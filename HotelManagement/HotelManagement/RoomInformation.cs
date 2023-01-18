using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class RoomInformation : Form
    {
        Room_tbl model = new Room_tbl();
        RoomServices roomServices = new RoomServices();
        public RoomInformation()
        {
            InitializeComponent();
            PopulateDataGridView();
            Datelbl.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }

        void Clear()
        {
            roomidtbl.Text = "Room Id";
            roomphonetbl.Text = "Room Phone";
            comboBox1.Text = "Room Type";
            //room.Text = "Room Free";
            model.RoomId = 0;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesbtn.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            model.RoomId = Convert.ToInt32(roomidtbl.Text.Trim());
            model.RoomType = comboBox1.SelectedItem.ToString();
            model.RoomPhone = roomphonetbl.Text.Trim();
            model.RoomFree = isfree;
            roomServices.AddRoom(model);
            Clear();
            PopulateDataGridView();
            MessageBox.Show( comboBox1.SelectedItem.ToString());
        }

        void PopulateDataGridView()
        {
            RoomGridview.AutoGenerateColumns = false;
            RoomGridview.DataSource = roomServices.GetRooms();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesbtn.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            model.RoomId = Convert.ToInt32(roomidtbl.Text.Trim());
            model.RoomType = comboBox1.SelectedItem.ToString();
            model.RoomPhone = roomphonetbl.Text.Trim();
            model.RoomFree = isfree;
            roomServices.EditRoom(model);
            Clear();
            MessageBox.Show("Room Successfully Updated");
            PopulateDataGridView();
        }

        private void RoomGridview_DoubleClick(object sender, EventArgs e)
        {
            if (RoomGridview.CurrentRow.Index != -1)
            {
                model.RoomId = Convert.ToInt32(RoomGridview.CurrentRow.Cells["RoomNumber"].Value);
                model = roomServices.GetRoomById(model.RoomId);
                comboBox1.Text = model.RoomType.ToString();
                roomidtbl.Text = model.RoomId.ToString();
                roomphonetbl.Text = model.RoomPhone.ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Record?", "Room Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                roomServices.DeleteRoom(model);
                PopulateDataGridView();
                Clear();
                MessageBox.Show("Room Successfully Deleted");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainStaff main = new MainStaff();
            main.Show();
            this.Hide();
        }

        private void refreshpb_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int.TryParse(RoomSearchtbl.Text.Trim(), out int id);
            using (HoteldbEntities db = new HoteldbEntities())
            {
                var dataset = roomServices.GetRoomsById(id);
                RoomGridview.DataSource = dataset;
            }

        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = Datelbl.Text.Trim();
            timer1.Start();
            PopulateDataGridView();
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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string isfree;
            if (roomidtbl.Text != "Număr Cameră" && roomphonetbl.Text != "Număr Telefon" && comboBox1.Text != "Tipul Camerei")
            {
                if (isValidPhone(roomphonetbl.Text))
                {
                    if (Yesbtn.Checked == true)
                        isfree = "free";
                    else
                        isfree = "busy";
                    model.RoomId = Convert.ToInt32(roomidtbl.Text.Trim());
                    model.RoomType = comboBox1.SelectedItem.ToString();
                    model.RoomPhone = roomphonetbl.Text.Trim();
                    model.RoomFree = isfree;
                    roomServices.AddRoom(model);
                    Clear();
                    PopulateDataGridView();
                    MessageBox.Show("Cameră adăugată cu Succes!");
                }
                else MessageBox.Show("Numărul de Telefon trebuie introdus în formatul corect!");
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesbtn.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            if (roomidtbl.Text != "Număr Cameră" && roomphonetbl.Text != "Număr Telefon" && comboBox1.Text != "Tipul Camerei")
            {
                if (isValidPhone(roomphonetbl.Text))
                {
                  model.RoomId = Convert.ToInt32(roomidtbl.Text.Trim());
                  model.RoomType = comboBox1.SelectedItem.ToString();
                  model.RoomPhone = roomphonetbl.Text.Trim();
                  model.RoomFree = isfree;
                  roomServices.EditRoom(model);
                  Clear();
                  MessageBox.Show("Cameră actualizată cu Succes!");
                  PopulateDataGridView();
                }
                else MessageBox.Show("Numărul de Telefon trebuie introdus în formatul corect!");
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eşti sigur(ă) că vrei să ştergi această cameră?", "Informaţii Camere", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                roomServices.DeleteRoom(model);
                PopulateDataGridView();
                Clear();
                MessageBox.Show("Cameră Ştearsă cu Succes!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
