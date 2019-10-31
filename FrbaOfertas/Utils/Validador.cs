using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
//Clase creada con el proposito de validar todos los campos que lo requieran tanto dentro de la app desktop (Nombres y apellidos sin numeros), como con la Base de datos (usuario unicos)

namespace FrbaOfertas.Utils
{
    class Validador
    {

        public  Boolean existeUsernameConDB(String username) {
            return FrbaOfertas.ConectorDB.FuncionesUsername.existeUsername(username);


        }
    
        public Boolean containsNumber(String palabra)
        {
            palabra = palabra.Trim();
            return palabra.Any(char.IsNumber);
        }

        public  Boolean isEmpty(String palabra)
        {
            if (palabra == "Falta completar campo") return false;
            if (palabra != "") { palabra = palabra.Trim(); }
            return palabra == "";
        }

        public Boolean isNumeric(String palabra)
        {
            palabra = palabra.Trim();
            return palabra.All(char.IsNumber);
        }

        public Boolean superaCantidadCaracteres(String palabra, int length)
        {
            palabra = palabra.Trim();
            return palabra.Length > length;
        }

        public Boolean fueraDeRango(String palabra, int inf, int sup)
        {
            palabra = palabra.Trim();
            return (palabra.Length > sup) || (palabra.Length < inf);
        }

        public Boolean IsValidEmail(String email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);

                return (addr.Address == email) && (email.Contains(".com"));
            }
            catch
            {
                return false;
            }
        }

        public Boolean FechaFutura(DateTime fechaDelDateTimePicker)
        {
            return DateTime.Compare(fechaDelDateTimePicker, DateTime.Now) > 0;
        }
        
        
        public void FaltaCompletarCampo(TextBox textbox)
        {
            textbox.Text = "Falta completar campo";
            textbox.ForeColor = Color.Red;
        }

        public static void  crearCajaDeError(string texto, string titulo)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

       }
}
