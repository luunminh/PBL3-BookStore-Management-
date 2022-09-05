namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    partial class ThemHoaDonNhapKho
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
            this.btThemHHNhapKho = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvHHNhapKhoSearch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dgvSPDaChon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTaoHoaDonNhapKho = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSoLuongHH = new System.Windows.Forms.NumericUpDown();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHNhapKhoSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPDaChon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHH)).BeginInit();
            this.SuspendLayout();
            // 
            // btThemHHNhapKho
            // 
            this.btThemHHNhapKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThemHHNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btThemHHNhapKho.FlatAppearance.BorderSize = 0;
            this.btThemHHNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemHHNhapKho.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btThemHHNhapKho.ForeColor = System.Drawing.Color.White;
            this.btThemHHNhapKho.Location = new System.Drawing.Point(937, 149);
            this.btThemHHNhapKho.Name = "btThemHHNhapKho";
            this.btThemHHNhapKho.Size = new System.Drawing.Size(82, 44);
            this.btThemHHNhapKho.TabIndex = 184;
            this.btThemHHNhapKho.Text = "Thêm";
            this.btThemHHNhapKho.UseVisualStyleBackColor = false;
            this.btThemHHNhapKho.Click += new System.EventHandler(this.btThemHH_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(579, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 182;
            this.label10.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(579, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 183;
            this.label8.Text = "Hàng hóa";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(709, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 33);
            this.txtSearch.TabIndex = 180;
            // 
            // dgvHHNhapKhoSearch
            // 
            this.dgvHHNhapKhoSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.dgvHHNhapKhoSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHHNhapKhoSearch.Location = new System.Drawing.Point(586, 241);
            this.dgvHHNhapKhoSearch.Name = "dgvHHNhapKhoSearch";
            this.dgvHHNhapKhoSearch.RowHeadersWidth = 51;
            this.dgvHHNhapKhoSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHHNhapKhoSearch.Size = new System.Drawing.Size(433, 363);
            this.dgvHHNhapKhoSearch.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(582, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 177;
            this.label1.Text = "Sản phẩm tìm kiếm";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtMaNV.Location = new System.Drawing.Point(193, 96);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(333, 33);
            this.txtMaNV.TabIndex = 176;
            // 
            // dgvSPDaChon
            // 
            this.dgvSPDaChon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.dgvSPDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPDaChon.Location = new System.Drawing.Point(58, 241);
            this.dgvSPDaChon.Name = "dgvSPDaChon";
            this.dgvSPDaChon.RowHeadersWidth = 51;
            this.dgvSPDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSPDaChon.Size = new System.Drawing.Size(468, 363);
            this.dgvSPDaChon.TabIndex = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(57, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 171;
            this.label3.Text = "Tổng tiền";
            // 
            // lbTaoHoaDonNhapKho
            // 
            this.lbTaoHoaDonNhapKho.AutoSize = true;
            this.lbTaoHoaDonNhapKho.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbTaoHoaDonNhapKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbTaoHoaDonNhapKho.Location = new System.Drawing.Point(446, 18);
            this.lbTaoHoaDonNhapKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTaoHoaDonNhapKho.Name = "lbTaoHoaDonNhapKho";
            this.lbTaoHoaDonNhapKho.Size = new System.Drawing.Size(209, 25);
            this.lbTaoHoaDonNhapKho.TabIndex = 46;
            this.lbTaoHoaDonNhapKho.Text = "Tạo hóa đơn nhập kho";
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(646, 670);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 74);
            this.btHuy.TabIndex = 173;
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
            this.btOK.Font = new System.Drawing.Font("SVN-Gilroy XBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(266, 670);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(192, 74);
            this.btOK.TabIndex = 174;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(55, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 25);
            this.label9.TabIndex = 170;
            this.label9.Text = "Sản phẩm đã chọn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lbTaoHoaDonNhapKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 58);
            this.panel1.TabIndex = 168;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(174, 619);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(352, 29);
            this.txtTongTien.TabIndex = 169;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 172;
            this.label2.Text = "Tên nhân viên";
            // 
            // numSoLuongHH
            // 
            this.numSoLuongHH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.numSoLuongHH.Location = new System.Drawing.Point(709, 156);
            this.numSoLuongHH.Name = "numSoLuongHH";
            this.numSoLuongHH.Size = new System.Drawing.Size(204, 33);
            this.numSoLuongHH.TabIndex = 185;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearch.Location = new System.Drawing.Point(937, 80);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(82, 52);
            this.btSearch.TabIndex = 184;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // ThemHoaDonNhapKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 770);
            this.Controls.Add(this.numSoLuongHH);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btThemHHNhapKho);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvHHNhapKhoSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.dgvSPDaChon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemHoaDonNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHoaDonNhapKhoVaBH";
            this.Load += new System.EventHandler(this.ThemHoaDonNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHNhapKhoSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPDaChon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThemHHNhapKho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvHHNhapKhoSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridView dgvSPDaChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTaoHoaDonNhapKho;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.NumericUpDown numSoLuongHH;
    }
}