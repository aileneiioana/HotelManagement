﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class ClientLogIn : Form
    {
        public ClientLogIn()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
           new Register().Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            StaffLogin mf = new StaffLogin();
            mf.Show();
        }

        private void staffCancelbtn_Click(object sender, EventArgs e)
        {
            staffGB.Hide();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDespreHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutForm().Show();
        }
    }
}
