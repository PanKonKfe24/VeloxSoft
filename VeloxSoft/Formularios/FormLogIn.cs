using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace VeloxSoft.Formularios
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
            LabelSalir.BringToFront();
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
