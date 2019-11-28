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

        public Boolean existeDNIenDB(String dni)
        {
            return FrbaOfertas.ConectorDB.FuncionesCliente.existeDNI(dni);
        }

        public Boolean existeMailenDB(String mail)
        {
            return FrbaOfertas.ConectorDB.FuncionesCliente.existeMail(mail);
        }
    
        public Boolean containsNumber(String palabra)
        {
            palabra = palabra.Trim();
            return palabra.Any(char.IsNumber);
        }

        public  Boolean isEmpty(String palabra)
        {
            //Estos son mensajes de error de no estar aca podrian crearse usuario con username = "El campo ya existe"
            if (palabra == "El campo ya existe" || palabra == "Falta completar campo" || palabra == "El Campo ingresado ya existe en la base de datos" || palabra == "El Rol ya existe"
               || palabra == "El Campo no debe contener numeros" || palabra == "El Campo no debe contener Letras" || palabra == "El Campo supera el rango maximo de caracteres" || palabra == "Usá el formato nombre@ejemplo.com" 
               || palabra == "El usuario ya existe")
            {
                return true;
            }
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

        public Boolean fechaAnteriorA(DateTime fechaUno, DateTime fechaDos)
        {
            return DateTime.Compare(fechaUno, fechaDos) > 0;
        }

        public void textoDeError(TextBox textbox, string texto) {
            textbox.Text = texto;
            textbox.ForeColor = Color.Red;
        }
        
        public void ErrorFaltaCompletarCampo(TextBox textbox)
        {
            textoDeError(textbox,"Falta completar campo");
        }
        public void ErrorCampoYaExisteEnLaBase(TextBox textbox)
        {
            textoDeError(textbox, "El Campo ingresado ya existe en la base de datos");
        }
        public void ErrornoContenerNumeros(TextBox textbox) {
            textoDeError(textbox, "El Campo no debe contener numeros");
        }
        public void ErrornoNumeroEnteroPositivo(TextBox textbox)
        {
            textoDeError(textbox, "El monto a cargar debe ser entero y positivo");
        }
        public void ErrorPrecioOfertaNoPuedeSerMayorOIgualQuePrecioLista(TextBox textbox)
        {
            textoDeError(textbox, "La Oferta debe ser menor o igual al precio de lista");
        }
        public void ErrornoContenerLetras(TextBox textbox)
        {
            textoDeError(textbox, "El Campo no debe contener Letras");
        }
        public void ErrorYaExisteRol(TextBox textbox)
        {
            textoDeError(textbox, "El Rol ya existe");
        }

        public void ErrorSuperaRango(TextBox textbox)
        {
            textoDeError(textbox, "El Campo supera el rango maximo de caracteres");
        }
        public void ErrorEmail(TextBox textbox)
        {
            textoDeError(textbox, "Usá el formato nombre@ejemplo.com");
        }
        public void ErrorCuitLongitud(TextBox textbox)
        {
            textoDeError(textbox, "Utilice el formato tipo-DNI-DigitoVerificador, 11 numeros");
        }
<<<<<<< HEAD
        public void ErrorTarjeta(TextBox textbox)
        {
            textoDeError(textbox, "Numero invalido de tarjeta (deben ser 16 caracteres)");
        }
=======
        public void ErrornoEsNumerico(TextBox textbox)
        {
            textoDeError(textbox, "Este campo debe ser un entero positivo");
        }

>>>>>>> 676423ebc6192cde26e48da2973bb25d596ebf16
        public static void  crearCajaDeError(string texto, string titulo)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //creo esta funcion ya que hay muchos campos que necesitan validar estas mismas propiedades (nombre, apellido, calle, etc)
        public Boolean validaCadenaCaracter(TextBox textbox, Boolean pass)
        {
            if (this.isEmpty(textbox.Text))
            {
                this.ErrorFaltaCompletarCampo(textbox);
                pass = false;
            }
            else if (this.containsNumber(textbox.Text))
            {
                this.ErrornoContenerNumeros(textbox);
                pass = false;
            }
            else if (this.fueraDeRango(textbox.Text, 0, 255))
            {
                this.ErrorSuperaRango(textbox);
                pass = false;
            }
            return pass;

        }
        public Boolean validacionDni(TextBox textboxDni, Boolean pass) {
            if (this.isEmpty(textboxDni.Text))
            {
                this.ErrorFaltaCompletarCampo(textboxDni);
                pass = false;
            }
            else if (!this.isNumeric(textboxDni.Text))
            {
                this.ErrornoContenerLetras(textboxDni);
                pass = false;
            }
            else if (this.fueraDeRango(textboxDni.Text, 8, 9))
            {
                this.ErrorSuperaRango(textboxDni);
                pass = false;
            }
            else if (this.existeDNIenDB(textboxDni.Text))
            {
                this.ErrorCampoYaExisteEnLaBase(textboxDni);
                pass = false;
            }
            return pass;
        
        }
        public Boolean validarCuit(TextBox TBcuit, Boolean pass)
        {
            string cuit = TBcuit.Text.Replace("-", string.Empty);
            if (this.isEmpty(TBcuit.Text))
            {
                this.ErrorFaltaCompletarCampo(TBcuit);
                pass = false;
            }
           
            else if (!this.isNumeric(TBcuit.Text))
            {
                this.ErrornoContenerLetras(TBcuit);
                pass = false;
            }
            else if (cuit.Length != 11)
            {
                 this.ErrorCuitLongitud(TBcuit);
                 pass = false;    
            }
            

            return pass;
        }
        public static void BorrarMensajeDeError(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "El campo ya existe" || textBox.Text == "Falta completar campo" || textBox.Text == "El Campo ingresado ya existe en la base de datos" || textBox.Text == "El Rol ya existe"
                || textBox.Text == "El Campo no debe contener numeros" || textBox.Text == "El Campo no debe contener Letras" || textBox.Text == "El Campo supera el rango maximo de caracteres" || textBox.Text == "Usá el formato nombre@ejemplo.com" || textBox.Text == "El credito a cargar debe ser entero y positivo")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }



        }

       }

