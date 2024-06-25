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
    public partial class P_GestionDotacionSCR : Form
    {
        public P_GestionDotacionSCR()
        {
            InitializeComponent();
        }

        private void P_GestionDotacionSCR_Load(object sender, EventArgs e)
        {
            N_GestionDotacion Consulta_G = new N_GestionDotacion();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encapsulamiento_ConsulttaGD();
            dgv1.DataSource = matriz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_MenuSecretaria Open = new P_MenuSecretaria();
            Open.Show();
            this.Hide();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
