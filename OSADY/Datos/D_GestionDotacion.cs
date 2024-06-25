using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_GestionDotacion
    {
        public static int Insertar_Dotacion(string id_user, int cod_empleado, string fecha_entrega, string tiempo_renovacion, string observaciones)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Dotacion = new SqlCommand("insertar_dotacion", conexion);
            Insercion_Dotacion.CommandType = CommandType.StoredProcedure;
            Insercion_Dotacion.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_user;
            Insercion_Dotacion.Parameters.Add("@id_empleado", SqlDbType.Int).Value = cod_empleado;
            Insercion_Dotacion.Parameters.Add("@fecha_entrega", SqlDbType.Date).Value = fecha_entrega;
            Insercion_Dotacion.Parameters.Add("@tiempo_renovacion", SqlDbType.Date).Value = tiempo_renovacion;
            Insercion_Dotacion.Parameters.Add("@observaciones", SqlDbType.VarChar, 1000).Value = observaciones;
            Insercion_Dotacion.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static DataTable ConsultaG_Dotacion()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("consultaG_dotacion", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable ConsultaE_Dotacion(string Dato)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consultaE_dotacion", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar, 100).Value = Dato;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;

        }
        public static int Actualizacion_Dotacion(string id_dotacion, string observaciones)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Actualizacion_Dotacion = new SqlCommand("actualizar_dotacion", conexion);
            Actualizacion_Dotacion.CommandType = CommandType.StoredProcedure;
            Actualizacion_Dotacion.Parameters.Add("@id", SqlDbType.Int).Value = id_dotacion;
            Actualizacion_Dotacion.Parameters.Add("@observaciones", SqlDbType.VarChar, 1000).Value = observaciones;
            Actualizacion_Dotacion.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static int ConsultaPrevia_Dotacion(int cod_empleado)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Consulta_previa_Empleado", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@Id_Empleado", SqlDbType.VarChar, 70).Value = cod_empleado;
            SqlDataReader Resultado = Consulta_IngresoE.ExecuteReader();
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
        public static DataTable consulta_Articulos()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consulta1 = new SqlDataAdapter("Consultar_Articulos", conexion);
            consulta1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable datos1 = new DataTable();
            consulta1.Fill(datos1);
            return datos1;
        }
        public static DataTable Consulta_Id_Articulo(string nombre_art)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consultaID_Articulo", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@Nombre_art", SqlDbType.VarChar, 100).Value = nombre_art;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Insercion_Detalles_Dotacion(string id_articulo, string cod_dotacion, string nombre_articulo, string cantidad_articulo)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Dotacion = new SqlCommand("Insercion_Detalles_Dotacion", conexion);
            Insercion_Dotacion.CommandType = CommandType.StoredProcedure;
            Insercion_Dotacion.Parameters.Add("@id_articulo", SqlDbType.Int).Value = id_articulo;
            Insercion_Dotacion.Parameters.Add("@id_dotacion ", SqlDbType.Int).Value = cod_dotacion;
            Insercion_Dotacion.Parameters.Add("@Nombre_articulo", SqlDbType.VarChar, 100).Value = nombre_articulo;
            Insercion_Dotacion.Parameters.Add("@Cantidad ", SqlDbType.Int).Value = cantidad_articulo;
            Insercion_Dotacion.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static DataTable ConsultaID_Dotacion(int cod_empleado)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("ConsultaID_Dotacion", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@cod_empleado", SqlDbType.VarChar, 100).Value = cod_empleado;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable Consulta_cantidad_Articulo(string nombre_art)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("Consulta_Cantidad_Articulos", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@nombre_art", SqlDbType.VarChar, 50).Value = nombre_art;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Actualizacion_Cantidad_Articulos(string nombre_art,int cantidad_restar)
        {
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Cantidad_Articulo = new SqlCommand("Nueva_Cantidad_Art", conexion);
            Cantidad_Articulo.CommandType = CommandType.StoredProcedure;
            Cantidad_Articulo.Parameters.Add("@nombre_art", SqlDbType.VarChar,50).Value = nombre_art;
            Cantidad_Articulo.Parameters.Add("@cantidad_restar", SqlDbType.Int).Value = cantidad_restar;
            Cantidad_Articulo.ExecuteNonQuery();
            conexion.Close();
            int respuesta = 1;
            return respuesta;
        }
        public static DataTable Traer_Registros_Fecha(string fecha_hoy)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("Consulta_Registros_Renovar", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@Fecha_Hoy", SqlDbType.Date).Value = fecha_hoy;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Ampliar_Fecha_Renovacion(string cod_dotacion,string fecha_nueva)
        {
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Cantidad_Articulo = new SqlCommand("Ampliar_Fecha_Renovacion", conexion);
            Cantidad_Articulo.CommandType = CommandType.StoredProcedure;
            Cantidad_Articulo.Parameters.Add("@Cod_dotacion", SqlDbType.Int).Value = cod_dotacion;
            Cantidad_Articulo.Parameters.Add("@Nueva_Fecha", SqlDbType.Date).Value = fecha_nueva;
            Cantidad_Articulo.ExecuteNonQuery();
            conexion.Close();
            int respuesta = 1;
            return respuesta;
        }
        public static int Verificar_Contrato(int id_empleado)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("verificar_existenciaContrato", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@id_empleado", SqlDbType.Int).Value = id_empleado;
            SqlDataReader Resultado = Consulta_IngresoE.ExecuteReader();
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
