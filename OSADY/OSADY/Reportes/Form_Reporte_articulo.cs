using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSADY.Reportes
{
    public partial class Form_Reporte_articulo : Form
    {
        public Form_Reporte_articulo()
        {
            InitializeComponent();
        }

        private void Form_Reporte_articulo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void oSADYDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
