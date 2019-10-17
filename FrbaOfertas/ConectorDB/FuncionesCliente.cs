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

namespace FrbaOfertas.ConectorDB
{
    class FuncionesCliente
    {
        public static Boolean altaCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO dbo.Cliente (Clie_Nom, Clie_Apellido, Clie_DNI, Clie_Calle, Clie_Piso, Clie_Dpto, Clie_Localidad, Clie_Tel, Clie_Mail, Clie_Ciudad, Clie_Fecha_Nac, Clie_Monto, Clie_EstadoBaja) " +
                                "VALUES ('" + cliente.nombre + "', '" + cliente.apellido + "', '" + cliente.documento + "', '"  + cliente.Calle + "'," +
                                " '" + cliente.Piso + "'," + cliente.Dpto + "'," + cliente.Localidad + ",'" + cliente.telefono + "'," + cliente.mail + "'," + cliente.Ciudad + "'," + cliente.fecha_nacimiento.ToString("yyyy-MM-dd HH:mm:ss") +
                                "'," + cliente.monto + "'," + cliente.habilitado + ")";
            comm.Connection = connection;
            comm.Connection.Open();
            int rows = comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
            return rows > 0;
        }

    }
}
