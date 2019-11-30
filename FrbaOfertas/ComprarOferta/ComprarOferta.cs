using FrbaOfertas.BaseDeDatos;
using FrbaOfertas.Modelo;
using FrbaOfertas.Modelo.Roles;
using FrbaOfertas.PropiedadesConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ComprarOferta
{
    public partial class ComprarOferta : Form
    {
        string cacheBusqueda;
        int montoActual;
        public ComprarOferta()
        {
            InitializeComponent();
        }

        private void ComprarOferta_Load(object sender, EventArgs e)
        {
            int monto = FrbaOfertas.ConectorDB.FuncionesCliente.ConseguirMontoActual();
            if (monto != -1)
            {
                lblmontoactual.Text = "Su monto actual es : " + monto;
                montoActual = monto;
            }
            else
            {
                MessageBox.Show("El rol actual no puede comprar oferta", "ERROR COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();


            }
           
        }

        private void cargarBusquedas() {
            cacheBusqueda=txtBuscador.Text.Trim(); 
          
            string fechaCarga = Config.Default.fechaSistema;
            this.dataGridCompraOfertas.DataSource = null;
            this.dataGridCompraOfertas.Rows.Clear();
            dataGridCompraOfertas.Refresh();
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            Cliente clienteactual = FrbaOfertas.ConectorDB.FuncionesCliente.traerCliente(FrbaOfertas.ConectorDB.FuncionesCliente.Get_Cliente_id(FrbaOfertas.Modelo.Usuario.id));

            string SQL = "SELECT p.Provee_Rs, Ofe_Precio_Ficticio,Ofe_Descrip , Ofe_Cant,  (case when Ofe_Max_Cant_Por_Usuario-HPBC.comprasDeOfertaRealizadas(" + clienteactual.documento + ", Ofe_Codigo) > Ofe_Cant then Ofe_Cant else Ofe_Max_Cant_Por_Usuario-HPBC.comprasDeOfertaRealizadas(" + clienteactual.documento + ", Ofe_Codigo) end) as 'Limite', Ofe_ID " +
                         "FROM HPBC.Proveedor p join HPBC.Oferta  on Ofe_ID_Proveedor = p.Provee_ID " +
                         "WHERE (p.Provee_Habilitado = 1 and Ofe_Accesible = 1 and '"+fechaCarga+"' between Ofe_Fecha AND Ofe_Fecha_Venc) ";

            if (txtBuscador.Text.Trim() != "")
            {
                SQL += " AND UPPER(Ofe_Descrip) LIKE '%' + UPPER('" + txtBuscador.Text.ToString() + "') + '%'";
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
                    dataGridCompraOfertas.Rows.Add();
                    dataGridCompraOfertas.Rows[cont].Cells[0].Value = reader["Provee_Rs"].ToString();
                    dataGridCompraOfertas.Rows[cont].Cells[1].Value = reader["Ofe_Descrip"].ToString();
                    dataGridCompraOfertas.Rows[cont].Cells[2].Value = reader["Ofe_Precio_Ficticio"].ToString();
                    dataGridCompraOfertas.Rows[cont].Cells[3].Value = reader["Ofe_Cant"].ToString();
                    dataGridCompraOfertas.Rows[cont].Cells[4].Value = reader["Limite"].ToString();
                    dataGridCompraOfertas.Rows[cont].Cells[6].Value = reader["Ofe_ID"].ToString();
                    cont++;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados");
            }

            conn.Close();

        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBuscador.Text.Trim()!= cacheBusqueda)
            this.cargarBusquedas();
        }

        private void dataGridCompraOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridCompraOfertas.Columns["Comprar"].Index && (dataGridCompraOfertas.Rows.Count > 1) && e.RowIndex != dataGridCompraOfertas.Rows.Count - 1)
            {
                if (montoActual >= (int) float.Parse(dataGridCompraOfertas.Rows[e.RowIndex].Cells["Precio"].Value.ToString()))
                {

                    int id = Int32.Parse(dataGridCompraOfertas.Rows[e.RowIndex].Cells["codigo"].Value.ToString());
                    Compra compra = new Compra();
                    compra.Compra_ID_Oferta = id.ToString();
                    compra.Compra_Fecha = Config.Default.fechaSistema;
                    compra.Compra_cantidad = dataGridCompraOfertas.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                    compra.Compra_Cantidad_Max_X_Usuario = dataGridCompraOfertas.Rows[e.RowIndex].Cells["maximo"].Value.ToString();
                    compra.Compra_Precio = dataGridCompraOfertas.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                    compra.Compra_Monto_Disponible = montoActual.ToString();
                    FrbaOfertas.ComprarOferta.CantidadOfe dialog = new FrbaOfertas.ComprarOferta.CantidadOfe(compra);
                    dialog.ShowDialog(this);
                    this.cargarBusquedas();
                    int monto = FrbaOfertas.ConectorDB.FuncionesCliente.ConseguirMontoActual();
                    if (monto != -1)
                    {
                        lblmontoactual.Text = "Su monto actual es : " + monto;
                        montoActual = monto;
                    }
                }
                else MessageBox.Show("No tiene creditos suficientes para comprar ni una unidad. Cargue en Cargar Creditos", "Error Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}