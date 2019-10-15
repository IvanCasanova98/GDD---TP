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
            
            //Validamos NOMBRE
            if (validador.isEmpty(txt_nombre.Text) || validador.isNumeric(txt_nombre.Text) || validador.fueraDeRango(txt_nombre.Text,0,255)) 
                MessageBox.Show("Error en campo NOMBRE.");
            else
            //Validamos APELLIDO
                if (validador.isEmpty(txt_apellido.Text) || validador.isNumeric(txt_apellido.Text) || validador.fueraDeRango(txt_apellido.Text, 0, 255)) 
                MessageBox.Show("Error en campo APELLIDO.");
            else
            //Validamos DNI
            if ( (!validador.isNumeric(txt_dni.Text)) || (validador.isNumeric(txt_dni.Text) && (txt_dni.Text.Length != 8)) || validador.isEmpty(txt_dni.Text)) 
                MessageBox.Show("Error en campo DNI.");
            else
            //Validamos CALLE
                if (validador.containsNumber(txt_calle.Text) || validador.isEmpty(txt_calle.Text) || validador.fueraDeRango(txt_calle.Text, 0, 255)) 
                MessageBox.Show("Error en campo CALLE.");
            else
            //Validamos PISO
            if ( (!validador.isNumeric(txt_piso.Text)) || ( (validador.isNumeric(txt_piso.Text)) && (txt_piso.Text.Length > 2)) || validador.isEmpty(txt_piso.Text)) 
                MessageBox.Show("Error en campo PISO.");
            else
            //Validamos DPTO
            if (validador.isEmpty(txt_dpto.Text)) 
                MessageBox.Show("Error en campo DPTO.");
            else
            //Validamos LOCALIDAD
            if (validador.containsNumber(txt_localidad.Text) || validador.isEmpty(txt_localidad.Text) || validador.fueraDeRango(txt_localidad.Text, 0, 255))
                MessageBox.Show("Error en campo LOCALIDAD.");
            else
            //Validamos TEL
            if ((!validador.isNumeric(txt_tel.Text)) || validador.isEmpty(txt_tel.Text) || validador.fueraDeRango(txt_tel.Text, 8, 15))
                MessageBox.Show("Error en campo TELEFONO.");
            //Validamos MAIL
            if (!validador.IsValidEmail(txt_mail.Text) || validador.isNumeric(txt_mail.Text)) 
                MessageBox.Show("Error en campo MAIL.");
            //Validamos CIUDAD
            if (validador.containsNumber(txt_ciudad.Text) || validador.isEmpty(txt_ciudad.Text) || validador.fueraDeRango(txt_ciudad.Text, 0, 255))
                MessageBox.Show("Error en campo CIUDAD.");
            else
              //Validamos EECHA NACIMIENTO
            if (validador.FechaFutura(dateTimePicker.Value))
                MessageBox.Show("Error en campo FECHA DE NACIMIENTO.");
        }


     


       
    }
}
