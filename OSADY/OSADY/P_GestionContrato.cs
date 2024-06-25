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
    public partial class P_GestionContrato : Form
    {
        public P_GestionContrato()
        {
            InitializeComponent();
        }
        public static string id_user;

        public void Registrado_por_Contrato(string id_usuario)
        {
            id_user = id_usuario;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rdb1.Visible = false;
            rdb2.Visible = false;
            rdb3.Visible = true;
            rdb4.Visible = true;
            label2.Visible = false;
            textBox1.Visible = false;

            ptb1.Visible = true;
            ptb2.Visible = false;
            ptb3.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            lbl15.Visible = true;
            lbl16.Visible = true;

            txt1.Visible = true;
            txt2.Visible = true;
            nud1.Visible = true;

            cmb2.Visible = true;
            txt6.Visible = true;

            txt15.Visible = true;
            cmb1.Visible = true;
            btn1.Visible = true;
            btn4.Visible = true;

            btn3.Visible = false;
            dgv1.Visible = false;
            dtp1.Visible = true;
            rtxt1.Visible = true;
            lbl90.Visible = true;
            lblhora.Visible = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;

            lbl15.Visible = true;
            lbl16.Visible = true;

            txt1.Visible = true;
            txt2.Visible = true;
            nud1.Visible = true;
            cmb2.Visible = true;
            txt6.Visible = true;
            txt15.Visible = true;

            dgv1.Visible = false;
            btn1.Visible = false;
            btn3.Visible = false;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rdb1.Visible = true;
            rdb2.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;

            dtp1.Visible = false;
            rtxt1.Visible = false;


            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl15.Visible = false;
            lbl16.Visible = false;

            txt1.Visible = false;
            txt2.Visible = false;
            nud1.Visible = false;
            cmb2.Visible = false;
            txt6.Visible = false;
            txt15.Visible = false;
            dgv1.Visible = true;

            btn1.Visible = false;
            btn3.Visible = true;
            cmb1.Visible = false;

            rdb3.Visible = false;
            rdb4.Visible = false;
            btn4.Visible = false;
            lbl90.Visible = false;
            lblhora.Visible = true;

            N_GestionContrato ConsultaG = new N_GestionContrato();
            DataTable matriz = new DataTable();
            matriz = ConsultaG.Encampsulamiento_ConsultaG_Contrato();
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

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || nud1.Text == "" || cmb1.Text == "" || dtp1.Text == "" || cmb2.Text == "" || txt6.Text == "")
            {
                MessageBox.Show("Todos los campos con * deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Consulta ID_EMPLEADO
                try
                {
                    string cedula_empleado = txt15.Text;
                    N_GestionContrato Consulta_cod_E = new N_GestionContrato();
                    DataTable matrizID_E = new DataTable();
                    matrizID_E = Consulta_cod_E.Consulta_Cod_E(cedula_empleado);
                    dgv3.DataSource = matrizID_E;
                    int cod_empleado = Convert.ToInt32(dgv3.Rows[0].Cells[0].Value.ToString());

                    string Tipo_Contrato = cmb1.Text;
                    string Nombre_Empleado = txt1.Text;
                    string CC_Empleado = txt2.Text;
                    string Duracion_Contrato = nud1.Text;
                    string Fecha_inicio = dtp1.Text;
                    string Cargo_Empleado = cmb2.Text;
                    string Salario = txt6.Text;
                    string Condiciones = rtxt1.Text;
                    N_GestionContrato Instancia = new N_GestionContrato();
                    int res = Instancia.Encapsulamiento_InsercionContrato(id_user, cod_empleado, Tipo_Contrato, Nombre_Empleado, CC_Empleado, Duracion_Contrato, Fecha_inicio, Cargo_Empleado, Salario, Condiciones);
                    if (res == 1)
                    {
                        MessageBox.Show("Registro de contrato exitoso", "Creación de contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        P_GestionContrato Mostrar = new P_GestionContrato();
                        Mostrar.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("Registro de contrato erróneo", "Creación de contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Registro de contrato erróneo", "Creación de contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void btn3_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked == false && rdb2.Checked == false)
            {
                MessageBox.Show("Seleccione el dato a validar", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("El campo debe ser diligenciado", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rdb1.Checked == true)
                    {
                        string nombre_empleado = textBox1.Text;
                        N_GestionContrato instaciarE_E = new N_GestionContrato();
                        DataTable matriz = new DataTable();
                        matriz = instaciarE_E.Encamsulamiento_ConsultaE_Contrato(nombre_empleado);
                        dgv1.DataSource = matriz;
                    }
                    else
                    {
                        if (rdb2.Checked == true)
                        {
                            string cedula = textBox1.Text;
                            N_GestionContrato instaciarE_E = new N_GestionContrato();
                            DataTable matriz = new DataTable();
                            matriz = instaciarE_E.Encamsulamiento_ConsultaE_Contrato(cedula);
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

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt15.Text == "")
            {
                MessageBox.Show("El campo debe ser diligenciado, verifique por favor", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txt15.Text != "")
                {
                    string cedula_empleado_ver = txt15.Text;
                    N_GestionContrato Instancia = new N_GestionContrato();
                    int res_ver_c = Instancia.Encapsulamiento_Validar_contrato1(cedula_empleado_ver);
                    if (res_ver_c == 1)
                    {
                        MessageBox.Show("El empleado ya posee un contrato, verifique sus datos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string Ced_empleado = txt15.Text;
                        N_GestionContrato consultaDatos_E = new N_GestionContrato();
                        DataTable matriz = new DataTable();
                        matriz = consultaDatos_E.Encapsulamiento_TraerDatos_E1(Ced_empleado);
                        dgv2.DataSource = matriz;

                        string ced_empleado = txt15.Text;
                        N_GestionContrato Instancia_Verificar = new N_GestionContrato();
                        int res_c = Instancia_Verificar.Encamsulamiento_ConsultaPrevia_Contrato1(ced_empleado);
                        if (res_c != 1)
                        {
                            MessageBox.Show("El empleado no existe, verifique sus datos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        txt1.Text = Convert.ToString(dgv2.Rows[0].Cells[0].Value);
                        txt2.Text = Convert.ToString(dgv2.Rows[0].Cells[1].Value);
                    }
                }
            }
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label3.Visible = false;
            nud1.Minimum = 1;
            nud1.Maximum = 11;
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = true;
            nud1.Minimum = 1;
            nud1.Maximum = 100;
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Campo alfabético");
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

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
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


        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
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