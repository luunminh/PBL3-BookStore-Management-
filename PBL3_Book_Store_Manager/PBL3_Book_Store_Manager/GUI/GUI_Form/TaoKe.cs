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
    public partial class TaoKe : Form
    {
        public TaoKe()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool Check()
        {
            if (txtTenKTB.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Nhập tên kệ không phù hợp");
                return true;
            }
            int a;
            if(Int32.TryParse(txtSoLuongToiDa.Text,out a) == false)
            {

                MessageBox.Show("Số lượng tối đa không phù hợp");
                return true;
            }
            if (BLL_KhuTrungBay.Instance.getKhuTrungBay_Ten(txtTenKTB.Text.ToString()) != null)
            {
                MessageBox.Show("Tên khu trưng bày đã tồn tại");
                return true;
            }
            return false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
           if(Check() == false)
            {
                DTO.KhuTrungBay KhuTrungBay = new DTO.KhuTrungBay();

                KhuTrungBay.TenKhuTrungBay = txtTenKTB.Text.ToString().Trim();
                KhuTrungBay.SoLuongToiDa = Convert.ToInt16(txtSoLuongToiDa.Text.Trim());
                DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo khu trưng bày mới không ?", "Xác nhận tạo khu trưng bày", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    BLL_KhuTrungBay.Instance.ThemKhuTrungBay(KhuTrungBay);
                }

                this.Close();
            }    
        }
    }
}