using Npgsql;
using System;
using System.Collections.Generic;
using VeloxSoft.Config;
using VeloxSoft.Models;

namespace VeloxSoft.Services
{
    public class ServicioCaja
    {
        private readonly DatabaseConfig _dbConfig;

        public ServicioCaja(DatabaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public List<Producto> BuscarProductos(string filtro, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                using var cmd = new NpgsqlCommand(@"
                    SELECT id_producto, nombre, cantidad, precio, id_categoria
                    FROM tbl_producto
                    WHERE estado = true
                      AND cantidad > 0
                      AND (
                          CAST(id_producto AS TEXT) ILIKE @filtro
                          OR nombre ILIKE @filtro
                      )
                    ORDER BY nombre
                    LIMIT 10
                ", conn);

                cmd.Parameters.AddWithValue("filtro", $"%{filtro}%");

                using var reader = cmd.ExecuteReader();
                var lista = new List<Producto>();

                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        IdProducto = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Cantidad = reader.GetDecimal(2),
                        Precio = reader.GetDecimal(3),
                        IdCategoria = reader.GetString(4)
                    });
                }

                return lista;
            }
            catch (PostgresException)
            {
                errorMessage = "Error inesperado PG.";
                return new List<Producto>();
            }
            catch (Exception)
            {
                errorMessage = "Error inesperado G.";
                return new List<Producto>();
            }
        }

        public List<Cliente> BuscarUsuarios(string filtro, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                using var cmd = new NpgsqlCommand(@"
                SELECT id_cel, nombre
                FROM tbl_cliente
                WHERE nombre ILIKE @filtro
                      OR CAST(id_cel AS TEXT) ILIKE @filtro
                ORDER BY nombre
                LIMIT 10", conn);

                cmd.Parameters.AddWithValue("filtro", $"%{filtro}%");

                using var reader = cmd.ExecuteReader();
                var lista = new List<Cliente>();

                while (reader.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = reader.GetInt64(0),
                        Nombre = reader.GetString(1),
                    });
                }

                return lista;
            }
            catch (PostgresException)
            {
                errorMessage = "Error inesperado PG.";
                return new List<Cliente>();
            }
            catch (Exception)
            {
                errorMessage = "Error inesperado G.";
                return new List<Cliente>();
            }
        }

        public List<(string Id, string Tipo)> Ver_MetodosPago(out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                using var cmd = new NpgsqlCommand(
                    "SELECT id_pago, tipo_pago FROM tbl_pago ORDER BY tipo_pago", conn);

                using var reader = cmd.ExecuteReader();
                var lista = new List<(string, string)>();

                while (reader.Read())
                    lista.Add((reader.GetString(0), reader.GetString(1)));

                return lista;
            }
            catch (PostgresException)
            {
                errorMessage = "Error inesperado PG.";
                return new List<(string, string)>();
            }
            catch (Exception)
            {
                errorMessage = "Error inesperado G.";
                return new List<(string, string)>();
            }
        }

        public void Insertar_Venta(List<ProductoCarrito> Compras, decimal cantidadTotal, decimal totalPagar, long cliente, long usuario, string pago, string estado, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                using var transaction = conn.BeginTransaction();

                DateOnly idFecha;


                using (var cmdBuscarFecha = new NpgsqlCommand(@"
                    SELECT id_fecha
                    FROM tbl_fecha
                    WHERE id_fecha = CURRENT_DATE
                ", conn, transaction))
                {
                    var resultado = cmdBuscarFecha.ExecuteScalar();

                    if (resultado != null)
                    {
                        idFecha = (DateOnly)resultado;
                    }
                    else
                    {
                        // Crear fecha nueva
                        using var cmdInsertarFecha = new NpgsqlCommand(@"
                            INSERT INTO tbl_fecha (id_fecha, dia, mes, anio)
                            VALUES (
                                CURRENT_DATE,
                                TO_CHAR(CURRENT_DATE, 'DD'),
                                TO_CHAR(CURRENT_DATE, 'MM'),
                                TO_CHAR(CURRENT_DATE, 'YYYY')
                            )
                            RETURNING id_fecha
                        ", conn, transaction);
                        idFecha = (DateOnly)cmdInsertarFecha.ExecuteScalar();
                    }
                }



                using var cmd = new NpgsqlCommand(
                    "INSERT INTO tbl_venta (cantidad, importe_g, fecha, num_cel, tipo_pago, tipo_estado, id_usuario) VALUES (@cantidad, @importe_g, @fecha, @num_cel, @tipo_pago, @tipo_estado, @id_usuario) RETURNING id_venta", conn, transaction);

                string IdPago = pago switch
                {
                    "Efectivo" => "EF",
                    "Transferencia" => "TR",
                    "Tarjeta" => "TA",
                    _ => "Desconocido"
                };

                string IdEstado = estado switch
                {
                    "Entregado" => "EN",
                    "Cancelado" => "CA",
                    "Pendiente" => "PE",
                    _ => "Desconocido"
                };

                cmd.Parameters.AddWithValue("cantidad", cantidadTotal);
                cmd.Parameters.AddWithValue("importe_g", totalPagar);
                cmd.Parameters.AddWithValue("fecha", idFecha);
                cmd.Parameters.AddWithValue("num_cel", cliente);
                cmd.Parameters.AddWithValue("tipo_pago", IdPago);
                cmd.Parameters.AddWithValue("tipo_estado", IdEstado);
                cmd.Parameters.AddWithValue("id_usuario", usuario);
               
                long idVenta = Convert.ToInt64(cmd.ExecuteScalar());

                foreach (var producto in Compras)
                {
                    using var cmdDetalle = new NpgsqlCommand(@"
                        INSERT INTO tbl_detalle_ventas
                        (
                            cantidad,
                            importe_p,
                            nventa,
                            idprod
                        )
                        VALUES
                        (
                            @cantidad,
                            @importe,
                            @nventa,
                            @idprod
                        )
                    ", conn, transaction);

                    cmdDetalle.Parameters.AddWithValue("cantidad", producto.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("importe", producto.Subtotal);
                    cmdDetalle.Parameters.AddWithValue("nventa", idVenta);
                    cmdDetalle.Parameters.AddWithValue("idprod", producto.Id);

                    cmdDetalle.ExecuteNonQuery();

                    using var cmdActualizarInventario = new NpgsqlCommand(@"
                        UPDATE tbl_producto
                        SET cantidad = cantidad - @cantidadComprada
                        WHERE id_producto = @idProducto
                    ", conn, transaction);

                    cmdActualizarInventario.Parameters.AddWithValue("cantidadComprada",producto.Cantidad);
                    cmdActualizarInventario.Parameters.AddWithValue("idProducto",producto.Id);
                    cmdActualizarInventario.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (PostgresException)
            {
                errorMessage = $"Error inesperado PG.";
            }
            catch (Exception)
            {
                errorMessage = $"Error inesperado G.";
            }
        }
    }
}