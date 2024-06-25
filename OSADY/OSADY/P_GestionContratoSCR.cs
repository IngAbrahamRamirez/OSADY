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
    public partial class P_GestionContratoSCR : Form
    {
        public P_GestionContratoSCR()
        {
            InitializeComponent();
        }

        private void P_GestionContratoSCR_Load(object sender, EventArgs e)
        {
            N_GestionContrato ConsultaG = new N_GestionContrato();
            DataTable matriz = new DataTable();
            matriz = ConsultaG.Encampsulamiento_ConsultaG_Contrato();
            dgv1.DataSource = matriz;
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
