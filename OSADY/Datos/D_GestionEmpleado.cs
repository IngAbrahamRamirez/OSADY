using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_GestionEmpleado
    {
        public static int Insertar_Empleado(string id_usuario, string nombre, string cedula, string area, string fecha_nacimiento, string lugar_nacimiento, string direccion, int telefono, string celular, string antecedentes, string correo, string profesion, string estado_civil, string anos_experiencia, string libreta_militar, string vehiculo, string licencia, string categoria_licencia, string tipo_vivienda, int numero_dependientes, string perfil_laboral)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Empleado = new SqlCommand("Insertar_empleado", conexion);
            Insercion_Empleado.CommandType = CommandType.StoredProcedure;
            Insercion_Empleado.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario;
            Insercion_Empleado.Parameters.Add("@nombre_completo", SqlDbType.VarChar, 100).Value = nombre;
            Insercion_Empleado.Parameters.Add("@cc", SqlDbType.BigInt).Value = cedula;
            Insercion_Empleado.Parameters.Add("@area", SqlDbType.VarChar, 50).Value = area;
            Insercion_Empleado.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = fecha_nacimiento;
            Insercion_Empleado.Parameters.Add("@lugar_nacimiento", SqlDbType.VarChar, 100).Value = lugar_nacimiento;
            Insercion_Empleado.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = direccion;
            Insercion_Empleado.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            Insercion_Empleado.Parameters.Add("@celular", SqlDbType.BigInt).Value = celular;
            Insercion_Empleado.Parameters.Add("@antecedentes", SqlDbType.Char, 2).Value = antecedentes;
            Insercion_Empleado.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = correo;
            Insercion_Empleado.Parameters.Add("@profesion", SqlDbType.VarChar, 100).Value = profesion;
            Insercion_Empleado.Parameters.Add("@estado_civil", SqlDbType.VarChar, 50).Value = estado_civil;
            Insercion_Empleado.Parameters.Add("@anos_experiencia", SqlDbType.Int).Value = anos_experiencia;
            Insercion_Empleado.Parameters.Add("@libreta_militar", SqlDbType.VarChar, 50).Value = libreta_militar;
            Insercion_Empleado.Parameters.Add("@vehiculo", SqlDbType.Char, 2).Value = vehiculo;
            Insercion_Empleado.Parameters.Add("@numero_licencia", SqlDbType.VarChar, 50).Value = licencia;
            Insercion_Empleado.Parameters.Add("@categoria_licencia", SqlDbType.Char, 2).Value = categoria_licencia;
            Insercion_Empleado.Parameters.Add("@tipo_vivienda", SqlDbType.VarChar, 20).Value = tipo_vivienda;
            Insercion_Empleado.Parameters.Add("@numero_dependientes", SqlDbType.Int).Value = numero_dependientes;
            Insercion_Empleado.Parameters.Add("@perfil_laboral", SqlDbType.VarChar, 500).Value = perfil_laboral;
            Insercion_Empleado.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }

        public static DataTable ConsultaG_Empleado()
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("consultaG_E", conexion);
            consulta.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Actualizacion_Empleado(string cedula, string area, string direccion, int telefono, string celular, string antecedentes, string correo, string profesion, string estado_civil, string anos_experiencia, string perfil_laboral, string tipo_vivienda, int num_dependientes)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Actualizar_Empleado = new SqlCommand("actualizar_empleado", conexion);
            Actualizar_Empleado.CommandType = CommandType.StoredProcedure;
            Actualizar_Empleado.Parameters.Add("@cc_empleado", SqlDbType.BigInt).Value = cedula;
            Actualizar_Empleado.Parameters.Add("@area", SqlDbType.VarChar, 50).Value = area;
            Actualizar_Empleado.Parameters.Add("@direccion", SqlDbType.VarChar, 10).Value = direccion;
            Actualizar_Empleado.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            Actualizar_Empleado.Parameters.Add("@celular", SqlDbType.BigInt).Value = celular;
            Actualizar_Empleado.Parameters.Add("@antecedentes", SqlDbType.Char, 2).Value = antecedentes;
            Actualizar_Empleado.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = correo;
            Actualizar_Empleado.Parameters.Add("@profesion", SqlDbType.VarChar, 100).Value = profesion;
            Actualizar_Empleado.Parameters.Add("@estado_civil", SqlDbType.VarChar, 50).Value = estado_civil;
            Actualizar_Empleado.Parameters.Add("@anos_experiencia", SqlDbType.Int).Value = anos_experiencia;
            Actualizar_Empleado.Parameters.Add("@tipo_vivienda", SqlDbType.VarChar, 20).Value = tipo_vivienda;
            Actualizar_Empleado.Parameters.Add("@perfil_laboral", SqlDbType.VarChar, 500).Value = perfil_laboral;
            Actualizar_Empleado.Parameters.Add("@numero_dependientes", SqlDbType.Int).Value = num_dependientes;
            Actualizar_Empleado.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static DataTable ConsultaE_Empleado(string Dato)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consultaE_E", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar, 70).Value = Dato;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static DataTable Consulta_Id(string cc)
        {
            DataTable ConjuntoDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlDataAdapter consultaE = new SqlDataAdapter("consulta_Id_E", conexion);
            consultaE.SelectCommand.CommandType = CommandType.StoredProcedure;
            consultaE.SelectCommand.Parameters.Add("@cc", SqlDbType.BigInt).Value = cc;
            consultaE.Fill(ConjuntoDatos);
            conexion.Close();
            return ConjuntoDatos;
        }
        public static int Insercion_Info_Aca(string id_empleado, string institucion, string tipo_t, string titulo, string fecha_titulo)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Iacademica = new SqlCommand("insertar_Iacademica", conexion);
            Insercion_Iacademica.CommandType = CommandType.StoredProcedure;
            Insercion_Iacademica.Parameters.Add("@id_empleado", SqlDbType.BigInt).Value = id_empleado;
            Insercion_Iacademica.Parameters.Add("@institucion", SqlDbType.VarChar, 50).Value = institucion;
            Insercion_Iacademica.Parameters.Add("@tipo_titulacion", SqlDbType.VarChar, 50).Value = tipo_t;
            Insercion_Iacademica.Parameters.Add("@titulo", SqlDbType.VarChar, 50).Value = titulo;
            Insercion_Iacademica.Parameters.Add("@fecha_titulacion", SqlDbType.Date).Value = fecha_titulo;
            Insercion_Iacademica.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static int Insercion_Ref(string id_empleado, string tipo_ref, string nombre_ref, string parentesco_ref, string correo_ref, string tel_ref)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Insercion_Referencias = new SqlCommand("insertar_referencias", conexion);
            Insercion_Referencias.CommandType = CommandType.StoredProcedure;
            Insercion_Referencias.Parameters.Add("@id_empleado", SqlDbType.Int).Value = id_empleado;
            Insercion_Referencias.Parameters.Add("@tipo", SqlDbType.Char, 2).Value = tipo_ref;
            Insercion_Referencias.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre_ref;
            Insercion_Referencias.Parameters.Add("@parentesco", SqlDbType.VarChar, 50).Value = parentesco_ref;
            Insercion_Referencias.Parameters.Add("@telefono", SqlDbType.BigInt).Value = tel_ref;
            Insercion_Referencias.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = correo_ref;
            Insercion_Referencias.ExecuteNonQuery();
            conexion.Close();
            respuesta = 1;
            return respuesta;
        }
        public static int Validar_Empelado(string cedula)
        {
            int respuesta;
            SqlConnection conexion = new SqlConnection(D_Conexion.CadenaConexion());
            conexion.Open();
            SqlCommand Consulta_IngresoE = new SqlCommand("Consulta_previa", conexion);
            Consulta_IngresoE.CommandType = CommandType.StoredProcedure;
            Consulta_IngresoE.Parameters.Add("@Cedula", SqlDbType.VarChar, 70).Value = cedula;
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
