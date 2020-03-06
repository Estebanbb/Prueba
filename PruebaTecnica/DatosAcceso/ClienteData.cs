using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAcceso
{
    public class ClienteData
    {

        private SqlConnection con = new Conexion().Conexion1();
        

        public DataTable GetCliente(Cliente Cliente)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("InsertCliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ClnNombre", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnApellido", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnIdentificacion", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnEmail", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnCiudad", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnPais", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnNumeroCompras", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnPais", Cliente.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ClnPais", Cliente.Nombre));
            }

            return dt;

        } 

    }
}
