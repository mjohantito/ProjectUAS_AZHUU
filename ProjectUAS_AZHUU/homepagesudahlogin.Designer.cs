namespace ProjectUAS_AZHUU
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbutDari = new System.Windows.Forms.RadioButton();
            this.rbutKe = new System.Windows.Forms.RadioButton();
            this.butCari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDariKe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxHalte = new System.Windows.Forms.ComboBox();
            this.cboxAirport = new System.Windows.Forms.ComboBox();
            this.dtpTanggalCari = new System.Windows.Forms.DateTimePicker();
            this.butProfile = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbutDari);
            this.panel1.Controls.Add(this.rbutKe);
            this.panel1.Controls.Add(this.butCari);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelDariKe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboxHalte);
            this.panel1.Controls.Add(this.cboxAirport);
            this.panel1.Controls.Add(this.dtpTanggalCari);
            this.panel1.Location = new System.Drawing.Point(497, 402);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 222);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(293, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Airport";
            // 
            // rbutDari
            // 
            this.rbutDari.AutoSize = true;
            this.rbutDari.Location = new System.Drawing.Point(61, 12);
            this.rbutDari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbutDari.Name = "rbutDari";
            this.rbutDari.Size = new System.Drawing.Size(55, 21);
            this.rbutDari.TabIndex = 24;
            this.rbutDari.TabStop = true;
            this.rbutDari.Text = "Dari";
            this.rbutDari.UseVisualStyleBackColor = true;
            this.rbutDari.CheckedChanged += new System.EventHandler(this.rbutDari_CheckedChanged);
            // 
            // rbutKe
            // 
            this.rbutKe.AutoSize = true;
            this.rbutKe.Location = new System.Drawing.Point(188, 12);
            this.rbutKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbutKe.Name = "rbutKe";
            this.rbutKe.Size = new System.Drawing.Size(46, 21);
            this.rbutKe.TabIndex = 23;
            this.rbutKe.TabStop = true;
            this.rbutKe.Text = "Ke";
            this.rbutKe.UseVisualStyleBackColor = true;
            this.rbutKe.CheckedChanged += new System.EventHandler(this.rbutKe_CheckedChanged);
            // 
            // butCari
            // 
            this.butCari.BackColor = System.Drawing.Color.Yellow;
            this.butCari.Location = new System.Drawing.Point(445, 145);
            this.butCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCari.Name = "butCari";
            this.butCari.Size = new System.Drawing.Size(181, 34);
            this.butCari.TabIndex = 21;
            this.butCari.Text = "Cari";
            this.butCari.UseVisualStyleBackColor = false;
            this.butCari.Click += new System.EventHandler(this.cari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(352, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tanggal :";
            // 
            // labelDariKe
            // 
            this.labelDariKe.AutoSize = true;
            this.labelDariKe.BackColor = System.Drawing.Color.Transparent;
            this.labelDariKe.Location = new System.Drawing.Point(65, 101);
            this.labelDariKe.Name = "labelDariKe";
            this.labelDariKe.Size = new System.Drawing.Size(33, 17);
            this.labelDariKe.TabIndex = 18;
            this.labelDariKe.Text = "Ke :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Airport :";
            // 
            // cboxHalte
            // 
            this.cboxHalte.FormattingEnabled = true;
            this.cboxHalte.Location = new System.Drawing.Point(61, 121);
            this.cboxHalte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxHalte.Name = "cboxHalte";
            this.cboxHalte.Size = new System.Drawing.Size(241, 24);
            this.cboxHalte.TabIndex = 14;
            // 
            // cboxAirport
            // 
            this.cboxAirport.FormattingEnabled = true;
            this.cboxAirport.Location = new System.Drawing.Point(61, 57);
            this.cboxAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAirport.Name = "cboxAirport";
            this.cboxAirport.Size = new System.Drawing.Size(241, 24);
            this.cboxAirport.TabIndex = 13;
            this.cboxAirport.SelectedIndexChanged += new System.EventHandler(this.cboxAirport_SelectedIndexChanged);
            // 
            // dtpTanggalCari
            // 
            this.dtpTanggalCari.Location = new System.Drawing.Point(352, 57);
            this.dtpTanggalCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTanggalCari.Name = "dtpTanggalCari";
            this.dtpTanggalCari.Size = new System.Drawing.Size(273, 22);
            this.dtpTanggalCari.TabIndex = 16;
            this.dtpTanggalCari.ValueChanged += new System.EventHandler(this.dtpTanggalCari_ValueChanged);
            // 
            // butProfile
            // 
            this.butProfile.BackColor = System.Drawing.Color.Yellow;
            this.butProfile.Location = new System.Drawing.Point(133, 284);
            this.butProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butProfile.Name = "butProfile";
            this.butProfile.Size = new System.Drawing.Size(181, 34);
            this.butProfile.TabIndex = 26;
            this.butProfile.Text = "Profile";
            this.butProfile.UseVisualStyleBackColor = false;
            this.butProfile.Click += new System.EventHandler(this.butProfile_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProjectUAS_AZHUU.Properties.Resources._11;
            this.pictureBox5.Location = new System.Drawing.Point(1123, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::ProjectUAS_AZHUU.Properties.Resources._1234;
            this.pictureBox3.Location = new System.Drawing.Point(795, 271);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(361, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectUAS_AZHUU.Properties.Resources._1111ssfefsef;
            this.pictureBox2.Location = new System.Drawing.Point(133, 402);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.butProfile);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDariKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxHalte;
        private System.Windows.Forms.ComboBox cboxAirport;
        private System.Windows.Forms.DateTimePicker dtpTanggalCari;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbutDari;
        private System.Windows.Forms.RadioButton rbutKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butProfile;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}