namespace Capa_Presentacion
{
    partial class FormReportProductosActivos
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
            this.productosActivosProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetVerUsuarios = new Capa_Presentacion.DatasetVerUsuarios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productosActivosProcTableAdapter = new Capa_Presentacion.DatasetVerUsuariosTableAdapters.ProductosActivosProcTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosActivosProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // productosActivosProcBindingSource
            // 
            this.productosActivosProcBindingSource.DataMember = "ProductosActivosProc";
            this.productosActivosProcBindingSource.DataSource = this.datasetVerUsuarios;
            // 
            // datasetVerUsuarios
            // 
            this.datasetVerUsuarios.DataSetName = "DatasetVerUsuarios";
            this.datasetVerUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.productosActivosProcBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.ReporteProductosActivos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(704, 580);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // productosActivosProcTableAdapter
            // 
            this.productosActivosProcTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportProductosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 580);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportProductosActivos";
            this.Text = "FormReportProductosActivos";
            this.Load += new System.EventHandler(this.FormReportProductosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosActivosProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVerUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatasetVerUsuarios datasetVerUsuarios;
        private System.Windows.Forms.BindingSource productosActivosProcBindingSource;
        private DatasetVerUsuariosTableAdapters.ProductosActivosProcTableAdapter productosActivosProcTableAdapter;
    }
}