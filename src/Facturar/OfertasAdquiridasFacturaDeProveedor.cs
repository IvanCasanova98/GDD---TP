using FrbaOfertas.BaseDeDatos;
using FrbaOfertas.Modelo;
using FrbaOfertas.Modelo.Listado;
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

namespace FrbaOfertas.Facturar
{
    public partial class OfertasAdquiridasFacturaDeProveedor : Form
    {
        
        DateTime fecha_desde;
        DateTime fecha_hasta;
        int ID_PROVEEDOR;

        public OfertasAdquiridasFacturaDeProveedor(FechasFacturas fechas,int ID_PROVEEDOR)
        {
          
            InitializeComponent();
            fecha_desde = fechas.Fecha_Desde;
            fecha_hasta = fechas.Fecha_Hasta;
            this.ID_PROVEEDOR = ID_PROVEEDOR;
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OfertasAdquiridasFacturaDeProveedor_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT Ofe_ID , Ofe_Descrip , Compra_Fecha , Ofe_Precio_Ficticio , Compra_Cant, Compra_ID FROM HPBC.Oferta "
                          + " JOIN HPBC.Compra ON Compra_ID_Oferta = Ofe_ID "
                          + " WHERE Ofe_ID_Proveedor = " + this.ID_PROVEEDOR + " AND Compra_Fecha BETWEEN '" + fecha_desde.ToString("yyyy-MM-dd") + "' AND '" + fecha_hasta.ToString("yyyy-MM-dd") + "' AND Compra_facturada = 0";

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
                    dataGridView1.Rows[cont].Cells[0].Value = reader["Ofe_ID"].ToString();
                    dataGridView1.Rows[cont].Cells[1].Value = reader["Ofe_Descrip"].ToString();
                    dataGridView1.Rows[cont].Cells[2].Value = Convert.ToDateTime(reader["Compra_Fecha"]).ToShortDateString();
                    dataGridView1.Rows[cont].Cells[3].Value = reader["Ofe_Precio_Ficticio"].ToString();
                    dataGridView1.Rows[cont].Cells[4].Value = reader["Compra_Cant"].ToString();
                    dataGridView1.Rows[cont].Cells[5].Value = reader["Compra_ID"].ToString();
                    cont++;
                }
            }
            else
            {
                this.Close();
                MessageBox.Show("No se adquirieron ofertas en el periodo seleccionado con respecto a este proveedor");
                
            }

            conn.Close();
        }

        private void cmd_facturar_Click(object sender, EventArgs e)
        {
            int monto = FrbaOfertas.ConectorDB.FuncionesFactura.CalcularMonto(ID_PROVEEDOR, fecha_desde, fecha_hasta);
            
            FrbaOfertas.ConectorDB.FuncionesFactura.AltaFactura(ID_PROVEEDOR, monto);
            int numeroFactura = FrbaOfertas.ConectorDB.FuncionesFactura.get_ultima_factura();
            int idFacturar = FrbaOfertas.ConectorDB.FuncionesFactura.get_ultima_id_Factura();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                FrbaOfertas.ConectorDB.FuncionesFactura.CompraXFactura(Int32.Parse(row.Cells["IdCompra"].Value.ToString()), idFacturar);
            }
            
            MessageBox.Show(string.Format("Facturacion realizada con exito!. Numero de la factura: {0}, Importe:{1}",numeroFactura,monto) , "Facturacion", MessageBoxButtons.OK);
            this.Close();
        }

    }
}
