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

        public static int Potongan = 0;
        public static int jumlahsubtotal;
        public static int jumlahpromo = 0;
        public static int jumlahtotal;
        public static string BookingID;
        public static string PromoID = "p0005";

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            try
            {
                labelFromTo.Text = DaftarPenumpang.FromTo;
                labelPOBus.Text = DaftarPenumpang.POBus;

                if (DaftarPenumpang.counterPenumpang == 1)
                {
                    labelPenumpang1.Text = DaftarPenumpang.NamaPenumpang1 + " - " + DaftarPenumpang.KTPPenumpang1;
                    labelPenumpang2.Text = "";
                    labelPenumpang3.Text = "";
                    labelPenumpang4.Text = "";

                    labelPenumpang1.Visible = true;
                    labelPenumpang2.Visible = false;
                    labelPenumpang3.Visible = false;
                    labelPenumpang4.Visible = false;
                }
                else if (DaftarPenumpang.counterPenumpang == 2)
                {
                    labelPenumpang1.Text = DaftarPenumpang.NamaPenumpang1 + " - " + DaftarPenumpang.KTPPenumpang1;
                    labelPenumpang2.Text = DaftarPenumpang.NamaPenumpang2 + " - " + DaftarPenumpang.KTPPenumpang2;
                    labelPenumpang3.Text = "";
                    labelPenumpang4.Text = "";

                    labelPenumpang1.Visible = true;
                    labelPenumpang2.Visible = true;
                    labelPenumpang3.Visible = false;
                    labelPenumpang4.Visible = false;
                }
                else if (DaftarPenumpang.counterPenumpang == 3)
                {
                    labelPenumpang1.Text = DaftarPenumpang.NamaPenumpang1 + " - " + DaftarPenumpang.KTPPenumpang1;
                    labelPenumpang2.Text = DaftarPenumpang.NamaPenumpang2 + " - " + DaftarPenumpang.KTPPenumpang2;
                    labelPenumpang3.Text = DaftarPenumpang.NamaPenumpang3 + " - " + DaftarPenumpang.KTPPenumpang3;
                    labelPenumpang4.Text = "";

                    labelPenumpang1.Visible = true;
                    labelPenumpang2.Visible = true;
                    labelPenumpang3.Visible = true;
                    labelPenumpang4.Visible = false;
                }
                else if (DaftarPenumpang.counterPenumpang == 4)
                {
                    labelPenumpang1.Text = DaftarPenumpang.NamaPenumpang1 + " - " + DaftarPenumpang.KTPPenumpang1;
                    labelPenumpang2.Text = DaftarPenumpang.NamaPenumpang2 + " - " + DaftarPenumpang.KTPPenumpang2;
                    labelPenumpang3.Text = DaftarPenumpang.NamaPenumpang3 + " - " + DaftarPenumpang.KTPPenumpang3;
                    labelPenumpang4.Text = DaftarPenumpang.NamaPenumpang4 + " - " + DaftarPenumpang.KTPPenumpang4;

                    labelPenumpang1.Visible = true;
                    labelPenumpang2.Visible = true;
                    labelPenumpang3.Visible = true;
                    labelPenumpang4.Visible = true;
                }

                labelJumlahSubtotal.Text = DaftarPenumpang.Subtotal.ToString();
                jumlahsubtotal = Convert.ToInt32(DaftarPenumpang.Subtotal);

                labelJumlahPromo.Text = Potongan.ToString();

                jumlahtotal = jumlahsubtotal - jumlahpromo;
                labelJumlahTotal.Text = jumlahtotal.ToString();

                string tanggalbook = Homepagebelumlogin.dateee;
                string idTanggal = tanggalbook.Substring(0, 4) + tanggalbook.Substring(5, 2) + tanggalbook.Substring(8, 2);
                MessageBox.Show(idTanggal);
                BookingID = Search.ruteidd + idTanggal;
                
                DataTable dtBookingID = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select tp_bookingid as `Booking ID` from pesan_transaksi where rute_id = '" + Search.ruteidd + "' and tp_tanggalbooking = '" + tanggalbook + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBookingID);

                int jumlahrows = dtBookingID.Rows.Count - 1;
                if(jumlahrows == -1)
                {
                    BookingID = BookingID + "001";
                }
                else
                {
                    string IDterakhir = dtBookingID.Rows[jumlahrows]["Booking ID"].ToString();
                    int angkaterakhir = Convert.ToInt32(IDterakhir.Substring(22, 3)) + 1;
                    string angka = angkaterakhir.ToString();

                    if(dtBookingID.Rows.Count < 10)
                    {
                        BookingID = BookingID + "00" + angka;
                    }
                    else if(dtBookingID.Rows.Count >= 10 && dtBookingID.Rows.Count < 100)
                    {
                        BookingID = BookingID + "0" + angka;
                    }
                    else if (dtBookingID.Rows.Count >= 100)
                    {
                        BookingID = BookingID +  angka;
                    }
                }

                labelisiIDBooking.Text = BookingID;
                MessageBox.Show(BookingID);
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
                if(DaftarPenumpang.counterPenumpang == 1)
                {
                    DataTable dtPenumpang = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into penumpang select '" + DaftarPenumpang.KTPPenumpang1 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang1 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang1 + "' as `Telepon`, '0' as `Delete`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataPenumpang;
                    sqlConnect.Open();
                    DataPenumpang = sqlCommand.ExecuteReader();
                    sqlConnect.Close();

                    DataTable dtPesanTrans = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into pesan_transaksi select '" + BookingID + "' as `Booking ID`, '" + Search.ruteidd + "' as `Rute ID`, '" + PromoID + "' as `Promo ID`, '" + HomePage.nikkk + "' as `NIK User`,  '" + DaftarPenumpang.Tanggal + "' as `Tanggal Transaksi`, '" + Homepagebelumlogin.dateee + "' as `Tanggal Booking`, 'O' as `Booking Status`, '" + jumlahtotal + "' as `Total Price`, '0' as `Delete`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataPesanTrans;
                    sqlConnect.Open();
                    DataPesanTrans = sqlCommand.ExecuteReader();
                    sqlConnect.Close();

                    DataTable dtTransPenumpang = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into transaksi_penumpang select '" + DaftarPenumpang.KTPPenumpang1 +"' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataTransPenumpang;
                    sqlConnect.Open();
                    DataTransPenumpang = sqlCommand.ExecuteReader();
                    sqlConnect.Close();
                }
                else if (DaftarPenumpang.counterPenumpang == 2)
                {
                    DataTable dtPenumpang = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into penumpang select '" + DaftarPenumpang.KTPPenumpang1 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang1 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang1 + "' as `Telepon`, '0' as `Delete` union select '" + DaftarPenumpang.KTPPenumpang2 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang2 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang2 + "' as `Telepon`, '0' as `Delete`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataPenumpang;
                    sqlConnect.Open();
                    DataPenumpang = sqlCommand.ExecuteReader();
                    sqlConnect.Close();

                    DataTable dtPesanTrans = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into pesan_transaksi select '" + BookingID + "' as `Booking ID`, '" + Search.ruteidd + "' as `Rute ID`, '" + PromoID + "' as `Promo ID`, '" + HomePage.nikkk + "' as `NIK User`,  '" + DaftarPenumpang.Tanggal + "' as `Tanggal Transaksi`, '" + Homepagebelumlogin.dateee + "' as `Tanggal Booking`, 'O' as `Booking Status`, '" + jumlahtotal + "' as `Total Price`, '0' as `Delete`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataPesanTrans;
                    sqlConnect.Open();
                    DataPesanTrans = sqlCommand.ExecuteReader();
                    sqlConnect.Close();

                    DataTable dtTransPenumpang = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into transaksi_penumpang select '" +DaftarPenumpang.KTPPenumpang1 +"' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID` union select '" + DaftarPenumpang.KTPPenumpang2+ "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataTransPenumpang;
                    sqlConnect.Open();
                    DataTransPenumpang = sqlCommand.ExecuteReader();
                    sqlConnect.Close();
                }
                else if (DaftarPenumpang.counterPenumpang == 3)
                {
                    DataTable dtPenumpang = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into penumpang select '" + DaftarPenumpang.KTPPenumpang1 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang1 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang1 + "' as `Telepon`, '0' as `Delete` union select '" + DaftarPenumpang.KTPPenumpang2 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang2 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang2 + "' as `Telepon`, '0' as `Delete` union select '" + DaftarPenumpang.KTPPenumpang3 + "' as `NIK`, '" + DaftarPenumpang.NamaPenumpang3 + "' as `Nama Penumpang`, '" + DaftarPenumpang.TlpnPenumpang3 + "' as `Telepon`, '0' as `Delete`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataPenumpang;
                    sqlConnect.Open();
                    DataPenumpang = sqlCommand.ExecuteReader();
                    sqlConnect.Close();

                    DataTable dtPesanTrans = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into pesan_transaksi select '" + BookingID + "' as `Booking ID`, '" + Search.ruteidd + "' as `Rute ID`, '" + PromoID + "' as `Promo ID`, '" + HomePage.nikkk + "' as `NIK User`,  '" + DaftarPenumpang.Tanggal + "' as `Tanggal Transaksi`, '" + Homepagebelumlogin.dateee + "' as `Tanggal Booking`, 'O' as `Booking Status`, '" + jumlahtotal + "' as `Total Price`, '0' as `Delete`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataPesanTrans;
                    sqlConnect.Open();
                    DataPesanTrans = sqlCommand.ExecuteReader();
                    sqlConnect.Close();

                    DataTable dtTransPenumpang = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into transaksi_penumpang select '" + DaftarPenumpang.KTPPenumpang1 + "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID` union select '" + DaftarPenumpang.KTPPenumpang2 + "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID` union select '" + DaftarPenumpang.KTPPenumpang3 + "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataTransPenumpang;
                    sqlConnect.Open();
                    DataTransPenumpang = sqlCommand.ExecuteReader();
                    sqlConnect.Close();
                }
                else if (DaftarPenumpang.counterPenumpang == 4)
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
                    sqlQuery = "insert into pesan_transaksi select '" + BookingID + "' as `Booking ID`, '" + Search.ruteidd + "' as `Rute ID`, '" + PromoID + "' as `Promo ID`, '" + HomePage.nikkk + "' as `NIK User`,  '" + DaftarPenumpang.Tanggal + "' as `Tanggal Transaksi`, '" + Homepagebelumlogin.dateee + "' as `Tanggal Booking`, 'O' as `Booking Status`, '" + jumlahtotal + "' as `Total Price`, '0' as `Delete`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataPesanTrans;
                    sqlConnect.Open();
                    DataPesanTrans = sqlCommand.ExecuteReader();
                    sqlConnect.Close();

                    DataTable dtTransPenumpang = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into transaksi_penumpang select '" + DaftarPenumpang.KTPPenumpang1 + "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID` union select '" + DaftarPenumpang.KTPPenumpang2 + "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID` union select '" + DaftarPenumpang.KTPPenumpang3 + "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID` union select '" + DaftarPenumpang.KTPPenumpang4 + "' as `NIK Penumpang`, '" + BookingID + "' as `Booking ID`;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    MySqlDataReader DataTransPenumpang;
                    sqlConnect.Open();
                    DataTransPenumpang = sqlCommand.ExecuteReader();
                    sqlConnect.Close();
                }

                FormMyOrder formMyOrder = new FormMyOrder();
                formMyOrder.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUse_Click(object sender, EventArgs e)
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
                labelJumlahTotal.Text = Convert.ToString(jumlahtotal);

                PromoID = Promo.Rows[0]["ID Promo"].ToString();

                if (tBoxKode.Text == "HANTAMPAN")
                {
                    labelDetailPromo.Text = "Promo HANTAMPAN + Potongan " + Convert.ToString(Potongan);
                }
                else if (tBoxKode.Text == "TAMPANPEMBERANI")
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

        private void butInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                // delete di table 
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "delete from azhuu_report";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                //insert di table
                sqlQuery = "insert into azhuu_report values ('"+BookingID+"','"+HomePage.nikkk+"','"+Search.ruteidd+"','"+tBoxKode.Text+"','"+DaftarPenumpang.Tanggal+"','"+Homepagebelumlogin.dateee+"','"+jumlahtotal.ToString()+"')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                var aaaa = new Report();
                aaaa.ShowDialog();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
