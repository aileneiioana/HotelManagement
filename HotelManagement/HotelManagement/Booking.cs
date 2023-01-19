﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASendMail;

namespace HotelManagement
{
    public partial class Booking : Form
    {



        // Valid email addresses based on regex defined
        // "tony@example.com",
        // "tony.stark@example.net",
        // "tony.stark@example.gov",
        // "TONY@EXAMPLE.GOV",

        // Invalid email addresses based on regex defined
        // "tony@example",
        // "tony@example.co.uk",
        // "tony@example.me"
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None);

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }


  
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$",RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

            
        }

        public bool isValidPhone(string phone)
        {
            Regex emailReges = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

            return (emailReges.IsMatch(phone) && phone.Length==10);
        }
        public Booking()
        {
            InitializeComponent();
            Datelbl.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }
        private void Booking_Load(object sender, EventArgs e)
        {

        }

        public int getTotalDays (DateTime data1, DateTime data2)
        {
            TimeSpan t = data2.Subtract(data1);
            return (int)t.TotalDays;
        }

        public bool checkPediod(DateTime data1, DateTime data2)
        {
            TimeSpan t = data2.Subtract(data1);
            if ( (data2 < data1) || (data1 < DateTime.Today)) return false;
            else return true;
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
                if (s == " ") s = "Fară Facilităţi Extra";
                DateTime data1 = new DateTime();
                DateTime data2 = new DateTime();
                data1 = guna2DateTimePicker1.Value;
                data2 = guna2DateTimePicker2.Value;
                TimeSpan t = data2.Subtract(data1);

                if (comboBox1.Text == "Camera Dubla Standard")
                    pret = pret + (540 * ((int)t.TotalDays));
                else if (comboBox1.Text == "Camera Dubla Superioara")
                    pret = pret + (560 * ((int)t.TotalDays));
                else if (comboBox1.Text == "Double Deluxe Room")
                    pret = pret + (580 * ((int)t.TotalDays));
                else if (comboBox1.Text == "Camera pentru Familie")
                    pret = pret + (1100 * ((int)t.TotalDays));
                else if (comboBox1.Text == "Tirol")
                    pret = pret + (1100 * ((int)t.TotalDays));

                if (comboBox1.Text != "")
                {
                    if (textBox1.Text != " " && textBox1.Text != "")
                    {
                        if (emaitb.Text != " " && emaitb.Text != "")
                        {
                            if (IsValidEmail(emaitb.Text))
                            {
                                if (isValidPhone(textBox1.Text))
                                {
                                    if ((data2 > data1) && (data1 > DateTime.Today))
                                    {
                                        oMail.TextBody = "Clientul cu emailul " + emaitb.Text + " şi numarul de telefon " + textBox1.Text + " solicita o camera" + " de tipul " + comboBox1.SelectedItem.ToString() + " din data " + guna2DateTimePicker1.Text + " pana in data " + guna2DateTimePicker2.Text + " cu urmatoarele facilitati: " + s + " \nPretul Total este: " + pret.ToString() + " lei.";
                                        SmtpServer oServer = new SmtpServer("smtp.mail.yahoo.com");
                                        oServer.User = "vambarus@yahoo.com";
                                        oServer.Password = "nkqfgoqzkpoymzik";
                                        oServer.Port = 465;
                                        oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                                        Console.WriteLine("start to send email over SSL ...");
                                        SmtpClient oSmtp = new SmtpClient();  
                                        oSmtp.SendMail(oServer, oMail);
                                        Console.WriteLine("email was sent successfully!");
                                        MessageBox.Show("Solicitarea ta a fost trimisă recepţiei Hotelului LIAV. Vei fi contactat telefonic sau prin email în cel mai scurt timp. \nMultumim!");
                                    }
                                    else MessageBox.Show("Perioada rezervarii trebuie introdusa corect!");
                                }
                                else MessageBox.Show("Numarul de Telefon trebuie introdus in formatul corect!");
                            }
                            else MessageBox.Show("Email-ul trebuie introdus in formatul corect!");
                        }
                        else MessageBox.Show("Email-ul trebuie introdus! ");
                    }
                    else  MessageBox.Show("Numarul de telefon trebuie introdus!");
                }
                else MessageBox.Show("Tipul camerei trebuie selectat!");
                  
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
            emaitb.Text= "";
            textBox1.Text = "";
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
            if (comboBox1.Text == "Camera Dubla Standard")
                pret = pret + (540 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Camera Dubla Superioara")
                pret = pret + (560 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Double Deluxe Room")
                pret = pret + (580 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Camera pentru Familie")
                pret = pret + (1100 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Tirol")
                pret = pret + (1100 * ((int)t.TotalDays));
            else MessageBox.Show("Selecteaza Tipul Camerei!");
            //MessageBox.Show(((int)t.TotalDays).ToString());
            if ((data2 > data1) && (data1 > DateTime.Today))
            {
                guna2HtmlLabel4.Text = pret.ToString();
            }
            else MessageBox.Show("Perioada rezervarii trebuie introdusa corect!");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutForm main = new AboutForm();
            main.Show();
            this.Hide();
        }
    }
}
