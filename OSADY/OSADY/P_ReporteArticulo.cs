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
    public partial class P_ReporteArticulo : Form
    {
        public P_ReporteArticulo()
        {
            InitializeComponent();
        }

        private void P_ReporteArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'OSADYDataSet.TrarDatos_Articulo' Puede moverla o quitarla según sea necesario.
            this.TrarDatos_ArticuloTableAdapter.Fill(this.OSADYDataSet.TrarDatos_Articulo);

            this.reportViewer1.RefreshReport();
        }
    }
}
