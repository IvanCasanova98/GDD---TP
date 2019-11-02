using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FrbaOfertas.Modelo.Roles;
using System.Globalization;
using FrbaOfertas.BaseDeDatos;

namespace FrbaOfertas.ConectorDB
{
    class FuncionesProveedor
    {
        public static void altaProveedor(Proveedor proveedor)
        {
            if (!FrbaOfertas.ConectorDB.FuncionesProveedor.existeRubro(proveedor.rubro)) FrbaOfertas.ConectorDB.FuncionesProveedor.crearRubro(proveedor.rubro);
            

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Proveedor (Provee_Rs, Provee_Calle, Provee_Piso, Provee_Dpto, Provee_Localidad, Provee_Ciudad, Provee_CodPostal, Provee_Mail, Provee_CUIT, Provee_Tel, Provee_NombreContacto, Provee_Habilitado, Provee_Rubro, Provee_usuario_id) " +
                                "VALUES ('" + proveedor.RazonSocial + "', '" + proveedor.Calle + "', " + proveedor.Piso + ", '" + proveedor.Dpto + "'," +
                                " '" + proveedor.Localidad + "','" + proveedor.Ciudad + "' , " + proveedor.codigoPostal + " ,'" + proveedor.mail + "', '" + proveedor.cuit + "', " + proveedor.telefono + ", '" + proveedor.nombreContacto +
                                "', " + proveedor.habilitado + ", (SELECT Rubro_ID from HPBC.Rubro WHERE Rubro_detalle = '"+proveedor.rubro+"')  ,(SELECT usuario_id from HPBC.Usuario where usuario_id not in (SELECT ID_Usuario from HPBC.Rol_Por_Usuario)))";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }

        public static void crearRubro(string Rubro)
        {
           


            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Rubro (Rubro_detalle) " +
                                "VALUES ('" + Rubro + "')";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }

        public static Boolean existeRubro(string rubro)
        {
            return FrbaOfertas.ConectorDB.FuncionesGlobales.existeTabla(rubro, "Rubro");

        }


    }
}
