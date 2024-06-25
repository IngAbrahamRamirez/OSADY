using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocio
{
    public class N_GestionContrato
    {
        private string e_Dato { get; set; }
        private int e_Cod_Empleado { get; set; }
        private string e_Tipo_Contrato { get; set; }
        private string e_Nombre_Empleado { get; set; }
        private string e_CC_Empleado { get; set; }
        private string e_Duracion_Contrato { get; set; }
        private string e_Fecha_inicio { get; set; }
        private string e_Cargo_Empleado { get; set; }
        private string e_Salario { get; set; }
        private string e_Condiciones { get; set; }
        public int Encapsulamiento_InsercionContrato(string id_user, int Cod, string t_Contrato, string Nombre, string cc, string duracion, string fecha, string cargo, string salario, string condiciones)
        {
            e_Cod_Empleado = Cod;
            e_Tipo_Contrato = t_Contrato;
            e_Nombre_Empleado = Nombre;
            e_CC_Empleado = cc;
            e_Duracion_Contrato = duracion;
            e_Fecha_inicio = fecha;
            e_Cargo_Empleado = cargo;
            e_Salario = salario;
            e_Condiciones = condiciones;
            return D_GestionContratos.InsercionContrato(id_user, e_Cod_Empleado, e_Tipo_Contrato, e_Nombre_Empleado, e_CC_Empleado, e_Duracion_Contrato, e_Fecha_inicio, e_Cargo_Empleado, e_Salario, e_Condiciones);
        }
        public DataTable Encampsulamiento_ConsultaG_Contrato()
        {
            return D_GestionContratos.ConsultaG_Contrato();
        }
        public DataTable Encamsulamiento_ConsultaE_Contrato(string dato)
        {
            e_Dato = dato;
            return D_GestionContratos.ConsultaE_Contrato(e_Dato);
        }
        public int Encamsulamiento_ConsultaPrevia_Contrato(int cod_empleado)
        {
            e_Cod_Empleado = cod_empleado;
            return D_GestionContratos.ConsultaPrevia_Contrato(e_Cod_Empleado);
}
        public DataTable Encapsulamiento_TraerDatos_E(int Id_Emp) 
        {
            e_Cod_Empleado = Id_Emp;
            return D_GestionContratos.TraerDatos_E(e_Cod_Empleado);
        }
        public int Encapsulamiento_Validar_contrato(int id_empleado)
        {
            e_Cod_Empleado = id_empleado;
            return D_GestionContratos.Verificar_Contrato(e_Cod_Empleado);
        }
        //////CONSULTA POR CEDULA
        public int Encamsulamiento_ConsultaPrevia_Contrato1(string cedula_empleado)
        {
            e_CC_Empleado = cedula_empleado;
            return D_GestionContratos.ConsultaPrevia_Contrato1(e_CC_Empleado);
        }
        public DataTable Encapsulamiento_TraerDatos_E1(string Ced_Emp)
        {
            e_CC_Empleado = Ced_Emp;
            return D_GestionContratos.TraerDatos_E1(e_CC_Empleado);
        }
        public int Encapsulamiento_Validar_contrato1(string ced_empleado)
        {
            e_CC_Empleado = ced_empleado;
            return D_GestionContratos.Verificar_Contrato1(e_CC_Empleado);
        }
        public DataTable Consulta_Cod_E(string ced_empleado)
        {
            e_CC_Empleado = ced_empleado;
            return D_GestionContratos.Consulta_Cod_E(e_CC_Empleado);
        }
    }
}
