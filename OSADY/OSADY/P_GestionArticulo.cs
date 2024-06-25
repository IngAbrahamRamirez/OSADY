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
    public partial class P_GestionArticulo : Form
    {
        public P_GestionArticulo()
        {
            InitializeComponent();
        }

        public static string id_user;

        public void Registrado_por_Articulo(string id_usuario)
        {
            id_user = id_usuario;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rdb1.Visible = false;
            rdb2.Visible = false;
            txt6.Visible = false;
            label2.Visible = false;

            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;

            txt1.Visible = true;
            cmb4.Visible = true;
            cmb1.Visible = true;
            txt1.Visible = true;
            rtxt1.Visible = true;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            dgv1.Visible = false;


            btn4.Visible = true;
            btn5.Visible = true;
            lbl10.Visible = true;
            lbl90.Visible = true;
            lbl7.Visible = true;
            nud1.Visible = true;
            lbl6.Visible = true;
            lblhora.Visible = true;


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rdb1.Visible = false;
            rdb2.Visible = false;
            txt6.Visible = false;
            label2.Visible = false;

            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            nud1.Visible = true;

            txt1.Visible = true;
            cmb4.Visible = true;
            cmb1.Visible = true;
            txt1.Visible = true;
            rtxt1.Visible = true;

            btn1.Visible = false;
            btn2.Visible = true;
            btn3.Visible = false;
            dgv1.Visible = true;

            txt1.Enabled = false;

            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            lbl10.Visible = false;
            nud1.Enabled = false;
            lbl90.Visible = false;
            cmb1.Enabled = true;
            cmb4.Enabled = false;
            rtxt1.Enabled = true;
            lblhora.Visible = true;


            N_GestionArticulo Consulta_G = new N_GestionArticulo();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encampsulamiento_ConsultaG_Articulo();
            dgv1.DataSource = matriz;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rdb1.Visible = true;
            rdb2.Visible = true;
            txt6.Visible = true;
            label2.Visible = true;
            
            ptb2.Visible = false;
            ptb1.Visible = true;

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            nud1.Visible = false;

            txt1.Visible = false;
            cmb4.Visible = false;
            cmb1.Visible = false;
            txt1.Visible = false;
            rtxt1.Visible = false;

            dgv1.Visible = true;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = true;

            txt1.Enabled = true;
            cmb4.Enabled = true;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            lbl10.Visible = false;
            lbl90.Visible = false;
            lblhora.Visible = true;

            N_GestionArticulo Consulta_G = new N_GestionArticulo();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encampsulamiento_ConsultaG_Articulo();
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
            string nombre_a = txt1.Text;
            string estado_a = cmb1.Text;
            string descripcion_a = rtxt1.Text;
            N_GestionArticulo Actualizar_A = new N_GestionArticulo();
            int r1 = Actualizar_A.Encapsulamiento_ActualizacionArticulo(nombre_a,estado_a,descripcion_a);
            if (r1 == 1)
            {
                MessageBox.Show("Actualización de artículo exitosa", "Actualización de artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Actualización de artículo errónea", "Actualización de artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void toolStripButton5_Click(object sender, EventArgs e)
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

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || cmb1.Text == "" || cmb4.Text == "" || nud1.Text == "")
            {
                MessageBox.Show("Todos los campos con * deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nombre_art = txt1.Text;
                N_GestionArticulo Instancia = new N_GestionArticulo();
                int res_c = Instancia.Verificar_registro_Art(nombre_art);
                if (res_c == 1)
                {
                    MessageBox.Show("El articulo ya existe, verifique sus datos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nombre_a = txt1.Text;
                    string estado_a = cmb1.Text;
                    string tipo_a = cmb4.Text;
                    string cantidad = Convert.ToString(nud1.Value);
                    string descripcion_a = rtxt1.Text;
                    N_GestionArticulo Insertar_A = new N_GestionArticulo();
                    int r1 = Insertar_A.Encapsulamiento_InsercionArticulo(id_user, nombre_a, estado_a, tipo_a, cantidad, descripcion_a);
                    if (r1 == 1)
                    {
                        MessageBox.Show("Inserción de artículo exitosa", "Registro de artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt1.Clear();
                        cmb4.ResetText();
                        cmb1.ResetText();
                        nud1.Value = 1;
                        rtxt1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Inserción de artículo errónea", "Registro de artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                        string nombre_a = txt6.Text;
                        N_GestionArticulo consultaE_A = new N_GestionArticulo();
                        DataTable matriz = new DataTable();
                        matriz = consultaE_A.Encapsulamiento_ConsultaE_Articulo(nombre_a);
                        dgv1.DataSource = matriz;
                    }
                    else
                    {
                        if (rdb2.Checked == true)
                        {
                            string cod_a = txt6.Text;
                            N_GestionArticulo consultaE_A = new N_GestionArticulo();
                            DataTable matriz = new DataTable();
                            matriz = consultaE_A.Encapsulamiento_ConsultaE_Articulo(cod_a);
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

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt1.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            cmb1.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            cmb4.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
            nud1.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            rtxt1.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Visible = false;
            btn5.Visible = false;
            lbl10.Visible = false;
            ptb2.Visible = true;
            txt1.Enabled = true;
            cmb1.Enabled = true;
            cmb4.Enabled = true;
            nud1.Enabled = true;
            rtxt1.Enabled = true;
            btn1.Visible = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn1.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            lbl10.Visible = false;
            dgv1.Visible = true;
            txt1.Enabled = false;
            cmb1.Enabled = false;
            cmb4.Enabled = false;
            nud1.Enabled = true;
            rtxt1.Enabled = false;
            btn6.Visible = true;

            N_GestionArticulo Consulta_G = new N_GestionArticulo();
            DataTable matriz = new DataTable();
            matriz = Consulta_G.Encampsulamiento_ConsultaG_Articulo();
            dgv1.DataSource = matriz;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string nombre_art = txt1.Text;
            string cantidad_art = Convert.ToString(nud1.Value);
            N_GestionArticulo Actualizar_Cantidad = new N_GestionArticulo();
            int r1 = Actualizar_Cantidad.Encapsulamiento_Actualizar_Cantidad(nombre_art,cantidad_art);
            if (r1 == 1)
            {
                MessageBox.Show("Cantidad agregada exitosamente", "Agregar cantidad de artículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar cantidad", "Agregar cantidad de artículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            P_ReporteArticulo Abrir = new P_ReporteArticulo();
            Abrir.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}
