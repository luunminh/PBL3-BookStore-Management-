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
    public partial class TaoTheLoaiHangHoa : Form
    {
        public TaoTheLoaiHangHoa()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            if (txtTenTLHH.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Nhập tên thể loại hàng hóa không hợp lệ");
                return true;
            }
            if (BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa("TenTheLoaiHangHoa", txtTenTLHH.Text.Trim().ToString()) != null)
            {
                MessageBox.Show("Tên thể loại hàng hóa này đã tồn tại");
            }
            return false;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if(Check()== false)
            {
                DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo thể loại hàng hóa mới không ?", "Xác nhận tạo thể loại hàng hóa", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    BLL_TheLoaiHangHoa.Instance.ThemTheLoaiHangHoa(txtTenTLHH.Text.ToString());
                }
                this.Close();
            }    
            
        }
    }
}