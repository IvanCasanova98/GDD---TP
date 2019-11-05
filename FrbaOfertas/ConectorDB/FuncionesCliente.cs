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
        public static void altaCliente(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.monto)) cliente.monto = "200";
            
            
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Cliente (clie_nombre, clie_apellido, clie_dni, clie_mail, clie_tel, clie_calle, clie_piso, clie_dpto , clie_fecha_nac,  clie_localidad, clie_habilitado, clie_monto, clie_usuario_ID) " +
                                "VALUES ('" + cliente.nombre + "', '" + cliente.apellido + "', " + cliente.documento + ", '" + cliente.mail + "'," +
                                " " + cliente.telefono + ",'" +cliente.Calle + "', " + cliente.Piso + ",'" + cliente.Dpto +"', '" + cliente.fecha_nacimiento.ToString("yyyy-MM-dd") + "' , '" + cliente.Localidad + "', "+ cliente.habilitado +", " + cliente.monto + ",  (SELECT usuario_id from HPBC.Usuario where usuario_id not in (SELECT ID_Usuario from HPBC.Rol_Por_Usuario)))";               
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }

        public static Boolean existeDNI(string dni)
        {
           return FrbaOfertas.ConectorDB.FuncionesGlobales.existeTabla(dni, "DNI");

        }

        public static Boolean existeMail(string mail)
        {
            return FrbaOfertas.ConectorDB.FuncionesGlobales.existeTabla(mail, "Email");

        }

    }
}
