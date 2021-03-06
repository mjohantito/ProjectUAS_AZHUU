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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        

        private void Sign_In_Load(object sender, EventArgs e)
        {

        }

        private void butSignIn_Click(object sender, EventArgs e)
        {
            try
            {

                int cekemail = 0;
                int cekpassword = 0;

                sqlConnect = new MySqlConnection(connectString);

                DataTable dtLogin = new DataTable();
                sqlQuery = "select user_email from user_azhuu where user_email = '"+tboxEmail.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);


                if(dtLogin.Rows.Count == 1)
                {
                    cekemail = 1;
                }

                DataTable dtpassword = new DataTable();
                sqlQuery = "select user_email, user_password from user_azhuu where user_password = '" + tboxPassword.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpassword);

                if(dtpassword.Rows.Count == 1) 
                {
                    cekpassword = 1;
                }


                if(cekemail == 0)
                {
                    labError.Text = "Email Tidak Terdaftar!";
                }
                else if (cekpassword == 0)
                {
                    labError.Text = "Password Salah!";
                }    
                else
                {
                    this.Hide();
                    DataTable dtcektitle = new DataTable();
                    sqlQuery = "select user_title,user_nik from user_azhuu where user_email = '"+tboxEmail.Text+"'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtcektitle);

                    Homepagebelumlogin.ceklogin = "sudah login";

                    HomePage.nikkk = dtcektitle.Rows[0]["user_nik"].ToString();
                    if (dtcektitle.Rows[0]["user_title"].ToString() == "0") // user title kosong, di lempar ke profile, else di lempar ke home page
                    {
                        var formprifil = new Profile();
                        formprifil.ShowDialog();
                    }
                    else
                    {
                        var formhomepage = new HomePage();
                        formhomepage.ShowDialog();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tboxPassword.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var rigistir = new Register();
                rigistir.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butForgotPass_Click(object sender, EventArgs e)
        {
            try
            {
                var firgit = new ForgotPasswordEmail();
                firgit.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
