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
    public partial class CargarCredito : Form
    {
        public CargarCredito()
        {
            InitializeComponent();
            cantidad.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
        }

        private void lblmontoactual_Click(object sender, EventArgs e)
        {

        }

        private void CargarCredito_Load(object sender, EventArgs e)
        {   
            int monto = FrbaOfertas.ConectorDB.FuncionesCliente.ConseguirMontoActual();
            if(monto != -1){
                lblmontoactual.Text = "Su monto actual es : " + monto;
            }
                else {
                    MessageBox.Show("Un provedor no puede cargar credito", "ERROR CARGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Close();
                
                
            }
        }

        private bool validarMonto() {
            
            bool pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            if (validador.isEmpty(cantidad.Text))
            {
                validador.ErrorFaltaCompletarCampo(cantidad);
                pass = false;
            }
            else if (!validador.isNumeric(cantidad.Text))
            {
                validador.ErrornoNumeroEnteroPositivo(cantidad);
                pass = false;
            }
            else if (validador.superaCantidadCaracteres(cantidad.Text, 18))
            {
                validador.ErrorSuperaRango(cantidad);
                pass = false;
            }
            return pass;
        }


        private void Cargar_Click(object sender, EventArgs e)
        {

            if (this.validarMonto()) { 
            FrbaOfertas.CargaCredito.CargaTarjeta dialog =  new FrbaOfertas.CargaCredito.CargaTarjeta ();
            dialog.ShowDialog(this);
            }
        }
    }
}
