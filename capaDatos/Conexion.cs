using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class Conexion
    {
        //atributos
        public string Server { get; set; }
        public string BaseDatos { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }

        private string CadenaConexion;
        private SqlConnection cx;
        private SqlCommand cmd;

        //metodos
        public void setConexion()
        {
            Server = "LAB02-PC07\\DESARROLLO";
            BaseDatos = "RestoApp";
            User = "";
            Clave = "";
            CadenaConexion = "Server=" + Server + ";Initial Catalog=" + BaseDatos + ";Integrated Security=True;";
        }
        public Boolean conectarBD()
        {
            try
            {
                cx = new SqlConnection(CadenaConexion);
                if (cx.State == ConnectionState.Closed)
                {
                    cx.Open();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean ejecutarSQL(string sql)//metodos insert, update,  delete
        {
            if (conectarBD())
            {
                cmd = new SqlCommand(sql, cx);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                cx.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getEjecutarSQL(string sql)// metodo select, consultas con retorno de registros
        {
            if (conectarBD())
            {
                try
                {
                    SqlDataAdapter obj = new SqlDataAdapter(sql, cx);
                    DataTable tablaDatos = new DataTable();
                    obj.Fill(tablaDatos);
                    return tablaDatos;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error al consultar -->>" + ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        ////////////////////////////////////////////////////////////////////////////
        public int ejecutarProcedimiento(string nameSP)
        {
            int cantidad = 0;

            if (conectarBD())
            {
                try
                {
                    cmd = new SqlCommand(nameSP, cx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Connection.Close();
                    cx.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error SP:" + ex.Message);
                    return 0;
                }
            }

            return cantidad;
        }
    }
}
