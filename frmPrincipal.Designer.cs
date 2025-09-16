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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
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
            this.btnVentas = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrincipal);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 338);
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
            this.tabPrincipal.Size = new System.Drawing.Size(674, 312);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 71);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(450, 101);
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
            this.btnEliminar.Location = new System.Drawing.Point(320, 262);
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
            this.btnGuardar.Location = new System.Drawing.Point(52, 262);
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
            this.btnModificar.Location = new System.Drawing.Point(190, 262);
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
            this.btnBuscar.Location = new System.Drawing.Point(210, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 33);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(131, 118);
            this.txtDescripcion.MaxLength = 3000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 112);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(450, 61);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(450, 19);
            this.txtStock.MaxLength = 10;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(131, 19);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(347, 101);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 21);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(376, 19);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 21);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(376, 61);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 21);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(17, 165);
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
            this.lblNombre.Location = new System.Drawing.Point(48, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(57, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(68, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVentas.Location = new System.Drawing.Point(450, 262);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(120, 33);
            this.btnVentas.TabIndex = 19;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(723, 374);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
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
    }
}