using FrbaOfertas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CargaCredito
{
    public partial class CargaTarjeta : Form
    {
        string montoCargar;
        public CargaTarjeta(string monto)
        {
            
            InitializeComponent();
            montoCargar = monto;
            textBox2.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            textBox1.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarTodo() {
            bool pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            //valido numero tarjetas
            if (validador.isEmpty(textBox2.Text))
            {
                validador.ErrorFaltaCompletarCampo(textBox2);
                pass = false;
            }
            else if (!validador.isNumeric(textBox2.Text))
            {
                validador.ErrornoContenerLetras(textBox2);
                pass = false;
            }
            else if (validador.fueraDeRango(textBox2.Text, 16, 16))
            {
                validador.ErrorSuperaRango(textBox2);
                pass = false;
            }
            //validar cod
            if (validador.isEmpty(textBox1.Text))
            {
                validador.ErrorFaltaCompletarCampo(textBox1);
                pass = false;
            }
            else if (!validador.isNumeric(textBox1.Text))
            {
                validador.ErrornoContenerLetras(textBox1);
                pass = false;
            }
            else if (validador.fueraDeRango(textBox1.Text, 3, 4))
            {
                validador.ErrorSuperaRango(textBox1);
                pass = false;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecciones un tipo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pass = false;
            }
            

            return pass;
        
        
        }

        private void solonumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.validarTodo()) {
                Tarjeta tarjeta = FrbaOfertas.ConectorDB.FuncionesCarga.ExisteTarjeta(textBox2.Text, textBox1.Text);
                if (tarjeta.TARJ_TIPO=="False"){
                    tarjeta.TARJ_NRO = textBox2.Text;
                    tarjeta.TARJ_COD_SEG = textBox1.Text;
                    tarjeta.TARJ_TIPO = comboBox1.Text;
                    FrbaOfertas.ConectorDB.FuncionesCarga.AltaTarjeta(tarjeta); 
                    }
                if(tarjeta.TARJ_TIPO!= comboBox1.Text){
                    MessageBox.Show("El tipo de la tarjeta ingresada es incorrecto","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                } else {
                    FrbaOfertas.ConectorDB.FuncionesCarga.AltaCarga(tarjeta,this.montoCargar);
                    MessageBox.Show("Monto Cargado con exito", "Monto Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                
                }
            }
                
                


        }
            
   

        private void fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox text =(TextBox) sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (text.Text.Length == 2)
                {
                    text.Text = text.Text + "/";
                    text.SelectionStart = text.Text.Length;
                    text.SelectionLength = 0;
                }
                
            }
      
            


        }

    }
}
