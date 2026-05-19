using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaNegocio
{
    public class Negocio_Productos
    {
        public DataTable ListarProductos()
        {
            Datos_Productos datosProductos = new Datos_Productos();
            return datosProductos.ListarProductos();
        }

        public void InsertarProducto(string descripcion, decimal precio, DateTime fechaVencimiento, string proveedor, string estado)
        {
            Datos_Productos datosProductos = new Datos_Productos();
            datosProductos.InsertarProducto(descripcion, precio, fechaVencimiento, proveedor, estado);
        }

        public void EliminarProducto(int productoID)
        {
            Datos_Productos datosProductos = new Datos_Productos();
            datosProductos.EliminarProducto(productoID);
        }
        public void ActualizarProducto(int productoID, string descripcion, decimal precio, DateTime fechaVencimiento, string proveedor, string estado)
        {
            Datos_Productos datosProductos = new Datos_Productos();
            datosProductos.ActualizarProducto(productoID, descripcion, precio, fechaVencimiento, proveedor, estado);
        }
        public DataTable BuscarProductoPorDescripcion(string descripcion)
        {
            Datos_Productos datosProductos = new Datos_Productos();
            return datosProductos.BuscarProductoPorDescripcion(descripcion);
        }
    }
}
