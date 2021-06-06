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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;


        private void NewPassword_Load(object sender, EventArgs e)
        {

        }

        private void butContinue_Click(object sender, EventArgs e)
        {
            if (tbpasword.Text != tbconfirm.Text)
            {
                labError.Text = " paswword tidak sama";
            }
            else
            {
                // masih belom selesai, close semua form di sebelum ini

                // ForgotPasswordEmail vt = new ForgotPasswordEmail();
                sqlConnect = new MySqlConnection(connectString);
                DataTable masuk1 = new DataTable();
                sqlQuery = "update user_azhuu set USER_PASSWORD = '" + tbpasword.Text + "' where USER_EMAIL = '" + ForgotPasswordEmail.emailforgot + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(masuk1);

                // labError.Text = " paswword sudah diganti";

                // password di password char '*';

                // lempar ke login

            }

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            var pwnotelp = new ForgotPasswordNoTelp();
            pwnotelp.ShowDialog();
        }

        private void tbpasword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbpasword.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbconfirm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbconfirm.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
