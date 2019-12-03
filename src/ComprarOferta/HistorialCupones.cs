using FrbaOfertas.BaseDeDatos;
using FrbaOfertas.Modelo;
using FrbaOfertas.PropiedadesConfig;
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

namespace FrbaOfertas.ComprarOferta
{
    public partial class HistorialCupones : Form
    {
        public HistorialCupones()
        {
            InitializeComponent();
        }

        private void HistorialCupones_Load(object sender, EventArgs e)
        {
            string fechaCarga = Config.Default.fechaSistema;
            this.dataGridHistorial.DataSource = null;
            this.dataGridHistorial.Rows.Clear();
            dataGridHistorial.Refresh();
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            Cliente clienteactual = FrbaOfertas.ConectorDB.FuncionesCliente.traerCliente(FrbaOfertas.ConectorDB.FuncionesCliente.Get_Cliente_id(FrbaOfertas.Modelo.Usuario.id));

            string SQL = "SELECT Cup_Codigo, Ofe_Descrip, Compra_Cant , Cup_Fecha_Venc, (case when Cup_Fecha_Consumo is null then 'No' else 'Si' end) as 'consumido' " +
                         "FROM HPBC.Compra join HPBC.Cupon  on Cupon_ID_Compra = Compra_ID JOIN HPBC.Oferta on Compra_ID_Oferta = Ofe_ID " +
                         "WHERE Compra_ID_Clie_Dest = "+ clienteactual.id;

            SqlCommand command = new SqlCommand(SQL, conn);
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            int cont = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridHistorial.Rows.Add();
                    dataGridHistorial.Rows[cont].Cells[0].Value = reader["Cup_Codigo"].ToString();
                    dataGridHistorial.Rows[cont].Cells[1].Value = reader["Ofe_Descrip"].ToString();
                    dataGridHistorial.Rows[cont].Cells[2].Value = reader["Compra_Cant"].ToString();
                    dataGridHistorial.Rows[cont].Cells[3].Value = Convert.ToDateTime(reader["Cup_Fecha_Venc"]).ToShortDateString();
                    dataGridHistorial.Rows[cont].Cells[4].Value = reader["consumido"].ToString();
                    cont++;
                } 
            }
            else
            {
                MessageBox.Show("No se encontraron resultados");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
