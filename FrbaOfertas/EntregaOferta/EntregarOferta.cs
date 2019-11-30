using FrbaOfertas.BaseDeDatos;
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

namespace FrbaOfertas.EntregarOferta
{
    public partial class EntregarOferta : Form
    {
        FrbaOfertas.Modelo.Roles.Proveedor proveedor;

        public EntregarOferta()
        {
            InitializeComponent();
        }

        private void buscar_cupon() 
        {
            if (this.validarDatos())
            {

                this.dataGridViewCUPON.DataSource = null;
                this.dataGridViewCUPON.Rows.Clear();
                dataGridViewCUPON.Refresh();
                SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
                conn.Open();

                string SQL = " SELECT Cupon_ID , Cup_Fecha_Venc , Cup_Codigo FROM HPBC.Cupon " +
                             " JOIN HPBC.Compra ON Cupon_ID_Compra = Compra_ID " +
                             " JOIN HPBC.Oferta ON Compra_ID_Oferta = Ofe_ID " +
                             " WHERE Ofe_ID_Proveedor = " + proveedor.id + " AND Cup_Fecha_Consumo IS NULL AND Cup_Fecha_Venc > '" + Config.Default.fechaSistema + "' AND UPPER(Cup_Codigo) LIKE '" + txt_codigo_cupon.Text.ToUpper() + "%'";

                SqlCommand command = new SqlCommand(SQL, conn);

                command.Connection = conn;
                command.CommandType = CommandType.Text;

                SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
                int cont = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridViewCUPON.Rows.Add();
                        dataGridViewCUPON.Rows[cont].Cells[0].Value = reader["Cup_Fecha_Venc"].ToString();
                        dataGridViewCUPON.Rows[cont].Cells[1].Value = reader["Cup_Codigo"].ToString();
                        dataGridViewCUPON.Rows[cont].Cells[3].Value = reader["Cupon_ID"].ToString();
                        cont++;
                    }
                }
                else
                {
                    MessageBox.Show("El proveedor no posee cupones para dar de baja.","Error canje",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                conn.Close();
            }
        }

        private void cmd_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_codigo_cupon.Text = "";
            txt_codigo_cupon.Select();
            this.dataGridViewCUPON.DataSource = null;
            this.dataGridViewCUPON.Rows.Clear();
        }

        private void cmd_buscar_Click(object sender, EventArgs e)
        {
            this.buscar_cupon();
        }

        private Boolean validarDatos()
        {
            Boolean pass=true;
            if (txt_codigo_cupon.Text.Trim() == "")
            {
                pass = false;
                MessageBox.Show("Se debe ingresar un codigo de cupon");
        
            }
            return pass;
            
        }

        private void EntregarOferta_Load(object sender, EventArgs e)
        {
            int usuario_id = FrbaOfertas.Modelo.Usuario.id;
            
            int proveedor_id = FrbaOfertas.ConectorDB.FuncionesProveedor.Get_Proveedor_id(usuario_id);
            this.proveedor = FrbaOfertas.ConectorDB.FuncionesProveedor.traerProveedor(proveedor_id);
            
        }

        private void dataGridViewCUPON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCUPON.Columns["Seleccionar"].Index && (dataGridViewCUPON.Rows.Count > 1) && e.RowIndex != dataGridViewCUPON.Rows.Count - 1)
            {
                int id_cupon = Int32.Parse(dataGridViewCUPON.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                 
                dataGridViewCUPON.DataSource = null;
                dataGridViewCUPON.Rows.Clear();

                FrbaOfertas.ConectorDB.FuncionesCupon.updateCuponEntregado(id_cupon);
                MessageBox.Show("Cupon Entregado", "Cupon Entregado Con Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buscar_cupon();
            }
        }


    }
}
