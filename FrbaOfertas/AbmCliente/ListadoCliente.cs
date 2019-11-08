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

namespace FrbaOfertas.AbmCliente
{
    public partial class ListadoCliente : Form
    {
        Listado tipoListado;
        public ListadoCliente(Listado deco)
        {
            tipoListado = deco;
            tipoListado.ModificarDataGrid(dataGridView1);
            InitializeComponent();
            txt_nombre.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_apellido.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_dni.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_mail.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);

        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_mail.Text = "";
            txt_nombre.Select();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
        }


        

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT DISTINCT c.clie_ID, c.clie_nombre, c.clie_apellido, c.clie_dni, c.clie_mail, c.clie_tel, c.clie_fecha_nac, c.clie_calle, c.clie_piso, c.clie_dpto, c.clie_localidad, c.clie_monto, c.clie_habilitado " +
                         "FROM HPBC.Cliente c " +
                         "WHERE (c.clie_habilitado = 1 OR c.clie_habilitado = " + tipoListado.MostrarBajasLogicas() + ")";

            if (txt_nombre.Text != "")
            {
                SQL += " AND UPPER(c.clie_nombre) LIKE '%' + UPPER('" + txt_nombre.Text.ToString() + "') + '%'";
            }
            if (txt_apellido.Text != "")
            {
                SQL += " AND UPPER(c.clie_apellido) LIKE '%' + UPPER('" + txt_apellido.Text.ToString() + "') + '%'";
            }
            if (txt_dni.Text != "")
            {
                SQL += " AND c.clie_dni = " + txt_dni.Text.ToString()  ;
            }
            if (txt_mail.Text != "")
            {
                SQL += " AND UPPER(c.clie_mail) LIKE '%' + UPPER('" + txt_mail.Text.ToString() + "') + '%'";
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
                    dataGridView1.Rows[cont].Cells[0].Value = reader["clie_ID"].ToString();
                    dataGridView1.Rows[cont].Cells[1].Value = reader["clie_nombre"].ToString();
                    dataGridView1.Rows[cont].Cells[2].Value = reader["clie_apellido"].ToString();
                    dataGridView1.Rows[cont].Cells[3].Value = reader["clie_dni"].ToString();
                    dataGridView1.Rows[cont].Cells[4].Value = reader["clie_mail"].ToString();
                    dataGridView1.Rows[cont].Cells[5].Value = reader["clie_tel"].ToString();
                    dataGridView1.Rows[cont].Cells[6].Value = Convert.ToDateTime(reader["clie_fecha_nac"]);
                    dataGridView1.Rows[cont].Cells[7].Value = reader["clie_calle"].ToString();
                    dataGridView1.Rows[cont].Cells[8].Value = reader["clie_piso"].ToString();
                    dataGridView1.Rows[cont].Cells[9].Value = reader["clie_dpto"].ToString();
                    dataGridView1.Rows[cont].Cells[10].Value = reader["clie_localidad"].ToString();
                    dataGridView1.Rows[cont].Cells[11].Value = reader["clie_monto"].ToString();
                    dataGridView1.Rows[cont].Cells[12].Value = Convert.ToBoolean(reader["clie_habilitado"]);
                    cont++;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para estos filtros");
            }

            conn.Close();

        }

        private void ListadoCliente_Load(object sender, EventArgs e)
        {

        }

       
    


      
    }
}
