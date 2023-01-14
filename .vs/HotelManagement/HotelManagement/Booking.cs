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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            Datelbl.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutForm().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trimitereMailbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                oMail.From = "vambarus@yahoo.com";
                oMail.To = "ailenei.ioana@yahoo.com";
                oMail.Subject = "Cerere Rezervare";
                String s = " ";
                int pret = 0;
                if (guna2CheckBox1.Checked) {
                    s = s + "Sky Resort ";
                    pret = pret + 250; }
                if (guna2CheckBox5.Checked) {
                    s = s + "Piscina "; 
                    pret = pret + 100; }
                if (guna2CheckBox4.Checked) { 
                    s = s + "Sauna ";
                    pret = pret + 150;
                }
                if (guna2CheckBox3.Checked) { 
                    s = s + "Spa ";
                    pret = pret + 100;
                }
                if (s == " ") s = "Fara Facilitati Extra";
                DateTime data1 = new DateTime();
                DateTime data2 = new DateTime();
                data1 = guna2DateTimePicker1.Value;
                data2 = guna2DateTimePicker2.Value;
                TimeSpan t = data2.Subtract(data1);
                pret = pret + (250 * ((int)t.TotalDays));
                oMail.TextBody = "Clientul cu emailul "+ emaitb.Text+ " si numarul de telefon "+ textBox1.Text + " solicita o camera din data " + guna2DateTimePicker1.Text + " pana in data " + guna2DateTimePicker2.Text + " cu urmatoarele facilitati: " + s+ " \nPretul Total este: "+ pret.ToString() + " lei.";
                SmtpServer oServer = new SmtpServer("smtp.mail.yahoo.com");
                oServer.User = "vambarus@yahoo.com";
                oServer.Password = "szechcdsoxgkkthr";
                oServer.Port = 465;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                Console.WriteLine("start to send email over SSL ...");
                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);
                Console.WriteLine("email was sent successfully!");
                MessageBox.Show("Solicitarea a fost facuta catre receptia hotelului LIAV. Veti fi contactat prin email sau telefonic dupa ce se va verifica disponibilitatea. \nMultumim!");
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
            emaitb.Text= " ";
            textBox1.Text = " ";
        }
         
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {   
            int pret = 0;
            if (guna2CheckBox1.Checked) pret = pret + 250;
            if (guna2CheckBox5.Checked) pret = pret + 100;
            if (guna2CheckBox4.Checked) pret = pret + 150;
            if (guna2CheckBox3.Checked) pret = pret + 100;
            DateTime data1 = new DateTime();
            DateTime data2 = new DateTime();
            data1 = guna2DateTimePicker1.Value;
            data2 = guna2DateTimePicker2.Value;
            TimeSpan t = data2.Subtract(data1);
            pret = pret + (250 * ((int)t.TotalDays));
            //MessageBox.Show(((int)t.TotalDays).ToString());
            guna2HtmlLabel4.Text = pret.ToString();  
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
