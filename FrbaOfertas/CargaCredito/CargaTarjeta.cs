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
        public CargaTarjeta()
        {
            InitializeComponent();
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
            else if (validador.fueraDeRango(textBox1.Text, 16, 16))
            {
                validador.ErrorSuperaRango(textBox1);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
