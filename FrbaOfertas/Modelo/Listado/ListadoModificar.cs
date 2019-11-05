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
            dgv.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)sender;
            if (e.ColumnIndex == dataGridView1.Columns["Modificar"].Index && dataGridView1.Rows.Count > 1)
            {
                FrbaOfertas.AbmRol.ModificacionRol dialog = new FrbaOfertas.AbmRol.ModificacionRol();
                dialog.ShowDialog();
                
            }
        }
        public override string MostrarBajasLogicas()
        {
            return "0";
        }

    }
}
