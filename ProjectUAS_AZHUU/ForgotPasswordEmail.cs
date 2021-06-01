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
    public partial class ForgotPasswordEmail : Form
    {
        public ForgotPasswordEmail()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;
        int cekemail = 0;


        private void ForgotPasswordEmail_Load(object sender, EventArgs e)
        {

        }

        private void butContinue_Click(object sender, EventArgs e)
        {
            
            sqlConnect = new MySqlConnection(connectString);
            DataTable masuk = new DataTable();
            sqlQuery = "select user_email from user_azhuu where user_email = '" + tbEmail.Text + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masuk);


            if (cekemail == 0)
            {
                labError.Text = "Email Tidak Terdaftar!";
            }
            else
            {
                var pwnotelp = new ForgotPasswordNoTelp();
                pwnotelp.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pwnotelp1 = new Sign_In();
            pwnotelp1.ShowDialog();
        }
    }
}
