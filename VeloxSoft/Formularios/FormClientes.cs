using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace VeloxSoft.Formularios
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        

            // Esto evita que parpadee al estirarse
            this.DoubleBuffered = true;

        }
        private void RedondearPanel(Panel p, PaintEventArgs e, int radio)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();

            // Restamos 1 al ancho y alto para que el borde (Pen) no se salga del área visible
            int w = p.Width - 1;
            int h = p.Height - 1;

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(w - radio, 0, radio, radio, 270, 90);
            path.AddArc(w - radio, h - radio, radio, radio, 0, 90);
            path.AddArc(0, h - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            p.Region = new Region(path);

            using (Pen pen = new Pen(ColorTranslator.FromHtml("#A4D1A5"), 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void RedondearBoton(Button btn, PaintEventArgs e, int radio)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Hace que el borde se vea suave

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radio, radio, 180, 90);
                path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
                path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
                path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
                path.CloseAllFigures();

                // Aplicamos la región redondeada al botón
                btn.Region = new Region(path);
            }
        }
        private void tlpFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNombre_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnDetallesC_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnDetallesC_Resize(object sender, EventArgs e)
        {
            pnDetallesC.Invalidate();
        }
    }
}
