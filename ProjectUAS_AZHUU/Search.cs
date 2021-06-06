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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        string fromto = Homepagebelumlogin.fromto; // dari homepage
        DateTime dateeeee =  Convert.ToDateTime(Homepagebelumlogin.dateee);

        public static string ruteidd;

        private void Search_Load(object sender, EventArgs e)
        {
            loadcbox();
            cboxAirport.SelectedValue = Homepagebelumlogin.airport; // dari homepage
            cboxHalte.SelectedValue = Homepagebelumlogin.halte; // darihomepage
            dtpTanggalCari.Value = (DateTime)dateeeee;
            if(fromto == "F")
            {
                rbutDari.Checked = true;
                labelDariKe.Text = "Ke :";
            }
            else if(fromto == "T")
            {
                rbutKe.Checked = true;
                labelDariKe.Text = "Dari :";
            }

        }
        private void loadcbox()
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);

                DataTable dtListAirport = new DataTable();
                sqlQuery = "select airport_id, concat('[',`airport_id`,']',`airport_name`) as `Airport` from airport";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListAirport);

                cboxAirport.DataSource = dtListAirport;
                cboxAirport.DisplayMember = "Airport";
                cboxAirport.ValueMember = "airport_id";

                loadcboxhalte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadcboxhalte()
        {
            cboxHalte.SelectedIndex = -1;
            DataTable dtRute = new DataTable();
            sqlQuery = "select rute_id, rute_halte as `Halte` from rute where airport_id = '" + cboxAirport.SelectedValue.ToString() + "' group by rute_halte";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtRute);

            cboxHalte.DataSource = dtRute;
            cboxHalte.DisplayMember = "Halte";
            cboxHalte.ValueMember = "Halte";
            cboxHalte.SelectedIndex = -1; // nnti diambil dari homepage pakai selectedvalue juga bolehhh
        }

        private void cboxAirport_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcboxhalte();
        }

        private void rbutDari_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fromto = "F";
                labelDariKe.Text = "Ke :";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbutKe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fromto = "T";
                labelDariKe.Text = "Dari :";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butCari_Click(object sender, EventArgs e)
        {
            try
            {
                string dateee = dtpTanggalCari.Value.ToString("yyyy-MM-dd");

                sqlConnect = new MySqlConnection(connectString);

                DataTable dtsearch = new DataTable();
                sqlQuery = "select a.rute_id as `Rute ID`, `PO BUS`, Jenis,IFNULL(`Sisa Kursi` - `apagitu`,`Sisa Kursi`) as `Sisa Kursi`, Halte, Waktu, `Harga`   from  (select rute_id, pobus_name as `PO BUS`, v_jenis as `Jenis`, v_capacity as `Sisa Kursi`, concat(if (rute_fromto = 'F','Ke','Dari'),'  ', rute_halte) as `Halte`,RUTE_WAKTUBERANGKAT as `Waktu`, rute_price as `Harga`   from rute r, po_bus p, vehicle v where p.pobus_id = v.pobus_id and v.v_id = r.v_id and airport_id = '"+cboxAirport.SelectedValue.ToString()+"' and RUTE_FROMTO = '"+fromto+"' and RUTE_HALTE = '"+cboxHalte.SelectedValue.ToString()+ "') a left join(select tp_tanggalbooking as `Tanggal Booking`, rute_id, count(*) as `apagitu` from pesan_transaksi group by rute_id) b on a.rute_id = b.rute_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtsearch);

                dgvRute.DataSource = dtsearch;

                dgvRute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(Homepagebelumlogin.ceklogin == "belum login")
                {
                    MessageBox.Show("Login Terlebih dahulu!");
                    var logiin = new Sign_In();
                    logiin.ShowDialog();
                }
                else
                {
                    ruteidd = dgvRute.Rows[e.RowIndex].Cells["Rute ID"].ToString();
                    var diftirpinimping = new DaftarPenumpang();
                    diftirpinimping.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpTanggalCari_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
