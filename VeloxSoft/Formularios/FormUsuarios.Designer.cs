namespace VeloxSoft.Formularios
{
    partial class FormUsuarios
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
            pnlUsuarios = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlLista = new Panel();
            pnlDetalles = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTitulo = new Label();
            pnlContenedorID = new Panel();
            txtID = new TextBox();
            pnlNombre = new Panel();
            txtNombre = new TextBox();
            pnlRol = new Panel();
            txtRol = new TextBox();
            pnlUsuarios.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlDetalles.SuspendLayout();
            pnlContenedorID.SuspendLayout();
            pnlNombre.SuspendLayout();
            pnlRol.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = Color.FromArgb(52, 133, 63);
            pnlUsuarios.Controls.Add(tableLayoutPanel1);
            pnlUsuarios.Dock = DockStyle.Fill;
            pnlUsuarios.Location = new Point(0, 0);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(1167, 696);
            pnlUsuarios.TabIndex = 0;
            pnlUsuarios.Resize += pnlUsuarios_Resize;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(pnlLista, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlDetalles, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1167, 696);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.FromArgb(192, 255, 192);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(787, 53);
            pnlLista.Margin = new Padding(29, 53, 29, 267);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(351, 376);
            pnlLista.TabIndex = 4;
            pnlLista.Paint += pnlLista_Paint;
            // 
            // pnlDetalles
            // 
            pnlDetalles.BackColor = Color.FromArgb(192, 255, 192);
            pnlDetalles.Controls.Add(btnBuscar);
            pnlDetalles.Controls.Add(btnEliminar);
            pnlDetalles.Controls.Add(btnGuardar);
            pnlDetalles.Controls.Add(btnNuevo);
            pnlDetalles.Controls.Add(label3);
            pnlDetalles.Controls.Add(label2);
            pnlDetalles.Controls.Add(label1);
            pnlDetalles.Controls.Add(txtTitulo);
            pnlDetalles.Controls.Add(pnlContenedorID);
            pnlDetalles.Controls.Add(pnlNombre);
            pnlDetalles.Controls.Add(pnlRol);
            pnlDetalles.Dock = DockStyle.Fill;
            pnlDetalles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDetalles.Location = new Point(23, 27);
            pnlDetalles.Margin = new Padding(23, 27, 23, 27);
            pnlDetalles.Name = "pnlDetalles";
            pnlDetalles.Size = new Size(712, 642);
            pnlDetalles.TabIndex = 2;
            pnlDetalles.Paint += pnlDetalles_Paint;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MediumAquamarine;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.ImageAlign = ContentAlignment.BottomLeft;
            btnBuscar.Location = new Point(461, 84);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 37);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.Paint += btnBuscar_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(217, 83, 79);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.ImageAlign = ContentAlignment.BottomLeft;
            btnEliminar.Location = new Point(334, 361);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 41);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Paint += btnEliminar_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(77, 119, 78);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.ImageAlign = ContentAlignment.BottomLeft;
            btnGuardar.Location = new Point(178, 361);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Paint += btnGuardar_Paint;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(77, 119, 78);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 20;
            btnNuevo.ImageAlign = ContentAlignment.BottomLeft;
            btnNuevo.Location = new Point(17, 361);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(119, 41);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Paint += btnNuevo_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 197);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 3;
            label3.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 140);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 84);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 1;
            label1.Text = "ID USUARIO: ";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(21, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(247, 41);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Detalles Usuario";
            // 
            // pnlContenedorID
            // 
            pnlContenedorID.BackColor = Color.White;
            pnlContenedorID.Controls.Add(txtID);
            pnlContenedorID.Location = new Point(178, 84);
            pnlContenedorID.Margin = new Padding(3, 4, 3, 4);
            pnlContenedorID.Name = "pnlContenedorID";
            pnlContenedorID.Size = new Size(274, 48);
            pnlContenedorID.TabIndex = 14;
            pnlContenedorID.Paint += pnlContenedorID_Paint;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Cursor = Cursors.IBeam;
            txtID.Location = new Point(3, 12);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(253, 20);
            txtID.TabIndex = 4;
            txtID.KeyDown += textID_KeyDown;
            // 
            // pnlNombre
            // 
            pnlNombre.BackColor = Color.White;
            pnlNombre.Controls.Add(txtNombre);
            pnlNombre.Cursor = Cursors.IBeam;
            pnlNombre.Location = new Point(178, 140);
            pnlNombre.Margin = new Padding(3, 4, 3, 4);
            pnlNombre.Name = "pnlNombre";
            pnlNombre.Size = new Size(274, 49);
            pnlNombre.TabIndex = 15;
            pnlNombre.Paint += pnlNombre_Paint;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(3, 7);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 20);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged_1;
            // 
            // pnlRol
            // 
            pnlRol.BackColor = Color.White;
            pnlRol.Controls.Add(txtRol);
            pnlRol.Cursor = Cursors.IBeam;
            pnlRol.Location = new Point(178, 197);
            pnlRol.Margin = new Padding(3, 4, 3, 4);
            pnlRol.Name = "pnlRol";
            pnlRol.Size = new Size(274, 45);
            pnlRol.TabIndex = 16;
            pnlRol.Paint += pnlRol_Paint;
            // 
            // txtRol
            // 
            txtRol.BorderStyle = BorderStyle.None;
            txtRol.Location = new Point(3, 7);
            txtRol.Margin = new Padding(3, 4, 3, 4);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(256, 20);
            txtRol.TabIndex = 6;
            txtRol.TextChanged += txtRol_TextChanged_1;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 696);
            Controls.Add(pnlUsuarios);
            Name = "FormUsuarios";
            Text = "Testt";
            pnlUsuarios.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlDetalles.ResumeLayout(false);
            pnlDetalles.PerformLayout();
            pnlContenedorID.ResumeLayout(false);
            pnlContenedorID.PerformLayout();
            pnlNombre.ResumeLayout(false);
            pnlNombre.PerformLayout();
            pnlRol.ResumeLayout(false);
            pnlRol.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUsuarios;
        private Label label1;
        private Panel pnlNombre;
        private PictureBox pictureBox1;
        private Panel pnlDetalles;
        private Panel pnlLista;
        private TableLayoutPanel tableLayoutPanel1;
        private Label txtTitulo;
        private Label label3;
        private Label label2;
        private TextBox txtRol;
        private TextBox txtNombre;
        private TextBox txtID;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Panel pnlContenedorID;
        private Panel pnlRol;
    }
}