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

        public static string NamaPenumpang1;
        public static string KTPPenumpang1;
        public static string TlpnPenumpang1;

        public static string NamaPenumpang2;
        public static string KTPPenumpang2;
        public static string TlpnPenumpang2;

        public static string NamaPenumpang3;
        public static string KTPPenumpang3;
        public static string TlpnPenumpang3;

        public static string NamaPenumpang4;
        public static string KTPPenumpang4;
        public static string TlpnPenumpang4;

        public static string FromTo;
        public static string POBus;
        public static int Subtotal;

        public static string Tanggal;

        public static int counterPenumpang;

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                NamaPenumpang1 = tBoxNamaPenumpang1.Text;
                KTPPenumpang1 = tBoxKTPPenumpang1.Text;
                TlpnPenumpang1 = tBoxTlpnPenumpang1.Text;

                NamaPenumpang2 = tBoxNamaPenumpang2.Text;
                KTPPenumpang2 = tBoxKTPPenumpang2.Text;
                TlpnPenumpang2 = tBoxTlpnPenumpang2.Text;

                NamaPenumpang3 = tBoxNamaPenumpang3.Text;
                KTPPenumpang3 = tBoxKTPPenumpang3.Text;
                TlpnPenumpang3 = tBoxTlpnPenumpang3.Text;

                NamaPenumpang4 = tBoxNamaPenumpang4.Text;
                KTPPenumpang4 = tBoxKTPPenumpang4.Text;
                TlpnPenumpang4 = tBoxTlpnPenumpang4.Text;

                FromTo = labelJurusan.Text;
                POBus = labelNamaPO.Text;
                Subtotal = Convert.ToInt32(labelJumlahPembayaran.Text);
                Tanggal = labelTanggal.Text;

                if(labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    counterPenumpang = 4;
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    counterPenumpang = 3;
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    counterPenumpang = 2;
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    counterPenumpang = 1;
                }

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

                labelNamaPenumpang1.Text = "";
                labelNamaPenumpang1.Visible = false;
                labelNamaPenumpang2.Text = "";
                labelNamaPenumpang2.Visible = false;
                labelNamaPenumpang3.Text = "";
                labelNamaPenumpang3.Visible = false;
                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;

                labelPN1.Visible = true;
                labelNIK1.Visible = true;
                labeltlp1.Visible = true;

                labelPN2.Visible = false;
                labelNIK2.Visible = false;
                labeltlp2.Visible = false;

                labelPN3.Visible = false;
                labelNIK3.Visible = false;
                labeltlp3.Visible = false;

                labelPN4.Visible = false;
                labelNIK4.Visible = false;
                labeltlp4.Visible = false;

                DataTable dtRute = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select concat(airport_id, ' ', if (rute_fromto = 'F','Ke','Dari'),'  ', rute_halte) as `Rute` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtRute);

                labelJurusan.Text = dtRute.Rows[0]["Rute"].ToString();

                string POID = Search.ruteidd.ToString().Substring(0, 4);

                DataTable dtPOBus = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select pobus_name as `Nama PO` from po_bus where  pobus_id  = '" + POID + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPOBus);

                labelNamaPO.Text = dtPOBus.Rows[0]["Nama PO"].ToString();

                DataTable dtProfile = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select user_title as `Title`, user_name as `User Name`, user_email as `User Email`, user_telp as `User Telp` from user_azhuu where user_nik = '" + HomePage.nikkk + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProfile);

                cBoxTitleProfile.DataSource = dtProfile;
                cBoxTitleProfile.DisplayMember = "Title";
                tBoxNamaProfile.Text = dtProfile.Rows[0]["User Name"].ToString();
                tBoxEmailProfile.Text = dtProfile.Rows[0]["User Email"].ToString();
                tBoxTeleponProfile.Text = dtProfile.Rows[0]["User Telp"].ToString();

                DataTable dtTanggal = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select curdate() as `Tanggal`;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTanggal);
                labelTanggal.Text = dtTanggal.Rows[0]["Tanggal"].ToString();

                Subtotal = 0;
                labelJumlahPembayaran.Text = Subtotal.ToString();

                counterPenumpang = 0;
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

                labelPN3.Visible = true;
                labelNIK3.Visible = true;
                labeltlp3.Visible = true;
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

                labelPN4.Visible = true;
                labelNIK4.Visible = true;
                labeltlp4.Visible = true;
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

                labelPN2.Visible = true;
                labelNIK2.Visible = true;
                labeltlp2.Visible = true;
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
                buttonTambahPenumpang1.Visible = true;
                buttonTambahPenumpang2.Visible = false;
                buttonTambahPenumpang3.Visible = false;

                tBoxNamaPenumpang1.Text = "";
                tBoxKTPPenumpang1.Text = "";
                tBoxTlpnPenumpang1.Text = "";
                groupBoxPenumpang1.Visible = true;

                tBoxNamaPenumpang2.Text = "";
                tBoxKTPPenumpang2.Text = "";
                tBoxTlpnPenumpang2.Text = "";
                groupBoxPenumpang2.Visible = false;

                tBoxNamaPenumpang3.Text = "";
                tBoxKTPPenumpang3.Text = "";
                tBoxTlpnPenumpang3.Text = "";
                groupBoxPenumpang3.Visible = false;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                tBoxTlpnPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelPN1.Visible = true;
                labelNIK1.Visible = true;
                labeltlp1.Visible = true;

                labelPN2.Visible = false;
                labelNIK2.Visible = false;
                labeltlp2.Visible = false;

                labelPN3.Visible = false;
                labelNIK3.Visible = false;
                labeltlp3.Visible = false;

                labelPN4.Visible = false;
                labelNIK4.Visible = false;
                labeltlp4.Visible = false;

                labelNamaPenumpang1.Text = "";
                labelNamaPenumpang1.Visible = false;
                labelNamaPenumpang2.Text = "";
                labelNamaPenumpang2.Visible = false;
                labelNamaPenumpang3.Text = "";
                labelNamaPenumpang3.Visible = false;
                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
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

                buttonTambahPenumpang1.Visible = true;
                buttonTambahPenumpang2.Visible = false;
                buttonTambahPenumpang3.Visible = false;

                tBoxNamaPenumpang2.Text = "";
                tBoxKTPPenumpang2.Text = "";
                tBoxTlpnPenumpang2.Text = "";
                groupBoxPenumpang2.Visible = false;

                tBoxNamaPenumpang3.Text = "";
                tBoxKTPPenumpang3.Text = "";
                tBoxTlpnPenumpang3.Text = "";
                groupBoxPenumpang3.Visible = false;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                tBoxTlpnPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelPN2.Visible = true;
                labelNIK2.Visible = true;
                labeltlp2.Visible = true;

                labelPN3.Visible = false;
                labelNIK3.Visible = false;
                labeltlp3.Visible = false;

                labelPN4.Visible = false;
                labelNIK4.Visible = false;
                labeltlp4.Visible = false;

                labelNamaPenumpang2.Text = "";
                labelNamaPenumpang2.Visible = false;
                labelNamaPenumpang3.Text = "";
                labelNamaPenumpang3.Visible = false;
                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
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

                buttonTambahPenumpang2.Visible = true;
                buttonTambahPenumpang3.Visible = false;

                tBoxNamaPenumpang3.Text = "";
                tBoxKTPPenumpang3.Text = "";
                tBoxTlpnPenumpang3.Text = "";
                groupBoxPenumpang3.Visible = false;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                tBoxTlpnPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelPN3.Visible = true;
                labelNIK3.Visible = true;
                labeltlp3.Visible = true;

                labelPN4.Visible = false;
                labelNIK4.Visible = false;
                labeltlp4.Visible = false;

                labelNamaPenumpang3.Text = "";
                labelNamaPenumpang3.Visible = false;
                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
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

                buttonTambahPenumpang3.Visible = true;

                tBoxNamaPenumpang4.Text = "";
                tBoxKTPPenumpang4.Text = "";
                tBoxTlpnPenumpang4.Text = "";
                groupBoxPenumpang4.Visible = false;

                labelPN4.Visible = true;
                labelNIK4.Visible = true;
                labeltlp4.Visible = true;

                labelNamaPenumpang4.Text = "";
                labelNamaPenumpang4.Visible = false;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
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
                labelPN1.Visible = false;
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
                labelPN2.Visible = false;
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
                labelPN3.Visible = false;
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
                labelPN4.Visible = false;
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
                labelNIK1.Visible = false;
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
                labelNIK2.Visible = false;
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
                labelNIK3.Visible = false;
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
                labelNIK4.Visible = false;
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
                labelNamaPenumpang1.Text = "- " + tBoxNamaPenumpang1.Text;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal*2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
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
                labelNamaPenumpang2.Text = "- " + tBoxNamaPenumpang2.Text;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
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
                labelNamaPenumpang3.Text = "- " + tBoxNamaPenumpang3.Text;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
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
                labelNamaPenumpang4.Text = "- " + tBoxNamaPenumpang4.Text;

                DataTable dtHarga = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select rute_price as `Harga` from rute where rute_id = '" + Search.ruteidd + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHarga);
                Subtotal = Convert.ToInt32(dtHarga.Rows[0]["Harga"].ToString());

                if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 2).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == false)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 3).ToString();
                }
                else if (labelNamaPenumpang1.Visible == true && labelNamaPenumpang2.Visible == true && labelNamaPenumpang3.Visible == true && labelNamaPenumpang4.Visible == true)
                {
                    labelJumlahPembayaran.Text = (Subtotal * 4).ToString();
                }
                else if (labelNamaPenumpang1.Visible == false && labelNamaPenumpang2.Visible == false && labelNamaPenumpang3.Visible == false && labelNamaPenumpang4.Visible == false)
                {
                    Subtotal = 0;
                    labelJumlahPembayaran.Text = Subtotal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxTlpnPenumpang1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang1.Visible = true;
                labeltlp1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxTlpnPenumpang2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang2.Visible = true;
                labeltlp2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxTlpnPenumpang3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang3.Visible = true;
                labeltlp3.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxTlpnPenumpang4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonDonePenumpang4.Visible = true;
                labeltlp4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
