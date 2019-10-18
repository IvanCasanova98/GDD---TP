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
    public partial class ModificacionProveedor : Form
    {
        public ModificacionProveedor()
        {
            InitializeComponent();
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_razonsocial.Text = "";
            txt_codpostal.Text = "";
            txt_cuit.Text = "";
            txt_calle.Text = "";
            txt_piso.Text = "";
            txt_dpto.Text = "";
            txt_localidad.Text = "";
            txt_tel.Text = "";
            txt_mail.Text = "";
            txt_ciudad.Text = "";
            txt_rubro.Text = "";
            txt_nombreContacto.Text = "";

            txt_razonsocial.Select();
        }
    }
}
