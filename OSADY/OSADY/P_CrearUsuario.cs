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
    public partial class P_CrearUsuario : Form
    {
        public P_CrearUsuario()
        {
            InitializeComponent();
        }
        public static string user1;
        public static string cc1;

        public void Tipo_Usuario(string usuario, string cedula)
        {
            user1 = usuario;
            cc1 = cedula;
        }

        private void P_CrearUsuario_Load(object sender, EventArgs e)
        {
            txt2.Text = P_CrearUsuario.user1;
            txt3.Text = P_CrearUsuario.cc1;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txt2.Text = user1;

            if (txt2.Text == "" || txt3.Text == "" || cmb1.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string CorreoU = txt2.Text;
                string CargoU = cmb1.Text;
                string CedulaU = Convert.ToString(txt3.Text);
                N_GestionUsuario Instancia = new N_GestionUsuario();
                int res = Instancia.Encapsulamiento_InsercionUsuario(txt2.Text, txt2.Text, txt3.Text, cmb1.Text);
                if (res == 1)
                {
                    MessageBox.Show("Inserción de usuario exitosa", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P_GestionEmpleado Mostrar = new P_GestionEmpleado();
                    Mostrar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Inserción de usuario errónea", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
