﻿namespace ProjectUAS_AZHUU
{
    partial class Sign_In
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
            this.label3 = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.butSignIn = new System.Windows.Forms.Button();
            this.labRegister = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labError = new System.Windows.Forms.Label();
            this.butForgotPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(816, 227);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(289, 20);
            this.tboxEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(816, 268);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(289, 20);
            this.tboxPassword.TabIndex = 10;
            // 
            // butSignIn
            // 
            this.butSignIn.Location = new System.Drawing.Point(894, 334);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(211, 25);
            this.butSignIn.TabIndex = 16;
            this.butSignIn.Text = "Sign-In";
            this.butSignIn.UseVisualStyleBackColor = true;
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // labRegister
            // 
            this.labRegister.AutoSize = true;
            this.labRegister.ForeColor = System.Drawing.Color.DarkOrange;
            this.labRegister.Location = new System.Drawing.Point(150, 660);
            this.labRegister.Name = "labRegister";
            this.labRegister.Size = new System.Drawing.Size(30, 13);
            this.labRegister.TabIndex = 20;
            this.labRegister.Text = "Here";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Don\'t have account? Sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 44);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sign - In";
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(813, 308);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(10, 13);
            this.labError.TabIndex = 22;
            this.labError.Text = "-";
            // 
            // butForgotPass
            // 
            this.butForgotPass.Location = new System.Drawing.Point(894, 374);
            this.butForgotPass.Name = "butForgotPass";
            this.butForgotPass.Size = new System.Drawing.Size(211, 23);
            this.butForgotPass.TabIndex = 23;
            this.butForgotPass.Text = "Forgot Password";
            this.butForgotPass.UseVisualStyleBackColor = true;
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.butForgotPass);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labRegister);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxEmail);
            this.Name = "Sign_In";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Sign_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button butSignIn;
        private System.Windows.Forms.Label labRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Button butForgotPass;
    }
}