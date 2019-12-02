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
using FrbaOfertas.PropiedadesConfig;

//FUNCIONES UTILIZADAS PARA LAS CARGAS DE CREDITO DE APLICACION-SQLSERVER

namespace FrbaOfertas.ConectorDB
{
    class FuncionesCarga
    {
        public static Tarjeta ExisteTarjeta(string numero, string cod)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT Tarj_Detalle, Tarj_Nro, Tarj_Cod_Seg from HPBC.Tipo_Pago where Tarj_Nro = " +numero +" and Tarj_Cod_Seg = " + cod;
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            reader.Read();
            if (reader.HasRows)
            {
                Tarjeta tarjetaNueva = new Tarjeta();
                tarjetaNueva.TARJ_NRO = reader["Tarj_Nro"].ToString();
                tarjetaNueva.TARJ_COD_SEG = reader["Tarj_Cod_Seg"].ToString();
                tarjetaNueva.TARJ_TIPO = reader["Tarj_Detalle"].ToString();
                comm.Connection.Close();
                connection.Close();
                return tarjetaNueva;
            }
            comm.Connection.Close();
            connection.Close();
            Tarjeta tarjeta = new Tarjeta();
            tarjeta.TARJ_TIPO = "False";
            return tarjeta;
            }

        public static void AltaTarjeta(Tarjeta tarjetaInsertar)
        {


            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Tipo_Pago (Tarj_Detalle, Tarj_Nro, Tarj_Cod_Seg) " +
                                "VALUES ('" + tarjetaInsertar.TARJ_TIPO + "', " + tarjetaInsertar.TARJ_NRO + ", " + tarjetaInsertar.TARJ_COD_SEG +")";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }
        public static void AltaCarga(Tarjeta tarjetaInsertar, string monto) {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            string clienteDNI = FrbaOfertas.ConectorDB.FuncionesCliente.traerCliente(FrbaOfertas.ConectorDB.FuncionesCliente.Get_Cliente_id(FrbaOfertas.Modelo.Usuario.id)).documento;
            string fechaCarga =  Config.Default.fechaSistema;

            comm.CommandText = "INSERT INTO HPBC.Credito (Credito_ID_Clie, Carga_Fecha, Carga_Monto, Credito_ID_Tarjeta) " +
                                "VALUES ((SELECT clie_ID FROM HPBC.Cliente where clie_dni = " + clienteDNI + "),'" + fechaCarga + "', " + monto + ",(SELECT Tipo_Pago_ID from HPBC.Tipo_Pago where Tarj_Detalle = '" + tarjetaInsertar.TARJ_TIPO + "' and Tarj_Nro=" + tarjetaInsertar.TARJ_NRO + " and Tarj_Cod_Seg=" + tarjetaInsertar.TARJ_COD_SEG + "))";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        
        }

    }
}
