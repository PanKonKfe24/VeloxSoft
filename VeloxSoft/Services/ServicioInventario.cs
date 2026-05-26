using Npgsql;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using VeloxSoft.Config;
using VeloxSoft.Models;

namespace VeloxSoft.Services
{
    public class ServicioInventario
    {
        private readonly DatabaseConfig _dbConfig;

        public ServicioInventario(DatabaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }


        public List<Producto> Ver_Productos(out String errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT p.id_producto, p.nombre, p.cantidad, p.precio, p.estado, c.nom_cat AS categoria
                      FROM tbl_producto p
                      INNER JOIN tbl_categoria c ON p.id_categoria = c.id_categoria
                      WHERE p.estado = true", conn);//CONSULTA SQL PARA OBTENER LOS PRODUCTOS ACTIVOS JUNTO CON SU CATEGORIA, SE UNE LA TABLA DE PRODUCTOS CON LA DE CATEGORIAS PARA OBTENER EL NOMBRE DE LA CATEGORIA
                //SI ESTA EN FALSE NO SE MUESTRA EN LA CONSULTA, SOLO LOS QUE ESTAN EN TRUE

                using var reader = cmd.ExecuteReader();//EJECUTA LA CONSULTA Y OBTIENE UN READER PARA LEER LOS RESULTADOS

                var lista_producto = new List<Producto>();//CREA UNA LISTA PARA ALMACENAR LOS PRODUCTOS OBTENIDOS DE LA CONSULTA


                while (reader.Read()) //LEE CADA REGISTRO OBTENIDO DE LA CONSULTA Y LO AGREGA A LA LISTA DE PRODUCTOS UNO POR UNO, SE OBTIENEN LOS CAMPOS DE LA CONSULTA Y SE ASIGNAN A LAS PROPIEDADES DEL OBJETO PRODUCTO
                {
                    lista_producto.Add(new Producto
                    {
                        IdProducto = reader.GetString(0), //EL ID DEL PRODUCTO SE OBTIENE DEL PRIMER CAMPO DE LA CONSULTA (INDEX 0)
                        Nombre = reader.GetString(1), //EL NOMBRE DEL PRODUCTO SE OBTIENE DEL SEGUNDO CAMPO DE LA CONSULTA (INDEX 1)
                        Cantidad = reader.GetDecimal(2), //LA CANTIDAD DEL PRODUCTO SE OBTIENE DEL TERCER CAMPO DE LA CONSULTA (INDEX 2)
                        Precio = reader.GetDecimal(3), //EL PRECIO DEL PRODUCTO SE OBTIENE DEL CUARTO CAMPO DE LA CONSULTA (INDEX 3)
                        Estado = reader.GetBoolean(4), //EL ESTADO DEL PRODUCTO SE OBTIENE DEL QUINTO CAMPO DE LA CONSULTA (INDEX 4), SI ESTA EN TRUE SE MUESTRA EN LA CONSULTA, SI ESTA EN FALSE NO SE MUESTRA 
                        IdCategoria = reader.GetString(5) //EL NOMBRE DE LA CATEGORIA SE OBTIENE
                    });

                }
                return lista_producto; // RETORNA LA LISTA DE PRODUCTOS OBTENIDOS DE LA CONSULTA
            }
            catch (PostgresException e) //SI OCURRE UN ERROR DE POSTGRESQL, SE CAPTURA LA EXCEPCION Y SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, Y SE RETORNA UNA LISTA VACIA DE PRODUCTOS
            {
                errorMessage = "Error inesperado"; //SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, SE PODRIA MEJORAR ESTE MENSAJE PARA QUE SEA MAS ESPECIFICO DEPENDIENDO DEL CODIGO DE ERROR DE POSTGRESQL
                return new List<Producto>(); //SE RETORNA UNA LISTA VACIA DE PRODUCTOS, SE PODRIA RETORNAR NULL O UNA EXCEPCION PERSONALIZADA DEPENDIENDO DE LA LOGICA DE NEGOCIO DE LA APLICACION
            }
            catch (Exception e) //SI OCURRE CUALQUIER OTRO TIPO DE EXCEPCION, SE CAPTURA Y SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, Y SE RETORNA UNA LISTA VACIA DE PRODUCTOS
            {
                errorMessage = "Error inesperado"; //SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, SE PODRIA MEJORAR ESTE MENSAJE PARA QUE SEA MAS ESPECIFICO DEPENDIENDO DEL CODIGO DE ERROR DE POSTGRESQL
                return new List<Producto>(); //SE RETORNA UNA LISTA VACIA DE PRODUCTOS, SE PODRIA RETORNAR NULL O UNA EXCEPCION PERSONALIZADA DEPENDIENDO DE LA LOGICA DE NEGOCIO DE LA APLICACION
            }
        }



        public string Insertar_Producto(string idProducto, string nombre, decimal cantidad, decimal precio, string idCategoria, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual)); //SE CREA UNA CONEXION A LA BASE DE DATOS UTILIZANDO LA CONFIGURACION DE LA BASE DE DATOS Y EL ROL ACTUAL DEL USUARIO LOGUEADO, SE UTILIZA EL METODO GetConnection DE LA CLASE DatabaseConfig PARA OBTENER LA CADENA DE CONEXION CORRESPONDIENTE AL ROL ACTUAL
                conn.Open();//

                using var cmd = new NpgsqlCommand("SELECT insertar_producto(@id, @nombre, @cantidad, @precio, @idCategoria)", conn);
                //SE CREA UN COMANDO PARA EJECUTAR LA FUNCION INSERTAR_PRODUCTO, SE PASAN LOS PARAMETROS NECESARIOS PARA LA FUNCION, SE UTILIZAN PARAMETROS EN LUGAR DE CONCATENAR LOS VALORES DIRECTAMENTE EN LA CONSULTA PARA EVITAR INYECCION SQL Y MEJORAR LA LEGIBILIDAD DEL CODIGO
                cmd.Parameters.AddWithValue("id", idProducto); //EL ID DEL PRODUCTO SE PASA COMO PARAMETRO A LA FUNCION INSERTAR_PRODUCTO, SE UTILIZA EL NOMBRE DEL PARAMETRO DEFINIDO EN LA FUNCION (ID) Y SE ASIGNA EL VALOR DE LA VARIABLE idProducto QUE SE RECIBE COMO PARAMETRO EN EL METODO Insertar_Producto
                cmd.Parameters.AddWithValue("nombre", nombre); //EL NOMBRE DEL PRODUCTO SE PASA COMO PARAMETRO A LA FUNCION INSERTAR_PRODUCTO, SE UTILIZA EL NOMBRE DEL PARAMETRO DEFINIDO EN LA FUNCION (NOMBRE) Y SE ASIGNA EL VALOR DE LA VARIABLE nombre QUE SE RECIBE COMO PARAMETRO EN EL METODO Insertar_Producto
                cmd.Parameters.AddWithValue("cantidad", cantidad); //LA CANTIDAD DEL PRODUCTO SE PASA COMO PARAMETRO A LA FUNCION INSERTAR_PRODUCTO, SE UTILIZA EL NOMBRE DEL PARAMETRO DEFINIDO EN LA FUNCION (CANTIDAD) Y SE ASIGNA EL VALOR DE LA VARIABLE cantidad QUE SE RECIBE COMO PARAMETRO EN EL METODO Insertar_Producto
                cmd.Parameters.AddWithValue("precio", precio);//EL PRECIO DEL PRODUCTO SE PASA COMO PARAMETRO A LA FUNCION INSERTAR_PRODUCTO, SE UTILIZA EL NOMBRE DEL PARAMETRO DEFINIDO EN LA FUNCION (PRECIO) Y SE ASIGNA EL VALOR DE LA VARIABLE precio QUE SE RECIBE COMO PARAMETRO EN EL METODO Insertar_Producto
                cmd.Parameters.AddWithValue("idCategoria", idCategoria);//EL ID DE LA CATEGORIA SE PASA COMO PARAMETRO A LA FUNCION INSERTAR_PRODUCTO, SE UTILIZA EL NOMBRE DEL PARAMETRO DEFINIDO EN LA FUNCION (IDCATEGORIA) Y SE ASIGNA EL VALOR DE LA VARIABLE idCategoria QUE SE RECIBE COMO PARAMETRO EN EL METODO Insertar_Producto

                string resultado = cmd.ExecuteScalar().ToString(); //EJECUTA LA CONSULTA Y OBTIENE EL RESULTADO DE LA FUNCION INSERTAR_PRODUCTO, SE CONVIERTE A STRING PARA RETORNARLO
                var parts = resultado.Split('|');

                if (parts[0] == "ERROR") //SI EL PRIMER ELEMENTO DEL RESULTADO ES "ERROR", SE ASIGNA EL SEGUNDO ELEMENTO DEL RESULTADO A LA VARIABLE errorMessage, Y SE RETORNA EL SEGUNDO ELEMENTO DEL RESULT
                {
                    errorMessage = parts[1]; //SE ASIGNA EL SEGUNDO ELEMENTO DEL RESULTADO A LA VARIABLE errorMessage
                }
                return parts[1]; //SE RETORNA EL SEGUNDO ELEMENTO DEL RESULTADO, SI EL PRIMER ELEMENTO ES "ERROR" SE RETORNA EL MENSAJE DE ERROR, SI EL PRIMER ELEMENTO NO ES "ERROR" SE RETORNA EL MENSAJE DE EXITO O CUALQUIER OTRO MENSAJE QUE LA FUNCION INSERTAR_PRODUCTO PUEDA RETORNAR
            }
            catch (PostgresException e) //SI OCURRE UN ERROR DE POSTGRESQL, SE CAPTURA LA EXCEPCION
            {
                return errorMessage = "Error de base de datos: "; //ERROR PARA SPLIT 
            }
            catch (Exception e)//SI OCURRE CUALQUIER OTRO TIPO DE EXCEPCION, SE CAPTURA
            {
                return errorMessage = "Error inesperado: "; //ERROR PARA SPLIT
            }
        }

        public void Eliminar_Producto(string idProducto, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                using var cmd = new NpgsqlCommand("UPDATE tbl_producto SET estado = false WHERE id_producto = @id", conn);
                cmd.Parameters.AddWithValue("id", idProducto);

                int filasAfectadas = cmd.ExecuteNonQuery(); //EJECUTA LA CONSULTA Y OBTIENE EL NUMERO DE FILAS AFECTADAS, SI EL NUMERO DE FILAS AFECTADAS ES 0, SIGNIFICA QUE NO SE ENCONTRO EL PRODUCTO CON EL ID PROPORCIONADO, SE ASIGNA UN MENSAJE DE ERROR

                if (filasAfectadas == 0)
                {
                    errorMessage = "No se encontró el producto con el ID proporcionado."; //SE ASIGNA UN MENSAJE DE ERROR SI NO SE ENCONTRO EL PRODUCTO CON EL ID PROPORCIONADO
                }



            }
            catch (PostgresException e)
            {
                errorMessage = "Error inesperado";
            }
            catch (Exception e)
            {
                errorMessage = "Error de base de datos";
            }

        }

        public List<Producto> Buscar_Productos(string id, string categoria, string estado, out string errorMessage)
        {
            
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                string query = @"SELECT p.id_producto, p.nombre, p.cantidad, p.precio, p.estado, c.nom_cat
                      FROM tbl_producto p
                      INNER JOIN tbl_categoria c ON p.id_categoria = c.id_categoria
                      WHERE 1=1"; //CONSULTA SQL PARA OBTENER LOS PRODUCTOS JUNTO CON SU CATEGORIA, SE UNE LA TABLA DE PRODUCTOS CON LA DE CATEGORIAS PARA OBTENER EL NOMBRE DE LA CATEGORIA, SE UTILIZA "WHERE 1=1" PARA FACILITAR LA CONCATENACION DE CONDICIONES EN LA CONSULTA

                using var cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                // Agregamos condiciones solo si tienen valor
                if (!string.IsNullOrEmpty(id)) //si id tiene algo
                {
                    query += " AND p.id_producto = @id"; //añadimos a la consulta estructurada lo que hay en id 
                    cmd.Parameters.AddWithValue("id", id); // enviamos ID como parametro para evitar inyeccion SQL

                    // Ignorar categoria y estado
                    cmd.CommandText = query;
                    // Saltar al ejecutar directo
                }
                else
                {
                    if (!string.IsNullOrEmpty(categoria))// si categoria tiene algo
                    {
                        string categoriaBD = categoria == "Pieza" ? "PZ" : "KL"; // si categoriaBD = categoria y este es = "Pieza" ? entonces es "PZ" : si no "KL"
                        query += " AND p.id_categoria = @categoria"; //Añadimos lo que nos dio de resultado en categoria
                        cmd.Parameters.AddWithValue("categoria", categoriaBD); // enviamos categoriaBD como parametro para evitar inyeccion SQL
                    }

                    if (string.IsNullOrEmpty(estado)) // Si esta vacio no se filtra por estado, se muestran todos los productos que tengan estado en true
                    {
                        query += " AND p.estado = true";
                    }
                    else
                    {
                        bool estadoBool = estado == "Activo"; // Asignamos un valor booleano a estadoBool dependiendo de si estado es igual a "Activo" o no, si estado es igual a "Activo" entonces estadoBool es true, si no es igual a "Activo" entonces estadoBool es false
                        query += " AND p.estado = @estado"; // Añadimos a la consulta estructurada lo que hay en estado, se filtra por estado dependiendo del valor de estadoBool, si estadoBool es true se muestran los productos con estado en true, si estadoBool es false se muestran los productos con estado en false
                        cmd.Parameters.AddWithValue("estado", estadoBool); // enviamos el estadoBool para añadirlo a la consulta.
                    }

                    cmd.CommandText = query; //Ejecutamos la consulta estructurada con las condiciones añadidas dependiendo de los parametros recibidos, se asigna la consulta estructurada a CommandText del comando para que se ejecute correctamente
                }
                using var reader = cmd.ExecuteReader(); // EJECUTA LA CONSULTA Y OBTIENE UN READER PARA LEER LOS RESULTADOS, se ejecuta la consulta con las condiciones añadidas dependiendo de los parametros recibidos, se obtiene un reader para leer los resultados de la consulta
                var lista = new List<Producto>(); // Lista de productos filtrados, se crea una lista para almacenar los productos obtenidos de la consulta con las condiciones añadidas dependiendo de los parametros recibidos

                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        IdProducto = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Cantidad = reader.GetDecimal(2),
                        Precio = reader.GetDecimal(3),
                        Estado = reader.GetBoolean(4),
                        IdCategoria = reader.GetString(5)
                    });
                }

                return lista; // retorna la lista de productos obtenidos de la consulta con las condiciones añadidas dependiendo de los parametros recibidos, se retorna una lista vacia si no se encontraron productos que cumplan con las condiciones añadidas dependiendo de los parametros recibidos
            }
            catch (PostgresException e)
            {
                errorMessage = "Error de base de datos.";
                return new List<Producto>();
            }
            catch (Exception e)
            {
                errorMessage = "Error inesperado.";
                return new List<Producto>();
            }

        }

        public string Actualizar_Producto(string idProducto, string nombre, decimal cantidad, decimal precio, string idCategoria, bool estado, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();

                using var cmd = new NpgsqlCommand("SELECT actualizar_producto(@id, @nombre, @cantidad, @precio, @idCategoria, @estado)", conn);  //llamada a la funcion actualizar_producto, se pasan los parametros necesarios para la funcion, se utilizan parametros en lugar de concatenar los valores directamente en la consulta para evitar inyeccion SQL y mejorar la legibilidad del codigo
                cmd.Parameters.AddWithValue("id", idProducto); //id 
                cmd.Parameters.AddWithValue("nombre", nombre); //Nombre
                cmd.Parameters.AddWithValue("cantidad", cantidad);//Cantidad
                cmd.Parameters.AddWithValue("precio", precio);//Precio
                cmd.Parameters.AddWithValue("idCategoria", idCategoria); //Categoria
                cmd.Parameters.AddWithValue("estado", estado); //Estado

                string resultado = cmd.ExecuteScalar().ToString(); //EJECUTA LA CONSULTA Y OBTIENE EL RESULTADO DE LA FUNCION ACTUALIZAR_PRODUCTO, SE CONVIERTE A STRING PARA RETORNARLO
                var parts = resultado.Split('|'); //SEPARA EL RESULTADO DE LA FUNCION ACTUALIZAR_PRODUCTO EN PARTES UTILIZANDO EL CARACTER "|" COMO SEPARADOR, SE ASUME QUE LA FUNCION ACTUALIZAR_PRODUCTO RETORNA UN STRING CON EL FORMATO "RESULTADO|MENSAJE", DONDE RESULTADO PUEDE SER "ERROR" O "EXITO" Y MENSAJE PUEDE SER UN MENSAJE DE ERROR O UN MENSAJE DE EXITO DEPENDIENDO DEL RESULTADO

                if (parts[0] == "ERROR") //SI EL PRIMER ELEMENTO DEL RESULTADO ES "ERROR", SE ASIGNA EL SEGUNDO ELEMENTO DEL RESULTADO A LA VARIABLE errorMessage, Y SE RETORNA EL SEGUNDO ELEMENTO DEL RESULTADO
                {
                    errorMessage = parts[1];//SE ASIGNA EL SEGUNDO ELEMENTO DEL RESULTADO A LA VARIABLE errorMessage, SE ASUME QUE EL SEGUNDO ELEMENTO DEL RESULTADO CONTIENE UN MENSAJE DE ERROR DESCRIPTIVO QUE EXPLICA LA RAZON DEL ERROR, SE RETORNA EL SEGUNDO ELEMENTO DEL RESULTADO PARA QUE PUEDA SER MOSTRADO AL USUARIO O UTILIZADO EN LA LOGICA DE NEGOCIO DE LA APLICACION
                }

                return parts[1];//SE RETORNA EL SEGUNDO ELEMENTO DEL RESULTADO, SI EL PRIMER ELEMENTO ES "ERROR" SE RETORNA EL MENSAJE DE ERROR, SI EL PRIMER ELEMENTO NO ES "ERROR" SE RETORNA EL MENSAJE DE EXITO O CUALQUIER OTRO MENSAJE QUE LA FUNCION ACTUALIZAR_PRODUCTO PUEDA RETORNAR, SE ASUME QUE LA FUNCION ACTUALIZAR_PRODUCTO RETORNA UN STRING CON EL FORMATO "RESULTADO|MENSAJE", DONDE RESULTADO PUEDE SER "ERROR" O "EXITO" Y MENSAJE PUEDE SER UN MENSAJE DE ERROR O UN MENSAJE DE EXITO DEPENDIENDO DEL RESULTADO
            }
            catch (PostgresException e)
            {
                return errorMessage = "Error de base de datos.";
            }
            catch (Exception e)
            {
                return errorMessage = "Error inesperado.";
            }
        }
    }
}
