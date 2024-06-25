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
    public partial class P_GestionEmpleadoSCRcs : Form
    {
        public P_GestionEmpleadoSCRcs()
        {
            InitializeComponent();
        }

        private void P_GestionEmpleadoSCRcs_Load(object sender, EventArgs e)
        {
            N_GestionEmpleado ConsultaG = new N_GestionEmpleado();
            DataTable matriz = new DataTable();
            matriz = ConsultaG.Encapsulamiento_ConsultaGEmpleado();
            dgv1.DataSource = matriz;
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

        private void button1_Click(object sender, EventArgs e)
        {
            P_MenuSecretaria Open = new P_MenuSecretaria();
            Open.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
