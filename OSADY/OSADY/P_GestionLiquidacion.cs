using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace OSADY
{
    public partial class P_GestionLiquidacion : Form
    {
        public P_GestionLiquidacion()
        {
            InitializeComponent();
        }
        public static string id_user;

        public void Registrado_por_Liquidacion(string id_usuario)
        {
            id_user = id_usuario;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl4.Visible = true;
            lbl11.Visible = true;
            lbl12.Visible = true;
            lbl13.Visible = true;
            lbl14.Visible = true;
            lbl15.Visible = true;
            lbl16.Visible = true;

            cmb1.Visible = true;
            txt1.Visible = true;
            txt3.Visible = true;
            txt10.Visible = true;
            txt11.Visible = true;
            txt12.Visible = true;
            txt13.Visible = true;
            txt14.Visible = true;
            txt15.Visible = true;

            btn1.Visible = true;
            btn3.Visible = false;
            dgv1.Visible = false;
            label4.Visible = true;
            textBox2.Visible = true;
            nud1.Visible = false;
            label3.Visible = false;
            label5.Visible = true;
            textBox3.Visible = true;
            btn5.Visible = true;

            lbl20.Visible = false;
            lbl21.Visible = false;
            lbl22.Visible = false;
            lbl23.Visible = false;
            lbl24.Visible = false;
            txt20.Visible = false;
            txt21.Visible = false;
            txt22.Visible = false;
            txt23.Visible = false;
            txt24.Visible = false;
            btn6.Visible = false;
            lbl90.Visible = true;
            label2.Visible = false;
            textBox1.Visible = false;
            label6.Visible = true;
            textBox4.Visible = true;
            label7.Visible = false;
            lblhora.Visible = true;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl4.Visible = false;
            lbl11.Visible = false;
            lbl12.Visible = false;
            lbl13.Visible = false;
            lbl14.Visible = false;
            lbl15.Visible = false;
            lbl16.Visible = false;

            cmb1.Visible = false;
            txt1.Visible = false;
            txt3.Visible = false;
            txt10.Visible = false;
            txt11.Visible = false;
            txt12.Visible = false;
            txt13.Visible = false;
            txt14.Visible = false;
            txt15.Visible = false;

            dgv1.Visible = true;

            btn1.Visible = false;
            btn3.Visible = true;
            label3.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            btn5.Visible = false;

            lbl20.Visible = false;
            lbl21.Visible = false;
            lbl22.Visible = false;
            lbl23.Visible = false;
            lbl24.Visible = false;
            txt20.Visible = false;
            txt21.Visible = false;
            txt22.Visible = false;
            txt23.Visible = false;
            txt24.Visible = false;
            btn6.Visible = false;
            label2.Visible=true;
            textBox1.Visible = true;
            label4.Visible = false;
            textBox2.Visible = false;
            lbl90.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            label7.Visible = false;
            lblhora.Visible = true;

            N_GestionLiquidacion_Contratos ConsultaG = new N_GestionLiquidacion_Contratos();
            DataTable matriz = new DataTable();
            matriz = ConsultaG.Encampsulamiento_ConsultaG_Liquidacion();
            dgv1.DataSource = matriz;
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            P_MenuGerenteAdministrativo MenuGerente = new P_MenuGerenteAdministrativo();
            MenuGerente.Show();
            this.Hide();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Notificacion de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                P_Login Salir = new P_Login();
                Salir.Show();
                this.Hide();
            }
            else
            {
                if (result == System.Windows.Forms.DialogResult.No)
                {

                }
            }
        }

        Reportes.DataSet2 Datos = new Reportes.DataSet2();

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || textBox2.Text == "" || cmb1.Text == "" || txt3.Text == "" || txt10.Text == "" || txt11.Text == "" || txt12.Text == "" || txt13.Text == "" || txt14.Text == "" || txt15.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                    else
                    {
                        int Id_Empleado = Convert.ToInt32(txt15.Text);
                        string Causa = cmb1.Text;
                        int cod_contrato = Convert.ToInt32(txt30.Text);
                        int Salario = Convert.ToInt32(txt1.Text);
                        int Dias_Liquidar = Convert.ToInt32(txt3.Text);
                        int Impuesto_caja_C = Convert.ToInt32(textBox2.Text);
                        int Impuesto_ICBF = Convert.ToInt32(txt10.Text);
                        int Impuesto_Sena = Convert.ToInt32(txt11.Text);
                        int Pension = Convert.ToInt32(txt12.Text);
                        double Salud = Convert.ToDouble(txt13.Text);
                        string Observaciones = txt14.Text;
                        N_GestionLiquidacion_Contratos Instancia_Insercion = new N_GestionLiquidacion_Contratos();
                        if (cmb1.Text == "Justificada")
                        {
                            int Meses_Faltantes1 = 0;
                            int res = Instancia_Insercion.Encapsulamiento_InsercionLiquidacionContrato(id_user, Id_Empleado,cod_contrato, Causa, Salario, Dias_Liquidar, Impuesto_caja_C, Impuesto_ICBF, Impuesto_Sena, Pension, Salud, Observaciones, Meses_Faltantes1);
                            if (res == 1)
                            {
                                MessageBox.Show("Registro de liquidación de contrato exitoso", "Creación de liquidación de contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                P_GestionLiquidacion Mostrar = new P_GestionLiquidacion();
                                Mostrar.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            int Meses_Faltantes = Convert.ToInt32(nud1.Value);
                            int res = Instancia_Insercion.Encapsulamiento_InsercionLiquidacionContrato(id_user, Id_Empleado,cod_contrato, Causa, Salario, Dias_Liquidar, Impuesto_caja_C, Impuesto_ICBF, Impuesto_Sena, Pension, Salud, Observaciones, Meses_Faltantes);
                            if (res == 1)
                            {
                                int Meses_Faltantes1 = Convert.ToInt32(nud1.Value);
                                MessageBox.Show("Registro de liquidación de contrato exitoso", "Creación de liquidación de contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                P_GestionLiquidacion Mostrar = new P_GestionLiquidacion();
                                Mostrar.Show();
                                this.Hide();
                            }
                        }
                //Genera la devolucion de los articulos de la dotacion del empleado
                        try
                        {
                            for (int cont = 0; cont < dataGridView2.Rows.Count; cont++)
                            {
                                string Nombre_Articulo = dataGridView2.Rows[cont].Cells[0].Value.ToString();
                                string Cantidad_Art = dataGridView2.Rows[cont].Cells[1].Value.ToString();
                                N_GestionLiquidacion_Contratos Actualizar_Cantidad = new N_GestionLiquidacion_Contratos();
                                Actualizar_Cantidad.Devolucion_Articulos(Nombre_Articulo, Cantidad_Art);
                            }
                        }
                        catch 
                        {
                        }
                        }
                       
                    
                

                //Reporte Liquidación de contrato

                int id_emp = Convert.ToInt32(txt15.Text);
                N_GestionLiquidacion_Contratos Consulta_Reporte = new N_GestionLiquidacion_Contratos();
                DataTable matriz = new DataTable();
                matriz = Consulta_Reporte.EncapsulamientoCE_Liquidacion(id_emp);
                dgv7.DataSource = matriz;

                Reportes.DataSet2.DataTable1Row file = Datos.DataTable1.NewDataTable1Row();
                file.Nombre_empleado = textBox4.Text;
                file.Tipo_contrato = textBox3.Text;
                file.Causa_liquidacion = cmb1.Text;
                file.Salario_empleado = txt1.Text;
                file.Dias_liquidar = txt3.Text;
                file.Observaciones = txt14.Text;
                Datos.DataTable1.Rows.Add(file);
                try
                {
                    Reportes.DataSet2.DataTable2Row fila = Datos.DataTable2.NewDataTable2Row();
                    fila.Prima_servicios = dgv7.Rows[0].Cells[7].Value.ToString();
                    fila.Vacaciones = dgv7.Rows[0].Cells[8].Value.ToString();
                    fila.Cesantias = dgv7.Rows[0].Cells[9].Value.ToString();
                    fila.Intereses_casantias = dgv7.Rows[0].Cells[10].Value.ToString();
                    fila.Caja_Compensacion = dgv7.Rows[0].Cells[11].Value.ToString();
                    fila.ICBF = dgv7.Rows[0].Cells[12].Value.ToString();
                    fila.SENA = dgv7.Rows[0].Cells[13].Value.ToString();
                    fila.Pension = dgv7.Rows[0].Cells[14].Value.ToString();
                    fila.Salud = dgv7.Rows[0].Cells[15].Value.ToString();
                    fila.Indemnizacion = dgv7.Rows[0].Cells[16].Value.ToString();
                    fila.Total_liquidación = dgv7.Rows[0].Cells[17].Value.ToString();
                    Datos.DataTable2.Rows.Add(fila);



                    Reportes.Form_Reporte_Liquidación Abrir_Reporte = new Reportes.Form_Reporte_Liquidación();
                    Abrir_Reporte.Nuevo = Datos;
                    Abrir_Reporte.Show();
                }
                catch
                { 
                }

            }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txt15.Text == "")
            {
                MessageBox.Show("El campo debe ser diligenciado, verifique por favor", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int cod_empleado1 = Convert.ToInt32(txt15.Text);
                N_GestionLiquidacion_Contratos InstanciaCP_L = new N_GestionLiquidacion_Contratos();
                int res_c1 = InstanciaCP_L.Verificar_Liquidacion(cod_empleado1);
                if (res_c1 == 1)
                {
                    MessageBox.Show("El empleado ya posee una liquidación de contrato, verifique sus datos", "Registro de liquidación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    int id_empleado = Convert.ToInt32(txt15.Text);
                    N_GestionLiquidacion_Contratos consultaFecha_C = new N_GestionLiquidacion_Contratos();
                    DataTable matriz_fecha = new DataTable();
                    matriz_fecha = consultaFecha_C.Encampsulamiento_ConsultaFecha_Contrato(id_empleado);
                    dgv4.DataSource = matriz_fecha;
                    //Calculo de dias a liquidar
                    try
                    {
                        DateTime fecha_contrato = Convert.ToDateTime(dgv4.Rows[0].Cells[0].Value.ToString());
                        DateTime fechaHoy = DateTime.Now;
                        TimeSpan ts = fechaHoy - fecha_contrato;
                        int differenceInDays = ts.Days;
                        System.Console.WriteLine("Difference in days: {0} ", differenceInDays);
                        System.Console.ReadLine();
                        txt3.Text = Convert.ToString(differenceInDays);
                    }
                    catch
                    {
                    }

                    //Trae los datos del contrato para su liquidación
                    int Id_empleado = Convert.ToInt32(txt15.Text);
                    N_GestionLiquidacion_Contratos consultaDatos_C = new N_GestionLiquidacion_Contratos();
                    DataTable matriz = new DataTable();
                    matriz = consultaDatos_C.Encapsulamiento_TraerDatos_Contrato(Id_empleado);
                    dgv2.DataSource = matriz;

                    //Trae el nombre del empleado
                    N_GestionContrato consultaDatos_E = new N_GestionContrato();
                    DataTable matriz_Nombre_e = new DataTable();
                    matriz_Nombre_e = consultaDatos_E.Encapsulamiento_TraerDatos_E(Id_empleado);
                    dgv4.DataSource = matriz_Nombre_e;

                    //Trae el id del contrato
                    try
                    {
                        N_GestionLiquidacion_Contratos ConsultaID_Contrato = new N_GestionLiquidacion_Contratos();
                        DataTable matriz_ID_C = new DataTable();
                        matriz_ID_C = ConsultaID_Contrato.Encapuslamiento_ConsultaID_Contrato(id_empleado);
                        dataGridView1.DataSource = matriz_ID_C;
                        txt30.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    }
                    catch
                    {
                    }

                    textBox4.Text = Convert.ToString(dgv4.Rows[0].Cells[0].Value);

                    //Verifica la existencia previa de un empelado en el sistema
                    int cod_empleado = Convert.ToInt32(txt15.Text);
                    N_GestionContrato Instancia_Verificar = new N_GestionContrato();
                    int res_c_em = Instancia_Verificar.Encamsulamiento_ConsultaPrevia_Contrato(cod_empleado);
                    if (res_c_em != 1)
                    {
                        MessageBox.Show("El empleado no existe, verifique sus datos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    textBox3.Text = Convert.ToString(dgv2.Rows[0].Cells[0].Value);
                    txt1.Text = Convert.ToString(dgv2.Rows[0].Cells[1].Value);
                    if (txt1.Text == "" && textBox3.Text == "")
                    {
                        MessageBox.Show("El empleado no posee contrato, verifique sus datos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Trae el nombre y cantidad de articulos de la dotacion del empleado
                    try
                    {
                        N_GestionLiquidacion_Contratos Consulta_ID_Dot = new N_GestionLiquidacion_Contratos();
                        DataTable matriz9 = new DataTable();
                        matriz9 = Consulta_ID_Dot.Consulta_IdDotacion(id_empleado);
                        dgv9.DataSource = matriz9;
                        int Cod_dotacion = Convert.ToInt32(dgv9.Rows[0].Cells[0].Value.ToString());

                        N_GestionLiquidacion_Contratos Consulta_Datos_Art = new N_GestionLiquidacion_Contratos();
                        DataTable matriz10 = new DataTable();
                        matriz10 = Consulta_Datos_Art.Consulta_DatosArt(Cod_dotacion);
                        dataGridView2.DataSource = matriz10;
                    }
                    catch
                    {
                    }
                }
            }
        }
            
        
        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl4.Visible = false;
            lbl11.Visible = false;
            lbl12.Visible = false;
            lbl13.Visible = false;
            lbl14.Visible = false;
            lbl15.Visible = false;
            lbl16.Visible = false;

            cmb1.Visible = false;
            txt1.Visible = false;
            txt3.Visible = false;
            txt10.Visible = false;
            txt11.Visible = false;
            txt12.Visible = false;
            txt13.Visible = false;
            txt14.Visible = false;
            txt15.Visible = false;

            dgv1.Visible = false;

            btn1.Visible = false;
            btn3.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            btn5.Visible = false;

            lbl20.Visible = true;
            lbl21.Visible = true;
            lbl22.Visible = true;
            lbl23.Visible = true;
            lbl24.Visible = true;
            txt20.Visible = true;
            txt21.Visible = true;
            txt22.Visible = true;
            txt23.Visible = true;
            txt24.Visible = true;
            btn6.Visible = true;
            lbl90.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            label7.Visible = true;
            lblhora.Visible = true;


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txt20.Text == "" || txt21.Text == "" || txt22.Text == "" || txt23.Text == "" || txt24.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                int impuesto_ICBF = Convert.ToInt32(txt20.Text);
                int impuesto_CajaC = Convert.ToInt32(txt21.Text);
                int impuesto_Sena = Convert.ToInt32(txt22.Text);
                int impuesto_Pension = Convert.ToInt32(txt23.Text);
                double impuesto_salud = Convert.ToDouble(txt24.Text);
                N_GestionLiquidacion_Contratos Actualizar_Impuestos = new N_GestionLiquidacion_Contratos();
                int r1 = Actualizar_Impuestos.Encapsulamiento_Actualizar_Impuestos(impuesto_ICBF, impuesto_CajaC, impuesto_Sena, impuesto_Pension, impuesto_salud);
                if (r1 == 1)
                {
                    MessageBox.Show("Actualización de impuestos exitosa", "Actualización de impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P_GestionLiquidacion Abrir = new P_GestionLiquidacion();
                    Abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Actualización de impuestos errónea", "Actualización de impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void P_GestionLiquidacion_Load(object sender, EventArgs e)
        {
            N_GestionLiquidacion_Contratos ConsultaImpuestos = new N_GestionLiquidacion_Contratos();
            DataTable matriz = new DataTable();
            matriz = ConsultaImpuestos.Encampsulamiento_ConsultaImpuestos();
            dgv3.DataSource = matriz;
            try
            {
                txt10.Text = dgv3.Rows[0].Cells[0].Value.ToString();
                textBox2.Text = dgv3.Rows[0].Cells[1].Value.ToString();
                txt11.Text = dgv3.Rows[0].Cells[2].Value.ToString();
                txt12.Text = dgv3.Rows[0].Cells[3].Value.ToString();
                txt13.Text = dgv3.Rows[0].Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.Text == "Justificada")
            {
                nud1.Visible = false;
                label3.Visible = false;
            }
            else
            {
                if (cmb1.Text == "No justificada")
                {
                    nud1.Visible = true;
                    label3.Visible = true;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("El campo debe ser diligenciado", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id_empleado = Convert.ToInt32(textBox1.Text);
                N_GestionLiquidacion_Contratos instaciarCE_Liq = new N_GestionLiquidacion_Contratos();
                DataTable matriz = new DataTable();
                matriz = instaciarCE_Liq.EncapsulamientoCE_Liquidacion(id_empleado);
                dgv1.DataSource = matriz;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Campo numérico");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
