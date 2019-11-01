using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    public class Cliente :  Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_nacimiento { get; set; } 
        public string Ciudad { get; set; }
        public string Calle { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public string Localidad { get; set; }
        public string monto { get; set; }
        public int habilitado { get; set; }


        public override string getIdentificadorPrincipal()
        {
            return this.documento;

    }
        public override string getName()
        {
            return typeof(Cliente).Name;
        }
        public override void Instertar()
        {
            FrbaOfertas.ConectorDB.FuncionesCliente.altaCliente(this);
        }

        public override void Modificar()
        {
            throw new NotImplementedException();
        }

}
}
