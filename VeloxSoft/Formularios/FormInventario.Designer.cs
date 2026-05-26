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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlInventario = new Panel();
            pnlDB = new Panel();
            label1 = new Label();
            LabelError = new Label();
            dtgBDInv = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPVenta = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            pnlBotones = new Panel();
            lbEstado = new Label();
            cbCategoria = new ComboBox();
            cbEstado = new ComboBox();
            lbCategoria = new Label();
            btnBuscarI = new FontAwesome.Sharp.IconButton();
            textBuscarID = new TextBox();
            lblBuscarI = new Label();
            pnlFormulario = new Panel();
            LabelError2 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            lblTitulo = new Label();
            cbEstadoInv = new ComboBox();
            lblEstado = new Label();
            BoxPrueba = new ComboBox();
            lblCategoria = new Label();
            textPV = new TextBox();
            lblPrecio = new Label();
            textStock = new TextBox();
            lblStock = new Label();
            textNombre = new TextBox();
            lblNombre = new Label();
            textID = new TextBox();
            lblID = new Label();
            pnlInventario.SuspendLayout();
            pnlDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBDInv).BeginInit();
            pnlBotones.SuspendLayout();
            pnlFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInventario
            // 
            pnlInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInventario.BackColor = Color.FromArgb(245, 247, 242);
            pnlInventario.Controls.Add(pnlDB);
            pnlInventario.Controls.Add(pnlBotones);
            pnlInventario.Controls.Add(pnlFormulario);
            pnlInventario.Location = new Point(1, 0);
            pnlInventario.Name = "pnlInventario";
            pnlInventario.Size = new Size(1298, 605);
            pnlInventario.TabIndex = 0;
            pnlInventario.Resize += pnlInventario_Resize;
            // 
            // pnlDB
            // 
            pnlDB.BackColor = Color.White;
            pnlDB.Controls.Add(label1);
            pnlDB.Controls.Add(LabelError);
            pnlDB.Controls.Add(dtgBDInv);
            pnlDB.Location = new Point(495, 122);
            pnlDB.Name = "pnlDB";
            pnlDB.Size = new Size(789, 472);
            pnlDB.TabIndex = 2;
            pnlDB.Paint += pnlDB_Paint;
            pnlDB.Resize += pnlDB_Resize;
            // 
            // label1
            // 
            label1.ForeColor = Color.Red;
            label1.Location = new Point(17, 449);
            label1.Name = "label1";
            label1.Size = new Size(747, 20);
            label1.TabIndex = 21;
            label1.Text = "Error";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Visible = false;
            // 
            // LabelError
            // 
            LabelError.ForeColor = Color.Red;
            LabelError.Location = new Point(17, 484);
            LabelError.Name = "LabelError";
            LabelError.Size = new Size(747, 20);
            LabelError.TabIndex = 20;
            LabelError.Text = "Error";
            LabelError.TextAlign = ContentAlignment.TopCenter;
            LabelError.Visible = false;
            // 
            // dtgBDInv
            // 
            dtgBDInv.AllowUserToAddRows = false;
            dtgBDInv.AllowUserToResizeRows = false;
            dtgBDInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBDInv.BackgroundColor = Color.White;
            dtgBDInv.BorderStyle = BorderStyle.None;
            dtgBDInv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgBDInv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(234, 243, 222);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(85, 125, 70);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(234, 243, 222);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgBDInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgBDInv.ColumnHeadersHeight = 45;
            dtgBDInv.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colCategoria, colStock, colPVenta, colEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgBDInv.DefaultCellStyle = dataGridViewCellStyle2;
            dtgBDInv.EnableHeadersVisualStyles = false;
            dtgBDInv.GridColor = Color.FromArgb(235, 235, 235);
            dtgBDInv.Location = new Point(3, 3);
            dtgBDInv.Name = "dtgBDInv";
            dtgBDInv.ReadOnly = true;
            dtgBDInv.RowHeadersVisible = false;
            dtgBDInv.RowHeadersWidth = 51;
            dtgBDInv.RowTemplate.Height = 50;
            dtgBDInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgBDInv.Size = new Size(783, 466);
            dtgBDInv.TabIndex = 0;
            dtgBDInv.CellContentClick += dtgBDInv_CellContentClick;
            dtgBDInv.DoubleClick += dtgBDInv_DoubleClick;
            // 
            // colID
            // 
            colID.FillWeight = 40F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.FillWeight = 60F;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colPVenta
            // 
            colPVenta.FillWeight = 80F;
            colPVenta.HeaderText = "P.Venta";
            colPVenta.MinimumWidth = 6;
            colPVenta.Name = "colPVenta";
            colPVenta.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.FillWeight = 80F;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // pnlBotones
            // 
            pnlBotones.Anchor = AnchorStyles.None;
            pnlBotones.BackColor = Color.White;
            pnlBotones.Controls.Add(lbEstado);
            pnlBotones.Controls.Add(cbCategoria);
            pnlBotones.Controls.Add(cbEstado);
            pnlBotones.Controls.Add(lbCategoria);
            pnlBotones.Controls.Add(btnBuscarI);
            pnlBotones.Controls.Add(textBuscarID);
            pnlBotones.Controls.Add(lblBuscarI);
            pnlBotones.Location = new Point(495, 12);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(789, 104);
            pnlBotones.TabIndex = 1;
            pnlBotones.Paint += pnlBotones_Paint;
            pnlBotones.Resize += pnlBotones_Resize;
            // 
            // lbEstado
            // 
            lbEstado.Anchor = AnchorStyles.None;
            lbEstado.AutoSize = true;
            lbEstado.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(294, 58);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(94, 27);
            lbEstado.TabIndex = 62;
            lbEstado.Text = "Estado:";
            // 
            // cbCategoria
            // 
            cbCategoria.Anchor = AnchorStyles.None;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "", "Pieza", "Kilo" });
            cbCategoria.Location = new Point(163, 61);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(114, 28);
            cbCategoria.TabIndex = 61;
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.None;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "", "Activo", "Inactivo" });
            cbEstado.Location = new Point(394, 58);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(120, 28);
            cbEstado.TabIndex = 60;
            // 
            // lbCategoria
            // 
            lbCategoria.Anchor = AnchorStyles.None;
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategoria.Location = new Point(22, 58);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(135, 27);
            lbCategoria.TabIndex = 59;
            lbCategoria.Text = "Categoría:";
            // 
            // btnBuscarI
            // 
            btnBuscarI.Anchor = AnchorStyles.None;
            btnBuscarI.BackColor = Color.FromArgb(59, 109, 17);
            btnBuscarI.FlatAppearance.BorderSize = 0;
            btnBuscarI.FlatStyle = FlatStyle.Flat;
            btnBuscarI.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarI.IconColor = Color.Black;
            btnBuscarI.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarI.IconSize = 25;
            btnBuscarI.Location = new Point(375, 13);
            btnBuscarI.Name = "btnBuscarI";
            btnBuscarI.Size = new Size(37, 34);
            btnBuscarI.TabIndex = 58;
            btnBuscarI.UseVisualStyleBackColor = false;
            btnBuscarI.Click += btnBuscarI_Click;
            btnBuscarI.Paint += btnBuscarI_Paint;
            // 
            // textBuscarID
            // 
            textBuscarID.Anchor = AnchorStyles.None;
            textBuscarID.BackColor = Color.FromArgb(250, 254, 247);
            textBuscarID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscarID.ForeColor = Color.DimGray;
            textBuscarID.Location = new Point(227, 13);
            textBuscarID.Name = "textBuscarID";
            textBuscarID.PlaceholderText = "Ej: 4011";
            textBuscarID.Size = new Size(142, 32);
            textBuscarID.TabIndex = 57;
            textBuscarID.KeyPress += textBuscarID_KeyPress;
            // 
            // lblBuscarI
            // 
            lblBuscarI.Anchor = AnchorStyles.None;
            lblBuscarI.AutoSize = true;
            lblBuscarI.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarI.Location = new Point(17, 12);
            lblBuscarI.Name = "lblBuscarI";
            lblBuscarI.Size = new Size(204, 27);
            lblBuscarI.TabIndex = 56;
            lblBuscarI.Text = "Buscar producto:";
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(LabelError2);
            pnlFormulario.Controls.Add(btnEliminar);
            pnlFormulario.Controls.Add(btnLimpiar);
            pnlFormulario.Controls.Add(btnGuardar);
            pnlFormulario.Controls.Add(lblTitulo);
            pnlFormulario.Controls.Add(cbEstadoInv);
            pnlFormulario.Controls.Add(lblEstado);
            pnlFormulario.Controls.Add(BoxPrueba);
            pnlFormulario.Controls.Add(lblCategoria);
            pnlFormulario.Controls.Add(textPV);
            pnlFormulario.Controls.Add(lblPrecio);
            pnlFormulario.Controls.Add(textStock);
            pnlFormulario.Controls.Add(lblStock);
            pnlFormulario.Controls.Add(textNombre);
            pnlFormulario.Controls.Add(lblNombre);
            pnlFormulario.Controls.Add(textID);
            pnlFormulario.Controls.Add(lblID);
            pnlFormulario.Location = new Point(11, 12);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(478, 582);
            pnlFormulario.TabIndex = 0;
            pnlFormulario.Paint += pnlFormulario_Paint;
            pnlFormulario.Resize += pnlFormulario_Resize;
            // 
            // LabelError2
            // 
            LabelError2.ForeColor = Color.Red;
            LabelError2.Location = new Point(0, 559);
            LabelError2.Name = "LabelError2";
            LabelError2.Size = new Size(475, 20);
            LabelError2.TabIndex = 57;
            LabelError2.Text = "LabelError";
            LabelError2.TextAlign = ContentAlignment.TopCenter;
            LabelError2.Visible = false;
            LabelError2.Click += LabelError2_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(163, 45, 45);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(232, 490);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 53);
            btnEliminar.TabIndex = 56;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.Paint += btnEliminar_Paint;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(234, 243, 222);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(39, 83, 10);
            btnLimpiar.Location = new Point(78, 490);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 53);
            btnLimpiar.TabIndex = 55;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.Paint += btnLimpiar_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(59, 109, 17);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(78, 425);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(298, 48);
            btnGuardar.TabIndex = 54;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.Paint += btnGuardar_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 47);
            lblTitulo.TabIndex = 52;
            lblTitulo.Text = "Inventario";
            // 
            // cbEstadoInv
            // 
            cbEstadoInv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoInv.FormattingEnabled = true;
            cbEstadoInv.Items.AddRange(new object[] { "Activo", "Baja" });
            cbEstadoInv.Location = new Point(78, 376);
            cbEstadoInv.Name = "cbEstadoInv";
            cbEstadoInv.Size = new Size(300, 28);
            cbEstadoInv.TabIndex = 51;
            cbEstadoInv.Visible = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.FromArgb(59, 109, 17);
            lblEstado.Location = new Point(78, 340);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(77, 23);
            lblEstado.TabIndex = 50;
            lblEstado.Text = "Estado";
            lblEstado.Visible = false;
            // 
            // BoxPrueba
            // 
            BoxPrueba.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxPrueba.FormattingEnabled = true;
            BoxPrueba.Items.AddRange(new object[] { "Pieza", "Kilo" });
            BoxPrueba.Location = new Point(78, 306);
            BoxPrueba.Name = "BoxPrueba";
            BoxPrueba.Size = new Size(300, 28);
            BoxPrueba.TabIndex = 49;
            BoxPrueba.SelectedIndexChanged += BoxPrueba_SelectedIndexChanged;
            BoxPrueba.KeyPress += BoxPrueba_KeyPress;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.FromArgb(59, 109, 17);
            lblCategoria.Location = new Point(78, 270);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(109, 23);
            lblCategoria.TabIndex = 48;
            lblCategoria.Text = "Categoria";
            // 
            // textPV
            // 
            textPV.BackColor = Color.White;
            textPV.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPV.ForeColor = Color.DimGray;
            textPV.Location = new Point(245, 226);
            textPV.Name = "textPV";
            textPV.PlaceholderText = "$0.00";
            textPV.Size = new Size(134, 32);
            textPV.TabIndex = 47;
            textPV.KeyPress += textPV_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.FromArgb(59, 109, 17);
            lblPrecio.Location = new Point(244, 201);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 23);
            lblPrecio.TabIndex = 46;
            lblPrecio.Text = "Precio";
            // 
            // textStock
            // 
            textStock.BackColor = Color.White;
            textStock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textStock.ForeColor = Color.DimGray;
            textStock.Location = new Point(78, 226);
            textStock.Name = "textStock";
            textStock.PlaceholderText = "0";
            textStock.Size = new Size(134, 32);
            textStock.TabIndex = 45;
            textStock.KeyPress += textStock_KeyPress;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(59, 109, 17);
            lblStock.Location = new Point(77, 201);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(63, 23);
            lblStock.TabIndex = 44;
            lblStock.Text = "Stock";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.White;
            textNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.ForeColor = Color.DimGray;
            textNombre.Location = new Point(77, 154);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre producto...";
            textNombre.Size = new Size(300, 32);
            textNombre.TabIndex = 43;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(59, 109, 17);
            lblNombre.Location = new Point(76, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 23);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Nombre";
            // 
            // textID
            // 
            textID.BackColor = Color.White;
            textID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textID.ForeColor = Color.DimGray;
            textID.Location = new Point(77, 84);
            textID.MaxLength = 30;
            textID.Name = "textID";
            textID.PlaceholderText = "Ej: 4011";
            textID.Size = new Size(300, 32);
            textID.TabIndex = 41;
            textID.KeyPress += textID_KeyPress_1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.FromArgb(59, 109, 17);
            lblID.Location = new Point(75, 58);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 23);
            lblID.TabIndex = 40;
            lblID.Text = "ID";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 606);
            Controls.Add(pnlInventario);
            Name = "FormInventario";
            Text = "FormInventarioP";
            Load += FormInventarioP_Load;
            pnlInventario.ResumeLayout(false);
            pnlDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgBDInv).EndInit();
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInventario;
        private Panel pnlFormulario;
        private Panel pnlBotones;
        private Panel pnlDB;
        private Label lblTitulo;
        private ComboBox cbEstadoInv;
        private Label lblEstado;
        private ComboBox BoxPrueba;
        private Label lblCategoria;
        private TextBox textPV;
        private Label lblPrecio;
        private TextBox textStock;
        private Label lblStock;
        private TextBox textNombre;
        private Label lblNombre;
        private TextBox textID;
        private Label lblID;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private FontAwesome.Sharp.IconButton btnBuscarI;
        private TextBox textBuscarID;
        private Label lblBuscarI;
        private DataGridView dtgBDInv;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPVenta;
        private DataGridViewTextBoxColumn colEstado;
        private Label LabelError2;
        private Label LabelError;
        private Label lbEstado;
        private ComboBox cbCategoria;
        private ComboBox cbEstado;
        private Label lbCategoria;
        private Label label1;
    }
}