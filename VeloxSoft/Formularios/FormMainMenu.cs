using FontAwesome.Sharp;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Converters;
using VeloxSoft.Formularios;

namespace VeloxSoft
{
    public partial class FormMainMenu : Form
    {

        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private IconPictureBox currentIcon;


        // Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // --- AGREGA ESTO PARA EL TAMAÑO ---
            // Ajusta estos números al ancho y alto total de tu diseño
            this.Size = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            // ----------------------------------

            // Configuración estética del Form
            this.Text = string.Empty;
            this.ControlBox = false; // Quita los botones cerrar/min/max estándar
            this.DoubleBuffered = true; // Evita el parpadeo al redimensionar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Disable the current button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.backColor1;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Change icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.BackColor = RGBColors.backColor1;
                iconCurrentChildForm.IconColor = color;
                // Change label current child form
                lblTitleChildForm.Text = currentBtn.Text;
                lblTitleChildForm.ForeColor = color;
                // Change background color panelTitleBar
                panelTitleBar.BackColor = RGBColors.backColor1;
                // Change background color Logo
                btnInicio.BackColor = RGBColors.backColor1;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = RGBColors.backColor1;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private struct RGBColors
        {
            // Colores personalizados para los botones seleccionados
            public static Color color1 = Color.FromArgb(16, 53, 34);
            public static Color color2 = Color.FromArgb(173, 171, 53);
            public static Color color3 = Color.FromArgb(243, 243, 233);
            public static Color color4 = Color.FromArgb(221, 62, 41);
            public static Color color5 = Color.FromArgb(155, 190, 171);
            public static Color color6 = Color.FromArgb(190, 169, 114);
            public static Color color7 = Color.FromArgb(1, 178, 126);
            // Color de fondo para los botones activos y cambio de color en otros elementos
            public static Color backColor1 = Color.FromArgb(191, 230, 99);
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(68, 154, 2);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUsuarios());
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClientes());
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGastos());
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInventario());
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVentas());
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCorte());
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCaja());
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.HomeUser;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            iconCurrentChildForm.BackColor = Color.FromArgb(68, 154, 2);

            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.ForeColor = Color.Gainsboro;

            panelTitleBar.BackColor = Color.FromArgb(68, 154, 2);

            btnInicio.BackColor = Color.FromArgb(68, 154, 2);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximixed_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                currentIcon = (IconPictureBox)sender;
                currentIcon.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                currentIcon = (IconPictureBox)sender;
                currentIcon.IconChar = IconChar.Maximize;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
