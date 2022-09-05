namespace PBL3_Book_Store_Manager.GUI_BH.UC_Control
{
    partial class UC_BHKhuyenMai
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
            this.dgvKM = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSortKM = new System.Windows.Forms.ComboBox();
            this.txtSearchKM = new System.Windows.Forms.TextBox();
            this.btSearchKM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKM
            // 
            this.dgvKM.AllowUserToAddRows = false;
            this.dgvKM.AllowUserToDeleteRows = false;
            this.dgvKM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvKM.Location = new System.Drawing.Point(34, 121);
            this.dgvKM.Name = "dgvKM";
            this.dgvKM.ReadOnly = true;
            this.dgvKM.RowHeadersWidth = 51;
            this.dgvKM.Size = new System.Drawing.Size(964, 414);
            this.dgvKM.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(34, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(964, 34);
            this.panel4.TabIndex = 23;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(998, 87);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(34, 448);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(34, 448);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 103);
            this.panel3.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbSortKM);
            this.panel1.Controls.Add(this.txtSearchKM);
            this.panel1.Controls.Add(this.btSearchKM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 87);
            this.panel1.TabIndex = 19;
            // 
            // cbbSortKM
            // 
            this.cbbSortKM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortKM.FormattingEnabled = true;
            this.cbbSortKM.Items.AddRange(new object[] {
            "Mã khuyến mãi",
            "Tên chương trình khuyến mãi",
            "Ngày bắt đầu ",
            "Ngày kết thúc"});
            this.cbbSortKM.Location = new System.Drawing.Point(463, 29);
            this.cbbSortKM.Name = "cbbSortKM";
            this.cbbSortKM.Size = new System.Drawing.Size(243, 33);
            this.cbbSortKM.TabIndex = 2;
            // 
            // txtSearchKM
            // 
            this.txtSearchKM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchKM.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSearchKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtSearchKM.Location = new System.Drawing.Point(792, 31);
            this.txtSearchKM.Name = "txtSearchKM";
            this.txtSearchKM.Size = new System.Drawing.Size(197, 33);
            this.txtSearchKM.TabIndex = 3;
            // 
            // btSearchKM
            // 
            this.btSearchKM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchKM.FlatAppearance.BorderSize = 0;
            this.btSearchKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchKM.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchKM.Location = new System.Drawing.Point(707, 1);
            this.btSearchKM.Name = "btSearchKM";
            this.btSearchKM.Size = new System.Drawing.Size(84, 87);
            this.btSearchKM.TabIndex = 1;
            this.btSearchKM.UseVisualStyleBackColor = true;
            this.btSearchKM.Click += new System.EventHandler(this.btSearchKM_Click);
            // 
            // UC_BHKhuyenMai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dgvKM);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.Name = "UC_BHKhuyenMai";
            this.Size = new System.Drawing.Size(1032, 638);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSortKM;
        private System.Windows.Forms.TextBox txtSearchKM;
        private System.Windows.Forms.Button btSearchKM;
    }
}