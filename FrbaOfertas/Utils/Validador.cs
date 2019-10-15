using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Utils
{
    class Validador
    {
        public Boolean containsNumber(String palabra)
        {
            palabra = palabra.Trim();
            return palabra.Any(char.IsNumber);
        }

        public Boolean isEmpty(String palabra)
        {
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

    }
}
