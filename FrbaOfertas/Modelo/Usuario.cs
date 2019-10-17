using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Usuario
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool habilitado { get; set; }
        public bool bloqueado { get; set; }
        public int cant_logeo_error { get; set; }
        public List<Rol> roles { get; set; }
        
    }
}
