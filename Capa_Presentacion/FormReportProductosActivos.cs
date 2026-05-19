using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FormReportProductosActivos : Form
    {
        public static FormReportProductosActivos formulario = null;
        public FormReportProductosActivos()
        {
            InitializeComponent();
        }
        public static FormReportProductosActivos LlamarFormulario
        {
            get
            {
                if(formulario == null || formulario.IsDisposed)
                {
                    formulario = new FormReportProductosActivos();
                }
                return formulario;
            }
        }


        private void FormReportProductosActivos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetVerUsuarios.ProductosActivosProc' table. You can move, or remove it, as needed.
            this.productosActivosProcTableAdapter.Fill(this.datasetVerUsuarios.ProductosActivosProc);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
