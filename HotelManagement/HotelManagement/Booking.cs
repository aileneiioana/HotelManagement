using System;
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
using HotelManagement.Services;
using HotelManagementApplication;

namespace HotelManagement
{
    public partial class Booking : Form
    {

        Reservation_tbl model = new Reservation_tbl();
        ReservationServices resServices = new ReservationServices();
        RoomServices roomServices = new RoomServices();
        List<Reservation_tbl> resList = new List<Reservation_tbl>();
        List<int> RoomIds = new List<int>();
        List<Room_tbl> rooms = new List<Room_tbl>();
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



            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));


        }

        public bool isValidPhone(string phone)
        {
            Regex emailReges = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

            return (emailReges.IsMatch(phone) && phone.Length == 10);
        }
        public Booking()
        {
            InitializeComponent();
            Datelbl.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }
        private void Booking_Load(object sender, EventArgs e)
        {

        }

        public int getTotalDays(DateTime data1, DateTime data2)
        {
            TimeSpan t = data2.Subtract(data1);
            return (int)t.TotalDays;
        }

        public bool checkPediod(DateTime data1, DateTime data2)
        {
            TimeSpan t = data2.Subtract(data1);
            if ((data2 < data1) || (data1 < DateTime.Today)) return false;
            else return true;
        }
        private void trimitereMailbtn_Click(object sender, EventArgs e)
        {
            int x = 0;

            String s = " ";
            int pret = 0;
            if (guna2CheckBox1.Checked)
            {
                s = s + "Masaj ";
                pret = pret + 250;
            }
            if (guna2CheckBox5.Checked)
            {
                s = s + "Piscina ";
                pret = pret + 100;
            }
            if (guna2CheckBox4.Checked)
            {
                s = s + "Sauna ";
                pret = pret + 150;
            }
            if (guna2CheckBox3.Checked)
            {
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
            else if (comboBox1.Text == "Triol")
                pret = pret + (1100 * ((int)t.TotalDays));

            if (comboBox1.Text != "")
            {
                if (IsValidEmail(emailtb.Text))
                {

                    if (data2 > data1)
                   {
                    if (data1 > DateTime.Today)
                    {
                        rooms = roomServices.GetFreeRooms();
                        for (int i = 0; i < rooms.Count; i++)
                        {
                            if (rooms[i].RoomType.ToString() == comboBox1.SelectedItem.ToString() && x == 0)
                            {
                                MessageBox.Show("A fost facut" + rooms[i].RoomId.ToString() + comboBox1.SelectedItem.ToString() + "1");
                                var model = new Reservation_tbl
                                {
                                    Client = numetb.Text,
                                    Room = rooms[i].RoomId,
                                    DateIn = guna2DateTimePicker1.Value,
                                    DateOut = guna2DateTimePicker2.Value

                                };
                                resServices.AddRes(model);
                                MessageBox.Show("Rezervare adăugată cu succes!");
                                x = 1;
                            }
                        }



                        resList = resServices.GetRoomsByFree(guna2DateTimePicker1.Value, guna2DateTimePicker2.Value);
                        for (int i = 0; i < resList.Count; i++)
                        {
                            Reservation_tbl r = resList[i];
                            RoomIds.Add((int)r.Room);
                        }
                        for (int i = 0; i < RoomIds.Count; i++)
                        {
                            Room_tbl room = roomServices.GetRoomById(RoomIds[i]);
                            if (room.RoomType.ToString() == comboBox1.SelectedItem.ToString() && x == 0)
                            {
                                MessageBox.Show("A fost facut" + room.RoomId.ToString() + comboBox1.SelectedItem.ToString());
                                var model = new Reservation_tbl
                                {
                                    Client = numetb.Text,
                                    Room = rooms[i].RoomId,
                                    DateIn = guna2DateTimePicker1.Value,
                                    DateOut = guna2DateTimePicker2.Value

                                };

                                resServices.AddRes(model);
                                MessageBox.Show("Rezervare adăugată cu succes!");
                                numetb.Text = "";
                                comboBox1.Text = "";
                                x = 1;
                            }

                        }


                        if (x == 0) MessageBox.Show("Nu s-a putut face rezervarea. Va rugam incercati alta perioada sau alt tip de camera. Multumim!");
                   
                     }
                    else MessageBox.Show("Perioada rezervarii trebuie introdusa corect! Data CheckIn trebuie sa fie dupa data de astazi!");
                }
                else MessageBox.Show("Perioada rezervarii trebuie introdusa corect! Data CheckOut trebuie sa fie dupa data CheckIn!");

                }
                else MessageBox.Show("Email-ul trebuie introdus in formatul corect! exemplu: email@email.com");


            }
            else MessageBox.Show("Tipul camerei trebuie selectat!");

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
            if (data2 > data1)
            {
                if (data1 > DateTime.Today)
                {
            if (comboBox1.Text == "Camera Dubla Standard")
                pret = pret + (540 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Camera Dubla Superioara")
                pret = pret + (560 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Double Deluxe Room")
                pret = pret + (580 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Camera pentru Familie")
                pret = pret + (1100 * ((int)t.TotalDays));
            else if (comboBox1.Text == "Triol")
                pret = pret + (1100 * ((int)t.TotalDays));
            else if(comboBox1.Text == "") MessageBox.Show("Selecteaza Tipul Camerei!");
                    //MessageBox.Show(((int)t.TotalDays).ToString());

                    guna2HtmlLabel4.Text = pret.ToString();
                }
                else MessageBox.Show("Perioada rezervarii trebuie introdusa corect! Data CheckIn trebuie sa fie dupa data de astazi!");
            }
            else MessageBox.Show("Perioada rezervarii trebuie introdusa corect! Data CheckOut trebuie sa fie dupa data CheckIn!");
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
