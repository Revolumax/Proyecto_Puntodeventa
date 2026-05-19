using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using Capa_LogicaNegocio;




namespace Capa_Presentacion
{
    public partial class FormPresentacion : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FormPresentacion(Autenticacion.Datos info)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
           Primary.BlueGrey700, Primary.BlueGrey900,
           Primary.BlueGrey800, Accent.Red200,
           TextShade.WHITE
       );

            lblUsuarioNom.Text = info.usuario;

            string rol = Negocio_Usuario.ObtenerRol(lblUsuarioNom.Text);

            if (rol == "Administrador")
            {
                lblRol.Text = "Administrador";
               
            }
            else if (rol == "Cajero")
            {
                lblRol.Text = "Cajero";
                btnUsuarios.Enabled = false;
            }


            

        }

        private void FormPresentacion_Load(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            AbrirFormularioEnPanel(formInicio);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
    
            Autenticacion autenticacion = new Autenticacion();
            autenticacion.ShowDialog();
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            if(this.panel_contenedor.Controls.Count > 0)
            {
                this.panel_contenedor.Controls.RemoveAt(0);
            }


            formulario.TopLevel = false;  // Establece TopLevel en false para que no sea un formulario independiente
            formulario.FormBorderStyle = FormBorderStyle.None;  // Quita el borde del formulario
            formulario.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(formulario);  // Agrega el formulario al panel
            formulario.Show();  // Muestra el formulario
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            AbrirFormularioEnPanel(formUsuarios);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            AbrirFormularioEnPanel(formInicio);
            
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            AbrirFormularioEnPanel(formProductos);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new FormReportes();
            AbrirFormularioEnPanel(formReportes);
        }
    }
}
