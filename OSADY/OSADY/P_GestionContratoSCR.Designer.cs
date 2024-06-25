namespace OSADY
{
    partial class P_GestionContratoSCR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_GestionContratoSCR));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btn3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(24, 186);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(620, 145);
            this.dgv1.TabIndex = 105;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightCoral;
            this.btn3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(308, 357);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 42);
            this.btn3.TabIndex = 104;
            this.btn3.Text = "Consultar contrato";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 159;
            this.label2.Text = "Ingrese el dato a validar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 158;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.BackColor = System.Drawing.Color.White;
            this.rdb2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.Location = new System.Drawing.Point(145, 143);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(244, 19);
            this.rdb2.TabIndex = 157;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Número de cédula del empleado";
            this.rdb2.UseVisualStyleBackColor = false;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.BackColor = System.Drawing.Color.White;
            this.rdb1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(145, 118);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(175, 19);
            this.rdb1.TabIndex = 156;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Nombre del empleado";
            this.rdb1.UseVisualStyleBackColor = false;
            // 
            // ptb1
            // 
            this.ptb1.Image = global::OSADY.Properties.Resources.LOGO_KODO1;
            this.ptb1.Location = new System.Drawing.Point(12, 12);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(153, 70);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 155;
            this.ptb1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::OSADY.Properties.Resources.Volver;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(579, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 44);
            this.button1.TabIndex = 160;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 203;
            this.label1.Text = "CONSULTAR CONTRATO";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.White;
            this.lblhora.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(338, 21);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(85, 15);
            this.lblhora.TabIndex = 212;
            this.lblhora.Text = "Cargando...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // P_GestionContratoSCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OSADY.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 421);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btn3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_GestionContratoSCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P_GestionContratoSCR";
            this.Load += new System.EventHandler(this.P_GestionContratoSCR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
    }
}