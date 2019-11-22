using FrbaOfertas.Modelo.AbmHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.ABMHandler
{
    class ProveedorHandle : Handler
    {

            public override Boolean darDeBaja(int id)
            {
                if ((MessageBox.Show(
                "Esta por dar de baja un proveedor. El usuario perderan acceso al mismo. ¿Desea Continuar?",
                "Baja Logica", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    FrbaOfertas.ConectorDB.FuncionesCliente.BajaLogicaCliente(id);


                    MessageBox.Show("Proveedor dado de baja con exito", "PROVEEDOR DADO DE BAJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;

            }
            public override void Modificar(int id)
            {
                FrbaOfertas.AbmProveedor.ModificacionProveedor dialog = new FrbaOfertas.AbmProveedor.ModificacionProveedor(id);
                dialog.ShowDialog();
            }
        }
    }

