using System;
using System.Collections.Generic;
using System.Text;

namespace VeloxSoft.Models
{
    public class ProductoCatalogo
    {
        public string Id { get; set; } = "";
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public string UnidadVenta { get; set; } = "pza";
    }

    public class ProductoCarrito
    {
        public string Id { get; set; } = "";
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public string Unidad { get; set; } = "pza";
        public decimal Cantidad { get; set; }
        public decimal Subtotal => Precio * Cantidad;
    }

    public class UsuarioCatalogo
    {
        public string Id { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Telefono { get; set; } = "";
    }

}

