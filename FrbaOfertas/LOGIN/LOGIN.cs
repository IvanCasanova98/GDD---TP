using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Utils;
using FrbaOfertas.PropiedadesConfig;

namespace FrbaOfertas
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            txtUsuario.GotFocus += new EventHandler(this.UserGotFocus);
            txtUsuario.LostFocus += new EventHandler(this.UserLostFocus);
            txtPassword.GotFocus += new EventHandler(this.PassGotFocus);
            txtPassword.LostFocus += new EventHandler(this.PassLostFocus);
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            
        }


        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrbaOfertas.RegistroUsuario.RegistroUsr dialog = new FrbaOfertas.RegistroUsuario.RegistroUsr();
            dialog.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UserGotFocus(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "Nombre de usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        public void UserLostFocus(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Nombre de usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        public void PassGotFocus(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        public void PassLostFocus(object sender, EventArgs e)
        {

            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(FrbaOfertas.Utils.ProtocoloSQL.protocoloLoginSQL(txtUsuario.Text,txtPassword.Text)){
                FrbaOfertas.Modelo.Usuario.IngresoUsuario(txtUsuario.Text, txtPassword.Text);
                FrbaOfertas.Home.MenuPrincial menu = new FrbaOfertas.Home.MenuPrincial();
                FrbaOfertas.Utils.Transicion.transicionForms(this, menu);

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


      


    }
}
