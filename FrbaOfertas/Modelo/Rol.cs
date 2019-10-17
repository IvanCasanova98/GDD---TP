using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool habilitado { get; set; }
        public List<Funcionalidad> funcionalidades { get; set; }
    }
}
