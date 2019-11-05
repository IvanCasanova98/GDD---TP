using FrbaOfertas.Modelo.AbmHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.ABMHandler
{
    class RolHandler : Handler
    {
        public override void darDeBaja(int id)
        {
            if ((MessageBox.Show(
            "Esta por dar de baja un rol. Todos los usuarios perderan acceso al mismo. ¿Desea Continuar?",
            "Baja Logica", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes))
            {
                FrbaOfertas.ConectorDB.FuncionesRol.BajaLogicaRol(id);
                MessageBox.Show("Rol dado de baja con exito", "ROL DADO DE BAJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

}
