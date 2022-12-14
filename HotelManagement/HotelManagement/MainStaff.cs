using HotelManagement;
using HotelManagement.Services;
using System;
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
    public partial class MainStaff : Form
    {
        public MainStaff()
        {
            InitializeComponent();
        }

        private void singoutpb_Click(object sender, EventArgs e)
        {
            StaffLogin login = new StaffLogin();
            login.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staffpb_Click(object sender, EventArgs e)
        {
            StaffInformation staff = new StaffInformation();
            staff.Show();
            this.Hide();
        }

        private void reservationpb_Click(object sender, EventArgs e)
        {
            ReservationInformation res = new ReservationInformation();
            res.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientpb_Click(object sender, EventArgs e)
        {
            Clientinfo res = new Clientinfo();
            res.Show();
            this.Hide();
        }

        private void roompb_Click(object sender, EventArgs e)
        {
            RoomInformation res = new RoomInformation();
            res.Show();
            this.Hide();
        }
    }
}
