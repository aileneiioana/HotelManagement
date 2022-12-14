using System.Windows.Forms;
namespace HotelManagement
{
    partial class MainStaff
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            this.singoutpb = new System.Windows.Forms.PictureBox();
            this.reservationpb = new System.Windows.Forms.PictureBox();
            this.roompb = new System.Windows.Forms.PictureBox();
            this.clientpb = new System.Windows.Forms.PictureBox();
            this.staffpb = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singoutpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roompb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffpb)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 66);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 28F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(387, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 66);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 28F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1101, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 66);
            this.label5.TabIndex = 10;
            this.label5.Text = "Staff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 28F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(810, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 66);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reservation";
            // 
            // exit
            // 
            this.exit.Image = global::HotelManagement.Properties.Resources.close;
            this.exit.Location = new System.Drawing.Point(1387, 4);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(46, 45);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // singoutpb
            // 
            this.singoutpb.Image = global::HotelManagement.Properties.Resources.log_out;
            this.singoutpb.Location = new System.Drawing.Point(625, 689);
            this.singoutpb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.singoutpb.Name = "singoutpb";
            this.singoutpb.Size = new System.Drawing.Size(207, 166);
            this.singoutpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.singoutpb.TabIndex = 5;
            this.singoutpb.TabStop = false;
            this.singoutpb.Click += new System.EventHandler(this.singoutpb_Click);
            // 
            // reservationpb
            // 
            this.reservationpb.Image = global::HotelManagement.Properties.Resources.reservation;
            this.reservationpb.Location = new System.Drawing.Point(861, 490);
            this.reservationpb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reservationpb.Name = "reservationpb";
            this.reservationpb.Size = new System.Drawing.Size(207, 166);
            this.reservationpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.reservationpb.TabIndex = 4;
            this.reservationpb.TabStop = false;
            this.reservationpb.Click += new System.EventHandler(this.reservationpb_Click);
            // 
            // roompb
            // 
            this.roompb.Image = global::HotelManagement.Properties.Resources.room;
            this.roompb.Location = new System.Drawing.Point(372, 490);
            this.roompb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roompb.Name = "roompb";
            this.roompb.Size = new System.Drawing.Size(207, 166);
            this.roompb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roompb.TabIndex = 3;
            this.roompb.TabStop = false;
            this.roompb.Click += new System.EventHandler(this.roompb_Click);
            // 
            // clientpb
            // 
            this.clientpb.Image = global::HotelManagement.Properties.Resources.client;
            this.clientpb.Location = new System.Drawing.Point(170, 232);
            this.clientpb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientpb.Name = "clientpb";
            this.clientpb.Size = new System.Drawing.Size(207, 166);
            this.clientpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.clientpb.TabIndex = 2;
            this.clientpb.TabStop = false;
            this.clientpb.Click += new System.EventHandler(this.clientpb_Click);
            // 
            // staffpb
            // 
            this.staffpb.Image = global::HotelManagement.Properties.Resources.staff;
            this.staffpb.Location = new System.Drawing.Point(1076, 232);
            this.staffpb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffpb.Name = "staffpb";
            this.staffpb.Size = new System.Drawing.Size(196, 166);
            this.staffpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.staffpb.TabIndex = 1;
            this.staffpb.TabStop = false;
            this.staffpb.Click += new System.EventHandler(this.staffpb_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 81;
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "LIAV Hotel";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(465, 23);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(10, 14, 10, 14);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 10;
            this.guna2TextBox1.Size = new System.Drawing.Size(563, 165);
            this.guna2TextBox1.TabIndex = 18;
            // 
            // MainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1436, 900);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.singoutpb);
            this.Controls.Add(this.reservationpb);
            this.Controls.Add(this.roompb);
            this.Controls.Add(this.clientpb);
            this.Controls.Add(this.staffpb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singoutpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roompb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox staffpb;
        private PictureBox clientpb;
        private PictureBox roompb;
        private PictureBox reservationpb;
        private PictureBox singoutpb;
        private PictureBox exit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}