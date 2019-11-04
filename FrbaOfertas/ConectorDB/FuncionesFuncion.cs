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


//CONECTOR ENTRE SQL SERVER Y C# PARA TODAS LAS FUNCIONALIDADES RELACIONADAS CON FUNCIONES USOS PRINCIPALES: OTORGAR A UN USUARIO FUNCIONALIDAD

namespace FrbaOfertas.ConectorDB
{
    class FuncionesFuncion
    {
         public static List<String> ObtenerFuncionalidades()
        {
            List<String> lista= new List <string>();
            
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT Func_detalle FROM HPBC.Funcion";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            while (reader.Read())
            {
                lista.Add(reader["Func_detalle"].ToString());
            }
            return lista;

        }
         public static void GuardarRolXFuncion(String Rol, String Funcion)
         {
             SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
             SqlCommand comm = connection.CreateCommand();

             comm.CommandText = "INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID, Func_ID) " +
                                 "VALUES ((SELECT Rol_ID FROM HPBC.Rol where Rol_detalle = '" + Rol + "'),(SELECT Func_ID FROM HPBC.Funcion where Func_detalle = '" + Funcion + "'))";
             comm.Connection = connection;
             comm.Connection.Open();
             comm.ExecuteNonQuery();
             comm.Connection.Close();
             connection.Close();


         }
         public static void BorrarRolXFuncion(String Rol)
         {
             SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
             SqlCommand command = conn.CreateCommand();
             command.CommandText = "HPBC.pr_borrar_relaciones_de_un_rol_x_funcion";
             command.CommandType = CommandType.StoredProcedure;
             command.Parameters.AddWithValue("@rol", SqlDbType.VarChar).Value = Rol;
             command.Connection = conn;
             command.Connection.Open();
             command.ExecuteNonQuery();
             command.Connection.Close();
             conn.Close();


         }


    }
}
