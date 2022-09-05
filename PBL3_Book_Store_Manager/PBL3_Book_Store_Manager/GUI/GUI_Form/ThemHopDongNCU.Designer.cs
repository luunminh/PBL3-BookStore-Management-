namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    partial class ThemHopDongNCU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.dtp_KetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_BatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThemAnh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbTenNCU = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 58);
            this.panel1.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(413, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Thêm hợp đồng nhà cung ứng";
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(601, 689);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 73);
            this.btHuy.TabIndex = 94;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btOK
            // 
            this.btOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btOK.FlatAppearance.BorderSize = 0;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(279, 689);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(191, 73);
            this.btOK.TabIndex = 95;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // dtp_KetThuc
            // 
            this.dtp_KetThuc.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dtp_KetThuc.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_KetThuc.Location = new System.Drawing.Point(206, 336);
            this.dtp_KetThuc.Name = "dtp_KetThuc";
            this.dtp_KetThuc.Size = new System.Drawing.Size(313, 29);
            this.dtp_KetThuc.TabIndex = 92;
            // 
            // dtp_BatDau
            // 
            this.dtp_BatDau.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dtp_BatDau.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_BatDau.Location = new System.Drawing.Point(207, 218);
            this.dtp_BatDau.Name = "dtp_BatDau";
            this.dtp_BatDau.Size = new System.Drawing.Size(313, 29);
            this.dtp_BatDau.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(31, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 88;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(573, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Hình ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(32, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên nhà cung ứng";
            // 
            // btThemAnh
            // 
            this.btThemAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThemAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btThemAnh.FlatAppearance.BorderSize = 0;
            this.btThemAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemAnh.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemAnh.ForeColor = System.Drawing.Color.White;
            this.btThemAnh.Location = new System.Drawing.Point(805, 605);
            this.btThemAnh.Name = "btThemAnh";
            this.btThemAnh.Size = new System.Drawing.Size(136, 56);
            this.btThemAnh.TabIndex = 95;
            this.btThemAnh.Text = "Chọn ảnh";
            this.btThemAnh.UseVisualStyleBackColor = false;
            this.btThemAnh.Click += new System.EventHandler(this.btThemAnh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(693, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(683, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 501);
            this.panel2.TabIndex = 97;
            // 
            // cbbTenNCU
            // 
            this.cbbTenNCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNCU.FormattingEnabled = true;
            this.cbbTenNCU.Location = new System.Drawing.Point(207, 114);
            this.cbbTenNCU.Name = "cbbTenNCU";
            this.cbbTenNCU.Size = new System.Drawing.Size(313, 33);
            this.cbbTenNCU.TabIndex = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 351);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // ThemHopDongNCU
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 800);
            this.Controls.Add(this.dtp_BatDau);
            this.Controls.Add(this.cbbTenNCU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThemAnh);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dtp_KetThuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThemHopDongNCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHopDongNCU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DateTimePicker dtp_KetThuc;
        private System.Windows.Forms.DateTimePicker dtp_BatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btThemAnh;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbTenNCU;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}