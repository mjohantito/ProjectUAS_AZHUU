namespace ProjectUAS_AZHUU
{
    partial class Register
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
            this.tboxFullName = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbutMale = new System.Windows.Forms.RadioButton();
            this.rbutFemale = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.butRegister = new System.Windows.Forms.Button();
            this.labError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labSignin = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNIK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxFullName
            // 
            this.tboxFullName.Location = new System.Drawing.Point(148, 320);
            this.tboxFullName.Name = "tboxFullName";
            this.tboxFullName.Size = new System.Drawing.Size(178, 20);
            this.tboxFullName.TabIndex = 1;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(148, 356);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(178, 20);
            this.tboxEmail.TabIndex = 2;
            // 
            // tboxPhone
            // 
            this.tboxPhone.Location = new System.Drawing.Point(148, 393);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(178, 20);
            this.tboxPhone.TabIndex = 3;
            this.tboxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPhone_KeyPress);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(148, 429);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(178, 20);
            this.tboxPassword.TabIndex = 4;
            this.tboxPassword.TextChanged += new System.EventHandler(this.tboxPassword_TextChanged);
            // 
            // tboxConfirmPassword
            // 
            this.tboxConfirmPassword.Location = new System.Drawing.Point(148, 469);
            this.tboxConfirmPassword.Name = "tboxConfirmPassword";
            this.tboxConfirmPassword.Size = new System.Drawing.Size(178, 20);
            this.tboxConfirmPassword.TabIndex = 5;
            this.tboxConfirmPassword.TextChanged += new System.EventHandler(this.tboxConfirmPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirm Password";
            // 
            // rbutMale
            // 
            this.rbutMale.AutoSize = true;
            this.rbutMale.Location = new System.Drawing.Point(148, 506);
            this.rbutMale.Name = "rbutMale";
            this.rbutMale.Size = new System.Drawing.Size(48, 17);
            this.rbutMale.TabIndex = 11;
            this.rbutMale.TabStop = true;
            this.rbutMale.Text = "Male";
            this.rbutMale.UseVisualStyleBackColor = true;
            // 
            // rbutFemale
            // 
            this.rbutFemale.AutoSize = true;
            this.rbutFemale.Location = new System.Drawing.Point(268, 506);
            this.rbutFemale.Name = "rbutFemale";
            this.rbutFemale.Size = new System.Drawing.Size(59, 17);
            this.rbutFemale.TabIndex = 12;
            this.rbutFemale.TabStop = true;
            this.rbutFemale.Text = "Female";
            this.rbutFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(148, 540);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(178, 20);
            this.dtpBirthdate.TabIndex = 13;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birthdate";
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(183, 594);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(112, 34);
            this.butRegister.TabIndex = 15;
            this.butRegister.Text = "Register";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(145, 574);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(10, 13);
            this.labError.TabIndex = 16;
            this.labError.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 640);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Already have account? Sign in";
            // 
            // labSignin
            // 
            this.labSignin.AutoSize = true;
            this.labSignin.ForeColor = System.Drawing.Color.DarkOrange;
            this.labSignin.Location = new System.Drawing.Point(158, 641);
            this.labSignin.Name = "labSignin";
            this.labSignin.Size = new System.Drawing.Size(30, 13);
            this.labSignin.TabIndex = 18;
            this.labSignin.Text = "Here";
            this.labSignin.Click += new System.EventHandler(this.labSignin_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(15, 25);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(28, 23);
            this.butBack.TabIndex = 19;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectUAS_AZHUU.Properties.Resources.NCAA_Twitter_Post1;
            this.pictureBox2.Location = new System.Drawing.Point(-14, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1289, 692);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources.azuuuuuu;
            this.pictureBox1.Location = new System.Drawing.Point(93, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "NIK";
            // 
            // tboxNIK
            // 
            this.tboxNIK.Location = new System.Drawing.Point(148, 283);
            this.tboxNIK.Name = "tboxNIK";
            this.tboxNIK.Size = new System.Drawing.Size(178, 20);
            this.tboxNIK.TabIndex = 22;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNIK);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.labSignin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.rbutFemale);
            this.Controls.Add(this.rbutMale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxConfirmPassword);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxPhone);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.tboxFullName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxFullName;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbutMale;
        private System.Windows.Forms.RadioButton rbutFemale;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labSignin;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNIK;
    }
}

