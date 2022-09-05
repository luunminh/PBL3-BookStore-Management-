namespace PBL3_Book_Store_Manager.GUI_KHO.UC_Control
{
    partial class UC_TabKhoHH
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
            this.cbbSortTrongKho = new System.Windows.Forms.ComboBox();
            this.btSearchTrongKho = new System.Windows.Forms.Button();
            this.txtSearchTrongKho = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btChiTiet = new System.Windows.Forms.Button();
            this.dgvHHTrongKho = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTaoHDNhap = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTaoHH = new System.Windows.Forms.Button();
            this.cbbSortTrenKe = new System.Windows.Forms.ComboBox();
            this.btSearchTrenKe = new System.Windows.Forms.Button();
            this.txtSearchTrenKe = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbKe = new System.Windows.Forms.Label();
            this.cbbKe = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSoLuong = new System.Windows.Forms.Button();
            this.btChiTietKe = new System.Windows.Forms.Button();
            this.btTaoHdXuatKho = new System.Windows.Forms.Button();
            this.btChiTietHHKe = new System.Windows.Forms.Button();
            this.btThemKe = new System.Windows.Forms.Button();
            this.tabTrenKe = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlHH = new System.Windows.Forms.TabControl();
            this.tabKho = new System.Windows.Forms.TabPage();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHTrongKho)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabTrenKe.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControlHH.SuspendLayout();
            this.tabKho.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbSortTrongKho
            // 
            this.cbbSortTrongKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortTrongKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortTrongKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.cbbSortTrongKho.FormattingEnabled = true;
            this.cbbSortTrongKho.Items.AddRange(new object[] {
            "Tên hàng hóa",
            "Nhà sản xuất",
            "Năm sản xuất",
            "Số lương trên trưng bày",
            "Số lượng trong kho",
            "Giá nhập",
            "Giá bán",
            "Trạng thái"});
            this.cbbSortTrongKho.Location = new System.Drawing.Point(494, 12);
            this.cbbSortTrongKho.Name = "cbbSortTrongKho";
            this.cbbSortTrongKho.Size = new System.Drawing.Size(186, 33);
            this.cbbSortTrongKho.TabIndex = 8;
            this.cbbSortTrongKho.UseWaitCursor = true;
            // 
            // btSearchTrongKho
            // 
            this.btSearchTrongKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchTrongKho.FlatAppearance.BorderSize = 0;
            this.btSearchTrongKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchTrongKho.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchTrongKho.Location = new System.Drawing.Point(884, 4);
            this.btSearchTrongKho.Name = "btSearchTrongKho";
            this.btSearchTrongKho.Size = new System.Drawing.Size(102, 47);
            this.btSearchTrongKho.TabIndex = 7;
            this.btSearchTrongKho.UseVisualStyleBackColor = true;
            this.btSearchTrongKho.UseWaitCursor = true;
            this.btSearchTrongKho.Click += new System.EventHandler(this.btSearchTrongKho_Click);
            // 
            // txtSearchTrongKho
            // 
            this.txtSearchTrongKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchTrongKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtSearchTrongKho.Location = new System.Drawing.Point(714, 12);
            this.txtSearchTrongKho.Name = "txtSearchTrongKho";
            this.txtSearchTrongKho.Size = new System.Drawing.Size(161, 33);
            this.txtSearchTrongKho.TabIndex = 9;
            this.txtSearchTrongKho.UseWaitCursor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.cbbSortTrongKho);
            this.panel7.Controls.Add(this.btSearchTrongKho);
            this.panel7.Controls.Add(this.txtSearchTrongKho);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 61);
            this.panel7.TabIndex = 20;
            this.panel7.UseWaitCursor = true;
            // 
            // btChiTiet
            // 
            this.btChiTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTiet.ForeColor = System.Drawing.Color.White;
            this.btChiTiet.Location = new System.Drawing.Point(292, 13);
            this.btChiTiet.Name = "btChiTiet";
            this.btChiTiet.Size = new System.Drawing.Size(141, 86);
            this.btChiTiet.TabIndex = 4;
            this.btChiTiet.Text = "Chi tiết";
            this.btChiTiet.UseVisualStyleBackColor = false;
            this.btChiTiet.UseWaitCursor = true;
            this.btChiTiet.Click += new System.EventHandler(this.btChiTiet_Click);
            // 
            // dgvHHTrongKho
            // 
            this.dgvHHTrongKho.AllowUserToAddRows = false;
            this.dgvHHTrongKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvHHTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHHTrongKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHHTrongKho.Location = new System.Drawing.Point(37, 64);
            this.dgvHHTrongKho.Name = "dgvHHTrongKho";
            this.dgvHHTrongKho.ReadOnly = true;
            this.dgvHHTrongKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHHTrongKho.Size = new System.Drawing.Size(950, 369);
            this.dgvHHTrongKho.TabIndex = 21;
            this.dgvHHTrongKho.UseWaitCursor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(987, 64);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(34, 369);
            this.flowLayoutPanel3.TabIndex = 18;
            this.flowLayoutPanel3.UseWaitCursor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(34, 369);
            this.flowLayoutPanel4.TabIndex = 19;
            this.flowLayoutPanel4.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btTaoHDNhap);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btTaoHH);
            this.panel2.Controls.Add(this.btChiTiet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 110);
            this.panel2.TabIndex = 17;
            this.panel2.UseWaitCursor = true;
            // 
            // btTaoHDNhap
            // 
            this.btTaoHDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTaoHDNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btTaoHDNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaoHDNhap.ForeColor = System.Drawing.Color.White;
            this.btTaoHDNhap.Location = new System.Drawing.Point(843, 13);
            this.btTaoHDNhap.Name = "btTaoHDNhap";
            this.btTaoHDNhap.Size = new System.Drawing.Size(141, 86);
            this.btTaoHDNhap.TabIndex = 4;
            this.btTaoHDNhap.Text = "Tạo hóa đơn nhập hàng";
            this.btTaoHDNhap.UseVisualStyleBackColor = false;
            this.btTaoHDNhap.UseWaitCursor = true;
            this.btTaoHDNhap.Click += new System.EventHandler(this.btTaoHDNhap_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(588, 13);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(141, 86);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Tạm ngưng kinh doanh";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.UseWaitCursor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTaoHH
            // 
            this.btTaoHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTaoHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btTaoHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaoHH.ForeColor = System.Drawing.Color.White;
            this.btTaoHH.Location = new System.Drawing.Point(34, 13);
            this.btTaoHH.Name = "btTaoHH";
            this.btTaoHH.Size = new System.Drawing.Size(141, 86);
            this.btTaoHH.TabIndex = 4;
            this.btTaoHH.Text = "Đề xuất tạo hàng hóa mới";
            this.btTaoHH.UseVisualStyleBackColor = false;
            this.btTaoHH.UseWaitCursor = true;
            this.btTaoHH.Click += new System.EventHandler(this.btTaoHH_Click);
            // 
            // cbbSortTrenKe
            // 
            this.cbbSortTrenKe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortTrenKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortTrenKe.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbSortTrenKe.FormattingEnabled = true;
            this.cbbSortTrenKe.Items.AddRange(new object[] {
            "Tên Hàng Hóa",
            "Nhà Sản Xuất",
            "Năm Sản Xuất",
            "Số Lương Trên Trưng Bày",
            "Số Lượng Trong Kho",
            "Giá Nhập",
            "Giá Bán",
            "Trạng Thái"});
            this.cbbSortTrenKe.Location = new System.Drawing.Point(505, 14);
            this.cbbSortTrenKe.Name = "cbbSortTrenKe";
            this.cbbSortTrenKe.Size = new System.Drawing.Size(179, 33);
            this.cbbSortTrenKe.TabIndex = 5;
            this.cbbSortTrenKe.UseWaitCursor = true;
            // 
            // btSearchTrenKe
            // 
            this.btSearchTrenKe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchTrenKe.FlatAppearance.BorderSize = 0;
            this.btSearchTrenKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchTrenKe.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchTrenKe.Location = new System.Drawing.Point(888, 6);
            this.btSearchTrenKe.Name = "btSearchTrenKe";
            this.btSearchTrenKe.Size = new System.Drawing.Size(102, 47);
            this.btSearchTrenKe.TabIndex = 4;
            this.btSearchTrenKe.UseVisualStyleBackColor = true;
            this.btSearchTrenKe.UseWaitCursor = true;
            this.btSearchTrenKe.Click += new System.EventHandler(this.btSearchTrenKe_Click);
            // 
            // txtSearchTrenKe
            // 
            this.txtSearchTrenKe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchTrenKe.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSearchTrenKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtSearchTrenKe.Location = new System.Drawing.Point(718, 14);
            this.txtSearchTrenKe.Name = "txtSearchTrenKe";
            this.txtSearchTrenKe.Size = new System.Drawing.Size(161, 33);
            this.txtSearchTrenKe.TabIndex = 6;
            this.txtSearchTrenKe.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbKe);
            this.panel4.Controls.Add(this.cbbKe);
            this.panel4.Controls.Add(this.cbbSortTrenKe);
            this.panel4.Controls.Add(this.btSearchTrenKe);
            this.panel4.Controls.Add(this.txtSearchTrenKe);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 61);
            this.panel4.TabIndex = 15;
            this.panel4.UseWaitCursor = true;
            // 
            // lbKe
            // 
            this.lbKe.AutoSize = true;
            this.lbKe.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbKe.Location = new System.Drawing.Point(39, 16);
            this.lbKe.Name = "lbKe";
            this.lbKe.Size = new System.Drawing.Size(35, 25);
            this.lbKe.TabIndex = 7;
            this.lbKe.Text = "Kệ";
            this.lbKe.UseWaitCursor = true;
            // 
            // cbbKe
            // 
            this.cbbKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKe.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbKe.FormattingEnabled = true;
            this.cbbKe.Location = new System.Drawing.Point(95, 15);
            this.cbbKe.Name = "cbbKe";
            this.cbbKe.Size = new System.Drawing.Size(170, 33);
            this.cbbKe.TabIndex = 5;
            this.cbbKe.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(34, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 375);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.UseWaitCursor = true;
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
            this.panel1.Controls.Add(this.btSoLuong);
            this.panel1.Controls.Add(this.btChiTietKe);
            this.panel1.Controls.Add(this.btTaoHdXuatKho);
            this.panel1.Controls.Add(this.btChiTietHHKe);
            this.panel1.Controls.Add(this.btThemKe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 110);
            this.panel1.TabIndex = 12;
            this.panel1.UseWaitCursor = true;
            // 
            // btSoLuong
            // 
            this.btSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btSoLuong.Enabled = false;
            this.btSoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSoLuong.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoLuong.ForeColor = System.Drawing.Color.White;
            this.btSoLuong.Location = new System.Drawing.Point(846, 12);
            this.btSoLuong.Name = "btSoLuong";
            this.btSoLuong.Size = new System.Drawing.Size(141, 86);
            this.btSoLuong.TabIndex = 5;
            this.btSoLuong.Text = "?/?";
            this.btSoLuong.UseVisualStyleBackColor = false;
            this.btSoLuong.UseWaitCursor = true;
            // 
            // btChiTietKe
            // 
            this.btChiTietKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTietKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTietKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTietKe.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btChiTietKe.ForeColor = System.Drawing.Color.White;
            this.btChiTietKe.Location = new System.Drawing.Point(649, 12);
            this.btChiTietKe.Name = "btChiTietKe";
            this.btChiTietKe.Size = new System.Drawing.Size(141, 86);
            this.btChiTietKe.TabIndex = 6;
            this.btChiTietKe.Text = "Chi tiết thông tin kệ";
            this.btChiTietKe.UseVisualStyleBackColor = false;
            this.btChiTietKe.UseWaitCursor = true;
            this.btChiTietKe.Click += new System.EventHandler(this.btChiTietKe_Click);
            // 
            // btTaoHdXuatKho
            // 
            this.btTaoHdXuatKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTaoHdXuatKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btTaoHdXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaoHdXuatKho.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btTaoHdXuatKho.ForeColor = System.Drawing.Color.White;
            this.btTaoHdXuatKho.Location = new System.Drawing.Point(37, 12);
            this.btTaoHdXuatKho.Name = "btTaoHdXuatKho";
            this.btTaoHdXuatKho.Size = new System.Drawing.Size(141, 86);
            this.btTaoHdXuatKho.TabIndex = 7;
            this.btTaoHdXuatKho.Text = "Tạo hóa đơn xuất kho";
            this.btTaoHdXuatKho.UseVisualStyleBackColor = false;
            this.btTaoHdXuatKho.UseWaitCursor = true;
            this.btTaoHdXuatKho.Click += new System.EventHandler(this.btTaoHdXuatKho_Click);
            // 
            // btChiTietHHKe
            // 
            this.btChiTietHHKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTietHHKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTietHHKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTietHHKe.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btChiTietHHKe.ForeColor = System.Drawing.Color.White;
            this.btChiTietHHKe.Location = new System.Drawing.Point(236, 12);
            this.btChiTietHHKe.Name = "btChiTietHHKe";
            this.btChiTietHHKe.Size = new System.Drawing.Size(141, 86);
            this.btChiTietHHKe.TabIndex = 8;
            this.btChiTietHHKe.Text = "Chi tiết hàng hóa";
            this.btChiTietHHKe.UseVisualStyleBackColor = false;
            this.btChiTietHHKe.UseWaitCursor = true;
            this.btChiTietHHKe.Click += new System.EventHandler(this.btChiTietHHKe_Click);
            // 
            // btThemKe
            // 
            this.btThemKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThemKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btThemKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemKe.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btThemKe.ForeColor = System.Drawing.Color.White;
            this.btThemKe.Location = new System.Drawing.Point(441, 12);
            this.btThemKe.Name = "btThemKe";
            this.btThemKe.Size = new System.Drawing.Size(141, 86);
            this.btThemKe.TabIndex = 9;
            this.btThemKe.Text = "Thêm kệ mới";
            this.btThemKe.UseVisualStyleBackColor = false;
            this.btThemKe.UseWaitCursor = true;
            this.btThemKe.Click += new System.EventHandler(this.btThemKe_Click);
            // 
            // tabTrenKe
            // 
            this.tabTrenKe.BackColor = System.Drawing.Color.White;
            this.tabTrenKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabTrenKe.Controls.Add(this.dataGridView1);
            this.tabTrenKe.Controls.Add(this.flowLayoutPanel2);
            this.tabTrenKe.Controls.Add(this.flowLayoutPanel1);
            this.tabTrenKe.Controls.Add(this.panel1);
            this.tabTrenKe.Controls.Add(this.panel4);
            this.tabTrenKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTrenKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.tabTrenKe.Location = new System.Drawing.Point(4, 88);
            this.tabTrenKe.Margin = new System.Windows.Forms.Padding(0);
            this.tabTrenKe.Name = "tabTrenKe";
            this.tabTrenKe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabTrenKe.Size = new System.Drawing.Size(1024, 546);
            this.tabTrenKe.TabIndex = 0;
            this.tabTrenKe.Text = "Trên kệ";
            this.tabTrenKe.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControlHH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 638);
            this.panel3.TabIndex = 12;
            // 
            // tabControlHH
            // 
            this.tabControlHH.Controls.Add(this.tabTrenKe);
            this.tabControlHH.Controls.Add(this.tabKho);
            this.tabControlHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlHH.Location = new System.Drawing.Point(0, 0);
            this.tabControlHH.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlHH.Multiline = true;
            this.tabControlHH.Name = "tabControlHH";
            this.tabControlHH.Padding = new System.Drawing.Point(50, 30);
            this.tabControlHH.SelectedIndex = 0;
            this.tabControlHH.Size = new System.Drawing.Size(1032, 638);
            this.tabControlHH.TabIndex = 0;
            // 
            // tabKho
            // 
            this.tabKho.BackColor = System.Drawing.Color.White;
            this.tabKho.Controls.Add(this.dgvHHTrongKho);
            this.tabKho.Controls.Add(this.flowLayoutPanel3);
            this.tabKho.Controls.Add(this.flowLayoutPanel4);
            this.tabKho.Controls.Add(this.panel2);
            this.tabKho.Controls.Add(this.panel7);
            this.tabKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.tabKho.Location = new System.Drawing.Point(4, 88);
            this.tabKho.Name = "tabKho";
            this.tabKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabKho.Size = new System.Drawing.Size(1024, 546);
            this.tabKho.TabIndex = 1;
            this.tabKho.Text = "   Kho";
            // 
            // UC_TabKhoHH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.Name = "UC_TabKhoHH";
            this.Size = new System.Drawing.Size(1032, 638);
            this.Load += new System.EventHandler(this.UC_TabKhoHH_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHTrongKho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabTrenKe.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControlHH.ResumeLayout(false);
            this.tabKho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSortTrongKho;
        private System.Windows.Forms.Button btSearchTrongKho;
        private System.Windows.Forms.TextBox txtSearchTrongKho;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btChiTiet;
        private System.Windows.Forms.DataGridView dgvHHTrongKho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTaoHDNhap;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTaoHH;
        private System.Windows.Forms.ComboBox cbbSortTrenKe;
        private System.Windows.Forms.Button btSearchTrenKe;
        private System.Windows.Forms.TextBox txtSearchTrenKe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabTrenKe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControlHH;
        private System.Windows.Forms.TabPage tabKho;
        private System.Windows.Forms.ComboBox cbbKe;
        private System.Windows.Forms.Button btSoLuong;
        private System.Windows.Forms.Button btChiTietKe;
        private System.Windows.Forms.Button btTaoHdXuatKho;
        private System.Windows.Forms.Button btChiTietHHKe;
        private System.Windows.Forms.Button btThemKe;
        private System.Windows.Forms.Label lbKe;
    }
}