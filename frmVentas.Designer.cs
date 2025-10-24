namespace pryLantieriGestionInventario
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.tabArticulos = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.dtpCreado = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCambio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbxEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxPromocion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxArticuloViejo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPrecioMayor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioMenor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioCosto = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxRubro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxTalle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxTemporada = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxMarca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigoArticulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCreado = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.lblArticuloViejo = new System.Windows.Forms.Label();
            this.lblPrecioMayor = new System.Windows.Forms.Label();
            this.lblPrecioMenor = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTalle = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.tabArticulos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabArticulos
            // 
            this.tabArticulos.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabArticulos.Controls.Add(this.tabPage2);
            this.tabArticulos.ItemSize = new System.Drawing.Size(180, 40);
            this.tabArticulos.Location = new System.Drawing.Point(36, 12);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.SelectedIndex = 0;
            this.tabArticulos.Size = new System.Drawing.Size(998, 427);
            this.tabArticulos.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabArticulos.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabArticulos.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabArticulos.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabArticulos.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabArticulos.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabArticulos.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabArticulos.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabArticulos.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabArticulos.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabArticulos.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabArticulos.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabArticulos.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabArticulos.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabArticulos.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabArticulos.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabArticulos.TabIndex = 0;
            this.tabArticulos.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.btnVolver);
            this.tabPage2.Controls.Add(this.dtpCreado);
            this.tabPage2.Controls.Add(this.dtpCambio);
            this.tabPage2.Controls.Add(this.cbxEstado);
            this.tabPage2.Controls.Add(this.cbxPromocion);
            this.tabPage2.Controls.Add(this.cbxArticuloViejo);
            this.tabPage2.Controls.Add(this.txtPrecioMayor);
            this.tabPage2.Controls.Add(this.txtPrecioMenor);
            this.tabPage2.Controls.Add(this.txtPrecioCosto);
            this.tabPage2.Controls.Add(this.cbxRubro);
            this.tabPage2.Controls.Add(this.cbxSexo);
            this.tabPage2.Controls.Add(this.cbxTalle);
            this.tabPage2.Controls.Add(this.cbxTemporada);
            this.tabPage2.Controls.Add(this.cbxMarca);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.txtCodigoArticulo);
            this.tabPage2.Controls.Add(this.lblCreado);
            this.tabPage2.Controls.Add(this.lblCambio);
            this.tabPage2.Controls.Add(this.lblEstado);
            this.tabPage2.Controls.Add(this.lblPromocion);
            this.tabPage2.Controls.Add(this.lblArticuloViejo);
            this.tabPage2.Controls.Add(this.lblPrecioMayor);
            this.tabPage2.Controls.Add(this.lblPrecioMenor);
            this.tabPage2.Controls.Add(this.lblPrecioCosto);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.lblRubro);
            this.tabPage2.Controls.Add(this.lblSexo);
            this.tabPage2.Controls.Add(this.lblTalle);
            this.tabPage2.Controls.Add(this.lblTemporada);
            this.tabPage2.Controls.Add(this.lblMarca);
            this.tabPage2.Controls.Add(this.lblCodigoArticulo);
            this.tabPage2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artículos";
            // 
            // btnVolver
            // 
            this.btnVolver.Animated = true;
            this.btnVolver.AutoRoundedCorners = true;
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.Goldenrod;
            this.btnVolver.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(708, 6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 38);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtpCreado
            // 
            this.dtpCreado.Checked = true;
            this.dtpCreado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCreado.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCreado.Location = new System.Drawing.Point(513, 369);
            this.dtpCreado.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCreado.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCreado.Name = "dtpCreado";
            this.dtpCreado.Size = new System.Drawing.Size(248, 36);
            this.dtpCreado.TabIndex = 29;
            this.dtpCreado.Value = new System.DateTime(2025, 9, 16, 18, 55, 52, 518);
            // 
            // dtpCambio
            // 
            this.dtpCambio.Checked = true;
            this.dtpCambio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCambio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCambio.Location = new System.Drawing.Point(132, 369);
            this.dtpCambio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCambio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCambio.Name = "dtpCambio";
            this.dtpCambio.Size = new System.Drawing.Size(248, 36);
            this.dtpCambio.TabIndex = 28;
            this.dtpCambio.Value = new System.DateTime(2025, 9, 16, 18, 55, 52, 518);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoRoundedCorners = true;
            this.cbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbxEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxEstado.ItemHeight = 30;
            this.cbxEstado.Location = new System.Drawing.Point(513, 252);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(105, 36);
            this.cbxEstado.TabIndex = 27;
            // 
            // cbxPromocion
            // 
            this.cbxPromocion.AutoRoundedCorners = true;
            this.cbxPromocion.BackColor = System.Drawing.Color.Transparent;
            this.cbxPromocion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPromocion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPromocion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPromocion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPromocion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPromocion.ItemHeight = 30;
            this.cbxPromocion.Location = new System.Drawing.Point(513, 210);
            this.cbxPromocion.Name = "cbxPromocion";
            this.cbxPromocion.Size = new System.Drawing.Size(105, 36);
            this.cbxPromocion.TabIndex = 26;
            // 
            // cbxArticuloViejo
            // 
            this.cbxArticuloViejo.AutoRoundedCorners = true;
            this.cbxArticuloViejo.BackColor = System.Drawing.Color.Transparent;
            this.cbxArticuloViejo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxArticuloViejo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticuloViejo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxArticuloViejo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxArticuloViejo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxArticuloViejo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxArticuloViejo.ItemHeight = 30;
            this.cbxArticuloViejo.Location = new System.Drawing.Point(513, 159);
            this.cbxArticuloViejo.Name = "cbxArticuloViejo";
            this.cbxArticuloViejo.Size = new System.Drawing.Size(105, 36);
            this.cbxArticuloViejo.TabIndex = 25;
            // 
            // txtPrecioMayor
            // 
            this.txtPrecioMayor.AutoRoundedCorners = true;
            this.txtPrecioMayor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioMayor.DefaultText = "";
            this.txtPrecioMayor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioMayor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioMayor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioMayor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioMayor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioMayor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioMayor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioMayor.Location = new System.Drawing.Point(513, 121);
            this.txtPrecioMayor.Name = "txtPrecioMayor";
            this.txtPrecioMayor.PlaceholderText = "";
            this.txtPrecioMayor.SelectedText = "";
            this.txtPrecioMayor.Size = new System.Drawing.Size(105, 23);
            this.txtPrecioMayor.TabIndex = 24;
            // 
            // txtPrecioMenor
            // 
            this.txtPrecioMenor.AutoRoundedCorners = true;
            this.txtPrecioMenor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioMenor.DefaultText = "";
            this.txtPrecioMenor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioMenor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioMenor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioMenor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioMenor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioMenor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioMenor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioMenor.Location = new System.Drawing.Point(513, 79);
            this.txtPrecioMenor.Name = "txtPrecioMenor";
            this.txtPrecioMenor.PlaceholderText = "";
            this.txtPrecioMenor.SelectedText = "";
            this.txtPrecioMenor.Size = new System.Drawing.Size(105, 23);
            this.txtPrecioMenor.TabIndex = 23;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.AutoRoundedCorners = true;
            this.txtPrecioCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioCosto.DefaultText = "";
            this.txtPrecioCosto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioCosto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioCosto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioCosto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioCosto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioCosto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioCosto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioCosto.Location = new System.Drawing.Point(513, 33);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.PlaceholderText = "";
            this.txtPrecioCosto.SelectedText = "";
            this.txtPrecioCosto.Size = new System.Drawing.Size(105, 23);
            this.txtPrecioCosto.TabIndex = 22;
            // 
            // cbxRubro
            // 
            this.cbxRubro.AutoRoundedCorners = true;
            this.cbxRubro.BackColor = System.Drawing.Color.Transparent;
            this.cbxRubro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRubro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRubro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRubro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxRubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxRubro.ItemHeight = 30;
            this.cbxRubro.Location = new System.Drawing.Point(132, 252);
            this.cbxRubro.Name = "cbxRubro";
            this.cbxRubro.Size = new System.Drawing.Size(75, 36);
            this.cbxRubro.TabIndex = 21;
            // 
            // cbxSexo
            // 
            this.cbxSexo.AutoRoundedCorners = true;
            this.cbxSexo.BackColor = System.Drawing.Color.Transparent;
            this.cbxSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxSexo.ItemHeight = 30;
            this.cbxSexo.Location = new System.Drawing.Point(132, 210);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(75, 36);
            this.cbxSexo.TabIndex = 20;
            // 
            // cbxTalle
            // 
            this.cbxTalle.AutoRoundedCorners = true;
            this.cbxTalle.BackColor = System.Drawing.Color.Transparent;
            this.cbxTalle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTalle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTalle.ItemHeight = 30;
            this.cbxTalle.Location = new System.Drawing.Point(132, 159);
            this.cbxTalle.Name = "cbxTalle";
            this.cbxTalle.Size = new System.Drawing.Size(75, 36);
            this.cbxTalle.TabIndex = 19;
            // 
            // cbxTemporada
            // 
            this.cbxTemporada.AutoRoundedCorners = true;
            this.cbxTemporada.BackColor = System.Drawing.Color.Transparent;
            this.cbxTemporada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTemporada.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTemporada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTemporada.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTemporada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTemporada.ItemHeight = 30;
            this.cbxTemporada.Location = new System.Drawing.Point(132, 108);
            this.cbxTemporada.Name = "cbxTemporada";
            this.cbxTemporada.Size = new System.Drawing.Size(75, 36);
            this.cbxTemporada.TabIndex = 18;
            // 
            // cbxMarca
            // 
            this.cbxMarca.AutoRoundedCorners = true;
            this.cbxMarca.BackColor = System.Drawing.Color.Transparent;
            this.cbxMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxMarca.ItemHeight = 30;
            this.cbxMarca.Location = new System.Drawing.Point(132, 66);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(75, 36);
            this.cbxMarca.TabIndex = 17;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoRoundedCorners = true;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(132, 315);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(215, 23);
            this.txtNombre.TabIndex = 16;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.AutoRoundedCorners = true;
            this.txtCodigoArticulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoArticulo.DefaultText = "";
            this.txtCodigoArticulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoArticulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoArticulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoArticulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoArticulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoArticulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoArticulo.Location = new System.Drawing.Point(132, 33);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.PlaceholderText = "";
            this.txtCodigoArticulo.SelectedText = "";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(215, 23);
            this.txtCodigoArticulo.TabIndex = 15;
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.Location = new System.Drawing.Point(449, 369);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(58, 19);
            this.lblCreado.TabIndex = 14;
            this.lblCreado.Text = "Fecha:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(56, 369);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(70, 19);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "Cambio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(442, 269);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(65, 19);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.Location = new System.Drawing.Point(415, 227);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(92, 19);
            this.lblPromocion.TabIndex = 11;
            this.lblPromocion.Text = "Promoción:";
            // 
            // lblArticuloViejo
            // 
            this.lblArticuloViejo.AutoSize = true;
            this.lblArticuloViejo.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloViejo.Location = new System.Drawing.Point(398, 176);
            this.lblArticuloViejo.Name = "lblArticuloViejo";
            this.lblArticuloViejo.Size = new System.Drawing.Size(109, 19);
            this.lblArticuloViejo.TabIndex = 10;
            this.lblArticuloViejo.Text = "Artículo viejo:";
            // 
            // lblPrecioMayor
            // 
            this.lblPrecioMayor.AutoSize = true;
            this.lblPrecioMayor.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMayor.Location = new System.Drawing.Point(397, 125);
            this.lblPrecioMayor.Name = "lblPrecioMayor";
            this.lblPrecioMayor.Size = new System.Drawing.Size(110, 19);
            this.lblPrecioMayor.TabIndex = 9;
            this.lblPrecioMayor.Text = "Precio mayor:";
            // 
            // lblPrecioMenor
            // 
            this.lblPrecioMenor.AutoSize = true;
            this.lblPrecioMenor.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMenor.Location = new System.Drawing.Point(396, 83);
            this.lblPrecioMenor.Name = "lblPrecioMenor";
            this.lblPrecioMenor.Size = new System.Drawing.Size(111, 19);
            this.lblPrecioMenor.TabIndex = 8;
            this.lblPrecioMenor.Text = "Precio menor:";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCosto.Location = new System.Drawing.Point(403, 37);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(104, 19);
            this.lblPrecioCosto.TabIndex = 7;
            this.lblPrecioCosto.Text = "Precio costo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(53, 315);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(69, 269);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(57, 19);
            this.lblRubro.TabIndex = 5;
            this.lblRubro.Text = "Rubro:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(76, 227);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 19);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalle.Location = new System.Drawing.Point(78, 176);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(48, 19);
            this.lblTalle.TabIndex = 3;
            this.lblTalle.Text = "Talle:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.Location = new System.Drawing.Point(30, 125);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(96, 19);
            this.lblTemporada.TabIndex = 2;
            this.lblTemporada.Text = "Temporada:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(66, 83);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(60, 19);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(2, 37);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(124, 19);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Código artículo:";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1061, 533);
            this.Controls.Add(this.tabArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.tabArticulos.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabArticulos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblArticuloViejo;
        private System.Windows.Forms.Label lblPrecioMayor;
        private System.Windows.Forms.Label lblPrecioMenor;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPromocion;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCreado;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCambio;
        private Guna.UI2.WinForms.Guna2ComboBox cbxEstado;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPromocion;
        private Guna.UI2.WinForms.Guna2ComboBox cbxArticuloViejo;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioMayor;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioMenor;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioCosto;
        private Guna.UI2.WinForms.Guna2ComboBox cbxRubro;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSexo;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTalle;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTemporada;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
    }
}