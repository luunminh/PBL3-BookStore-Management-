namespace PBL3_Book_Store_Manager.GUI__AD.UC_Control
{
    partial class UC_NCU
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btChiTietNCU = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSortNCU = new System.Windows.Forms.ComboBox();
            this.txtSearchNCU = new System.Windows.Forms.TextBox();
            this.btSearchNCU = new System.Windows.Forms.Button();
            this.dgvNCU = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCU)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(34, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(964, 34);
            this.panel4.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(998, 87);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(34, 441);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(34, 441);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btChiTietNCU);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 110);
            this.panel3.TabIndex = 7;
            // 
            // btChiTietNCU
            // 
            this.btChiTietNCU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChiTietNCU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.btChiTietNCU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiTietNCU.ForeColor = System.Drawing.Color.White;
            this.btChiTietNCU.Location = new System.Drawing.Point(418, 30);
            this.btChiTietNCU.Name = "btChiTietNCU";
            this.btChiTietNCU.Size = new System.Drawing.Size(198, 57);
            this.btChiTietNCU.TabIndex = 2;
            this.btChiTietNCU.Text = "Chi tiết";
            this.btChiTietNCU.UseVisualStyleBackColor = false;
            this.btChiTietNCU.Click += new System.EventHandler(this.btChiTietNCU_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbSortNCU);
            this.panel1.Controls.Add(this.txtSearchNCU);
            this.panel1.Controls.Add(this.btSearchNCU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 87);
            this.panel1.TabIndex = 6;
            // 
            // cbbSortNCU
            // 
            this.cbbSortNCU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbSortNCU.FormattingEnabled = true;
            this.cbbSortNCU.Items.AddRange(new object[] {
            "Tên nhà cung ứng",
            "Địa chỉ",
            "Số điện thoại"});
            this.cbbSortNCU.Location = new System.Drawing.Point(507, 29);
            this.cbbSortNCU.Name = "cbbSortNCU";
            this.cbbSortNCU.Size = new System.Drawing.Size(199, 33);
            this.cbbSortNCU.TabIndex = 2;
            // 
            // txtSearchNCU
            // 
            this.txtSearchNCU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchNCU.Location = new System.Drawing.Point(792, 31);
            this.txtSearchNCU.Name = "txtSearchNCU";
            this.txtSearchNCU.Size = new System.Drawing.Size(197, 33);
            this.txtSearchNCU.TabIndex = 3;
            // 
            // btSearchNCU
            // 
            this.btSearchNCU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSearchNCU.FlatAppearance.BorderSize = 0;
            this.btSearchNCU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchNCU.Image = global::PBL3_Book_Store_Manager.Properties.Resources.search;
            this.btSearchNCU.Location = new System.Drawing.Point(707, 1);
            this.btSearchNCU.Name = "btSearchNCU";
            this.btSearchNCU.Size = new System.Drawing.Size(84, 87);
            this.btSearchNCU.TabIndex = 1;
            this.btSearchNCU.UseVisualStyleBackColor = true;
            this.btSearchNCU.Click += new System.EventHandler(this.btSearchNCU_Click);
            // 
            // dgvNCU
            // 
            this.dgvNCU.AllowUserToAddRows = false;
            this.dgvNCU.AllowUserToDeleteRows = false;
            this.dgvNCU.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.dgvNCU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCU.Location = new System.Drawing.Point(34, 121);
            this.dgvNCU.Name = "dgvNCU";
            this.dgvNCU.ReadOnly = true;
            this.dgvNCU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCU.Size = new System.Drawing.Size(964, 407);
            this.dgvNCU.TabIndex = 11;
            // 
            // UC_NCU
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvNCU);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UC_NCU";
            this.Size = new System.Drawing.Size(1032, 638);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btChiTietNCU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSortNCU;
        private System.Windows.Forms.TextBox txtSearchNCU;
        private System.Windows.Forms.Button btSearchNCU;
        private System.Windows.Forms.DataGridView dgvNCU;
    }
}
