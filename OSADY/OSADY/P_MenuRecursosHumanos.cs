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
    public partial class P_MenuRecursosHumanos : Form
    {
        public P_MenuRecursosHumanos()
        {
            InitializeComponent();
        }

        private void P_MenuRecursosHumanos_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            P_GestionEmpleado Gestion_E=new P_GestionEmpleado();
            Gestion_E.Show();
            this.Hide();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            P_GestionLiquidacionRH Gestion_L = new P_GestionLiquidacionRH();
            Gestion_L.Show();
            this.Hide();
        
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            P_GestionContratoRH Gestion_P = new P_GestionContratoRH();
            Gestion_P.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            P_GestionDotacionRH Gestion_D=new P_GestionDotacionRH();
            Gestion_D.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
