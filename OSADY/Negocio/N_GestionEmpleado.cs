using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class N_GestionEmpleado
    {

        private string e_id_empleado { get; set; }
        private string e_dato { get; set; }
        private string e_id_user { get; set; }
        private string e_nombre { get; set; }
        private string e_cedula { get; set; }
        private string e_area { get; set; }
        private string e_fecha_nac { get; set; }
        private string e_lugar_nac { get; set; }
        private string e_direccion { get; set; }
        private int e_telefono { get; set; }
        private string e_celular { get; set; }
        private string e_antecedentes { get; set; }
        private string e_correo { get; set; }
        private string e_profesion { get; set; }
        private string e_estado_civil { get; set; }
        private string e_anos_exp { get; set; }
        private string e_libreta_m { get; set; }
        private string e_vehiculo { get; set; }
        private string e_licencia { get; set; }
        private string e_categoria_lic { get; set; }
        private string e_tipo_vivienda { get; set; }
        private int e_num_dependientes { get; set; }
        private string e_perfil { get; set; }
        private string e_institucion { get; set; }
        private string e_tipo_titulo { get; set; }
        private string e_titulo { get; set; }
        private string e_fecha_titulo { get; set; }
        private string e_tipo_ref { get; set; }
        private string e_nombre_ref { get; set; }
        private string e_parentesco_ref { get; set; }
        private string e_correo_ref { get; set; }
        private string e_telefono_ref { get; set; }


        public int Encapsulamiento_InsercionEmpleado(string id_usuario, string nombre, string cedula, string area, string fecha_nacimiento, string lugar_nacimiento, string direccion, int telefono, string celular, string antecedentes, string correo, string profesion, string estado_civil, string anos_experiencia, string libreta_militar, string vehiculo, string licencia, string categoria_licencia, string tipo_vivienda, int numero_dependientes, string perfil_laboral)
        {
            e_id_user = id_usuario;
            e_nombre = nombre;
            e_cedula = cedula;
            e_area = area;
            e_fecha_nac = fecha_nacimiento;
            e_lugar_nac = lugar_nacimiento;
            e_direccion = direccion;
            e_telefono = telefono;
            e_celular = celular;
            e_antecedentes = antecedentes;
            e_correo = correo;
            e_profesion = profesion;
            e_estado_civil = estado_civil;
            e_anos_exp = anos_experiencia;
            e_libreta_m = libreta_militar;
            e_vehiculo = vehiculo;
            e_licencia = licencia;
            e_categoria_lic = categoria_licencia;
            e_tipo_vivienda = tipo_vivienda;
            e_num_dependientes = numero_dependientes;
            e_perfil = perfil_laboral;
            return D_GestionEmpleado.Insertar_Empleado(e_id_user, e_nombre, e_cedula, e_area, e_fecha_nac, e_lugar_nac, e_direccion, e_telefono, e_celular, e_antecedentes, e_correo, e_profesion, e_estado_civil, e_anos_exp, e_libreta_m, e_vehiculo, e_licencia, e_categoria_lic, e_tipo_vivienda, e_num_dependientes, e_perfil);
        }

        public DataTable Encapsulamiento_ConsultaGEmpleado()
        {
            return D_GestionEmpleado.ConsultaG_Empleado();
        }
        public int Encapsulamiento_ActualizacionEmpleado(string cedula, string area, string direccion, int telefono, string celular, string antecedentes, string correo, string profesion, string estado_civil, string anos_experiencia, string perfil_laboral, string tipo_vivienda, int num_dependientes)
        {
            e_cedula = cedula;
            e_area = area;
            e_direccion = direccion;
            e_telefono = telefono;
            e_celular = celular;
            e_antecedentes = antecedentes;
            e_correo = correo;
            e_profesion = profesion;
            e_estado_civil = estado_civil;
            e_anos_exp = anos_experiencia;
            e_perfil = perfil_laboral;
            e_tipo_vivienda = tipo_vivienda;
            e_num_dependientes = num_dependientes;
            return D_GestionEmpleado.Actualizacion_Empleado(e_cedula, e_area, e_direccion, e_telefono, e_celular, e_antecedentes, e_correo, e_profesion, e_estado_civil, e_anos_exp, e_perfil, e_tipo_vivienda, e_num_dependientes);
        }
        public DataTable Encapsulamiento_ConsultaE_Empleado(string dato)
        {
            e_dato = dato;
            return D_GestionEmpleado.ConsultaE_Empleado(e_dato);
        }
        public DataTable Instancia_IdEmpleado(string cc)
        {
            e_cedula = cc;
            return D_GestionEmpleado.Consulta_Id(e_cedula);
        }
        public DataTable Encapsulamiento_ConsultaID_Empleado(string CC)
        {
            e_cedula = CC;
            return D_GestionEmpleado.Consulta_Id(e_cedula);
        }
        public int Encapsulamiento_InsercionInfo_Aca(string id_empleado, string institucion, string tipo_t, string titulo, string fecha_titulo)
        {
            e_institucion = institucion;
            e_tipo_titulo = tipo_t;
            e_titulo = titulo;
            e_fecha_titulo = fecha_titulo;
            return D_GestionEmpleado.Insercion_Info_Aca(id_empleado, e_institucion, e_tipo_titulo, e_titulo, e_fecha_titulo);

        }
        public int Encapsulamiento_Insercion_Referencias(string id_empleado,string tipo_ref, string nombre_ref, string parentesco, string correo_ref, string telefono_ref)
        {
        e_id_empleado = id_empleado;
        e_tipo_ref=tipo_ref;
        e_nombre_ref =nombre_ref;
        e_parentesco_ref=parentesco;
        e_correo_ref = correo_ref;
        e_telefono_ref = telefono_ref;
        return D_GestionEmpleado.Insercion_Ref(e_id_empleado ,e_tipo_ref, e_nombre_ref, e_parentesco_ref, e_correo_ref, telefono_ref);
        }
        public int Verificar_registro(string cedula)
        {
            e_cedula = cedula;
            return D_GestionEmpleado.Validar_Empelado(e_cedula);
        }

    }
}
