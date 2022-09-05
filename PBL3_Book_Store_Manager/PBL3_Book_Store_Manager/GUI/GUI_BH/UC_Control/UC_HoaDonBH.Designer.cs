namespace PBL3_Book_Store_Manager.GUI_BH.UC_Control
{
    partial class UC_HoaDonBH
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
            this.dgvHDBH = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btThemHDBH = new System.Windows.Forms.Button();
            this.btDetailHH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSortHDBH = new System.Windows.Forms.ComboBox();
            this.txtSearchHDBH = new System.Windows.Forms.TextBox();
            this.btSearchHDBH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBH)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHDBH
            // 
            this.dgvHDBH.AllowUserToAddRows = false;
            this.dgvHDBH.AllowUserToDeleteRows = false;
            this.dgvHDBH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvHDBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvHDBH.Location = new System.Drawing.Point(34, 121);
            this.dgvHDBH.Name = "dgvHDBH";
            this.dgvHDBH.ReadOnly = true;
            this.dgvHDBH.RowHeadersWidth = 80;
            this.dgvHDBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDBH.Size = new System.Drawing.Size(964, 407);
            this.dgvHDBH.TabIndex = 24;
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(34, 441);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(34, 441);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btThemHDBH);
            this.panel3.Controls.Add(this.btDetailHH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 110);
            this.panel3.TabIndex = 20;
            // 
            // btThemHDBH
            // 
            this.btThemHDBH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThemHDBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btThemHDBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemHDBH.ForeColor = System.Drawing.Color.White;
            this.btThemHDBH.Location = new System.Drawing.Point(227, 30);
            this.btThemHDBH.Name = "btThemHDBH";
            this.btThemHDBH.Size = new System.Drawing.Size(198, 57);
            this.btThemHDBH.TabIndex = 2;
            this.btThemHDBH.Text = "Thêm";
            this.btThemHDBH.UseVisualStyleBackColor = false;
            this.btThemHDBH.Click += new System.EventHandler(this.btThemHDBH_Click);
            // 
            // btDetailHH
            // 
            this.btDetailHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDetailHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btDetailHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetailHH.ForeColor = System.Drawing.Color.White;
            this.btDetailHH.Location = new System.Drawing.Point(611, 30);
            this.btDetailHH.Name = "btDetailHH";
            this.btDetailHH.Size = new System.Drawing.Size(198, 57);
            this.btDetailHH.TabIndex = 2;
            this.btDetailHH.Text = "Chi tiết";
            this.btDetailHH.UseVisualStyleBackColor = false;
            this.btDetailHH.Click += new System.EventHandler(this.btDetailHH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbSortHDBH);
            this.panel1.Controls.Add(this.txtSearchHDBH);
            this.panel1.Controls.Add(this.btSearchHDBH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 87);
            this.panel1.TabIndex = 19;
            // 
            // cbbSortHDBH
            // 
            this.cbbSortHDBH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortHDBH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.cbbSortHDBH.FormattingEnabled = true;
            this.cbbSortHDBH.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Tên nhân viên"});
            this.cbbSortHDBH.Location = new System.Drawing.Point(481, 29);
            this.cbbSortHDBH.Name = "cbbSortHDBH";
            this.cbbSortHDBH.Size = new System.Drawing.Size(225, 33);
            this.cbbSortHDBH.TabIndex = 2;
            // 
            // txtSearchHDBH
            // 
            this.txtSearchHDBH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchHDBH.Location = new System.Drawing.Point(792, 29);
            this.txtSearchHDBH.Name = "txtSearchHDBH";
            this.txtSearchHDBH.Size = new System.Drawing.Size(197, 33);
            this.txtSearchHDBH.TabIndex = 3;
            // 
            // btSearchHDBH
            // 
            this.btSearchHDBH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchHDBH.FlatAppearance.BorderSize = 0;
            this.btSearchHDBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchHDBH.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchHDBH.Location = new System.Drawing.Point(707, 1);
            this.btSearchHDBH.Name = "btSearchHDBH";
            this.btSearchHDBH.Size = new System.Drawing.Size(84, 87);
            this.btSearchHDBH.TabIndex = 1;
            this.btSearchHDBH.UseVisualStyleBackColor = true;
            this.btSearchHDBH.Click += new System.EventHandler(this.btSearchHDBH_Click);
            // 
            // UC_HoaDonBH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvHDBH);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.Name = "UC_HoaDonBH";
            this.Size = new System.Drawing.Size(1032, 638);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHDBH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btThemHDBH;
        private System.Windows.Forms.Button btDetailHH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSortHDBH;
        private System.Windows.Forms.TextBox txtSearchHDBH;
        private System.Windows.Forms.Button btSearchHDBH;
    }
}
