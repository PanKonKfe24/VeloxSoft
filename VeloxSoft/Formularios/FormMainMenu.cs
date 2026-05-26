using FontAwesome.Sharp;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Converters;
using VeloxSoft.Formularios;
using VeloxSoft.Services;

namespace VeloxSoft
{
    public partial class FormMainMenu : Form
    {
        private System.Windows.Forms.Timer _TimerActividad;
        private readonly ServicioInventario _ServicioInventario;
        private readonly ServicioUsuarios _ServicioUsuarios;
        private readonly ServicioClientes _ServicioClientes;
        private readonly ServicioVentas _ServicioVentas;
        private readonly ServicioCorte _ServicioCorte;
        private readonly ServicioGasto _ServicioGasto;
        private readonly ServicioCaja _ServicioCaja;
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private IconPictureBox currentIcon;

        // Campos para información del usuario
        private Panel _panelUsuario;
        private Label _lblNombreUsuario;
        private Label _lblRolUsuario;


        // Constructor
        public FormMainMenu(ServicioInventario ServicioInventario, ServicioUsuarios ServicioUsuarios, ServicioClientes ServicioClientes, ServicioVentas ServicioVentas, ServicioCorte ServicioCorte, ServicioGasto ServicioGasto, ServicioCaja ServicioCaja)
        {
            //Instancias de servicios
            _ServicioInventario = ServicioInventario;
            _ServicioUsuarios = ServicioUsuarios;
            _ServicioClientes = ServicioClientes;
            _ServicioVentas = ServicioVentas;
            _ServicioCorte = ServicioCorte;
            _ServicioGasto = ServicioGasto;
            _ServicioCaja = ServicioCaja;
            //Fin de Instancias de servicios
            InitializeComponent();
            InicializarPanelUsuario();


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // --- AGREGA ESTO PARA EL TAMAÑO ---
            // Ajusta estos números al ancho y alto total de tu diseño
            this.Size = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            // ----------------------------------


            // PANTALLA COMPLETA
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1100, 700);

            // IMPORTANTE
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.ResumeLayout(false);

            // Configuración estética del Form
            this.Text = string.Empty;
            this.ControlBox = false; // Quita los botones cerrar/min/max estándar
            this.DoubleBuffered = true; // Evita el parpadeo al redimensionar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;



        }

        private void InicializarPanelUsuario()
        {
            // Panel contenedor
            _panelUsuario = new Panel
            {
                BackColor = Color.FromArgb(15, 40, 30),
                Dock = DockStyle.Bottom,
                Height = 72,
                Padding = new Padding(12, 8, 12, 8)
            };

            // Icono
            Label lblIcono = new Label
            {
                Text = "👤",
                Font = new Font("Segoe UI Emoji", 18f),
                ForeColor = Color.White,
                Location = new Point(10, 14),
                Size = new Size(38, 38),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Nombre
            _lblNombreUsuario = new Label
            {
                Text = Program.UsuarioLogueado.Nombre,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(149, 213, 178),
                Location = new Point(54, 14),
                Size = new Size(180, 20),
                AutoEllipsis = true
            };

            // Rol
            _lblRolUsuario = new Label
            {
                Text = Program.UsuarioLogueado.Rol switch
                {
                    "0" => "Gerente",
                    "1" => "Administrador",
                    "2" => "Cajero",
                    _ => "Desconocido"
                },
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.FromArgb(100, 160, 130),
                Location = new Point(54, 36),
                Size = new Size(180, 18),
                AutoEllipsis = true
            };


            _panelUsuario.Controls.Add(lblIcono);
            _panelUsuario.Controls.Add(_lblNombreUsuario);
            _panelUsuario.Controls.Add(_lblRolUsuario);

            panelMenu.Controls.Add(_panelUsuario);

            // Mantenerlo al frente
            _panelUsuario.BringToFront();
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
            public static Color color1 = Color.FromArgb(27, 67, 50);     // Verde oscuro principal
            public static Color color2 = Color.FromArgb(82, 183, 136);   // Verde medio (Inventario)
            public static Color color3 = Color.FromArgb(247, 250, 248);  // Neutro claro (Clientes)
            public static Color color4 = Color.FromArgb(230, 57, 70);    // Rojo eliminar (Ventas)
            public static Color color5 = Color.FromArgb(45, 106, 79);    // Verde acento (Gastos)
            public static Color color6 = Color.FromArgb(149, 213, 178);  // Verde claro (Corte)
            public static Color color7 = Color.FromArgb(82, 183, 136);   // Verde medio (Caja)
            public static Color backColor1 = Color.FromArgb(27, 67, 50); // Fondo activo
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(45, 106, 79);  // era (68, 154, 2)
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUsuarios(_ServicioUsuarios));
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClientes(_ServicioClientes));
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGastos(_ServicioGasto));
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInventario(_ServicioInventario));
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVentas(_ServicioVentas));
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCorte(_ServicioCorte));
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCaja(_ServicioCaja));
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
            iconCurrentChildForm.BackColor = Color.FromArgb(45, 106, 79);  // era (68, 154, 2)

            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.ForeColor = Color.Gainsboro;

            panelTitleBar.BackColor = Color.FromArgb(45, 106, 79);  // era (68, 154, 2)

            btnInicio.BackColor = Color.FromArgb(45, 106, 79);  // era (68, 154, 2)
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
            _ServicioUsuarios.CerrarSesion(out string errorMessage);
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
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            IniciarTimer();
        }
        private void IniciarTimer()
        {
            _TimerActividad = new System.Windows.Forms.Timer();
            _TimerActividad.Interval = 1 * 30 * 1000; // 30 segundos
            _TimerActividad.Tick += (s, e) =>
            {
                _ServicioUsuarios.ActualizarActividad(Program.UsuarioLogueado.Id, out _);
            };
            _TimerActividad.Start();
        }
    }
    }

