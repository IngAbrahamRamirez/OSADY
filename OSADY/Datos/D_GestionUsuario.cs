using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_GestionUsuario
    {
        public static int Insertar_Usuario(string usuario, string correo, string cedula, string cargo)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Usuario = new SqlCommand("Insertar_usuario", conexion);
            Insercion_Usuario.CommandType = CommandType.StoredProcedure;
            Insercion_Usuario.Parameters.Add("@usuario", SqlDbType.VarChar, 70).Value = usuario;
            Insercion_Usuario.Parameters.Add("@cc_usuario", SqlDbType.BigInt).Value = cedula;
            Insercion_Usuario.Parameters.Add("@correo", SqlDbType.VarChar, 70).Value = correo;
            Insercion_Usuario.Parameters.Add("@contrasena", SqlDbType.VarChar, 100).Value = cedula;
            Insercion_Usuario.Parameters.Add("@cargo_empleado", SqlDbType.VarChar, 70).Value = cargo;
            Insercion_Usuario.Parameters.Add("@estado", SqlDbType.Char, 1).Value = "a";
            Insercion_Usuario.Parameters.Add("@num_ingreso", SqlDbType.Char, 1).Value = 0;
            Insercion_Usuario.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static DataTable ConsultaE_Usuario(string Dato)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consultaE_U", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar,70).Value = Dato;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;

        }
        public static DataTable ConsultaG_Usuario()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("consultaG_U", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Actualizar_Usuario(string cedula,string correo, string cargo)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlCommand Actualizacion_Usuario = new SqlCommand("Actualizar_Usuario", conexion);
            Actualizacion_Usuario.CommandType = CommandType.StoredProcedure;
            Actualizacion_Usuario.Parameters.Add("@cc_usuario", SqlDbType.BigInt).Value = cedula;
            Actualizacion_Usuario.Parameters.Add("@correo", SqlDbType.VarChar,70).Value = correo;
            Actualizacion_Usuario.Parameters.Add("@cargo", SqlDbType.VarChar,70).Value = cargo;
            Actualizacion_Usuario.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }

        public static int Eliminar_Usuario(string usuario)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlCommand Eliminar_Usuario = new SqlCommand("Eliminar_U", conexion);
            Eliminar_Usuario.CommandType = CommandType.StoredProcedure;
            Eliminar_Usuario.Parameters.Add("@usuario", SqlDbType.VarChar, 70).Value = usuario;
            Eliminar_Usuario.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;

        }
        public static int Activar_Usuario(string usuario)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlCommand Activar_Usuario = new SqlCommand("Activar_U", conexion);
            Activar_Usuario.CommandType = CommandType.StoredProcedure;
            Activar_Usuario.Parameters.Add("@usuario", SqlDbType.VarChar, 70).Value = usuario;
            Activar_Usuario.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;

        }
        public static DataTable Consulta_Activar_Usuario()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("consultaG_U_Activar", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
    }
}
