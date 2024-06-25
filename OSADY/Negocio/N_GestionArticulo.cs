using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    public class N_GestionArticulo
    {
        private string e_nombre_a { get; set; }
        private string e_estado_a { get; set; }
        private string e_tipo_a { get; set; }
        private string e_cantidad_a { get; set; }
        private string e_descripcion_a { get; set; }
        private string e_dato { get; set; }
        public int Encapsulamiento_InsercionArticulo(string id_user, string nombre_a, string estado_a, string tipo_a, string cantidad_a, string descripcion_a)
        {
            e_nombre_a = nombre_a;
            e_estado_a = estado_a;
            e_tipo_a = tipo_a;
            e_cantidad_a = cantidad_a;
            e_descripcion_a = descripcion_a;

            return D_GestionArticulo.Insertar_Articulo(id_user, nombre_a, e_estado_a, e_tipo_a, e_cantidad_a, e_descripcion_a);
        }
        public DataTable Encampsulamiento_ConsultaG_Articulo()
        {
            return D_GestionArticulo.ConsultaG_Articulo();
        }
        public DataTable Encapsulamiento_ConsultaE_Articulo(string dato)
        {
            e_dato = dato;
            return D_GestionArticulo.ConsultaE_Articulo(e_dato);
        }
        public int Encapsulamiento_ActualizacionArticulo(string nombre_a,string estado_a,string descripcion_a)
        {
            e_nombre_a = nombre_a;
            e_estado_a = estado_a;
            e_descripcion_a = descripcion_a;
            return D_GestionArticulo.Actualizar_Articulo(e_nombre_a, e_estado_a,e_descripcion_a);
        }
        public int Encapsulamiento_Actualizar_Cantidad(string nombre_art,string cantidad_articulo)
        {
            e_nombre_a = nombre_art;
            e_cantidad_a = cantidad_articulo;
            return D_GestionArticulo.Actualizar_Cantidad(e_nombre_a,e_cantidad_a);
        }
        public int Verificar_registro_Art(string nombre_art)
        {
            e_nombre_a = nombre_art;
            return D_GestionArticulo.Validar_Articulo(e_nombre_a);
        }
    }
}
