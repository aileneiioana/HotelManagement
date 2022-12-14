using System.Windows.Forms;

namespace HotelManagement
{
    partial class Clientinfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientnametbl = new System.Windows.Forms.RichTextBox();
            this.clientphonetb = new System.Windows.Forms.RichTextBox();
            this.clientctrytb = new System.Windows.Forms.ComboBox();
            this.ClientGridview = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClientSearchtb = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.passwordTb = new System.Windows.Forms.RichTextBox();
            this.clientIdTxtbox = new System.Windows.Forms.RichTextBox();
            this.BtnDeleteStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnEditStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnAddStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 125);
            this.panel1.TabIndex = 0;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Datelbl.Location = new System.Drawing.Point(1284, 61);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(84, 37);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(603, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            // 
            // clientnametbl
            // 
            this.clientnametbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientnametbl.Location = new System.Drawing.Point(213, 299);
            this.clientnametbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.Size = new System.Drawing.Size(238, 43);
            this.clientnametbl.TabIndex = 2;
            this.clientnametbl.Text = "ClientName";
            // 
            // clientphonetb
            // 
            this.clientphonetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientphonetb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientphonetb.Location = new System.Drawing.Point(213, 361);
            this.clientphonetb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientphonetb.Name = "clientphonetb";
            this.clientphonetb.Size = new System.Drawing.Size(238, 44);
            this.clientphonetb.TabIndex = 3;
            this.clientphonetb.Text = "Phone Number";
            // 
            // clientctrytb
            // 
            this.clientctrytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientctrytb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientctrytb.FormattingEnabled = true;
            this.clientctrytb.Items.AddRange(new object[] {
            "ROMANIA",
            "SPAIN",
            "USA",
            "CHINA",
            "FRANCE",
            "ITALY"});
            this.clientctrytb.Location = new System.Drawing.Point(213, 485);
            this.clientctrytb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientctrytb.Name = "clientctrytb";
            this.clientctrytb.Size = new System.Drawing.Size(238, 37);
            this.clientctrytb.TabIndex = 4;
            this.clientctrytb.Text = "Country";
            // 
            // ClientGridview
            // 
            this.ClientGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientName,
            this.PhoneNum,
            this.Country,
            this.Password});
            this.ClientGridview.Location = new System.Drawing.Point(555, 232);
            this.ClientGridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientGridview.Name = "ClientGridview";
            this.ClientGridview.RowHeadersWidth = 51;
            this.ClientGridview.RowTemplate.Height = 29;
            this.ClientGridview.Size = new System.Drawing.Size(829, 512);
            this.ClientGridview.TabIndex = 5;
            this.ClientGridview.DoubleClick += new System.EventHandler(this.ClientGridview_DoubleClick);
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.MinimumWidth = 6;
            this.ClientId.Name = "ClientId";
            this.ClientId.Width = 125;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 125;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "ClientPhone";
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.MinimumWidth = 6;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 125;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "ClientCountry";
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(166, 564);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 51);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(263, 564);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(90, 51);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(360, 564);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(134, 51);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClientSearchtb
            // 
            this.ClientSearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientSearchtb.Location = new System.Drawing.Point(922, 165);
            this.ClientSearchtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientSearchtb.Name = "ClientSearchtb";
            this.ClientSearchtb.Size = new System.Drawing.Size(238, 46);
            this.ClientSearchtb.TabIndex = 9;
            this.ClientSearchtb.Text = "ClientSearch";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Location = new System.Drawing.Point(1167, 158);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(147, 55);
            this.Search.TabIndex = 10;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(64, 759);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // refreshpb
            // 
            this.refreshpb.Image = global::HotelManagement.Properties.Resources.refresh;
            this.refreshpb.Location = new System.Drawing.Point(1322, 158);
            this.refreshpb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(48, 52);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refreshpb.TabIndex = 11;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.passwordTb.Location = new System.Drawing.Point(213, 422);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(238, 44);
            this.passwordTb.TabIndex = 13;
            this.passwordTb.Text = "Password";
            // 
            // clientIdTxtbox
            // 
            this.clientIdTxtbox.Enabled = false;
            this.clientIdTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIdTxtbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientIdTxtbox.Location = new System.Drawing.Point(213, 232);
            this.clientIdTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientIdTxtbox.Name = "clientIdTxtbox";
            this.clientIdTxtbox.Size = new System.Drawing.Size(238, 43);
            this.clientIdTxtbox.TabIndex = 14;
            this.clientIdTxtbox.Text = "Client Id";
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
            this.BtnDeleteStaff.Location = new System.Drawing.Point(393, 669);
            this.BtnDeleteStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteStaff.Name = "BtnDeleteStaff";
            this.BtnDeleteStaff.Size = new System.Drawing.Size(117, 56);
            this.BtnDeleteStaff.TabIndex = 36;
            this.BtnDeleteStaff.Text = "Delete";
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
            this.BtnEditStaff.Location = new System.Drawing.Point(263, 669);
            this.BtnEditStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditStaff.Name = "BtnEditStaff";
            this.BtnEditStaff.Size = new System.Drawing.Size(117, 56);
            this.BtnEditStaff.TabIndex = 35;
            this.BtnEditStaff.Text = "Edit";
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
            this.BtnAddStaff.Location = new System.Drawing.Point(133, 669);
            this.BtnAddStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddStaff.Name = "BtnAddStaff";
            this.BtnAddStaff.Size = new System.Drawing.Size(117, 56);
            this.BtnAddStaff.TabIndex = 34;
            this.BtnAddStaff.Text = "Add";
            // 
            // Clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 900);
            this.Controls.Add(this.BtnDeleteStaff);
            this.Controls.Add(this.BtnEditStaff);
            this.Controls.Add(this.BtnAddStaff);
            this.Controls.Add(this.clientIdTxtbox);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ClientSearchtb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ClientGridview);
            this.Controls.Add(this.clientctrytb);
            this.Controls.Add(this.clientphonetb);
            this.Controls.Add(this.clientnametbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientinfo";
            this.Load += new System.EventHandler(this.Clientinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RichTextBox clientnametbl;
        private RichTextBox clientphonetb;
        private ComboBox clientctrytb;
        private DataGridView ClientGridview;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private RichTextBox ClientSearchtb;
        private Button Search;
        private Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private PictureBox refreshpb;
        private PictureBox pictureBox1;
        private RichTextBox passwordTb;
        private RichTextBox clientIdTxtbox;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn PhoneNum;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Password;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDeleteStaff;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEditStaff;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAddStaff;
    }
}