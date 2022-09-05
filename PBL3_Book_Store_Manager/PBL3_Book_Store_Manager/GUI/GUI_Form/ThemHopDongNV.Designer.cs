namespace PBL3_Book_Store_Manager.GUI_Form
{
    partial class ThemHopDongNV
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
            this.btHuy = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHopDongNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_NgayKyKet = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btThemAnh = new System.Windows.Forms.Button();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(647, 659);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 75);
            this.btHuy.TabIndex = 105;
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
            this.btOK.Location = new System.Drawing.Point(299, 659);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(191, 75);
            this.btOK.TabIndex = 106;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(302, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Ngày ký kết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(302, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "Tên nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lbHopDongNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 58);
            this.panel1.TabIndex = 96;
            // 
            // lbHopDongNV
            // 
            this.lbHopDongNV.AutoSize = true;
            this.lbHopDongNV.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHopDongNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbHopDongNV.Location = new System.Drawing.Point(416, 16);
            this.lbHopDongNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHopDongNV.Name = "lbHopDongNV";
            this.lbHopDongNV.Size = new System.Drawing.Size(257, 27);
            this.lbHopDongNV.TabIndex = 46;
            this.lbHopDongNV.Text = "Thêm hợp đồng nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(302, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 101;
            this.label4.Text = "Hình ảnh";
            // 
            // dtp_NgayKyKet
            // 
            this.dtp_NgayKyKet.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dtp_NgayKyKet.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dtp_NgayKyKet.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dtp_NgayKyKet.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKyKet.Location = new System.Drawing.Point(463, 171);
            this.dtp_NgayKyKet.Name = "dtp_NgayKyKet";
            this.dtp_NgayKyKet.Size = new System.Drawing.Size(278, 29);
            this.dtp_NgayKyKet.TabIndex = 107;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(463, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // btThemAnh
            // 
            this.btThemAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThemAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btThemAnh.FlatAppearance.BorderSize = 0;
            this.btThemAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemAnh.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemAnh.ForeColor = System.Drawing.Color.White;
            this.btThemAnh.Location = new System.Drawing.Point(299, 269);
            this.btThemAnh.Name = "btThemAnh";
            this.btThemAnh.Size = new System.Drawing.Size(98, 44);
            this.btThemAnh.TabIndex = 106;
            this.btThemAnh.Text = "Thêm ảnh";
            this.btThemAnh.UseVisualStyleBackColor = false;
            this.btThemAnh.Click += new System.EventHandler(this.btThemAnh_Click);
            // 
            // cbbNV
            // 
            this.cbbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(463, 107);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(278, 33);
            this.cbbNV.TabIndex = 109;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(451, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 391);
            this.panel2.TabIndex = 110;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "ofdOpenFile";
            // 
            // ThemHopDongNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 770);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbbNV);
            this.Controls.Add(this.dtp_NgayKyKet);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThemAnh);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemHopDongNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemVaChiTIetHopDongNV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHopDongNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_NgayKyKet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btThemAnh;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
    }
}