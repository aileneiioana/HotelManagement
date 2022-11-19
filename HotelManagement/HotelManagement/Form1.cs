﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement;
using HotelManagement.Services;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        Staff_tbl model = new Staff_tbl();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffServices staffServices = new StaffServices();
            var dataset = staffServices.validate(usernametb.Text, passwordtb.Text);
            if (dataset != null)
            {
                Main mf = new Main();
                mf.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
