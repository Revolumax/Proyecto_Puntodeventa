namespace Capa_Presentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.comboboxRol = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarUsu = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsu = new FontAwesome.Sharp.IconButton();
            this.btnEditUsu = new FontAwesome.Sharp.IconButton();
            this.btnBuscarUsu = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarUsu = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.txtcontraseñaUsu = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.txtUsu = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.txtNombreUsu = new Proyecto_ListaTareas.ControladoresDinamicos.Modificador();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.dtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgUsuarios.EnableHeadersVisualStyles = false;
            this.dtgUsuarios.Location = new System.Drawing.Point(12, 329);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.RowTemplate.Height = 32;
            this.dtgUsuarios.Size = new System.Drawing.Size(693, 278);
            this.dtgUsuarios.TabIndex = 4;
            this.dtgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellClick);
            this.dtgUsuarios.SelectionChanged += new System.EventHandler(this.dtgUsuarios_SelectionChanged);
            // 
            // comboboxRol
            // 
            this.comboboxRol.AutoResize = false;
            this.comboboxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboboxRol.Depth = 0;
            this.comboboxRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboboxRol.DropDownHeight = 174;
            this.comboboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxRol.DropDownWidth = 121;
            this.comboboxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboboxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboboxRol.FormattingEnabled = true;
            this.comboboxRol.IntegralHeight = false;
            this.comboboxRol.ItemHeight = 43;
            this.comboboxRol.Items.AddRange(new object[] {
            "Cajero",
            "Administrador"});
            this.comboboxRol.Location = new System.Drawing.Point(266, 129);
            this.comboboxRol.MaxDropDownItems = 4;
            this.comboboxRol.MouseState = MaterialSkin.MouseState.OUT;
            this.comboboxRol.Name = "comboboxRol";
            this.comboboxRol.Size = new System.Drawing.Size(198, 49);
            this.comboboxRol.StartIndex = 0;
            this.comboboxRol.TabIndex = 9;
            this.comboboxRol.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(261, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cree una contraseña";
            // 
            // btnAgregarUsu
            // 
            this.btnAgregarUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnAgregarUsu.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsu.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsu.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarUsu.IconColor = System.Drawing.Color.White;
            this.btnAgregarUsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarUsu.IconSize = 38;
            this.btnAgregarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsu.Location = new System.Drawing.Point(12, 276);
            this.btnAgregarUsu.Name = "btnAgregarUsu";
            this.btnAgregarUsu.Size = new System.Drawing.Size(134, 38);
            this.btnAgregarUsu.TabIndex = 14;
            this.btnAgregarUsu.Text = "Agregar";
            this.btnAgregarUsu.UseVisualStyleBackColor = false;
            this.btnAgregarUsu.Click += new System.EventHandler(this.btnAgregarUsu_Click);
            // 
            // btnEliminarUsu
            // 
            this.btnEliminarUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnEliminarUsu.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsu.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsu.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarUsu.IconColor = System.Drawing.Color.White;
            this.btnEliminarUsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUsu.IconSize = 38;
            this.btnEliminarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUsu.Location = new System.Drawing.Point(171, 276);
            this.btnEliminarUsu.Name = "btnEliminarUsu";
            this.btnEliminarUsu.Size = new System.Drawing.Size(134, 38);
            this.btnEliminarUsu.TabIndex = 16;
            this.btnEliminarUsu.Text = "Eliminar";
            this.btnEliminarUsu.UseVisualStyleBackColor = false;
            this.btnEliminarUsu.Click += new System.EventHandler(this.btnEliminarUsu_Click);
            // 
            // btnEditUsu
            // 
            this.btnEditUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnEditUsu.FlatAppearance.BorderSize = 0;
            this.btnEditUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsu.ForeColor = System.Drawing.Color.White;
            this.btnEditUsu.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditUsu.IconColor = System.Drawing.Color.White;
            this.btnEditUsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditUsu.IconSize = 38;
            this.btnEditUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUsu.Location = new System.Drawing.Point(330, 276);
            this.btnEditUsu.Name = "btnEditUsu";
            this.btnEditUsu.Size = new System.Drawing.Size(134, 38);
            this.btnEditUsu.TabIndex = 17;
            this.btnEditUsu.Text = "Editar";
            this.btnEditUsu.UseVisualStyleBackColor = false;
            this.btnEditUsu.Click += new System.EventHandler(this.btnEditUsu_Click);
            // 
            // btnBuscarUsu
            // 
            this.btnBuscarUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnBuscarUsu.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsu.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsu.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarUsu.IconColor = System.Drawing.Color.White;
            this.btnBuscarUsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarUsu.IconSize = 38;
            this.btnBuscarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsu.Location = new System.Drawing.Point(484, 193);
            this.btnBuscarUsu.Name = "btnBuscarUsu";
            this.btnBuscarUsu.Size = new System.Drawing.Size(134, 38);
            this.btnBuscarUsu.TabIndex = 19;
            this.btnBuscarUsu.Text = "Buscar";
            this.btnBuscarUsu.UseVisualStyleBackColor = false;
            this.btnBuscarUsu.Click += new System.EventHandler(this.btnBuscarUsu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(479, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seleccione un rol";
            // 
            // txtBuscarUsu
            // 
            this.txtBuscarUsu.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarUsu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtBuscarUsu.BorderSize = 2;
            this.txtBuscarUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtBuscarUsu.Location = new System.Drawing.Point(12, 193);
            this.txtBuscarUsu.Name = "txtBuscarUsu";
            this.txtBuscarUsu.Padding = new System.Windows.Forms.Padding(7);
            this.txtBuscarUsu.PasswordChar = '\0';
            this.txtBuscarUsu.Size = new System.Drawing.Size(452, 39);
            this.txtBuscarUsu.TabIndex = 18;
            this.txtBuscarUsu.Texts = "";
            this.txtBuscarUsu.UnderlinedStyle = false;
            // 
            // txtcontraseñaUsu
            // 
            this.txtcontraseñaUsu.BackColor = System.Drawing.SystemColors.Window;
            this.txtcontraseñaUsu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtcontraseñaUsu.BorderSize = 2;
            this.txtcontraseñaUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseñaUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtcontraseñaUsu.Location = new System.Drawing.Point(266, 49);
            this.txtcontraseñaUsu.Name = "txtcontraseñaUsu";
            this.txtcontraseñaUsu.Padding = new System.Windows.Forms.Padding(7);
            this.txtcontraseñaUsu.PasswordChar = '\0';
            this.txtcontraseñaUsu.Size = new System.Drawing.Size(231, 39);
            this.txtcontraseñaUsu.TabIndex = 7;
            this.txtcontraseñaUsu.Texts = "";
            this.txtcontraseñaUsu.UnderlinedStyle = false;
            // 
            // txtUsu
            // 
            this.txtUsu.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtUsu.BorderSize = 2;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtUsu.Location = new System.Drawing.Point(12, 129);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsu.PasswordChar = '\0';
            this.txtUsu.Size = new System.Drawing.Size(231, 39);
            this.txtUsu.TabIndex = 6;
            this.txtUsu.Texts = "";
            this.txtUsu.UnderlinedStyle = false;
            // 
            // txtNombreUsu
            // 
            this.txtNombreUsu.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUsu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtNombreUsu.BorderSize = 2;
            this.txtNombreUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtNombreUsu.Location = new System.Drawing.Point(12, 49);
            this.txtNombreUsu.Name = "txtNombreUsu";
            this.txtNombreUsu.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombreUsu.PasswordChar = '\0';
            this.txtNombreUsu.Size = new System.Drawing.Size(231, 39);
            this.txtNombreUsu.TabIndex = 5;
            this.txtNombreUsu.Texts = "";
            this.txtNombreUsu.UnderlinedStyle = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 38;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(484, 276);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 38);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpíar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(667, 276);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(38, 37);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(728, 619);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscarUsu);
            this.Controls.Add(this.txtBuscarUsu);
            this.Controls.Add(this.btnEditUsu);
            this.Controls.Add(this.btnEliminarUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboboxRol);
            this.Controls.Add(this.txtcontraseñaUsu);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.txtNombreUsu);
            this.Controls.Add(this.dtgUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuarios;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtNombreUsu;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtUsu;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtcontraseñaUsu;
        private MaterialSkin.Controls.MaterialComboBox comboboxRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAgregarUsu;
        private FontAwesome.Sharp.IconButton btnEliminarUsu;
        private FontAwesome.Sharp.IconButton btnEditUsu;
        private Proyecto_ListaTareas.ControladoresDinamicos.Modificador txtBuscarUsu;
        private FontAwesome.Sharp.IconButton btnBuscarUsu;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnActualizar;
    }
}