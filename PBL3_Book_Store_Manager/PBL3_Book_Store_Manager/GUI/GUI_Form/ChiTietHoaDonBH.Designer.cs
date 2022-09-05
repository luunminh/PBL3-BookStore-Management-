namespace PBL3_Book_Store_Manager.GUI_Form
{
    partial class ChiTietHoaDonNhapKho
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
            this.dtpTGTao = new System.Windows.Forms.DateTimePicker();
            this.btHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChiTietHDNhapKho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgvSPDaChon = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTGTao
            // 
            this.dtpTGTao.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dtpTGTao.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dtpTGTao.Enabled = false;
            this.dtpTGTao.Font = new System.Drawing.Font("SVN-Gilroy XBold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGTao.Location = new System.Drawing.Point(755, 106);
            this.dtpTGTao.Name = "dtpTGTao";
            this.dtpTGTao.Size = new System.Drawing.Size(279, 25);
            this.dtpTGTao.TabIndex = 117;
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(456, 644);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 76);
            this.btHuy.TabIndex = 114;
            this.btHuy.Text = "Quay lại";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(575, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "Thời gian tạo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(61, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 25);
            this.label9.TabIndex = 111;
            this.label9.Text = "Sản phẩm đã chọn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lbChiTietHDNhapKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 58);
            this.panel1.TabIndex = 99;
            // 
            // lbChiTietHDNhapKho
            // 
            this.lbChiTietHDNhapKho.AutoSize = true;
            this.lbChiTietHDNhapKho.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietHDNhapKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbChiTietHDNhapKho.Location = new System.Drawing.Point(451, 16);
            this.lbChiTietHDNhapKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChiTietHDNhapKho.Name = "lbChiTietHDNhapKho";
            this.lbChiTietHDNhapKho.Size = new System.Drawing.Size(169, 27);
            this.lbChiTietHDNhapKho.TabIndex = 46;
            this.lbChiTietHDNhapKho.Text = "Chi tiết hóa đơn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(61, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtTenNV.Location = new System.Drawing.Point(205, 101);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(299, 33);
            this.txtTenNV.TabIndex = 105;
            // 
            // dgvSPDaChon
            // 
            this.dgvSPDaChon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.dgvSPDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPDaChon.Location = new System.Drawing.Point(66, 216);
            this.dgvSPDaChon.Name = "dgvSPDaChon";
            this.dgvSPDaChon.Size = new System.Drawing.Size(968, 377);
            this.dgvSPDaChon.TabIndex = 118;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtTongTien.Location = new System.Drawing.Point(696, 166);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(338, 33);
            this.txtTongTien.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(575, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 113;
            this.label3.Text = "Tổng tiền";
            // 
            // ChiTietHoaDonNhapKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 770);
            this.Controls.Add(this.dgvSPDaChon);
            this.Controls.Add(this.dtpTGTao);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenNV);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietHoaDonNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietHoaDonNhapKho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPDaChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTGTao;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChiTietHDNhapKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dgvSPDaChon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
    }
}