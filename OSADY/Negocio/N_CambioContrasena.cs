using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Negocio
{
    public class N_CambioContrasena
    {
        private string e_claveN { get; set; }
        private string e_user { get; set; }
        public int Encapsulamiento_Clave(string clave, string usuario)
        {
            e_claveN = clave;
            e_user = usuario;
            return D_CambioContrasena.Cambio_Clave(e_claveN, e_user);
                
        }
    }
}
