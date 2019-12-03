using FrbaOfertas.Modelo.AbmHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.ABMHandler
{
    class ClienteHandler : Handler
    {
         public override Boolean darDeBaja(int id)
        {
            if ((MessageBox.Show(
            "Esta por dar de baja un cliente. El usuario perderan acceso al mismo. ¿Desea Continuar?",
            "Baja Logica", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes))
            {
                FrbaOfertas.ConectorDB.FuncionesCliente.BajaLogicaCliente(id);


                MessageBox.Show("Cliente dado de baja con exito", "CLIENTE DADO DE BAJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;

        }
        public override void Modificar(int id)
        {
            FrbaOfertas.AbmCliente.ModificacionCliente dialog = new FrbaOfertas.AbmCliente.ModificacionCliente(id);
            dialog.ShowDialog();
        }

        public override void SetearUsuario(int identificador)
        {
            FrbaOfertas.ConectorDB.FuncionesCliente.LoguearUsuarioCliente(identificador);
        }
    }
 }

