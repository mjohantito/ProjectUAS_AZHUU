namespace ProjectUAS_AZHUU
{
    partial class Homepagebelumlogin
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
            this.tujuan = new System.Windows.Forms.RadioButton();
            this.airport = new System.Windows.Forms.RadioButton();
            this.btcari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbke = new System.Windows.Forms.ComboBox();
            this.cbdari = new System.Windows.Forms.ComboBox();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.btsignin = new System.Windows.Forms.Button();
            this.btsignup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tujuan);
            this.panel1.Controls.Add(this.airport);
            this.panel1.Controls.Add(this.btcari);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbke);
            this.panel1.Controls.Add(this.cbdari);
            this.panel1.Controls.Add(this.tanggal);
            this.panel1.Location = new System.Drawing.Point(136, 311);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 173);
            this.panel1.TabIndex = 2;
            // 
            // tujuan
            // 
            this.tujuan.AutoSize = true;
            this.tujuan.Location = new System.Drawing.Point(51, 12);
            this.tujuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tujuan.Name = "tujuan";
            this.tujuan.Size = new System.Drawing.Size(84, 17);
            this.tujuan.TabIndex = 22;
            this.tujuan.TabStop = true;
            this.tujuan.Text = "Asal - Airport";
            this.tujuan.UseVisualStyleBackColor = true;
            this.tujuan.CheckedChanged += new System.EventHandler(this.tujuan_CheckedChanged);
            // 
            // airport
            // 
            this.airport.AutoSize = true;
            this.airport.Location = new System.Drawing.Point(146, 12);
            this.airport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.airport.Name = "airport";
            this.airport.Size = new System.Drawing.Size(97, 17);
            this.airport.TabIndex = 10;
            this.airport.TabStop = true;
            this.airport.Text = "Airport - Tujuan";
            this.airport.UseVisualStyleBackColor = true;
            this.airport.CheckedChanged += new System.EventHandler(this.airport_CheckedChanged);
            // 
            // btcari
            // 
            this.btcari.BackColor = System.Drawing.Color.Yellow;
            this.btcari.Location = new System.Drawing.Point(290, 89);
            this.btcari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(136, 28);
            this.btcari.TabIndex = 21;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(264, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tanggal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ke :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dari :";
            // 
            // cbke
            // 
            this.cbke.FormattingEnabled = true;
            this.cbke.Location = new System.Drawing.Point(46, 89);
            this.cbke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbke.Name = "cbke";
            this.cbke.Size = new System.Drawing.Size(182, 21);
            this.cbke.TabIndex = 14;
            // 
            // cbdari
            // 
            this.cbdari.FormattingEnabled = true;
            this.cbdari.Location = new System.Drawing.Point(46, 46);
            this.cbdari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdari.Name = "cbdari";
            this.cbdari.Size = new System.Drawing.Size(182, 21);
            this.cbdari.TabIndex = 13;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(264, 46);
            this.tanggal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(206, 20);
            this.tanggal.TabIndex = 16;
            // 
            // btsignin
            // 
            this.btsignin.BackColor = System.Drawing.Color.Yellow;
            this.btsignin.Location = new System.Drawing.Point(17, 19);
            this.btsignin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btsignin.Name = "btsignin";
            this.btsignin.Size = new System.Drawing.Size(93, 20);
            this.btsignin.TabIndex = 7;
            this.btsignin.Text = "Sign-in";
            this.btsignin.UseVisualStyleBackColor = false;
            this.btsignin.Click += new System.EventHandler(this.btsignin_Click);
            this.btsignin.MouseHover += new System.EventHandler(this.btsignin_MouseHover);
            // 
            // btsignup
            // 
            this.btsignup.BackColor = System.Drawing.Color.Yellow;
            this.btsignup.Location = new System.Drawing.Point(16, 52);
            this.btsignup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btsignup.Name = "btsignup";
            this.btsignup.Size = new System.Drawing.Size(93, 19);
            this.btsignup.TabIndex = 8;
            this.btsignup.Text = "Sign-up";
            this.btsignup.UseVisualStyleBackColor = false;
            this.btsignup.Click += new System.EventHandler(this.btsignup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btsignin);
            this.panel2.Controls.Add(this.btsignup);
            this.panel2.Location = new System.Drawing.Point(68, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 71);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources.hppppppp;
            this.pictureBox1.Location = new System.Drawing.Point(-33, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 541);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Homepagebelumlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Homepagebelumlogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Homepagebelumlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbke;
        private System.Windows.Forms.ComboBox cbdari;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btsignin;
        private System.Windows.Forms.Button btsignup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton tujuan;
        private System.Windows.Forms.RadioButton airport;
    }
}