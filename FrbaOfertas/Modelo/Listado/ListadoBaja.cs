using FrbaOfertas.Modelo.AbmHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.Listado
{
    class ListadoBaja : Listado
    {
        Handler tipoAbm;
        public ListadoBaja(Handler tipo) {
            tipoAbm = tipo;
        }
        public override void ModificarDataGrid(DataGridView dgv)
        {
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Eliminar";
            uninstallButtonColumn.Text = "Eliminar";
            int columnIndex = dgv.Columns.Count;
            if (dgv.Columns["Eliminar"] == null)
            {
                dgv.Columns.Insert(columnIndex, uninstallButtonColumn);
                
            }


            dgv.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)sender;
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && (dataGridView1.Rows.Count > 1) && e.RowIndex != dataGridView1.Rows.Count-1)
            {
                tipoAbm.darDeBaja(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                dataGridView1.Refresh();
      {
               
      }
            

            }
        }
        public override string MostrarBajasLogicas()
        {
            return "1";
        }
    }
}
