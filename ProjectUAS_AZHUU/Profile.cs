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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                // abmil register.nikk
                cboxTitle.Items.Add("Mr.");
                cboxTitle.Items.Add("Mrs.");
                cboxTitle.Items.Add("Ms.");
                cboxTitle.SelectedIndex = -1;

                sqlConnect = new MySqlConnection(connectString);

                DataTable dtProfile = new DataTable();
                sqlQuery = "select user_nik, user_name, user_title, user_birthdate, user_gender, user_email, user_telp, user_delete from user_azhuu where user_nik = '"+HomePage.nikkk+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProfile);

                tbFullName.Text = dtProfile.Rows[0]["user_name"].ToString();
                tbEmail.Text = dtProfile.Rows[0]["user_email"].ToString();
                //birthdate
                dtpBirthdate.Value = (DateTime)dtProfile.Rows[0]["user_birthdate"];
                tbKTP.Text = dtProfile.Rows[0]["user_NIK"].ToString();
                tbHP.Text = "0"+dtProfile.Rows[0]["user_telp"].ToString();

                // delete account

                // button save enable saat ada yg berubah termasuk foto

                // change foto
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butSaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);

                DataTable dt1User = new DataTable();
                sqlQuery = "select user_nik, user_name, user_title, user_birthdate, user_gender, user_email,user_telp from user_azhuu where user_nik = '"+tbKTP.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt1User);



                if (cboxTitle.SelectedIndex == -1 || tbFullName.Text == "" || tbEmail.Text == "" || tbKTP.Text == "" || tbHP.Text == "") // data ada yang kosong
                {
                    MessageBox.Show("Data ada yang kosong!");
                }
                else if (cboxTitle.SelectedItem == dt1User.Rows[0]["user_title"] && tbFullName.Text == dt1User.Rows[0]["user_name"].ToString() && tbEmail.Text == dt1User.Rows[0]["user_name"].ToString() && tbHP.Text == dt1User.Rows[0]["user_telp"].ToString())
                {
                    MessageBox.Show("Data tidak ada yang di ubah!");
                }
                else
                {
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Data berhasil masuk!");

                    var homepage = new HomePage();
                    homepage.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
