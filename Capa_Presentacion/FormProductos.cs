using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaNegocio;

namespace Capa_Presentacion
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        private int usuarioSeleccionadoID;

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            Negocio_Productos negocioUsuario = new Negocio_Productos();
            DataTable tablaProductos = negocioUsuario.ListarProductos();
            dtgProductos.DataSource = tablaProductos;
        }

        private void btnAgregarProduc_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Texts;
            string precioStr = txtPrecio.Texts;
            string fechaVencimientoStr = txtFechaVencimiento.Texts;
            string proveedor = txtProveedor.Texts;
            string estado = comboboxEstado.Text;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(precioStr) || string.IsNullOrWhiteSpace(fechaVencimientoStr) || string.IsNullOrWhiteSpace(proveedor))
            {
                MessageBox.Show("Rellene los campos faltantes");
            }
            else
            {
                // Convertir el valor del precio a decimal
                if (decimal.TryParse(precioStr, out decimal precio))
                {
                    // Convertir el valor de la fecha de vencimiento a DateTime
                    if (DateTime.TryParse(fechaVencimientoStr, out DateTime fechaVencimiento))
                    {
                        Negocio_Productos negocioProductos = new Negocio_Productos();
                        negocioProductos.InsertarProducto(descripcion, precio, fechaVencimiento, proveedor, estado);
                        MessageBox.Show("Producto agregado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Formato de fecha de vencimiento no válido");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de precio no válido");
                }
            }

            CargarProductos();
        }

        private void btnEliminarProduc_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionadoID > 0)
            {
                // Usuario seleccionado válido, llamar al método de eliminación
                Negocio_Productos negocio_Productos = new Negocio_Productos();
                negocio_Productos.EliminarProducto(usuarioSeleccionadoID);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún usuario para eliminar.");
            }

            CargarProductos();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la primera columna (suponiendo que la primera columna es la columna 0)
                string valorPrimeraColumna = dtgProductos.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Almacenar el ID del usuario seleccionado
                if (int.TryParse(valorPrimeraColumna, out usuarioSeleccionadoID))
                {
                    // El valor se pudo convertir a un entero, ahora puedes usar usuarioSeleccionadoID
                }
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgProductos.Rows[e.RowIndex];

                // Asignar el valor de cada celda a los TextBox correspondientes
                txtDescripcion.Texts = fila.Cells["Descripcion"].Value.ToString();
                txtPrecio.Texts = fila.Cells["Precio"].Value.ToString();
                txtFechaVencimiento.Texts = fila.Cells["FechaVencimiento"].Value.ToString();
                txtProveedor.Texts = fila.Cells["Proveedor"].Value.ToString();
                comboboxEstado.Text = fila.Cells["Estado"].Value.ToString();
            }

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Texts;
            string precioStr = txtPrecio.Texts;
            string fechaVencimientoStr = txtFechaVencimiento.Texts;
            string proveedor = txtProveedor.Texts;
            string estado = comboboxEstado.Text;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(precioStr) || string.IsNullOrWhiteSpace(fechaVencimientoStr) || string.IsNullOrWhiteSpace(proveedor))
            {
                MessageBox.Show("Rellene los campos faltantes");
            }
            else
            {
                // Convertir el valor del precio a decimal
                if (decimal.TryParse(precioStr, out decimal precio))
                {
                    // Convertir el valor de la fecha de vencimiento a DateTime
                    if (DateTime.TryParse(fechaVencimientoStr, out DateTime fechaVencimiento))
                    {
                        Negocio_Productos negocioProductos = new Negocio_Productos();
                        negocioProductos.ActualizarProducto(usuarioSeleccionadoID, descripcion, precio, fechaVencimiento, proveedor, estado);
                        MessageBox.Show("Producto Editado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Formato de fecha de vencimiento no válido");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de precio no válido");
                }
            }

            CargarProductos();
        }

        private void btnLimpiarProducts_Click(object sender, EventArgs e)
        {
            LimpiarProductos();
        }

        private void LimpiarProductos()
        {
            txtDescripcion.Texts = "";
            txtPrecio.Texts = "";
            txtFechaVencimiento.Texts = "";
            txtProveedor.Texts = "";
            comboboxEstado.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnBuscarProduc_Click(object sender, EventArgs e)
        {
            string descripcion = txtBuscarProduc.Texts;

            Negocio_Productos negocio_Productos = new Negocio_Productos();
            DataTable resultado = negocio_Productos.BuscarProductoPorDescripcion(descripcion);

            dtgProductos.DataSource = resultado;
        }
    }
}
