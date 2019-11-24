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
    class ObtenerRangoAñosFacturas
    {
        public static int obtenerMaximoAño()
        {
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT YEAR(MAX(Fact_Fecha)) AS 'MAXIMO AÑO' FROM HPBC.Factura";

            SqlCommand command = new SqlCommand(SQL, conn);

            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            reader.Read();

            return Convert.ToInt32(reader["MAXIMO AÑO"]);

        }

        public static int obtenerMinimoAño()
        {
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT YEAR(MIN(Fact_Fecha)) AS 'MINIMO AÑO' FROM HPBC.Factura";

            SqlCommand command = new SqlCommand(SQL, conn);

            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            reader.Read();

            return Convert.ToInt32(reader["MINIMO AÑO"]);

        }
    }
}
