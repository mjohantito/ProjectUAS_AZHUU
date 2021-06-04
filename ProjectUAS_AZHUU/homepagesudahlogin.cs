﻿using System;
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
                DataTable masuk = new DataTable();
                sqlQuery = "select airport_name  , airport_id from airport";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(masuk);
                cbdari.DisplayMember = "airport_name";
                cbdari.ValueMember = "airport_id";
                cbdari.DataSource = masuk;

                sqlConnect = new MySqlConnection(connectString);
                DataTable masuk1 = new DataTable();
                sqlQuery = "select RUTE_DESTINATION  , RUTE_ID from RUTE";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(masuk1);
                cbke.DisplayMember = "RUTE_DESTINATION";
                cbke.ValueMember = "RUTE_ID";
                cbke.DataSource = masuk1;
            }
            else if (airport.Checked == true)
            {
                sqlConnect = new MySqlConnection(connectString);
                DataTable masuk = new DataTable();
                sqlQuery = "select airport_name  , airport_id from airport";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(masuk);
                cbke.DisplayMember = "airport_name";
                cbke.ValueMember = "airport_id";
                cbke.DataSource = masuk;

                sqlConnect = new MySqlConnection(connectString);
                DataTable masuk1 = new DataTable();
                sqlQuery = "select RUTE_DESTINATION  , RUTE_ID from RUTE";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(masuk1);
                cbdari.DisplayMember = "RUTE_DESTINATION";
                cbdari.ValueMember = "RUTE_ID";
                cbdari.DataSource = masuk1;

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
