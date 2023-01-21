using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Services;

namespace HotelManagement
{
    public partial class Register : Form
    { 
            Client_tbl model = new Client_tbl();
            ClientServices clientServices = new ClientServices();
        public Register()
        {
            InitializeComponent();
           
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterGpBx.Show();
            linkRegister.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutForm().Show();
        }
        private void LoginPageLogInbtn_Click(object sender, EventArgs e)
        {
            ClientServices ClientServices = new ClientServices();
            var dataset = ClientServices.validate(PhoneNrTxtbox.Text, PasswordLogInTxtBox.Text);
            if (dataset != null)
            {
                Booking mf = new Booking();
                mf.Show();
                this.Hide();
                MessageBox.Show("Logare cu succes!");
            }
            else
            {
                MessageBox.Show("Parola sau numar de telefon incorecte");
            }
        }


        private void cancelRegisterbtn_Click(object sender, EventArgs e)
        {
            RegisterGpBx.Hide();
            linkRegister.Show();
        }
        public static bool isValidPhone(string phone)
        {
            Regex emailReges = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

            return (emailReges.IsMatch(phone) && phone.Length==10);
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (clientNametxtBox.Text != string.Empty && clientPhoneNr.Text != string.Empty
                && ClientCountryTxtbox.Text != string.Empty && ClientPassTxt.Text != string.Empty && confirmPasstxtbox.Text != string.Empty)
              { if (isValidPhone(clientPhoneNr.Text))
               
                 {
                      if (ClientPassTxt.Text == confirmPasstxtbox.Text)
                      {
                          if (clientServices.GetClientByPhone(clientPhoneNr.Text.Trim()) == null)
                          {
                                model.ClientName = clientNametxtBox.Text.Trim();
                                model.ClientPhone = clientPhoneNr.Text.Trim();
                                model.ClientCountry = ClientCountryTxtbox.Text.Trim();
                                model.Password = ClientPassTxt.Text.Trim();
                                clientServices.AddClient(model);
                                MessageBox.Show("Cont creat cu succes!");
                                Booking mf = new Booking();
                                mf.Show();
                                this.Hide();
                          }
                            else MessageBox.Show("Exista un cont deja creat cu acest numar de telefon !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                        else MessageBox.Show("Parolele trebuie introduse la fel in ambele campuri", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else MessageBox.Show("Introdu corect numarul de telefon!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else MessageBox.Show("Toate campurile trebuie completate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
