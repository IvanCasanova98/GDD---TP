using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.RegistroUsuario
{
    public partial class RegistroUsr : Form
    {
        public RegistroUsr()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {

        }

        private Boolean validarDatos()
        {
            // if(Usuario no existe en la base de datos)
            // if(tbpass no es vacío, y tbpass_confirm no es vacìo, y tbpass = tbpass_confirm)
            // if(rol no esta vacío)
            return true;
        }

        private void cmd_sgte_Click(object sender, EventArgs e)
        {
            if (this.validarDatos())
            {
                switch(cbo_rol.Text)
                {
                    case "Cliente":
                        FrbaOfertas.AbmCliente.AltaCliente dialogCliente = new FrbaOfertas.AbmCliente.AltaCliente();
                        dialogCliente.ShowDialog(this);
                        break;
                    case "Proveedor":
                        FrbaOfertas.AbmProveedor.AltaProveedor dialogProveedor = new FrbaOfertas.AbmProveedor.AltaProveedor();
                        dialogProveedor.ShowDialog(this);
                        break;
                    case "Administrador":
                        MessageBox.Show("No puede ser administrador.");
                        break;

                }

            }
        }


    
    }
}
