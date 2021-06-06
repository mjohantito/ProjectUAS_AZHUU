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
    public partial class FormCheckout : Form
    {
        public FormCheckout()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        public static int Potongan;
        public static int jumlahsubtotal;
        public static int jumlahpromo;
        public static int jumlahtotal;
        public static string BookingID;
        public static string PromoID;

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            try
            {
                labelFromTo.Text = DaftarPenumpang.FromTo;
                labelPOBus.Text = DaftarPenumpang.POBus;

                labelPenumpang1.Text = DaftarPenumpang.NamaPenumpang1 = DaftarPenumpang.KTPPenumpang1;
                labelPenumpang2.Text = DaftarPenumpang.NamaPenumpang2 = DaftarPenumpang.KTPPenumpang2;
                labelPenumpang3.Text = DaftarPenumpang.NamaPenumpang3 = DaftarPenumpang.KTPPenumpang3;
                labelPenumpang4.Text = DaftarPenumpang.NamaPenumpang4 = DaftarPenumpang.KTPPenumpang4;

                labelJumlahSubtotal.Text = DaftarPenumpang.Subtotal.ToString();
                jumlahsubtotal = Convert.ToInt32(labelJumlahSubtotal);

                labelJumlahPromo.Text = Convert.ToString(Potongan);
                jumlahpromo = Potongan;

                jumlahtotal = jumlahsubtotal - jumlahpromo;
                labelJumlahTotal.Text = "Rp. " + Convert.ToString(jumlahtotal);

                string tanggalbook = Homepagebelumlogin.dateee;
                string idTengah = tanggalbook.Substring(0, 2) + tanggalbook.Substring(3, 2) + tanggalbook.Substring(6, 4);
                BookingID = Search.ruteidd + idTengah; // terakhir disini brian
                labelisiIDBooking.Text = BookingID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxKode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Promo = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select promo_id as `ID Promo`, promo_value as `Promo`, promo_code as `Kode` from promo where promo_code = '" + tBoxKode.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Promo);

                Potongan = Convert.ToInt32(Promo.Rows[0]["Promo"].ToString());
                jumlahpromo = Potongan;

                jumlahtotal = jumlahsubtotal - jumlahpromo;
                labelJumlahTotal.Text = "Rp. " + Convert.ToString(jumlahtotal);

                PromoID = Promo.Rows[0]["ID Promo"].ToString();

                if (tBoxKode.Text == "HANTAMPAN")
                {
                    labelDetailPromo.Text = "Promo HANTAMPAN + Potongan " + Convert.ToString(Potongan);
                }
                else if(tBoxKode.Text == "TAMPANPEMBERANI")
                {
                    labelDetailPromo.Text = "Promo TAMPANPEMBERANI + Potongan " + Convert.ToString(Potongan);
                }
                else if (tBoxKode.Text == "PENIKMATKOPI")
                {
                    labelDetailPromo.Text = "Promo PENIKMATKOPI + Potongan " + Convert.ToString(Potongan);
                }
                else if (tBoxKode.Text == "ASDOS2021")
                {
                    labelDetailPromo.Text = "Promo ASDOS2021 + Potongan " + Convert.ToString(Potongan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPenumpang = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "insert into penumpang select '" + DaftarPenumpang.KTPPenumpang1 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang1 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang1 + "' as `Telepon`, '0' as `Delete` union select '" + DaftarPenumpang.KTPPenumpang2 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang2 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang2 + "' as `Telepon`, '0' as `Delete` union select '" + DaftarPenumpang.KTPPenumpang3 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang3 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang3 + "' as `Telepon`, '0' as `Delete` union select '" + DaftarPenumpang.KTPPenumpang4 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang4 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang4 + "' as `Telepon`, '0' as `Delete`;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader DataPenumpang;
                sqlConnect.Open();
                DataPenumpang = sqlCommand.ExecuteReader();
                sqlConnect.Close();

                DataTable dtPesanTrans = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "`";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader DataPesanTrans;
                sqlConnect.Open();
                DataPesanTrans = sqlCommand.ExecuteReader();
                sqlConnect.Close();
                
                DataTable dtTransPenumpang = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "`";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader DataTransPenumpang;
                sqlConnect.Open();
                DataTransPenumpang = sqlCommand.ExecuteReader();
                sqlConnect.Close();

                FormMyOrder formMyOrder = new FormMyOrder();
                formMyOrder.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
