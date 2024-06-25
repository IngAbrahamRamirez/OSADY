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
    public partial class Form_Reporte_Dotacion : Form
    {
        public Form_Reporte_Dotacion()
        {
            InitializeComponent();
        }

        public DataSet Nuevo;

        private void Form_Reporte_Dotacion_Load(object sender, EventArgs e)
        {
            CrystalReport1 Imprimir = new CrystalReport1();
            Imprimir.SetDataSource(Nuevo);
            crystalReportViewer1.ReportSource = Imprimir;

        }
    }
}
