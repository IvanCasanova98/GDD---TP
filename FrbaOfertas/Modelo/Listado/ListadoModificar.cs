using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.Listado
{
    class ListadoModificar :Listado
    {
        public override void ModificarDataGrid(DataGridView dgv)
        {
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Modificar";
            uninstallButtonColumn.Text = "Modificar";
            int columnIndex = dgv.Columns.Count;
            if (dgv.Columns["Modificar"] == null)
            {
                dgv.Columns.Insert(columnIndex, uninstallButtonColumn);
            }

           
        }




    }
}
