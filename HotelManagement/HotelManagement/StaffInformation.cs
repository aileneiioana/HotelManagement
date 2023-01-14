using HotelManagement.Services;
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
            Passwordtb.Text = "Password";
            Gendercb.Text = "Gender";   
            model.StaffId = 0;
        }
        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
           
            model.StaffId= Convert.ToInt32(StaffIdtb.Text.Trim());
            model.Staffname= StaffNametb.Text.Trim();
            model.Staffphone=PhoneNumbertb.Text.Trim();
            model.Staffpassword=Passwordtb.Text.Trim();
            model.Gender=Gendercb.Text.Trim();
            staffService.AddStaff(model);
            Clear();
            MessageBox.Show("Staff Successfully Added");
            PopulateDataGridView();

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
                Passwordtb.Text= model.Staffpassword;
                Gendercb.Text = model.Gender;

            } 
        }

        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            model.StaffId = Convert.ToInt32(StaffIdtb.Text.Trim());
            model.Staffname = StaffNametb.Text.Trim();
            model.Staffphone = PhoneNumbertb.Text.Trim();
            model.Staffpassword = Passwordtb.Text.Trim();
            model.Gender = Gendercb.Text.Trim();
            staffService.EditStaff(model);
            Clear();
            MessageBox.Show("Staff Successfully Updated");
            PopulateDataGridView();
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

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            model.StaffId = Convert.ToInt32(StaffIdtb.Text.Trim());
            model.Staffname = StaffNametb.Text.Trim();
            model.Staffphone = PhoneNumbertb.Text.Trim();
            model.Staffpassword = Passwordtb.Text.Trim();
            model.Gender = Gendercb.Text.Trim();
            staffService.AddStaff(model);
            Clear();
            MessageBox.Show("Staff Successfully Added");
            PopulateDataGridView();
        }

        private void BtnEditStaff_Click(object sender, EventArgs e)
        {
            model.StaffId = Convert.ToInt32(StaffIdtb.Text.Trim());
            model.Staffname = StaffNametb.Text.Trim();
            model.Staffphone = PhoneNumbertb.Text.Trim();
            model.Staffpassword = Passwordtb.Text.Trim();
            model.Gender = Gendercb.Text.Trim();
            staffService.EditStaff(model);
            Clear();
            MessageBox.Show("Staff Successfully Updated");
            PopulateDataGridView();
        }

        private void BtnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Record?", "Staff Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                staffService.DeleteStaff(model);
                PopulateDataGridView();
                Clear();
                MessageBox.Show("Staff Successfully Deleted");
            }
        }

        private void StaffInformation_Load(object sender, EventArgs e)
        {

        }

        private void Datelb_Click(object sender, EventArgs e)
        {

        }
    }
}
