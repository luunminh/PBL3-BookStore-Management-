namespace PBL3_Book_Store_Manager.GUI__AD.UC_Control
{
    partial class UC_TabHH
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
            this.btSearchHH = new System.Windows.Forms.Button();
            this.btChiTietHH = new System.Windows.Forms.Button();
            this.cbbSortHH = new System.Windows.Forms.ComboBox();
            this.txtSearchHH = new System.Windows.Forms.TextBox();
            this.tabHH = new System.Windows.Forms.TabPage();
            this.dgvHH = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSearchHH
            // 
            this.btSearchHH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchHH.FlatAppearance.BorderSize = 0;
            this.btSearchHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchHH.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchHH.Location = new System.Drawing.Point(884, 4);
            this.btSearchHH.Name = "btSearchHH";
            this.btSearchHH.Size = new System.Drawing.Size(102, 47);
            this.btSearchHH.TabIndex = 7;
            this.btSearchHH.UseVisualStyleBackColor = true;
            this.btSearchHH.UseWaitCursor = true;
            this.btSearchHH.Click += new System.EventHandler(this.btSearchHH_Click);
            // 
            // btChiTietHH
            // 
            this.btChiTietHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTietHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTietHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTietHH.ForeColor = System.Drawing.Color.White;
            this.btChiTietHH.Location = new System.Drawing.Point(412, 14);
            this.btChiTietHH.Name = "btChiTietHH";
            this.btChiTietHH.Size = new System.Drawing.Size(198, 85);
            this.btChiTietHH.TabIndex = 4;
            this.btChiTietHH.Text = "Chi tiết";
            this.btChiTietHH.UseVisualStyleBackColor = false;
            this.btChiTietHH.UseWaitCursor = true;
            this.btChiTietHH.Click += new System.EventHandler(this.btChiTietHH_Click);
            // 
            // cbbSortHH
            // 
            this.cbbSortHH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortHH.FormattingEnabled = true;
            this.cbbSortHH.Items.AddRange(new object[] {
            "Tên hàng hóa",
            "Nhà sản xuất",
            "Năm sản xuất",
            "Số lương trên trưng bày",
            "Số lượng trong kho",
            "Giá nhập",
            "Giá bán",
            "Trạng thái"});
            this.cbbSortHH.Location = new System.Drawing.Point(507, 12);
            this.cbbSortHH.Name = "cbbSortHH";
            this.cbbSortHH.Size = new System.Drawing.Size(173, 33);
            this.cbbSortHH.TabIndex = 8;
            this.cbbSortHH.UseWaitCursor = true;
            // 
            // txtSearchHH
            // 
            this.txtSearchHH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchHH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtSearchHH.Location = new System.Drawing.Point(714, 12);
            this.txtSearchHH.Name = "txtSearchHH";
            this.txtSearchHH.Size = new System.Drawing.Size(161, 33);
            this.txtSearchHH.TabIndex = 9;
            this.txtSearchHH.UseWaitCursor = true;
            // 
            // tabHH
            // 
            this.tabHH.BackColor = System.Drawing.Color.White;
            this.tabHH.Controls.Add(this.dgvHH);
            this.tabHH.Controls.Add(this.flowLayoutPanel3);
            this.tabHH.Controls.Add(this.flowLayoutPanel4);
            this.tabHH.Controls.Add(this.panel2);
            this.tabHH.Controls.Add(this.panel7);
            this.tabHH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.tabHH.Location = new System.Drawing.Point(4, 88);
            this.tabHH.Name = "tabHH";
            this.tabHH.Padding = new System.Windows.Forms.Padding(3);
            this.tabHH.Size = new System.Drawing.Size(1024, 546);
            this.tabHH.TabIndex = 1;
            this.tabHH.Text = "Hàng hóa";
            // 
            // dgvHH
            // 
            this.dgvHH.AllowUserToAddRows = false;
            this.dgvHH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHH.Location = new System.Drawing.Point(37, 64);
            this.dgvHH.Name = "dgvHH";
            this.dgvHH.ReadOnly = true;
            this.dgvHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHH.Size = new System.Drawing.Size(950, 369);
            this.dgvHH.TabIndex = 21;
            this.dgvHH.UseWaitCursor = true;
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
            this.panel2.Controls.Add(this.btChiTietHH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 110);
            this.panel2.TabIndex = 17;
            this.panel2.UseWaitCursor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.cbbSortHH);
            this.panel7.Controls.Add(this.btSearchHH);
            this.panel7.Controls.Add(this.txtSearchHH);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 61);
            this.panel7.TabIndex = 20;
            this.panel7.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 638);
            this.panel3.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHH);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(50, 30);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // UC_TabHH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.Name = "UC_TabHH";
            this.Size = new System.Drawing.Size(1032, 638);
            this.tabHH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSearchHH;
        private System.Windows.Forms.Button btChiTietHH;
        private System.Windows.Forms.ComboBox cbbSortHH;
        private System.Windows.Forms.TextBox txtSearchHH;
        private System.Windows.Forms.TabPage tabHH;
        private System.Windows.Forms.DataGridView dgvHH;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}