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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxFullName
            // 
            this.tboxFullName.Location = new System.Drawing.Point(197, 300);
            this.tboxFullName.Margin = new System.Windows.Forms.Padding(4);
            this.tboxFullName.Name = "tboxFullName";
            this.tboxFullName.Size = new System.Drawing.Size(236, 22);
            this.tboxFullName.TabIndex = 1;
            this.tboxFullName.TextChanged += new System.EventHandler(this.tboxFullName_TextChanged);
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(197, 364);
            this.tboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(236, 22);
            this.tboxEmail.TabIndex = 2;
            this.tboxEmail.TextChanged += new System.EventHandler(this.tboxEmail_TextChanged);
            // 
            // tboxPhone
            // 
            this.tboxPhone.Location = new System.Drawing.Point(197, 430);
            this.tboxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(236, 22);
            this.tboxPhone.TabIndex = 3;
            this.tboxPhone.TextChanged += new System.EventHandler(this.tboxPhone_TextChanged);
            this.tboxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPhone_KeyPress);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(197, 500);
            this.tboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(236, 22);
            this.tboxPassword.TabIndex = 4;
            this.tboxPassword.TextChanged += new System.EventHandler(this.tboxPassword_TextChanged);
            // 
            // tboxConfirmPassword
            // 
            this.tboxConfirmPassword.Location = new System.Drawing.Point(197, 577);
            this.tboxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tboxConfirmPassword.Name = "tboxConfirmPassword";
            this.tboxConfirmPassword.Size = new System.Drawing.Size(236, 22);
            this.tboxConfirmPassword.TabIndex = 5;
            this.tboxConfirmPassword.TextChanged += new System.EventHandler(this.tboxConfirmPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 433);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 505);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 580);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirm Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rbutMale
            // 
            this.rbutMale.AutoSize = true;
            this.rbutMale.Location = new System.Drawing.Point(197, 623);
            this.rbutMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbutMale.Name = "rbutMale";
            this.rbutMale.Size = new System.Drawing.Size(59, 21);
            this.rbutMale.TabIndex = 11;
            this.rbutMale.TabStop = true;
            this.rbutMale.Text = "Male";
            this.rbutMale.UseVisualStyleBackColor = true;
            this.rbutMale.CheckedChanged += new System.EventHandler(this.rbutMale_CheckedChanged);
            // 
            // rbutFemale
            // 
            this.rbutFemale.AutoSize = true;
            this.rbutFemale.Location = new System.Drawing.Point(358, 623);
            this.rbutFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbutFemale.Name = "rbutFemale";
            this.rbutFemale.Size = new System.Drawing.Size(75, 21);
            this.rbutFemale.TabIndex = 12;
            this.rbutFemale.TabStop = true;
            this.rbutFemale.Text = "Female";
            this.rbutFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(197, 665);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(236, 22);
            this.dtpBirthdate.TabIndex = 13;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 665);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birthdate";
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(244, 720);
            this.butRegister.Margin = new System.Windows.Forms.Padding(4);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(149, 42);
            this.butRegister.TabIndex = 15;
            this.butRegister.Text = "Register";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(727, 666);
            this.labError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(13, 17);
            this.labError.TabIndex = 16;
            this.labError.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 788);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Already have account? Sign in";
            // 
            // labSignin
            // 
            this.labSignin.AutoSize = true;
            this.labSignin.ForeColor = System.Drawing.Color.DarkOrange;
            this.labSignin.Location = new System.Drawing.Point(211, 789);
            this.labSignin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSignin.Name = "labSignin";
            this.labSignin.Size = new System.Drawing.Size(39, 17);
            this.labSignin.TabIndex = 18;
            this.labSignin.Text = "Here";
            this.labSignin.Click += new System.EventHandler(this.labSignin_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(20, 31);
            this.butBack.Margin = new System.Windows.Forms.Padding(4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(37, 28);
            this.butBack.TabIndex = 19;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectUAS_AZHUU.Properties.Resources.NCAA_Twitter_Post1;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1719, 852);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_AZHUU.Properties.Resources.azuuuuuu;
            this.pictureBox1.Location = new System.Drawing.Point(124, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1685, 838);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

