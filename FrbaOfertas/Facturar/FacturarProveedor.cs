using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Facturar
{
    public partial class FacturarProveedor : Form
    {
        public FacturarProveedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Boolean validarDatos()
        {
            FrbaOfertas.Utils.Validador validador = new FrbaOfertas.Utils.Validador();
            Boolean pass = true;

            if (validador.fechaAnteriorA(dateTimeDesde.Value, dateTimeHasta.Value))
            {
                MessageBox.Show("La fecha DESDE debe ser anterior a la de HASTA");
                this.reiniciarDatos();
                pass = false;
            }

            return pass;

        }
        private void reiniciarDatos()
        {
            this.dateTimeDesde.Value = DateTime.Now;
            this.dateTimeHasta.Value = DateTime.Now;
        }

        private void cmd_avanzar_Click(object sender, EventArgs e)
        {
            if (this.validarDatos())
            {
                FrbaOfertas.Modelo.FechasFacturas fechas = new FrbaOfertas.Modelo.FechasFacturas();

                FrbaOfertas.Facturar.FacturarListaProveedores listaProveedores = new FrbaOfertas.Facturar.FacturarListaProveedores(fechas, new FrbaOfertas.Modelo.Listado.ListadoSeleccionFacturar()); 
                listaProveedores.ShowDialog(this);

            }
        }



    }
}
