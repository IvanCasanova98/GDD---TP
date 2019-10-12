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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void cmd_darAlta_Click(object sender, EventArgs e)
        {
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            
            
            if (validador.isEmpty(txt_nombre.Text)) MessageBox.Show("Falta completar campo NOMBRE.");
            if (!validador.IsValidEmail(txt_mail.Text)) MessageBox.Show("Mail ingresado inválido.");
        }

     


       
    }
}
