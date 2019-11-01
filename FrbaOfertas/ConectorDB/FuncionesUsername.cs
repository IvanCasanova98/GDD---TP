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


//CONECTOR ENTRE SQL SERVER Y C# PARA TODAS LAS FUNCIONALIDADES RELACIONADAS CON USUARIO USOS PRINCIPALES: LOGIN, REGISTRO Y OTORGAR A UN USUARIO FUNCIONALIDAD

namespace FrbaOfertas.ConectorDB
{
    class FuncionesUsername
    {
        public static int validLogin(string username, string password)
        {
            int RespuestaProtocolo;
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT HPBC.validar_usuario(@usario,@pass)";
                          
            SqlCommand command = new SqlCommand(SQL, conn);
           // command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@usario", username);
            command.Parameters.AddWithValue("@pass", password);  


            RespuestaProtocolo = (int) command.ExecuteScalar();
            conn.Close();
            return RespuestaProtocolo;
            
        }
        public static void resetearCant_login_Fallido(string username)
        {
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "HPBC.pr_resetear_cant_login_fallido";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            conn.Close();
       
        }
        public static void aumentarCant_login_Fallido(string username)
        {
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "HPBC.pr_aumentar_cant_login_fallido";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            conn.Close();
            
        }

        public static void recuperar_usuario_id(string username, string pass)
        {
            
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT usuario_id FROM HPBC.Usuario WHERE usuario_username = '"+username+"' and usuario_password = HASHBYTES('SHA2_256', '"+pass+"')";
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            reader.Read();
            Usuario.id = (int)reader["usuario_id"];
            Usuario.rol = null;
            Usuario.username = username;
            Usuario.password = pass;
            command.Connection.Close();
            conn.Close();
            

        }
        public static List<String> ObtenerFuncionalidadesDeUnUsuario(string username)
        {
            List<String> lista = new List<string>();

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText =
                "SELECT Distinct Func_detalle FROM HPBC.Funcion f join HPBC.Funcion_Por_Rol fr on f.Func_ID = fr.Func_ID join HPBC.Rol r on fr.Rol_ID = r.Rol_ID join HPBC.Rol_Por_Usuario on ID_Rol = r.Rol_ID join HPBC.Usuario on usuario_id = ID_Usuario where usuario_username = '" + username+ "'";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            while (reader.Read())
            {
                lista.Add(reader["Func_detalle"].ToString());
            }
            return lista;

        }
        public static Boolean existeUsername(string username) {
            return FrbaOfertas.ConectorDB.FuncionesGlobales.existeTabla(username, "Usuario");
        }

    }


}
