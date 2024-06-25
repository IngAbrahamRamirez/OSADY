using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public static class D_GestionLiquidacion_Contratos
    {
        public static int InsercionLiquidacion(string id_User,int id_empleado,int cod_contrato, string causa, int salario,int dias, int prima, int vacaciones, int cesantias, int int_cesantias, int icbf, int sena, int caja_compensacion, int pension, double salud, string observaciones, int indemnizacion,double Total_liquidacion)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlCommand Insercion_Liquidacion = new SqlCommand("insertar_Lcontrato", conexion);
            Insercion_Liquidacion.CommandType = CommandType.StoredProcedure;
            Insercion_Liquidacion.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_User;
            Insercion_Liquidacion.Parameters.Add("@id_empleado", SqlDbType.Int).Value = id_empleado;
            Insercion_Liquidacion.Parameters.Add("@id_contrato", SqlDbType.Int).Value = cod_contrato;
            Insercion_Liquidacion.Parameters.Add("@causa", SqlDbType.VarChar, 1000).Value =causa ;
            Insercion_Liquidacion.Parameters.Add("@salario", SqlDbType.BigInt).Value = salario;
            Insercion_Liquidacion.Parameters.Add("@dias_liquidar", SqlDbType.Int).Value = dias;
            Insercion_Liquidacion.Parameters.Add("@prima_servicios", SqlDbType.BigInt).Value = prima;
            Insercion_Liquidacion.Parameters.Add("@vacaciones", SqlDbType.BigInt).Value = vacaciones;
            Insercion_Liquidacion.Parameters.Add("@cesantias", SqlDbType.BigInt).Value = cesantias;
            Insercion_Liquidacion.Parameters.Add("@intereses_cesantias", SqlDbType.BigInt).Value = int_cesantias;
            Insercion_Liquidacion.Parameters.Add("@caja_compensacion", SqlDbType.Real).Value = caja_compensacion;
            Insercion_Liquidacion.Parameters.Add("@impuesto_ICBF", SqlDbType.Real).Value = icbf;
            Insercion_Liquidacion.Parameters.Add("@impuesto_SENA", SqlDbType.Real).Value = sena;
            Insercion_Liquidacion.Parameters.Add("@pension", SqlDbType.Real).Value = pension;
            Insercion_Liquidacion.Parameters.Add("@salud", SqlDbType.Real).Value = salud;
            Insercion_Liquidacion.Parameters.Add("@observaciones", SqlDbType.VarChar, 1000).Value = observaciones;
            Insercion_Liquidacion.Parameters.Add("@indemnizacion", SqlDbType.BigInt).Value = indemnizacion;
            Insercion_Liquidacion.Parameters.Add("@Total_liquidacion", SqlDbType.BigInt).Value = Total_liquidacion;
            Insercion_Liquidacion.Parameters.Add("@identificador", SqlDbType.Char,1).Value = 0;
            Insercion_Liquidacion.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static int Validar_Existencia(int cedula)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Consulta_previa_Liquidacion", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@Id_Contrato", SqlDbType.VarChar, 70).Value = cedula;
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
        public static DataTable ConsultaG_Liquidacion() 
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("consultaG_Lcontrato", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int ConsultaPrevia_Liquidacion(int cod_empleado)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Consulta_previa_Empleado", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = cod_empleado;
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
        public static DataTable TraerDatos_Cont(int Id_Emp)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("Traer_datos_Liquidacion", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@Cod_empleado", SqlDbType.Int).Value = Id_Emp;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Actualizar_Impuestos(int impuesto_ICBF, int impuesto_CajaC, int impuesto_Sena, int impuesto_Pension, double impuesto_salud)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion()); conexion.Open();
            SqlCommand Actualizacion_Impuestos = new SqlCommand("Actualizar_Impuestos", conexion);
            Actualizacion_Impuestos.CommandType = CommandType.StoredProcedure;
            Actualizacion_Impuestos.Parameters.Add("@identificador", SqlDbType.Real).Value = 1;
            Actualizacion_Impuestos.Parameters.Add("@caja_compensacion", SqlDbType.Real).Value = impuesto_CajaC;
            Actualizacion_Impuestos.Parameters.Add("@impuesto_ICBF", SqlDbType.Real).Value = impuesto_ICBF;
            Actualizacion_Impuestos.Parameters.Add("@impuesto_SENA", SqlDbType.Real).Value = impuesto_Sena;
            Actualizacion_Impuestos.Parameters.Add("@pension", SqlDbType.Real).Value = impuesto_Pension;
            Actualizacion_Impuestos.Parameters.Add("@salud", SqlDbType.Real).Value = impuesto_salud;
            Actualizacion_Impuestos.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static DataTable Consulta_Impuestos()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("Consulta_Impuestos", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable Consulta_Especifica_Liquidacion(int id_empleado)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consultaE_Lcontrato", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int).Value = id_empleado;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable Consulta_Fecha_Contrato(int id_empleado)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("Traer_Fecha_Contrato", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@cod_empleado", SqlDbType.Int).Value = id_empleado;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable Consulta_ID_COntrato(int id_empleado)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("TraerID_Contrato ", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int).Value = id_empleado;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable ConsultaID_Dotacion(int id_empleado)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("Consulta_ID_Dotacion", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int).Value = id_empleado;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable ConsultaDatos_Art(int id_dotacion)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("Traer_Datos_DetallesDotacion", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@id_dotacion", SqlDbType.Int).Value = id_dotacion;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Devolver_Articulos(string nombre_art, string cantidad_articulo)
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
        public static int Validar_Liquidacion(int cod_empleado)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Consulta_Existencia_Liquidacion", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@id_empleado", SqlDbType.Int).Value = cod_empleado;
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
