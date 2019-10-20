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
    public partial class ListadoCliente : Form
    {
        public ListadoCliente()
        {
            InitializeComponent();
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_mail.Text = "";
            txt_nombre.Select();
        }

       
    


      
    }
}
