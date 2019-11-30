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

namespace FrbaOfertas.ConectorDB
{
    class FuncionesCompra
    {
        public static void AltaCompra(Compra compraNueva)
        {

            int idCliente = FrbaOfertas.ConectorDB.FuncionesCliente.Get_Cliente_id(FrbaOfertas.Modelo.Usuario.id);
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Compra (Compra_ID_Oferta, Compra_ID_Clie_Dest, Compra_Fecha, Compra_Cant, Compra_Facturada) " +
                                " VALUES (" + compraNueva.Compra_ID_Oferta + ", " + idCliente + ", '" + compraNueva.Compra_Fecha + "' , " + compraNueva.Compra_cantidad + ", 0)";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
            FrbaOfertas.ConectorDB.FuncionesCompra.UpdateMonto(idCliente, Int32.Parse(compraNueva.Compra_cantidad) * (int)float.Parse(compraNueva.Compra_Precio));
            FrbaOfertas.ConectorDB.FuncionesCompra.UpdateStock(Int32.Parse(compraNueva.Compra_ID_Oferta), Int32.Parse(compraNueva.Compra_cantidad));
            MessageBox.Show(string.Format("Compra realizada con exito!. Su cupon para retirar su oferta es: {0}, anotelo!!!", FrbaOfertas.ConectorDB.FuncionesCliente.get_cupon_mas_reciente(idCliente)), "Codigo Oferta", MessageBoxButtons.OK);
        }
        public static void AltaCupon(Compra compraNueva)
        {

            int idCliente = FrbaOfertas.ConectorDB.FuncionesCliente.Get_Cliente_id(FrbaOfertas.Modelo.Usuario.id);
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Cupon (Compra_ID_Oferta, Compra_ID_Clie_Dest, Compra_Fecha, Compra_Cantidad, Compra_Facturada) " +
                                "VALUES (" + compraNueva.Compra_ID_Oferta + ", " + idCliente + ", '" + compraNueva.Compra_Fecha + "', " + compraNueva.Compra_cantidad + ", 0)";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }

        public static void UpdateMonto(int idCliente,int monto)
        {

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "UPDATE HPBC.Cliente SET clie_monto= clie_monto -" + monto +
                               " WHERE clie_ID = " + idCliente;
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }
        public static void UpdateStock(int idOferta, int cant)
        {

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "UPDATE HPBC.Oferta SET Ofe_Cant= Ofe_Cant -" + cant +
                               " WHERE Ofe_ID = " + idOferta;
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }



    }
}
