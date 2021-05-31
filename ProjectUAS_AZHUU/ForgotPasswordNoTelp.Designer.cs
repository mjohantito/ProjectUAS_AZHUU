namespace ProjectUAS_AZHUU
{
    partial class ForgotPasswordNoTelp
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
            this.labError = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.butContinue = new System.Windows.Forms.Button();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(737, 619);
            this.labError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(20, 29);
            this.labError.TabIndex = 33;
            this.labError.Text = "-";
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(12, 16);
            this.butBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(39, 28);
            this.butBack.TabIndex = 32;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // butContinue
            // 
            this.butContinue.Location = new System.Drawing.Point(799, 672);
            this.butContinue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(100, 28);
            this.butContinue.TabIndex = 31;
            this.butContinue.Text = "CONTINUE";
            this.butContinue.UseVisualStyleBackColor = true;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Location = new System.Drawing.Point(577, 591);
            this.tbNoTelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(535, 22);
            this.tbNoTelp.TabIndex = 30;
            this.tbNoTelp.TextChanged += new System.EventHandler(this.tbNoTelp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 559);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "MASUKAN NO TELP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 55);
            this.label2.TabIndex = 28;
            this.label2.Text = "Forgot Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources.phone_number;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1713, 832);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPasswordNoTelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butContinue);
            this.Controls.Add(this.tbNoTelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForgotPasswordNoTelp";
            this.Text = "ForgotPasswordNoTelp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butContinue;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}