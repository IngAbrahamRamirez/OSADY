using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using System.Text.RegularExpressions;

namespace OSADY
{
    public partial class P_GestionEmpleado : Form
    {
        public P_GestionEmpleado()
        {
            InitializeComponent();
        }

        public static string id_user;

        public void Registrado_por(string id_usuario)
        {
            id_user = id_usuario;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ptb2.Visible = false;
            ptb1.Visible = true;
            ptb4.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            lbl8.Visible = true;
            lbl9.Visible = true;
            lbl10.Visible = true;
            lbl10.Visible = true;
            lbl11.Visible = true;
            lbl12.Visible = true;
            lbl13.Visible = true;
            label4.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            dtp1.Visible = true;
            cmb1.Visible = true;
            cmb3.Visible = true;
            lbl14.Visible = false;


            txt1.Visible = true;
            txt2.Visible = true;
            cmb4.Visible = true;
            txt4.Visible = false;
            cmb5.Visible = true;
            txt6.Visible = true;
            txt7.Visible = true;
            txt8.Visible = true;
            txt10.Visible = true;
            txt11.Visible = true;
            txt15.Visible = true;
            txt16.Visible = true;
            cmb6.Visible = true;
            cmb7.Visible = true;
            rtxt3.Visible = true;

            nud1.Visible = true;
            nud2.Visible = true;
            txt14.Visible = false;
            cmb2.Visible = true;

            btn1.Visible = true;
            btn2.Visible = false;
            btn3.Visible = false;
            dgv1.Visible = false;

            txt1.Enabled = true;
            txt2.Enabled = true;
            txt4.Enabled = true;
            dtp1.Enabled = true;
            cmb5.Enabled = true;
            txt15.Enabled = true;
            txt16.Enabled = true;
            cmb2.Enabled = true;
            cmb8.Visible = true;
            label2.Visible= true;
            lbl90.Visible = true;
            lblhora.Visible = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rdb1.Visible = false;
            rdb2.Visible = false;
            rdb3.Visible = false;
            ptb4.Visible = false;

            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            lbl8.Visible = true;
            lbl9.Visible = true;
            lbl10.Visible = true;
            lbl11.Visible = true;
            lbl12.Visible = true;
            lbl13.Visible = true;
            lbl14.Visible = false;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            dtp1.Visible = true;
            cmb1.Visible = true;
            cmb2.Visible = true;
            cmb3.Visible = true;
            rtxt3.Visible = true;



            txt1.Visible = true;
            txt2.Visible = true;
            cmb4.Visible = true;
            txt4.Visible = true;
            cmb5.Visible = false;
            txt6.Visible = true;
            txt7.Visible = true;
            txt8.Visible = true;
            txt10.Visible = true;
            txt11.Visible = true;
            nud1.Visible = true;
            nud2.Visible = true;
            txt14.Visible = false;
            txt15.Visible = true;
            txt16.Visible = true;
            cmb6.Visible = true;
            cmb7.Visible = true;

            dgv1.Visible = true;
            btn1.Visible = false;
            btn2.Visible = true;
            btn3.Visible = false;
            lblhora.Visible = true;
            

            N_GestionEmpleado ConsultaG = new N_GestionEmpleado();
            DataTable matriz = new DataTable();
            matriz = ConsultaG.Encapsulamiento_ConsultaGEmpleado();
            dgv1.DataSource = matriz;

            txt1.Enabled = false;
            txt2.Enabled = false;
            txt4.Enabled = false;
            dtp1.Enabled = false;
            cmb5.Enabled = false;
            txt15.Enabled = false;
            txt16.Enabled = false;
            cmb2.Enabled = false;
            cmb8.Enabled = false;
            lbl90.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rdb1.Visible = true;
            rdb2.Visible = true;
            rdb3.Visible = true;


            ptb2.Visible = false;
            ptb1.Visible = true;
            ptb4.Visible = false;

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;
            lbl10.Visible = false;
            lbl11.Visible = false;
            lbl12.Visible = false;
            lbl13.Visible = false;
            lbl14.Visible = false;
            label4.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            dtp1.Visible = false;
            cmb3.Visible = false;
            cmb2.Visible = false;
            cmb1.Visible = false;
            lbl14.Visible = true;
            nud1.Visible = false;


            txt1.Visible = false;
            txt2.Visible = false;
            txt4.Visible = false;
            cmb4.Visible = false;
            cmb5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;
            txt8.Visible = false;
            txt10.Visible = false;
            txt11.Visible = false;
            nud2.Visible = false;
            txt14.Visible = true;
            txt15.Visible = false;
            txt16.Visible = false;
            cmb6.Visible = false;
            cmb7.Visible = false;
            rtxt3.Visible = false;

            dgv1.Visible = true;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = true;
            lbl90.Visible = false;
            cmb8.Visible=false;
            label2.Visible = false;
            lblhora.Visible = true;

            N_GestionEmpleado ConsultaG = new N_GestionEmpleado();
            DataTable matriz = new DataTable();
            matriz = ConsultaG.Encapsulamiento_ConsultaGEmpleado();
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

        private void btn1_Click_1(object sender, EventArgs e)
        {
            
            if (txt1.Text == "" || txt2.Text == "" || cmb4.Text == "" || dtp1.Text == "" || cmb1.Text == "" || cmb5.Text == "" || txt6.Text == "" || txt7.Text == "" || txt8.Text == "" || txt10.Text == "" || txt11.Text == "" || nud2.Text == "" || cmb3.Text == "" || cmb7.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string cedula_em =txt2.Text;
                N_GestionEmpleado Instancia = new N_GestionEmpleado();
                int res_c = Instancia.Verificar_registro(cedula_em);
                if(res_c==1)
                {
                    MessageBox.Show("El empleado ya existe, verifique sus datos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
                else
                {
                    string nombre = txt1.Text;
                    string cedula = txt2.Text;
                    string area = cmb4.Text;
                    string fecha_nacimiento = Convert.ToString(dtp1.Text);
                    string lugar_nacimiento = cmb5.Text;
                    string direccion = txt6.Text;
                    int telefono = Convert.ToInt32(txt7.Text);
                    string celular = txt8.Text;
                    string antecedentes = cmb1.Text;
                    string correo = txt10.Text;
                    string profesion = txt11.Text;
                    string estado_civil = cmb3.Text;
                    string anos_experiencia = nud2.Text;
                    string libreta_militar = txt15.Text;
                    string vehiculo = cmb2.Text;
                    string licencia = txt16.Text;
                    string categoria_licencia = cmb6.Text;
                    string tipo_vivienda = cmb7.Text;
                    string perfil_laboral = rtxt3.Text;
                    int numero_dependientes = Convert.ToInt32(nud1.Value);
                    N_GestionEmpleado Instancia_Insercion = new N_GestionEmpleado();
                    int res = Instancia_Insercion.Encapsulamiento_InsercionEmpleado(id_user, nombre, cedula, area, fecha_nacimiento, lugar_nacimiento, direccion, telefono, celular, antecedentes, correo, profesion, estado_civil, anos_experiencia, libreta_militar, vehiculo, licencia, categoria_licencia, tipo_vivienda, numero_dependientes, perfil_laboral);
                    if (res == 1)
                    {
                        MessageBox.Show("Registro de empleado exitoso", "Continuar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        P_CrearUsuario instancia = new P_CrearUsuario();
                        instancia.Tipo_Usuario(txt10.Text, txt2.Text);//Envio de datos para crear un nuevo usuario del sistema
                        P_GestionEmpleado2 Empleado2 = new P_GestionEmpleado2();//Se muestra un nuevo formulario para completar el registro del empleado
                        Empleado2.Show();
                        this.Hide();
                        string cc = txt2.Text;
                        N_GestionEmpleado instaciarE_E = new N_GestionEmpleado();
                        DataTable matriz = new DataTable();
                        matriz = instaciarE_E.Encapsulamiento_ConsultaID_Empleado(cc);
                        dgv1.DataSource = matriz; //Consulta del ID del empleado 

                        //Envio del ID a otra clase

                        string id_emleado = dgv1.Rows[0].Cells[0].Value.ToString();
                        P_GestionEmpleado2 Registrado = new P_GestionEmpleado2();
                        Registrado.Pertenece_Empleado(id_emleado);


                    }
                    else
                    {
                        MessageBox.Show("Inserción de empleado incorrecta", "Registro de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt23.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            txt24.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            txt1.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            txt2.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            dtp1.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
            txt4.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            txt6.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
            txt7.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
            txt8.Text = dgv1.CurrentRow.Cells[8].Value.ToString();
            txt10.Text = dgv1.CurrentRow.Cells[9].Value.ToString();
            cmb1.Text = dgv1.CurrentRow.Cells[10].Value.ToString();
            txt11.Text = dgv1.CurrentRow.Cells[11].Value.ToString();
            cmb3.Text = dgv1.CurrentRow.Cells[12].Value.ToString();
            nud2.Text = dgv1.CurrentRow.Cells[13].Value.ToString();
            cmb4.Text = dgv1.CurrentRow.Cells[14].Value.ToString();
            txt15.Text = dgv1.CurrentRow.Cells[15].Value.ToString();
            cmb2.Text = dgv1.CurrentRow.Cells[16].Value.ToString();
            txt16.Text = dgv1.CurrentRow.Cells[17].Value.ToString();
            cmb6.Text = dgv1.CurrentRow.Cells[18].Value.ToString();
            cmb7.Text = dgv1.CurrentRow.Cells[19].Value.ToString();
            nud1.Text = dgv1.CurrentRow.Cells[20].Value.ToString();
            rtxt3.Text = dgv1.CurrentRow.Cells[21].Value.ToString();

        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dato = cmb2.Text;
            if (dato == "Si")
            {
                txt16.Enabled = true;
                cmb6.Enabled = true;
                txt16.Text = "";
                cmb6.Text = "";
            }
            else
            {
                if (dato == "No")
                {
                    txt16.Enabled = false;
                    cmb6.Enabled = false;
                    txt16.Text = "No";
                    cmb6.Text = "No";
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            {
                if (cmb4.Text == "" || txt7.Text == "" || txt8.Text == "" || cmb1.Text == "" || txt10.Text == "" || txt11.Text == "" || nud2.Text == "" || cmb3.Text == "" || cmb7.Text == "" || nud1.Text == "" || rtxt3.Text == "")
                {
                    MessageBox.Show("Todos los campos deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string cedula = txt2.Text;
                    string area = cmb4.Text;
                    string direccion = txt6.Text;
                    int telefono = Convert.ToInt32(txt7.Text);
                    string celular = txt8.Text;
                    string antecedentes = cmb1.Text;
                    string correo = txt10.Text;
                    string profesion = txt11.Text;
                    string estado_civil = cmb3.Text;
                    string anos_experiencia = nud2.Text;
                    string perfil_laboral = rtxt3.Text;
                    string tipo_vivienda = cmb7.Text;
                    int num_dependientes = Convert.ToInt32(nud1.Value);
                    N_GestionEmpleado Actualizar_E = new N_GestionEmpleado();
                    int r1 = Actualizar_E.Encapsulamiento_ActualizacionEmpleado(cedula, area, direccion, telefono, celular, antecedentes, correo, profesion, estado_civil, anos_experiencia, perfil_laboral, tipo_vivienda, num_dependientes);
                    if (r1 == 1)
                    {
                        MessageBox.Show("Actualización de datos del empleado exitosa", "Actualización de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Actualización de datos del empleado errónea", "Actualización de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked == false && rdb2.Checked == false && rdb3.Checked == false)
            {
                MessageBox.Show("Seleccione el dato a validar", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txt14.Text == "")
                {
                    MessageBox.Show("El campo debe ser diligenciado", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rdb1.Checked == true)
                    {
                        string nombre_empleado = txt14.Text;
                        N_GestionEmpleado instaciarE_E = new N_GestionEmpleado();
                        DataTable matriz = new DataTable();
                        matriz = instaciarE_E.Encapsulamiento_ConsultaE_Empleado(nombre_empleado);
                        dgv1.DataSource = matriz;
                    }
                    else
                    {
                        if (rdb2.Checked == true)
                        {
                            string correo_empleado = txt14.Text;
                            N_GestionEmpleado instaciarE_E = new N_GestionEmpleado();
                            DataTable matriz = new DataTable();
                            matriz = instaciarE_E.Encapsulamiento_ConsultaE_Empleado(correo_empleado);
                            dgv1.DataSource = matriz;
                        }
                        else
                        {
                            if (rdb3.Checked == true)
                            {
                                string cedula = txt14.Text;
                                N_GestionEmpleado instaciarE_E = new N_GestionEmpleado();
                                DataTable matriz = new DataTable();
                                matriz = instaciarE_E.Encapsulamiento_ConsultaE_Empleado(cedula);
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

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt18_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt10_Leave(object sender, EventArgs e)
        {
            string Formato_Correo;
            Formato_Correo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txt10.Text, Formato_Correo))
            {
            }
            else
            {
                MessageBox.Show("Formato de correo incorrecto");
                txt10.Focus();

            }
        }

        private void cmb8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dato = cmb8.Text;
            if (dato == "Si")
            {
                txt15.Enabled = true;
                txt15.Text = "";
            }
            else
            {
                if (dato == "No")
                {
                    txt15.Enabled = false;
                    txt15.Text = "No";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
      