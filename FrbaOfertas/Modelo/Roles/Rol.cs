using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo
{
    public abstract class Rol
    {

        public abstract string getIdentificadorPrincipal();
        public abstract string getName();
        public abstract void Instertar();
        public abstract void Modificar();
    }

}
