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
        
        Listado tipoListado;
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
            string SQL = "SELECT Ofe_ID , Ofe_Descrip , clie_nombre , Ofe_Precio_Ficticio , Compra_Cant FROM HPBC.Proveedor "
                          + " JOIN HPBC.Oferta ON Ofe_ID_Proveedor = Provee_ID "
                          + " JOIN HPBC.Compra ON Compra_ID_Oferta = Ofe_ID "
                          + " JOIN HPBC.Cliente ON Compra_ID_Clie_Dest = clie_ID "
                          + " WHERE Provee_ID = '" + ID_PROVEEDOR + "' AND (Compra_Fecha BETWEEN " + fecha_desde.ToString("yyyy-MM-dd") + " AND " + fecha_hasta.ToString("yyyy-MM-dd") + ")" + " AND Compra_facturada = 0";

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
                    dataGridView1.Rows[cont].Cells[2].Value = reader["clie_nombre"].ToString();
                    dataGridView1.Rows[cont].Cells[3].Value = reader["Ofe_Precio_Ficticio"].ToString();
                    dataGridView1.Rows[cont].Cells[3].Value = reader["Compra_Cant"].ToString();
                    cont++;
                }
            }
            else
            {
    
                MessageBox.Show("No se adquirieron ofertas en el periodo seleccionado con respecto a este proveedor");

            }

            conn.Close();
        }

        private void cmd_facturar_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO HPBC.Factura (Fact_ID_Proveedor, Fact_Fecha, Fact_Nro, Fact_Monto) " +
                                " VALUES ( SELECT Fact_ID_Proveedor, " + Config.Default.fechaSistema + ", MAX(Fact_Nro)+1, SUM(Ofe_Precio_Ficticio*Compra_Cant) FROM HPBC.Proveedor "
                                       + " JOIN HPBC.Oferta ON Ofe_ID_Proveedor = Provee_ID "
                                       + " JOIN HPBC.Compra ON Compra_ID_Oferta = Ofe_ID "
                                       + " JOIN HPBC.Cliente ON Compra_ID_Clie_Dest = clie_ID "
                                       + " JOIN HPBC.Factura ON Fact_ID_Proveedor = Provee_ID "
                                       + " WHERE Provee_ID = '" + ID_PROVEEDOR + "' AND (Compra_Fecha BETWEEN " + fecha_desde.ToString("yyyy-MM-dd") + " AND " + fecha_hasta.ToString("yyyy-MM-dd") + ")" + " AND Compra_facturada = 0"
                                       + " GROUP BY Fact_ID_Proveedor )";

            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();

            
        }
    }
}
