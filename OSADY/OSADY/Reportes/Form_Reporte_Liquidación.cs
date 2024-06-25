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
    public partial class Form_Reporte_Liquidación : Form
    {
        public Form_Reporte_Liquidación()
        {
            InitializeComponent();
        }

        public DataSet Nuevo;

        private void Form_Reporte_Liquidación_Load(object sender, EventArgs e)
        {
            CrystalReport2 Imprimir = new CrystalReport2();
            Imprimir.SetDataSource(Nuevo);
            crystalReportViewer1.ReportSource = Imprimir;
        }

    }
}
