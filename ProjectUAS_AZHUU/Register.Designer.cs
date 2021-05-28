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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register for Free";
            // 
            // tboxFullName
            // 
            this.tboxFullName.Location = new System.Drawing.Point(548, 133);
            this.tboxFullName.Name = "tboxFullName";
            this.tboxFullName.Size = new System.Drawing.Size(289, 20);
            this.tboxFullName.TabIndex = 1;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(548, 185);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(289, 20);
            this.tboxEmail.TabIndex = 2;
            // 
            // tboxPhone
            // 
            this.tboxPhone.Location = new System.Drawing.Point(548, 239);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(289, 20);
            this.tboxPhone.TabIndex = 3;
            this.tboxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPhone_KeyPress);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(548, 296);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(289, 20);
            this.tboxPassword.TabIndex = 4;
            this.tboxPassword.TextChanged += new System.EventHandler(this.tboxPassword_TextChanged);
            // 
            // tboxConfirmPassword
            // 
            this.tboxConfirmPassword.Location = new System.Drawing.Point(548, 358);
            this.tboxConfirmPassword.Name = "tboxConfirmPassword";
            this.tboxConfirmPassword.Size = new System.Drawing.Size(289, 20);
            this.tboxConfirmPassword.TabIndex = 5;
            this.tboxConfirmPassword.TextChanged += new System.EventHandler(this.tboxConfirmPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirm Password";
            // 
            // rbutMale
            // 
            this.rbutMale.AutoSize = true;
            this.rbutMale.Location = new System.Drawing.Point(559, 415);
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
            this.rbutFemale.Location = new System.Drawing.Point(723, 415);
            this.rbutFemale.Name = "rbutFemale";
            this.rbutFemale.Size = new System.Drawing.Size(59, 17);
            this.rbutFemale.TabIndex = 12;
            this.rbutFemale.TabStop = true;
            this.rbutFemale.Text = "Female";
            this.rbutFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(548, 480);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(289, 20);
            this.dtpBirthdate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birthdate";
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(723, 571);
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
            this.labError.Location = new System.Drawing.Point(545, 541);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(10, 13);
            this.labError.TabIndex = 16;
            this.labError.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Already have account? Sign in";
            // 
            // labSignin
            // 
            this.labSignin.AutoSize = true;
            this.labSignin.ForeColor = System.Drawing.Color.DarkOrange;
            this.labSignin.Location = new System.Drawing.Point(159, 660);
            this.labSignin.Name = "labSignin";
            this.labSignin.Size = new System.Drawing.Size(30, 13);
            this.labSignin.TabIndex = 18;
            this.labSignin.Text = "Here";
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
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}

