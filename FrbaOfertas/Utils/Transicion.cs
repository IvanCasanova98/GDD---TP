using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FrbaOfertas.Utils
{
    class Transicion
    {
        public static void transicionForms(Form viejo, Form nuevo)
        {
            viejo.Hide();
            nuevo.FormClosed += (s, args) => viejo.Close();
            nuevo.Show();
            nuevo.Focus();
        }
    }
}
