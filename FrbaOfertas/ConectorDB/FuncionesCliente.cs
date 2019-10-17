using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;


namespace FrbaOfertas.ConectorDB
{
    class FuncionesCliente
    {
        public static Boolean altaCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(Connection.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText = "INSERT INTO EL_REJUNTE.Cliente (clie_nombre, clie_apellido, clie_tipo_documento, clie_documento, clie_cuil, clie_email, clie_telefono, clie_direccion_id, clie_fecha_nacimiento, clie_fecha_creacion, clie_tarjeta_id, clie_habilitado, clie_usuario_id) " +
                                "VALUES ('" + cliente.nombre + "', '" + cliente.apellido + "', '" + cliente.tipo_documento + "', '" + cliente.documento + "', '" + cliente.cuil + "', '" + cliente.mail + "'," +
                                " '" + cliente.telefono + "'," + "(SELECT TOP 1 dire_id FROM EL_REJUNTE.Direccion WHERE dire_calle = '" + cliente.dire.calle + "' AND dire_numero = '" + cliente.dire.numero +
                                "' AND dire_piso = '" + cliente.dire.piso + "' AND dire_depto = '" + cliente.dire.depto + "' AND dire_localidad = '" + cliente.dire.localidad + "' AND dire_codigo_postal = '" +
                                cliente.dire.codigo_postal + "') , '" + cliente.fecha_nacimiento.ToString("yyyy-MM-dd HH:mm:ss") +
                                "', '" + VariablesGlobales.FechaHoraSistemaString + "' ," + "(SELECT TOP 1 tarj_id FROM EL_REJUNTE.Tarjeta WHERE tarj_numero = '" + cliente.tarjeta.numero + "' AND tarj_cod_seguridad = '" +
                                cliente.tarjeta.cod_seguridad + "' AND tarj_vencimiento = '" + cliente.tarjeta.vencimiento + "' AND tarj_titular = '" + cliente.tarjeta.titular + "' AND tarj_tipo = '" +
                                cliente.tarjeta.tipo + "')" + ", 1, (SELECT u.usuario_id FROM EL_REJUNTE.Usuario u WHERE u.usuario_username = '" + cliente.documento + "')" +
                                ")";
            comm.Connection = connection;
            comm.Connection.Open();
            int rows = comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
            return rows > 0;
        }

    }
}
