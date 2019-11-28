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
        public static void BajaLogicaCliente(int id)
        {

            FrbaOfertas.ConectorDB.FuncionesGlobales.BajaLogica(id, "Proveedor");
        }

        public static Proveedor traerProveedor(int id) { 

            Proveedor proveedorBuscado = new Proveedor();
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT DISTINCT Provee_ID, Provee_Rs, Provee_Calle, Provee_Piso, Provee_Dpto, Provee_Localidad, Provee_Ciudad, Provee_CodPostal, Provee_Mail, Provee_CUIT, Provee_Tel, Provee_NombreContacto, Provee_Habilitado, Rubro_detalle  " +
                                "FROM HPBC.Proveedor join HPBC.Rubro on Provee_Rubro = Rubro_ID  WHERE Provee_ID = "+ id ;
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            while (reader.Read())
            {
                proveedorBuscado.RazonSocial = reader["Provee_Rs"].ToString();
                proveedorBuscado.Calle = reader["Provee_Calle"].ToString();
                proveedorBuscado.Piso = reader["Provee_Piso"].ToString();
                proveedorBuscado.Dpto = reader["Provee_Dpto"].ToString();
                proveedorBuscado.Localidad = reader["Provee_Localidad"].ToString();
                proveedorBuscado.Ciudad = reader["Provee_Ciudad"].ToString();
                proveedorBuscado.codigoPostal = reader["Provee_CodPostal"].ToString();
                proveedorBuscado.mail = reader["Provee_Mail"].ToString();
                proveedorBuscado.cuit = reader["Provee_CUIT"].ToString();
                proveedorBuscado.telefono = reader["Provee_Tel"].ToString();
                proveedorBuscado.nombreContacto = reader["Provee_NombreContacto"].ToString();
                proveedorBuscado.rubro = reader["Rubro_detalle"].ToString();
                proveedorBuscado.habilitado = Convert.ToBoolean(reader["Provee_Habilitado"].ToString());
            }

            proveedorBuscado.id = id;
            connection.Close();
            return proveedorBuscado;
        }
        public static void UpdateProveedor(Proveedor proveedor)
        {
            if (!FuncionesProveedor.existeRubro(proveedor.rubro))
                FuncionesProveedor.crearRubro(proveedor.rubro);
            
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "UPDATE HPBC.Proveedor SET Provee_Rs = '" + proveedor.RazonSocial + "', Provee_Calle= '" + proveedor.Calle + "', Provee_Piso= " + proveedor.Piso + ", Provee_Localidad= '" + proveedor.Localidad + "' , Provee_Ciudad= '" + proveedor.Ciudad + "', Provee_CodPostal= " + proveedor.codigoPostal + ", Provee_Mail= '" + proveedor.mail + "', Provee_CUIT = '" + proveedor.cuit + "' , Provee_NombreContacto = '" + proveedor.nombreContacto+ "' , Provee_Habilitado = " + Convert.ToInt32(proveedor.habilitado) + ", Provee_Rubro= (SELECT Rubro_ID from HPBC.Rubro where UPPER('"+proveedor.rubro+"') = UPPER(Rubro_detalle))" +
                               " WHERE Provee_ID = " + proveedor.id;
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }

        public static int Get_Proveedor_id(int usuarioID)
        {

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT DISTINCT Provee_ID " +
                                "FROM HPBC.Proveedor WHERE clie_usuario_ID = " + usuarioID;
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            reader.Read();
            int id = Int32.Parse(reader["Provee_ID"].ToString());
            comm.Connection.Close();
            connection.Close();
            return id;
        }
        public static int Get_Proveedor_id_con_razon_social(string RS)
        {

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT DISTINCT Provee_ID " +
                                "FROM HPBC.Proveedor WHERE Provee_Rs = '" + RS+"'";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            reader.Read();
            int id = Int32.Parse(reader["Provee_ID"].ToString());
            comm.Connection.Close();
            connection.Close();
            return id;
        }
        public static int ConseguirCantidadDeFacturasTotal(int idProv)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT Count(*) from HPBC.Oferta where Ofe_ID_Proveedor = " + idProv;
            comm.Connection = connection;
            comm.Connection.Open();
            int count = (Int32)comm.ExecuteScalar();

            return count;
        }



        
        }
    }

