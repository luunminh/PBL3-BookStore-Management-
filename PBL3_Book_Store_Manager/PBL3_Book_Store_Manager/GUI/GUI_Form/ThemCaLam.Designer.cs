namespace PBL3_Book_Store_Manager.GUI_Form
{
    partial class ThemCaLam
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
            this.btHuy = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCaLam = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhuCapCa = new System.Windows.Forms.TextBox();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
            this.txtGioBatDau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btHuy.FlatAppearance.BorderSize = 0;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("SVN-Gilroy XBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.White;
            this.btHuy.Location = new System.Drawing.Point(581, 460);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(191, 76);
            this.btHuy.TabIndex = 94;
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
            this.btOK.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(293, 460);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(191, 76);
            this.btOK.TabIndex = 95;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(546, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 88;
            this.label4.Text = "Giờ kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(47, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Giờ bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(43, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Tiền phụ cấp ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên ca làm";
            // 
            // txtTenCaLam
            // 
            this.txtTenCaLam.Location = new System.Drawing.Point(206, 116);
            this.txtTenCaLam.Name = "txtTenCaLam";
            this.txtTenCaLam.Size = new System.Drawing.Size(787, 33);
            this.txtTenCaLam.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 58);
            this.panel1.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(476, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Thêm ca làm";
            // 
            // txtPhuCapCa
            // 
            this.txtPhuCapCa.Location = new System.Drawing.Point(206, 178);
            this.txtPhuCapCa.Name = "txtPhuCapCa";
            this.txtPhuCapCa.Size = new System.Drawing.Size(787, 33);
            this.txtPhuCapCa.TabIndex = 87;
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.txtGioKetThuc.Location = new System.Drawing.Point(708, 279);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(285, 33);
            this.txtGioKetThuc.TabIndex = 98;
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.txtGioBatDau.Location = new System.Drawing.Point(184, 281);
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(305, 33);
            this.txtGioBatDau.TabIndex = 99;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(35, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 99);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(35, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 153);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            // 
            // ThemCaLam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 606);
            this.Controls.Add(this.txtGioKetThuc);
            this.Controls.Add(this.txtGioBatDau);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhuCapCa);
            this.Controls.Add(this.txtTenCaLam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("SVN-Gilroy XBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemCaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemCaLam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCaLam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhuCapCa;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.TextBox txtGioBatDau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}