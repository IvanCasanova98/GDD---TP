using FrbaOfertas.BaseDeDatos;
using FrbaOfertas.Modelo;
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

namespace FrbaOfertas.Facturar
{
    public partial class FacturarListaProveedores : Form
    {
        FechasFacturas fechasFacturas;


        public FacturarListaProveedores(FechasFacturas fechas)
        {
            InitializeComponent();

            txt_cuit.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_razonsocial.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_mail.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);

            fechasFacturas = fechas;

            
        }

        private void FacturarListaProveedores_Load(object sender, EventArgs e)
        {
            


        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_razonsocial.Text = "";
            txt_cuit.Text = "";
            txt_mail.Text = "";
            txt_razonsocial.Select();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT p.Provee_ID, p.Provee_Rs, p.Provee_Piso, p.Provee_Calle, p.Provee_Dpto, p.Provee_Localidad, p.Provee_Ciudad, p.Provee_CodPostal, p.Provee_Mail, p.Provee_CUIT, p.Provee_Tel, p.Provee_NombreContacto, p.Provee_Habilitado, r.Rubro_detalle " +
                         "FROM HPBC.Proveedor p join HPBC.Rubro r on r.Rubro_ID = p.Provee_Rubro " +
                         "WHERE p.Provee_Habilitado = 1 ";

            if (txt_razonsocial.Text.Trim() != "")
            {
                SQL += " AND UPPER(p.Provee_Rs) LIKE '%' + UPPER('" + txt_razonsocial.Text.ToString() + "') + '%'";
            }
            if (txt_mail.Text.Trim() != "")
            {
                SQL += " AND UPPER(p.Provee_Mail) LIKE '%' + UPPER('" + txt_mail.Text.ToString() + "') + '%'";
            }
            if (txt_cuit.Text.Trim() != "")
            {
                SQL += " AND p.Provee_CUIT = " + txt_cuit.Text.ToString().Replace("-", "");
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
                    dataGridView1.Rows[cont].Cells[0].Value = reader["Provee_ID"].ToString();
                    dataGridView1.Rows[cont].Cells[1].Value = reader["Provee_Rs"].ToString();
                    dataGridView1.Rows[cont].Cells[2].Value = reader["Provee_CUIT"].ToString();
                    dataGridView1.Rows[cont].Cells[3].Value = reader["Provee_Mail"].ToString();
                    dataGridView1.Rows[cont].Cells[4].Value = reader["Provee_Tel"].ToString();
                    dataGridView1.Rows[cont].Cells[5].Value = reader["Provee_Calle"].ToString();
                    dataGridView1.Rows[cont].Cells[6].Value = reader["Provee_Piso"].ToString();
                    dataGridView1.Rows[cont].Cells[7].Value = reader["Provee_Dpto"].ToString();
                    dataGridView1.Rows[cont].Cells[8].Value = reader["Provee_Localidad"].ToString();
                    dataGridView1.Rows[cont].Cells[9].Value = reader["Provee_Ciudad"].ToString();
                    dataGridView1.Rows[cont].Cells[10].Value = reader["Provee_CodPostal"].ToString();
                    dataGridView1.Rows[cont].Cells[11].Value = reader["Provee_NombreContacto"].ToString();
                    dataGridView1.Rows[cont].Cells[12].Value = reader["Rubro_detalle"].ToString();
                    dataGridView1.Rows[cont].Cells[13].Value = Convert.ToBoolean(reader["Provee_Habilitado"]);
                    cont++;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para estos filtros");
            }

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Seleccionar"].Index && (dataGridView1.Rows.Count > 1) && e.RowIndex != dataGridView1.Rows.Count - 1)
            {


                    int idProveedor = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    if (FrbaOfertas.ConectorDB.FuncionesFactura.CalcularMonto(idProveedor,fechasFacturas.Fecha_Desde,fechasFacturas.Fecha_Hasta)!=-1){
                    FrbaOfertas.Facturar.OfertasAdquiridasFacturaDeProveedor dialog = new FrbaOfertas.Facturar.OfertasAdquiridasFacturaDeProveedor(fechasFacturas, idProveedor);
                    dialog.ShowDialog(this);
                    }
                    else MessageBox.Show("Todas las compras del proveedor ya fueron facturadas en el periodo seleccionado","Facturacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

            
        }
    }
}
