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
using FrbaOfertas.Modelo.Roles;

namespace FrbaOfertas.ConectorDB
{
    class FuncionesOferta
    {
        public static void AltaOferta(Oferta OfertaInsertar,Proveedor prov)
        {
           

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Oferta (Ofe_ID_Proveedor, Ofe_Precio, Ofe_Precio_Ficticio, Ofe_Fecha, Ofe_Fecha_Venc, Ofe_Descrip, Ofe_Cant, Ofe_Max_Cant_Por_Usuario, Ofe_Codigo,Ofe_Accesible) " +
                                " VALUES (" + prov.id + 
                                ", " + OfertaInsertar.Ofe_Precio + 
                                ", " + OfertaInsertar.Ofe_Precio_Ficticio + 
                                ", '" + OfertaInsertar.Ofe_Fecha.ToString("yyyy-MM-dd") + 
                                "', '" + OfertaInsertar.Ofe_Fecha_Venc.ToString("yyyy-MM-dd") + 
                                "' ,'" + OfertaInsertar.Ofe_Descrip + 
                                "', " + OfertaInsertar.Ofe_Cant + 
                                ", " + OfertaInsertar.Ofe_Max_Cant_Por_Usuario + 
                                ", (SELECT CONCAT('A', HPBC.fnBase36(" + prov.id + "+" + prov.cuit + "+" + FrbaOfertas.ConectorDB.FuncionesProveedor.ConseguirCantidadDeFacturasTotal(prov.id) + "))), 1 )";

            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        }
    }
}
