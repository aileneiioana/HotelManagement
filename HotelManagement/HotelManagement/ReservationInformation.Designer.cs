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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomnumbercb = new System.Windows.Forms.ComboBox();
            this.clientcb = new System.Windows.Forms.ComboBox();
            this.DeleteResfBtn = new System.Windows.Forms.Button();
            this.EditResfBtn = new System.Windows.Forms.Button();
            this.AddResBtn = new System.Windows.Forms.Button();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.Button();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.ResView = new System.Windows.Forms.DataGridView();
            this.ResId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOutTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateInTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReservationIdtb = new System.Windows.Forms.TextBox();
            this.Datelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(-231, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(-208, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Room Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(-208, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Client Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomnumbercb
            // 
            this.roomnumbercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.roomnumbercb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomnumbercb.FormattingEnabled = true;
            this.roomnumbercb.Location = new System.Drawing.Point(-36, 160);
            this.roomnumbercb.Margin = new System.Windows.Forms.Padding(4);
            this.roomnumbercb.Name = "roomnumbercb";
            this.roomnumbercb.Size = new System.Drawing.Size(191, 33);
            this.roomnumbercb.TabIndex = 41;
            this.roomnumbercb.Text = "Room Number";
            // 
            // clientcb
            // 
            this.clientcb.AccessibleName = "";
            this.clientcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientcb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientcb.FormattingEnabled = true;
            this.clientcb.Location = new System.Drawing.Point(-36, 119);
            this.clientcb.Margin = new System.Windows.Forms.Padding(4);
            this.clientcb.Name = "clientcb";
            this.clientcb.Size = new System.Drawing.Size(191, 33);
            this.clientcb.TabIndex = 40;
            this.clientcb.Text = "Client Name";
            // 
            // DeleteResfBtn
            // 
            this.DeleteResfBtn.FlatAppearance.BorderSize = 0;
            this.DeleteResfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteResfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteResfBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteResfBtn.Location = new System.Drawing.Point(-52, 308);
            this.DeleteResfBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteResfBtn.Name = "DeleteResfBtn";
            this.DeleteResfBtn.Size = new System.Drawing.Size(127, 41);
            this.DeleteResfBtn.TabIndex = 39;
            this.DeleteResfBtn.Text = "DELETE";
            this.DeleteResfBtn.UseVisualStyleBackColor = true;
            // 
            // EditResfBtn
            // 
            this.EditResfBtn.FlatAppearance.BorderSize = 0;
            this.EditResfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditResfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EditResfBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditResfBtn.Location = new System.Drawing.Point(-142, 308);
            this.EditResfBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditResfBtn.Name = "EditResfBtn";
            this.EditResfBtn.Size = new System.Drawing.Size(80, 41);
            this.EditResfBtn.TabIndex = 38;
            this.EditResfBtn.Text = "EDIT";
            this.EditResfBtn.UseVisualStyleBackColor = true;
            // 
            // AddResBtn
            // 
            this.AddResBtn.FlatAppearance.BorderSize = 0;
            this.AddResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddResBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AddResBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddResBtn.Location = new System.Drawing.Point(-231, 308);
            this.AddResBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddResBtn.Name = "AddResBtn";
            this.AddResBtn.Size = new System.Drawing.Size(80, 41);
            this.AddResBtn.TabIndex = 37;
            this.AddResBtn.Text = "ADD";
            this.AddResBtn.UseVisualStyleBackColor = true;
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "DateOut";
            this.DateOut.HeaderText = "DateOut";
            this.DateOut.MinimumWidth = 6;
            this.DateOut.Name = "DateOut";
            this.DateOut.Width = 125;
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "DateIn";
            this.DateIn.HeaderText = "DateIn";
            this.DateIn.MinimumWidth = 6;
            this.DateIn.Name = "DateIn";
            this.DateIn.Width = 125;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // refreshpb
            // 
            this.refreshpb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshpb.Image = global::HotelManagement.Properties.Resources.refresh;
            this.refreshpb.Location = new System.Drawing.Point(718, 99);
            this.refreshpb.Margin = new System.Windows.Forms.Padding(4);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(548, 227);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refreshpb.TabIndex = 36;
            this.refreshpb.TabStop = false;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 125;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(832, 57);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 44);
            this.Search.TabIndex = 35;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            // 
            // Searchtb
            // 
            this.Searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Searchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Searchtb.Location = new System.Drawing.Point(592, 64);
            this.Searchtb.Margin = new System.Windows.Forms.Padding(4);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(232, 30);
            this.Searchtb.TabIndex = 34;
            this.Searchtb.Text = "Reservation Search";
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
            this.ResView.Location = new System.Drawing.Point(163, 160);
            this.ResView.Margin = new System.Windows.Forms.Padding(4);
            this.ResView.Name = "ResView";
            this.ResView.RowHeadersWidth = 51;
            this.ResView.RowTemplate.Height = 25;
            this.ResView.Size = new System.Drawing.Size(905, 427);
            this.ResView.TabIndex = 33;
            // 
            // ResId
            // 
            this.ResId.DataPropertyName = "ResId";
            this.ResId.HeaderText = "ResId";
            this.ResId.MinimumWidth = 6;
            this.ResId.Name = "ResId";
            this.ResId.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(-208, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Date Out";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOutTimePicker
            // 
            this.dateOutTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateOutTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateOutTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOutTimePicker.Location = new System.Drawing.Point(-36, 239);
            this.dateOutTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateOutTimePicker.Name = "dateOutTimePicker";
            this.dateOutTimePicker.Size = new System.Drawing.Size(191, 32);
            this.dateOutTimePicker.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(-208, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateInTimePicker
            // 
            this.dateInTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateInTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInTimePicker.Location = new System.Drawing.Point(-36, 198);
            this.dateInTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateInTimePicker.Name = "dateInTimePicker";
            this.dateInTimePicker.Size = new System.Drawing.Size(191, 32);
            this.dateInTimePicker.TabIndex = 30;
            // 
            // ReservationIdtb
            // 
            this.ReservationIdtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ReservationIdtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReservationIdtb.Location = new System.Drawing.Point(-208, 73);
            this.ReservationIdtb.Margin = new System.Windows.Forms.Padding(4);
            this.ReservationIdtb.Name = "ReservationIdtb";
            this.ReservationIdtb.Size = new System.Drawing.Size(281, 30);
            this.ReservationIdtb.TabIndex = 29;
            this.ReservationIdtb.Text = "Reservation Id";
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelb.Location = new System.Drawing.Point(1105, 96);
            this.Datelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(76, 33);
            this.Datelb.TabIndex = 1;
            this.Datelb.Text = "Date";
            this.Datelb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F);
            this.label1.Location = new System.Drawing.Point(480, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Datelb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 142);
            this.panel1.TabIndex = 27;
            // 
            // ReservationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomnumbercb);
            this.Controls.Add(this.clientcb);
            this.Controls.Add(this.DeleteResfBtn);
            this.Controls.Add(this.EditResfBtn);
            this.Controls.Add(this.AddResBtn);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Searchtb);
            this.Controls.Add(this.ResView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOutTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateInTimePicker);
            this.Controls.Add(this.ReservationIdtb);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationInformation";
            this.Text = "ReservationInformation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roomnumbercb;
        private System.Windows.Forms.ComboBox clientcb;
        private System.Windows.Forms.Button DeleteResfBtn;
        private System.Windows.Forms.Button EditResfBtn;
        private System.Windows.Forms.Button AddResBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.PictureBox refreshpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Searchtb;
        private System.Windows.Forms.DataGridView ResView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOutTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateInTimePicker;
        public System.Windows.Forms.TextBox ReservationIdtb;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}