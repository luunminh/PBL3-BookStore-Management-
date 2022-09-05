using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Book_Store_Manager.BLL;

namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    public partial class TaoTheLoaiSach : Form
    {
        public TaoTheLoaiSach()
        {
            InitializeComponent();
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Check()
        {
            if(txtTenTLS.Text.Replace(" ","") =="")
            {
                MessageBox.Show("Nhập tên thể loại không phù hợp");
                return true;
            }
            if (BLL_TheLoaiSach.Instance.getTheLoaiSach_byTen(txtTenTLS.Text.Trim().ToString()) != null)
            {
                MessageBox.Show("Thể loại này đã tồn tại");
                return true;
            }
            return false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(Check() == false)
            {
                BLL_TheLoaiSach.Instance.ThemTheLoaiSach(txtTenTLS.Text);
                this.Close();
            }    
           
        }
    }
}