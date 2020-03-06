using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAcceso
{
    public class Conexion
    {
        public SqlConnection Conexion1()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Conn1"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            
            return con;
        }

        public string Conexion2()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Conn2"].ConnectionString;
            return connStr;
        }
    }
}
