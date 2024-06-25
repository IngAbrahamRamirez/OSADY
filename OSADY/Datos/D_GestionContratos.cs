using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_GestionContratos
    {
        public static int InsercionContrato(string id_user, int Cod, string t_Contrato, string Nombre, string cc, string duracion, string fecha, string cargo, string salario, string condiciones)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Contrato = new SqlCommand("Insertar_contrato", conexion);
            Insercion_Contrato.CommandType = CommandType.StoredProcedure;
            Insercion_Contrato.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_user;
            Insercion_Contrato.Parameters.Add("@id_empleado", SqlDbType.Int).Value = Cod;
            Insercion_Contrato.Parameters.Add("@Tipo_contrato", SqlDbType.VarChar, 100).Value = t_Contrato;
            Insercion_Contrato.Parameters.Add("@nombre_empleado", SqlDbType.VarChar, 100).Value = Nombre;
            Insercion_Contrato.Parameters.Add("@cc", SqlDbType.BigInt).Value = cc;
            Insercion_Contrato.Parameters.Add("@duracion_contrato", SqlDbType.VarChar, 50).Value = duracion;
            Insercion_Contrato.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fecha;
            Insercion_Contrato.Parameters.Add("@cargo_empleado", SqlDbType.VarChar, 100).Value = cargo;
            Insercion_Contrato.Parameters.Add("@salario", SqlDbType.BigInt).Value = salario;
            Insercion_Contrato.Parameters.Add("@condiciones", SqlDbType.VarChar, 1000).Value = condiciones;
            Insercion_Contrato.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static DataTable ConsultaG_Contrato()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("consultaG_C", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable ConsultaE_Contrato(string Dato)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consultaE_C", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar, 100).Value = Dato;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;

        }
        public static int ConsultaPrevia_Contrato(int cod_empleado)
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
        public static DataTable TraerDatos_E(int Id_Emp)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("Traer_Datos_E", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@id_Empleado", SqlDbType.Int).Value = Id_Emp;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Verificar_Contrato(int cod_empleado)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Verificar_contrato", conexion);
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

        //////////// CONSULTA POR CEDULA
         
        public static int ConsultaPrevia_Contrato1(string cedula_empleado)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Consulta_previa", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = cedula_empleado;
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
        public static DataTable TraerDatos_E1(string Ced_Emp)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("TraerDatosEmpleado_Contrato", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = Ced_Emp;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Verificar_Contrato1(string cod_empleado)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Verificar_contrato_Cedula", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = cod_empleado;
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
        public static DataTable Consulta_Cod_E(string ced_empleado)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("ConsultaID_Empleado", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@cc", SqlDbType.BigInt).Value = ced_empleado;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
    }
}
