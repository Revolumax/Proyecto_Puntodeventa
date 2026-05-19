namespace Capa_Presentacion
{
    partial class FormReportUsuario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datasetVerUsuarios = new Capa_Presentacion.DatasetVerUsuarios();
            this.datasetVerUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetVerUsuarios1 = new Capa_Presentacion.DatasetVerUsuarios();
            this.datasetVerUsuarios1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Capa_Presentacion.DatasetVerUsuariosTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.ReporteUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(720, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // datasetVerUsuarios
            // 
            this.datasetVerUsuarios.DataSetName = "DatasetVerUsuarios";
            this.datasetVerUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datasetVerUsuariosBindingSource
            // 
            this.datasetVerUsuariosBindingSource.DataSource = this.datasetVerUsuarios;
            this.datasetVerUsuariosBindingSource.Position = 0;
            // 
            // datasetVerUsuarios1
            // 
            this.datasetVerUsuarios1.DataSetName = "DatasetVerUsuarios";
            this.datasetVerUsuarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datasetVerUsuarios1BindingSource
            // 
            this.datasetVerUsuarios1BindingSource.DataSource = this.datasetVerUsuarios1;
            this.datasetVerUsuarios1BindingSource.Position = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.datasetVerUsuarios1BindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 619);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportUsuario";
            this.Text = "FormReportUsuario";
            this.Load += new System.EventHandler(this.FormReportUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatasetVerUsuarios datasetVerUsuarios;
        private System.Windows.Forms.BindingSource datasetVerUsuariosBindingSource;
        private System.Windows.Forms.BindingSource datasetVerUsuarios1BindingSource;
        private DatasetVerUsuarios datasetVerUsuarios1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DatasetVerUsuariosTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}