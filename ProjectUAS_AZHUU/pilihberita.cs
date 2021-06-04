using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS_AZHUU
{
    public partial class pilihberita : Form
    {
        public pilihberita()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var pwnotelp = new HomePage();
            pwnotelp.ShowDialog();
        }
    }
}
