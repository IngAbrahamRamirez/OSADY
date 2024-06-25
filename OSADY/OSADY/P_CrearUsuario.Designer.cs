namespace OSADY
{
    partial class P_CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_CrearUsuario));
            this.lbl7 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.White;
            this.lbl7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(72, 148);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(134, 15);
            this.lbl7.TabIndex = 146;
            this.lbl7.Text = "Numero de cedula:";
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(212, 143);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(212, 20);
            this.txt3.TabIndex = 145;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(154, 185);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(52, 15);
            this.lbl5.TabIndex = 144;
            this.lbl5.Text = "Cargo:";
            // 
            // cmb1
            // 
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Gerente Administrativo",
            "Recursos Humanos",
            "Secretaria"});
            this.cmb1.Location = new System.Drawing.Point(212, 179);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(212, 21);
            this.cmb1.TabIndex = 1;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(65, 111);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(141, 15);
            this.lbl3.TabIndex = 142;
            this.lbl3.Text = "Correo electronico:";
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(212, 106);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(212, 20);
            this.txt2.TabIndex = 141;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightCoral;
            this.btn1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(212, 244);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 42);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Crear usuario";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ptb1
            // 
            this.ptb1.Image = global::OSADY.Properties.Resources.LOGO_KODO1;
            this.ptb1.Location = new System.Drawing.Point(12, 12);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(148, 66);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 150;
            this.ptb1.TabStop = false;
            this.ptb1.Visible = false;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.White;
            this.lblhora.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(255, 12);
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
            // P_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OSADY.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 339);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P_CrearUsuario";
            this.Load += new System.EventHandler(this.P_CrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
    }
}