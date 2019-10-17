using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipo_documento { get; set; }
        public string documento { get; set; }
        public string cuil { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_creacion { get; set; }
        public bool habilitado { get; set; }
        public Tarjeta tarjeta { get; set; }
        public Usuario usuario { get; set; }
        public string dire { get; set; }
    }
}
