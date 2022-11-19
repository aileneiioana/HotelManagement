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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FirstPage().Show();
        }
        Client_tbl model = new Client_tbl();
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
    }
}
