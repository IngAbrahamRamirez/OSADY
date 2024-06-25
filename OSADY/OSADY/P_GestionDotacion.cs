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
    public partial class P_GestionDotacion : Form
    {
        public P_GestionDotacion()
        {
            InitializeComponent();
        }
        public static string id_user;

        public void Registrado_por_Dotacion(string id_usuario)
        {
            id_user = id_usuario;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dgv2.Visible = true;
            lbl5.Visible = true;
            btn5.Visible = true;
            cmb1.Visible = true;
            nud1.Visible = true;
            txt2.Visible = true;
            label3.Visible = true;
            label2.Visible = false;
            txt6.Visible = false;
            rdb1.Visible = false;
            rdb2.Visible = false;
            btn4.Visible = true;


            dtp1.Enabled = false;
            dtp2.Enabled = false;

            dgv1.Visible = false;
            ptb1.Visible = true;
            ptb2.Visible = false;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;

            dtp1.Visible = true;
            dtp2.Visible = true;
            rtxt1.Visible = true;

            btn3.Visible = false;

            label4.Visible = true;
            label5.Visible = true;
            txt4.Visible = true;
            txt5.Visible = true;
            lbl90.Visible = true;
            lbl6.Visible = true;
            dgv9.Visible = false;
            dtp2.Enabled = true;
            label6.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn6.Visible = false;
            lblhora.Visible = true;
        }


        Reportes.DataSet1 Datos = new Reportes.DataSet1();

        private void btn1_Click(object sender, EventArgs e)
        {
            if (dtp2.Text == "" || txt2.Text == "" || dtp1.Text == "" )
            {
                MessageBox.Show("Todos los campos con * deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                int cod_empleado = Convert.ToInt32(txt2.Text);
                string fecha_entrega = dtp1.Text;
                string tiempo_renovacion = dtp2.Text;
                string observaciones = rtxt1.Text;
                N_GestionDotacion InsercionD = new N_GestionDotacion();
                InsercionD.Encapsulamiento_InsercionDotacion(id_user, cod_empleado, fecha_entrega, tiempo_renovacion, observaciones);

                //CONSULTA ID_DOTACION
                N_GestionDotacion consultaID_D = new N_GestionDotacion();
                DataTable matriz = new DataTable();
                matriz = consultaID_D.Encampsulamiento_ConsultaID_Dotacion(cod_empleado);
                dgv4.DataSource = matriz;

                string id_dotacion = dgv4.Rows[0].Cells[0].Value.ToString();



                //Insercion Detalles dotacion


                for (int cont = 0; cont < dgv2.Rows.Count; cont++)
                {
                    string cod_articulo = dgv2.Rows[cont].Cells[0].Value.ToString();
                    string nombre_articulo = dgv2.Rows[cont].Cells[1].Value.ToString();
                    string cantidad_articulo = dgv2.Rows[cont].Cells[2].Value.ToString();

                    N_GestionDotacion Instancia_Insercion0 = new N_GestionDotacion();
                    int res = Instancia_Insercion0.Encampsulamiento_Insercion_Detalles_Dotacion(cod_articulo, id_dotacion, nombre_articulo, cantidad_articulo);
                }

                for (int cont = 0; cont < dgv2.Rows.Count; cont++)
                {
                    //Modificar cantidad de articulo
                    string nombre_art = dgv2.Rows[cont].Cells[1].Value.ToString();
                    int Cantidad_restar = Convert.ToInt32(nud1.Value);
                    N_GestionDotacion Instancia_Insercion1 = new N_GestionDotacion();
                    int res1 = Instancia_Insercion1.Operacion_Cantidad_Articulos(nombre_art, Cantidad_restar);
                }

                MessageBox.Show("Registro de dotación exitoso", "Registro de dotación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Codigo reporte dotación
                for (int c = 0; c < dgv2.RowCount; c++)
                {
                    Reportes.DataSet1.DataTable2Row fila = Datos.DataTable2.NewDataTable2Row();
                    fila.Articulo= dgv2.Rows[c].Cells[1].Value.ToString();
                    fila.Cantidad = dgv2.Rows[c].Cells[2].Value.ToString();
                    Datos.DataTable2.Rows.Add(fila);
                }

                Reportes.DataSet1.DataTable1Row file = Datos.DataTable1.NewDataTable1Row();
                file.Nombre_empleado = txt5.Text;
                file.Fecha_entrega = dtp1.Text;
                file.Tiempo_renovacion = dtp2.Text;
                file.Observaciones = rtxt1.Text;
                Datos.DataTable1.Rows.Add(file);

                Reportes.Form_Reporte_Dotacion Abrir_Reporte = new Reportes.Form_Reporte_Dotacion();
                Abrir_Reporte.Nuevo = Datos;
                Abrir_Reporte.Show();
            }
            P_GestionDotacion Abrir = new P_GestionDotacion();
            Abrir.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dgv2.Visible = false;
            lbl5.Visible = false;
            btn5.Visible = false;
            cmb1.Visible = false;
            label2.Visible = false;
            txt6.Visible = false;
            rdb1.Visible = false;
            rdb2.Visible = false;
            btn4.Visible = false;

            dtp1.Enabled = false;
            dtp2.Enabled = true;

            dgv1.Visible = true;
            ptb1.Visible = true;
            ptb2.Visible = false;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;

            dtp1.Visible = true;
            dtp2.Visible = true;
            rtxt1.Visible = true;

            btn1.Visible = false;
            btn3.Visible = false;
            rtxt1.Enabled = true;
            label3.Visible = true;
            txt2.Visible = true;
            txt2.Enabled = false;

            label4.Visible = false;
            txt4.Visible = false;

            N_GestionDotacion Consulta_G = new N_GestionDotacion();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encapsulamiento_ConsulttaGD();
            dgv1.DataSource = matriz;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dgv2.Visible = false;
            lbl5.Visible = false;
            btn5.Visible = false;
            cmb1.Visible = false;
            txt2.Visible = false;
            label3.Visible = false;
            label2.Visible = true;
            txt6.Visible = true;
            rdb1.Visible = true;
            rdb2.Visible = true;
            btn4.Visible = false;

            dtp1.Enabled = true;
            dtp2.Enabled = true;

            dgv1.Visible = true;
            ptb1.Visible = true;
            ptb2.Visible = false;

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;

            dtp1.Visible = false;
            dtp2.Visible = false;
            rtxt1.Visible = false;

            btn1.Visible = false;
            btn3.Visible = true;

            label4.Visible = false;
            label5.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            nud1.Visible = false;
            lbl90.Visible = false;
            lbl6.Visible = false;
            dgv9.Visible = false;
            label6.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn6.Visible = false;
            lblhora.Visible = true;

            N_GestionDotacion Consulta_G = new N_GestionDotacion();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encapsulamiento_ConsulttaGD();
            dgv1.DataSource = matriz;

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            P_MenuGerenteAdministrativo MenuGerente = new P_MenuGerenteAdministrativo();
            MenuGerente.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string fecha_entrega = dtp1.Text;
            string observaciones = rtxt1.Text;
            N_GestionDotacion Actualizar_D = new N_GestionDotacion();
            int r1 = Actualizar_D.Encapsulamiento_ActualizarDotacion(fecha_entrega, observaciones);
            if (r1 == 1)
            {
                MessageBox.Show("Actualización de dotación exitosa", "Actualización de dotación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Actualización de dotación erréonea", "Actualización de dotación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt2.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            dtp1.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            dtp2.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
            rtxt1.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked == false && rdb2.Checked == false)
            {
                MessageBox.Show("Seleccione el dato a validar", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txt6.Text == "")
                {
                    MessageBox.Show("El campo debe ser diligenciado", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rdb1.Checked == true)
                    {
                        string cod_empleado = txt6.Text;
                        N_GestionDotacion consultaE_D = new N_GestionDotacion();
                        DataTable matriz = new DataTable();
                        matriz = consultaE_D.Encapsulamiento_ConsultaE_Dotacion(cod_empleado);
                        dgv1.DataSource = matriz;
                    }
                    else
                    {
                        if (rdb2.Checked == true)
                        {
                            string tiempo_renovacion = txt6.Text;
                            N_GestionDotacion consultaE_D = new N_GestionDotacion();
                            DataTable matriz = new DataTable();
                            matriz = consultaE_D.Encapsulamiento_ConsultaE_Dotacion(tiempo_renovacion);
                            dgv1.DataSource = matriz;
                        }
                        else
                        {
                            MessageBox.Show("Verifique que el dato del campo diligenciado sea correcto", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt2.Text == "")
            {
                MessageBox.Show("El campo debe ser diligenciado, verifique por favor", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                else
                {
                    int Id_empleado = Convert.ToInt32(txt2.Text);
                    N_GestionContrato consultaDatos_E = new N_GestionContrato();
                    DataTable matriz = new DataTable();
                    matriz = consultaDatos_E.Encapsulamiento_TraerDatos_E(Id_empleado);
                    dgv7.DataSource = matriz;

                    int cod_empleado = Convert.ToInt32(txt2.Text);
                    N_GestionDotacion Instancia_Verificar = new N_GestionDotacion();
                    int res_c = Instancia_Verificar.Encamsulamiento_ConsultaPrevia_Dotacion(cod_empleado);
                    if (res_c != 1)
                    {
                        MessageBox.Show("El empleado no existe, verifique sus datos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt5.Clear();
                        dtp1.Enabled = false;
                        dtp2.Enabled = false;
                        cmb1.Enabled = false;
                        txt4.Enabled = false;
                        nud1.Enabled = false;
                        btn5.Enabled = false;
                        rtxt1.Enabled = false;
                    }
                    else
                    {
                        int cod_empleado1 = Convert.ToInt32(txt2.Text);
                        N_GestionDotacion InstanciaC_Contrato = new N_GestionDotacion();
                        int res_c1 = InstanciaC_Contrato.Verificacion_Contrato(cod_empleado1);
                        if (res_c1 != 1)
                        {
                            MessageBox.Show("El empleado no posee contrato y por lo tanto no puede recibir dotación, verifique sus datos", "Registro de liquidación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            P_GestionDotacion Abrir = new P_GestionDotacion();
                            Abrir.Show();
                            this.Hide();                         
                        }
                    try
                    {
                        txt5.Text = Convert.ToString(dgv7.Rows[0].Cells[0].Value);
                        dtp1.Enabled = true;
                        dtp2.Enabled = true;
                        cmb1.Enabled = true;
                        nud1.Enabled = true;
                        btn5.Enabled = true;
                        rtxt1.Enabled = true;
                    }
                    catch
                    {
                    }

                }
            }
        }

        private void P_GestionDotacion_Load(object sender, EventArgs e)
        {
            N_GestionDotacion Consulta_Art = new N_GestionDotacion();
            cmb1.DataSource = Consulta_Art.Consulta_Articulos();
            cmb1.ValueMember = "nombre_articulo";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txt5.Text == "" || dtp1.Text == "" || dtp2.Text == "" || cmb1.Text == "" || txt4.Text == "" || nud1.Text == "")
            {
                MessageBox.Show("Todos los campos con * deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (nud1.Value > Convert.ToInt32(txt4.Text))
                {
                    MessageBox.Show("El número de artículos a agragar excede el número de artículos disponibles, verifique sus datos.", "Registro de dotación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //CONSULTA DEL ID_ARTICULO
                    string nombre_art = cmb1.Text;
                    N_GestionDotacion consultaID_Art = new N_GestionDotacion();
                    DataTable matriz = new DataTable();
                    matriz = consultaID_Art.ConsultaID_art(nombre_art);
                    dgv3.DataSource = matriz;
                    string cod_articulo = dgv3.Rows[0].Cells[0].Value.ToString();
                    //INSERCION A COLUMNAS DGV2
                    dgv2.Rows.Add(cod_articulo, cmb1.Text, nud1.Value, txt4.Text);
                    btn1.Visible = true;
                }
            }
        }

        private void cmb1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                string nombre_art = cmb1.Text;
                N_GestionDotacion consultaCant_A = new N_GestionDotacion();
                DataTable matriz = new DataTable();
                matriz = consultaCant_A.Consulta_Cant_Articulo(nombre_art);
                dgv5.DataSource = matriz;
                txt4.Text = dgv5.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv2.Rows.Remove(dgv2.CurrentRow);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            dgv2.Visible = false;
            lbl5.Visible = false;
            btn5.Visible = false;
            cmb1.Visible = false;
            txt2.Visible = false;
            label3.Visible = false;
            label2.Visible = true;
            txt6.Visible = true;
            rdb1.Visible = true;
            rdb2.Visible = true;
            btn4.Visible = false;

            dtp1.Enabled = true;
            dtp2.Enabled = true;

            dgv9.Visible = true;
            ptb1.Visible = true;
            ptb2.Visible = false;

            lbl1.Visible = false;
            lbl2.Visible = true;
            lbl3.Visible = false;

            dtp1.Visible = false;
            dtp2.Visible = true;
            rtxt1.Visible = false;

            btn1.Visible = false;
            btn3.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            nud1.Visible = false;
            lbl90.Visible = false;
            lbl6.Visible = false;
            dgv1.Visible = false;
            txt6.Visible = false;
            label2.Visible = false;
            rdb1.Visible = false;
            rdb2.Visible = false;
            label6.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn6.Visible = true;
            dtp2.Enabled = false;
            lblhora.Visible = true;


            string fechaHoy = DateTime.Now.ToShortDateString();
            N_GestionDotacion consultaE_D = new N_GestionDotacion();
            DataTable matriz = new DataTable();
            matriz = consultaE_D.Traer_DatosconFecha(fechaHoy);
            dgv9.DataSource = matriz;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            dtp2.Enabled = true;
            btn6.Enabled = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            dtp2.Enabled = false;
            btn6.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string cod_dotacion = textBox1.Text;
            string fecha_nueva = dtp2.Text;
            N_GestionDotacion Actualizar_Fecha_Ren = new N_GestionDotacion();
            int r1 = Actualizar_Fecha_Ren.Amplicacion_FechaRen(cod_dotacion,fecha_nueva);
            if (r1 == 1)
            {
                MessageBox.Show("Ampliación de fecha exitosa", "Actualización de fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string fechaHoy = DateTime.Now.ToShortDateString();
                N_GestionDotacion consultaE_D = new N_GestionDotacion();
                DataTable matriz = new DataTable();
                matriz = consultaE_D.Traer_DatosconFecha(fechaHoy);
                dgv9.DataSource = matriz;
            }
            else
            {
                MessageBox.Show("Ampliación de fecha errónea", "Actualización de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgv9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgv9.CurrentRow.Cells[0].Value.ToString();
            dtp2.Text = dgv9.CurrentRow.Cells[3].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
