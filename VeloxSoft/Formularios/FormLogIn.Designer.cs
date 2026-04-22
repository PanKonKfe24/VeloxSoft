namespace VeloxSoft.Formularios
{
    partial class FormLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NavPanel = new Panel();
            LabelLimpiar = new Label();
            TxtPassword = new TextBox();
            TxtUsuario = new TextBox();
            LogInButton = new Button();
            panel3 = new Panel();
            PasswordIcon = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            UserIcon = new PictureBox();
            TxtLogIn = new Label();
            pictureBox1 = new PictureBox();
            LabelSalir = new Label();
            NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.Controls.Add(LabelLimpiar);
            NavPanel.Controls.Add(TxtPassword);
            NavPanel.Controls.Add(TxtUsuario);
            NavPanel.Controls.Add(LogInButton);
            NavPanel.Controls.Add(panel3);
            NavPanel.Controls.Add(PasswordIcon);
            NavPanel.Controls.Add(panel2);
            NavPanel.Controls.Add(panel1);
            NavPanel.Controls.Add(UserIcon);
            NavPanel.Controls.Add(TxtLogIn);
            NavPanel.Controls.Add(pictureBox1);
            NavPanel.Controls.Add(LabelSalir);
            NavPanel.Location = new Point(0, 0);
            NavPanel.Margin = new Padding(3, 4, 3, 4);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(334, 595);
            NavPanel.TabIndex = 7;
            NavPanel.Paint += NavPanel_Paint;
            NavPanel.MouseDown += NavPanel_MouseDown;
            // 
            // LabelLimpiar
            // 
            LabelLimpiar.AutoSize = true;
            LabelLimpiar.Cursor = Cursors.Hand;
            LabelLimpiar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelLimpiar.ForeColor = Color.FromArgb(10, 80, 17);
            LabelLimpiar.Location = new Point(229, 425);
            LabelLimpiar.Name = "LabelLimpiar";
            LabelLimpiar.Size = new Size(67, 19);
            LabelLimpiar.TabIndex = 71;
            LabelLimpiar.Text = "Limpiar";
            LabelLimpiar.Click += LabelLimpiar_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(10, 34, 17);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPassword.ForeColor = Color.FromArgb(10, 80, 17);
            TxtPassword.Location = new Point(55, 367);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(234, 32);
            TxtPassword.TabIndex = 70;
            // 
            // TxtUsuario
            // 
            TxtUsuario.BackColor = Color.FromArgb(10, 34, 17);
            TxtUsuario.BorderStyle = BorderStyle.None;
            TxtUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtUsuario.ForeColor = Color.FromArgb(10, 80, 17);
            TxtUsuario.Location = new Point(55, 276);
            TxtUsuario.Margin = new Padding(3, 4, 3, 4);
            TxtUsuario.Multiline = true;
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(234, 32);
            TxtUsuario.TabIndex = 69;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(10, 80, 17);
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(23, 451);
            LogInButton.Margin = new Padding(3, 4, 3, 4);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(270, 44);
            LogInButton.TabIndex = 68;
            LogInButton.Text = "Iniciar Sesión";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(10, 80, 17);
            panel3.Location = new Point(23, 401);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 1);
            panel3.TabIndex = 67;
            // 
            // PasswordIcon
            // 
            PasswordIcon.Image = Properties.Resources.PasswordVeloxen;
            PasswordIcon.Location = new Point(23, 356);
            PasswordIcon.Margin = new Padding(3, 4, 3, 4);
            PasswordIcon.Name = "PasswordIcon";
            PasswordIcon.Size = new Size(29, 33);
            PasswordIcon.SizeMode = PictureBoxSizeMode.Zoom;
            PasswordIcon.TabIndex = 66;
            PasswordIcon.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(10, 80, 17);
            panel2.Location = new Point(23, 311);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 1);
            panel2.TabIndex = 65;
            // 
            // panel1
            // 
            panel1.Location = new Point(23, 301);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 1);
            panel1.TabIndex = 64;
            // 
            // UserIcon
            // 
            UserIcon.Image = Properties.Resources.UserVeloxen;
            UserIcon.Location = new Point(23, 265);
            UserIcon.Margin = new Padding(3, 4, 3, 4);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(29, 33);
            UserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            UserIcon.TabIndex = 63;
            UserIcon.TabStop = false;
            // 
            // TxtLogIn
            // 
            TxtLogIn.AutoSize = true;
            TxtLogIn.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtLogIn.ForeColor = Color.White;
            TxtLogIn.Location = new Point(23, 164);
            TxtLogIn.Name = "TxtLogIn";
            TxtLogIn.Size = new Size(312, 45);
            TxtLogIn.TabIndex = 62;
            TxtLogIn.Text = "Inicio de sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ElAmigo7__1_;
            pictureBox1.Location = new Point(120, 59);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // LabelSalir
            // 
            LabelSalir.AutoSize = true;
            LabelSalir.Cursor = Cursors.Hand;
            LabelSalir.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSalir.ForeColor = Color.FromArgb(10, 80, 17);
            LabelSalir.Location = new Point(134, 513);
            LabelSalir.Name = "LabelSalir";
            LabelSalir.Size = new Size(42, 19);
            LabelSalir.TabIndex = 72;
            LabelSalir.Text = "Salir";
            LabelSalir.Click += LabelSalir_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 34, 17);
            ClientSize = new Size(334, 596);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            NavPanel.ResumeLayout(false);
            NavPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel NavPanel;
        private Label LabelLimpiar;
        private TextBox TxtPassword;
        private TextBox TxtUsuario;
        private Button LogInButton;
        private Panel panel3;
        private PictureBox PasswordIcon;
        private Panel panel2;
        private Panel panel1;
        private PictureBox UserIcon;
        private Label TxtLogIn;
        private PictureBox pictureBox1;
        private Label LabelSalir;
    }
}