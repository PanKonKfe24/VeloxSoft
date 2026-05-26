using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VeloxSoft.Models;
using VeloxSoft.Services;

namespace VeloxSoft.Formularios
{
    public partial class FormDetallesVentas : Form
    {
        private readonly ServicioVentas _ServicioVentas;
        public FormDetallesVentas(string idVenta, string cliente, string fecha, ServicioVentas servicioVentas)
        {
            InitializeComponent();
            _ServicioVentas = servicioVentas;
            lblInfo.Text = $"Detalle de N° Venta: {idVenta} \nN° Cliente: {cliente}, Fecha: {fecha}";
            CargarDatos(idVenta);
        }

        private void CargarDatos(string idVenta)
        {
            long idVentaLong = long.Parse(idVenta);
            List<DetallesVenta> detalles = _ServicioVentas.ObtenerDetalles(idVentaLong, out string errorMessage);
            dgvDetalles.Rows.Clear();
            foreach (var detalle in detalles)
            {
                dgvDetalles.Rows.Add(
                    detalle.IdProd,
                    detalle.Producto.Nombre,
                    $"${detalle.Producto.Precio.ToString("F2")}",
                    detalle.Cantidad.ToString("F2"),
                    $"${detalle.ImporteP.ToString("F2")}"
                );
            }
        }
    }



}
