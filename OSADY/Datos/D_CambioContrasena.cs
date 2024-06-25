using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_CambioContrasena
    {
        public static int Cambio_Clave(string clave, string user)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Actualizar = new SqlCommand("Actualizacion_Contrasena", conexion);
            Actualizar.CommandType = CommandType.StoredProcedure;
            Actualizar.Parameters.Add("@usuario", SqlDbType.VarChar, 70).Value = user;
            Actualizar.Parameters.Add("@clave", SqlDbType.VarChar, 20).Value = clave;
            Actualizar.Parameters.Add("@Num_ingreso", SqlDbType.Char,1).Value = 1;
            Actualizar.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
    }
}
