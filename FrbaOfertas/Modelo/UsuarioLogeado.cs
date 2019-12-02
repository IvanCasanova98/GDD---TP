using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class UsuarioLogeado
    {
        public static int id { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static Rol rol { get; set; }

        public static void IngresoUsuario(string username, string pass)
        {
            FrbaOfertas.ConectorDB.FuncionesUsername.recuperar_usuario_id(username, pass);
        }


    }
}
