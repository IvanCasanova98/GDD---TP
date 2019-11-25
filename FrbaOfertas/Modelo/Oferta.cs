using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    class Oferta
    {
        public int Ofe_ID { get; set; }
        public int Ofe_ID_Proveedor { get; set; }
        public double Ofe_Precio { get; set; }
        public double Ofe_Precio_Ficticio { get; set; }
        public DateTime Ofe_Fecha { get; set; }
        public DateTime Ofe_Fecha_Venc { get; set; }
        public string Ofe_Descrip { get; set; }
        public int Ofe_Cant { get; set; }
        public int Ofe_Max_Cant_Por_Usuario { get; set; }
        public string Ofe_Codigo { get; set; }
        public int Ofe_Accesible { get; set; }

    }
}
