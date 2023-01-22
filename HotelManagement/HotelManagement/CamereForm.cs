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
    public partial class CamereForm : Form
    {
        public CamereForm()
        {
            InitializeComponent();
        }

        private void btnDespreHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutForm().Show();
        }

        private void btnCamere_Click(object sender, EventArgs e)
        {

        }

        private void btnFacilitati_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FacilitatiForrm().Show();
        }

        private void btnGalerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Galerie().Show();
        }

        private void btnTarife_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PricesPage().Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ContactForm().Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffLogin().Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CameraDSmoreBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void CamereForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBoxC1.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            groupBoxC1.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            groupBoxC2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            groupBoxC2.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            groupBoxC3.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            groupBoxC3.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            groupBoxC4.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            groupBoxC4.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            groupBoxC5.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            groupBoxC5.Hide();
        }
    }
}
