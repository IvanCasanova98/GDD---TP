using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CrearOferta
{
    public partial class CrearOfertaAdministrador : Form
    {
        public CrearOfertaAdministrador()
        {
            InitializeComponent();
        }

        private void CrearOfertaAdministrador_Load(object sender, EventArgs e)
        {
            List<String> lstProveedores = FrbaOfertas.ConectorDB.ObtenerTodosLosProveedores.getListaProveedores();
            for (int i = 0; i <= lstProveedores.Count; i++)
            {
                cboProveedores.Items.Add(i);
            }
        }
    }
}
