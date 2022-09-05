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
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.GUI.GUI_Form;

namespace PBL3_Book_Store_Manager.GUI_Form
{
    public partial class TaoHangHoa : Form
    {
        public string MaNhanVien { get; set; }
        public TaoHangHoa(string MaNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = MaNhanVien;
            {
                cbbKhuTrungBay.DisplayMember = "TenKhuTrungBay";
                cbbKhuTrungBay.DataSource = BLL_KhuTrungBay.Instance.getListKhuTrungBay();
                cbbTheLoaiHangHoa.DisplayMember = "TenTheLoaiHangHoa";
                cbbTheLoaiHangHoa.DataSource = BLL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa();
                BLL_NCU.Instance.getListNCU(cbbNCU);
            }
        }
        public bool Check()
        {
            if (txtTenHH.Text.Replace(" ","") == "")
            {
                MessageBox.Show("Tên hàng hóa không hợp lệ");
                return false;
            }
            int a;
            if (Int32.TryParse(txtNamSX.Text,out a) == false || txtNamSX.Text.ToString().Length != 4)
            {
                MessageBox.Show("Năm sản xuất không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtSoLuongOKhu.Text, out a) == false )
            {
                MessageBox.Show("Số lượng trong khu trưng bày không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtSoLuongOKho.Text, out a) == false )
            {
                MessageBox.Show("Số lượng trong kho không hợp lệ");
                return false;
            }
            if (txtNhaSanXuat.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Nhà sản xuất không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtGiaBan.Text, out a) == false)
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtGiaNhap.Text, out a) == false)
            {
                MessageBox.Show("Giá nhập không hợp lệ");
                return false;
            }
            if (BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa("TenTheLoaiHangHoa", cbbTheLoaiHangHoa.Text.ToString().Trim()) == null)
            {
                MessageBox.Show("Không tồn tại thể loại hàng hóa này");
                return false;
            }
            if (BLL_KhuTrungBay.Instance.getKhuTrungBay_Ten(cbbKhuTrungBay.Text.ToString().Trim()) == null)
            {
                MessageBox.Show("Không tồn tại khu trưng bày này");
                return false;
            }
            if (BLL_NCU.Instance.SearchListNCUByTenNCU(cbbNCU.Text.ToString().Trim()) == null)
            {
                MessageBox.Show("Không tồn tại nhà cung ứng này");
                return false;
            }
            return true;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(Check() == false)
            {
                return;
            }    
            DTO.HangHoa hanghoa = new DTO.HangHoa();
            hanghoa.TenHangHoa = txtTenHH.Text.ToString().Trim();
            hanghoa.NamSanXuat = txtNamSX.ToString().Trim();
            hanghoa.NhaSanXuat = txtNhaSanXuat.Text.ToString().ToString().Trim();
            hanghoa.SoLuongTrenKhuTrungBay = Convert.ToInt16(txtSoLuongOKhu.Text.Trim());
            hanghoa.SoLuongTrongKho = Convert.ToInt16(txtSoLuongOKho.Text.Trim());
            hanghoa.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text.Trim());
            hanghoa.GiaBan = Convert.ToDecimal(txtGiaBan.Text.Trim());
            hanghoa.TrangThai = "Đang chờ xét duyệt thêm";

            DTO.DeXuat DeXuat = new DTO.DeXuat("", MaNhanVien, "Đang chờ phê duyệt", "Đề xuất thêm hàng hóa", DateTime.Now);

            hanghoa.MaKho = "K000";

            if (cbbTheLoaiHangHoa.Text.ToString().Trim() == "Sách")
                using (TaoSach taoSach = new TaoSach(DeXuat, hanghoa, cbbTheLoaiHangHoa.Text.ToString().Trim(), cbbKhuTrungBay.Text.ToString().Trim(), cbbNCU.Text.ToString().Trim()))
                    taoSach.ShowDialog();
            else
            {
                DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo đề xuất hàng hóa mới mới không ?", "Xác nhận tạo hàng hóa", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    BLL_HangHoa.Instance.DeXuatThemHangHoa(DeXuat, hanghoa, cbbTheLoaiHangHoa.Text.ToString().Trim(), cbbKhuTrungBay.Text.ToString().Trim(), cbbNCU.Text.ToString().Trim());
                    MessageBox.Show("Đã gửi đề xuất tạo hàng hóa mới thành công!");
                }
            }
            
            this.Dispose();
        }
        private void btThemTLHH_Click(object sender, EventArgs e)
        {
            TaoTheLoaiHangHoa tTLHH = new TaoTheLoaiHangHoa();
            tTLHH.ShowDialog();

            cbbTheLoaiHangHoa.DataSource = null;
            cbbTheLoaiHangHoa.DisplayMember = "TenTheLoaiHangHoa";
            cbbTheLoaiHangHoa.DataSource = BLL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa();
        }
    }
}