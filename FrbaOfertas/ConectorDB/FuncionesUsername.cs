﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FrbaOfertas.Modelo;
using System.Globalization;
using FrbaOfertas.BaseDeDatos;

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
    }


}
