using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo.Roles
{
    class Proveedor : Rol
    {
        public int id { get; set; }
        public string RazonSocial { get; set; }
        public string cuit { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public string Ciudad { get; set; }
        public string Calle { get; set; }
        public string codigoPostal { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public string Localidad { get; set; }
        public string rubro { get; set; }
        public string nombreContacto { get; set; }
        public Boolean habilitado { get; set; }
        
        public override string getIdentificadorPrincipal()
        {
            return this.cuit;

        }

        public override string getName()
        {
            return typeof(Proveedor).Name;
        }

        public override void Instertar()
        {
            FrbaOfertas.ConectorDB.FuncionesProveedor.altaProveedor(this);
        }
        public override void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
