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

        int Potongan;

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtProfile = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProfile);

                FormMyOrder formMyOrder = new FormMyOrder();
                formMyOrder.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            try
            {
                int jumlahsubtotal;
                int jumlahpromo;
                int jumlahtotal;

                labelFromTo.Text = DaftarPenumpang.FromTo;
                labelPOBus.Text = DaftarPenumpang.POBus;

                labelPenumpang1.Text = DaftarPenumpang.NamaPenumpang1 = DaftarPenumpang.KTPPenumpang1;
                labelPenumpang2.Text = DaftarPenumpang.NamaPenumpang2 = DaftarPenumpang.KTPPenumpang2;
                labelPenumpang3.Text = DaftarPenumpang.NamaPenumpang3 = DaftarPenumpang.KTPPenumpang3;
                labelPenumpang4.Text = DaftarPenumpang.NamaPenumpang4 = DaftarPenumpang.KTPPenumpang4;

                labelJumlahSubtotal.Text = DaftarPenumpang.Subtotal;
                jumlahsubtotal = Convert.ToInt32(labelJumlahSubtotal);

                labelJumlahPromo.Text = Convert.ToString(Potongan);
                jumlahpromo = Potongan;

                jumlahtotal = jumlahsubtotal - jumlahpromo;
                labelJumlahTotal.Text = "Rp. " + Convert.ToString(jumlahtotal);
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
                if(tBoxKode.Text == "HANTAMPAN")
                {
                    Potongan = 300000;
                    labelDetailPromo.Text = "Promo HANTAMPAN + Potongan " + Convert.ToString(Potongan);
                }
                else if(tBoxKode.Text == "TAMPANPEMBERANI")
                {
                    Potongan = 1500;
                    labelDetailPromo.Text = "Promo TAMPANPEMBERANI + Potongan " + Convert.ToString(Potongan);
                }
                else if (tBoxKode.Text == "PENIKMATKOPI")
                {
                    Potongan = 50000;
                    labelDetailPromo.Text = "Promo PENIKMATKOPI + Potongan " + Convert.ToString(Potongan);
                }
                else if (tBoxKode.Text == "ASDOS2021")
                {
                    Potongan = 200000;
                    labelDetailPromo.Text = "Promo ASDOS2021 + Potongan " + Convert.ToString(Potongan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
