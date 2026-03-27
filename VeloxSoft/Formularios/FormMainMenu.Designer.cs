namespace VeloxSoft
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnCaja = new FontAwesome.Sharp.IconButton();
            btnCorte = new FontAwesome.Sharp.IconButton();
            btnGastos = new FontAwesome.Sharp.IconButton();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnInicio = new PictureBox();
            panelTitleBar = new Panel();
            btnMaximixed = new FontAwesome.Sharp.IconPictureBox();
            btnMinus = new FontAwesome.Sharp.IconPictureBox();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            lblLogoDesktop = new PictureBox();
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximixed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblLogoDesktop).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(68, 154, 2);
            panelMenu.Controls.Add(btnCaja);
            panelMenu.Controls.Add(btnCorte);
            panelMenu.Controls.Add(btnGastos);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(192, 453);
            panelMenu.TabIndex = 0;
            // 
            // btnCaja
            // 
            btnCaja.BackColor = Color.FromArgb(68, 154, 2);
            btnCaja.Dock = DockStyle.Top;
            btnCaja.FlatAppearance.BorderSize = 0;
            btnCaja.FlatStyle = FlatStyle.Flat;
            btnCaja.Font = new Font("Segoe UI", 12F);
            btnCaja.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnCaja.IconColor = Color.Black;
            btnCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaja.Location = new Point(0, 375);
            btnCaja.Margin = new Padding(3, 2, 3, 2);
            btnCaja.Name = "btnCaja";
            btnCaja.Padding = new Padding(9, 0, 18, 0);
            btnCaja.Size = new Size(192, 45);
            btnCaja.TabIndex = 7;
            btnCaja.Text = "Caja";
            btnCaja.TextAlign = ContentAlignment.MiddleLeft;
            btnCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += btnCaja_Click;
            // 
            // btnCorte
            // 
            btnCorte.BackColor = Color.FromArgb(68, 154, 2);
            btnCorte.Dock = DockStyle.Top;
            btnCorte.FlatAppearance.BorderSize = 0;
            btnCorte.FlatStyle = FlatStyle.Flat;
            btnCorte.Font = new Font("Segoe UI", 12F);
            btnCorte.IconChar = FontAwesome.Sharp.IconChar.Scissors;
            btnCorte.IconColor = Color.Black;
            btnCorte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCorte.ImageAlign = ContentAlignment.MiddleLeft;
            btnCorte.Location = new Point(0, 330);
            btnCorte.Margin = new Padding(3, 2, 3, 2);
            btnCorte.Name = "btnCorte";
            btnCorte.Padding = new Padding(9, 0, 18, 0);
            btnCorte.Size = new Size(192, 45);
            btnCorte.TabIndex = 6;
            btnCorte.Text = "Corte";
            btnCorte.TextAlign = ContentAlignment.MiddleLeft;
            btnCorte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorte.UseVisualStyleBackColor = true;
            btnCorte.Click += btnCorte_Click;
            // 
            // btnGastos
            // 
            btnGastos.BackColor = Color.FromArgb(68, 154, 2);
            btnGastos.Dock = DockStyle.Top;
            btnGastos.FlatAppearance.BorderSize = 0;
            btnGastos.FlatStyle = FlatStyle.Flat;
            btnGastos.Font = new Font("Segoe UI", 12F);
            btnGastos.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            btnGastos.IconColor = Color.Black;
            btnGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGastos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGastos.Location = new Point(0, 285);
            btnGastos.Margin = new Padding(3, 2, 3, 2);
            btnGastos.Name = "btnGastos";
            btnGastos.Padding = new Padding(9, 0, 18, 0);
            btnGastos.Size = new Size(192, 45);
            btnGastos.TabIndex = 5;
            btnGastos.Text = "Gastos";
            btnGastos.TextAlign = ContentAlignment.MiddleLeft;
            btnGastos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGastos.UseVisualStyleBackColor = true;
            btnGastos.Click += btnGastos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(68, 154, 2);
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 12F);
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnVentas.IconColor = Color.Black;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 240);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(9, 0, 18, 0);
            btnVentas.Size = new Size(192, 45);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(68, 154, 2);
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F);
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnClientes.IconColor = Color.Black;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 195);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(9, 0, 18, 0);
            btnClientes.Size = new Size(192, 45);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(68, 154, 2);
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 12F);
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            btnInventario.IconColor = Color.Black;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 150);
            btnInventario.Margin = new Padding(3, 2, 3, 2);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(9, 0, 18, 0);
            btnInventario.Size = new Size(192, 45);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(68, 154, 2);
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 105);
            btnUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(9, 0, 18, 0);
            btnUsuarios.Size = new Size(192, 45);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(68, 154, 2);
            panelLogo.Controls.Add(btnInicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(9, 0, 18, 0);
            panelLogo.Size = new Size(192, 105);
            panelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(68, 154, 2);
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(-11, -9);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(216, 134);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(68, 154, 2);
            panelTitleBar.Controls.Add(btnMaximixed);
            panelTitleBar.Controls.Add(btnMinus);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(192, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(661, 57);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMaximixed
            // 
            btnMaximixed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximixed.BackColor = Color.Transparent;
            btnMaximixed.BackgroundImageLayout = ImageLayout.None;
            btnMaximixed.Cursor = Cursors.SizeAll;
            btnMaximixed.ForeColor = Color.DarkBlue;
            btnMaximixed.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMaximixed.IconColor = Color.DarkBlue;
            btnMaximixed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximixed.IconSize = 25;
            btnMaximixed.Location = new Point(606, -2);
            btnMaximixed.Margin = new Padding(3, 2, 3, 2);
            btnMaximixed.Name = "btnMaximixed";
            btnMaximixed.Size = new Size(29, 25);
            btnMaximixed.TabIndex = 4;
            btnMaximixed.TabStop = false;
            btnMaximixed.Click += btnMaximixed_Click;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinus.BackColor = Color.Transparent;
            btnMinus.BackgroundImageLayout = ImageLayout.None;
            btnMinus.Cursor = Cursors.Hand;
            btnMinus.ForeColor = Color.Sienna;
            btnMinus.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            btnMinus.IconColor = Color.Sienna;
            btnMinus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMinus.IconSize = 26;
            btnMinus.Location = new Point(578, -2);
            btnMinus.Margin = new Padding(3, 2, 3, 2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(30, 26);
            btnMinus.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinus.TabIndex = 3;
            btnMinus.TabStop = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.Cursor = Cursors.No;
            btnExit.ForeColor = Color.DarkRed;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnExit.IconColor = Color.DarkRed;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 29;
            btnExit.Location = new Point(633, -4);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 29);
            btnExit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.Font = new Font("Segoe UI", 12F);
            lblTitleChildForm.Location = new Point(61, 19);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(89, 22);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(68, 150, 3);
            iconCurrentChildForm.ForeColor = SystemColors.ControlText;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            iconCurrentChildForm.IconColor = SystemColors.ControlText;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 28;
            iconCurrentChildForm.Location = new Point(18, 15);
            iconCurrentChildForm.Margin = new Padding(3, 2, 3, 2);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(33, 28);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(68, 154, 2);
            panelDesktop.Controls.Add(lblLogoDesktop);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(192, 57);
            panelDesktop.Margin = new Padding(3, 2, 3, 2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(661, 396);
            panelDesktop.TabIndex = 2;
            // 
            // lblLogoDesktop
            // 
            lblLogoDesktop.BackColor = Color.FromArgb(68, 154, 2);
            lblLogoDesktop.Dock = DockStyle.Fill;
            lblLogoDesktop.Image = (Image)resources.GetObject("lblLogoDesktop.Image");
            lblLogoDesktop.Location = new Point(0, 0);
            lblLogoDesktop.Margin = new Padding(3, 2, 3, 2);
            lblLogoDesktop.Name = "lblLogoDesktop";
            lblLogoDesktop.Size = new Size(661, 396);
            lblLogoDesktop.SizeMode = PictureBoxSizeMode.Zoom;
            lblLogoDesktop.TabIndex = 1;
            lblLogoDesktop.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 154, 1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(192, 57);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 1);
            panel1.TabIndex = 3;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 453);
            Controls.Add(panel1);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMainMenu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMaximixed).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lblLogoDesktop).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelDesktop;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnGastos;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnCorte;
        private FontAwesome.Sharp.IconButton btnCaja;
        private PictureBox btnInicio;
        private PictureBox lblLogoDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnMinus;
        private FontAwesome.Sharp.IconPictureBox btnMaximixed;
    }
}
