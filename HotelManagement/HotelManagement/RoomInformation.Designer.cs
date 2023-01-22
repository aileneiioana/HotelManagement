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
            this.Datelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomGridview = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.hoteldbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Datelb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 81);
            this.panel1.TabIndex = 1;
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Century", 15.75F);
            this.Datelb.Location = new System.Drawing.Point(1036, 41);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(59, 25);
            this.Datelb.TabIndex = 54;
            this.Datelb.Text = "Date";
            this.Datelb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informaţii Camere";
            // 
            // RoomGridview
            // 
            this.RoomGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomType,
            this.RoomPhone,
            this.RoomFree});
            this.RoomGridview.Location = new System.Drawing.Point(494, 108);
            this.RoomGridview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RoomGridview.Name = "RoomGridview";
            this.RoomGridview.RowHeadersWidth = 51;
            this.RoomGridview.RowTemplate.Height = 29;
            this.RoomGridview.Size = new System.Drawing.Size(652, 643);
            this.RoomGridview.TabIndex = 6;
            this.RoomGridview.DoubleClick += new System.EventHandler(this.RoomGridview_DoubleClick);
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomId";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.MinimumWidth = 8;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 150;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "RoomType";
            this.RoomType.HeaderText = "Tip";
            this.RoomType.MinimumWidth = 8;
            this.RoomType.Name = "RoomType";
            this.RoomType.Width = 150;
            // 
            // RoomPhone
            // 
            this.RoomPhone.DataPropertyName = "RoomPhone";
            this.RoomPhone.HeaderText = "NumărTelefon";
            this.RoomPhone.MinimumWidth = 8;
            this.RoomPhone.Name = "RoomPhone";
            this.RoomPhone.Width = 150;
            // 
            // RoomFree
            // 
            this.RoomFree.DataPropertyName = "RoomFree";
            this.RoomFree.HeaderText = "Liberă?";
            this.RoomFree.MinimumWidth = 8;
            this.RoomFree.Name = "RoomFree";
            this.RoomFree.Width = 150;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Location = new System.Drawing.Point(240, 138);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(106, 29);
            this.Search.TabIndex = 13;
            this.Search.Text = "Caută";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RoomSearchtbl
            // 
            this.RoomSearchtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSearchtbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RoomSearchtbl.Location = new System.Drawing.Point(76, 138);
            this.RoomSearchtbl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RoomSearchtbl.Name = "RoomSearchtbl";
            this.RoomSearchtbl.Size = new System.Drawing.Size(160, 30);
            this.RoomSearchtbl.TabIndex = 12;
            this.RoomSearchtbl.Text = "Caută Cameră";
            // 
            // roomphonetbl
            // 
            this.roomphonetbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomphonetbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomphonetbl.Location = new System.Drawing.Point(132, 408);
            this.roomphonetbl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.roomphonetbl.Name = "roomphonetbl";
            this.roomphonetbl.Size = new System.Drawing.Size(199, 54);
            this.roomphonetbl.TabIndex = 16;
            this.roomphonetbl.Text = "Număr Telefon";
            // 
            // roomidtbl
            // 
            this.roomidtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomidtbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomidtbl.Location = new System.Drawing.Point(132, 317);
            this.roomidtbl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.roomidtbl.Name = "roomidtbl";
            this.roomidtbl.Size = new System.Drawing.Size(199, 54);
            this.roomidtbl.TabIndex = 15;
            this.roomidtbl.Text = "Număr Cameră";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(134, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Liberă";
            // 
            // Yesbtn
            // 
            this.Yesbtn.AutoSize = true;
            this.Yesbtn.Location = new System.Drawing.Point(207, 502);
            this.Yesbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(14, 13);
            this.Yesbtn.TabIndex = 18;
            this.Yesbtn.UseVisualStyleBackColor = true;
            // 
            // Noradio
            // 
            this.Noradio.AutoSize = true;
            this.Noradio.Location = new System.Drawing.Point(264, 501);
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
            this.Yesradio.Location = new System.Drawing.Point(225, 497);
            this.Yesradio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(30, 20);
            this.Yesradio.TabIndex = 20;
            this.Yesradio.Text = "Da";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(282, 497);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 703);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // refreshpb
            // 
            this.refreshpb.Image = ((System.Drawing.Image)(resources.GetObject("refreshpb.Image")));
            this.refreshpb.Location = new System.Drawing.Point(350, 134);
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
            this.BtnAdd.BorderRadius = 21;
            this.BtnAdd.BorderThickness = 1;
            this.BtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdd.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(76, 608);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 44);
            this.BtnAdd.TabIndex = 28;
            this.BtnAdd.Text = "Adaugă";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoRoundedCorners = true;
            this.BtnEdit.BorderRadius = 21;
            this.BtnEdit.BorderThickness = 1;
            this.BtnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEdit.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEdit.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.Location = new System.Drawing.Point(188, 608);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(96, 44);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "Editeză";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoRoundedCorners = true;
            this.BtnDelete.BorderRadius = 21;
            this.BtnDelete.BorderThickness = 1;
            this.BtnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDelete.FillColor2 = System.Drawing.Color.LightGray;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(298, 608);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(96, 44);
            this.BtnDelete.TabIndex = 30;
            this.BtnDelete.Text = "Şterge";
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
            this.comboBox1.Location = new System.Drawing.Point(132, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Tipul Camerei";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 781);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(712, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Atenţie! Dacă vrei să modifici numărul unei camere, trebuie să o ştergi şi să o a" +
    "daugi din nou cu numărul nou!";
            // 
            // RoomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 839);
            this.Controls.Add(this.label3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RoomInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpb)).EndInit();
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
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEdit;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource hoteldbDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomFree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Datelb;
    }
}