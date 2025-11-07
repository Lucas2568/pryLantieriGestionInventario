namespace pryLantieriGestionInventario
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.btnVentas = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buscarProducto = new System.Windows.Forms.TabPage();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbxCategoriaBuscar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBuscarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.dgvBuscar = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTexto = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            this.buscarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrincipal);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.buscarProducto);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPrincipal.Controls.Add(this.btnVentas);
            this.tabPrincipal.Controls.Add(this.txtNombre);
            this.tabPrincipal.Controls.Add(this.cbxCategoria);
            this.tabPrincipal.Controls.Add(this.btnEliminar);
            this.tabPrincipal.Controls.Add(this.btnGuardar);
            this.tabPrincipal.Controls.Add(this.btnModificar);
            this.tabPrincipal.Controls.Add(this.btnBuscar);
            this.tabPrincipal.Controls.Add(this.txtDescripcion);
            this.tabPrincipal.Controls.Add(this.txtPrecio);
            this.tabPrincipal.Controls.Add(this.txtStock);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.lblCategoria);
            this.tabPrincipal.Controls.Add(this.lblStock);
            this.tabPrincipal.Controls.Add(this.lblPrecio);
            this.tabPrincipal.Controls.Add(this.lblDescripcion);
            this.tabPrincipal.Controls.Add(this.lblNombre);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(844, 498);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVentas.Location = new System.Drawing.Point(563, 337);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(120, 33);
            this.btnVentas.TabIndex = 19;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 146);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(563, 176);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(53, 21);
            this.cbxCategoria.Sorted = true;
            this.cbxCategoria.TabIndex = 17;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Khaki;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(433, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 33);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Khaki;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(165, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 33);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Khaki;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(303, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 33);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Khaki;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(323, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 33);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(244, 193);
            this.txtDescripcion.MaxLength = 3000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 112);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(563, 136);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(563, 94);
            this.txtStock.MaxLength = 10;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(244, 94);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(460, 176);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 21);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(489, 94);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 21);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(489, 136);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 21);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(130, 240);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 21);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(161, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(170, 94);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(68, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 498);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Gráfico de datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartProductos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProductos.Legends.Add(legend1);
            this.chartProductos.Location = new System.Drawing.Point(60, 28);
            this.chartProductos.Name = "chartProductos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProductos.Series.Add(series1);
            this.chartProductos.Size = new System.Drawing.Size(756, 451);
            this.chartProductos.TabIndex = 0;
            this.chartProductos.Text = "chart1";
            // 
            // buscarProducto
            // 
            this.buscarProducto.BackColor = System.Drawing.Color.Silver;
            this.buscarProducto.Controls.Add(this.txtTexto);
            this.buscarProducto.Controls.Add(this.dgvBuscar);
            this.buscarProducto.Controls.Add(this.btnBuscarProducto);
            this.buscarProducto.Controls.Add(this.cbxCategoriaBuscar);
            this.buscarProducto.Controls.Add(this.lblBuscarPor);
            this.buscarProducto.Location = new System.Drawing.Point(4, 22);
            this.buscarProducto.Name = "buscarProducto";
            this.buscarProducto.Padding = new System.Windows.Forms.Padding(3);
            this.buscarProducto.Size = new System.Drawing.Size(844, 498);
            this.buscarProducto.TabIndex = 2;
            this.buscarProducto.Text = "Buscar";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(51, 54);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(130, 27);
            this.lblBuscarPor.TabIndex = 0;
            this.lblBuscarPor.Text = "Buscar Por:";
            // 
            // cbxCategoriaBuscar
            // 
            this.cbxCategoriaBuscar.AutoRoundedCorners = true;
            this.cbxCategoriaBuscar.BackColor = System.Drawing.Color.Transparent;
            this.cbxCategoriaBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategoriaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoriaBuscar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategoriaBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategoriaBuscar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxCategoriaBuscar.ItemHeight = 30;
            this.cbxCategoriaBuscar.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Categoría"});
            this.cbxCategoriaBuscar.Location = new System.Drawing.Point(187, 45);
            this.cbxCategoriaBuscar.Name = "cbxCategoriaBuscar";
            this.cbxCategoriaBuscar.Size = new System.Drawing.Size(208, 36);
            this.cbxCategoriaBuscar.TabIndex = 1;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AutoRoundedCorners = true;
            this.btnBuscarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarProducto.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(640, 44);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(180, 37);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvBuscar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBuscar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscar.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Stock,
            this.Categoria});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuscar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBuscar.Location = new System.Drawing.Point(56, 120);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersVisible = false;
            this.dgvBuscar.Size = new System.Drawing.Size(764, 346);
            this.dgvBuscar.TabIndex = 3;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBuscar.ThemeStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBuscar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBuscar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBuscar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBuscar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBuscar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBuscar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvBuscar.ThemeStyle.ReadOnly = false;
            this.dgvBuscar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBuscar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuscar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBuscar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBuscar.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBuscar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBuscar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            // 
            // txtTexto
            // 
            this.txtTexto.AutoRoundedCorners = true;
            this.txtTexto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTexto.DefaultText = "";
            this.txtTexto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTexto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTexto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTexto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTexto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTexto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTexto.Location = new System.Drawing.Point(404, 44);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.PlaceholderText = "";
            this.txtTexto.SelectedText = "";
            this.txtTexto.Size = new System.Drawing.Size(226, 37);
            this.txtTexto.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(876, 548);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            this.buscarProducto.ResumeLayout(false);
            this.buscarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private System.Windows.Forms.TabPage buscarProducto;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private Guna.UI2.WinForms.Guna2Button btnBuscarProducto;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategoriaBuscar;
        private System.Windows.Forms.Label lblBuscarPor;
        private Guna.UI2.WinForms.Guna2TextBox txtTexto;
    }
}