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
    public partial class ForgotPasswordNoTelp : Form
    {
        public ForgotPasswordNoTelp()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;
        int cekemail = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbNoTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void butContinue_Click(object sender, EventArgs e)
        {
            ForgotPasswordEmail fe = new ForgotPasswordEmail();
            sqlConnect = new MySqlConnection(connectString);
            DataTable masuk1 = new DataTable();
            sqlQuery = "select * from user_azhuu where USER_TELP  = '" + tbNoTelp.Text + "' and USER_EMAIL = '" +fe.emailforgot+ "' ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masuk1);

            if (masuk1.Rows.Count == 0)
            {
                labError.Text = "nomor telfon salah";
            }
            else
            {
                var pwnew = new NewPassword();
                pwnew.ShowDialog();
            }

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            var pwnotelp = new ForgotPasswordEmail();
            pwnotelp.ShowDialog();
        }

        private void ForgotPasswordNoTelp_Load(object sender, EventArgs e)
        {

        }
    }
}
