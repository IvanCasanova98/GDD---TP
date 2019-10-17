using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Modelo;
using FrbaOfertas.Properties;
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
            Cliente cliente = new Cliente();
            //Validamos NOMBRE Clie_Nom
            if (validador.isEmpty(txt_nombre.Text) || validador.containsNumber(txt_nombre.Text) || validador.fueraDeRango(txt_nombre.Text,0,255)) 
                MessageBox.Show("Error en campo NOMBRE.");
            else
            //Validamos APELLIDO Clie_Apellido
                if (validador.isEmpty(txt_apellido.Text) || validador.containsNumber(txt_apellido.Text) || validador.fueraDeRango(txt_apellido.Text, 0, 255)) 
                MessageBox.Show("Error en campo APELLIDO.");
            else
            //Validamos DNI Clie_DNI
            if ((!validador.isNumeric(txt_dni.Text)) || (validador.isNumeric(txt_dni.Text) && (txt_dni.Text.Length < 8) || (txt_dni.Text.Length > 9)) || validador.isEmpty(txt_dni.Text)) 
                MessageBox.Show("Error en campo DNI.");
            else
             //Validamos CALLE Clie_Calle
            if (validador.containsNumber(txt_calle.Text) || validador.isEmpty(txt_calle.Text) || validador.fueraDeRango(txt_calle.Text, 0, 255)) 
                MessageBox.Show("Error en campo CALLE.");
            else
             //Validamos PISO Clie_Piso
            if ( (!validador.isNumeric(txt_piso.Text)) || ( (validador.isNumeric(txt_piso.Text)) && (txt_piso.Text.Length > 2)) || validador.isEmpty(txt_piso.Text)) 
                MessageBox.Show("Error en campo PISO.");
            else
             //Validamos DPTO Clie_Dpto
            if (validador.isEmpty(txt_dpto.Text) || validador.fueraDeRango(txt_dpto.Text,0,3)) 
                MessageBox.Show("Error en campo DPTO.");
            else
             //Validamos LOCALIDAD Clie_Localidad
            if (validador.containsNumber(txt_localidad.Text) || validador.isEmpty(txt_localidad.Text) || validador.fueraDeRango(txt_localidad.Text, 0, 255))
                MessageBox.Show("Error en campo LOCALIDAD.");
            else
            //Validamos TEL Clie_Tel
            if ((!validador.isNumeric(txt_tel.Text)) || validador.isEmpty(txt_tel.Text) || validador.fueraDeRango(txt_tel.Text, 8, 15))
                MessageBox.Show("Error en campo TELEFONO.");
            //Validamos MAIL Clie_Mail
            if (!validador.IsValidEmail(txt_mail.Text) || validador.isNumeric(txt_mail.Text) || validador.fueraDeRango(txt_mail.Text,0,255) ) 
                MessageBox.Show("Error en campo MAIL.");
            //Validamos CIUDAD Clie_Ciudad
            if (validador.containsNumber(txt_ciudad.Text) || validador.isEmpty(txt_ciudad.Text) || validador.fueraDeRango(txt_ciudad.Text, 0, 255))
                MessageBox.Show("Error en campo CIUDAD.");
            else
            //Validamos FECHA NACIMIENTO Clie_Fecha_Nac
            if (validador.FechaFutura(dateTimePicker.Value))
                MessageBox.Show("Error en campo FECHA DE NACIMIENTO.");
          
                
                
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


     


       
    }
}
