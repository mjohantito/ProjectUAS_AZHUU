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
    public partial class Homepagebelumlogin : Form
    {
        public Homepagebelumlogin()
        {
            InitializeComponent();
        }

        private void Homepagebelumlogin_Load(object sender, EventArgs e)
        {

        }

        private void btsignin_MouseHover(object sender, EventArgs e)
        {
            btsignin.BackColor = Color.White;
        }
    }
}
