using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.ConectorDB;
namespace FrbaOfertas.AbmRol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            textBox1.GotFocus += new EventHandler(this.UserGotFocus);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargarComboFunciones() {
            comboBox1.Items.Clear();
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesFuncion.ObtenerFuncionalidades())
            {
                
                comboBox1.Items.Add(listing);
            }
        }
        
        
        private void AltaRol_Load(object sender, EventArgs e)
        {
            this.cargarComboFunciones();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
             
             this.dataGridView1.Rows.Add(comboBox1.SelectedItem.ToString(), "X");
             this.comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox1.Focus();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            
            this.cargarComboFunciones();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean validarDatos() {
            Boolean pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            pass = validador.validaCadenaCaracter(textBox1, pass);
            if(FrbaOfertas.ConectorDB.FuncionesRol.existeRol(textBox1.Text)){
                validador.ErrorYaExisteRol(textBox1);
                pass=false;
            }
            if(this.dataGridView1.Rows.Count == 1){
                FrbaOfertas.Utils.Validador.crearCajaDeError("Elija alguna funcion", "ERROR FUNCION");
                pass=false;
            }



            return pass;
        }
        
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (this.validarDatos()) { 
                List<String> lista = new List<String>();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells.Count >= 2 && //atleast two columns
                        item.Cells["Funcion"].Value != null) //value is not null
                    {
                        lista.Add(item.Cells["Funcion"].Value.ToString());
                    }
                }

                FrbaOfertas.ConectorDB.FuncionesRol.GuardarRol(textBox1.Text, lista);
                MessageBox.Show("Rol creado con exito", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public void UserGotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "El campo ya existe" || textBox.Text == "Falta completar campo" || textBox.Text == "El Campo ingresado ya existe en la base de datos" || textBox.Text == "El Rol ya existe"
                || textBox.Text == "El Campo no debe contener numeros" || textBox.Text == "El Campo no debe contener Letras" || textBox.Text == "El Campo supera el rango maximo de caracteres" || textBox.Text == "Usá el formato nombre@ejemplo.com")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && dataGridView1.Rows.Count > 1 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                this.comboBox1.Items.Add(dataGridView1.Rows[e.RowIndex].Cells["Funcion"].Value.ToString());
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
