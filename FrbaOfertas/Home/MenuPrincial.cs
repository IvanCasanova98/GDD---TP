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
            
             //Itero por la lista de funciones y voy "activando los botones del menu en caso de que coincidan"
                
            
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    List<String> Funciones = FrbaOfertas.ConectorDB.FuncionesUsername.ObtenerFuncionalidadesDeUnUsuario(FrbaOfertas.Modelo.Usuario.username);    
                    if (Funciones.Contains(item.Text.ToUpper()))
                    {
                        item.Visible = true;
                    }

                    foreach (ToolStripDropDownItem rol in modificiarDatosPersonalesToolStripMenuItem.DropDownItems)
                    {
                        List<String> roles = FrbaOfertas.ConectorDB.FuncionesRol.ObtenerRolesDeUnUsuario(FrbaOfertas.Modelo.Usuario.id);
                        if (roles.Contains(rol.Text))
                        {
                            rol.Visible = true;
                        }
                    }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ABMDEROL_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        





    }
}
