using HotelManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class StaffInformation : Form
    {
        Staff_tbl model = new Staff_tbl();
        StaffServices staffService = new StaffServices();

        public StaffInformation()
        {
            InitializeComponent();
            PopulateDataGridView();
            Datelb.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }

        void Clear()
        {
            StaffIdtb.Text = "Staff Id";
            StaffNametb.Text = "Staff Name";
            PhoneNumbertb.Text = "Phone Number";
            parolatb.Text = "Password";
            Gendercb.Text = "Gender";
            functietb.Text = "Funcţie";
            adresatb.Text = "Adresă";
            emailtb.Text = "Email";
            model.StaffId = 0;
        }

         void PopulateDataGridView()
        {
              StaffView.DataSource = staffService.Getstaff();
        }

        private void StaffView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(StaffView.CurrentRow.Index != -1)
            {
                model.StaffId=Convert.ToInt32(StaffView.CurrentRow.Cells["StaffId"].Value);
                model=staffService.GetStaffById(model.StaffId);
                StaffIdtb.Text = model.StaffId.ToString();
                StaffNametb.Text = model.Staffname;
                PhoneNumbertb.Text = model.Staffphone;
                parolatb.Text= model.Staffpassword;
                Gendercb.Text = model.Gender;
                emailtb.Text = model.Staffemail;
                functietb.Text = model.Stafffunction;
                adresatb.Text = model.Staffaddress;

            } 
        }


        private void DeleteStaffBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Record?", "Staff Info", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
            staffService.DeleteStaff(model);
            PopulateDataGridView();
            Clear();
            MessageBox.Show("Staff Successfully Deleted");
            }
        }

        private void refreshpb_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            MainStaff main = new MainStaff();
            main.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                var dataset = staffService.GetStaffByName(Searchtb.Text);
               StaffView.DataSource = dataset;
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainStaff main = new MainStaff();
            main.Show();
            this.Hide();
        }

        public static bool isValidPhone(string phone)
        {
            Regex emailReges = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

            return (emailReges.IsMatch(phone) && phone.Length == 10);
        }
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

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            if(StaffNametb.Text != "Nume" && PhoneNumbertb.Text!= "Număr Telefon"&& parolatb.Text!="Parolă"&& Gendercb.Text!="Gen" && functietb.Text!= "Funcţie" && adresatb.Text != "Adresă" && emailtb.Text != "Email")
            {
                if (isValidPhone(PhoneNumbertb.Text))
                {
                    if (IsValidEmail(emailtb.Text))
                    {
                        //model.StaffId = Convert.ToInt32(StaffIdtb.Text.Trim());
                        model.Staffname = StaffNametb.Text.Trim();
                        model.Staffphone = PhoneNumbertb.Text.Trim();
                        model.Staffpassword = parolatb.Text.Trim();
                        model.Staffemail = emailtb.Text.Trim();
                        model.Stafffunction = functietb.Text.Trim();
                        model.Staffaddress = adresatb.Text.Trim();
                        model.Gender = Gendercb.Text.Trim();
                        staffService.AddStaff(model);
                        Clear();
                        MessageBox.Show("Staff adăugat cu Succes");
                        PopulateDataGridView();
                    }
                    else MessageBox.Show("Email-ul trebuie introdus corect! Exemplu format corect: email@email.com");
                }
                else MessageBox.Show("Număr Telefon trebuie introdus corect! Trebuie să contină doar cifre!");
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void BtnEditStaff_Click(object sender, EventArgs e)
        {
            if (StaffNametb.Text != "Nume" && PhoneNumbertb.Text != "Număr Telefon" && parolatb.Text != "Parolă" && Gendercb.Text != "Gen" && functietb.Text != "Funcţie" && adresatb.Text != "Adresă" && emailtb.Text != "Email")
            {
                if (isValidPhone(PhoneNumbertb.Text))
                {
                    if (IsValidEmail(emailtb.Text))
                    {
                    //model.StaffId = Convert.ToInt32(StaffIdtb.Text.Trim());
                    model.Staffname = StaffNametb.Text.Trim();
                    model.Staffphone = PhoneNumbertb.Text.Trim();
                    model.Staffpassword = parolatb.Text.Trim();
                    model.Staffemail = emailtb.Text.Trim();
                    model.Stafffunction = functietb.Text.Trim();
                    model.Staffaddress = adresatb.Text.Trim();
                    model.Gender = Gendercb.Text.Trim();
                    staffService.EditStaff(model);
                    Clear();
                    MessageBox.Show("Staff actualizat cu Succes");
                    PopulateDataGridView();
                    }
                    else MessageBox.Show("Email-ul trebuie introdus corect! Exemplu format corect: email@email.com");
                }
                else MessageBox.Show("Număr Telefon trebuie introdus corect! Trebuie să contină doar cifre!");
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void BtnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eşti sigur(ă) că vrei să ştergi această înregistrare?", "Staff Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                staffService.DeleteStaff(model);
                PopulateDataGridView();
                Clear();
                MessageBox.Show("Staff Şters cu Succes");
            }
        }

        private void StaffInformation_Load(object sender, EventArgs e)
        {

        }

        private void Datelb_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
