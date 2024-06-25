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
    public partial class P_GestionEmpleado2 : Form
    {
        public P_GestionEmpleado2()
        {
            InitializeComponent();
        }
        public static string id_E;

        public void Pertenece_Empleado(string id_empleado)
        {
            id_E = id_empleado;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            dgv1.Rows.Add(txt1.Text, cmb2.Text, txt3.Text, dtp1.Text, cmb1.Text, txt6.Text, cmb7.Text, txt8.Text, txt9.Text);
            txt1.Clear();
            cmb2.ResetText();
            txt3.Clear();
            txt6.Clear();
            cmb7.ResetText();
            txt9.Clear();
            txt1.Focus();
            txt8.Clear();
            cmb2.Focus();
            txt3.Focus();
            txt6.Focus();
            cmb7.Focus();
            txt9.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            for (int cont = 0; cont < dgv1.Rows.Count; cont++)
            {
                string institucion = dgv1.Rows[cont].Cells[0].Value.ToString();
                string T_Tilulacion = dgv1.Rows[cont].Cells[1].Value.ToString();
                string Titulo = dgv1.Rows[cont].Cells[2].Value.ToString();
                string Fecha_T = dgv1.Rows[cont].Cells[3].Value.ToString();

                N_GestionEmpleado Instancia_Insercion2 = new N_GestionEmpleado();
                int res = Instancia_Insercion2.Encapsulamiento_InsercionInfo_Aca(id_E, institucion, T_Tilulacion, Titulo, Fecha_T);
            }

            for (int cont = 0; cont < dgv1.Rows.Count; cont++)
            {
                string T_referencia = dgv1.Rows[cont].Cells[4].Value.ToString();
                string nombre_Ref = dgv1.Rows[cont].Cells[5].Value.ToString();
                string Parentesco_Ref = dgv1.Rows[cont].Cells[6].Value.ToString();
                string Correo_Ref = dgv1.Rows[cont].Cells[7].Value.ToString();
                string tel_ref = dgv1.Rows[cont].Cells[8].Value.ToString();
                N_GestionEmpleado Insercion_Ref = new N_GestionEmpleado();
                int res = Insercion_Ref.Encapsulamiento_Insercion_Referencias(id_E, T_referencia, nombre_Ref, Parentesco_Ref, Correo_Ref, tel_ref);
                if (res == 1)
                {
                    DialogResult result = MessageBox.Show("¿Desea dar permisos de usuario al empelado por registrar?", "Notificacion de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        P_CrearUsuario Permiso_Usuario = new P_CrearUsuario();
                        Permiso_Usuario.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (result == System.Windows.Forms.DialogResult.No)
                        {
                            MessageBox.Show("Registro de empleado exitoso", "Registro de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            P_GestionEmpleado Abrir = new P_GestionEmpleado();
                            Abrir.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Registro de empleado erróneo", "Registro de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.Text == "Laboral")
            {
                cmb7.Text = "NA";
                cmb7.Enabled = false;
            }
            else
            {
                if (cmb1.Text == "Familiar")
                {
                    cmb7.Text = "";
                    cmb7.Enabled = true;
                }
            }
        }

        private void txt9_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt8_Leave(object sender, EventArgs e)
        {
            string Formato_Correo;
            Formato_Correo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txt8.Text, Formato_Correo))
            {
            }
            else
            {
                MessageBox.Show("Formato de correo incorrecto");
                txt8.Focus();
            }
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb3.Text == "Si")
            {
                txt8.Enabled = true;
            }
            else
            {
                if (cmb3.Text == "No") 
                {
                    txt8.Enabled = false;
                    txt8.Text = "No";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
