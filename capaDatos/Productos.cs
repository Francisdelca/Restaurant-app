using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace capaDatos
{
    public class Productos: Conexion
    {
        public Productos()
        {
            this.setConexion();
        }

        public DataTable listarProductos(int id)
        {
            string sql = "SELECT image,nombre,descripcion,precio FROM Producto WHERE idCategoria = "+id;
            return getEjecutarSQL(sql);
        }
    }
}
