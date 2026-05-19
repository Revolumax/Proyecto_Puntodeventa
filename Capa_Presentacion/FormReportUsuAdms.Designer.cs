namespace Capa_Presentacion
{
    partial class FormReportUsuAdms
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
            this.usuariosAdmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosAdmsTableAdapter = new Capa_Presentacion.DatasetVerUsuariosTableAdapters.UsuariosAdmsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosAdmsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usuariosAdmsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.ReporteUsuariosAdministradores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(688, 541);
            this.reportViewer1.TabIndex = 0;
            // 
            // datasetVerUsuarios
            // 
            this.datasetVerUsuarios.DataSetName = "DatasetVerUsuarios";
            this.datasetVerUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosAdmsBindingSource
            // 
            this.usuariosAdmsBindingSource.DataMember = "UsuariosAdms";
            this.usuariosAdmsBindingSource.DataSource = this.datasetVerUsuarios;
            // 
            // usuariosAdmsTableAdapter
            // 
            this.usuariosAdmsTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportUsuAdms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 541);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportUsuAdms";
            this.Text = "FormReportUsuAdms";
            this.Load += new System.EventHandler(this.FormReportUsuAdms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosAdmsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatasetVerUsuarios datasetVerUsuarios;
        private System.Windows.Forms.BindingSource usuariosAdmsBindingSource;
        private DatasetVerUsuariosTableAdapters.UsuariosAdmsTableAdapter usuariosAdmsTableAdapter;
    }
}