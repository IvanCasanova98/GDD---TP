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

namespace FrbaOfertas.AbmCliente
{
    public partial class ModificacionCliente : Form
    {

        int id;
        string dni;
        string email;
        public ModificacionCliente(int idAModificar)
        {
            id = idAModificar;
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
            txt_monto.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
        }

        private void cargarTodo() {
           Cliente clienteAModificar = FrbaOfertas.ConectorDB.FuncionesCliente.traerCliente(id);
           txt_nombre.Text = clienteAModificar.nombre.ToString();
           txt_apellido.Text = clienteAModificar.apellido.ToString();
           txt_calle.Text = clienteAModificar.Calle.ToString();
           txt_dni.Text = clienteAModificar.documento.ToString();
           dni= txt_dni.Text;
           txt_dpto.Text = clienteAModificar.Dpto.ToString();
           txt_localidad.Text = clienteAModificar.Localidad.ToString();
           txt_mail.Text = clienteAModificar.mail.ToString();
           email = txt_mail.Text;
           txt_piso.Text = clienteAModificar.Piso.ToString();
           txt_tel.Text = clienteAModificar.telefono.ToString();
           txt_monto.Text = clienteAModificar.monto.ToString();
           dateTimePicker.Value = clienteAModificar.fecha_nacimiento;
           checkBox1.Checked = Convert.ToBoolean(clienteAModificar.habilitado);
        
        }

        private Boolean validarDatos()
        {
            Boolean pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            //Valida Nombre
            pass = validador.validaCadenaCaracter(txt_nombre, pass);
            //Valida Apellido
            pass = validador.validaCadenaCaracter(txt_apellido, pass);
            //Valida DNI
            if(txt_dni.Text != dni)
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
            else if (!validador.isNumeric(txt_piso.Text))
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
            }
            else
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
            if (txt_mail.Text != email)
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
            //monto
            if (validador.isEmpty(txt_monto.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_monto);
                pass = false;
            }
            else if (!validador.isNumeric(txt_monto.Text))
            {
                validador.ErrornoContenerLetras(txt_monto);
                pass = false;
            }
            else if (validador.superaCantidadCaracteres(txt_monto.Text, 18))
            {
                validador.ErrorSuperaRango(txt_piso);
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

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {
            this.cargarTodo();
        }

        private void cmd_darAlta_Click(object sender, EventArgs e)
        {
            if (this.validarDatos()) {
                Cliente clienteUpdateado = new Cliente();
                clienteUpdateado.id = id;
                clienteUpdateado.nombre = txt_nombre.Text;
                clienteUpdateado.apellido = txt_apellido.Text;
                clienteUpdateado.Calle=txt_calle.Text;
                clienteUpdateado.documento=txt_dni.Text;
                clienteUpdateado.Dpto = txt_dpto.Text;
                clienteUpdateado.Localidad = txt_localidad.Text;
                clienteUpdateado.mail = txt_mail.Text;
                clienteUpdateado.Piso = txt_piso.Text;
                clienteUpdateado.telefono = txt_tel.Text;
                clienteUpdateado.monto = txt_monto.Text;
                clienteUpdateado.fecha_nacimiento = dateTimePicker.Value;
                clienteUpdateado.habilitado=checkBox1.Checked;
                FrbaOfertas.ConectorDB.FuncionesCliente.UpdateCliente(clienteUpdateado);
                MessageBox.Show("Cliente modificado con exito", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
