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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientinfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.clientnametbl = new System.Windows.Forms.RichTextBox();
            this.clientphonetb = new System.Windows.Forms.RichTextBox();
            this.clientctrytb = new System.Windows.Forms.ComboBox();
            this.ClientGridview = new System.Windows.Forms.DataGridView();
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
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 81);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informaţii Clienţi";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Datelbl.Location = new System.Drawing.Point(797, 44);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(57, 25);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            // 
            // clientnametbl
            // 
            this.clientnametbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnametbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientnametbl.Location = new System.Drawing.Point(81, 229);
            this.clientnametbl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.Size = new System.Drawing.Size(215, 35);
            this.clientnametbl.TabIndex = 2;
            this.clientnametbl.Text = "Nume";
            // 
            // clientphonetb
            // 
            this.clientphonetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientphonetb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientphonetb.Location = new System.Drawing.Point(81, 280);
            this.clientphonetb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clientphonetb.Name = "clientphonetb";
            this.clientphonetb.Size = new System.Drawing.Size(215, 35);
            this.clientphonetb.TabIndex = 3;
            this.clientphonetb.Text = "Număr Telefon";
            // 
            // clientctrytb
            // 
            this.clientctrytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientctrytb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientctrytb.FormattingEnabled = true;
            this.clientctrytb.Items.AddRange(new object[] {
            "ROMANIA",
            "SPAIN",
            "USA",
            "CHINA",
            "FRANCE",
            "ITALY"});
            this.clientctrytb.Location = new System.Drawing.Point(81, 378);
            this.clientctrytb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clientctrytb.Name = "clientctrytb";
            this.clientctrytb.Size = new System.Drawing.Size(215, 28);
            this.clientctrytb.TabIndex = 4;
            this.clientctrytb.Text = "Ţara";
            // 
            // ClientGridview
            // 
            this.ClientGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientName,
            this.ClientPhone,
            this.Country,
            this.Password});
            this.ClientGridview.Location = new System.Drawing.Point(355, 101);
            this.ClientGridview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ClientGridview.Name = "ClientGridview";
            this.ClientGridview.RowHeadersWidth = 51;
            this.ClientGridview.RowTemplate.Height = 29;
            this.ClientGridview.Size = new System.Drawing.Size(580, 461);
            this.ClientGridview.TabIndex = 5;
            this.ClientGridview.DoubleClick += new System.EventHandler(this.ClientGridview_DoubleClick);
            // 
            // ClientSearchtb
            // 
            this.ClientSearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSearchtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSearchtb.Location = new System.Drawing.Point(33, 101);
            this.ClientSearchtb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ClientSearchtb.Name = "ClientSearchtb";
            this.ClientSearchtb.Size = new System.Drawing.Size(160, 30);
            this.ClientSearchtb.TabIndex = 9;
            this.ClientSearchtb.Text = "Caută după nume";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Location = new System.Drawing.Point(197, 101);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(106, 29);
            this.Search.TabIndex = 10;
            this.Search.Text = "Caută";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 523);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // refreshpb
            // 
            this.refreshpb.Image = ((System.Drawing.Image)(resources.GetObject("refreshpb.Image")));
            this.refreshpb.Location = new System.Drawing.Point(307, 97);
            this.refreshpb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(31, 34);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshpb.TabIndex = 11;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTb.Location = new System.Drawing.Point(81, 331);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(215, 35);
            this.passwordTb.TabIndex = 13;
            this.passwordTb.Text = "Parola";
            // 
            // clientIdTxtbox
            // 
            this.clientIdTxtbox.Enabled = false;
            this.clientIdTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIdTxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientIdTxtbox.Location = new System.Drawing.Point(81, 176);
            this.clientIdTxtbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clientIdTxtbox.Name = "clientIdTxtbox";
            this.clientIdTxtbox.Size = new System.Drawing.Size(215, 35);
            this.clientIdTxtbox.TabIndex = 14;
            this.clientIdTxtbox.Text = "Id";
            // 
            // BtnDeleteStaff
            // 
            this.BtnDeleteStaff.AutoRoundedCorners = true;
            this.BtnDeleteStaff.BorderRadius = 17;
            this.BtnDeleteStaff.BorderThickness = 1;
            this.BtnDeleteStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDeleteStaff.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteStaff.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteStaff.Location = new System.Drawing.Point(242, 469);
            this.BtnDeleteStaff.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnDeleteStaff.Name = "BtnDeleteStaff";
            this.BtnDeleteStaff.Size = new System.Drawing.Size(96, 36);
            this.BtnDeleteStaff.TabIndex = 36;
            this.BtnDeleteStaff.Text = "Şterge";
            this.BtnDeleteStaff.Click += new System.EventHandler(this.BtnDeleteStaff_Click);
            // 
            // BtnEditStaff
            // 
            this.BtnEditStaff.AutoRoundedCorners = true;
            this.BtnEditStaff.BorderRadius = 17;
            this.BtnEditStaff.BorderThickness = 1;
            this.BtnEditStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEditStaff.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnEditStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEditStaff.ForeColor = System.Drawing.Color.Black;
            this.BtnEditStaff.Location = new System.Drawing.Point(142, 469);
            this.BtnEditStaff.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnEditStaff.Name = "BtnEditStaff";
            this.BtnEditStaff.Size = new System.Drawing.Size(96, 36);
            this.BtnEditStaff.TabIndex = 35;
            this.BtnEditStaff.Text = "Editează";
            this.BtnEditStaff.Click += new System.EventHandler(this.BtnEditStaff_Click);
            // 
            // BtnAddStaff
            // 
            this.BtnAddStaff.AutoRoundedCorners = true;
            this.BtnAddStaff.BorderRadius = 17;
            this.BtnAddStaff.BorderThickness = 1;
            this.BtnAddStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddStaff.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnAddStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAddStaff.ForeColor = System.Drawing.Color.Black;
            this.BtnAddStaff.Location = new System.Drawing.Point(42, 469);
            this.BtnAddStaff.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnAddStaff.Name = "BtnAddStaff";
            this.BtnAddStaff.Size = new System.Drawing.Size(96, 36);
            this.BtnAddStaff.TabIndex = 34;
            this.BtnAddStaff.Text = "Adaugă";
            this.BtnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
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
            this.ClientName.HeaderText = "Nume";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 125;
            // 
            // ClientPhone
            // 
            this.ClientPhone.DataPropertyName = "ClientPhone";
            this.ClientPhone.HeaderText = "NumărTelefon";
            this.ClientPhone.MinimumWidth = 6;
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Width = 125;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "ClientCountry";
            this.Country.HeaderText = "Ţara";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Parola";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // Clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 605);
            this.Controls.Add(this.BtnDeleteStaff);
            this.Controls.Add(this.BtnEditStaff);
            this.Controls.Add(this.BtnAddStaff);
            this.Controls.Add(this.clientIdTxtbox);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ClientSearchtb);
            this.Controls.Add(this.ClientGridview);
            this.Controls.Add(this.clientctrytb);
            this.Controls.Add(this.clientphonetb);
            this.Controls.Add(this.clientnametbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private RichTextBox clientnametbl;
        private RichTextBox clientphonetb;
        private ComboBox clientctrytb;
        private DataGridView ClientGridview;
        private RichTextBox ClientSearchtb;
        private Button Search;
        private Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private PictureBox refreshpb;
        private PictureBox pictureBox1;
        private RichTextBox passwordTb;
        private RichTextBox clientIdTxtbox;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDeleteStaff;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEditStaff;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAddStaff;
        private Label label2;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn ClientPhone;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Password;
    }
}