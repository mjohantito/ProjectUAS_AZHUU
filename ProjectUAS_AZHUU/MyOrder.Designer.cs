
namespace ProjectUAS_AZHUU
{
    partial class FormMyOrder
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
            this.labelMyOrder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDetailOrder = new System.Windows.Forms.Label();
            this.labelBookingID = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelTotalPembayaran = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelJam = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelFromTo = new System.Windows.Forms.Label();
            this.labelPenumpang = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvMyOrder = new System.Windows.Forms.DataGridView();
            this.dgvPenumpang = new System.Windows.Forms.DataGridView();
            this.butInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenumpang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMyOrder
            // 
            this.labelMyOrder.AutoSize = true;
            this.labelMyOrder.BackColor = System.Drawing.Color.White;
            this.labelMyOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyOrder.Location = new System.Drawing.Point(75, 60);
            this.labelMyOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyOrder.Name = "labelMyOrder";
            this.labelMyOrder.Size = new System.Drawing.Size(126, 31);
            this.labelMyOrder.TabIndex = 0;
            this.labelMyOrder.Text = "My Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 7;
            // 
            // labelDetailOrder
            // 
            this.labelDetailOrder.AutoSize = true;
            this.labelDetailOrder.BackColor = System.Drawing.Color.White;
            this.labelDetailOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailOrder.Location = new System.Drawing.Point(465, 46);
            this.labelDetailOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetailOrder.Name = "labelDetailOrder";
            this.labelDetailOrder.Size = new System.Drawing.Size(160, 31);
            this.labelDetailOrder.TabIndex = 16;
            this.labelDetailOrder.Text = "Detail Order";
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.BackColor = System.Drawing.Color.White;
            this.labelBookingID.Location = new System.Drawing.Point(747, 63);
            this.labelBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(66, 13);
            this.labelBookingID.TabIndex = 17;
            this.labelBookingID.Text = "Booking ID :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(805, 63);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(61, 13);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "874512335";
            // 
            // labelTotalPembayaran
            // 
            this.labelTotalPembayaran.AutoSize = true;
            this.labelTotalPembayaran.BackColor = System.Drawing.Color.White;
            this.labelTotalPembayaran.Location = new System.Drawing.Point(470, 102);
            this.labelTotalPembayaran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPembayaran.Name = "labelTotalPembayaran";
            this.labelTotalPembayaran.Size = new System.Drawing.Size(93, 13);
            this.labelTotalPembayaran.TabIndex = 21;
            this.labelTotalPembayaran.Text = "Total Pembayaran";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(472, 136);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(68, 13);
            this.labelTotal.TabIndex = 22;
            this.labelTotal.Text = "IDR 978.000";
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.BackColor = System.Drawing.Color.White;
            this.labelJam.Location = new System.Drawing.Point(472, 220);
            this.labelJam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(58, 13);
            this.labelJam.TabIndex = 24;
            this.labelJam.Text = "16.54 WIB";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.BackColor = System.Drawing.Color.White;
            this.labelTanggal.Location = new System.Drawing.Point(478, 253);
            this.labelTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(40, 13);
            this.labelTanggal.TabIndex = 25;
            this.labelTanggal.Text = "15 Ags";
            // 
            // labelFromTo
            // 
            this.labelFromTo.AutoSize = true;
            this.labelFromTo.BackColor = System.Drawing.Color.White;
            this.labelFromTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromTo.Location = new System.Drawing.Point(619, 229);
            this.labelFromTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFromTo.Name = "labelFromTo";
            this.labelFromTo.Size = new System.Drawing.Size(90, 24);
            this.labelFromTo.TabIndex = 29;
            this.labelFromTo.Text = "From To";
            // 
            // labelPenumpang
            // 
            this.labelPenumpang.AutoSize = true;
            this.labelPenumpang.BackColor = System.Drawing.Color.White;
            this.labelPenumpang.Location = new System.Drawing.Point(478, 346);
            this.labelPenumpang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPenumpang.Name = "labelPenumpang";
            this.labelPenumpang.Size = new System.Drawing.Size(64, 13);
            this.labelPenumpang.TabIndex = 31;
            this.labelPenumpang.Text = "Penumpang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources._1234124;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // dgvMyOrder
            // 
            this.dgvMyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrder.Location = new System.Drawing.Point(59, 102);
            this.dgvMyOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMyOrder.Name = "dgvMyOrder";
            this.dgvMyOrder.RowHeadersWidth = 51;
            this.dgvMyOrder.RowTemplate.Height = 24;
            this.dgvMyOrder.Size = new System.Drawing.Size(279, 397);
            this.dgvMyOrder.TabIndex = 37;
            this.dgvMyOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyOrder_CellClick);
            // 
            // dgvPenumpang
            // 
            this.dgvPenumpang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenumpang.Location = new System.Drawing.Point(481, 377);
            this.dgvPenumpang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPenumpang.Name = "dgvPenumpang";
            this.dgvPenumpang.RowHeadersWidth = 51;
            this.dgvPenumpang.RowTemplate.Height = 24;
            this.dgvPenumpang.Size = new System.Drawing.Size(353, 123);
            this.dgvPenumpang.TabIndex = 38;
            // 
            // butInvoice
            // 
            this.butInvoice.BackColor = System.Drawing.Color.Yellow;
            this.butInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvoice.Location = new System.Drawing.Point(736, 302);
            this.butInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.butInvoice.Name = "butInvoice";
            this.butInvoice.Size = new System.Drawing.Size(140, 42);
            this.butInvoice.TabIndex = 39;
            this.butInvoice.Text = "Invoice";
            this.butInvoice.UseVisualStyleBackColor = false;
            this.butInvoice.Click += new System.EventHandler(this.butInvoice_Click);
            // 
            // FormMyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.butInvoice);
            this.Controls.Add(this.dgvPenumpang);
            this.Controls.Add(this.dgvMyOrder);
            this.Controls.Add(this.labelPenumpang);
            this.Controls.Add(this.labelFromTo);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelJam);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTotalPembayaran);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelBookingID);
            this.Controls.Add(this.labelDetailOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMyOrder);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMyOrder";
            this.Text = "My Order";
            this.Load += new System.EventHandler(this.FormMyOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenumpang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDetailOrder;
        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTotalPembayaran;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelFromTo;
        private System.Windows.Forms.Label labelPenumpang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMyOrder;
        private System.Windows.Forms.DataGridView dgvPenumpang;
        private System.Windows.Forms.Button butInvoice;
    }
}