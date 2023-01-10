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
    public partial class FacilitatiForrm : Form
    {
        public FacilitatiForrm()
        {
            InitializeComponent();
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

        private void btnDespreHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutForm().Show();
        }

        private void btnFacilitati_Click(object sender, EventArgs e)
        {

        }
    }
}
