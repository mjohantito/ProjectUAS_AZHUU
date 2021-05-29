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
                // cari di database emailnya
                // cek password 

                // if email ga ada di database, messagebox email belum terdaftar, ganti label, silahkan register
                // if password tidak match, hanya ganti label
                // else -> di lempar ke homepage yg sudah log-in

                int cekemail = 0;
                int cekpassword = 0;

                sqlConnect = new MySqlConnection(connectString);

                DataTable dtLogin = new DataTable();
                sqlQuery = "select user_email from user_azhuu where user_email = '"+tboxEmail.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);


                if(dtLogin.Rows.Count == 1) // masih salah
                {
                    cekemail = 1;
                }

                DataTable dtpassword = new DataTable();
                sqlQuery = "select user_email, user_password from user_azhuu where user_password = '" + tboxPassword.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpassword);

                if(dtpassword.Rows.Count == 1) // masih salahhh
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
                    //lempar ke form homepage
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
