using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.BaseDeDatos;
using FrbaOfertas.Modelo.Listado;
using System.Data.SqlClient;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

            int minimoAnio = FrbaOfertas.ConectorDB.ObtenerRangoAñosFacturas.obtenerMinimoAño();
            int maximoAnio = FrbaOfertas.ConectorDB.ObtenerRangoAñosFacturas.obtenerMaximoAño();
            for (int i = minimoAnio; i <= maximoAnio; i++)
            {
                cboAños.Items.Add(i);
            }
            radioBtnPRIMERO.Checked = true;
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            this.dataGridViewListadoFACTURAS.DataSource = null;
            this.dataGridViewListadoFACTURAS.Rows.Clear();
            this.dataGridViewListadoOFERTAS.DataSource = null;
            this.dataGridViewListadoOFERTAS.Rows.Clear();
            radioBtnPRIMERO.Checked = true;
    
        }

        private void cmdListadoOFERTAS_Click(object sender, EventArgs e)
        {
            if (this.validarDatos())
            {
            

                this.dataGridViewListadoOFERTAS.Visible = true;
                this.dataGridViewListadoFACTURAS.Visible = false;
           
               int rango_inf = 0;
               int rango_sup = 0;
              if (radioBtnPRIMERO.Checked == true)
                {
                    rango_inf = 1;
                    rango_sup = 6;
                } else if (radioBtnSEGUNDO.Checked == true)
                {
                    rango_inf = 7;
                    rango_sup = 12;
                }
                    this.dataGridViewListadoOFERTAS.DataSource = null;
                    this.dataGridViewListadoOFERTAS.Rows.Clear();
                    dataGridViewListadoOFERTAS.Refresh();
                    SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
                    conn.Open();

                    string SQL = "	SELECT TOP 5 oferta.Ofe_ID_Proveedor AS 'ID PROVEEDOR', (SELECT Provee_Rs FROM [GD2C2019].[HPBC].[Proveedor] WHERE Provee_ID = oferta.Ofe_ID_Proveedor) AS 'Razon Social', CONCAT(COUNT(Ofe_ID_Proveedor),' ofertas') AS 'Cantidad Ofertas Realizadas',  CONCAT(AVG((((Ofe_Precio) - (Ofe_Precio_Ficticio))/ Ofe_Precio))*100,' %')  AS 'Porcentaje de Descuento Ofrecido'"
                        + " FROM [HPBC].[Oferta] oferta"
                        + " WHERE YEAR(Ofe_Fecha) ='" + cboAños.SelectedItem + "' AND ((MONTH(Ofe_Fecha)) BETWEEN " + rango_inf + " AND " + rango_sup + ")"
                        + " GROUP BY Ofe_ID_Proveedor "
                        + " ORDER BY AVG((((Ofe_Precio) - (Ofe_Precio_Ficticio))/ Ofe_Precio)) DESC";

                    SqlCommand command = new SqlCommand(SQL, conn);

                    command.Connection = conn;
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
                    int cont = 0;
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridViewListadoOFERTAS.Rows.Add();
                            dataGridViewListadoOFERTAS.Rows[cont].Cells[0].Value = reader["ID PROVEEDOR"].ToString();
                            dataGridViewListadoOFERTAS.Rows[cont].Cells[1].Value = reader["Razon Social"].ToString();
                            dataGridViewListadoOFERTAS.Rows[cont].Cells[2].Value = reader["Cantidad Ofertas Realizadas"].ToString();
                            dataGridViewListadoOFERTAS.Rows[cont].Cells[3].Value = reader["Porcentaje de Descuento Ofrecido"].ToString();
                            cont++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados para ese año");
                    }

                    conn.Close();
            }

        }

        private void cmdListadoFACTURACION_Click(object sender, EventArgs e)
        {
            if (this.validarDatos())
            {

                this.dataGridViewListadoOFERTAS.Visible = false;
                this.dataGridViewListadoFACTURAS.Visible = true;

                int rango_inf = 0;
                int rango_sup = 0;
                if (radioBtnPRIMERO.Checked == true)
                {
                    rango_inf = 1;
                    rango_sup = 6;
                }
                else if (radioBtnSEGUNDO.Checked == true)
                {
                    rango_inf = 7;
                    rango_sup = 12;
                }
                this.dataGridViewListadoFACTURAS.DataSource = null;
                this.dataGridViewListadoFACTURAS.Rows.Clear();
                dataGridViewListadoFACTURAS.Refresh();
                SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
                conn.Open();

                string SQL = "SELECT TOP 5	fact.Fact_ID_Proveedor AS 'ID PROVEEDOR',(SELECT Provee_Rs FROM [GD2C2019].[HPBC].[Proveedor] WHERE Provee_ID = fact.Fact_ID_Proveedor) AS 'Razon Social', CONCAT(SUM(fact.Fact_Monto), ' $') AS 'Total Facturado', CONCAT(COUNT(fact.Fact_Nro), ' facturas') AS 'Cantidad de Facturas'"
                           + " FROM [GD2C2019].[HPBC].[Factura] fact"
                           + " WHERE (YEAR(Fact_Fecha)) ='" + cboAños.SelectedItem + "' AND ((MONTH(Fact_Fecha)) BETWEEN " + rango_inf + " AND " + rango_sup + ")"
                           + " GROUP BY Fact_ID_Proveedor"
                           + " ORDER BY SUM(fact.Fact_Monto) DESC";

                SqlCommand command = new SqlCommand(SQL, conn);

                command.Connection = conn;
                command.CommandType = CommandType.Text;

                SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
                int cont = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridViewListadoFACTURAS.Rows.Add();
                        dataGridViewListadoFACTURAS.Rows[cont].Cells[0].Value = reader["ID PROVEEDOR"].ToString();
                        dataGridViewListadoFACTURAS.Rows[cont].Cells[1].Value = reader["Razon Social"].ToString();
                        dataGridViewListadoFACTURAS.Rows[cont].Cells[2].Value = reader["Total Facturado"].ToString();
                        dataGridViewListadoFACTURAS.Rows[cont].Cells[3].Value = reader["Cantidad de Facturas"].ToString();
                        cont++;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para ese año");
                }

                conn.Close();
            }
    }
   

        private bool validarDatos(){
            if (cboAños.Text == "")
            {
                MessageBox.Show("Seleccione un año", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }


    }

