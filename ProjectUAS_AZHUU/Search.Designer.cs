namespace ProjectUAS_AZHUU
{
    partial class Search
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
            this.dgvRute = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbutKe = new System.Windows.Forms.RadioButton();
            this.rbutDari = new System.Windows.Forms.RadioButton();
            this.butCari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDariKe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxHalte = new System.Windows.Forms.ComboBox();
            this.cboxAirport = new System.Windows.Forms.ComboBox();
            this.dtpTanggalCari = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRute
            // 
            this.dgvRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRute.Location = new System.Drawing.Point(104, 269);
            this.dgvRute.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRute.Name = "dgvRute";
            this.dgvRute.RowHeadersWidth = 51;
            this.dgvRute.RowTemplate.Height = 24;
            this.dgvRute.Size = new System.Drawing.Size(1083, 388);
            this.dgvRute.TabIndex = 1;
            this.dgvRute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRute_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbutKe);
            this.panel1.Controls.Add(this.rbutDari);
            this.panel1.Controls.Add(this.butCari);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelDariKe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboxHalte);
            this.panel1.Controls.Add(this.cboxAirport);
            this.panel1.Controls.Add(this.dtpTanggalCari);
            this.panel1.Location = new System.Drawing.Point(154, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 180);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Airport";
            // 
            // rbutKe
            // 
            this.rbutKe.AutoSize = true;
            this.rbutKe.Location = new System.Drawing.Point(135, 12);
            this.rbutKe.Name = "rbutKe";
            this.rbutKe.Size = new System.Drawing.Size(38, 17);
            this.rbutKe.TabIndex = 23;
            this.rbutKe.TabStop = true;
            this.rbutKe.Text = "Ke";
            this.rbutKe.UseVisualStyleBackColor = true;
            this.rbutKe.CheckedChanged += new System.EventHandler(this.rbutKe_CheckedChanged);
            // 
            // rbutDari
            // 
            this.rbutDari.AutoSize = true;
            this.rbutDari.Location = new System.Drawing.Point(46, 12);
            this.rbutDari.Name = "rbutDari";
            this.rbutDari.Size = new System.Drawing.Size(44, 17);
            this.rbutDari.TabIndex = 22;
            this.rbutDari.TabStop = true;
            this.rbutDari.Text = "Dari";
            this.rbutDari.UseVisualStyleBackColor = true;
            this.rbutDari.CheckedChanged += new System.EventHandler(this.rbutDari_CheckedChanged);
            // 
            // butCari
            // 
            this.butCari.BackColor = System.Drawing.Color.Yellow;
            this.butCari.Location = new System.Drawing.Point(455, 119);
            this.butCari.Margin = new System.Windows.Forms.Padding(2);
            this.butCari.Name = "butCari";
            this.butCari.Size = new System.Drawing.Size(136, 28);
            this.butCari.TabIndex = 21;
            this.butCari.Text = "Cari";
            this.butCari.UseVisualStyleBackColor = false;
            this.butCari.Click += new System.EventHandler(this.butCari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(385, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tanggal :";
            // 
            // labelDariKe
            // 
            this.labelDariKe.AutoSize = true;
            this.labelDariKe.BackColor = System.Drawing.Color.Transparent;
            this.labelDariKe.Location = new System.Drawing.Point(45, 103);
            this.labelDariKe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDariKe.Name = "labelDariKe";
            this.labelDariKe.Size = new System.Drawing.Size(26, 13);
            this.labelDariKe.TabIndex = 18;
            this.labelDariKe.Text = "Ke :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Airport : ";
            // 
            // cboxHalte
            // 
            this.cboxHalte.FormattingEnabled = true;
            this.cboxHalte.Location = new System.Drawing.Point(42, 119);
            this.cboxHalte.Margin = new System.Windows.Forms.Padding(2);
            this.cboxHalte.Name = "cboxHalte";
            this.cboxHalte.Size = new System.Drawing.Size(182, 21);
            this.cboxHalte.TabIndex = 14;
            // 
            // cboxAirport
            // 
            this.cboxAirport.FormattingEnabled = true;
            this.cboxAirport.Location = new System.Drawing.Point(42, 67);
            this.cboxAirport.Margin = new System.Windows.Forms.Padding(2);
            this.cboxAirport.Name = "cboxAirport";
            this.cboxAirport.Size = new System.Drawing.Size(278, 21);
            this.cboxAirport.TabIndex = 13;
            this.cboxAirport.SelectedIndexChanged += new System.EventHandler(this.cboxAirport_SelectedIndexChanged);
            // 
            // dtpTanggalCari
            // 
            this.dtpTanggalCari.Location = new System.Drawing.Point(385, 68);
            this.dtpTanggalCari.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTanggalCari.Name = "dtpTanggalCari";
            this.dtpTanggalCari.Size = new System.Drawing.Size(206, 20);
            this.dtpTanggalCari.TabIndex = 16;
            this.dtpTanggalCari.ValueChanged += new System.EventHandler(this.dtpTanggalCari_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1265, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRute);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDariKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxHalte;
        private System.Windows.Forms.ComboBox cboxAirport;
        private System.Windows.Forms.DateTimePicker dtpTanggalCari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbutKe;
        private System.Windows.Forms.RadioButton rbutDari;
    }
}