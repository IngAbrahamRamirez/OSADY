using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Negocio
{
    public class N_GestionLiquidacion_Contratos
    {
        private int e_cod_empleado { get; set; }
        private int e_Id_Empleado { get; set; }
        private int e_id_contrato { get; set; }
        private int e_ID_Dotacion { get; set; }
        private string e_Causa { get; set; }
        private int e_Salario { get; set; }
        private int e_Salarios_adeudados { get; set; }
        private int e_Dias_Liquidar { get; set; }
        private int e_Prima_servicios { get; set; }
        private int e_Vacaciones { get; set; }
        private int e_Cesantias { get; set; }
        private int e_Intereses_Cesantias { get; set; }
        private int e_Caja_Compensacion { get; set; }
        private int e_Impuesto_Caja_Compensacion { get; set; }
        private int e_Impuesto_ICBF { get; set; }
        private int e_Impuesto_Sena { get; set; }
        private int e_Impuesto_Pension { get; set; }
        private double e_Impuesto_Salud { get; set; }
        private int e_ICBF { get; set; }
        private int e_Sena { get; set; }
        private int e_Pension { get; set; }
        private double e_Salud { get; set; }
        private int e_indemnizacion { get; set; }
        private string e_Observaciones { get; set; }
        private string e_nombre_art { get; set; }
        private string e_cantidad_art { get; set; }
        private int e_meses_Faltantes { get; set; }//No se envia
        public int Encapsulamiento_InsercionLiquidacionContrato(string id_User,int id_empleado,int cod_contrato, string causa, int salario, int dias,int Im_Caja_C, int icbf, int sena, int pension, double salud, string observaciones, int meses_Faltantes)
        {
        e_Id_Empleado=id_empleado;
        e_id_contrato = cod_contrato;
        e_Causa=causa; 
        e_Salario=salario;
        e_Dias_Liquidar=dias;
        e_Impuesto_Caja_Compensacion = Im_Caja_C;
        e_Impuesto_ICBF=icbf;
        e_Impuesto_Sena=sena;
        e_Impuesto_Pension=pension;
        e_Impuesto_Salud=salud;
        e_Observaciones = observaciones;
            e_meses_Faltantes = meses_Faltantes;
            //OPERACIONES LIQUIDACION DE CONTRATO

        //Liquidacion de las prestaciones sociales
        e_Prima_servicios = (e_Salario * 120) / 360;
        e_Vacaciones = (e_Salario * e_Dias_Liquidar) / 720;
        e_Cesantias = (e_Salario * e_Dias_Liquidar) / 360;
        e_Intereses_Cesantias = (e_Cesantias * ((e_Dias_Liquidar * 12) / 100)) / 360;

        //Liquidación de los aportes parafiscales
        e_Caja_Compensacion = (e_Salario * e_Impuesto_Caja_Compensacion)/100;
        e_ICBF = (e_Salario * e_Impuesto_ICBF) / 100;
        e_Sena = (e_Salario * e_Impuesto_Sena) / 100;

        //Liquidación de los aportes a seguridad social
        e_Pension = (e_Salario * e_Impuesto_Pension) / 100;
        e_Salud = (e_Salario * e_Impuesto_Salud) / 100;
            if(meses_Faltantes!=0){
                e_indemnizacion = (e_Salario * meses_Faltantes);
                double Total_liquidacion = e_Prima_servicios + e_Vacaciones + e_Cesantias + e_Intereses_Cesantias + e_Caja_Compensacion + e_ICBF + e_Sena + e_Pension + e_Salud + e_indemnizacion;
                return D_GestionLiquidacion_Contratos.InsercionLiquidacion(id_User,e_Id_Empleado,e_id_contrato, e_Causa, e_Salario,e_Dias_Liquidar, e_Prima_servicios, e_Vacaciones, e_Cesantias, e_Intereses_Cesantias, e_ICBF, e_Sena,e_Caja_Compensacion, e_Pension, e_Salud, e_Observaciones,e_indemnizacion,Total_liquidacion);
            }
            e_indemnizacion = 0;
            double Total_liquidacion1 = e_Prima_servicios + e_Vacaciones + e_Cesantias + e_Intereses_Cesantias + e_Caja_Compensacion + e_ICBF + e_Sena + e_Pension + e_Salud + e_indemnizacion;
            return D_GestionLiquidacion_Contratos.InsercionLiquidacion(id_User, e_Id_Empleado,e_id_contrato, e_Causa, e_Salario, e_Dias_Liquidar, e_Prima_servicios, e_Vacaciones, e_Cesantias, e_Intereses_Cesantias, e_ICBF, e_Sena, e_Caja_Compensacion, e_Pension, e_Salud, e_Observaciones, e_indemnizacion,Total_liquidacion1);
        }
        public int Verificar_registro(int id_empleado)
        {
            e_Id_Empleado = id_empleado;
            return D_GestionLiquidacion_Contratos.Validar_Existencia(e_Id_Empleado);
        }
        public DataTable Encampsulamiento_ConsultaG_Liquidacion()
        {
            return D_GestionLiquidacion_Contratos.ConsultaG_Liquidacion();
        }
        public int Encamsulamiento_ConsultaPrevia_Liquidacion(int cod_empleado)
        {
            e_cod_empleado = cod_empleado;
            return D_GestionLiquidacion_Contratos.ConsultaPrevia_Liquidacion(e_cod_empleado);
        }
        public DataTable Encapsulamiento_TraerDatos_Contrato(int Id_Emp)
        {
            e_cod_empleado = Id_Emp;
            return D_GestionLiquidacion_Contratos.TraerDatos_Cont(e_cod_empleado);
        }
        public int Encapsulamiento_Actualizar_Impuestos(int impuesto_ICBF, int impuesto_CajaC, int impuesto_Sena, int impuesto_Pension, double impuesto_salud)
        {
            e_Impuesto_ICBF = impuesto_ICBF;
            e_Impuesto_Caja_Compensacion = impuesto_CajaC;
            e_Impuesto_Sena = impuesto_Sena;
            e_Impuesto_Pension = impuesto_Pension;
            e_Impuesto_Salud = impuesto_salud;
            return D_GestionLiquidacion_Contratos.Actualizar_Impuestos(e_Impuesto_ICBF, e_Impuesto_Caja_Compensacion, e_Impuesto_Sena, e_Impuesto_Pension, e_Impuesto_Salud);
        }
        public DataTable Encampsulamiento_ConsultaImpuestos()
        {
            return D_GestionLiquidacion_Contratos.Consulta_Impuestos();
        }
        public DataTable EncapsulamientoCE_Liquidacion(int id_empleado)
        {
            e_Id_Empleado=id_empleado;
            return D_GestionLiquidacion_Contratos.Consulta_Especifica_Liquidacion(e_Id_Empleado);
        }
        public DataTable Encampsulamiento_ConsultaFecha_Contrato(int id_empleado)
        {
            e_Id_Empleado = id_empleado;
            return D_GestionLiquidacion_Contratos.Consulta_Fecha_Contrato(id_empleado);
        }
        public DataTable Encapuslamiento_ConsultaID_Contrato(int id_empleado)
        {
            e_Id_Empleado = id_empleado;
            return D_GestionLiquidacion_Contratos.Consulta_ID_COntrato(e_Id_Empleado);
        }
        public DataTable Consulta_IdDotacion(int id_empleado)
        {
            e_Id_Empleado = id_empleado;
            return D_GestionLiquidacion_Contratos.ConsultaID_Dotacion(e_Id_Empleado);
        }
        public DataTable Consulta_DatosArt(int ID_Dotacion)
        {
            e_ID_Dotacion = ID_Dotacion;
            return D_GestionLiquidacion_Contratos.ConsultaDatos_Art(e_ID_Dotacion);
        }
        public int Devolucion_Articulos(string nombre_art, string cantidad_art)
        {
            e_nombre_art = nombre_art;
            e_cantidad_art = cantidad_art;
            return D_GestionLiquidacion_Contratos.Devolver_Articulos(e_nombre_art, e_cantidad_art);
        }
        public int Verificar_Liquidacion(int cod_empleado)
        { 
            e_cod_empleado=cod_empleado;
            return D_GestionLiquidacion_Contratos.Validar_Liquidacion(e_cod_empleado);
        }
    }
}
