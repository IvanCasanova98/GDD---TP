using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class ListadoProveedor : Form
    {
        public ListadoProveedor()
        {
            InitializeComponent();
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_razonsocial.Text = "";
            txt_cuit.Text = "";
            txt_mail.Text = "";
            txt_razonsocial.Select();
        }
    }
}
