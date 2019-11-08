using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.DatosPersonales.Usuarios
{
    public partial class DatosPersonalesUsuario : Form
    {
        public DatosPersonalesUsuario()
        {
            InitializeComponent();
            nuevaContra.GotFocus += new EventHandler(this.Enmascarar);
            RepitaContra.GotFocus += new EventHandler(this.Enmascarar);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DatosPersonalesUsuario_Load(object sender, EventArgs e)
        {
            username.Text = FrbaOfertas.Modelo.Usuario.username;
            contraseña.Text = FrbaOfertas.Modelo.Usuario.password;
            contraseña.PasswordChar = '*';
            nuevaContra.PasswordChar = '*';
            RepitaContra.PasswordChar = '*';
            nuevaContra.Visible = false;
            RepitaContra.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            button3.Visible = false;

            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id)) {
                if (listing.ToLower().Contains("admin")) { button4.Visible = true; break; }
            
            }

        }

        public void Enmascarar(object sender, EventArgs e)
        {
            TextBox tb_pass_confirm = (TextBox)sender;
            if (tb_pass_confirm.Text == "Falta completar campo")
            {
                tb_pass_confirm.Text = "";
                tb_pass_confirm.ForeColor = Color.Black;
                tb_pass_confirm.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked== true) contraseña.PasswordChar = '\0';
            if (checkBox1.Checked == false) contraseña.PasswordChar = '*';
        }

        private Boolean validarTodo() {
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();

            Boolean pass = true;
            if (validador.isEmpty(nuevaContra.Text))
            {
                validador.ErrorFaltaCompletarCampo(nuevaContra);
                nuevaContra.PasswordChar = '\0';
                pass = false;
            }
            if (validador.isEmpty(RepitaContra.Text))
            {
                validador.ErrorFaltaCompletarCampo(RepitaContra);
                RepitaContra.PasswordChar = '\0';
                pass = false;
            }
            if (nuevaContra.Text != RepitaContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                RepitaContra.Text = "";
                pass = false;
            }
            return pass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevaContra.Visible = true;
            RepitaContra.Visible = true;
            label1.Visible = true;
            label4.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.validarTodo()) {
                FrbaOfertas.ConectorDB.FuncionesUsername.updatearUsuario(FrbaOfertas.Modelo.Usuario.id, nuevaContra.Text, true, false);
                MessageBox.Show("Contraseña cambiada con exito", "Cambio Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevaContra.Visible = false;
                RepitaContra.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
                FrbaOfertas.Modelo.Usuario.password=nuevaContra.Text;
                contraseña.Text = nuevaContra.Text;
                nuevaContra.Text = "";
                RepitaContra.Text = "";
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
