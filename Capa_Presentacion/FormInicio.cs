using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Capa_Presentacion
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();

            timer1.Tick += Timer_Tick;

 
            timer1.Interval = 1000;


            timer1.Start();

            timerFecha.Tick += Timer_Tick;


            timerFecha.Interval = 1000;


            timerFecha.Start();

            labelReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            Capa_LogicaNegocio.Negocio_Productos negocioProductos = new Capa_LogicaNegocio.Negocio_Productos();
            DataTable dataTable = negocioProductos.ListarProductos();

            chart1.Series.Clear();
            chart1.Series.Add("Precio");


            foreach (DataRow row in dataTable.Rows)
            {
                string producto = row["Descripcion"].ToString();
                decimal precio = Convert.ToDecimal(row["Precio"]);

                chart1.Series["Precio"].Points.AddXY(producto, precio);
            }
            chart1.Series["Precio"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            labelReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            ActualizarFecha();
        }

        private void ActualizarFecha()
        {
 
            DateTime fechaActual = DateTime.Now;

            string formatoFecha = $"dddd, dd/MM/yyyy";


            labelFecha.Text = fechaActual.ToString(formatoFecha);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
