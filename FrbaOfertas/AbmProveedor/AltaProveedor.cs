using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Modelo.Roles;
using FrbaOfertas.Modelo;
using FrbaOfertas.Properties;
namespace FrbaOfertas.AbmProveedor
{
    public partial class AltaProveedor : Form
    {
        StateGuardar modoDeGuardado;
        public AltaProveedor(StateGuardar guardado)
        {
            this.modoDeGuardado = guardado;
            this.CenterToScreen();
            InitializeComponent();
            txt_cuit.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_razonsocial.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_calle.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_ciudad.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_codpostal.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_dpto.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_localidad.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_mail.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_piso.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_tel.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_rubro.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_nombreContacto.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
        }

        private Boolean validarCampos() {
            Boolean pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            //RS
            pass = validador.validaCadenaCaracter(txt_razonsocial, pass);
            //CALLE
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
            //PISO
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
            //LOCALIDAD
            pass = validador.validaCadenaCaracter(txt_localidad, pass);
            //CIUDAD
            pass = validador.validaCadenaCaracter(txt_ciudad, pass);
            //CODIGO POSTAL
            if (validador.isEmpty(txt_codpostal.Text))
            {
                validador.ErrorFaltaCompletarCampo(txt_codpostal);
                pass = false;
            }
            else if (!validador.isNumeric(txt_codpostal.Text))
            {
                validador.ErrornoContenerLetras(txt_codpostal);
                pass = false;
            }
            else if ((txt_codpostal.Text.Length != 4))
            {
                validador.ErrorSuperaRango(txt_codpostal);
                pass = false;
            }
            //MAIL
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
            //CUIT
            pass = validador.validarCuit(txt_cuit, pass);
            //TELEFONO
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
            //RUBRO
            pass = validador.validaCadenaCaracter(txt_rubro, pass);
            //PROV CONTACTO
            pass = validador.validaCadenaCaracter(txt_nombreContacto, pass);
            
            
            
            return pass;
        
        }


        private void cmd_darAlta_Click(object sender, EventArgs e)
        {
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            if (this.validarCampos()) {
                Proveedor proveedor = new Proveedor();
                proveedor.RazonSocial = txt_razonsocial.Text;
                proveedor.cuit = txt_cuit.Text.Replace("-", string.Empty);
                proveedor.codigoPostal = txt_codpostal.Text.Trim();
                proveedor.Calle = txt_calle.Text;
                proveedor.Piso = txt_piso.Text.Trim();
                proveedor.Dpto = txt_dpto.Text.Trim();
                proveedor.Localidad = txt_localidad.Text.Trim();
                proveedor.telefono = txt_tel.Text.Trim();
                proveedor.mail = txt_mail.Text.Trim();
                proveedor.Ciudad = txt_ciudad.Text.Trim();
                proveedor.rubro = txt_rubro.Text.Trim();
                proveedor.nombreContacto = txt_nombreContacto.Text.Trim();
                proveedor.habilitado = true;
                modoDeGuardado.Guardar(proveedor);
            
            }

        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_razonsocial.Text = "";
            txt_codpostal.Text = "";
            txt_cuit.Text = "";
            txt_calle.Text = "";
            txt_piso.Text = "";
            txt_dpto.Text = "";
            txt_localidad.Text = "";
            txt_tel.Text = "";
            txt_mail.Text = "";
            txt_ciudad.Text = "";
            txt_rubro.Text = "";
            txt_nombreContacto.Text = "";

            txt_razonsocial.Select();
        }

        private void AltaProveedor_Load(object sender, EventArgs e)
        {

        }

        private void txt_razonsocial_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
