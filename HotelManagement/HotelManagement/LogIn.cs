using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Services;

namespace HotelManagement
{
    public partial class LogIn : Form
    { 
            Client_tbl model = new Client_tbl();
            ClientServices clientServices = new ClientServices();
        public LogIn()
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
            new FirstPage().Show();
        }
        private void LoginPageLogInbtn_Click(object sender, EventArgs e)
        {
            ClientServices ClientServices = new ClientServices();
            var dataset = ClientServices.validate(PhoneNrTxtbox.Text, PasswordLogInTxtBox.Text);
            if (dataset != null)
            {
                //Main mf = new Main();
                //mf.Show();
                //this.Hide();
                MessageBox.Show("Log in succesfull!");
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void RegisterGpBx_Enter(object sender, EventArgs e)
        {

        }

        private void cancelRegisterbtn_Click(object sender, EventArgs e)
        {
            RegisterGpBx.Hide();
            linkRegister.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (clientNametxtBox.Text != string.Empty && clientPhoneNr.Text != string.Empty
                && ClientCountryTxtbox.Text != string.Empty && ClientPassTxt.Text != string.Empty && confirmPasstxtbox.Text != string.Empty)
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
                        MessageBox.Show("Account succesfully created!");
                    }
                    else MessageBox.Show("Account already created with this phone number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Please enter the same password in both fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please enter value in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
