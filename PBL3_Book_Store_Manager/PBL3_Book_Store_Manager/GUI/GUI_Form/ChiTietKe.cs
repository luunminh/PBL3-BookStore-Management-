using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.BLL;

namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    public partial class ChiTietKe : Form
    {
        string makhutrungbay;
        public ChiTietKe(string MaKhuTrungBay)
        {
            InitializeComponent();
            Show(MaKhuTrungBay);
            makhutrungbay = MaKhuTrungBay;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Check()
        {
            if (txtTenKTB.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Nhập tên kệ không hợp lệ");
                return true;
            }
            int a;
            if (Int32.TryParse(txtSoLuongToiDa.Text, out a) == false)
            {
                MessageBox.Show("Nhập số lượng tối đa không hợp lệ");
                return true;
            }
            return false;
        }
        public void Show(string MaKhuTrungBay)
        {
            DTO.KhuTrungBay KTB = BLL_KhuTrungBay.Instance.getKhuTrungBay(MaKhuTrungBay);
            txtTenKTB.Text = KTB.TenKhuTrungBay.ToString();
            txtSoLuongToiDa.Text = KTB.SoLuongToiDa.ToString();
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                DTO.KhuTrungBay KhuTrungBay = new KhuTrungBay();
                KhuTrungBay.MaKhuTrungBay = makhutrungbay;
                KhuTrungBay.TenKhuTrungBay = txtTenKTB.Text.ToString().Trim();
                KhuTrungBay.SoLuongToiDa = Convert.ToInt16(txtSoLuongToiDa.Text.Trim());
                MessageBox.Show("Dữ liệu của khu trưng bày sẽ được cập nhật");
                DialogResult results = MessageBox.Show("Bạn có muốn cập nhật thông tin khu trưng bày này không ?", "Xác nhận cập nhật khu trưng bày", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    BLL_KhuTrungBay.Instance.CapNhatKhuTrungBay(KhuTrungBay);
                    MessageBox.Show("Dữ liệu đã được cập nhật");
                    this.Close();
                }
            }
        }
    }
}