using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.ConectorDB;
namespace FrbaOfertas.Utils
{
    class ProtocoloSQL
    {


        public static Boolean protocoloLoginSQL(string username,string password)
        {
            int Respuesta = FrbaOfertas.ConectorDB.FuncionesUsername.validLogin(username, password);
            switch (Respuesta)
            {
                case 1:
                    FrbaOfertas.ConectorDB.FuncionesUsername.resetearCant_login_Fallido(username);
                    return true;
                case 2:
                    MessageBox.Show("El usuario se encuentra inhabilitado, comuniquese con un administrativo", "USUARIO INHABILITADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                case 3:
                    MessageBox.Show("El usuario se encuentra bloqueado por superar el numero de logins, comuniquese con un administrativo", "USUARIO BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
                case 4:
                   MessageBox.Show("Password Incorrecta numero de intentos aumentado", "PASSWORD INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   FrbaOfertas.ConectorDB.FuncionesUsername.aumentarCant_login_Fallido(username);
                   return false;
                default:
                   MessageBox.Show("Username no encontrado, registrese o intente nuevamente", "USERNAME NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
                  
            }
        }

    }
}
