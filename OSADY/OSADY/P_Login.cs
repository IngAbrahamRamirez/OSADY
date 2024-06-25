using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocio;


namespace OSADY
{
    public partial class P_Login : Form
    {
        public P_Login()
        {
            InitializeComponent();
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || cmb1.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser diligenciados", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {


                    N_Login ingreso = new N_Login();
                    DataTable matriz = new DataTable();
                    matriz = ingreso.Encasulamiento_Ingreso(txt1.Text);
                    dgv1.DataSource = matriz;



                    N_Login Instancia = new N_Login();
                    int res = Instancia.Encapsulamiento_login(txt1.Text, txt2.Text, cmb1.Text);

                    string dato = dgv1.Rows[0].Cells[0].Value.ToString();
                    string dato2 = dgv1.Rows[0].Cells[1].Value.ToString();

                    //INSTANCIAS PARA ENVIAR EL CODIGO DEL USUARIO QUE REGISTRA:
                    
                    P_GestionEmpleado Registrado = new P_GestionEmpleado();
                    Registrado.Registrado_por(dato2);

                    P_GestionArticulo Registrado_articulo = new P_GestionArticulo();
                    Registrado_articulo.Registrado_por_Articulo(dato2);

                    P_GestionDotacion Registrado_dotacion = new P_GestionDotacion();
                    Registrado_dotacion.Registrado_por_Dotacion(dato2);

                    P_GestionContrato Registrado_contrato = new P_GestionContrato();
                    Registrado_contrato.Registrado_por_Contrato(dato2);

                    P_GestionLiquidacion Registrado_liquidacion = new P_GestionLiquidacion();
                    Registrado_liquidacion.Registrado_por_Liquidacion(dato2);



                    if (res == 1 && cmb1.Text == "Gerente Administrativo" && dato == "0")
                    {
                        P_CambioContrasena Cambio_O = new P_CambioContrasena();
                        Cambio_O.cambio_C(txt1.Text);
                        Cambio_O.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (res == 1 && cmb1.Text == "Secretaria" && dato == "0")
                        {
                            P_CambioContrasena Cambio_O = new P_CambioContrasena();
                            Cambio_O.cambio_C(txt1.Text);
                            Cambio_O.Show();
                            this.Hide();

                        }
                        else
                        {
                            if (res == 1 && cmb1.Text == "Recursos Humanos" && dato == "0")
                            {
                                P_CambioContrasena Cambio_O = new P_CambioContrasena();
                                Cambio_O.cambio_C(txt1.Text);
                                Cambio_O.Show();
                                this.Hide();
                            }
                            else
                            {
                                if (res == 1 && cmb1.Text == "Gerente Administrativo" && dato == "1")
                                {
                                    P_MenuGerenteAdministrativo Menu1 = new P_MenuGerenteAdministrativo();
                                    Menu1.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    if (res == 1 && cmb1.Text == "Secretaria" && dato == "1")
                                    {
                                        P_MenuSecretaria Menu2 = new P_MenuSecretaria();
                                        Menu2.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        if (res == 1 && cmb1.Text == "Recursos Humanos" && dato == "1")
                                        {
                                            P_MenuRecursosHumanos Menu3 = new P_MenuRecursosHumanos();
                                            Menu3.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Datos incorrectos. Verifique los campos por favor.", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("Datos incorrectos. Verifique los campos por favor.", "Notificacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
