using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.Listado
{
    class ListadoNormal : Listado
    {
        public override void ModificarDataGrid(DataGridView dgv) { 
  
        }
        public override string MostrarBajasLogicas()
        {
            return "0";
        }


    }
}
