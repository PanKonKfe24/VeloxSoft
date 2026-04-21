namespace VeloxSoft.Formularios
{
    partial class FormInventario
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
            pnlFondo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlDetalles = new Panel();
            pnlPV = new Panel();
            textPV = new TextBox();
            lblVenta = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            pnlStock = new Panel();
            textStock = new TextBox();
            lblStock = new Label();
            pnlPC = new Panel();
            textPC = new TextBox();
            lblPrecioC = new Label();
            pnlNombre = new Panel();
            textNombre = new TextBox();
            lblNombre = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            textID = new TextBox();
            lblID = new Label();
            lbTitulo = new Label();
            pnlFondo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlDetalles.SuspendLayout();
            pnlPV.SuspendLayout();
            pnlStock.SuspendLayout();
            pnlPC.SuspendLayout();
            pnlNombre.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = Color.FromArgb(52, 133, 63);
            pnlFondo.Controls.Add(tableLayoutPanel1);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 0);
            pnlFondo.Margin = new Padding(3, 4, 3, 4);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(1394, 795);
            pnlFondo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(pnlDetalles, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1394, 795);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pnlDetalles
            // 
            pnlDetalles.BackColor = Color.FromArgb(192, 255, 192);
            pnlDetalles.Controls.Add(pnlPV);
            pnlDetalles.Controls.Add(lblVenta);
            pnlDetalles.Controls.Add(btnEliminar);
            pnlDetalles.Controls.Add(btnGuardar);
            pnlDetalles.Controls.Add(btnNuevo);
            pnlDetalles.Controls.Add(pnlStock);
            pnlDetalles.Controls.Add(lblStock);
            pnlDetalles.Controls.Add(pnlPC);
            pnlDetalles.Controls.Add(lblPrecioC);
            pnlDetalles.Controls.Add(pnlNombre);
            pnlDetalles.Controls.Add(lblNombre);
            pnlDetalles.Controls.Add(btnBuscar);
            pnlDetalles.Controls.Add(panel1);
            pnlDetalles.Controls.Add(lblID);
            pnlDetalles.Controls.Add(lbTitulo);
            pnlDetalles.Dock = DockStyle.Fill;
            pnlDetalles.Location = new Point(3, 4);
            pnlDetalles.Margin = new Padding(3, 4, 3, 4);
            pnlDetalles.Name = "pnlDetalles";
            pnlDetalles.Size = new Size(760, 787);
            pnlDetalles.TabIndex = 0;
            pnlDetalles.Paint += pnlDetalles_Paint;
            pnlDetalles.Resize += pnlDetalles_Resize;
            // 
            // pnlPV
            // 
            pnlPV.BackColor = Color.White;
            pnlPV.Controls.Add(textPV);
            pnlPV.Location = new Point(257, 287);
            pnlPV.Margin = new Padding(3, 4, 3, 4);
            pnlPV.Name = "pnlPV";
            pnlPV.Size = new Size(250, 49);
            pnlPV.TabIndex = 24;
            pnlPV.Paint += pnlPV_Paint;
            // 
            // textPV
            // 
            textPV.BorderStyle = BorderStyle.None;
            textPV.Cursor = Cursors.IBeam;
            textPV.Location = new Point(3, 15);
            textPV.Margin = new Padding(3, 4, 3, 4);
            textPV.Name = "textPV";
            textPV.Size = new Size(243, 20);
            textPV.TabIndex = 0;
            textPV.TextChanged += textPV_TextChanged;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(3, 303);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(228, 32);
            lblVenta.TabIndex = 23;
            lblVenta.Text = "PRECIO DE VENTA:";
            lblVenta.Click += label1_Click_1;
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
            btnEliminar.Location = new Point(447, 465);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 41);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnGuardar.Location = new Point(241, 465);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnNuevo.Location = new Point(24, 465);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(119, 41);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            btnNuevo.Paint += btnNuevo_Paint;
            // 
            // pnlStock
            // 
            pnlStock.BackColor = Color.White;
            pnlStock.Controls.Add(textStock);
            pnlStock.Location = new Point(157, 363);
            pnlStock.Margin = new Padding(3, 4, 3, 4);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(351, 45);
            pnlStock.TabIndex = 19;
            pnlStock.Paint += pnlStock_Paint;
            // 
            // textStock
            // 
            textStock.BorderStyle = BorderStyle.None;
            textStock.Cursor = Cursors.IBeam;
            textStock.Location = new Point(3, 12);
            textStock.Margin = new Padding(3, 4, 3, 4);
            textStock.Name = "textStock";
            textStock.Size = new Size(243, 20);
            textStock.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(10, 363);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(135, 32);
            lblStock.TabIndex = 18;
            lblStock.Text = "EN STOCK:";
            // 
            // pnlPC
            // 
            pnlPC.BackColor = Color.White;
            pnlPC.Controls.Add(textPC);
            pnlPC.Location = new Point(257, 217);
            pnlPC.Margin = new Padding(3, 4, 3, 4);
            pnlPC.Name = "pnlPC";
            pnlPC.Size = new Size(250, 49);
            pnlPC.TabIndex = 17;
            pnlPC.Paint += pnlPC_Paint;
            // 
            // textPC
            // 
            textPC.BorderStyle = BorderStyle.None;
            textPC.Cursor = Cursors.IBeam;
            textPC.Location = new Point(3, 15);
            textPC.Margin = new Padding(3, 4, 3, 4);
            textPC.Name = "textPC";
            textPC.Size = new Size(243, 20);
            textPC.TabIndex = 0;
            // 
            // lblPrecioC
            // 
            lblPrecioC.AutoSize = true;
            lblPrecioC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioC.Location = new Point(3, 233);
            lblPrecioC.Name = "lblPrecioC";
            lblPrecioC.Size = new Size(255, 32);
            lblPrecioC.TabIndex = 1;
            lblPrecioC.Text = "PRECIO DE COMPRA:";
            lblPrecioC.Click += label1_Click;
            // 
            // pnlNombre
            // 
            pnlNombre.BackColor = Color.White;
            pnlNombre.Controls.Add(textNombre);
            pnlNombre.Location = new Point(153, 141);
            pnlNombre.Margin = new Padding(3, 4, 3, 4);
            pnlNombre.Name = "pnlNombre";
            pnlNombre.Size = new Size(354, 49);
            pnlNombre.TabIndex = 16;
            pnlNombre.Paint += pnlNombre_Paint;
            // 
            // textNombre
            // 
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.Cursor = Cursors.IBeam;
            textNombre.Location = new Point(3, 13);
            textNombre.Margin = new Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(347, 20);
            textNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(10, 141);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 32);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "NOMBRE:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SeaGreen;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.ImageAlign = ContentAlignment.BottomLeft;
            btnBuscar.Location = new Point(542, 81);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 37);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.Paint += btnBuscar_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textID);
            panel1.Location = new Point(153, 77);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 49);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // textID
            // 
            textID.BorderStyle = BorderStyle.None;
            textID.Cursor = Cursors.IBeam;
            textID.Location = new Point(3, 12);
            textID.Margin = new Padding(3, 4, 3, 4);
            textID.Name = "textID";
            textID.Size = new Size(347, 20);
            textID.TabIndex = 0;
            textID.TextChanged += textID_TextChanged;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(10, 85);
            lblID.Name = "lblID";
            lblID.Size = new Size(147, 32);
            lblID.TabIndex = 1;
            lblID.Text = "BUSCAR ID:";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(10, 8);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(284, 41);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Detalles Inventario";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 154, 2);
            ClientSize = new Size(1394, 795);
            Controls.Add(pnlFondo);
            Name = "FormInventario";
            Text = "FormInventario";
            pnlFondo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlDetalles.ResumeLayout(false);
            pnlDetalles.PerformLayout();
            pnlPV.ResumeLayout(false);
            pnlPV.PerformLayout();
            pnlStock.ResumeLayout(false);
            pnlStock.PerformLayout();
            pnlPC.ResumeLayout(false);
            pnlPC.PerformLayout();
            pnlNombre.ResumeLayout(false);
            pnlNombre.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFondo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlDetalles;
        private Label lbTitulo;
        private Panel panel1;
        private Label lblID;
        private TextBox textID;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Panel pnlNombre;
        private Label lblNombre;
        private Label lblPrecioC;
        private Panel pnlPC;
        private TextBox textPC;
        private TextBox textNombre;
        private Panel pnlStock;
        private TextBox textStock;
        private Label lblStock;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Panel pnlPV;
        private TextBox textPV;
        private Label lblVenta;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}