using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Modelo.GuardarDB
{
    public class AbmAltaGuardar : StateGuardar
    {
        public override void Guardar(Rol RolAGuardar)
        {

            FrbaOfertas.ConectorDB.FuncionesUsername.GuardarUsuario(RolAGuardar.getIdentificadorPrincipal(), RolAGuardar.getIdentificadorPrincipal()); //Hago que la contraseña de los nuevos usuarios sea dni dni
            RolAGuardar.Instertar();
            FrbaOfertas.ConectorDB.FuncionesUsername.insertarRolxUsuario(RolAGuardar.getName(), RolAGuardar.getIdentificadorPrincipal());
            MessageBox.Show("Cliente creado con exito. Para ingresar: usuario = " + RolAGuardar.getIdentificadorPrincipal() + " Password = " + RolAGuardar.getIdentificadorPrincipal(), "ABMCLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
