namespace HotelManagement
{
    partial class RoomInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomGridview = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.RoomSearchtbl = new System.Windows.Forms.RichTextBox();
            this.roomphonetbl = new System.Windows.Forms.RichTextBox();
            this.roomidtbl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yesbtn = new System.Windows.Forms.RadioButton();
            this.Noradio = new System.Windows.Forms.RadioButton();
            this.Yesradio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshpb = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hoteldbDataSet = new HotelManagement.HoteldbDataSet();
            this.hoteldbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSetBindingSource)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 81);
            this.panel1.TabIndex = 1;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(728, 44);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(86, 38);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // RoomGridview
            // 
            this.RoomGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomType,
            this.RoomPhone,
            this.RoomFree});
            this.RoomGridview.Location = new System.Drawing.Point(355, 104);
            this.RoomGridview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RoomGridview.Name = "RoomGridview";
            this.RoomGridview.RowHeadersWidth = 51;
            this.RoomGridview.RowTemplate.Height = 29;
            this.RoomGridview.Size = new System.Drawing.Size(580, 448);
            this.RoomGridview.TabIndex = 6;
            this.RoomGridview.DoubleClick += new System.EventHandler(this.RoomGridview_DoubleClick);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Location = new System.Drawing.Point(195, 123);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(106, 29);
            this.Search.TabIndex = 13;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RoomSearchtbl
            // 
            this.RoomSearchtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSearchtbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RoomSearchtbl.Location = new System.Drawing.Point(31, 123);
            this.RoomSearchtbl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RoomSearchtbl.Name = "RoomSearchtbl";
            this.RoomSearchtbl.Size = new System.Drawing.Size(160, 30);
            this.RoomSearchtbl.TabIndex = 12;
            this.RoomSearchtbl.Text = "RoomSearch";
            // 
            // roomphonetbl
            // 
            this.roomphonetbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomphonetbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomphonetbl.Location = new System.Drawing.Point(68, 322);
            this.roomphonetbl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.roomphonetbl.Name = "roomphonetbl";
            this.roomphonetbl.Size = new System.Drawing.Size(215, 45);
            this.roomphonetbl.TabIndex = 16;
            this.roomphonetbl.Text = "Room Phone";
            // 
            // roomidtbl
            // 
            this.roomidtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomidtbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomidtbl.Location = new System.Drawing.Point(68, 250);
            this.roomidtbl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.roomidtbl.Name = "roomidtbl";
            this.roomidtbl.Size = new System.Drawing.Size(215, 45);
            this.roomidtbl.TabIndex = 15;
            this.roomidtbl.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(91, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Free";
            // 
            // Yesbtn
            // 
            this.Yesbtn.AutoSize = true;
            this.Yesbtn.Location = new System.Drawing.Point(157, 393);
            this.Yesbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(14, 13);
            this.Yesbtn.TabIndex = 18;
            this.Yesbtn.UseVisualStyleBackColor = true;
            // 
            // Noradio
            // 
            this.Noradio.AutoSize = true;
            this.Noradio.Location = new System.Drawing.Point(213, 393);
            this.Noradio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Noradio.Name = "Noradio";
            this.Noradio.Size = new System.Drawing.Size(14, 13);
            this.Noradio.TabIndex = 19;
            this.Noradio.UseVisualStyleBackColor = true;
            // 
            // Yesradio
            // 
            this.Yesradio.AutoSize = true;
            this.Yesradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesradio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Yesradio.Location = new System.Drawing.Point(174, 389);
            this.Yesradio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(37, 20);
            this.Yesradio.TabIndex = 20;
            this.Yesradio.Text = "Yes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(231, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 514);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // refreshpb
            // 
            this.refreshpb.Image = ((System.Drawing.Image)(resources.GetObject("refreshpb.Image")));
            this.refreshpb.Location = new System.Drawing.Point(305, 119);
            this.refreshpb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.refreshpb.Name = "refreshpb";
            this.refreshpb.Size = new System.Drawing.Size(31, 34);
            this.refreshpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshpb.TabIndex = 14;
            this.refreshpb.TabStop = false;
            this.refreshpb.Click += new System.EventHandler(this.refreshpb_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoRoundedCorners = true;
            this.BtnAdd.BorderRadius = 17;
            this.BtnAdd.BorderThickness = 1;
            this.BtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdd.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(49, 467);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(78, 36);
            this.BtnAdd.TabIndex = 28;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoRoundedCorners = true;
            this.BtnEdit.BorderRadius = 17;
            this.BtnEdit.BorderThickness = 1;
            this.BtnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEdit.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEdit.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.Location = new System.Drawing.Point(136, 467);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(78, 36);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoRoundedCorners = true;
            this.BtnDelete.BorderRadius = 17;
            this.BtnDelete.BorderThickness = 1;
            this.BtnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDelete.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(223, 467);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 36);
            this.BtnDelete.TabIndex = 30;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Camera Dubla Standard",
            "Camera Dubla Superioara",
            "Camera Dubla Deluxe",
            "Camera pentru Familie",
            "Triol"});
            this.comboBox1.Location = new System.Drawing.Point(68, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 28);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Room Type";
            // 
            // hoteldbDataSet
            // 
            this.hoteldbDataSet.DataSetName = "HoteldbDataSet";
            this.hoteldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoteldbDataSetBindingSource
            // 
            this.hoteldbDataSetBindingSource.DataSource = this.hoteldbDataSet;
            this.hoteldbDataSetBindingSource.Position = 0;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomId";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "RoomType";
            this.RoomType.HeaderText = "RoomType";
            this.RoomType.Name = "RoomType";
            // 
            // RoomPhone
            // 
            this.RoomPhone.DataPropertyName = "RoomPhone";
            this.RoomPhone.HeaderText = "RoomPhone";
            this.RoomPhone.Name = "RoomPhone";
            // 
            // RoomFree
            // 
            this.RoomFree.DataPropertyName = "RoomFree";
            this.RoomFree.HeaderText = "RoomFree";
            this.RoomFree.Name = "RoomFree";
            // 
            // RoomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 585);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Yesradio);
            this.Controls.Add(this.Noradio);
            this.Controls.Add(this.Yesbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomphonetbl);
            this.Controls.Add(this.roomidtbl);
            this.Controls.Add(this.refreshpb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.RoomSearchtbl);
            this.Controls.Add(this.RoomGridview);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RoomInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RoomGridview;
        private System.Windows.Forms.PictureBox refreshpb;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox RoomSearchtbl;
        private System.Windows.Forms.RichTextBox roomphonetbl;
        private System.Windows.Forms.RichTextBox roomidtbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Yesbtn;
        private System.Windows.Forms.RadioButton Noradio;
        private System.Windows.Forms.Label Yesradio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Datelbl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEdit;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource hoteldbDataSetBindingSource;
        private HoteldbDataSet hoteldbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomFree;
    }
}