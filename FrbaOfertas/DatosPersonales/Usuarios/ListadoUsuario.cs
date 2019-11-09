using FrbaOfertas.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.DatosPersonales.Usuarios
{
    public partial class ListadoUsuario : Form
    {
        public ListadoUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Seleccionar"].Index && (dataGridView1.Rows.Count > 1) && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                FrbaOfertas.DatosPersonales.Usuarios.ModificarUsuario dialog = new FrbaOfertas.DatosPersonales.Usuarios.ModificarUsuario(dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString());
                dialog.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT DISTINCT usuario_id, usuario_username, usuario_password, usuario_habilitado, usuario_bloqueado " +
                         "FROM HPBC.Usuario  " +
                         "WHERE (usuario_habilitado = 1 OR usuario_habilitado = 0)";
            
            if (textBox1.Text.Trim() != "")
            {
                SQL += " AND UPPER(usuario_username) LIKE '%' + UPPER('" + textBox1.Text.ToString() + "') + '%'";
            }



            SqlCommand command = new SqlCommand(SQL, conn);

            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            int cont = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[cont].Cells[0].Value = reader["usuario_id"].ToString();
                    dataGridView1.Rows[cont].Cells[1].Value = reader["usuario_username"].ToString();
                    dataGridView1.Rows[cont].Cells[2].Value = reader["usuario_bloqueado"].ToString();
                    dataGridView1.Rows[cont].Cells[3].Value = reader["usuario_habilitado"].ToString();
                    cont++;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para estos filtros");
            }

            conn.Close();

        }
    }
}
