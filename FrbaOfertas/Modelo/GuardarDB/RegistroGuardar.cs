using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Alta cuando un usuario su registro
namespace FrbaOfertas.Modelo.GuardarDB
{
    public class RegistroGuardar: StateGuardar
    {
        public override void Guardar(Rol RolAGuardar) {
            
            FrbaOfertas.ConectorDB.FuncionesUsername.GuardarUsuario(FrbaOfertas.Modelo.Usuario.username, FrbaOfertas.Modelo.Usuario.password);
            FrbaOfertas.ConectorDB.FuncionesUsername.insertarRolxUsuario(RolAGuardar.getName(), FrbaOfertas.Modelo.Usuario.username);
            RolAGuardar.Instertar();
            MessageBox.Show("Usuario registrado con exito, puede loguearse con los datos ingresados anteriormente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
