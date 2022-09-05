namespace PBL3_Book_Store_Manager.GUI_KHO.UC_Control
{
    partial class UC_KhoNCU
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
            this.dgvNCU = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.btChiTiet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCU)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNCU
            // 
            this.dgvNCU.AllowUserToAddRows = false;
            this.dgvNCU.AllowUserToDeleteRows = false;
            this.dgvNCU.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvNCU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCU.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvNCU.Location = new System.Drawing.Point(34, 121);
            this.dgvNCU.Name = "dgvNCU";
            this.dgvNCU.ReadOnly = true;
            this.dgvNCU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCU.Size = new System.Drawing.Size(964, 407);
            this.dgvNCU.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(34, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(964, 34);
            this.panel4.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(998, 87);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(34, 441);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(34, 441);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.btChiTiet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 110);
            this.panel3.TabIndex = 26;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(206, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(198, 86);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Đề xuất thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btChiTiet
            // 
            this.btChiTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTiet.ForeColor = System.Drawing.Color.White;
            this.btChiTiet.Location = new System.Drawing.Point(637, 12);
            this.btChiTiet.Name = "btChiTiet";
            this.btChiTiet.Size = new System.Drawing.Size(198, 86);
            this.btChiTiet.TabIndex = 2;
            this.btChiTiet.Text = "Chi tiết";
            this.btChiTiet.UseVisualStyleBackColor = false;
            this.btChiTiet.Click += new System.EventHandler(this.btChiTiet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbSort);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 87);
            this.panel1.TabIndex = 25;
            // 
            // cbbSort
            // 
            this.cbbSort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Items.AddRange(new object[] {
            "Tên nhà cung ứng",
            "Địa chỉ",
            "Số điện thoại"});
            this.cbbSort.Location = new System.Drawing.Point(507, 29);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(199, 33);
            this.cbbSort.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.Location = new System.Drawing.Point(792, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 33);
            this.txtSearch.TabIndex = 3;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearch.Location = new System.Drawing.Point(707, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(84, 87);
            this.btSearch.TabIndex = 1;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // UC_KhoNCU
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dgvNCU);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_KhoNCU";
            this.Size = new System.Drawing.Size(1032, 638);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCU)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNCU;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btChiTiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSearch;
    }
}
