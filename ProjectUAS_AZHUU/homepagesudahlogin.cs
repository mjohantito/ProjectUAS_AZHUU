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

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (tujuan.Checked == true)
            {
                sqlConnect = new MySqlConnection(connectString);

                DataTable dtListAirport = new DataTable();
                sqlQuery = "select airport_id, concat('[',`airport_id`,']',`airport_name`) as `Airport` from airport";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListAirport);

                cbdari.DataSource = dtListAirport;
                cbdari.DisplayMember = "Airport";
                cbdari.ValueMember = "airport_id";

                sqlConnect = new MySqlConnection(connectString);
                DataTable dtRute = new DataTable();
                sqlQuery = "select rute_id, rute_halte as `Halte` from rute where airport_id = '" + cbke.SelectedValue.ToString() + "' group by rute_halte";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtRute);

                cbke.DataSource = dtRute;
                cbke.DisplayMember = "Halte";
                cbke.ValueMember = "Halte";
            }
            else if (airport.Checked == true)
            {
                sqlConnect = new MySqlConnection(connectString);
                DataTable dtRute = new DataTable();
                sqlQuery = "select rute_id, rute_halte as `Halte` from rute where airport_id = '" + cbke.SelectedValue.ToString() + "' group by rute_halte";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtRute);

                cbke.DataSource = dtRute;
                cbke.DisplayMember = "Halte";
                cbke.ValueMember = "Halte";

                sqlConnect = new MySqlConnection(connectString);
                DataTable dtListAirport = new DataTable();
                sqlQuery = "select airport_id, concat('[',`airport_id`,']',`airport_name`) as `Airport` from airport";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListAirport);

                cbdari.DataSource = dtListAirport;
                cbdari.DisplayMember = "Airport";
                cbdari.ValueMember = "airport_id";

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var pwnotelp = new pilihberita();
            pwnotelp.ShowDialog();
        }

        private void tujuan_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void airport_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void cari_Click(object sender, EventArgs e)
        {
            var pwnotelp = new Search();
            pwnotelp.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var pwnotelp = new Promo();
            pwnotelp.ShowDialog();
        }
    }
}
