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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private int usuarioSeleccionadoID;

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            Negocio_Usuario negocioUsuario = new Negocio_Usuario();
            DataTable tablaUsuarios = negocioUsuario.ListarUsuarios();
            dtgUsuarios.DataSource = tablaUsuarios;
        }

        private void btnAgregarUsu_Click(object sender, EventArgs e)
        {
            string nombreUsu = txtNombreUsu.Texts;
            string Usu = txtUsu.Texts;
            string Rol = comboboxRol.Text;
            string contraseña = txtcontraseñaUsu.Texts;

            if (nombreUsu == "" || Usu == "" || contraseña == "")
            {
                MessageBox.Show("Rellene los campos faltantes");
            }
            else
            {
                Negocio_Usuario negocioUsuario = new Negocio_Usuario();
                negocioUsuario.InsertarUsuario(nombreUsu, Usu, contraseña, Rol);

                ListarUsuarios();
                LimpiarTextsUsuarios();
            }
        }

        private void LimpiarTextsUsuarios()
        {
            txtNombreUsu.Texts = "";
            txtUsu.Texts = "";
            comboboxRol.Text = "";
            txtcontraseñaUsu.Texts = "";
        }

        private void btnEliminarUsu_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionadoID > 0)
            {
                // Usuario seleccionado válido, llamar al método de eliminación
                Negocio_Usuario negocioUsuario = new Negocio_Usuario();
                negocioUsuario.EliminarUsuario(usuarioSeleccionadoID);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún usuario para eliminar.");
            }

            ListarUsuarios();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la primera columna (suponiendo que la primera columna es la columna 0)
                string valorPrimeraColumna = dtgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Almacenar el ID del usuario seleccionado
                if (int.TryParse(valorPrimeraColumna, out usuarioSeleccionadoID))
                {
                    // El valor se pudo convertir a un entero, ahora puedes usar usuarioSeleccionadoID
                }
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgUsuarios.Rows[e.RowIndex];

                // Asignar el valor de cada celda a los TextBox correspondientes
                txtNombreUsu.Texts = fila.Cells["Nombre"].Value.ToString();
                txtUsu.Texts = fila.Cells["Usuario"].Value.ToString();
                txtcontraseñaUsu.Texts = fila.Cells["Contraseña"].Value.ToString();
                comboboxRol.Text = fila.Cells["Rol"].Value.ToString();
            }

        }

        private void btnEditUsu_Click(object sender, EventArgs e)
        {
            string nombreUsu = txtNombreUsu.Texts;
            string Usu = txtUsu.Texts;
            string Rol = comboboxRol.Text;
            string contraseña = txtcontraseñaUsu.Texts;

            Negocio_Usuario negocioUsuario = new Negocio_Usuario();
            negocioUsuario.ModificarUsuario(usuarioSeleccionadoID, nombreUsu, Usu, contraseña, Rol);

            ListarUsuarios();
        }

        private void dtgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dtgUsuarios.SelectedRows[0];

                // Asignar el valor de cada celda a los TextBox correspondientes
                txtNombreUsu.Texts = fila.Cells["Nombre"].Value.ToString();
                txtUsu.Texts = fila.Cells["Usuario"].Value.ToString();
                txtcontraseñaUsu.Texts = fila.Cells["Contraseña"].Value.ToString();
                comboboxRol.Text = fila.Cells["Rol"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextsUsuarios();
        }

        private void btnBuscarUsu_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtBuscarUsu.Texts;

            Negocio_Usuario negocioUsuario = new Negocio_Usuario();
            DataTable resultado = negocioUsuario.BuscarUsuarioPorNombre(nombreUsuario);

            dtgUsuarios.DataSource = resultado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
    }
}
