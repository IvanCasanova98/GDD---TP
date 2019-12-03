using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FORM PARA MODIFICACION DE ROLES

namespace FrbaOfertas.AbmRol
{
    public partial class ModificacionRol : Form
    {
        int id;
        string detalle; //necesito guardar el detalle en una variable ya que al ser unique debo validarlo
        public ModificacionRol(int idAModificar)
        {
            id = idAModificar;
            InitializeComponent();
            textBox1.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
        }

        private void cargarTodo() {
            textBox1.Text = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerDetalleRol(id);
            detalle = textBox1.Text;
            checkBox1.Checked = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerEstadoRol(id);
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesFuncion.ObtenerFuncionalidades())
            {

                comboBox1.Items.Add(listing);
            }
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesRol.ObtenerFuncionalidadesDeUnRol(textBox1.Text))
            {
                this.dataGridView1.Rows.Add(listing, "X");
                this.comboBox1.Items.Remove(listing);
                
            }


        }


        private void ModificacionRol_Load(object sender, EventArgs e)
        {
            this.cargarTodo();
        }

        private Boolean validarDatos()
        {
            Boolean pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            pass = validador.validaCadenaCaracter(textBox1, pass);
            if (textBox1.Text != detalle) { 
                if(FrbaOfertas.ConectorDB.FuncionesRol.existeRol(textBox1.Text)){
                    validador.ErrorYaExisteRol(textBox1);
                    pass=false;
                }
            
            }
            if (this.dataGridView1.Rows.Count == 1)
            {
                FrbaOfertas.Utils.Validador.crearCajaDeError("Elija alguna funcion", "ERROR FUNCION");
                pass = false;
            }



            return pass;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && dataGridView1.Rows.Count > 1 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                this.comboBox1.Items.Add(dataGridView1.Rows[e.RowIndex].Cells["Funcion"].Value.ToString());
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (this.validarDatos())
            {
                List<String> lista = new List<String>();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells.Count >= 2 && //atleast two columns
                        item.Cells["Funcion"].Value != null) //value is not null
                    {
                        lista.Add(item.Cells["Funcion"].Value.ToString());
                    }
                }
                FrbaOfertas.ConectorDB.FuncionesFuncion.BorrarRolXFuncion(FrbaOfertas.ConectorDB.FuncionesRol.ObtenerDetalleRol(id));
                FrbaOfertas.ConectorDB.FuncionesRol.UpdatearRol(textBox1.Text, FrbaOfertas.ConectorDB.FuncionesRol.ObtenerDetalleRol(id), checkBox1.Checked, lista);
                foreach (String funcion in lista)
                {
                    FrbaOfertas.ConectorDB.FuncionesFuncion.GuardarRolXFuncion(textBox1.Text, funcion);

                }
                MessageBox.Show("Rol modificado con exito", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            this.dataGridView1.Rows.Add(comboBox1.SelectedItem.ToString(), "X");
            this.comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
        }
    }
}
