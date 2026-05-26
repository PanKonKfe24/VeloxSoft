using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using VeloxSoft.Config;
using VeloxSoft.Models;

namespace VeloxSoft.Services
{
    public class ServicioVentas
    {
        private readonly DatabaseConfig _dbConfig;

        public ServicioVentas(DatabaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public List<Venta> Buscar_Ventas(string nVenta, string nCliente, string estado, string fechaInicio, string fechaFin, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                string query = @"
                                SELECT 
                                    v.id_venta, v.cantidad, v.importe_g, v.fecha,
                                    v.num_cel, tp.tipo_pago, te.tipo_estado,
                                    v.id_corte, v.id_usuario
                                FROM tbl_venta v
                                INNER JOIN tbl_pago tp ON tp.id_pago = v.tipo_pago
                                INNER JOIN tbl_estado te ON te.id_estado = v.tipo_estado
                                WHERE 1=1";

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                // N° VENTA
                if (!string.IsNullOrEmpty(nVenta))
                {
                    query += " AND v.id_venta = @nVenta";
                    cmd.Parameters.AddWithValue("nVenta", long.Parse(nVenta));
                }

                // N° CLIENTE
                if (!string.IsNullOrEmpty(nCliente))
                {
                    query += " AND v.num_cel = @nCliente";
                    cmd.Parameters.AddWithValue("nCliente", long.Parse(nCliente));
                }

                // ESTADO
                if (!string.IsNullOrEmpty(estado) && estado != "Todos")
                {
                    string idEstado = estado switch
                    {
                        "Entregado" => "EN",
                        "Pendiente" => "PE",
                        "Cancelado" => "CA",
                        _ => null
                    };

                    if (idEstado != null)
                    {
                        query += " AND v.tipo_estado = @estado";
                        cmd.Parameters.AddWithValue("estado", idEstado);
                    }
                }

                // RANGO DE FECHAS
                if (!string.IsNullOrEmpty(fechaInicio) && !string.IsNullOrEmpty(fechaFin))
                {
                    query += " AND v.fecha BETWEEN @fechaInicio AND @fechaFin";
                    cmd.Parameters.AddWithValue("fechaInicio", DateOnly.Parse(fechaInicio));
                    cmd.Parameters.AddWithValue("fechaFin", DateOnly.Parse(fechaFin));
                }
                else if (!string.IsNullOrEmpty(fechaInicio))
                {
                    query += " AND v.fecha >= @fechaInicio";
                    cmd.Parameters.AddWithValue("fechaInicio", DateOnly.Parse(fechaInicio));
                }
                else if (!string.IsNullOrEmpty(fechaFin))
                {
                    query += " AND v.fecha <= @fechaFin";
                    cmd.Parameters.AddWithValue("fechaFin", DateOnly.Parse(fechaFin));
                }

                cmd.CommandText = query;
                using var reader = cmd.ExecuteReader();
                var ListaVentas = new List<Venta>();

                while (reader.Read())
                {
                    ListaVentas.Add(new Venta
                    {
                        IdVenta = reader.GetInt64(0),
                        Cantidad = reader.GetDecimal(1),
                        Importe = reader.GetDecimal(2),
                        Fecha = reader.GetFieldValue<DateOnly>(3),
                        NumCel = reader.GetInt64(4),
                        TipoDePago = reader.GetString(5),
                        Estado = reader.GetString(6),
                        IdCorte = reader.IsDBNull(7) ? null : reader.GetInt64(7),
                        IdUsuario = reader.GetInt64(8)
                    });
                }

                return ListaVentas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                errorMessage = "Error Inesperado";
                return new List<Venta>();
            }
        }

        public List<DetallesVenta> ObtenerDetalles(long idVenta, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                string query = @"SELECT 
                                    dv.id_detalle_venta,
                                    dv.cantidad,
                                    dv.importe_p,
                                    dv.nventa,
                                    dv.idprod,
                                    p.nombre,
                                    p.precio,
                                    p.id_categoria
                                FROM tbl_detalle_ventas dv
                                INNER JOIN tbl_producto p ON p.id_producto = dv.idprod
                                WHERE dv.nventa = @idVenta";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("idVenta", idVenta);

                using var reader = cmd.ExecuteReader();
                var Detalleslista = new List<DetallesVenta>();

                while (reader.Read())
                {
                    Detalleslista.Add(new DetallesVenta
                    {
                        IdDetalleVenta = reader.GetInt32(0),
                        Cantidad = reader.GetDecimal(1),
                        ImporteP = reader.GetDecimal(2),
                        NVenta = reader.GetInt64(3),
                        IdProd = reader.GetString(4),

                        Producto = new Producto
                        {
                            IdProducto = reader.GetString(4),
                            Nombre = reader.GetString(5),
                            Precio = reader.GetDecimal(6),
                            IdCategoria = reader.GetString(7)
                        }
                    });
                }

                return Detalleslista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                errorMessage = "Error Inesperado";
                return new List<DetallesVenta>();
            }
        }
        public bool Actualizar_Estado(long idVenta, string idEstado, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                string query = "UPDATE tbl_venta SET tipo_estado = @idEstado WHERE id_venta = @idVenta";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("idEstado", idEstado);
                cmd.Parameters.AddWithValue("idVenta", idVenta);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                errorMessage = "Error Inesperado";
                return false;
            }
        }
    }
}