using System;
using System.Windows.Forms;
namespace HotelManagement
{
    partial class StaffInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffIdtb = new System.Windows.Forms.TextBox();
            this.StaffNametb = new System.Windows.Forms.TextBox();
            this.PhoneNumbertb = new System.Windows.Forms.TextBox();
            this.Gendercb = new System.Windows.Forms.ComboBox();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StaffView = new System.Windows.Forms.DataGridView();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafffunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDeleteStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnEditStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnAddStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.adresatb = new System.Windows.Forms.TextBox();
            this.functietb = new System.Windows.Forms.TextBox();
            this.parolatb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Datelb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 142);
            this.panel1.TabIndex = 0;
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelb.Location = new System.Drawing.Point(1159, 83);
            this.Datelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(59, 25);
            this.Datelb.TabIndex = 52;
            this.Datelb.Text = "Date";
            this.Datelb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informaţii Staff";
            // 
            // StaffIdtb
            // 
            this.StaffIdtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffIdtb.Location = new System.Drawing.Point(91, 245);
            this.StaffIdtb.Margin = new System.Windows.Forms.Padding(4);
            this.StaffIdtb.Multiline = true;
            this.StaffIdtb.Name = "StaffIdtb";
            this.StaffIdtb.ReadOnly = true;
            this.StaffIdtb.Size = new System.Drawing.Size(321, 52);
            this.StaffIdtb.TabIndex = 1;
            this.StaffIdtb.Text = "Staff Id";
            // 
            // StaffNametb
            // 
            this.StaffNametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StaffNametb.Location = new System.Drawing.Point(91, 305);
            this.StaffNametb.Margin = new System.Windows.Forms.Padding(4);
            this.StaffNametb.Multiline = true;
            this.StaffNametb.Name = "StaffNametb";
            this.StaffNametb.Size = new System.Drawing.Size(321, 52);
            this.StaffNametb.TabIndex = 2;
            this.StaffNametb.Text = "Nume";
            // 
            // PhoneNumbertb
            // 
            this.PhoneNumbertb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PhoneNumbertb.Location = new System.Drawing.Point(91, 365);
            this.PhoneNumbertb.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumbertb.Multiline = true;
            this.PhoneNumbertb.Name = "PhoneNumbertb";
            this.PhoneNumbertb.Size = new System.Drawing.Size(321, 52);
            this.PhoneNumbertb.TabIndex = 3;
            this.PhoneNumbertb.Text = "Număr Telefon";
            // 
            // Gendercb
            // 
            this.Gendercb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gendercb.FormattingEnabled = true;
            this.Gendercb.Items.AddRange(new object[] {
            "BĂRBAT",
            "FEMEIE"});
            this.Gendercb.Location = new System.Drawing.Point(91, 663);
            this.Gendercb.Margin = new System.Windows.Forms.Padding(4);
            this.Gendercb.Name = "Gendercb";
            this.Gendercb.Size = new System.Drawing.Size(321, 28);
            this.Gendercb.TabIndex = 4;
            this.Gendercb.Text = "Gen";
            // 
            // Searchtb
            // 
            this.Searchtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Searchtb.Location = new System.Drawing.Point(38, 171);
            this.Searchtb.Margin = new System.Windows.Forms.Padding(4);
            this.Searchtb.Multiline = true;
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(238, 44);
            this.Searchtb.TabIndex = 9;
            this.Searchtb.Text = "Nume";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(284, 171);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(159, 45);
            this.Search.TabIndex = 10;
            this.Search.Text = "Caută";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // refreshpb
            // 
            this.refreshpb.Image = ((System.Drawing.Image)(resources.GetObject("refreshpb.Image")));
            this.refreshpb.Location = new System.Drawing.Point(450, 171);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(47, 52);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshpb.TabIndex = 12;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // StaffView
            // 
            this.StaffView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffId,
            this.Staffname,
            this.Staffaddress,
            this.Stafffunction,
            this.Staffphone,
            this.Staffemail,
            this.Gender,
            this.Staffpassword});
            this.StaffView.Location = new System.Drawing.Point(549, 158);
            this.StaffView.Margin = new System.Windows.Forms.Padding(4);
            this.StaffView.Name = "StaffView";
            this.StaffView.RowHeadersWidth = 51;
            this.StaffView.RowTemplate.Height = 25;
            this.StaffView.Size = new System.Drawing.Size(854, 710);
            this.StaffView.TabIndex = 5;
            this.StaffView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffView_DoubleClick);
            // 
            // StaffId
            // 
            this.StaffId.DataPropertyName = "StaffId";
            this.StaffId.HeaderText = "StaffId";
            this.StaffId.MinimumWidth = 6;
            this.StaffId.Name = "StaffId";
            this.StaffId.Width = 125;
            // 
            // Staffname
            // 
            this.Staffname.DataPropertyName = "Staffname";
            this.Staffname.HeaderText = "Nume";
            this.Staffname.MinimumWidth = 6;
            this.Staffname.Name = "Staffname";
            this.Staffname.Width = 125;
            // 
            // Staffaddress
            // 
            this.Staffaddress.DataPropertyName = "Staffaddress";
            this.Staffaddress.HeaderText = "Adresă";
            this.Staffaddress.Name = "Staffaddress";
            // 
            // Stafffunction
            // 
            this.Stafffunction.DataPropertyName = "Stafffunction";
            this.Stafffunction.HeaderText = "Funcţie";
            this.Stafffunction.Name = "Stafffunction";
            // 
            // Staffphone
            // 
            this.Staffphone.DataPropertyName = "Staffphone";
            this.Staffphone.HeaderText = "NumărTelefon";
            this.Staffphone.MinimumWidth = 6;
            this.Staffphone.Name = "Staffphone";
            this.Staffphone.Width = 125;
            // 
            // Staffemail
            // 
            this.Staffemail.DataPropertyName = "Staffemail";
            this.Staffemail.HeaderText = "Email";
            this.Staffemail.Name = "Staffemail";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gen";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Staffpassword
            // 
            this.Staffpassword.DataPropertyName = "Staffpassword";
            this.Staffpassword.HeaderText = "Parolă";
            this.Staffpassword.MinimumWidth = 6;
            this.Staffpassword.Name = "Staffpassword";
            this.Staffpassword.Visible = false;
            this.Staffpassword.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 791);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnDeleteStaff
            // 
            this.BtnDeleteStaff.AutoRoundedCorners = true;
            this.BtnDeleteStaff.BorderRadius = 27;
            this.BtnDeleteStaff.BorderThickness = 1;
            this.BtnDeleteStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDeleteStaff.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteStaff.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteStaff.Location = new System.Drawing.Point(337, 727);
            this.BtnDeleteStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteStaff.Name = "BtnDeleteStaff";
            this.BtnDeleteStaff.Size = new System.Drawing.Size(117, 56);
            this.BtnDeleteStaff.TabIndex = 33;
            this.BtnDeleteStaff.Text = "Şterge";
            this.BtnDeleteStaff.Click += new System.EventHandler(this.BtnDeleteStaff_Click);
            // 
            // BtnEditStaff
            // 
            this.BtnEditStaff.AutoRoundedCorners = true;
            this.BtnEditStaff.BorderRadius = 27;
            this.BtnEditStaff.BorderThickness = 1;
            this.BtnEditStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEditStaff.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnEditStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEditStaff.ForeColor = System.Drawing.Color.Black;
            this.BtnEditStaff.Location = new System.Drawing.Point(207, 727);
            this.BtnEditStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditStaff.Name = "BtnEditStaff";
            this.BtnEditStaff.Size = new System.Drawing.Size(117, 56);
            this.BtnEditStaff.TabIndex = 32;
            this.BtnEditStaff.Text = "Editează";
            this.BtnEditStaff.Click += new System.EventHandler(this.BtnEditStaff_Click);
            // 
            // BtnAddStaff
            // 
            this.BtnAddStaff.AutoRoundedCorners = true;
            this.BtnAddStaff.BorderRadius = 27;
            this.BtnAddStaff.BorderThickness = 1;
            this.BtnAddStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddStaff.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnAddStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAddStaff.ForeColor = System.Drawing.Color.Black;
            this.BtnAddStaff.Location = new System.Drawing.Point(77, 727);
            this.BtnAddStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddStaff.Name = "BtnAddStaff";
            this.BtnAddStaff.Size = new System.Drawing.Size(117, 56);
            this.BtnAddStaff.TabIndex = 31;
            this.BtnAddStaff.Text = "Adaugă";
            this.BtnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // emailtb
            // 
            this.emailtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailtb.Location = new System.Drawing.Point(91, 425);
            this.emailtb.Margin = new System.Windows.Forms.Padding(4);
            this.emailtb.Multiline = true;
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(321, 52);
            this.emailtb.TabIndex = 34;
            this.emailtb.Text = "Email";
            // 
            // adresatb
            // 
            this.adresatb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adresatb.Location = new System.Drawing.Point(91, 485);
            this.adresatb.Margin = new System.Windows.Forms.Padding(4);
            this.adresatb.Multiline = true;
            this.adresatb.Name = "adresatb";
            this.adresatb.Size = new System.Drawing.Size(321, 52);
            this.adresatb.TabIndex = 35;
            this.adresatb.Text = "Adresă";
            // 
            // functietb
            // 
            this.functietb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.functietb.Location = new System.Drawing.Point(91, 545);
            this.functietb.Margin = new System.Windows.Forms.Padding(4);
            this.functietb.Multiline = true;
            this.functietb.Name = "functietb";
            this.functietb.Size = new System.Drawing.Size(321, 52);
            this.functietb.TabIndex = 36;
            this.functietb.Text = "Funcţie";
            // 
            // parolatb
            // 
            this.parolatb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parolatb.Location = new System.Drawing.Point(91, 605);
            this.parolatb.Margin = new System.Windows.Forms.Padding(4);
            this.parolatb.Multiline = true;
            this.parolatb.Name = "parolatb";
            this.parolatb.PasswordChar = '*';
            this.parolatb.Size = new System.Drawing.Size(321, 52);
            this.parolatb.TabIndex = 37;
            this.parolatb.Text = "Parolă";
            // 
            // StaffInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.parolatb);
            this.Controls.Add(this.functietb);
            this.Controls.Add(this.adresatb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.BtnDeleteStaff);
            this.Controls.Add(this.BtnEditStaff);
            this.Controls.Add(this.BtnAddStaff);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Searchtb);
            this.Controls.Add(this.StaffView);
            this.Controls.Add(this.Gendercb);
            this.Controls.Add(this.PhoneNumbertb);
            this.Controls.Add(this.StaffNametb);
            this.Controls.Add(this.StaffIdtb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StaffInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Panel panel1;
        private TextBox StaffNametb;
        private TextBox PhoneNumbertb;
        private ComboBox Gendercb;
        private TextBox Searchtb;
        private Button Search;
        private PictureBox refreshpb;
        private System.Windows.Forms.Timer timer1;
        private DataGridView StaffView;
        public TextBox StaffIdtb;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDeleteStaff;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEditStaff;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAddStaff;
        private Label label2;
        private Label Datelb;
        private TextBox emailtb;
        private TextBox adresatb;
        private TextBox functietb;
        private TextBox parolatb;
        private DataGridViewTextBoxColumn StaffId;
        private DataGridViewTextBoxColumn Staffname;
        private DataGridViewTextBoxColumn Staffaddress;
        private DataGridViewTextBoxColumn Stafffunction;
        private DataGridViewTextBoxColumn Staffphone;
        private DataGridViewTextBoxColumn Staffemail;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Staffpassword;
    }
}