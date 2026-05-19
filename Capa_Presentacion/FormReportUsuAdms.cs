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
    public partial class FormReportUsuAdms : Form
    {
        public FormReportUsuAdms()
        {
            InitializeComponent();
        }

        private void FormReportUsuAdms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetVerUsuarios.UsuariosAdms' table. You can move, or remove it, as needed.
            this.usuariosAdmsTableAdapter.Fill(this.datasetVerUsuarios.UsuariosAdms);

            this.reportViewer1.RefreshReport();
        }
    }
}
