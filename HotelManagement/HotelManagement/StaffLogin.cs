using System;
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
    public partial class StaffLogin : Form
    {
        Staff_tbl model = new Staff_tbl();
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffServices staffServices = new StaffServices();
            var dataset = staffServices.validate(usernametb.Text, passwordtb.Text);
            if (dataset != null)
            {
                MainStaff mf = new MainStaff();
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
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            StaffServices staffServices = new StaffServices();
            var dataset = staffServices.validate(usernametb.Text, passwordtb.Text);
            if (dataset != null)
            {
                MainStaff mf = new MainStaff();
                mf.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AboutForm login = new AboutForm();
            login.Show();
            this.Hide();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
