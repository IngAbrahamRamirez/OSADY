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
    public partial class P_GestionUsuario : Form
    {
        public P_GestionUsuario()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ptb2.Visible = true;
            ptb1.Visible = true;

            txt3.Enabled = true;

            rdb1.Visible = false;
            rdb2.Visible = false;
            rdb3.Visible = false;


            lbl3.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = true;


            txt2.Visible = true;
            txt3.Visible = true;
            txt6.Visible = false;
            cmb1.Visible = true;
            cmb1.Visible = true;

            dgv1.Visible = false;

            btn1.Visible = true;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txt3.Enabled = false;
            txt3.Visible = true;

            rdb1.Visible = false;
            rdb2.Visible = false;
            rdb3.Visible = false;

            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl3.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = true;



            txt2.Visible = true;
            txt6.Visible = false;
            cmb1.Visible = true;

            dgv1.Visible = true;

            btn1.Visible = false;
            btn2.Visible = true;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            lblhora.Visible = true;

            N_GestionUsuario Consulta_G = new N_GestionUsuario();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encampsulamiento_ConsultaG_Usuario();
            dgv1.DataSource = matriz;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            rdb1.Visible = true;
            rdb2.Visible = true;
            rdb3.Visible = true;

            dgv1.Visible = true;

            ptb2.Visible = false;
            ptb1.Visible = true;

            rdb1.Visible = true;
            rdb2.Visible = true;
            lbl6.Visible = true;
            txt6.Visible = true;
            txt3.Visible = false;

            lbl3.Visible = false;
            lbl5.Visible = false;
            lbl7.Visible = false;



            txt2.Visible = false;
            cmb1.Visible = false;


            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = true;
            btn4.Visible = false;
            btn5.Visible = false;
            lblhora.Visible = true;

            N_GestionUsuario Consulta_G = new N_GestionUsuario();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encampsulamiento_ConsultaG_Usuario();
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
            if (txt2.Text == "" || txt3.Text == "" || cmb1.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string cedula = txt3.Text;
                string correo = txt2.Text;
                string cargo = cmb1.Text;
                N_GestionUsuario Actualizar_U = new N_GestionUsuario();
                int r1 = Actualizar_U.Encapsulamiento_ActualizacionUsuario(cedula, correo, cargo);
                if (r1 == 1)
                {
                    MessageBox.Show("Actualización de usuario exitosa", "Actualización de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Actualización de usuario errónea", "Actualización de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                {
                    if (rdb1.Checked == true)
                    {
                        string cargo = cmb2.Text;
                        N_GestionUsuario instaciarG_U = new N_GestionUsuario();
                        DataTable matriz = new DataTable();
                        matriz = instaciarG_U.Encapsulamiento_ConsultaE_Usuario(cargo);
                        dgv1.DataSource = matriz;
                    }
                    else
                    {
                        if (rdb2.Checked == true)
                        {
                            if (txt6.Text == "")
                            {
                                MessageBox.Show("El campo debe ser diligenciado", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            txt6.Visible = true;
                            cmb2.Visible = false;

                            string correo = txt6.Text;
                            N_GestionUsuario instaciarG_U = new N_GestionUsuario();
                            DataTable matriz = new DataTable();
                            matriz = instaciarG_U.Encapsulamiento_ConsultaE_Usuario(correo);
                            dgv1.DataSource = matriz;
                        }
                        else
                        {
                            if (rdb3.Checked == true)
                            {
                                if (txt6.Text == "")
                                {
                                    MessageBox.Show("El campo debe ser diligenciado", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                txt6.Visible = true;
                                cmb2.Visible = false;
                                string cedula = txt6.Text;
                                N_GestionUsuario instaciarG_U = new N_GestionUsuario();
                                DataTable matriz = new DataTable();
                                matriz = instaciarG_U.Encapsulamiento_ConsultaE_Usuario(cedula);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt3.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            cmb1.Text = dgv1.CurrentRow.Cells[2].Value.ToString();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(txt2.Text);
            N_GestionUsuario Eliminar_U = new N_GestionUsuario();
            int r1 = Eliminar_U.Encapsulamiento_EliminacionUsuario(usuario);
            if (r1 == 1)
            {
                MessageBox.Show("Eliminación de usuario exitosa", "Eliminación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eliminación de usuario errónea", "Eliminación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            txt2.Enabled = false;
            txt3.Enabled = false;
            txt3.Visible = false;
            txt6.Visible = false;
            cmb1.Enabled = false;

            rdb1.Visible = false;
            rdb2.Visible = false;
            rdb3.Visible = false;

            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl3.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = true;


            txt2.Visible = true;
            txt3.Visible = true;
            cmb1.Visible = true;

            dgv1.Visible = true;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = true;
            btn5.Visible = false;
            lblhora.Visible = true;

            N_GestionUsuario Consulta_G = new N_GestionUsuario();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encampsulamiento_ConsultaG_Usuario();
            dgv1.DataSource = matriz;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
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

        private void txt2_Leave(object sender, EventArgs e)
        {
            string Formato_Correo;
            Formato_Correo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txt2.Text, Formato_Correo))
            {

            }
            else
            {
                MessageBox.Show("Formato de correo incorrecto");
                txt2.Focus();
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptb2_Click(object sender, EventArgs e)
        {

        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt3.Visible = false;
            txt6.Visible = false;
            cmb1.Enabled = false;

            rdb1.Visible = false;
            rdb2.Visible = false;
            rdb3.Visible = false;

            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl3.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = true;


            txt2.Visible = true;
            txt3.Visible = true;
            cmb1.Visible = true;

            dgv1.Visible = true;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = true;
            lblhora.Visible = true;

            N_GestionUsuario Consulta_G = new N_GestionUsuario();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.ConsultaG_Activar();
            dgv1.DataSource = matriz;
        }
        private void btn5_Click(object sender, EventArgs e)
        {

            string usuario = Convert.ToString(txt2.Text);
            N_GestionUsuario Activar_U = new N_GestionUsuario();
            int r1 = Activar_U.Encapsulamiento_ActivacionUsuario(usuario);
            if (r1 == 1)
            {
                MessageBox.Show("Activación de usuario exitosa", "Activación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Activación de usuario errónea", "Activación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            txt6.Visible = true;
            cmb2.Visible = false;
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            txt6.Visible = true;
            cmb2.Visible = false;
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            txt6.Visible = false;
            cmb2.Visible = true;
        }

        private void P_GestionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
