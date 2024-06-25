using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    class D_Conexion
    {
        public static string CadenaConexion() 
        {
            string conexion = "Data source=(local);Initial Catalog=OSADY;Integrated Security=True";
            return conexion;
        }
    }
}
