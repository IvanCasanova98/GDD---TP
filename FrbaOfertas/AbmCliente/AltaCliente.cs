using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Modelo;
using FrbaOfertas.Properties;
namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {

        StateGuardar modoDeGuardado;
        public AltaCliente(StateGuardar guardado)
        {
            this.modoDeGuardado = guardado;
            InitializeComponent();

            this.CenterToScreen();
            txt_nombre.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_apellido.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_calle.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_dni.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_dpto.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_localidad.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_mail.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_piso.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_tel.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
        }

        /*cuando haya que modificar descomentar este. Seria como un decorator medio trucho ya que le da la funcionalidad de agregar los datos de un cliente ya cargado
        public AltaCliente(StateGuardar guardado,Cliente cliente a modificar){
         * this.AltaCliente(guardado);
         *  txt_nombre.Text = cliente.nombre;
            faltan los demas
         * 
         * 
         * }
         
          
        */
        private Boolean validarDatos()
        {
            Boolean pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            //Valida Nombre
            pass = validador.validaCadenaCaracter(txt_nombre,pass);
            //Valida Apellido
            pass = validador.validaCadenaCaracter(txt_apellido,pass);           
            //Valida DNI
            pass = validador.validacionDni(txt_dni, pass);
            //Valida Calle

            if (validador.isEmpty(txt_calle.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_calle);
                pass = false;
            }
            else if (validador.fueraDeRango(txt_calle.Text, 0, 255))
            {
                validador.ErrorSuperaRango(txt_calle);
                pass = false;
            }
            
            //Valida Piso
            if (validador.isEmpty(txt_piso.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_piso);
                pass = false;
            }
            else
            if (!validador.isNumeric(txt_piso.Text))
            {
                validador.ErrornoContenerLetras(txt_piso);
                pass = false;
            }
            else if (validador.superaCantidadCaracteres(txt_piso.Text, 2))
            {
                validador.ErrorSuperaRango(txt_piso);
                pass = false;
            }
            //DPTO
            if (validador.isEmpty(txt_dpto.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_dpto);
                pass = false;
            }else
            if (validador.isNumeric(txt_dpto.Text))
            {
                validador.ErrornoContenerNumeros(txt_dpto);
                pass = false;
            }
            else if (validador.fueraDeRango(txt_dpto.Text, 0, 3))
            {
                validador.ErrorSuperaRango(txt_dpto);
                pass = false;
            }
            //Localidad
            pass = validador.validaCadenaCaracter(txt_localidad, pass);
            //Telefono
            if (validador.isEmpty(txt_tel.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_tel);
                pass = false;
            }
            else if (!validador.isNumeric(txt_tel.Text))
            {
                validador.ErrornoContenerLetras(txt_tel);
                pass = false;
            }
            else if (validador.fueraDeRango(txt_tel.Text, 8, 15))
            {
                validador.ErrorSuperaRango(txt_tel);
                pass = false;
            }
            //EMAIL
            if (validador.isEmpty(txt_mail.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_mail);
                pass = false;
            }
            else if (validador.isNumeric(txt_mail.Text))
            {
                validador.ErrornoContenerLetras(txt_mail);
                pass = false;
            }
            else if (!validador.IsValidEmail(txt_mail.Text))
            {
                validador.ErrorEmail(txt_mail);
                pass = false;
            }
            else if (validador.existeMailenDB(txt_mail.Text))
            {
                validador.ErrorCampoYaExisteEnLaBase(txt_mail);
                pass = false;
            }


                               
                                  
 
          
                //Validamos FECHA NACIMIENTO Clie_Fecha_Nac
            if (validador.FechaFutura(dateTimePicker.Value))
            {
                MessageBox.Show("Fecha de nacimiento fuera de rango");
                pass = false;
            }
            return pass;
        }


        private void cmd_darAlta_Click(object sender, EventArgs e)
        {
            
            if (this.validarDatos()) {
                Cliente cliente = new Cliente();
                cliente.nombre = txt_nombre.Text.Trim();
                cliente.apellido = txt_apellido.Text.Trim();
                cliente.documento = txt_dni.Text.Trim();
                cliente.Calle = txt_calle.Text;
                cliente.Piso = txt_piso.Text.Trim();
                cliente.Dpto = txt_dpto.Text.Trim();
                cliente.Localidad = txt_localidad.Text.Trim();
                cliente.telefono = txt_tel.Text.Trim();
                cliente.mail = txt_mail.Text.Trim();
                cliente.fecha_nacimiento = dateTimePicker.Value;
                cliente.habilitado = true;
                modoDeGuardado.Guardar(cliente);
                
                this.Close();
                
            
            }
                
                
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_calle.Text = "";
            txt_piso.Text = "";
            txt_dpto.Text = "";
            txt_localidad.Text = "";
            txt_tel.Text = "";
            txt_mail.Text = "";

            dateTimePicker.Value = DateTime.Now;

            txt_nombre.Select();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }


     


       
    }
}
