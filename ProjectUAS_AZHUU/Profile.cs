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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                cboxTitle.Items.Add("Mr.");
                cboxTitle.Items.Add("Mrs.");
                cboxTitle.Items.Add("Ms.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
