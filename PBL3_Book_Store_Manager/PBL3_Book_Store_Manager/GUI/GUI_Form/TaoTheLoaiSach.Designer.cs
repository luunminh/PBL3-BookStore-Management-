namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    partial class TaoTheLoaiSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbpTLS = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lbKTB = new System.Windows.Forms.Label();
            this.txtTenTLS = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lbpTLS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 58);
            this.panel1.TabIndex = 129;
            // 
            // lbpTLS
            // 
            this.lbpTLS.AutoSize = true;
            this.lbpTLS.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpTLS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbpTLS.Location = new System.Drawing.Point(387, 19);
            this.lbpTLS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpTLS.Name = "lbpTLS";
            this.lbpTLS.Size = new System.Drawing.Size(179, 25);
            this.lbpTLS.TabIndex = 46;
            this.lbpTLS.Text = "Thêm thể loại sách";
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(542, 355);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 79);
            this.btHuy.TabIndex = 134;
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
            this.btOK.Font = new System.Drawing.Font("SVN-Gilroy XBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(156, 359);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(191, 79);
            this.btOK.TabIndex = 135;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbKTB
            // 
            this.lbKTB.AutoSize = true;
            this.lbKTB.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbKTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbKTB.Location = new System.Drawing.Point(72, 198);
            this.lbKTB.Name = "lbKTB";
            this.lbKTB.Size = new System.Drawing.Size(161, 25);
            this.lbKTB.TabIndex = 133;
            this.lbKTB.Text = "Tên thể loại sách";
            // 
            // txtTenTLS
            // 
            this.txtTenTLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTLS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtTenTLS.Location = new System.Drawing.Point(328, 195);
            this.txtTenTLS.Name = "txtTenTLS";
            this.txtTenTLS.Size = new System.Drawing.Size(516, 29);
            this.txtTenTLS.TabIndex = 130;
            // 
            // TaoTheLoaiSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbKTB);
            this.Controls.Add(this.txtTenTLS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoTheLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoTheLoaiSach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbpTLS;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbKTB;
        private System.Windows.Forms.TextBox txtTenTLS;
    }
}