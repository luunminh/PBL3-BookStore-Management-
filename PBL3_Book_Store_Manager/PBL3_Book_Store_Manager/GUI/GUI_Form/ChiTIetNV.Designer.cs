namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    partial class ChiTIetNV
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
            this.dgvViewCaLam = new System.Windows.Forms.DataGridView();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.dtp_NS = new System.Windows.Forms.DateTimePicker();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenTk = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCaLam)).BeginInit();
            this.grbGender.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewCaLam
            // 
            this.dgvViewCaLam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.dgvViewCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCaLam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.dgvViewCaLam.Location = new System.Drawing.Point(64, 459);
            this.dgvViewCaLam.Name = "dgvViewCaLam";
            this.dgvViewCaLam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewCaLam.Size = new System.Drawing.Size(440, 195);
            this.dgvViewCaLam.TabIndex = 174;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.Enabled = false;
            this.cbbChucVu.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên bán hàng",
            "Nhân viên thủ kho"});
            this.cbbChucVu.Location = new System.Drawing.Point(762, 223);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(279, 33);
            this.cbbChucVu.TabIndex = 172;
            // 
            // dtp_NS
            // 
            this.dtp_NS.CalendarFont = new System.Drawing.Font("SVN-Gilroy XBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NS.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NS.Location = new System.Drawing.Point(762, 154);
            this.dtp_NS.Name = "dtp_NS";
            this.dtp_NS.Size = new System.Drawing.Size(279, 29);
            this.dtp_NS.TabIndex = 171;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbNu);
            this.grbGender.Controls.Add(this.rdbNam);
            this.grbGender.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.grbGender.Location = new System.Drawing.Point(57, 209);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(442, 98);
            this.grbGender.TabIndex = 170;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(281, 46);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(54, 29);
            this.rdbNu.TabIndex = 0;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(101, 46);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(71, 29);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("SVN-Gilroy XBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.Color.White;
            this.btOk.Location = new System.Drawing.Point(290, 694);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(191, 80);
            this.btOk.TabIndex = 166;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(60, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 156;
            this.label1.Text = "Ca làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(570, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 157;
            this.label6.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(570, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 158;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(56, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 159;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(570, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 162;
            this.label5.Text = "Căn cước công dân";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtCCCD.Location = new System.Drawing.Point(762, 96);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(279, 33);
            this.txtCCCD.TabIndex = 155;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(570, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 163;
            this.label7.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label11.Location = new System.Drawing.Point(570, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 165;
            this.label11.Text = "Lương";
            this.label11.Visible = false;
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(631, 696);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 80);
            this.btHuy.TabIndex = 167;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(570, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 164;
            this.label9.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(56, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 161;
            this.label8.Text = "Tên tài khoản";
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtLuong.Location = new System.Drawing.Point(764, 593);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(277, 33);
            this.txtLuong.TabIndex = 154;
            this.txtLuong.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(56, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 160;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtMk.Location = new System.Drawing.Point(760, 351);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(281, 33);
            this.txtMk.TabIndex = 153;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtDiaChi.Location = new System.Drawing.Point(760, 412);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(281, 152);
            this.txtDiaChi.TabIndex = 152;
            // 
            // txtTenTk
            // 
            this.txtTenTk.Enabled = false;
            this.txtTenTk.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtTenTk.Location = new System.Drawing.Point(202, 345);
            this.txtTenTk.Name = "txtTenTk";
            this.txtTenTk.Size = new System.Drawing.Size(302, 33);
            this.txtTenTk.TabIndex = 151;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtSDT.Location = new System.Drawing.Point(200, 157);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(299, 33);
            this.txtSDT.TabIndex = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 58);
            this.panel1.TabIndex = 148;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(475, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 135;
            this.label10.Text = "Chi tiết nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtTenNV.Location = new System.Drawing.Point(200, 96);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(299, 33);
            this.txtTenNV.TabIndex = 149;
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrang.Enabled = false;
            this.cbbTinhTrang.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Hoạt động",
            "Tạm ngưng"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(764, 289);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(279, 33);
            this.cbbTinhTrang.TabIndex = 201;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label12.Location = new System.Drawing.Point(572, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 25);
            this.label12.TabIndex = 200;
            this.label12.Text = "Tình trạng";
            // 
            // ChiTIetNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 809);
            this.Controls.Add(this.cbbTinhTrang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvViewCaLam);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.dtp_NS);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenTk);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenNV);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTIetNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTIetNV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCaLam)).EndInit();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewCaLam;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.DateTimePicker dtp_NS;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenTk;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Label label12;
    }
}