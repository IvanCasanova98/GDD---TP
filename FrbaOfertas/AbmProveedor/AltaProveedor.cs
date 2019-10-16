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
    public partial class AltaProveedor : Form
    {
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void cmd_darAlta_Click(object sender, EventArgs e)
        {
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();

            //Validamos RAZÓN SOCIAL Provee_Rs
            if( validador.fueraDeRango(txt_razonsocial.Text,0,100) || validador.isEmpty(txt_razonsocial.Text) || validador.containsNumber(txt_razonsocial.Text))
                MessageBox.Show("Error en campo RAZÓN SOCIAL.");
            else
            //Validamos CALLE Provee_Calle
            if (validador.containsNumber(txt_calle.Text) || validador.isEmpty(txt_calle.Text) || validador.fueraDeRango(txt_calle.Text, 0, 255)) 
                MessageBox.Show("Error en campo CALLE.");
            else
             //Validamos PISO Provee_Piso
            if ( (!validador.isNumeric(txt_piso.Text)) || ( (validador.isNumeric(txt_piso.Text)) && (txt_piso.Text.Length > 2)) || validador.isEmpty(txt_piso.Text)) 
                MessageBox.Show("Error en campo PISO.");
            else
             //Validamos DPTO Provee_Dpto
            if (validador.isEmpty(txt_dpto.Text) || validador.fueraDeRango(txt_dpto.Text,0,3)) 
                MessageBox.Show("Error en campo DPTO.");
            else
             //Validamos LOCALIDAD Provee_Localidad
            if (validador.containsNumber(txt_localidad.Text) || validador.isEmpty(txt_localidad.Text) || validador.fueraDeRango(txt_localidad.Text, 0, 255))
                MessageBox.Show("Error en campo LOCALIDAD.");
            else
            //Validamos CIUDAD Provee_Ciudad
            if (validador.containsNumber(txt_ciudad.Text) || validador.isEmpty(txt_ciudad.Text) || validador.fueraDeRango(txt_ciudad.Text, 0, 255))
                MessageBox.Show("Error en campo CIUDAD.");
            //Validamos CÓDIGO POSTAL Provee_CodPostal
            if ((!validador.isNumeric(txt_codpostal.Text)) || (validador.isNumeric(txt_codpostal.Text) && (txt_codpostal.Text.Length != 4)) || validador.isEmpty(txt_codpostal.Text) || (txt_codpostal.Text.Length != 4))
                MessageBox.Show("Error en campo CÓDIGO POSTAL.");
            //Validamos MAIL Provee_Mail
            if (!validador.IsValidEmail(txt_mail.Text) || validador.isNumeric(txt_mail.Text) || validador.fueraDeRango(txt_mail.Text, 0, 255))
                MessageBox.Show("Error en campo MAIL.");
            //Validamos CUIT Provee_CUIT
            if ((!validador.isNumeric(txt_cuit.Text)) || ( (validador.isNumeric(txt_cuit.Text)) && ((txt_cuit.Text.Length != 11)) ) || validador.isEmpty(txt_cuit.Text) || (txt_cuit.Text.Length != 11) )
                MessageBox.Show("Error en campo CUIT.");
            //Validamos TEL Provee_Tel
            if ((!validador.isNumeric(txt_tel.Text)) || validador.isEmpty(txt_tel.Text) || validador.fueraDeRango(txt_tel.Text, 7, 15))
                MessageBox.Show("Error en campo TELEFONO.");
            else
            //Validamos RUBRO Provee_Rubro
            if( validador.containsNumber(txt_rubro.Text) || validador.isEmpty(txt_rubro.Text) ||  validador.fueraDeRango(txt_rubro.Text,0,20) )
                MessageBox.Show("Error en campo RUBRO.");
            else
            //Validamos NombreContacto Provee_NombreContacto
            if (validador.containsNumber(txt_nombreContacto.Text) || validador.isEmpty(txt_nombreContacto.Text) || validador.fueraDeRango(txt_nombreContacto.Text, 0, 100))
                MessageBox.Show("Error en campo NOMBRE CONTACTO.");
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
