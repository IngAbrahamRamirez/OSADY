using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class D_Login
    {
        public static int Validar_Acceso(string usuario, string contrasena, string cargo)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlCommand Consulta_Login = new SqlCommand("Acceso_Usuario", conexion);
            Consulta_Login.CommandType = CommandType.StoredProcedure;
            Consulta_Login.Parameters.Add("@Usuario", SqlDbType.VarChar, 70).Value = usuario;
            Consulta_Login.Parameters.Add("@contrasena", SqlDbType.VarChar, 100).Value = contrasena;
            Consulta_Login.Parameters.Add("@cargo_empleado", SqlDbType.VarChar, 70).Value = cargo;
            SqlDataReader Resultado = Consulta_Login.ExecuteReader();
            if (Resultado.Read() == true)
            {
                respuesta = 1;
            }
            else
            {
                respuesta = 0;
            }
            conexion.Close();
            return respuesta;
        }
        public static DataTable ingreso(string usuario)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlDataAdapter Consulta_Ingreso = new SqlDataAdapter("Consulta_N_Ingreso", conexion);
            Consulta_Ingreso.SelectCommand.CommandType = CommandType.StoredProcedure;
            Consulta_Ingreso.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 70).Value = usuario;
            Consulta_Ingreso.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable Registrado_por(string usuario)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlDataAdapter Consulta_Ingreso = new SqlDataAdapter("Consulta_Registrado_Por", conexion);
            Consulta_Ingreso.SelectCommand.CommandType = CommandType.StoredProcedure;
            Consulta_Ingreso.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 70).Value = usuario;
            Consulta_Ingreso.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
    }
}

