using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Home
{
    public partial class SeleccionarRol : Form
    {
        public SeleccionarRol()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id))
            {
                comboBox1.Items.Add(listing);
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
            MessageBox.Show("El usuario se encuentra inhabilitado, comuniquese con un administrativo", "USUARIO INHABILITADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
