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
    public partial class MenuPrincial : Form
    {
        public MenuPrincial()
        {
            InitializeComponent();
        }
        
 

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuPrincial_Load(object sender, EventArgs e)
        {
                  
            label2.Text = "Bienvenido " + FrbaOfertas.Modelo.Usuario.username;
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id))
            {
                ListViewItem itemrol = new ListViewItem(listing);
                RolesView.Items.Add(itemrol);
            }

            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesUsername.ObtenerFuncionalidadesDeUnUsuario(FrbaOfertas.Modelo.Usuario.username))
            {
                ListViewItem itemrol = new ListViewItem(listing);
                listView1.Items.Add(itemrol);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        





    }
}
