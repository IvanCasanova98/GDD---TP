using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Cuenta
    {
        public int id { get; set; }
        public string TARJ_NRO { get; set; }
        public string TARJ_COD_SEG { get; set; }
        public string TARJ_TIPO { get; set; }
        public DateTime CARGA_FECHA { get; set; }
        public string CARGA_CREDITO { get; set; }
    }
}
