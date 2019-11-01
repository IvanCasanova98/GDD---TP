using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FrbaOfertas.Modelo;
using System.Globalization;
using FrbaOfertas.BaseDeDatos;
//Aca van las funciones que las demas clases comparten ej: tanto proveedor, cliente como usuario deben validar que no existan campos duplicados
namespace FrbaOfertas.ConectorDB
{
    class FuncionesGlobales
    {
        public static Boolean existeTabla(string buscado ,string columna)
        {
            Boolean existeUnico;
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT HPBC.existe" + columna + "(@buscado)";
            SqlCommand command = new SqlCommand(SQL, conn);
            command.Parameters.AddWithValue("@buscado", buscado);
            existeUnico = (Boolean)command.ExecuteScalar();
            conn.Close();
            return existeUnico;

        }


    }
}
