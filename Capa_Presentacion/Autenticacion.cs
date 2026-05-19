using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaNegocio;

namespace Capa_Presentacion
{
    public partial class Autenticacion : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
   

        public Autenticacion()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
           Primary.BlueGrey700, Primary.BlueGrey900,
           Primary.BlueGrey800, Accent.Red200,
           TextShade.WHITE
       );

            txtContraseña.PasswordChar = '*';
        }

        public struct Datos
        {
            public string usuario;
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {
          
        }
        private Color HexToColor(string hex)
        {
            return Color.FromArgb(
                Convert.ToInt32(hex.Substring(1, 2), 16),
                Convert.ToInt32(hex.Substring(3, 2), 16),
                Convert.ToInt32(hex.Substring(5, 2), 16)
            );
        }

        private void CheckMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMostrar.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }

        public void rjButton1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Texts;
            string rol = Negocio_Usuario.ObtenerRol(usuario);
            int resultado = Negocio_Usuario.Logic(txtUsuario.Texts, txtContraseña.Texts);

            Datos info;
            info.usuario = txtUsuario.Texts;


            if (resultado == 1)
            {
                FormPresentacion presentacion = new FormPresentacion(info);
                MessageBox.Show($"Inicio de sesión exitoso. Usuario: {usuario}");
                presentacion.ShowDialog();
                this.Close();
            }
            else if(resultado == 0)
            {
                MessageBox.Show("No se pudo iniciar sesion, verifica tus credenciales");
            }

        }

    }
}
