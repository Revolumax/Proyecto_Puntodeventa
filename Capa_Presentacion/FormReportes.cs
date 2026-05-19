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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        public static FormReportes formulario = null;


        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnReportUsu_Click(object sender, EventArgs e)
        {
            FormReportUsuario formReportUsuario = new FormReportUsuario();
            formReportUsuario.ShowDialog();
        }

        private void btnReportProducto_Click(object sender, EventArgs e)
        {
            FormReportProducto formReportProducto = new FormReportProducto();
            formReportProducto.ShowDialog();
        }

        private void btnReportProductEnable_Click(object sender, EventArgs e)
        {
            FormReportProductosActivos.LlamarFormulario.Show();
        }

        private void btnProductDisable_Click(object sender, EventArgs e)
        {
            FormReportProductosInactivos formReportProductosInactivos = new FormReportProductosInactivos();
            formReportProductosInactivos.ShowDialog();
        }

        private void btnReportUsuAdm_Click(object sender, EventArgs e)
        {
            FormReportUsuAdms formReportUsuAdms = new FormReportUsuAdms();
            formReportUsuAdms.ShowDialog();
        }
    }
}
