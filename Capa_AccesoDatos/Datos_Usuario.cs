using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Capa_AccesoDatos
{
    public class Datos_Usuario
    {
        public int Logic(string usuario, string pass)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.CrearInstancia().ConexionBDInventario();
                SqlCommand cmd = new SqlCommand("splogin", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@pass", pass);
                conexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close(); //Cerramos conexion 
            }
            return -1;
        }

        public string ObtenerRol(string usuario)
        {
            string rol = null;

            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.CrearInstancia().ConexionBDInventario();
                SqlCommand cmd = new SqlCommand("spObtenerRolUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreUsuario", usuario);

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        rol = dr["Rol"].ToString();  // "Rol" es el nombre de la columna devuelta por el procedimiento
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close(); // Cerramos la conexión 
            }

            return rol;
        }


        public DataTable ListarUsuarios()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    // Consulta SQL para obtener datos de la tabla de usuarios
                    string consulta = "SELECT *FROM Usuarios";

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                        {
                            // Llenar el DataTable con los datos del adaptador
                            adaptador.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos de usuarios: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }

            return dataTable;
        }

        public void InsertarUsuario(string nombre, string usuario, string contraseña, string rol)
        {
            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsertarUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@Rol", rol);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar usuario: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
        }

        public void EliminarUsuario(int usuarioID)
        {
            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spEliminarUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
        }
        public void ModificarUsuario(int usuarioID, string nombre, string usuario, string contraseña, string rol)
        {
            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spModificarUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@Rol", rol);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar usuario: " + ex.Message);
                }
            }
        }


        public DataTable BuscarUsuarioPorNombre(string nombreUsuario)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spBuscarUsuarioPorNombre", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar nombre de usuario: " + ex.Message);
                }
            }

            return dataTable;
        }


    }
}
