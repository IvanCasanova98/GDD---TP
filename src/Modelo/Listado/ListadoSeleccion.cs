using FrbaOfertas.Modelo.AbmHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FrbaOfertas.Modelo.Listado
{

        class ListadoSeleccion : Listado
        {
            
            Handler tipoAbm;
            Form FormActual;
            public ListadoSeleccion(Handler tipo, Form form)
            {
                tipoAbm = tipo;
                FormActual = form;
            }

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
                    tipoAbm.SetearUsuario(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                    FormActual.ShowDialog();
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    
                }
            }
            public override string MostrarBajasLogicas()
            {
                return "1";
            }

        }

    }

