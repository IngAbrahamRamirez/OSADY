using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    public class N_Login
    {
        private string e_usuario { get; set; }
        private string e_contrasena { get; set; }
        private string e_cargo { get; set; }

        public int Encapsulamiento_login(string usuario, string contrasena, string cargo)
        {

            e_usuario = usuario;
            e_contrasena = contrasena;
            e_cargo = cargo;



            return D_Login.Validar_Acceso(e_usuario, e_contrasena, e_cargo);
        }
        public DataTable Encasulamiento_Ingreso(string usuario)
        {
            e_usuario = usuario;
            return D_Login.ingreso(e_usuario);
        }

        public DataTable Encapsulamiento_Registrado_Por(string usuario)
        {
            e_usuario = usuario;
            return D_Login.Registrado_por(e_usuario);
        }
    }
}

 