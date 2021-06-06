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
    public partial class FormMyOrder : Form
    {
        public FormMyOrder()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=premier_league;";
        string sqlQuery;

        private void FormMyOrder_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtOrder = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select tp_bookingid as `Booking ID`,  concat(airport_id, ' ', if (rute_fromto = 'F','Ke','Dari'),'  ', rute_halte) as `Rute`, tp_tanggalbooking as `Tanggal Booking` from pesan_transaksi pt, rute r where user_nik = '" + HomePage.nikkk + "' and pt.rute_id = r.rute_id and pt.tp_bookingstatus = 'O';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtOrder);
                dgvMyOrder.DataSource = dtOrder;

                labelBookingID.Visible = false;
                labelID.Visible = false;
                labelTotalPembayaran.Visible = false;
                labelTotal.Visible = false;
                labelTanggal.Visible = false;
                labelJam.Visible = false;
                labelFromTo.Visible = false;
                labelPenumpang.Visible = false;
                dgvPenumpang.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMyOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelBookingID.Visible = true;
                labelID.Visible = true;
                labelTotalPembayaran.Visible = true;
                labelTotal.Visible = true;
                labelTanggal.Visible = true;
                labelJam.Visible = true;
                labelFromTo.Visible = true;
                labelPenumpang.Visible = true;
                dgvPenumpang.Visible = true;

                DataTable dtPesanan = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select tp_bookingid as `Booking ID`, tp_tanggalbooking as `Tanggal Booking`, rute_waktuberangkat as `Jam`, tp_totalprice as `Harga`,  concat(airport_id, ' ', if (rute_fromto = 'F','Ke','Dari'),'  ', rute_halte) as `Rute` from pesan_transaksi pt, rute r where tp_bookingid = '" + dgvMyOrder.Rows[e.RowIndex].Cells["Booking ID"].Value.ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPesanan);

                labelID.Text = dtPesanan.Rows[0]["Booking ID"].ToString();
                labelTotal.Text = "IDR " + dtPesanan.Rows[0]["Harga"].ToString();
                labelTanggal.Text = dtPesanan.Rows[0]["Tanggal Booking"].ToString();
                labelJam.Text = dtPesanan.Rows[0]["Jam"].ToString();
                labelFromTo.Text = dtPesanan.Rows[0]["Rute"].ToString();

                DataTable dtPenumpang = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select p_nik as `NIK`, p_nama as `Nama`, p_telp as `Telepon` from  penumpang p, transaksi_penumpang tp where tp.tp_bookingid = '" + dgvMyOrder.Rows[e.RowIndex].Cells["Booking ID"].Value.ToString() + "' and p.p_nik = tp.p_nik;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPenumpang);

                dgvPenumpang.DataSource = dtPenumpang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
