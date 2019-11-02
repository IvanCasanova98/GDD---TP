using FrbaOfertas.Modelo.GuardarDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.RegistroUsuario
{
    public partial class RegistroUsr : Form
    {
        public RegistroUsr()
        {
            InitializeComponent();
            tb_user.GotFocus += new EventHandler(this.UserGotFocus);
            tb_pass.GotFocus += new EventHandler(this.PassGotFocus);
            tb_pass_confirm.GotFocus += new EventHandler(this.ConfirmGotFocus);
        }

        private void RegistroUsr_Load(object sender, EventArgs e)
        {
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesRegistrables())
            {
                cbo_rol.Items.Add(listing);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {

        }

        private Boolean validarDatos()
        {
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();

            Boolean pass = true;
            
            
            if (validador.existeUsernameConDB(tb_user.Text))
            {
            tb_user.Text = "El usuario ya existe";
            tb_user.ForeColor = Color.Red;
            pass = false;
            } else
            if (validador.isEmpty(tb_user.Text))
            {
                validador.ErrorFaltaCompletarCampo(tb_user);
                pass = false;
            }else 
            
            if(string.IsNullOrWhiteSpace(tb_user.Text) || tb_user.Text.Contains(" ")){
                tb_user.Text = "El usuario no puede contener espacios";
                tb_user.ForeColor = Color.Red;
                pass = false;
            }

       

            if (validador.isEmpty(tb_pass.Text))
            {
                validador.ErrorFaltaCompletarCampo(tb_pass);
                tb_pass.PasswordChar = '\0';
                pass = false;
            }
            if (validador.isEmpty(tb_pass_confirm.Text))
            {
                validador.ErrorFaltaCompletarCampo(tb_pass_confirm);
                tb_pass_confirm.PasswordChar = '\0';
                pass = false;
            }
            if (tb_pass.Text != tb_pass_confirm.Text) {
                MessageBox.Show("Las contraseñas no coinciden");
                tb_pass_confirm.Text = "";
                pass = false;
            }
            // if(rol no esta vacío)
            return pass;
        }

        private void cmd_sgte_Click(object sender, EventArgs e)
        {
            if (this.validarDatos())
            {
                switch(cbo_rol.Text)
                {
                    case "Cliente":
                        FrbaOfertas.Modelo.Usuario.username = tb_user.Text;
                        FrbaOfertas.Modelo.Usuario.password = tb_pass.Text;
                        FrbaOfertas.AbmCliente.AltaCliente dialogCliente = new FrbaOfertas.AbmCliente.AltaCliente(new RegistroGuardar());
                        dialogCliente.ShowDialog(this);
                        this.Close();
                        break;
                    case "Proveedor":
                        FrbaOfertas.Modelo.Usuario.username = tb_user.Text;
                        FrbaOfertas.Modelo.Usuario.password = tb_pass.Text;
                        FrbaOfertas.AbmProveedor.AltaProveedor dialogProveedor = new FrbaOfertas.AbmProveedor.AltaProveedor(new RegistroGuardar());
                        dialogProveedor.ShowDialog(this);
                        this.Close();
                        break;
                    case "Administrador":
                        MessageBox.Show("No puede ser administrador.");
                        break;
                    default:
                        FrbaOfertas.Utils.Validador.crearCajaDeError("Elija un rol", "FALTA ROL");
                        break;

                }

            }
        }

        public void UserGotFocus(object sender, EventArgs e)
        {

            if (tb_user.Text == "El usuario ya existe" || tb_user.Text == "Falta completar campo" || tb_user.Text == "El usuario no puede contener espacios")
            {
                tb_user.Text = "";
                tb_user.ForeColor = Color.Black;
            }
        }

        public void PassGotFocus(object sender, EventArgs e)
        {

            if (tb_pass.Text == "Falta completar campo")
            {
                tb_pass.Text = "";
                tb_pass.ForeColor = Color.Black;
                tb_pass.PasswordChar = '*';
            }
        }
        public void ConfirmGotFocus(object sender, EventArgs e)
        {

            if (tb_pass_confirm.Text == "Falta completar campo")
            {
                tb_pass_confirm.Text = "";
                tb_pass_confirm.ForeColor = Color.Black;
                tb_pass_confirm.PasswordChar = '*';
            }
        }

        private void cbo_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
