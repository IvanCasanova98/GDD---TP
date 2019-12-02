using FrbaOfertas.BaseDeDatos;
using FrbaOfertas.PropiedadesConfig;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FUNCIONES UTILIZADAS PARA LOS CUPONES DE APLICACION-SQLSERVER

namespace FrbaOfertas.ConectorDB
{
    class FuncionesCupon
    {

        public static void updateCuponEntregado(int id_cupon)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();

            comm.CommandText = "UPDATE HPBC.Cupon" +
                               " SET Cup_Fecha_Consumo = '" + Config.Default.fechaSistema + "'" +
                               " WHERE Cupon_ID = "+ id_cupon;
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();

        }


    }
}
