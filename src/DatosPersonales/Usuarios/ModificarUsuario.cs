using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ESTE FORM SE ENCARGA DE HACER LAS MODIFICACIONES NECESARIAS A UN USUARIO SIENDO UN ADMINISTRATIVO

namespace FrbaOfertas.DatosPersonales.Usuarios
{
    public partial class ModificarUsuario : Form
    {
        string usuarioUpdate;
        public ModificarUsuario(string usuario)
        {
            usuarioUpdate = usuario;
            InitializeComponent();
            nuevaContra.GotFocus += new EventHandler(this.Enmascarar);
            RepitaContra.GotFocus += new EventHandler(this.Enmascarar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Visible = true;
            label4.Visible = true;
            nuevaContra.Visible = true;
            RepitaContra.Visible = true;

        }
        private Boolean validarTodo()
        {
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
        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            username.Text = usuarioUpdate;
            label1.Visible = false;
            label4.Visible = false;
            nuevaContra.Visible = false;
            RepitaContra.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrbaOfertas.ConectorDB.FuncionesUsername.BajaLogicaUsuario(FrbaOfertas.ConectorDB.FuncionesUsername.get_id(username.Text));
            MessageBox.Show("Usuario dado de baja con exito", "Baja Logica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrbaOfertas.ConectorDB.FuncionesUsername.desbloquearUsuario(FrbaOfertas.ConectorDB.FuncionesUsername.get_id(username.Text));
            MessageBox.Show("Usuario desbloqueado, ya puede loguearse", "Desbloqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.validarTodo())
            {
                FrbaOfertas.ConectorDB.FuncionesUsername.updatearUsuario(FrbaOfertas.ConectorDB.FuncionesUsername.get_id(username.Text), nuevaContra.Text, true, false);
                MessageBox.Show("Contraseña cambiada con exito", "Cambio Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevaContra.Visible = false;
                RepitaContra.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
                FrbaOfertas.Modelo.Usuario.password = nuevaContra.Text;
                nuevaContra.Text = "";
                RepitaContra.Text = "";

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

    }
}
