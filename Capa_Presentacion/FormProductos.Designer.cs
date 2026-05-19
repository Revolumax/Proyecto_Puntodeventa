namespace Capa_Presentacion
{
    partial class FormProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarProduc = new FontAwesome.Sharp.IconButton();
            this.btnEditProduct = new FontAwesome.Sharp.IconButton();
            this.btnEliminarProduc = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProduc = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.btnLimpiarProducts = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.txtBuscarProduc = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.txtFechaVencimiento = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.txtProveedor = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.txtPrecio = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.txtDescripcion = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarProduc
            // 
            this.btnBuscarProduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnBuscarProduc.FlatAppearance.BorderSize = 0;
            this.btnBuscarProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProduc.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProduc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProduc.IconColor = System.Drawing.Color.White;
            this.btnBuscarProduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProduc.IconSize = 38;
            this.btnBuscarProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProduc.Location = new System.Drawing.Point(539, 254);
            this.btnBuscarProduc.Name = "btnBuscarProduc";
            this.btnBuscarProduc.Size = new System.Drawing.Size(134, 38);
            this.btnBuscarProduc.TabIndex = 32;
            this.btnBuscarProduc.Text = "Buscar";
            this.btnBuscarProduc.UseVisualStyleBackColor = false;
            this.btnBuscarProduc.Click += new System.EventHandler(this.btnBuscarProduc_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditProduct.IconColor = System.Drawing.Color.White;
            this.btnEditProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProduct.IconSize = 38;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(582, 183);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(134, 38);
            this.btnEditProduct.TabIndex = 30;
            this.btnEditProduct.Text = "Editar";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnEliminarProduc
            // 
            this.btnEliminarProduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnEliminarProduc.FlatAppearance.BorderSize = 0;
            this.btnEliminarProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProduc.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProduc.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarProduc.IconColor = System.Drawing.Color.White;
            this.btnEliminarProduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProduc.IconSize = 38;
            this.btnEliminarProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProduc.Location = new System.Drawing.Point(423, 183);
            this.btnEliminarProduc.Name = "btnEliminarProduc";
            this.btnEliminarProduc.Size = new System.Drawing.Size(134, 38);
            this.btnEliminarProduc.TabIndex = 29;
            this.btnEliminarProduc.Text = "Eliminar";
            this.btnEliminarProduc.UseVisualStyleBackColor = false;
            this.btnEliminarProduc.Click += new System.EventHandler(this.btnEliminarProduc_Click);
            // 
            // btnAgregarProduc
            // 
            this.btnAgregarProduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnAgregarProduc.FlatAppearance.BorderSize = 0;
            this.btnAgregarProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProduc.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProduc.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarProduc.IconColor = System.Drawing.Color.White;
            this.btnAgregarProduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProduc.IconSize = 38;
            this.btnAgregarProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProduc.Location = new System.Drawing.Point(264, 183);
            this.btnAgregarProduc.Name = "btnAgregarProduc";
            this.btnAgregarProduc.Size = new System.Drawing.Size(134, 38);
            this.btnAgregarProduc.TabIndex = 27;
            this.btnAgregarProduc.Text = "Agregar";
            this.btnAgregarProduc.UseVisualStyleBackColor = false;
            this.btnAgregarProduc.Click += new System.EventHandler(this.btnAgregarProduc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(262, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Descripcion";
            // 
            // comboboxEstado
            // 
            this.comboboxEstado.AutoResize = false;
            this.comboboxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboboxEstado.Depth = 0;
            this.comboboxEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboboxEstado.DropDownHeight = 174;
            this.comboboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxEstado.DropDownWidth = 121;
            this.comboboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboboxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboboxEstado.FormattingEnabled = true;
            this.comboboxEstado.IntegralHeight = false;
            this.comboboxEstado.ItemHeight = 43;
            this.comboboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboboxEstado.Location = new System.Drawing.Point(267, 107);
            this.comboboxEstado.MaxDropDownItems = 4;
            this.comboboxEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.comboboxEstado.Name = "comboboxEstado";
            this.comboboxEstado.Size = new System.Drawing.Size(198, 49);
            this.comboboxEstado.StartIndex = 0;
            this.comboboxEstado.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(8, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha de Vencimiento";
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.dtgProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.dtgProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductos.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgProductos.EnableHeadersVisualStyles = false;
            this.dtgProductos.Location = new System.Drawing.Point(13, 307);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersVisible = false;
            this.dtgProductos.RowTemplate.Height = 32;
            this.dtgProductos.Size = new System.Drawing.Size(703, 300);
            this.dtgProductos.TabIndex = 35;
            this.dtgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellClick);
            // 
            // btnLimpiarProducts
            // 
            this.btnLimpiarProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnLimpiarProducts.FlatAppearance.BorderSize = 0;
            this.btnLimpiarProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProducts.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarProducts.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarProducts.IconColor = System.Drawing.Color.White;
            this.btnLimpiarProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProducts.IconSize = 38;
            this.btnLimpiarProducts.Location = new System.Drawing.Point(504, 47);
            this.btnLimpiarProducts.Name = "btnLimpiarProducts";
            this.btnLimpiarProducts.Size = new System.Drawing.Size(34, 39);
            this.btnLimpiarProducts.TabIndex = 36;
            this.btnLimpiarProducts.UseVisualStyleBackColor = false;
            this.btnLimpiarProducts.Click += new System.EventHandler(this.btnLimpiarProducts_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 38;
            this.btnActualizar.Location = new System.Drawing.Point(544, 47);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(34, 39);
            this.btnActualizar.TabIndex = 37;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtBuscarProduc
            // 
            this.txtBuscarProduc.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarProduc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtBuscarProduc.BorderSize = 2;
            this.txtBuscarProduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtBuscarProduc.Location = new System.Drawing.Point(12, 253);
            this.txtBuscarProduc.Name = "txtBuscarProduc";
            this.txtBuscarProduc.Padding = new System.Windows.Forms.Padding(7);
            this.txtBuscarProduc.PasswordChar = '\0';
            this.txtBuscarProduc.Size = new System.Drawing.Size(506, 39);
            this.txtBuscarProduc.TabIndex = 34;
            this.txtBuscarProduc.Texts = "";
            this.txtBuscarProduc.UnderlinedStyle = false;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaVencimiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtFechaVencimiento.BorderSize = 2;
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtFechaVencimiento.Location = new System.Drawing.Point(13, 183);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Padding = new System.Windows.Forms.Padding(7);
            this.txtFechaVencimiento.PasswordChar = '\0';
            this.txtFechaVencimiento.Size = new System.Drawing.Size(231, 39);
            this.txtFechaVencimiento.TabIndex = 31;
            this.txtFechaVencimiento.Texts = "";
            this.txtFechaVencimiento.UnderlinedStyle = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtProveedor.BorderSize = 2;
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtProveedor.Location = new System.Drawing.Point(267, 47);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Padding = new System.Windows.Forms.Padding(7);
            this.txtProveedor.PasswordChar = '\0';
            this.txtProveedor.Size = new System.Drawing.Size(231, 39);
            this.txtProveedor.TabIndex = 22;
            this.txtProveedor.Texts = "";
            this.txtProveedor.UnderlinedStyle = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtPrecio.BorderSize = 2;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtPrecio.Location = new System.Drawing.Point(13, 117);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.Size = new System.Drawing.Size(231, 39);
            this.txtPrecio.TabIndex = 21;
            this.txtPrecio.Texts = "";
            this.txtPrecio.UnderlinedStyle = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtDescripcion.Location = new System.Drawing.Point(13, 47);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.Size = new System.Drawing.Size(231, 39);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.UnderlinedStyle = false;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 619);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiarProducts);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.txtBuscarProduc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarProduc);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnEliminarProduc);
            this.Controls.Add(this.btnAgregarProduc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboboxEstado);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBuscarProduc;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtFechaVencimiento;
        private FontAwesome.Sharp.IconButton btnEditProduct;
        private FontAwesome.Sharp.IconButton btnEliminarProduc;
        private FontAwesome.Sharp.IconButton btnAgregarProduc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox comboboxEstado;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtProveedor;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtPrecio;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtDescripcion;
        private System.Windows.Forms.Label label5;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtBuscarProduc;
        private System.Windows.Forms.DataGridView dtgProductos;
        private FontAwesome.Sharp.IconButton btnLimpiarProducts;
        private FontAwesome.Sharp.IconButton btnActualizar;
    }
}