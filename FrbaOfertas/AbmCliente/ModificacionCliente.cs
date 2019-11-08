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
    public partial class ModificacionCliente : Form
    {

        int id;
        string dni;
        string email;
        public ModificacionCliente(int idAModificar)
        {
            id = idAModificar;
            InitializeComponent();
            this.CenterToScreen();
            txt_nombre.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_apellido.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_calle.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_dni.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_dpto.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_localidad.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_mail.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_piso.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_tel.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
            txt_monto.GotFocus += new EventHandler(FrbaOfertas.Utils.Validador.BorrarMensajeDeError);
        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
