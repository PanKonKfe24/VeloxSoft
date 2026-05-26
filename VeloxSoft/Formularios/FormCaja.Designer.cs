namespace VeloxSoft.Formularios
{
    partial class FormCaja
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlCaja = new Panel();
            pnlFormulario = new Panel();
            lstSugerencias2 = new ListBox();
            txtUsuario = new TextBox();
            lblBuscar = new Label();
            checkCaja = new CheckBox();
            txtBuscar = new TextBox();
            lblUsuario = new Label();
            lstSugerencias = new ListBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            lblUnidad = new Label();
            btnAgregar = new Button();
            lblMetodoPago = new Label();
            cbMetodoPago = new ComboBox();
            lblTotal = new Label();
            lblTotalValor = new Label();
            btnTerminarCompra = new Button();
            btnLimpiar = new Button();
            pnlBotones = new Panel();
            lblInfoId = new Label();
            lblInfoNombre = new Label();
            lblErrores = new Label();
            pnlBD = new Panel();
            dgvCarrito = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colUnidad = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            pnlBotones.SuspendLayout();
            pnlBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // pnlCaja
            // 
            pnlCaja.BackColor = Color.FromArgb(234, 243, 222);
            pnlCaja.Dock = DockStyle.Fill;
            pnlCaja.Location = new Point(0, 0);
            pnlCaja.Name = "pnlCaja";
            pnlCaja.Size = new Size(1386, 788);
            pnlCaja.TabIndex = 0;
            pnlCaja.Resize += pnlCaja_Resize;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(lstSugerencias2);
            pnlFormulario.Controls.Add(txtUsuario);
            pnlFormulario.Controls.Add(lblBuscar);
            pnlFormulario.Controls.Add(checkCaja);
            pnlFormulario.Controls.Add(txtBuscar);
            pnlFormulario.Controls.Add(lblUsuario);
            pnlFormulario.Controls.Add(lstSugerencias);
            pnlFormulario.Controls.Add(lblCantidad);
            pnlFormulario.Controls.Add(nudCantidad);
            pnlFormulario.Controls.Add(lblUnidad);
            pnlFormulario.Controls.Add(btnAgregar);
            pnlFormulario.Controls.Add(lblMetodoPago);
            pnlFormulario.Controls.Add(cbMetodoPago);
            pnlFormulario.Controls.Add(lblTotal);
            pnlFormulario.Controls.Add(lblTotalValor);
            pnlFormulario.Controls.Add(btnTerminarCompra);
            pnlFormulario.Controls.Add(btnLimpiar);
            pnlFormulario.Location = new Point(14, 16);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(480, 1035);
            pnlFormulario.TabIndex = 1;
            pnlFormulario.Paint += pnlFormulario_Paint;
            pnlFormulario.Resize += pnlFormulario_Resize;
            // 
            // lstSugerencias2
            // 
            lstSugerencias2.BorderStyle = BorderStyle.FixedSingle;
            lstSugerencias2.Font = new Font("Segoe UI", 10F);
            lstSugerencias2.Location = new Point(26, 81);
            lstSugerencias2.Name = "lstSugerencias2";
            lstSugerencias2.Size = new Size(300, 94);
            lstSugerencias2.TabIndex = 9;
            lstSugerencias2.Visible = false;
            lstSugerencias2.Click += lstSugerencias2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(250, 254, 247);
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(26, 43);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Argel ";
            txtUsuario.Size = new Size(300, 32);
            txtUsuario.TabIndex = 8;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(59, 109, 17);
            lblBuscar.Location = new Point(26, 211);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(146, 23);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar producto:";
            // 
            // checkCaja
            // 
            checkCaja.BackColor = Color.Transparent;
            checkCaja.Cursor = Cursors.Hand;
            checkCaja.FlatStyle = FlatStyle.Flat;
            checkCaja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            checkCaja.ForeColor = Color.FromArgb(59, 109, 17);
            checkCaja.Location = new Point(26, 17);
            checkCaja.Name = "checkCaja";
            checkCaja.Size = new Size(200, 29);
            checkCaja.TabIndex = 4;
            checkCaja.Text = "  \U0001f6f5  Envío";
            checkCaja.UseVisualStyleBackColor = false;
            checkCaja.CheckedChanged += checkCaja_CheckedChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(250, 254, 247);
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.Location = new Point(26, 237);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Nombre o ID...";
            txtBuscar.Size = new Size(300, 32);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(59, 109, 17);
            lblUsuario.Location = new Point(26, 17);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 23);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += label1_Click;
            // 
            // lstSugerencias
            // 
            lstSugerencias.BorderStyle = BorderStyle.FixedSingle;
            lstSugerencias.Font = new Font("Segoe UI", 10F);
            lstSugerencias.Location = new Point(26, 276);
            lstSugerencias.Name = "lstSugerencias";
            lstSugerencias.Size = new Size(300, 94);
            lstSugerencias.TabIndex = 1;
            lstSugerencias.Visible = false;
            lstSugerencias.Click += lstSugerencias_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(59, 109, 17);
            lblCantidad.Location = new Point(23, 467);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(88, 23);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.BackColor = Color.FromArgb(250, 254, 247);
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Font = new Font("Segoe UI", 11F);
            nudCantidad.Location = new Point(23, 493);
            nudCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 25, 0, 0, 131072 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(139, 32);
            nudCantidad.TabIndex = 2;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Validating += nudCantidad_Validating;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUnidad.ForeColor = Color.FromArgb(120, 120, 120);
            lblUnidad.Location = new Point(173, 499);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(38, 23);
            lblUnidad.TabIndex = 3;
            lblUnidad.Text = "pza";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(59, 109, 17);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(23, 547);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(299, 43);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMetodoPago.ForeColor = Color.FromArgb(59, 109, 17);
            lblMetodoPago.Location = new Point(23, 616);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(149, 23);
            lblMetodoPago.TabIndex = 4;
            lblMetodoPago.Text = "Método de pago:";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.BackColor = Color.FromArgb(250, 254, 247);
            cbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodoPago.Font = new Font("Segoe UI", 11F);
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cbMetodoPago.Location = new Point(23, 644);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(300, 33);
            cbMetodoPago.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(59, 109, 17);
            lblTotal.Location = new Point(23, 755);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(59, 109, 17);
            lblTotalValor.Location = new Point(23, 785);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(116, 50);
            lblTotalValor.TabIndex = 6;
            lblTotalValor.Text = "$0.00";
            // 
            // btnTerminarCompra
            // 
            btnTerminarCompra.BackColor = Color.FromArgb(59, 109, 17);
            btnTerminarCompra.FlatAppearance.BorderSize = 0;
            btnTerminarCompra.FlatStyle = FlatStyle.Flat;
            btnTerminarCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTerminarCompra.ForeColor = Color.White;
            btnTerminarCompra.Location = new Point(23, 875);
            btnTerminarCompra.Name = "btnTerminarCompra";
            btnTerminarCompra.Size = new Size(299, 51);
            btnTerminarCompra.TabIndex = 5;
            btnTerminarCompra.Text = "✔ Terminar compra";
            btnTerminarCompra.UseVisualStyleBackColor = false;
            btnTerminarCompra.Click += btnTerminarCompra_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(163, 45, 45);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 11F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(23, 935);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(299, 43);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "✕ Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.White;
            pnlBotones.Controls.Add(lblInfoId);
            pnlBotones.Controls.Add(lblInfoNombre);
            pnlBotones.Controls.Add(lblErrores);
            pnlBotones.Location = new Point(507, 16);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(1079, 91);
            pnlBotones.TabIndex = 2;
            pnlBotones.Paint += pnlBotones_Paint;
            pnlBotones.Resize += pnlBotones_Resize;
            // 
            // lblInfoId
            // 
            lblInfoId.AutoSize = true;
            lblInfoId.Location = new Point(581, 20);
            lblInfoId.Name = "lblInfoId";
            lblInfoId.Size = new Size(50, 20);
            lblInfoId.TabIndex = 2;
            lblInfoId.Text = "label2";
            lblInfoId.Visible = false;
            // 
            // lblInfoNombre
            // 
            lblInfoNombre.AutoSize = true;
            lblInfoNombre.Location = new Point(232, 20);
            lblInfoNombre.Name = "lblInfoNombre";
            lblInfoNombre.Size = new Size(50, 20);
            lblInfoNombre.TabIndex = 1;
            lblInfoNombre.Text = "label1";
            lblInfoNombre.Visible = false;
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrores.ForeColor = Color.Red;
            lblErrores.Location = new Point(32, 33);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(97, 23);
            lblErrores.TabIndex = 0;
            lblErrores.Text = "lblErrores";
            lblErrores.Visible = false;
            // 
            // pnlBD
            // 
            pnlBD.BackColor = Color.White;
            pnlBD.Controls.Add(dgvCarrito);
            pnlBD.Location = new Point(507, 117);
            pnlBD.Name = "pnlBD";
            pnlBD.Size = new Size(1079, 931);
            pnlBD.TabIndex = 3;
            pnlBD.Paint += pnlBD_Paint;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.BorderStyle = BorderStyle.None;
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(234, 243, 222);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(85, 125, 70);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(234, 243, 222);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(85, 125, 70);
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.ColumnHeadersHeight = 40;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPrecio, colUnidad, colCantidad, colSubtotal, colEliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = Color.FromArgb(235, 235, 235);
            dgvCarrito.Location = new Point(0, 0);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 45;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(1079, 931);
            dgvCarrito.TabIndex = 0;
            dgvCarrito.CellClick += dgvCarrito_CellClick;
            dgvCarrito.CellEndEdit += dgvCarrito_CellEndEdit;
            // 
            // colId
            // 
            colId.FillWeight = 50F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.FillWeight = 180F;
            colNombre.HeaderText = "Producto";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.FillWeight = 90F;
            colPrecio.HeaderText = "Precio unit";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colUnidad
            // 
            colUnidad.FillWeight = 70F;
            colUnidad.HeaderText = "Unidad";
            colUnidad.MinimumWidth = 6;
            colUnidad.Name = "colUnidad";
            colUnidad.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.FillWeight = 80F;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            colSubtotal.FillWeight = 90F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colEliminar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(163, 45, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            colEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            colEliminar.FillWeight = 40F;
            colEliminar.FlatStyle = FlatStyle.Flat;
            colEliminar.HeaderText = "";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.Text = "✕";
            colEliminar.UseColumnTextForButtonValue = true;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 245);
            ClientSize = new Size(1386, 788);
            Controls.Add(pnlBD);
            Controls.Add(pnlBotones);
            Controls.Add(pnlFormulario);
            Controls.Add(pnlCaja);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCaja";
            Text = "FormCaja";
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            pnlBD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlCaja;
        private Panel pnlFormulario;
        private Panel pnlBotones;
        private Panel pnlBD;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private ListBox lstSugerencias;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Label lblUnidad;
        private Button btnAgregar;
        private Label lblMetodoPago;
        private ComboBox cbMetodoPago;
        private Label lblTotal;
        private Label lblTotalValor;
        private Button btnTerminarCompra;
        private Button btnLimpiar;
        private DataGridView dgvCarrito;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colUnidad;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colEliminar;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private CheckBox checkCaja;
        private ListBox lstSugerencias2;
        private Label lblErrores;
        private Label lblInfoId;
        private Label lblInfoNombre;
    }
}