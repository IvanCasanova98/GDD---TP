using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Modelo.AbmHandler;
namespace FrbaOfertas.Modelo.Listado
{
    //El proposito de esta clase es la de agregar funciones en tiempo de ejecucion al listado, tanto dar de Baja como Modificar
   public abstract class Listado
    {
       Handler TipoDeAbm;
       public abstract void ModificarDataGrid(DataGridView dgv);
       public abstract string MostrarBajasLogicas();

    }
}
