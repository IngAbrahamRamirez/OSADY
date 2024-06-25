namespace OSADY.Reportes
{
    partial class Form_Reporte_articulo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.oSADYDataSet = new OSADY.OSADYDataSet();
            this.oSADYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrarDatos_ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oSADYDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.oSADYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSADYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrarDatos_ArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSADYDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OSADY.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(473, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // oSADYDataSet
            // 
            this.oSADYDataSet.DataSetName = "OSADYDataSet";
            this.oSADYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oSADYDataSetBindingSource
            // 
            this.oSADYDataSetBindingSource.DataSource = this.oSADYDataSet;
            this.oSADYDataSetBindingSource.Position = 0;
            this.oSADYDataSetBindingSource.CurrentChanged += new System.EventHandler(this.oSADYDataSetBindingSource_CurrentChanged);
            // 
            // TrarDatos_ArticuloBindingSource
            // 
            this.TrarDatos_ArticuloBindingSource.DataMember = "TrarDatos_Articulo";
            this.TrarDatos_ArticuloBindingSource.DataSource = this.oSADYDataSet;
            // 
            // oSADYDataSetBindingSource1
            // 
            this.oSADYDataSetBindingSource1.DataSource = this.oSADYDataSet;
            this.oSADYDataSetBindingSource1.Position = 0;
            // 
            // Form_Reporte_articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 340);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Reporte_articulo";
            this.Text = "Form_Reporte_articulo";
            this.Load += new System.EventHandler(this.Form_Reporte_articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oSADYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSADYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrarDatos_ArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSADYDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource oSADYDataSetBindingSource;
        private OSADYDataSet oSADYDataSet;
        private System.Windows.Forms.BindingSource TrarDatos_ArticuloBindingSource;
        private System.Windows.Forms.BindingSource oSADYDataSetBindingSource1;
    }
}