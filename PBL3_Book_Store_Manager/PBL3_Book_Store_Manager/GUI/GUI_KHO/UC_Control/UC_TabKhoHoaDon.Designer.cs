namespace PBL3_Book_Store_Manager.GUI_KHO.UC_Control
{
    partial class UC_TabKhoHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlHopDong = new System.Windows.Forms.TabControl();
            this.tabHDNhapKho = new System.Windows.Forms.TabPage();
            this.dgvHDNhapKho = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btChiTietHdNhapKho = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbHDNhapKho = new System.Windows.Forms.ComboBox();
            this.btSearchHdNhapKho = new System.Windows.Forms.Button();
            this.txtSearchHdNhapKho = new System.Windows.Forms.TextBox();
            this.tabHDXuatKho = new System.Windows.Forms.TabPage();
            this.dgvHDXuatKho = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btChiTietHDXuatKho = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbSortHDXuatKho = new System.Windows.Forms.ComboBox();
            this.btSearchHDXuatKho = new System.Windows.Forms.Button();
            this.txtSearchHDXuatKho = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.tabControlHopDong.SuspendLayout();
            this.tabHDNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhapKho)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabHDXuatKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDXuatKho)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControlHopDong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 638);
            this.panel3.TabIndex = 11;
            // 
            // tabControlHopDong
            // 
            this.tabControlHopDong.Controls.Add(this.tabHDNhapKho);
            this.tabControlHopDong.Controls.Add(this.tabHDXuatKho);
            this.tabControlHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHopDong.Location = new System.Drawing.Point(0, 0);
            this.tabControlHopDong.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlHopDong.Multiline = true;
            this.tabControlHopDong.Name = "tabControlHopDong";
            this.tabControlHopDong.Padding = new System.Drawing.Point(50, 30);
            this.tabControlHopDong.SelectedIndex = 0;
            this.tabControlHopDong.Size = new System.Drawing.Size(1032, 638);
            this.tabControlHopDong.TabIndex = 0;
            // 
            // tabHDNhapKho
            // 
            this.tabHDNhapKho.BackColor = System.Drawing.Color.White;
            this.tabHDNhapKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabHDNhapKho.Controls.Add(this.dgvHDNhapKho);
            this.tabHDNhapKho.Controls.Add(this.flowLayoutPanel2);
            this.tabHDNhapKho.Controls.Add(this.flowLayoutPanel1);
            this.tabHDNhapKho.Controls.Add(this.panel1);
            this.tabHDNhapKho.Controls.Add(this.panel4);
            this.tabHDNhapKho.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHDNhapKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.tabHDNhapKho.Location = new System.Drawing.Point(4, 88);
            this.tabHDNhapKho.Margin = new System.Windows.Forms.Padding(0);
            this.tabHDNhapKho.Name = "tabHDNhapKho";
            this.tabHDNhapKho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabHDNhapKho.Size = new System.Drawing.Size(1024, 546);
            this.tabHDNhapKho.TabIndex = 0;
            this.tabHDNhapKho.Text = "Hóa đơn nhập kho";
            this.tabHDNhapKho.UseWaitCursor = true;
            // 
            // dgvHDNhapKho
            // 
            this.dgvHDNhapKho.AllowUserToAddRows = false;
            this.dgvHDNhapKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvHDNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDNhapKho.Location = new System.Drawing.Point(34, 61);
            this.dgvHDNhapKho.Name = "dgvHDNhapKho";
            this.dgvHDNhapKho.ReadOnly = true;
            this.dgvHDNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDNhapKho.Size = new System.Drawing.Size(956, 375);
            this.dgvHDNhapKho.TabIndex = 16;
            this.dgvHDNhapKho.UseWaitCursor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(990, 61);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(34, 375);
            this.flowLayoutPanel2.TabIndex = 13;
            this.flowLayoutPanel2.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(34, 375);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btChiTietHdNhapKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 110);
            this.panel1.TabIndex = 12;
            this.panel1.UseWaitCursor = true;
            // 
            // btChiTietHdNhapKho
            // 
            this.btChiTietHdNhapKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTietHdNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTietHdNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTietHdNhapKho.ForeColor = System.Drawing.Color.White;
            this.btChiTietHdNhapKho.Location = new System.Drawing.Point(431, 10);
            this.btChiTietHdNhapKho.Name = "btChiTietHdNhapKho";
            this.btChiTietHdNhapKho.Size = new System.Drawing.Size(198, 90);
            this.btChiTietHdNhapKho.TabIndex = 3;
            this.btChiTietHdNhapKho.Text = "Chi tiết";
            this.btChiTietHdNhapKho.UseVisualStyleBackColor = false;
            this.btChiTietHdNhapKho.UseWaitCursor = true;
            this.btChiTietHdNhapKho.Click += new System.EventHandler(this.btChiTietHdNhapKho_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.cbbHDNhapKho);
            this.panel4.Controls.Add(this.btSearchHdNhapKho);
            this.panel4.Controls.Add(this.txtSearchHdNhapKho);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 61);
            this.panel4.TabIndex = 15;
            this.panel4.UseWaitCursor = true;
            // 
            // cbbHDNhapKho
            // 
            this.cbbHDNhapKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbHDNhapKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHDNhapKho.FormattingEnabled = true;
            this.cbbHDNhapKho.Items.AddRange(new object[] {
            "All",
            "Mã đề xuất",
            "Tên nhân viên"});
            this.cbbHDNhapKho.Location = new System.Drawing.Point(493, 14);
            this.cbbHDNhapKho.Name = "cbbHDNhapKho";
            this.cbbHDNhapKho.Size = new System.Drawing.Size(191, 33);
            this.cbbHDNhapKho.TabIndex = 5;
            this.cbbHDNhapKho.UseWaitCursor = true;
            // 
            // btSearchHdNhapKho
            // 
            this.btSearchHdNhapKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchHdNhapKho.FlatAppearance.BorderSize = 0;
            this.btSearchHdNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchHdNhapKho.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchHdNhapKho.Location = new System.Drawing.Point(888, 6);
            this.btSearchHdNhapKho.Name = "btSearchHdNhapKho";
            this.btSearchHdNhapKho.Size = new System.Drawing.Size(102, 47);
            this.btSearchHdNhapKho.TabIndex = 4;
            this.btSearchHdNhapKho.UseVisualStyleBackColor = true;
            this.btSearchHdNhapKho.UseWaitCursor = true;
            this.btSearchHdNhapKho.Click += new System.EventHandler(this.btSearchHdNhapKho_Click);
            // 
            // txtSearchHdNhapKho
            // 
            this.txtSearchHdNhapKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchHdNhapKho.Location = new System.Drawing.Point(718, 14);
            this.txtSearchHdNhapKho.Name = "txtSearchHdNhapKho";
            this.txtSearchHdNhapKho.Size = new System.Drawing.Size(161, 33);
            this.txtSearchHdNhapKho.TabIndex = 6;
            this.txtSearchHdNhapKho.UseWaitCursor = true;
            // 
            // tabHDXuatKho
            // 
            this.tabHDXuatKho.BackColor = System.Drawing.Color.White;
            this.tabHDXuatKho.Controls.Add(this.dgvHDXuatKho);
            this.tabHDXuatKho.Controls.Add(this.flowLayoutPanel3);
            this.tabHDXuatKho.Controls.Add(this.flowLayoutPanel4);
            this.tabHDXuatKho.Controls.Add(this.panel2);
            this.tabHDXuatKho.Controls.Add(this.panel7);
            this.tabHDXuatKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.tabHDXuatKho.Location = new System.Drawing.Point(4, 76);
            this.tabHDXuatKho.Name = "tabHDXuatKho";
            this.tabHDXuatKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabHDXuatKho.Size = new System.Drawing.Size(1024, 558);
            this.tabHDXuatKho.TabIndex = 1;
            this.tabHDXuatKho.Text = "Hóa đơn xuất kho";
            // 
            // dgvHDXuatKho
            // 
            this.dgvHDXuatKho.AllowUserToAddRows = false;
            this.dgvHDXuatKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvHDXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDXuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDXuatKho.Location = new System.Drawing.Point(37, 64);
            this.dgvHDXuatKho.Name = "dgvHDXuatKho";
            this.dgvHDXuatKho.ReadOnly = true;
            this.dgvHDXuatKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDXuatKho.Size = new System.Drawing.Size(950, 381);
            this.dgvHDXuatKho.TabIndex = 21;
            this.dgvHDXuatKho.UseWaitCursor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(987, 64);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(34, 381);
            this.flowLayoutPanel3.TabIndex = 18;
            this.flowLayoutPanel3.UseWaitCursor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(34, 381);
            this.flowLayoutPanel4.TabIndex = 19;
            this.flowLayoutPanel4.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btChiTietHDXuatKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 110);
            this.panel2.TabIndex = 17;
            this.panel2.UseWaitCursor = true;
            // 
            // btChiTietHDXuatKho
            // 
            this.btChiTietHDXuatKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTietHDXuatKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTietHDXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTietHDXuatKho.ForeColor = System.Drawing.Color.White;
            this.btChiTietHDXuatKho.Location = new System.Drawing.Point(425, 13);
            this.btChiTietHDXuatKho.Name = "btChiTietHDXuatKho";
            this.btChiTietHDXuatKho.Size = new System.Drawing.Size(198, 86);
            this.btChiTietHDXuatKho.TabIndex = 4;
            this.btChiTietHDXuatKho.Text = "Chi tiết";
            this.btChiTietHDXuatKho.UseVisualStyleBackColor = false;
            this.btChiTietHDXuatKho.UseWaitCursor = true;
            this.btChiTietHDXuatKho.Click += new System.EventHandler(this.btChiTietHDXuatKho_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.cbbSortHDXuatKho);
            this.panel7.Controls.Add(this.btSearchHDXuatKho);
            this.panel7.Controls.Add(this.txtSearchHDXuatKho);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 61);
            this.panel7.TabIndex = 20;
            this.panel7.UseWaitCursor = true;
            // 
            // cbbSortHDXuatKho
            // 
            this.cbbSortHDXuatKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortHDXuatKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortHDXuatKho.FormattingEnabled = true;
            this.cbbSortHDXuatKho.Items.AddRange(new object[] {
            "Tên nhân viên"});
            this.cbbSortHDXuatKho.Location = new System.Drawing.Point(491, 12);
            this.cbbSortHDXuatKho.Name = "cbbSortHDXuatKho";
            this.cbbSortHDXuatKho.Size = new System.Drawing.Size(189, 33);
            this.cbbSortHDXuatKho.TabIndex = 8;
            this.cbbSortHDXuatKho.UseWaitCursor = true;
            // 
            // btSearchHDXuatKho
            // 
            this.btSearchHDXuatKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchHDXuatKho.FlatAppearance.BorderSize = 0;
            this.btSearchHDXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchHDXuatKho.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchHDXuatKho.Location = new System.Drawing.Point(884, 4);
            this.btSearchHDXuatKho.Name = "btSearchHDXuatKho";
            this.btSearchHDXuatKho.Size = new System.Drawing.Size(102, 47);
            this.btSearchHDXuatKho.TabIndex = 7;
            this.btSearchHDXuatKho.UseVisualStyleBackColor = true;
            this.btSearchHDXuatKho.UseWaitCursor = true;
            this.btSearchHDXuatKho.Click += new System.EventHandler(this.btSearchHDXuatKho_Click);
            // 
            // txtSearchHDXuatKho
            // 
            this.txtSearchHDXuatKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchHDXuatKho.Location = new System.Drawing.Point(714, 12);
            this.txtSearchHDXuatKho.Name = "txtSearchHDXuatKho";
            this.txtSearchHDXuatKho.Size = new System.Drawing.Size(161, 33);
            this.txtSearchHDXuatKho.TabIndex = 9;
            this.txtSearchHDXuatKho.UseWaitCursor = true;
            // 
            // UC_TabKhoHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.Name = "UC_TabKhoHoaDon";
            this.Size = new System.Drawing.Size(1032, 638);
            this.panel3.ResumeLayout(false);
            this.tabControlHopDong.ResumeLayout(false);
            this.tabHDNhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhapKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabHDXuatKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDXuatKho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControlHopDong;
        private System.Windows.Forms.TabPage tabHDNhapKho;
        private System.Windows.Forms.DataGridView dgvHDNhapKho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btChiTietHdNhapKho;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbHDNhapKho;
        private System.Windows.Forms.Button btSearchHdNhapKho;
        private System.Windows.Forms.TextBox txtSearchHdNhapKho;
        private System.Windows.Forms.TabPage tabHDXuatKho;
        private System.Windows.Forms.DataGridView dgvHDXuatKho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btChiTietHDXuatKho;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbbSortHDXuatKho;
        private System.Windows.Forms.Button btSearchHDXuatKho;
        private System.Windows.Forms.TextBox txtSearchHDXuatKho;
    }
}
