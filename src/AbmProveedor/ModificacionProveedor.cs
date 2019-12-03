using FrbaOfertas.Modelo.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FORM PARA MODIFICACION DE PROVEEDORES

namespace FrbaOfertas.AbmProveedor
{
    public partial class ModificacionProveedor : Form
    {
        int id;
        string rs;
        string cuit;
        public ModificacionProveedor(int idamodificar)
        {
            id = idamodificar;
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
            cargarTodo();
        }
        private void cargarTodo()
        {
            Proveedor ProveedorAModificar = FrbaOfertas.ConectorDB.FuncionesProveedor.traerProveedor(id);
            txt_razonsocial.Text = ProveedorAModificar.RazonSocial.ToString();
            rs = txt_razonsocial.Text;
            txt_calle.Text = ProveedorAModificar.Calle.ToString();
            txt_piso.Text = ProveedorAModificar.Piso.ToString();
            txt_dpto.Text = ProveedorAModificar.Dpto.ToString();
            txt_localidad.Text = ProveedorAModificar.Localidad.ToString();
            txt_ciudad.Text = ProveedorAModificar.Ciudad.ToString();
            txt_codpostal.Text = ProveedorAModificar.codigoPostal.ToString();
            txt_mail.Text = ProveedorAModificar.mail.ToString();
            txt_cuit.Text = ProveedorAModificar.cuit.ToString();
            cuit = txt_cuit.Text;
            txt_tel.Text = ProveedorAModificar.telefono.ToString();
            txt_rubro.Text = ProveedorAModificar.rubro.ToString();
            checkBox1.Checked = Convert.ToBoolean(ProveedorAModificar.habilitado);
            if (FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(id).Contains("Proveedor"))
            {
                checkBox1.Visible = false;
            }
        }
        private Boolean validarCampos()
        {
            Boolean pass = true;
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            //RS
            if (txt_razonsocial.Text != rs)
                if (!validador.existeRSenDB(txt_razonsocial.Text))
                {
                    pass = validador.validaCadenaCaracter(txt_razonsocial, pass);
                }
                else
                {
                    validador.ErrorCampoYaExisteEnLaBase(txt_razonsocial);
                    pass = false;
                }
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
            if (txt_cuit.Text != cuit)
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
            if (validarCampos()) {
                Proveedor proveedorUpdateado = new Proveedor();
                proveedorUpdateado.RazonSocial = txt_razonsocial.Text;
                proveedorUpdateado.Calle = txt_calle.Text;
                proveedorUpdateado.Piso=txt_piso.Text;
                proveedorUpdateado.Dpto=txt_dpto.Text;
                proveedorUpdateado.Localidad=txt_localidad.Text;
                proveedorUpdateado.Ciudad=txt_ciudad.Text;
                proveedorUpdateado.codigoPostal=txt_codpostal.Text;
                proveedorUpdateado.mail=txt_mail.Text;
                proveedorUpdateado.cuit = txt_cuit.Text;
                proveedorUpdateado.telefono=txt_tel.Text;
                proveedorUpdateado.rubro=txt_rubro.Text;
                proveedorUpdateado.habilitado= checkBox1.Checked;
                FrbaOfertas.ConectorDB.FuncionesProveedor.UpdateProveedor(proveedorUpdateado);
                MessageBox.Show("Proveedor modificado con exito", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            
            }
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
