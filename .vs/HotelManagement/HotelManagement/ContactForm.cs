using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASendMail;

namespace HotelManagement
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trimitereMailbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                oMail.From = "vambarus@yahoo.com";
                oMail.To = guna2ComboBox1.SelectedItem.ToString();
                oMail.Subject = subiectContacttxt.Text;
                oMail.TextBody = mesajContacttxt.Text;
                SmtpServer oServer = new SmtpServer("smtp.mail.yahoo.com");
                oServer.User = "vambarus@yahoo.com";
                oServer.Password = "szechcdsoxgkkthr";
                oServer.Port = 465;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                Console.WriteLine("start to send email over SSL ...");
                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);
                Console.WriteLine("email was sent successfully!");
                MessageBox.Show("Email was sent successfully!");
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
            guna2ComboBox1.Text = " ";
            subiectContacttxt.Clear();
            mesajContacttxt.Clear();
            

            //MailMessage mm = new MailMessage("vambarus@yahoo.com", toContacttxt.Text);
            //mm.Subject = subiectContacttxt.Text;
            //mm.Body = mesajContacttxt.Text;
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.mail.yahoo.com";
            //smtp.Port = 465;
            //System.Net.NetworkCredential nc = new NetworkCredential("vambarus@yahoo.com", "raxhfnppeiupihyg");
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = nc;
            //smtp.EnableSsl = true;
            //smtp.Send(mm);
            //label9.Text = "Mesajul dumneavoastra a fost trimis catre \r\n" + toContacttxt.Text;
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDespreHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutForm().Show();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnContact_Click(object sender, EventArgs e)
        {

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

        private void btnCamere_Click(object sender, EventArgs e)
        {

        }
    }
}
