using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Modelo.AbmHandler
{
    //el proposito de esta clase es evitar repeticion de codigo creando varios listados para lo mismo.
    public abstract class Handler
    {
        public abstract Boolean darDeBaja(int id);
        public abstract void Modificar(int id);

    }
}
