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
    public partial class FormUsuarios : Form
    {
        Dictionary<string, (string Nombre, string Rol)> usuariosSimulados = new Dictionary<string, (string, string)>
        {
            { "101", ("ARMANDO", "Administrador") },
            { "102", ("JUAN PABLO", "Operador") },
            { "103", ("ARGEL", "Ventas") },
            { "104", ("GILBERT", "Ventas") }
        };

        public FormUsuarios()
        {
            InitializeComponent();
            this.Size = new Size(1300, 750);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Esto es CLAVE: hace que el formulario se estire para llenar el panel gris
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDetalles_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(pnlDetalles, e, 30);
        }

        private void pnlLista_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(pnlLista, e, 30);
        }
        //BORDES REDONDOS PARA LOS PANEL, SOLO LO LLAMAMOS EN LOS EVENTOS PAINT DE LOS PANEL, ASÍ SE DIBUJAN LOS BORDES CUANDO SE REDIMENSIONA LA VENTANA
        private void RedondearPanel(Panel p, PaintEventArgs e, int radio)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();

            // Dibujamos el camino de las esquinas
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(p.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(p.Width - radio, p.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, p.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            // Aplicamos la forma al panel para que sea "físicamente" redondo
            p.Region = new Region(path);

            // Dibuja un borde sutil con el verde #A4D1A5 de tu paleta Fruit Salad
            // Esto hace que el cuadro resalte sobre el fondo verde oscuro
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

        private void btnNuevo_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnNuevo, e, 15); // Un radio de 20 le da ese toque moderno
        }

        private void btnGuardar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnGuardar, e, 15); // Un radio de 20 le da ese toque moderno
        }

        private void btnEliminar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnEliminar, e, 15); // Un radio de 20 le da ese toque moderno
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = txtID.Text;

                if (usuariosSimulados.ContainsKey(id))
                {
                    // Autorellenar campos (Asegúrate de que estos nombres coincidan con tus TextBox)
                    txtNombre.Text = usuariosSimulados[id].Nombre; // Nombre
                    txtRol.Text = usuariosSimulados[id].Rol;    // Rol

                    // Feedback visual en el panel contenedor del ID
                    if (pnlContenedorID != null)
                        pnlContenedorID.BackColor = Color.FromArgb(210, 235, 210);
                }
                // Verificamos si la tecla presionada es Enter
                if (e.KeyCode == Keys.Enter)
                {
                    // Ejecutamos la función del botón de buscar
                    btnBuscar_Click(this, new EventArgs());

                    // Esto evita que suene el "beep" de Windows al presionar Enter
                    e.SuppressKeyPress = true;
                }
                else
                {
                    MessageBox.Show("ID no encontrado en el sistema.", "VeloxSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Clear();
                    txtRol.Clear();
                }

                e.SuppressKeyPress = true; // Quita el sonido de "beep"
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // 1. Obtener el ID del TextBox (Asegúrate que se llame txtID o textBoxID)
            string idBuscado = txtID.Text;

            // 2. Validar que no esté vacío
            if (!string.IsNullOrEmpty(idBuscado))
            {
                // 3. BUSCAR en nuestro diccionario simulado (usuariosSimulados)
                if (usuariosSimulados.ContainsKey(idBuscado))
                {
                    MessageBox.Show("Encontrado: " + usuariosSimulados[idBuscado].Nombre);
                    // 4. AUTO-RELLENAR los campos con los datos del diccionario
                    txtNombre.Text = usuariosSimulados[idBuscado].Nombre;
                    txtRol.Text = usuariosSimulados[idBuscado].Rol;

                    // Cambiar color a verde éxito
                    pnlContenedorID.BackColor = Color.FromArgb(230, 255, 230);
                }
                else
                {
                    // 5. Si no existe, avisar al usuario
                    MessageBox.Show("Usuario no encontrado en VeloxSoft", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtRol.Clear();
                }

                {
                    pnlContenedorID.BackColor = Color.White; // Volver a blanco si falla
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID para buscar.", "VeloxSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBuscar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnBuscar, e, 15);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlContenedorID_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void txtRol_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pnlNombre_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlRol_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }
    }


}
