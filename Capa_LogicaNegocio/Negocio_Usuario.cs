using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaNegocio
{
    public class Negocio_Usuario
    {
        //metodo para comprobar usuario
        public static int Logic(string usuario, string pass)
        {
            Datos_Usuario datos = new Datos_Usuario();
            return datos.Logic(usuario, pass); // Supongamos que tienes una clase específica para el acceso a datos de usuarios.
          
        }
        public static string ObtenerRol(string usuario)
        {
            Datos_Usuario datos = new Datos_Usuario();
            return datos.ObtenerRol(usuario);
        }

        public DataTable ListarUsuarios()
        {
            Datos_Usuario datosUsuario = new Datos_Usuario();
            return datosUsuario.ListarUsuarios();
        }

        public void InsertarUsuario(string nombre, string usuario, string contraseña, string rol)
        {
            Datos_Usuario datosUsuario = new Datos_Usuario();
            datosUsuario.InsertarUsuario(nombre, usuario, contraseña, rol);
        }
        public void EliminarUsuario(int usuarioID)
        {
            Datos_Usuario datosUsuario = new Datos_Usuario();
            datosUsuario.EliminarUsuario(usuarioID);
        }

        public DataTable BuscarUsuarioPorNombre(string nombreUsuario)
        {
            Datos_Usuario datosUsuario = new Datos_Usuario();
            return datosUsuario.BuscarUsuarioPorNombre(nombreUsuario);
        }

        public void ModificarUsuario(int usuarioID, string nombre, string usuario, string contraseña, string rol)
        {
            Datos_Usuario datosUsuario = new Datos_Usuario();
            datosUsuario.ModificarUsuario(usuarioID, nombre, usuario, contraseña, rol);
        }

    }
}
