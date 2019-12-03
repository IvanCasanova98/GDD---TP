using FrbaOfertas.Modelo.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ComprarOferta
{
    public partial class CantidadOfe : Form
    {
        Compra compraNueva;
        public CantidadOfe(Compra compra)
        {
            InitializeComponent();
            compraNueva = compra;
            cantidad.Maximum = Int32.Parse(compraNueva.Compra_Cantidad_Max_X_Usuario);
        }

        private void CantidadOfe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((int)float.Parse(compraNueva.Compra_Monto_Disponible) >= cantidad.Value * (int)float.Parse(compraNueva.Compra_Precio))
            {
                compraNueva.Compra_cantidad = cantidad.Value.ToString();
                FrbaOfertas.ConectorDB.FuncionesCompra.AltaCompra(compraNueva);
                MessageBox.Show("Compra realizada con exito", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();


            }
            else MessageBox.Show("No tiene creditos suficientes. Cargue en Cargar Creditos", "Error Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
