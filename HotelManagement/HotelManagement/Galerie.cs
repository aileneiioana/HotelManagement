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
    public partial class Galerie : Form
    {
        public Galerie()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientLogIn().Show();
        }

        private void btnDespreHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutForm().Show();
        }

        private void btnCamere_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CamereForm().Show();
        }

        private void btnTarife_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PricesPage().Show();
        }

        private void btnGalerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Galerie().Show();
        }

        private void btnFacilitati_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FacilitatiForrm().Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ContactForm().Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffLogin().Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffLogin().Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            groupBox1.Show();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            groupBox2.Show();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            groupBox4.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            groupBox5.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            groupBox5.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            groupBox6.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            groupBox6.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox7.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            groupBox7.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            groupBox8.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            groupBox8.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            groupBox9.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            groupBox9.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            groupBox10.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            groupBox10.Hide();
        }

        private void Galerie_Load(object sender, EventArgs e)
        {

        }
    }
}
