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
    public partial class FormReportProductosInactivos : Form
    {
        public FormReportProductosInactivos()
        {
            InitializeComponent();
        }

        private void FormReportProductosInactivos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetVerUsuarios.ProductosInactivosProc' table. You can move, or remove it, as needed.
            this.productosInactivosProcTableAdapter.Fill(this.datasetVerUsuarios.ProductosInactivosProc);

            this.reportViewer1.RefreshReport();
        }
    }
}
