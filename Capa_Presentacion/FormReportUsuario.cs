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
    public partial class FormReportUsuario : Form
    {
        public FormReportUsuario()
        {
            InitializeComponent();
        }

        private void FormReportUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetVerUsuarios1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.datasetVerUsuarios1.Usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
