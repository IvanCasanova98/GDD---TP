using FrbaOfertas.Modelo.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.Listado
{

    

    class ListadoSeleccionFacturar : Listado
    {
        FechasFacturas fechas;
        int ID_PROVEEDOR;

        public override void ModificarDataGrid(DataGridView dgv)
        {
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Seleccionar";
            uninstallButtonColumn.Text = "Seleccionar";
            int columnIndex = dgv.Columns.Count;
            if (dgv.Columns["Seleccionar"] == null)
            {
                dgv.Columns.Insert(columnIndex, uninstallButtonColumn);
            }
            dgv.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)sender;
            if (e.ColumnIndex == dataGridView1.Columns["Seleccionar"].Index && (dataGridView1.Rows.Count > 1) && e.RowIndex != dataGridView1.Rows.Count - 1)
            {

                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Proveedor provee = FrbaOfertas.ConectorDB.FuncionesProveedor.traerProveedor(id);

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                
                FrbaOfertas.Facturar.OfertasAdquiridasFacturaDeProveedor ofertasAdquiridas = new FrbaOfertas.Facturar.OfertasAdquiridasFacturaDeProveedor(fechas,ID_PROVEEDOR);
                //ofertasAdquiridas.ShowDialog(this);
                
            }
        }

        public void setParametros(FechasFacturas fechas, int ID_PROVEEDOR)
        {
            this.fechas = fechas;
            this.ID_PROVEEDOR = ID_PROVEEDOR;
        }

        public override string MostrarBajasLogicas()
        {
            return "0";
        }
    }
}
