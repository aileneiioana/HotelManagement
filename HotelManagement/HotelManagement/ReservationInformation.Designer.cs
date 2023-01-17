namespace HotelManagement
{
    partial class ReservationInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInformation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roomnumbercb = new System.Windows.Forms.ComboBox();
            this.clientcb = new System.Windows.Forms.ComboBox();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.Button();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.ResView = new System.Windows.Forms.DataGridView();
            this.dateOutTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateInTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReservationIdtb = new System.Windows.Forms.TextBox();
            this.Datelb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnDeleteRes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnEditRes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnAddRes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ResId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 490);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // roomnumbercb
            // 
            this.roomnumbercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.roomnumbercb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomnumbercb.FormattingEnabled = true;
            this.roomnumbercb.Location = new System.Drawing.Point(76, 298);
            this.roomnumbercb.Name = "roomnumbercb";
            this.roomnumbercb.Size = new System.Drawing.Size(215, 28);
            this.roomnumbercb.TabIndex = 41;
            this.roomnumbercb.Text = "Numărul Camerei";
            // 
            // clientcb
            // 
            this.clientcb.AccessibleName = "";
            this.clientcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientcb.FormattingEnabled = true;
            this.clientcb.Location = new System.Drawing.Point(76, 252);
            this.clientcb.Name = "clientcb";
            this.clientcb.Size = new System.Drawing.Size(215, 28);
            this.clientcb.TabIndex = 40;
            this.clientcb.Text = "Numele Clientului";
            // 
            // refreshpb
            // 
            this.refreshpb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshpb.Image = global::HotelManagement.Properties.Resources.refresh;
            this.refreshpb.Location = new System.Drawing.Point(525, 147);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(0, 0);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refreshpb.TabIndex = 36;
            this.refreshpb.TabStop = false;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(188, 138);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(106, 29);
            this.Search.TabIndex = 35;
            this.Search.Text = "Caută";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // Searchtb
            // 
            this.Searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Searchtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Searchtb.Location = new System.Drawing.Point(24, 138);
            this.Searchtb.Multiline = true;
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(160, 30);
            this.Searchtb.TabIndex = 34;
            this.Searchtb.Text = "Caută Rezervare";
            // 
            // ResView
            // 
            this.ResView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResId,
            this.Client,
            this.Room,
            this.DateIn,
            this.DateOut});
            this.ResView.Location = new System.Drawing.Point(389, 122);
            this.ResView.Name = "ResView";
            this.ResView.RowHeadersWidth = 51;
            this.ResView.RowTemplate.Height = 25;
            this.ResView.Size = new System.Drawing.Size(538, 417);
            this.ResView.TabIndex = 33;
            // 
            // dateOutTimePicker
            // 
            this.dateOutTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateOutTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateOutTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOutTimePicker.Location = new System.Drawing.Point(76, 388);
            this.dateOutTimePicker.Name = "dateOutTimePicker";
            this.dateOutTimePicker.Size = new System.Drawing.Size(215, 27);
            this.dateOutTimePicker.TabIndex = 32;
            // 
            // dateInTimePicker
            // 
            this.dateInTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateInTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInTimePicker.Location = new System.Drawing.Point(76, 341);
            this.dateInTimePicker.Name = "dateInTimePicker";
            this.dateInTimePicker.Size = new System.Drawing.Size(215, 27);
            this.dateInTimePicker.TabIndex = 30;
            // 
            // ReservationIdtb
            // 
            this.ReservationIdtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ReservationIdtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReservationIdtb.Location = new System.Drawing.Point(76, 198);
            this.ReservationIdtb.Multiline = true;
            this.ReservationIdtb.Name = "ReservationIdtb";
            this.ReservationIdtb.Size = new System.Drawing.Size(215, 35);
            this.ReservationIdtb.TabIndex = 29;
            this.ReservationIdtb.Text = "Id";
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelb.Location = new System.Drawing.Point(793, 76);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(59, 25);
            this.Datelb.TabIndex = 1;
            this.Datelb.Text = "Date";
            this.Datelb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Datelb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 116);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informaţii Rezervări";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(305, 138);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // BtnDeleteRes
            // 
            this.BtnDeleteRes.AutoRoundedCorners = true;
            this.BtnDeleteRes.BorderRadius = 17;
            this.BtnDeleteRes.BorderThickness = 1;
            this.BtnDeleteRes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDeleteRes.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnDeleteRes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteRes.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteRes.Location = new System.Drawing.Point(220, 443);
            this.BtnDeleteRes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnDeleteRes.Name = "BtnDeleteRes";
            this.BtnDeleteRes.Size = new System.Drawing.Size(86, 36);
            this.BtnDeleteRes.TabIndex = 49;
            this.BtnDeleteRes.Text = "Şterge";
            this.BtnDeleteRes.Click += new System.EventHandler(this.BtnDeleteRes_Click);
            // 
            // BtnEditRes
            // 
            this.BtnEditRes.AutoRoundedCorners = true;
            this.BtnEditRes.BorderRadius = 17;
            this.BtnEditRes.BorderThickness = 1;
            this.BtnEditRes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEditRes.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnEditRes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEditRes.ForeColor = System.Drawing.Color.Black;
            this.BtnEditRes.Location = new System.Drawing.Point(130, 443);
            this.BtnEditRes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnEditRes.Name = "BtnEditRes";
            this.BtnEditRes.Size = new System.Drawing.Size(86, 36);
            this.BtnEditRes.TabIndex = 48;
            this.BtnEditRes.Text = "Editează";
            this.BtnEditRes.Click += new System.EventHandler(this.BtnEditRes_Click);
            // 
            // BtnAddRes
            // 
            this.BtnAddRes.AutoRoundedCorners = true;
            this.BtnAddRes.BorderRadius = 17;
            this.BtnAddRes.BorderThickness = 1;
            this.BtnAddRes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddRes.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnAddRes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAddRes.ForeColor = System.Drawing.Color.Black;
            this.BtnAddRes.Location = new System.Drawing.Point(40, 443);
            this.BtnAddRes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnAddRes.Name = "BtnAddRes";
            this.BtnAddRes.Size = new System.Drawing.Size(86, 36);
            this.BtnAddRes.TabIndex = 47;
            this.BtnAddRes.Text = "Adaugă";
            this.BtnAddRes.Click += new System.EventHandler(this.BtnAddRes_Click);
            // 
            // ResId
            // 
            this.ResId.DataPropertyName = "ResId";
            this.ResId.HeaderText = "ResId";
            this.ResId.MinimumWidth = 6;
            this.ResId.Name = "ResId";
            this.ResId.Width = 125;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 125;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Cameră";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "DateIn";
            this.DateIn.HeaderText = "Check-In";
            this.DateIn.MinimumWidth = 6;
            this.DateIn.Name = "DateIn";
            this.DateIn.Width = 125;
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "DateOut";
            this.DateOut.HeaderText = "Check-Out";
            this.DateOut.MinimumWidth = 6;
            this.DateOut.Name = "DateOut";
            this.DateOut.Width = 125;
            // 
            // ReservationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 549);
            this.Controls.Add(this.BtnDeleteRes);
            this.Controls.Add(this.BtnEditRes);
            this.Controls.Add(this.BtnAddRes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Searchtb);
            this.Controls.Add(this.roomnumbercb);
            this.Controls.Add(this.clientcb);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ResView);
            this.Controls.Add(this.dateOutTimePicker);
            this.Controls.Add(this.dateInTimePicker);
            this.Controls.Add(this.ReservationIdtb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ReservationInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInformation";
            this.Load += new System.EventHandler(this.ReservationInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox roomnumbercb;
        private System.Windows.Forms.ComboBox clientcb;
        private System.Windows.Forms.PictureBox refreshpb;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Searchtb;
        private System.Windows.Forms.DataGridView ResView;
        private System.Windows.Forms.DateTimePicker dateOutTimePicker;
        private System.Windows.Forms.DateTimePicker dateInTimePicker;
        public System.Windows.Forms.TextBox ReservationIdtb;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDeleteRes;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEditRes;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAddRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
    }
}