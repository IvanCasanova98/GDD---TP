using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo.AbmHandler
{
    //el proposito de esta clase es evitar repeticion de codigo creando 
    public abstract class Handler
    {
        public abstract void darDeBaja(int id);

    }
}
