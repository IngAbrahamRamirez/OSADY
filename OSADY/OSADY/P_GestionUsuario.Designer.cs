namespace OSADY
{
    partial class P_GestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_GestionUsuario));
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightCoral;
            this.btn3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(354, 528);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 42);
            this.btn3.TabIndex = 63;
            this.btn3.Text = "Consultar usuario";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightCoral;
            this.btn2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(354, 528);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(103, 42);
            this.btn2.TabIndex = 62;
            this.btn2.Text = "Actualizar usuario";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(256, 484);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(52, 15);
            this.lbl5.TabIndex = 60;
            this.lbl5.Text = "Cargo:";
            this.lbl5.Visible = false;
            // 
            // cmb1
            // 
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Gerente Administrativo",
            "Recursos Humanos",
            "Secretaria"});
            this.cmb1.Location = new System.Drawing.Point(314, 478);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(228, 21);
            this.cmb1.TabIndex = 3;
            this.cmb1.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(167, 410);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(141, 15);
            this.lbl3.TabIndex = 58;
            this.lbl3.Text = "Correo electronico:";
            this.lbl3.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(314, 405);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(228, 20);
            this.txt2.TabIndex = 1;
            this.txt2.Visible = false;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            this.txt2.Leave += new System.EventHandler(this.txt2_Leave);
            // 
            // ptb1
            // 
            this.ptb1.Image = global::OSADY.Properties.Resources.LOGO_KODO1;
            this.ptb1.Location = new System.Drawing.Point(12, 41);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(153, 70);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 53;
            this.ptb1.TabStop = false;
            this.ptb1.Visible = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightCoral;
            this.btn1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(354, 528);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 42);
            this.btn1.TabIndex = 47;
            this.btn1.Text = "Crear usuario";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Visible = false;
            // 
            // ptb2
            // 
            this.ptb2.Image = global::OSADY.Properties.Resources.LOGO_KODO1;
            this.ptb2.Location = new System.Drawing.Point(225, 189);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(317, 171);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb2.TabIndex = 56;
            this.ptb2.TabStop = false;
            this.ptb2.Click += new System.EventHandler(this.ptb2_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(189, 189);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(403, 194);
            this.dgv1.TabIndex = 61;
            this.dgv1.Visible = false;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton1,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 25);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::OSADY.Properties.Resources.Volver;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Regresar";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::OSADY.Properties.Resources.Usuario_kodo2;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Actualizar usuario";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::OSADY.Properties.Resources.Usuario_Kodo3;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Consultar usuario";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.ToolTipText = "Eliminar usuario";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::OSADY.Properties.Resources.Usuario_kodo1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Activar usuario";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.ToolTipText = "Salir";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 133;
            this.label1.Text = "GESTIÓN USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.BackColor = System.Drawing.Color.White;
            this.rdb1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(215, 92);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(145, 19);
            this.rdb1.TabIndex = 134;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Cargo del usuario";
            this.rdb1.UseVisualStyleBackColor = false;
            this.rdb1.Visible = false;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.BackColor = System.Drawing.Color.White;
            this.rdb2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.Location = new System.Drawing.Point(215, 115);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(151, 19);
            this.rdb2.TabIndex = 135;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Correo del usuario";
            this.rdb2.UseVisualStyleBackColor = false;
            this.rdb2.Visible = false;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(467, 115);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(199, 20);
            this.txt6.TabIndex = 137;
            this.txt6.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(478, 96);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(177, 15);
            this.lbl6.TabIndex = 138;
            this.lbl6.Text = "Ingrese el dato a validar:";
            this.lbl6.Visible = false;
            this.lbl6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(314, 442);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(228, 20);
            this.txt3.TabIndex = 2;
            this.txt3.Visible = false;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.White;
            this.lbl7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(174, 447);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(134, 15);
            this.lbl7.TabIndex = 140;
            this.lbl7.Text = "Numero de cedula:";
            this.lbl7.Visible = false;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.BackColor = System.Drawing.Color.White;
            this.rdb3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3.Location = new System.Drawing.Point(215, 140);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(188, 19);
            this.rdb3.TabIndex = 143;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "N° de cedula del usuario";
            this.rdb3.UseVisualStyleBackColor = false;
            this.rdb3.Visible = false;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightCoral;
            this.btn4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(354, 528);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(103, 42);
            this.btn4.TabIndex = 148;
            this.btn4.Text = "Eliminar usuario";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Visible = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightCoral;
            this.btn5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(354, 528);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(103, 42);
            this.btn5.TabIndex = 149;
            this.btn5.Text = "Activar usuario";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Visible = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // cmb2
            // 
            this.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "Gerente Administrativo",
            "Recursos Humanos",
            "Secretaria"});
            this.cmb2.Location = new System.Drawing.Point(453, 115);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(228, 21);
            this.cmb2.TabIndex = 150;
            this.cmb2.Visible = false;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.White;
            this.lblhora.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(581, 9);
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
            // P_GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OSADY.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 632);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cmb2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_GestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P_GestionUsuario";
            this.Load += new System.EventHandler(this.P_GestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;

    }
}