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
    }
}
