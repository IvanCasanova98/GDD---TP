using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo.Roles
{
    public class Compra
    {
        public string Compra_ID { get; set; }
        public string Compra_ID_Oferta { get; set; }
        public string Compra_Fecha { get; set; }
        public string Compra_cantidad { get; set; }
        public string Compra_Precio { get; set; }
        public string Compra_Cantidad_Max_X_Usuario { get; set; }
        public string Compra_Monto_Disponible { get; set; }

    }
}
