using FrbaOfertas.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.ConectorDB
{
    class ObtenerTodosLosProveedores
    {

        public static List<string> getListaProveedores()
        {
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT DISTINCT [Provee_Rs] FROM [GD2C2019].[HPBC].[Proveedor]";

            SqlCommand command = new SqlCommand(SQL, conn);

            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            reader.Read();

            List<string> listaProveedores = new List<string>();
            while (reader.Read())
            {
                listaProveedores.Add(reader["Provee_Rs"].ToString());
            }
            return listaProveedores;
        }

    }
}
