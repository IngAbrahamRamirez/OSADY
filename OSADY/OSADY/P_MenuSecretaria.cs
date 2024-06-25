using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSADY
{
    public partial class P_MenuSecretaria : Form
    {
        public P_MenuSecretaria()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            P_GestionEmpleado Gestion_e = new P_GestionEmpleado();
            Gestion_e.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
            P_GestionEmpleadoSCRcs Abrir = new P_GestionEmpleadoSCRcs();
            Abrir.Show();
            this.Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            P_GestionContratoSCR Abrir = new P_GestionContratoSCR();
            Abrir.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            P_GestionDotacionSCR Abrir = new P_GestionDotacionSCR();
            Abrir.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
