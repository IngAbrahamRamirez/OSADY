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
    public partial class P_CambioContrasena : Form
    {
        public P_CambioContrasena()
        {
            InitializeComponent();
        }

        public string nom_user;

        public void cambio_C(string usuario)
        {
            nom_user = usuario;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
 
            if (txt1.Text == "")
            {
                MessageBox.Show("Debe diligenciar el campo requerido", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string clave_nueva = txt1.Text;
                N_CambioContrasena cambio = new N_CambioContrasena();
                int res = cambio.Encapsulamiento_Clave(txt1.Text, nom_user);
                if (res == 1)
                {
                    MessageBox.Show("Cambio de contraseña exitoso", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P_Login Acceso = new P_Login();
                    Acceso.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Cambio de contraseña erróneo", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}



