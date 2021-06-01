namespace ProjectUAS_AZHUU
{
    partial class NewPassword
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
            this.tbpasword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbconfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(743, 722);
            this.labError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(20, 29);
            this.labError.TabIndex = 39;
            this.labError.Text = "-";
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(17, 21);
            this.butBack.Margin = new System.Windows.Forms.Padding(4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(39, 28);
            this.butBack.TabIndex = 38;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butContinue
            // 
            this.butContinue.Location = new System.Drawing.Point(799, 768);
            this.butContinue.Margin = new System.Windows.Forms.Padding(4);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(100, 28);
            this.butContinue.TabIndex = 37;
            this.butContinue.Text = "CONTINUE";
            this.butContinue.UseVisualStyleBackColor = true;
            this.butContinue.Click += new System.EventHandler(this.butContinue_Click);
            // 
            // tbpasword
            // 
            this.tbpasword.Location = new System.Drawing.Point(583, 616);
            this.tbpasword.Margin = new System.Windows.Forms.Padding(4);
            this.tbpasword.Name = "tbpasword";
            this.tbpasword.Size = new System.Drawing.Size(535, 22);
            this.tbpasword.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 584);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 55);
            this.label2.TabIndex = 34;
            this.label2.Text = "New Password";
            // 
            // tbconfirm
            // 
            this.tbconfirm.Location = new System.Drawing.Point(583, 676);
            this.tbconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.tbconfirm.Name = "tbconfirm";
            this.tbconfirm.Size = new System.Drawing.Size(535, 22);
            this.tbconfirm.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 644);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Confirm New Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources.Slate_Gray;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1685, 838);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.tbconfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butContinue);
            this.Controls.Add(this.tbpasword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.Load += new System.EventHandler(this.NewPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butContinue;
        private System.Windows.Forms.TextBox tbpasword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbconfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}