namespace PBL3_Book_Store_Manager.GUI_Form
{
    partial class ChiTietCaLam
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
            this.btOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhuCapCa = new System.Windows.Forms.TextBox();
            this.txtTenCaLam = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChiTietCaLam = new System.Windows.Forms.Label();
            this.dgvNVTrongCa = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.txtGioBatDau = new System.Windows.Forms.TextBox();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVTrongCa)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(591, 552);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 77);
            this.btHuy.TabIndex = 105;
            this.btHuy.Text = "Quay lại";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOk.ForeColor = System.Drawing.Color.White;
            this.btOk.Location = new System.Drawing.Point(254, 552);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(191, 77);
            this.btOk.TabIndex = 106;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(35, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 99;
            this.label4.Text = "Giờ kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(35, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 100;
            this.label5.Text = "Giờ bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(35, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Tiền phụ cấp ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "Tên ca làm";
            // 
            // txtPhuCapCa
            // 
            this.txtPhuCapCa.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuCapCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.txtPhuCapCa.Location = new System.Drawing.Point(196, 164);
            this.txtPhuCapCa.Name = "txtPhuCapCa";
            this.txtPhuCapCa.Size = new System.Drawing.Size(279, 33);
            this.txtPhuCapCa.TabIndex = 97;
            // 
            // txtTenCaLam
            // 
            this.txtTenCaLam.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCaLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.txtTenCaLam.Location = new System.Drawing.Point(196, 103);
            this.txtTenCaLam.Name = "txtTenCaLam";
            this.txtTenCaLam.Size = new System.Drawing.Size(278, 33);
            this.txtTenCaLam.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lbChiTietCaLam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 58);
            this.panel1.TabIndex = 96;
            // 
            // lbChiTietCaLam
            // 
            this.lbChiTietCaLam.AutoSize = true;
            this.lbChiTietCaLam.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietCaLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbChiTietCaLam.Location = new System.Drawing.Point(467, 14);
            this.lbChiTietCaLam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChiTietCaLam.Name = "lbChiTietCaLam";
            this.lbChiTietCaLam.Size = new System.Drawing.Size(142, 25);
            this.lbChiTietCaLam.TabIndex = 46;
            this.lbChiTietCaLam.Text = "Chi tiết ca làm";
            // 
            // dgvNVTrongCa
            // 
            this.dgvNVTrongCa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.dgvNVTrongCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNVTrongCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVTrongCa.Location = new System.Drawing.Point(554, 125);
            this.dgvNVTrongCa.Name = "dgvNVTrongCa";
            this.dgvNVTrongCa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNVTrongCa.Size = new System.Drawing.Size(474, 298);
            this.dgvNVTrongCa.TabIndex = 107;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(775, 434);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(107, 54);
            this.btThem.TabIndex = 105;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(557, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 102;
            this.label7.Text = "Nhân viên trong ca";
            // 
            // cbbNV
            // 
            this.cbbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNV.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(760, 85);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(267, 33);
            this.cbbNV.TabIndex = 108;
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.txtGioBatDau.Location = new System.Drawing.Point(196, 248);
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(279, 33);
            this.txtGioBatDau.TabIndex = 97;
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.txtGioKetThuc.Location = new System.Drawing.Point(195, 300);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(279, 33);
            this.txtGioKetThuc.TabIndex = 97;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(28, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 135);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(914, 434);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(107, 54);
            this.btXoa.TabIndex = 105;
            this.btXoa.Text = "Tạm ngưng";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // ChiTietCaLam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 720);
            this.Controls.Add(this.cbbNV);
            this.Controls.Add(this.dgvNVTrongCa);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGioKetThuc);
            this.Controls.Add(this.txtGioBatDau);
            this.Controls.Add(this.txtPhuCapCa);
            this.Controls.Add(this.txtTenCaLam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietCaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietCaLam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVTrongCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhuCapCa;
        private System.Windows.Forms.TextBox txtTenCaLam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChiTietCaLam;
        private System.Windows.Forms.DataGridView dgvNVTrongCa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.TextBox txtGioBatDau;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoa;
    }
}