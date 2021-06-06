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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        public static string nikkk;
        string fromto = Homepagebelumlogin.fromto;
        

        private void HomePage_Load(object sender, EventArgs e)
        {
            loadcbox();
            cboxAirport.SelectedValue = Homepagebelumlogin.airport; // dari homepage
            cboxHalte.SelectedValue = Homepagebelumlogin.halte; // darihomepage
            if(Homepagebelumlogin.dateee == "0000-00-00")
            {

            }
            else
            {
                dtpTanggalCari.Value = Convert.ToDateTime(Homepagebelumlogin.dateee);
            }    
            if (fromto == "F")
            {
                rbutDari.Checked = true;
                labelDariKe.Text = "Ke :";
            }
            else if (fromto == "T")
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
            cboxHalte.SelectedIndex = -1;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var pwnotelp = new pilihberita();
            pwnotelp.ShowDialog();
        }

        private void cari_Click(object sender, EventArgs e)
        {
            try
            {
                string dateee = dtpTanggalCari.Value.ToString("yyyy-MM-dd");

                if (cboxHalte.SelectedIndex == -1)
                {
                    MessageBox.Show("Isi Halte Tujuan");
                }
                else if (dateee == "0000-00-00")
                {
                    MessageBox.Show("Tanggal Belum di isi!");
                }
                else
                {
                    Homepagebelumlogin.dateee = dtpTanggalCari.Value.ToString("yyyy-MM-dd");
                    Homepagebelumlogin.airport = cboxAirport.SelectedValue.ToString();
                    Homepagebelumlogin.halte = cboxHalte.SelectedValue.ToString();

                    var sirch = new Search();
                    sirch.ShowDialog();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var pwnotelp = new Promo();
            pwnotelp.ShowDialog();
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

        private void dtpTanggalCari_ValueChanged(object sender, EventArgs e)
        {
            Homepagebelumlogin.dateee = dtpTanggalCari.Value.ToString("yyyy-MM-dd");
        }

        private void butProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var formprofile = new Profile();
                formprofile.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
