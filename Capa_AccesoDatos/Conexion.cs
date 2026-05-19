using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    internal class Conexion
    {
        //variables privadas

        private string Base;
        private string Servidor;
        private bool Seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "Gestor_Inventario";
            this.Servidor = "DESKTOP-2R1OVB7\\SQLEXPRESS";
            this.Seguridad = true;
        }

        public SqlConnection ConexionBDInventario()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    connection.ConnectionString = connection.ConnectionString + "Integrated Security = SSPI";
                }

            }
            catch(Exception ex)
            {
                connection = null;
                throw ex;
            }

            return connection;

        }
        public static Conexion CrearInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
