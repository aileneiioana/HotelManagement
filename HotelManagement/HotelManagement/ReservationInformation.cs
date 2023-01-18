using HotelManagement.Services;
using HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class ReservationInformation : Form
    {
        Reservation_tbl model = new Reservation_tbl();
        ReservationServices resServices = new ReservationServices();
        RoomServices roomServices = new RoomServices();

        public ReservationInformation()
        {
            InitializeComponent();
            PopulateDataGridView();
            fillClientcb();
            fillRoomcb();
            Datelb.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }
        void Clear()
        {
            ReservationIdtb.Text = "Id";
            clientcb.Text = "Numele Clientului";
            roomnumbercb.Text = "Numărul Camerei";
            model.ResId = 0;
        }
        void fillClientcb()
        {
            ClientServices clientServices = new ClientServices();
            var dataset = clientServices.GetClientsNames();
            clientcb.DataSource = dataset;
        }

        void fillRoomcb()
        {
            RoomServices roomServices = new RoomServices();
            var dataset = roomServices.GetFreeIDs();
            roomnumbercb.DataSource = dataset;
        }
        void PopulateDataGridView()
        {
            ResView.DataSource = resServices.GetRes();
        }

        private void refreshpb_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void ResView_DoubleClick(object sender, EventArgs e)
        {
            if (ResView.CurrentRow.Index != -1)
            {
                model.ResId = Convert.ToInt32(ResView.CurrentRow.Cells["ResId"].Value);
                model = resServices.GetResById(model.ResId);
                ReservationIdtb.Text = model.ResId.ToString();
                clientcb.Text = model.Client;
                roomnumbercb.Text = model.Room.ToString();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            int.TryParse(Searchtb.Text.Trim(), out int id);
            var dataset = resServices.GetReservationsById(id);
            ResView.DataSource = dataset;
        }


        private void Backbtn_Click(object sender, EventArgs e)
        {
            MainStaff main = new MainStaff();
            main.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainStaff main = new MainStaff();
            main.Show();
            this.Hide();
        }

        private void ReservationInformation_Load(object sender, EventArgs e)
        {

        }

     
        private void BtnAddRes_Click(object sender, EventArgs e)
        {
            DateTime data1 = new DateTime();
            DateTime data2 = new DateTime();
            data1 = dateInTimePicker.Value;
            data2 = dateOutTimePicker.Value;
            
            if (clientcb.Text != "Numele Clientului" && roomnumbercb.Text != "Numărul Camerei")
               {    
                if ((data2 > data1) && (data1 > DateTime.Today)) 
                {
                var model = new Reservation_tbl
                {
                    Client = clientcb.Text,
                    Room = int.Parse(roomnumbercb.Text),
                    DateIn = dateInTimePicker.Value.ToString(),
                    DateOut = dateOutTimePicker.Value.ToString()
                };
                resServices.AddRes(model);
                MessageBox.Show("Rezervare adăugată cu succes!");
                int.TryParse(model.Room.ToString(), out int id);
                roomServices.updateRoomState(id, "busy");
                fillRoomcb();
                PopulateDataGridView();
                Clear();
                } 
               else MessageBox.Show("Perioada trebuie introdusă corect!");
            }
            else MessageBox.Show("Numele Clientului şi Numărul Camerei trebuie introduse!");
        }


        private void BtnDeleteRes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eşti sigur că vrei să ştergi această rezervare_", "Informaţii Rezervări", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resServices.DeleteRes(model);
                PopulateDataGridView();
                MessageBox.Show("Rezervare Ştersă cu Succes");
                int.TryParse(model.Room.ToString(), out int id);
                roomServices.updateRoomState(id, "free");
                fillRoomcb(); 
                Clear();
            }
        }

        private void BtnEditRes_Click(object sender, EventArgs e)
        {
            DateTime data1 = new DateTime();
            DateTime data2 = new DateTime();
            data1 = dateInTimePicker.Value;
            data2 = dateOutTimePicker.Value;

            if (clientcb.Text != "Numele Clientului" && roomnumbercb.Text != "Numărul Camerei")
            {
                if ((data2 > data1) && (data1 > DateTime.Today))
                {

                    var model = new Reservation_tbl
                    {
                        ResId = int.Parse(ReservationIdtb.Text),
                        Client = clientcb.Text,
                        Room = int.Parse(roomnumbercb.Text),
                        DateIn = dateInTimePicker.Text,
                        DateOut = dateOutTimePicker.Text
                    };
                    resServices.EditRes(model);
                    Clear();
                    MessageBox.Show("Rezervare Editată cu Succes");
                    PopulateDataGridView();
                }
                else MessageBox.Show("Perioada trebuie introdusă corect!");
            }
            else MessageBox.Show("Numele Clientului şi Numărul Camerei trebuie introduse!");
        }

            private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MainStaff main = new MainStaff();
            main.Show();
            this.Hide();
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            int.TryParse(Searchtb.Text.Trim(), out int id);
            var dataset = resServices.GetReservationsById(id);
            ResView.DataSource = dataset;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
