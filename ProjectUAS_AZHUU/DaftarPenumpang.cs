﻿using System;
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
    public partial class FormDaftarPenumpang : System.Windows.Forms.Form
    {
        public FormDaftarPenumpang()
        {
            InitializeComponent();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                FormCheckout formCheckout = new FormCheckout();
                formCheckout.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
