using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectUAS_AZHUU
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        string birthdate = "0000-00-00";
        string gender = "";

        

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void InitializeMyControl()
        {
            tboxPassword.PasswordChar = '*';
            tboxConfirmPassword.PasswordChar = '*';
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);


                DataTable dtcekemail = new DataTable();
                sqlQuery = "select user_email from user_azhuu where user_email = '"+tboxEmail.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtcekemail);

                int ijinregister = 1;
                if(rbutMale.Checked == true)
                {
                    gender = "M";
                }
                else if(rbutFemale.Checked == true)
                {
                    gender = "F";
                }

                if (tboxNIK.Text == "" || tboxFullName.Text == "" || tboxEmail.Text == "" || tboxPhone.Text == "" || tboxPassword.Text == "" || tboxConfirmPassword.Text == "" || gender == "" || birthdate == "0000-00-00")
                {
                    labError.Text = "ada data yang kosong!";
                    ijinregister = 0;
                }
                else if(dtcekemail.Rows.Count == 1)
                {
                    labError.Text = "Email sudah terdaftar!";
                    ijinregister = 0;
                }
                else if (tboxPassword.Text != tboxConfirmPassword.Text)
                {
                    labError.Text = "Password doesn't Match!";
                    ijinregister = 0;
                }

                if(ijinregister == 1)
                {
                    sqlQuery = "insert into user_azhuu values ('"+tboxNIK.Text+"','"+tboxFullName.Text+"','0','"+birthdate+"','"+gender.ToString()+"','"+tboxEmail.Text+"','"+tboxConfirmPassword.Text+"','"+tboxPhone.Text+"','0')";
                    
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("selamat, sudah terdaftar!");
                    HomePage.nikkk = tboxNIK.Text;
                    


                    //lempar ke profile
                    this.Hide();
                    var formprifil = new Profile();
                    formprifil.ShowDialog();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void tboxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ini code biar yg masuk angka doang
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        
        private void tboxPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InitializeMyControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InitializeMyControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labSignin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var formsignin = new Sign_In();
                formsignin.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                birthdate = dtpBirthdate.Value.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxNIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void butRegister_MouseHover(object sender, EventArgs e)
        {

            butRegister.BackColor = Color.Yellow;
        }
    }
}
