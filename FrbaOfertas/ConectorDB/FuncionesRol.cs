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


//CONECTOR ENTRE SQL SERVER Y C# PARA TODAS LAS FUNCIONALIDADES RELACIONADAS CON ROL USOS PRINCIPALES: OTORGAR A UN USUARIO FUNCIONALIDAD

namespace FrbaOfertas.ConectorDB
{
    class FuncionesRol
    {
        public static List<String> ObtenerFuncionalidadesDeUnRol(string nombreRol)
        {
            List<String> lista = new List<string>();

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT Func_detalle FROM HPBC.Funcion f join HPBC.Funcion_Por_Rol fr on f.Func_ID = fr.Func_ID join HPBC.Rol r on fr.Rol_ID = r.Rol_ID where r.Rol_detalle =" + nombreRol;
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            while (reader.Read())
            {
                lista.Add(reader["Func_detalle"].ToString());
            }
            return lista;

        }

        public static List<String> ObtenerRolesDeUnUsuario(int id_usuario)
        {
            List<String> lista = new List<string>();
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT Rol_detalle from HPBC.Rol r join HPBC.Rol_Por_Usuario on ID_Rol = r.Rol_ID join HPBC.Usuario on ID_Usuario = usuario_id where usuario_id =" + id_usuario;
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            while (reader.Read())
            {
                lista.Add(reader["Rol_detalle"].ToString());
            }
            return lista;



        }
        public static List<String> ObtenerRolesRegistrables() {
            List<String> lista = new List<string>();
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT DISTINCT Rol_detalle from HPBC.Rol f join HPBC.Funcion_Por_Rol fr on f.Rol_ID = fr.Rol_ID join HPBC.Funcion r on fr.Func_ID= r.Func_ID where r.Func_detalle = 'REGISTRO' and f.Rol_Habilitado = 1";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            while (reader.Read())
            {
                lista.Add(reader["Rol_detalle"].ToString());
            }
            return lista;
        
        }

    }
}