using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.ConectorDB;
namespace FrbaOfertas.AbmRol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            foreach (String listing in FrbaOfertas.ConectorDB.FuncionesFuncion.ObtenerFuncionalidades())
            {
                comboBox1.Items.Add(listing);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listView1.Items.Add(comboBox1.SelectedItem.ToString());
            }
        }

    }
}
