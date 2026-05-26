using System;
using System.Collections.Generic;
using System.Text;

namespace VeloxSoft.Models
{
    public class DetallesVenta
    {
        public int IdDetalleVenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ImporteP { get; set; }
        public long NVenta { get; set; }       
        public string IdProd { get; set; }

        public Producto Producto { get; set; }
    }
}
