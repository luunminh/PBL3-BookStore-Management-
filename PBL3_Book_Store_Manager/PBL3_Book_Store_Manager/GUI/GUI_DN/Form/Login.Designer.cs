namespace PBL3_Book_Store_Manager
{
    partial class Login
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
            this.logo2 = new System.Windows.Forms.Label();
            this.logo1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbMk = new System.Windows.Forms.Label();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEye = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.logo2);
            this.panel1.Controls.Add(this.logo1);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 96);
            this.panel1.TabIndex = 0;
            // 
            // logo2
            // 
            this.logo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo2.AutoSize = true;
            this.logo2.Font = new System.Drawing.Font("Iceland", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(122)))), ((int)(((byte)(251)))));
            this.logo2.Location = new System.Drawing.Point(106, 19);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(71, 58);
            this.logo2.TabIndex = 4;
            this.logo2.Text = "TT";
            // 
            // logo1
            // 
            this.logo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo1.AutoSize = true;
            this.logo1.Font = new System.Drawing.Font("Iceland", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logo1.Location = new System.Drawing.Point(12, 19);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(101, 58);
            this.logo1.TabIndex = 5;
            this.logo1.Text = "AM";
            // 
            // btExit
            // 
            this.btExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Image = global::PBL3_Book_Store_Manager.Properties.Resources.Exit;
            this.btExit.Location = new System.Drawing.Point(1187, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(93, 96);
            this.btExit.TabIndex = 0;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbUserName.Location = new System.Drawing.Point(459, 332);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(141, 28);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Tên tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(454, 368);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(406, 29);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // lbMk
            // 
            this.lbMk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMk.AutoSize = true;
            this.lbMk.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.lbMk.Location = new System.Drawing.Point(459, 436);
            this.lbMk.Name = "lbMk";
            this.lbMk.Size = new System.Drawing.Size(105, 28);
            this.lbMk.TabIndex = 1;
            this.lbMk.Text = "Mật Khẩu";
            // 
            // txtMk
            // 
            this.txtMk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.txtMk.Location = new System.Drawing.Point(454, 467);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(406, 29);
            this.txtMk.TabIndex = 2;
            this.txtMk.UseSystemPasswordChar = true;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btDangNhap.FlatAppearance.BorderSize = 0;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Location = new System.Drawing.Point(548, 553);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(207, 82);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("iCiel Artsy & Raw Raw 2", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(431, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 96);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà Sách AMTT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PBL3_Book_Store_Manager.Properties.Resources.book2;
            this.pictureBox1.Location = new System.Drawing.Point(296, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 125);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btEye
            // 
            this.btEye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEye.BackColor = System.Drawing.Color.White;
            this.btEye.FlatAppearance.BorderSize = 0;
            this.btEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEye.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEye.ForeColor = System.Drawing.Color.White;
            this.btEye.Image = global::PBL3_Book_Store_Manager.Properties.Resources.eyes;
            this.btEye.Location = new System.Drawing.Point(820, 467);
            this.btEye.Name = "btEye";
            this.btEye.Size = new System.Drawing.Size(38, 29);
            this.btEye.TabIndex = 3;
            this.btEye.UseVisualStyleBackColor = false;
            this.btEye.Click += new System.EventHandler(this.btEye_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEye);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.lbMk);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label logo2;
        private System.Windows.Forms.Label logo1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbMk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEye;
    }
}