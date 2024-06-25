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
    public partial class P_MenuGerenteAdministrativo : Form
    {
        public P_MenuGerenteAdministrativo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            P_GestionEmpleado GestionE = new P_GestionEmpleado();
            GestionE.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            P_GestionUsuario GestionU = new P_GestionUsuario();
            GestionU.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            P_GestionLiquidacion GestionL = new P_GestionLiquidacion();
            GestionL.Show();
            this.Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            P_GestionContrato GestionC = new P_GestionContrato();
            GestionC.Show();
            this.Hide();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            P_GestionDotacion GestionD = new P_GestionDotacion();
            GestionD.Show();
            this.Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            P_GestionArticulo GestionA = new P_GestionArticulo();
            GestionA.Show();
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

        private void btn2_Click_1(object sender, EventArgs e)
        {
            P_GestionUsuario GU = new P_GestionUsuario();
            GU.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}
