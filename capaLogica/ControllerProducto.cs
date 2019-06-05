using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data;

namespace capaLogica
{
    public class ControllerProducto
    {
        public DataTable listarProductos(int id)
        {
            Productos enlace = new Productos();
            return enlace.listarProductos(id);
        }
    }
}
