using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Datos;


namespace Negocio
{
    public class N_GestionDotacion
    {
        private string e_cod_dotacion { get; set; }
        private int e_Cod_empleado { get; set; }
        private string e_Cod_articulo { get; set; }
        private string e_dato { get; set; }
        private string e_f_entrega { get; set; }
        private string e_t_renovacion { get; set; }
        private string e_observaciones { get; set; }
        private string e_nombre_art { get; set; }
        private string e_cantidad_articulo { get; set; }
        private int e_cantidad_restar { get; set; }
        private string e_fecha_hoy { get; set; }
        private string e_fecha_nueva { get; set; }

        public int Encapsulamiento_InsercionDotacion(string id_user, int cod_empleado, string fecha_entrega, string tiempo_renovacion, string observaciones)
        {
            e_Cod_empleado = cod_empleado;
            e_f_entrega = fecha_entrega;
            e_t_renovacion = tiempo_renovacion;
            e_observaciones = observaciones;

            return D_GestionDotacion.Insertar_Dotacion(id_user, cod_empleado, e_f_entrega, e_t_renovacion, e_observaciones);
        }
        public DataTable Encapsulamiento_ConsulttaGD()
        {
            return D_GestionDotacion.ConsultaG_Dotacion();
        }
        public DataTable Encapsulamiento_ConsultaE_Dotacion(string dato)
        {
            e_dato = dato;
            return D_GestionDotacion.ConsultaE_Dotacion(e_dato);
        }
        public int Encapsulamiento_ActualizarDotacion(string fecha_entrega, string observaciones)
        {
            e_f_entrega = fecha_entrega;
            e_observaciones = observaciones;
            return D_GestionDotacion.Actualizacion_Dotacion(e_f_entrega, e_observaciones);
        }
        public int Encamsulamiento_ConsultaPrevia_Dotacion(int cod_empleado)
        {
            e_Cod_empleado = cod_empleado;
            return D_GestionDotacion.ConsultaPrevia_Dotacion(e_Cod_empleado);
        }
        public DataTable Consulta_Articulos()
        {
            return D_GestionDotacion.consulta_Articulos();
        }
        public DataTable ConsultaID_art(string nombre_art)
        {
            e_nombre_art = nombre_art;
            return D_GestionDotacion.Consulta_Id_Articulo(e_nombre_art);
        }
        public int Encampsulamiento_Insercion_Detalles_Dotacion(string id_articulo, string cod_dotacion, string nombre_articulo, string candidad_articulo)
        {
            e_Cod_articulo = id_articulo;
            e_cod_dotacion = cod_dotacion;
            e_nombre_art = nombre_articulo;
            e_cantidad_articulo = candidad_articulo;
            return D_GestionDotacion.Insercion_Detalles_Dotacion(e_Cod_articulo, e_cod_dotacion, e_nombre_art, e_cantidad_articulo);
        }
        public DataTable Encampsulamiento_ConsultaID_Dotacion(int cod_empleado)
        {
            e_Cod_empleado = cod_empleado;
            return D_GestionDotacion.ConsultaID_Dotacion(e_Cod_empleado);
        }
        public DataTable Consulta_Cant_Articulo(string nombre_art)
        {
            e_nombre_art = nombre_art;
            return D_GestionDotacion.Consulta_cantidad_Articulo(nombre_art);
        }
        public int Operacion_Cantidad_Articulos(string nombre_art, int cantidad_restar)
        {
            e_nombre_art = nombre_art;
            e_cantidad_restar = cantidad_restar;
            return D_GestionDotacion.Actualizacion_Cantidad_Articulos(nombre_art, e_cantidad_restar);
        }
        public DataTable Traer_DatosconFecha(string fecha_hoy)
        {
            e_fecha_hoy=fecha_hoy;
            return D_GestionDotacion.Traer_Registros_Fecha(e_fecha_hoy);
        }
        public int Amplicacion_FechaRen(string cod_dotacion,string fecha_nueva)
        {
            e_cod_dotacion = cod_dotacion;
            e_fecha_nueva=fecha_nueva;
            return D_GestionDotacion.Ampliar_Fecha_Renovacion(e_cod_dotacion, e_fecha_nueva);
        }
        public int Verificacion_Contrato(int id_empleado)
        {
            e_Cod_empleado = id_empleado;
            return D_GestionDotacion.Verificar_Contrato(e_Cod_empleado);
        }
            
    }
}
