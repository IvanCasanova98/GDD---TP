using FrbaOfertas.BaseDeDatos;
using FrbaOfertas.Modelo.Listado;
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

namespace FrbaOfertas.AbmRol
{
    public partial class ListadoRol : Form
    {
        Listado tipoListado;
        public ListadoRol(Listado deco)
        {
            InitializeComponent();
            tipoListado = deco;
            tipoListado.ModificarDataGrid(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox1.Focus();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click_1(object sender, EventArgs e)
        
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT DISTINCT r.Rol_ID, r.Rol_detalle, r.Rol_Habilitado " +
                         "FROM HPBC.Rol r " +
                         "WHERE (r.Rol_Habilitado = 1 OR r.Rol_Habilitado = " + tipoListado.MostrarBajasLogicas()+")" ;

            if (textBox1.Text != "")
            {
                SQL += " AND UPPER(r.Rol_detalle) LIKE '%' + UPPER('" + textBox1.Text.ToString() + "') + '%'";
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
                    dataGridView1.Rows[cont].Cells[0].Value = reader["Rol_ID"].ToString();
                    dataGridView1.Rows[cont].Cells[1].Value = reader["Rol_detalle"].ToString();
                    dataGridView1.Rows[cont].Cells[2].Value = Convert.ToBoolean(reader["Rol_Habilitado"]);
                    cont++;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para estos parametros, modifique alguno e intente nuevamente!");
            }

            conn.Close();

        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
