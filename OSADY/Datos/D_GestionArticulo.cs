using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class D_GestionArticulo
    {
        public static int Insertar_Articulo(string id_user,string nombre_a, string estado_a, string tipo_a, string cantidad_a, string descripcion_a)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Articulo = new SqlCommand("insertar_articulo", conexion);
            Insercion_Articulo.CommandType = CommandType.StoredProcedure;
            Insercion_Articulo.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_user;
            Insercion_Articulo.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre_a;
            Insercion_Articulo.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad_a;
            Insercion_Articulo.Parameters.Add("@tipo", SqlDbType.VarChar, 50).Value = tipo_a;
            Insercion_Articulo.Parameters.Add("@estado", SqlDbType.VarChar, 30).Value = estado_a;
            Insercion_Articulo.Parameters.Add("@descripcion", SqlDbType.VarChar, 500).Value = descripcion_a;
            Insercion_Articulo.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static DataTable ConsultaG_Articulo()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("consultaG_articulo", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable ConsultaE_Articulo(string Dato)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consultaE_articulo", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar, 100).Value = Dato;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;

        }
        public static int Actualizar_Articulo(string nombre_a,string estado_a, string descripcion_a)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Actualizacion_Usuario = new SqlCommand("actualiza_articulo", conexion);
            Actualizacion_Usuario.CommandType = CommandType.StoredProcedure;
            Actualizacion_Usuario.Parameters.Add("@nombre", SqlDbType.VarChar,100).Value = nombre_a;
            Actualizacion_Usuario.Parameters.Add("@estado", SqlDbType.VarChar, 30).Value = estado_a;
            Actualizacion_Usuario.Parameters.Add("@descripcion", SqlDbType.VarChar, 500).Value = descripcion_a;
            Actualizacion_Usuario.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static int Actualizar_Cantidad(string nombre_art,string cantidad_articulo)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Actualizacion_Cantidad = new SqlCommand("Actualizar_Cantidad_Art", conexion);
            Actualizacion_Cantidad.CommandType = CommandType.StoredProcedure;
            Actualizacion_Cantidad.Parameters.Add("@nombre_art", SqlDbType.VarChar, 100).Value = nombre_art;
            Actualizacion_Cantidad.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad_articulo;
            Actualizacion_Cantidad.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static int Validar_Articulo(string nombre_art)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_Validar_Art = new SqlCommand("Consulta_previa_Art", conexion);
            Consulta_Validar_Art.CommandType = CommandType.StoredProcedure;
            Consulta_Validar_Art.Parameters.Add("@Nombre_art", SqlDbType.VarChar, 50).Value = nombre_art;
            SqlDataReader Resultado = Consulta_Validar_Art.ExecuteReader();
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
    }
}
