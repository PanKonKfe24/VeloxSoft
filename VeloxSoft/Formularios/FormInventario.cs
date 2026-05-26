using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using VeloxSoft.Models;
using VeloxSoft.Services;

namespace VeloxSoft.Formularios
{
    public partial class FormInventario : Form
    {
        private bool _modoEdicion = false; // Variable para controlar si estamos editando o creando un nuevo producto
        private readonly ServicioInventario _ServicioInventario;

        public FormInventario(ServicioInventario ServicioInventario)
        {
            InitializeComponent();
            _ServicioInventario = ServicioInventario;
            this.ResizeRedraw = true;
            this.ResizeRedraw = true;
            // Evita el efecto de "congelado" o parpadeo
            this.DoubleBuffered = true;
            pnlInventario_Resize(this, EventArgs.Empty);
            pnlFormulario_Resize(this, EventArgs.Empty);
            pnlBotones_Resize(this, EventArgs.Empty);
            pnlDB_Resize(this, EventArgs.Empty);

        }


        //DIseño de paneles y botones para el formulario de inventario.

        private void RedondearPanel(Panel p, PaintEventArgs e, int radio)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();

            // Dibujamos el camino de las esquinas
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(p.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(p.Width - radio, p.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, p.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            // Aplicamos la forma al panel para que sea "físicamente" redondo
            p.Region = new Region(path);

            // Dibuja un borde sutil con el verde #A4D1A5 de tu paleta Fruit Salad
            // Esto hace que el cuadro resalte sobre el fondo verde oscuro
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#A4D1A5"), 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
        private void RedondearBoton(Button btn, PaintEventArgs e, int radio)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Hace que el borde se vea suave

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radio, radio, 180, 90);
                path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
                path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
                path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
                path.CloseAllFigures();

                // Aplicamos la región redondeada al botón
                btn.Region = new Region(path);
            }
        }


        //Fin del diseño de paneles y botones para el formulario de inventario.
        private void FormInventarioP_Load(object sender, EventArgs e)
        {
            CargarInventario();                   // LLAMAMOS AL MÉTODO PARA CARGAR LOS DATOS DE PRUEBA EN LA TABLA, LUEGO LO ELIMINAMOS O LO MODIFICAMOS PARA QUE CARGUE LOS DATOS REALES DESDE LA BASE DE DATOS

        }

        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlDB_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void btnGuardar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnGuardar, e, 15);
        }

        private void btnLimpiar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnLimpiar, e, 15);
        }

        private void btnEliminar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnEliminar, e, 15);
        }

        private void LabelError2_Click(object sender, EventArgs e)
        {

        }

        private void pnlInventario_Resize(object sender, EventArgs e)
        {
            int w = pnlInventario.Width;
            int h = pnlInventario.Height;
            int margen = 12;
            int espacioH = 10;

            int anchoIzq = (int)(w * 0.38) - margen;
            int anchoDer = w - anchoIzq - (margen * 3) - espacioH;
            int altoBotones = anchoDer < 650 ? 85 : 55;

            // FORMULARIO
            pnlFormulario.Location = new Point(margen, margen);
            pnlFormulario.Size = new Size(anchoIzq, h - margen * 2);

            // BOTONES
            pnlBotones.Location = new Point(anchoIzq + margen * 2, margen);
            pnlBotones.Size = new Size(anchoDer, altoBotones);

            // DB
            int yDB = margen + altoBotones + espacioH;
            pnlDB.Location = new Point(anchoIzq + margen * 2, yDB);
            pnlDB.Size = new Size(anchoDer, h - yDB - margen);

            pnlInventario.Invalidate();
        }

        private void pnlBotones_Resize(object sender, EventArgs e)
        {
            int w = pnlBotones.Width;
            int h = pnlBotones.Height;
            int margenH = 15; // Margen izquierdo y derecho
            int altoControl = 28;
            int espacioPequeño = 5;  // Espacio entre Label y su TextBox/Combo
            int espacioGrande = 20;   // Espacio entre grupos (Buscar -> Categoría -> Estado)

            // Decidimos si usar una o dos líneas según el ancho real
            bool dosLineas = w < 750; // Aumenté un poco el umbral para evitar amontonamiento

            if (!dosLineas)
            {
                // ── UNA LÍNEA (Pantalla Ancha) ──
                int y = (h - altoControl) / 2;

                // 1. Calcular anchos dinámicos para los grupos
                // Dejamos fijos los labels y el botón de lupa
                int anchoLblBusc = lblBuscarI.PreferredWidth;
                int anchoBtnLupa = 35;
                int anchoLblCat = lbCategoria.PreferredWidth;
                int anchoLblEst = lbEstado.PreferredWidth;

                // El espacio restante se divide entre los 3 controles de entrada (Search, Cat, Est)
                int espacioDisponible = w - (margenH * 2) - anchoLblBusc - anchoBtnLupa - anchoLblCat - anchoLblEst - (espacioPequeño * 3) - (espacioGrande * 2);
                int anchoInput = espacioDisponible / 3;

                // --- Grupo Buscar ---
                lblBuscarI.Location = new Point(margenH, y + 4);
                textBuscarID.Location = new Point(lblBuscarI.Right + espacioPequeño, y);
                textBuscarID.Size = new Size(anchoInput, altoControl);
                btnBuscarI.Location = new Point(textBuscarID.Right + 2, y);
                btnBuscarI.Size = new Size(anchoBtnLupa, altoControl);

                // --- Grupo Categoría ---
                lbCategoria.Location = new Point(btnBuscarI.Right + espacioGrande, y + 4);
                cbCategoria.Location = new Point(lbCategoria.Right + espacioPequeño, y);
                cbCategoria.Size = new Size(anchoInput, altoControl);

                // --- Grupo Estado ---
                lbEstado.Location = new Point(cbCategoria.Right + espacioGrande, y + 4);
                cbEstado.Location = new Point(lbEstado.Right + espacioPequeño, y);
                cbEstado.Size = new Size(w - cbEstado.Left - margenH, altoControl);
            }
            else
            {
                // ── DOS LÍNEAS (Pantalla Estrecha / Tablet) ──
                int margenV = 10;
                int anchoDisponible = w - (margenH * 2);
                int anchoBtnLupa = 35;

                // FILA 1: Buscar Producto (Ocupa todo el ancho arriba)
                int y1 = margenV;
                lblBuscarI.Location = new Point(margenH, y1 + 4);

                int anchoTxtBuscar = anchoDisponible - lblBuscarI.Width - anchoBtnLupa - 10;
                textBuscarID.Location = new Point(lblBuscarI.Right + espacioPequeño, y1);
                textBuscarID.Size = new Size(anchoTxtBuscar, altoControl);

                btnBuscarI.Location = new Point(textBuscarID.Right + 2, y1);
                btnBuscarI.Size = new Size(anchoBtnLupa, altoControl);

                // FILA 2: Combos (Divididos 50/50 abajo)
                int y2 = y1 + altoControl + 10;
                int anchoGrupo = (anchoDisponible - espacioGrande) / 2;

                // Categoría
                lbCategoria.Location = new Point(margenH, y2 + 4);
                cbCategoria.Location = new Point(lbCategoria.Right + espacioPequeño, y2);
                cbCategoria.Size = new Size(anchoGrupo - lbCategoria.Width - espacioPequeño, altoControl);

                // Estado
                lbEstado.Location = new Point(cbCategoria.Right + espacioGrande, y2 + 4);
                cbEstado.Location = new Point(lbEstado.Right + espacioPequeño, y2);
                cbEstado.Size = new Size(w - cbEstado.Left - margenH, altoControl);
            }

            pnlBotones.Invalidate();
        }

        private void pnlFormulario_Resize(object sender, EventArgs e)
        {
            int w = pnlFormulario.Width;
            int h = pnlFormulario.Height;
            int margen = 40;
            int anchoInput = w - (margen * 2);
            int altoInput = 32;
            int altoLabel = 23;
            int espacio = 18;

            // TÍTULO
            lblTitulo.Location = new Point(margen - 10, 10);

            // ID
            int yID = 60;
            lblID.Location = new Point(margen, yID);
            textID.Location = new Point(margen, yID + altoLabel + 2);
            textID.Size = new Size(anchoInput, altoInput);

            // NOMBRE
            int yNombre = textID.Bottom + espacio;
            lblNombre.Location = new Point(margen, yNombre);
            textNombre.Location = new Point(margen, yNombre + altoLabel + 2);
            textNombre.Size = new Size(anchoInput, altoInput);

            // STOCK y PRECIO — misma fila
            int yStockPrecio = textNombre.Bottom + espacio;
            int anchoCampo = (int)((anchoInput - 10) / 2);

            lblStock.Location = new Point(margen, yStockPrecio);
            textStock.Location = new Point(margen, yStockPrecio + altoLabel + 2);
            textStock.Size = new Size(anchoCampo, altoInput);

            lblPrecio.Location = new Point(margen + anchoCampo + 10, yStockPrecio);
            textPV.Location = new Point(margen + anchoCampo + 10, yStockPrecio + altoLabel + 2);
            textPV.Size = new Size(anchoCampo, altoInput);

            // CATEGORÍA
            int yCategoria = textStock.Bottom + espacio;
            lblCategoria.Location = new Point(margen, yCategoria);
            BoxPrueba.Location = new Point(margen, yCategoria + altoLabel + 2);
            BoxPrueba.Size = new Size(anchoInput, altoInput);

            // BOTONES
            int yBotones = h - 120;
            int anchoBtn = (int)((anchoInput - 10) / 2);

            btnGuardar.Location = new Point(margen, yBotones);
            btnGuardar.Size = new Size(anchoInput, 48);

            btnLimpiar.Location = new Point(margen, btnGuardar.Bottom + 10);
            btnLimpiar.Size = new Size(anchoBtn, 48);

            btnEliminar.Location = new Point(margen + anchoBtn + 10, btnGuardar.Bottom + 10);
            btnEliminar.Size = new Size(anchoBtn, 48);

            pnlFormulario.Invalidate();
        }

        private void pnlDB_Resize(object sender, EventArgs e)
        {
            int w = pnlDB.Width;
            int h = pnlDB.Height;
            int margen = 10;

            dtgBDInv.Location = new Point(margen, margen);
            dtgBDInv.Size = new Size(w - margen * 2, h - margen * 2);

            pnlDB.Invalidate();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // Validar que se haya seleccionado un producto en la tabla
            if (dtgBDInv.SelectedRows.Count == 0)
            {
                LabelError.Text = "Debe seleccionar un producto para eliminar.";
                LabelError.Visible = true;
                LabelError.ForeColor = Color.Red;
                return;
            }

            // Obtener el ID del producto seleccionado en la tabla
            string idProducto = dtgBDInv.SelectedRows[0].Cells[0].Value?.ToString() ?? ""; // O el nombre de la columna que corresponda

            // Mostrar un cuadro de diálogo de confirmación antes de eliminar el producto
            var Evitemos_Errores = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el producto con ID: {idProducto}?", //confirmación de eliminación, se muestra el ID del producto para que el usuario pueda verificar que está eliminando el producto correcto
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            // Si el usuario selecciona "No", se cancela la operación de eliminación
            if (Evitemos_Errores == DialogResult.No) return;

            //Llamar al serivico para eliminar el producto.
            _ServicioInventario.Eliminar_Producto(idProducto, out string errorMessage);
            string EstadoProducto = dtgBDInv.SelectedRows[0].Cells[5].Value?.ToString() ?? "";
            if (EstadoProducto == "Inactivo")
            {
                LabelError.Text = "El producto ya se encuentra inactivo.";
                LabelError.Visible = true;
                LabelError.ForeColor = Color.Red;
                return;
            }
            //Mostrar mensaje de error o éxito dependiendo del resultado de la operación
            if (!string.IsNullOrEmpty(errorMessage))
            {
                LabelError.Text = errorMessage;
                LabelError.Visible = true;
            }
            else
            {
                LabelError.Text = "Producto eliminado correctamente.";
                LabelError.ForeColor = Color.Green;
                LabelError.Visible = true;
                CargarInventario();
                textID.Text = "";
                textNombre.Text = "";
                textPV.Text = "";
                textStock.Text = "";
                BoxPrueba.SelectedItem = null;
                cbEstadoInv.Visible = false;
                BoxPrueba.Enabled = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!_modoEdicion) //FALSO
            {
                // 1. Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(textID.Text) ||
                    string.IsNullOrWhiteSpace(textNombre.Text) ||
                    string.IsNullOrWhiteSpace(textPV.Text) ||
                    string.IsNullOrWhiteSpace(textStock.Text))
                {
                    LabelError2.Text = "Todos los campos son obligatorios.";
                    LabelError2.Visible = true;
                    LabelError2.ForeColor = Color.Red;
                    return;
                }

                // 2. Validar que precio y cantidad sean números
                if (!decimal.TryParse(textPV.Text, out decimal precio))
                {
                    LabelError2.Text = "El precio debe ser un número válido.";
                    LabelError2.ForeColor = Color.Red;
                    return;
                }
                if (!decimal.TryParse(textStock.Text, out decimal cantidad))
                {
                    LabelError2.Text = "El stock debe ser un número válido.";
                    LabelError2.ForeColor = Color.Red;
                    return;
                }

                // 3. Obtener categoría del ComboBox
                if (BoxPrueba.SelectedItem == null)
                {
                    LabelError2.Text = "Debe seleccionar una categoría.";
                    LabelError2.ForeColor = Color.Red;
                    LabelError2.Visible = true;
                    return;
                }

                string categoria = BoxPrueba.SelectedItem?.ToString() ?? "";

                if (categoria == "Pieza")
                {
                    categoria = "PZ";
                }
                else if (categoria == "Kilo")
                {
                    categoria = "KL";
                }

                
                // 4. Llamar al servicio para insertar el producto
                string mensaje = _ServicioInventario.Insertar_Producto(textID.Text.Trim(), textNombre.Text.Trim(), cantidad, precio, categoria, out string errorMessage);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    LabelError2.Text = errorMessage;
                    LabelError2.Visible = true;
                    LabelError2.ForeColor = Color.Red;
                    CargarInventario();
                    return;
                }
                else
                {

                    LabelError2.Text = mensaje; // "Producto agregado correctamente."
                    LabelError2.Visible = true;
                    LabelError2.ForeColor = Color.Green;
                    CargarInventario(); // Recarga la tabla para mostrar el nuevo producto

                    //Limpiamos los campos después de guardar
                    textID.Text = string.Empty;
                    textNombre.Text = string.Empty;
                    textPV.Text = string.Empty;
                    textStock.Text = string.Empty;
                    BoxPrueba.SelectedItem = null;
                }
            }
            else //VERDADERO
            {
                // Determinar si el producto estaba inactivo según si cbEstadoInv está visible
                bool esInactivo = cbEstadoInv.Visible;

                if (esInactivo)
                {
                    // Validar nombre y categoria
                    if (string.IsNullOrWhiteSpace(textNombre.Text) || textNombre.Text == "Ej: 4011")
                    {
                        LabelError2.Text = "El nombre es obligatorio.";
                        LabelError2.ForeColor = Color.Red;
                        LabelError2.Visible = true;
                        return;
                    }
                    if (BoxPrueba.SelectedItem == null)
                    {
                        LabelError2.Text = "Debe seleccionar una categoría.";
                        LabelError2.ForeColor = Color.Red;
                        LabelError2.Visible = true;
                        return;
                    }
                    // Si quiere reactivar, debe tener stock y precio válidos
                    if (cbEstadoInv.SelectedItem?.ToString() == "Activo")
                    {
                        if (!decimal.TryParse(textStock.Text, out decimal stockVal) || stockVal <= 0)
                        {
                            LabelError2.Text = "Para reactivar el producto el stock debe ser mayor a 0.";
                            LabelError2.ForeColor = Color.Red;
                            LabelError2.Visible = true;
                            return;
                        }
                        if (!decimal.TryParse(textPV.Text, out decimal precioVal) || precioVal <= 0)
                        {
                            LabelError2.Text = "Para reactivar el producto el precio debe ser mayor a 0.";
                            LabelError2.ForeColor = Color.Red;
                            LabelError2.Visible = true;
                            return;
                        }
                    }
                }
                else
                {
                    // Validar stock y precio — deben ser mayores a 0
                    if (!decimal.TryParse(textStock.Text, out decimal stockVal) || stockVal <= 0)
                    {
                        LabelError2.Text = "El stock debe ser mayor a 0.";
                        LabelError2.ForeColor = Color.Red;
                        LabelError2.Visible = true;
                        return;
                    }
                    if (!decimal.TryParse(textPV.Text, out decimal precioVal) || precioVal <= 0)
                    {
                        LabelError2.Text = "El precio debe ser mayor a 0.";
                        LabelError2.ForeColor = Color.Red;
                        LabelError2.Visible = true;
                        return;
                    }
                }

                // Parsear cantidad y precio
                decimal cantidad = esInactivo ? 0 : decimal.Parse(textStock.Text);
                decimal precio = esInactivo ? 0 : decimal.Parse(textPV.Text);

                // Convertir categoria
                string categoria = BoxPrueba.SelectedItem?.ToString() == "Pieza" ? "PZ" : "KL";

                // Determinar estado
                bool estado = esInactivo
                    ? cbEstadoInv.SelectedItem?.ToString() == "Activo"
                    : true;

                // Llamar al servicio
                string mensaje = _ServicioInventario.Actualizar_Producto(
                    textID.Text.Trim(),
                    textNombre.Text.Trim(),
                    cantidad,
                    precio,
                    categoria,
                    estado,
                    out string errorMessage);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    LabelError2.Text = errorMessage;
                    LabelError2.ForeColor = Color.Red;
                    LabelError2.Visible = true;
                    return;
                }

                LabelError2.Text = mensaje;
                LabelError2.ForeColor = Color.Green;
                LabelError2.Visible = true;
                CargarInventario();

                btnLimpiar_Click(sender, e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            //Limpiamos los campos para permitir ingresar un nuevo producto
            textID.Text = string.Empty;
            textNombre.Text = string.Empty;
            textPV.Text = string.Empty;
            textStock.Text = string.Empty;
            BoxPrueba.Text = "";

            //desbloquear el campo de ID en caso de que estemos editando un producto
            textID.ReadOnly = false;
            textID.Enabled = true;
            textNombre.ReadOnly = false;
            textNombre.Enabled = true;
            BoxPrueba.Enabled = true;
            textPV.ForeColor = Color.DimGray;
            textStock.ForeColor = Color.DimGray;
            textNombre.ForeColor = Color.DimGray;

            //Desactivamos el modo edición para que al guardar se cree un nuevo producto en lugar de actualizar uno existente
            _modoEdicion = false;

            // Limpieza de mensaje de error
            LabelError2.Text = string.Empty;
            LabelError2.Visible = false;

            lblEstado.Visible = false;
            cbEstadoInv.Visible = false;
        }
        //FIN BOTON NUEVO (LIMPIAR) PARA LIMPIAR CAMPOS

        //METODO PARA CARGAR DATOS EN LA TABLA AL INICIAR Y EN EL FILTRO
        private void CargarInventario(List<Producto> lista = null) // CON ESTE MÉTODO LLENAMOS LA TABLA CON DATOS DE PRUEBA PARA VER CÓMO QUEDA, LUEGO LO ELIMINAMOS O LO MODIFICAMOS PARA QUE CARGUE LOS DATOS REALES DESDE LA BASE DE DATOS
        {
            if (lista == null)
            {
                lista = _ServicioInventario.Ver_Productos(out String errorMessage);//OBTENEMOS LA LISTA DE PRODUCTOS DESDE EL SERVICIO DE INVENTARIO, SI OCURRE UN ERROR SE ASIGNA UN MENSAJE A errorMessage
                if (!string.IsNullOrEmpty(errorMessage))//SI HAY UN MENSAJE DE ERROR, LO MOSTRAMOS EN LA ETIQUETA DE ERROR Y SALIMOS DEL MÉTODO PARA NO INTENTAR CARGAR DATOS EN LA TABLA
                {
                    LabelError.Text = errorMessage;
                    LabelError.Visible = true;
                    return;
                }
            }

            dtgBDInv.Rows.Clear(); // Limpio la tabla antes de cargar los datos

            foreach (var producto in lista)
            {
                string cantidad;

                if (producto.IdCategoria == "Pieza") // PZ es el ID de Pieza en tu BD
                {
                    cantidad = ((int)producto.Cantidad).ToString();        // Sin decimales
                }
                else
                {
                    cantidad = producto.Cantidad.ToString("F2");           // 3 decimales
                }

                dtgBDInv.Rows.Add( //añade una nueva fila a la tabla con los datos del producto
                    producto.IdProducto,
                    producto.Nombre,
                    producto.IdCategoria,
                    cantidad,
                    producto.Precio.ToString("F2"),
                    producto.Estado ? "Activo" : "Inactivo");
            }
        }

        private void dtgBDInv_DoubleClick(object sender, EventArgs e)
        {

            if (dtgBDInv.CurrentRow == null) return;
            DataGridViewRow fila = dtgBDInv.CurrentRow;

            // Rellenar campos
            textID.Text = fila.Cells[0].Value?.ToString() ?? "";
            textNombre.Text = fila.Cells[1].Value?.ToString() ?? "";
            BoxPrueba.Text = fila.Cells[2].Value?.ToString() ?? "";
            textStock.Text = fila.Cells[3].Value?.ToString() ?? "";
            textPV.Text = fila.Cells[4].Value?.ToString() ?? "";


            // ID siempre bloqueado
            textID.ReadOnly = true;
            textID.Enabled = false;

            string estadoProducto = fila.Cells[5].Value?.ToString() ?? "";

            if (estadoProducto == "Inactivo")
            {
                // Inactivo: puede modificar nombre, categoria y estado
                textNombre.ReadOnly = false;
                textNombre.Enabled = true;
                BoxPrueba.Enabled = true;
                textStock.ReadOnly = false;
                textStock.Enabled = true;
                textPV.ReadOnly = false;
                textPV.Enabled = true;
                lblEstado.Visible = true;
                cbEstadoInv.Visible = true;
                cbEstadoInv.Enabled = true;
                cbEstadoInv.SelectedIndex = 1;

                textNombre.ForeColor = Color.Black;
                textPV.ForeColor = Color.Black;
                textStock.ForeColor = Color.Black;

            }
            else
            {
                // Activo: solo puede modificar stock y precio
                textNombre.ReadOnly = true;
                textNombre.Enabled = false;
                BoxPrueba.Enabled = false;
                textStock.ReadOnly = false;
                textStock.Enabled = true;
                textPV.ReadOnly = false;
                textPV.Enabled = true;
                lblEstado.Visible = false;
                cbEstadoInv.Visible = false;
                cbEstadoInv.SelectedIndex = 0;
                textPV.ForeColor = Color.Black;
                textStock.ForeColor = Color.Black;
            }

            _modoEdicion = true;
        }
        // FIN EVENTO PARA CARGAR LOS DATOS DEL PRODUCTO SELECCIONADO EN LA TABLA A LOS CAMPOS DE TEXTO PARA SU EDICIÓN (Gil)
        //EVENTOS DE VALIDACIÓN DE ENTRADAS
        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Backspace permitido
            if (e.KeyChar == (char)Keys.Back) return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (textID.Text.Length <= 4)
            {
                e.Handled = true;
            }
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, espacios, backspace, punto y guión
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
            string texto = textNombre.Text;

            if (e.KeyChar == '.')
            {
                //Bloquear si ya tiene un punto o si este esta al inicio.
                if (texto.Contains('.') || texto.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                // Bloquear si ya tiene un guion O si está al inicio
                if (texto.Contains('-') || texto.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void textID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Backspace permitido
            if (e.KeyChar == (char)Keys.Back) return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {

            bool esPieza = BoxPrueba.SelectedItem?.ToString() == "Pieza";

            // Backspace permitido
            if (e.KeyChar == (char)Keys.Back) return;

            if (esPieza && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.Handled = true; // Bloquea la tecla. No escribe nada.
                LabelError2.Text = "No se permiten decimales en piezas.";
                LabelError2.Visible = true;
                return;
            }
            string texto = textStock.Text;

            // SI ES PIEZA (ENTERO)
            if (esPieza)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    if (texto.Length >= 6)
                        e.Handled = true;
                    return;
                }

                // bloquear todo lo demás
                e.Handled = true;
                return;
            }
            // SI NO ES PIEZA (DECIMAL)

            if (char.IsDigit(e.KeyChar))
            {
                int puntoPos = texto.IndexOf('.');

                if (puntoPos >= 0)
                {
                    string decimales = texto.Substring(puntoPos + 1);

                    if (textStock.SelectionStart > puntoPos && decimales.Length >= 2)
                        e.Handled = true;
                }
                else
                {
                    if (texto.Length >= 6)
                        e.Handled = true;
                }

                return;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = texto.Contains('.') || texto.Length == 0;
                return;
            }

            e.Handled = true;
        }

        private void textPV_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir Backspace
            if (e.KeyChar == (char)Keys.Back)
                return;

            string texto = textPV.Text;

            // Permitir números
            if (char.IsDigit(e.KeyChar))
            {
                int puntoPos = texto.IndexOf('.');

                if (puntoPos >= 0)
                {
                    // Máximo 2 decimales
                    string decimales = texto.Substring(puntoPos + 1);

                    if (textPV.SelectionStart > puntoPos && decimales.Length >= 2)
                        e.Handled = true;
                }
                else
                {
                    // Máximo 6 enteros
                    if (texto.Length >= 6)
                        e.Handled = true;
                }

                return;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.')
            {
                // No permitir más de un punto
                if (texto.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }

                // No permitir punto al inicio
                if (texto.Length == 0)
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }

        private void textBuscarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Backspace permitido
            if (e.KeyChar == (char)Keys.Back) return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (textBuscarID.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void BoxPrueba_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BoxPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Verificamos que haya algo seleccionado para evitar el error
            if (BoxPrueba.SelectedItem == null) return;

            string categoria = BoxPrueba.SelectedItem.ToString();
            if (categoria == "Pieza")
            {
                // 2. Verificamos que el TextBox no sea nulo y tenga texto
                if (!string.IsNullOrEmpty(textStock.Text) && textStock.Text.Contains("."))
                {
                    textStock.Clear();
                    LabelError2.Text = "Categoria pieza: No se permiten stock en decimales.";
                    LabelError2.Visible = true;
                    LabelError2.ForeColor = Color.Red;
                }
            }
            else
            {
                // Si cambia a otra cosa (como Kilo), ocultamos el error
                LabelError2.Visible = false;
            }
        }

        private void btnBuscarI_Click(object sender, EventArgs e)
        {
            string id = string.IsNullOrWhiteSpace(textBuscarID.Text) || textBuscarID.Text == "Ej: 4011" ? null : textBuscarID.Text.Trim();

            string categoria = cbCategoria.SelectedItem == null ? null : cbCategoria.SelectedItem.ToString();
            string estado = cbEstado.SelectedItem == null ? null : cbEstado.SelectedItem.ToString();

            var lista = _ServicioInventario.Buscar_Productos(id, categoria, estado, out string errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                LabelError.Text = errorMessage;
                LabelError.Visible = true;
                return;
            }

            // Reutilizamos la misma lógica de CargarInventario pero con la lista filtrada
            CargarInventario(lista);
        }

        private void dtgBDInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarI_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnBuscarI, e, 15);
        }
    }

}
