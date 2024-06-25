using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Negocio
{
    public class N_GestionUsuario
    {
        private string e_usuario { get; set; }
        private string e_correo { get; set; }
        private string e_cargo { get; set; }
        private string e_cedula { get; set; }
        public int Encapsulamiento_InsercionUsuario( string usuario, string correo, string cedula,  string cargo)
        {
            e_usuario = usuario;
            e_correo = correo;
            e_cargo = cargo;
            e_cedula = cedula;
            return D_GestionUsuario.Insertar_Usuario(usuario, e_correo, e_cedula , e_cargo);
        }
        
        private string e_Dato { get; set; }
        public DataTable Encapsulamiento_ConsultaE_Usuario(string dato)
        {
            e_Dato = dato;
            return D_GestionUsuario.ConsultaE_Usuario(e_Dato);
        }
       
        
        public DataTable Encampsulamiento_ConsultaG_Usuario()
        {
            return D_GestionUsuario.ConsultaG_Usuario();
        }
        
        
        public int Encapsulamiento_ActualizacionUsuario(string cedula,string correo, string cargo)
        {
            e_cedula = cedula;
            e_correo = correo;
            e_cargo = cargo;
            return D_GestionUsuario.Actualizar_Usuario(e_cedula,e_correo, e_cargo);
        }

        public int Encapsulamiento_EliminacionUsuario(string usuario)
        {
            e_usuario = usuario;
            D_GestionUsuario Eliminar_u = new D_GestionUsuario();
            return D_GestionUsuario.Eliminar_Usuario(e_usuario);
        }
        public int Encapsulamiento_ActivacionUsuario(string usuario)
        {
            e_usuario = usuario;
            D_GestionUsuario Activar_u = new D_GestionUsuario();
            return D_GestionUsuario.Activar_Usuario(e_usuario);
        }
        public DataTable ConsultaG_Activar()
        {
            return D_GestionUsuario.Consulta_Activar_Usuario();
        }
    }
      
}

