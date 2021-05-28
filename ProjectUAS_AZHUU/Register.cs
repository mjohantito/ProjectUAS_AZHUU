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
        string connectString = "server=localhost;uid=root;pwd=;database=premier_league;";
        string sqlQuery;

        string birthdate = "0000-00-00";

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            try
            {

                if (tboxFullName.Text == "" || tboxEmail.Text == "" || tboxPhone.Text == "" || tboxPassword.Text == "" || tboxConfirmPassword.Text == "" || rbutFemale.Checked == false || rbutMale.Checked == false || birthdate == "0000-00-00")
                {
                    MessageBox.Show("ada data yang kosong!");
                }
                else if (tboxPassword.Text != tboxConfirmPassword.Text)
                {
                    MessageBox.Show("Password doesn't Match!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void InitializeMyControl()
        {
            tboxPassword.PasswordChar = '*';
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
    }
}
