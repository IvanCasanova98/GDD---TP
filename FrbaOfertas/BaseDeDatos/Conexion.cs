using FrbaOfertas.PropiedadesConfig;
using System.Data.SqlClient;
using System;

//Clase globlal para generar las conexiones con la base de datos SQL Server

namespace FrbaOfertas.BaseDeDatos
{
    class Conexion
    {
        public static string getStringConnection()
        {
            return Config.Default.connectionString;
        }

        private static SqlConnection create()
        {
            return new SqlConnection(getStringConnection());
        }

        private static SqlConnection open(SqlConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return conn;
        }

        public static void close(SqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static SqlConnection getConnection()
        {
            return open(create());
        }
    }
}
