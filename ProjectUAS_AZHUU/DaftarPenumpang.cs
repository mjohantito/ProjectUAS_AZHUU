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
    public partial class DaftarPenumpang : Form
    {
        public DaftarPenumpang()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                FormCheckout formCheckout = new FormCheckout();
                formCheckout.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DaftarPenumpang_Load(object sender, EventArgs e)
        {
            try
            {
                groupBoxPenumpang1.Visible = true;
                buttonTambahPenumpang1.Visible = true;
                groupBoxPenumpang2.Visible = false;
                buttonTambahPenumpang2.Visible = false;
                groupBoxPenumpang3.Visible = false;
                buttonTambahPenumpang3.Visible = false;
                groupBoxPenumpang4.Visible = false;

                DataTable dtProfile = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProfile);

                cBoxTitleProfile.DataSource = dtProfile;
                cBoxTitleProfile.DisplayMember = "Title";
                tBoxNamaProfile.Text = dtProfile.Rows[0]["User Name"].ToString();
                tBoxEmailProfile.Text = dtProfile.Rows[0]["User Email"].ToString();
                tBoxTeleponProfile.Text = dtProfile.Rows[0]["User Telp"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTambahPenumpang2_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPenumpang1.Visible = true;
                buttonTambahPenumpang1.Visible = false;
                groupBoxPenumpang2.Visible = true;
                buttonTambahPenumpang2.Visible = false;
                groupBoxPenumpang3.Visible = true;
                buttonTambahPenumpang3.Visible = true;
                groupBoxPenumpang4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTambahPenumpang3_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPenumpang1.Visible = true;
                buttonTambahPenumpang1.Visible = false;
                groupBoxPenumpang2.Visible = true;
                buttonTambahPenumpang2.Visible = false;
                groupBoxPenumpang3.Visible = true;
                buttonTambahPenumpang3.Visible = false;
                groupBoxPenumpang4.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTambahPenumpang1_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPenumpang1.Visible = true;
                buttonTambahPenumpang1.Visible = false;
                groupBoxPenumpang2.Visible = true;
                buttonTambahPenumpang2.Visible = true;
                groupBoxPenumpang3.Visible = false;
                buttonTambahPenumpang3.Visible = false;
                groupBoxPenumpang4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUbahProfile_Click(object sender, EventArgs e)
        {
            try
            {
                Profile formProfile = new Profile();
                formProfile.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHapusPenumpang1_Click(object sender, EventArgs e)
        {
            try
            {
                tBoxNamaPenumpang1.Text = "";
                tBoxKTPPenumpang1.Text = "";
                groupBoxPenumpang1.Visible = true;

                tBoxNamaPenumpang2.Text = "";
                tBoxKTPPenumpang2.Text = "";
                groupBoxPenumpang2.Visible = false;

                tBoxNamaPenumpang3.Text = "";
                tBoxKTPPenumpang3.Text = "";
                groupBoxPenumpang3.Visible = false;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelNamaPenumpang1.Text = "";
                labelNamaPenumpang1.Visible = false;
                labelNamaPenumpang2.Text = "";
                labelNamaPenumpang2.Visible = false;
                labelNamaPenumpang3.Text = "";
                labelNamaPenumpang3.Visible = false;
                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHapusPenumpang2_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPenumpang1.Visible = true;

                tBoxNamaPenumpang2.Text = "";
                tBoxKTPPenumpang2.Text = "";
                groupBoxPenumpang2.Visible = false;

                tBoxNamaPenumpang3.Text = "";
                tBoxKTPPenumpang3.Text = "";
                groupBoxPenumpang3.Visible = false;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelNamaPenumpang2.Text = "";
                labelNamaPenumpang2.Visible = false;
                labelNamaPenumpang3.Text = "";
                labelNamaPenumpang3.Visible = false;
                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHapusPenumpang3_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPenumpang1.Visible = true;

                groupBoxPenumpang2.Visible = true;

                tBoxNamaPenumpang3.Text = "";
                tBoxKTPPenumpang3.Text = "";
                groupBoxPenumpang3.Visible = false;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelNamaPenumpang3.Text = "";
                labelNamaPenumpang3.Visible = false;
                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHapusPenumpang4_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxPenumpang1.Visible = true;

                groupBoxPenumpang2.Visible = true;

                groupBoxPenumpang3.Visible = true;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cBoxTitlePenumpang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cBoxTitlePenumpang2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cBoxTitlePenumang3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cBoxTitlePenumang4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang4.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxNamaPenumpang1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxNamaPenumpang2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxNamaPenumpang3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxNamaPenumpang4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang4.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxKTPPenumpang1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxKTPPenumpang2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxKTPPenumpang3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxKTPPenumpang4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang4.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDonePenumpang1_Click(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang1.Visible = false;
                labelNamaPenumpang1.Visible = true;
                labelNamaPenumpang1.Text = tBoxNamaPenumpang1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDonePenumpang2_Click(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang2.Visible = false;
                labelNamaPenumpang2.Visible = true;
                labelNamaPenumpang2.Text = tBoxNamaPenumpang1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDonePenumpang3_Click(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang3.Visible = false;
                labelNamaPenumpang3.Visible = true;
                labelNamaPenumpang3.Text = tBoxNamaPenumpang1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDonePenumpang4_Click(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang4.Visible = false;
                labelNamaPenumpang4.Visible = true;
                labelNamaPenumpang4.Text = tBoxNamaPenumpang1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
