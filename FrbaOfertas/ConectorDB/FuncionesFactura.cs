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
using FrbaOfertas.Modelo.Roles;
using System.Windows.Forms;
using FrbaOfertas.PropiedadesConfig;

namespace FrbaOfertas.ConectorDB
{
    class FuncionesFactura
    {
        public static void CompraXFactura(int idCompra, int idFactura)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();

            comm.CommandText = "INSERT INTO HPBC.Detalle_Fact(Detalle_ID_Fact, Detalle_ID_Compra) " +
                                "VALUES (" + idFactura + ", " + idCompra + " )";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();


        }

        public static void AltaFactura(int idProveedor, int monto) {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            string fechaCarga = Config.Default.fechaSistema;
            comm.CommandText = "INSERT INTO HPBC.Factura(Fact_ID_Proveedor, Fact_Fecha,Fact_Nro,Fact_Monto) " +
                                "VALUES (" + idProveedor + ", '" + fechaCarga + "',(select max(Fact_Nro) from HPBC.Factura)+1, "+monto+" )";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
                
        }
        public static int CalcularMonto(int idProveedor, DateTime fecha_desde, DateTime fecha_hasta) {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT SUM(Ofe_Precio_Ficticio*Compra_Cant) as 'Monto' FROM HPBC.Oferta JOIN HPBC.Compra on Compra_ID_Oferta = Ofe_ID "
                                + " WHERE Ofe_ID_Proveedor = " + idProveedor + " AND (Compra_Fecha BETWEEN '" + fecha_desde.ToString("yyyy-MM-dd") + "' AND '" + fecha_hasta.ToString("yyyy-MM-dd") + "')" + " AND Compra_facturada = 0";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            reader.Read();
            if (!reader.IsDBNull(0))
            {
                    int monto = Int32.Parse(reader["Monto"].ToString());
                    comm.Connection.Close();
                    connection.Close();
                    return monto;
                
            }
            comm.Connection.Close();
            connection.Close();
            return -1;



        }
        public static int get_ultima_factura() {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT max(Fact_Nro) as 'max' FROM HPBC.Factura";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            reader.Read();
            int max = Int32.Parse(reader["max"].ToString());
            comm.Connection.Close();
            connection.Close();
            return max;

        
        }

        public static int get_ultima_id_Factura()
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT Fact_ID as 'max' FROM HPBC.Factura where Fact_Nro = (SELECT max(Fact_Nro) as 'max' FROM HPBC.Factura) ";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            reader.Read();
            int max = Int32.Parse(reader["max"].ToString());
            comm.Connection.Close();
            connection.Close();
            return max;
        }

    }
}
