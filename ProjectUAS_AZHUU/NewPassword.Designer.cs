﻿namespace ProjectUAS_AZHUU
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
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(557, 375);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(16, 23);
            this.labError.TabIndex = 39;
            this.labError.Text = "-";
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(13, 17);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(29, 23);
            this.butBack.TabIndex = 38;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // butContinue
            // 
            this.butContinue.Location = new System.Drawing.Point(599, 413);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(75, 23);
            this.butContinue.TabIndex = 37;
            this.butContinue.Text = "CONTINUE";
            this.butContinue.UseVisualStyleBackColor = true;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Location = new System.Drawing.Point(437, 289);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(402, 20);
            this.tbNoTelp.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 44);
            this.label2.TabIndex = 34;
            this.label2.Text = "New Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(437, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Confirm New Password :";
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butContinue);
            this.Controls.Add(this.tbNoTelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.Load += new System.EventHandler(this.NewPassword_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}