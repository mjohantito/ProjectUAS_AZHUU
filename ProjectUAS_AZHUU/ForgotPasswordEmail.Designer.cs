namespace ProjectUAS_AZHUU
{
    partial class ForgotPasswordEmail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.butContinue = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 44);
            this.label2.TabIndex = 22;
            this.label2.Text = "Forgot Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "MASUKAN EMAIL";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(436, 284);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(402, 20);
            this.tbEmail.TabIndex = 24;
            // 
            // butContinue
            // 
            this.butContinue.Location = new System.Drawing.Point(602, 350);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(75, 23);
            this.butContinue.TabIndex = 25;
            this.butContinue.Text = "CONTINUE";
            this.butContinue.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(556, 307);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(16, 23);
            this.labError.TabIndex = 27;
            this.labError.Text = "-";
            // 
            // ForgotPasswordEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butContinue);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ForgotPasswordEmail";
            this.Text = "ForgotPasswordEmail";
            this.Load += new System.EventHandler(this.ForgotPasswordEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button butContinue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labError;
    }
}