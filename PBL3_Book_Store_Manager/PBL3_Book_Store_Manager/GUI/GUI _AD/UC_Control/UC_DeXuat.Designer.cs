namespace PBL3_Book_Store_Manager.GUI.GUI__AD.UC_Control
{
    partial class UC_DeXuat
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
            this.dgvDeXuat = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSortDeXuat = new System.Windows.Forms.ComboBox();
            this.txtSearchDeXuat = new System.Windows.Forms.TextBox();
            this.btSearchDeXuat = new System.Windows.Forms.Button();
            this.btChiTiet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeXuat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeXuat
            // 
            this.dgvDeXuat.AllowUserToAddRows = false;
            this.dgvDeXuat.AllowUserToDeleteRows = false;
            this.dgvDeXuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvDeXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeXuat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvDeXuat.Location = new System.Drawing.Point(34, 121);
            this.dgvDeXuat.Name = "dgvDeXuat";
            this.dgvDeXuat.ReadOnly = true;
            this.dgvDeXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeXuat.Size = new System.Drawing.Size(964, 407);
            this.dgvDeXuat.TabIndex = 30;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbSortDeXuat);
            this.panel1.Controls.Add(this.txtSearchDeXuat);
            this.panel1.Controls.Add(this.btSearchDeXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 87);
            this.panel1.TabIndex = 25;
            // 
            // cbbSortDeXuat
            // 
            this.cbbSortDeXuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortDeXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.cbbSortDeXuat.FormattingEnabled = true;
            this.cbbSortDeXuat.Items.AddRange(new object[] {
            "Mã đề xuất",
            "Tên nhân viên",
            "Loại đề xuất",
            "Tình trạng"});
            this.cbbSortDeXuat.Location = new System.Drawing.Point(507, 29);
            this.cbbSortDeXuat.Name = "cbbSortDeXuat";
            this.cbbSortDeXuat.Size = new System.Drawing.Size(199, 33);
            this.cbbSortDeXuat.TabIndex = 2;
            // 
            // txtSearchDeXuat
            // 
            this.txtSearchDeXuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchDeXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtSearchDeXuat.Location = new System.Drawing.Point(792, 31);
            this.txtSearchDeXuat.Name = "txtSearchDeXuat";
            this.txtSearchDeXuat.Size = new System.Drawing.Size(197, 33);
            this.txtSearchDeXuat.TabIndex = 3;
            // 
            // btSearchDeXuat
            // 
            this.btSearchDeXuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchDeXuat.FlatAppearance.BorderSize = 0;
            this.btSearchDeXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchDeXuat.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchDeXuat.Location = new System.Drawing.Point(707, 1);
            this.btSearchDeXuat.Name = "btSearchDeXuat";
            this.btSearchDeXuat.Size = new System.Drawing.Size(84, 87);
            this.btSearchDeXuat.TabIndex = 1;
            this.btSearchDeXuat.UseVisualStyleBackColor = true;
            this.btSearchDeXuat.Click += new System.EventHandler(this.btSearchDeXuat_Click);
            // 
            // btChiTiet
            // 
            this.btChiTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTiet.ForeColor = System.Drawing.Color.White;
            this.btChiTiet.Location = new System.Drawing.Point(424, 14);
            this.btChiTiet.Name = "btChiTiet";
            this.btChiTiet.Size = new System.Drawing.Size(198, 83);
            this.btChiTiet.TabIndex = 2;
            this.btChiTiet.Text = "Chi tiết";
            this.btChiTiet.UseVisualStyleBackColor = false;
            this.btChiTiet.Click += new System.EventHandler(this.btChiTiet_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btChiTiet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 110);
            this.panel3.TabIndex = 26;
            // 
            // UC_DeXuat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDeXuat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.Name = "UC_DeXuat";
            this.Size = new System.Drawing.Size(1032, 638);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeXuat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeXuat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSortDeXuat;
        private System.Windows.Forms.TextBox txtSearchDeXuat;
        private System.Windows.Forms.Button btSearchDeXuat;
        private System.Windows.Forms.Button btChiTiet;
        private System.Windows.Forms.Panel panel3;
    }
}
