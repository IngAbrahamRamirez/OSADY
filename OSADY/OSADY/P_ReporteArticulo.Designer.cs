namespace OSADY
{
    partial class P_ReporteArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_ReporteArticulo));
            this.TrarDatos_ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OSADYDataSet = new OSADY.OSADYDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TrarDatos_ArticuloTableAdapter = new OSADY.OSADYDataSetTableAdapters.TrarDatos_ArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TrarDatos_ArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSADYDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TrarDatos_ArticuloBindingSource
            // 
            this.TrarDatos_ArticuloBindingSource.DataMember = "TrarDatos_Articulo";
            this.TrarDatos_ArticuloBindingSource.DataSource = this.OSADYDataSet;
            // 
            // OSADYDataSet
            // 
            this.OSADYDataSet.DataSetName = "OSADYDataSet";
            this.OSADYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TrarDatos_ArticuloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OSADY.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(556, 436);
            this.reportViewer1.TabIndex = 0;
            // 
            // TrarDatos_ArticuloTableAdapter
            // 
            this.TrarDatos_ArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // P_ReporteArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 471);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_ReporteArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P_ReporteArticulo";
            this.Load += new System.EventHandler(this.P_ReporteArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrarDatos_ArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSADYDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TrarDatos_ArticuloBindingSource;
        private OSADYDataSet OSADYDataSet;
        private OSADYDataSetTableAdapters.TrarDatos_ArticuloTableAdapter TrarDatos_ArticuloTableAdapter;
    }
}