using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

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
            MailMessage mm = new MailMessage("vambarus@yahoo.com", toContacttxt.Text);
            mm.Subject = subiectContacttxt.Text;
            mm.Body = mesajContacttxt.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.mail.yahoo.com";
            smtp.Port = 465;
            System.Net.NetworkCredential nc = new NetworkCredential("vambarus@yahoo.com", "raxhfnppeiupihyg");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
            label9.Text = "Mesajul dumneavoastra a fost trimis catre \r\n" + toContacttxt.Text;
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
