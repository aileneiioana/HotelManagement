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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LoginPagecancelBtn_Click(object sender, EventArgs e)
        {
            FirstNameRegisterTxtBox.Clear();
            LastNameRegisterTextBox.Clear();
            EmailRegisterTextBox.Clear();
            PasswordRegisterTxtBox.Clear();
            PhoneNrRegisterTxtBox.Clear();
            AdressRegisterTxtBox.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }
    }
}
