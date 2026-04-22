using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VeloxSoft.Services;
using VeloxSoft.Config;
using VeloxSoft.Models;

namespace VeloxSoft.Formularios
{
    public partial class FormLogIn : Form
    {
        private readonly AutenticarUsuario _autenticarUsuario;

        public FormLogIn(AutenticarUsuario autenticarUsuario)
        {
            InitializeComponent();
            LabelSalir.BringToFront();
            _autenticarUsuario = autenticarUsuario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void NavPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void LabelLimpiar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtPassword.Clear();
            TxtUsuario.Focus();
        }

        private void LabelSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread(); // Detiene el hilo actual
            Application.Exit();       // Envía la señal de cierre a la app
        }

        private void LabelSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string errorMessage;
            string Id = TxtUsuario.Text;
            string Password = TxtPassword.Text;
            MessageBox.Show("Se dio click en el boton", "Click");
            if (Id != string.Empty && Password != string.Empty)
            {
                usuario = _autenticarUsuario.Autenticar(Id, Password, out errorMessage);
            }


            if (usuario.Nombre != "Error")
            {
                MessageBox.Show("Inicio ", "ta bn");
                Program.UsuarioLogueado = usuario;
                Program.RolActual = ObtenerRolEnum.ObtenerRol(usuario.Rol);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void NavPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
