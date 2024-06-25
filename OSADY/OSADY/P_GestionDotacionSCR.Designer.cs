namespace OSADY
{
    partial class P_GestionDotacionSCR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_GestionDotacionSCR));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
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
            this.dgv1.Location = new System.Drawing.Point(36, 185);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(611, 143);
            this.dgv1.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 150;
            this.label2.Text = "Ingrese el dato a validar:";
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(368, 140);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(199, 20);
            this.txt6.TabIndex = 149;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.BackColor = System.Drawing.Color.White;
            this.rdb2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.Location = new System.Drawing.Point(116, 140);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(176, 19);
            this.rdb2.TabIndex = 148;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Tiempo de renovacion";
            this.rdb2.UseVisualStyleBackColor = false;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.BackColor = System.Drawing.Color.White;
            this.rdb1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(116, 121);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(170, 19);
            this.rdb1.TabIndex = 147;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Código del empleado";
            this.rdb1.UseVisualStyleBackColor = false;
            // 
            // ptb1
            // 
            this.ptb1.Image = global::OSADY.Properties.Resources.LOGO_KODO1;
            this.ptb1.Location = new System.Drawing.Point(12, 12);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(153, 70);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 151;
            this.ptb1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::OSADY.Properties.Resources.Volver;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(582, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 44);
            this.button1.TabIndex = 152;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 203;
            this.label1.Text = "CONSULTAR DOTACION";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightCoral;
            this.btn3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(307, 349);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 42);
            this.btn3.TabIndex = 204;
            this.btn3.Text = "Consultar dotación";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.White;
            this.lblhora.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(304, 27);
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
            // P_GestionDotacionSCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OSADY.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 425);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_GestionDotacionSCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P_GestionDotacionSCR";
            this.Load += new System.EventHandler(this.P_GestionDotacionSCR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
    }
}