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
    public class Datos_Productos
    {
        public DataTable ListarProductos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spListarProductos", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar productos: " + ex.Message);
                }
            }

            return dataTable;
        }

        public void InsertarProducto(string descripcion, decimal precio, DateTime fechaVencimiento, string proveedor, string estado)
        {
            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsertarProducto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros del procedimiento almacenado
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                        cmd.Parameters.AddWithValue("@Proveedor", proveedor);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar producto: " + ex.Message);
                }
            }
        }

        public void EliminarProducto(int productoID)
        {
            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spEliminarProducto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros del procedimiento almacenado
                        cmd.Parameters.AddWithValue("@ProductoID", productoID);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                }
            }
        }

        public void ActualizarProducto(int productoID, string descripcion, decimal precio, DateTime fechaVencimiento, string proveedor, string estado)
        {
            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spActualizarProducto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros del procedimiento almacenado
                        cmd.Parameters.AddWithValue("@ProductoID", productoID);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                        cmd.Parameters.AddWithValue("@Proveedor", proveedor);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar producto: " + ex.Message);
                }
            }
        }

        public DataTable BuscarProductoPorDescripcion(string descripcion)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = Conexion.CrearInstancia().ConexionBDInventario())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("spBuscarProductoPorDescripcion", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetro del procedimiento almacenado
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar producto por descripción: " + ex.Message);
                }
            }

            return dataTable;
        }





    }
}
