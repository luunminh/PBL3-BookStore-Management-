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
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.GUI.GUI_Form;

namespace PBL3_Book_Store_Manager.GUI_Form
{
    public partial class ChiTietSach : Form
    {
        string MaNhanVien;
        string MaSach;
        public ChiTietSach(string masach, string MaNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = MaNhanVien;
            this.MaSach = masach;
            Check_NhanVien();
            Show(MaSach);
        }
        public void Show(string MaHangHoa)
        {
            DTO.Sach hh = BLL_Sach.Instance.getListSach("MaHangHoa", MaHangHoa)[0];
            txtSach.Text = hh.TenHangHoa.ToString();
            //cbbTheLoaiHangHoa.Text = BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa(hh.MaTheLoaiHangHoa).TenTheLoaiHangHoa.ToString();
            txtNamSX.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).NamSanXuat;
            txtNXS.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).NhaSanXuat;
            txtSoLuongTrenKhu.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).SoLuongTrenKhuTrungBay.ToString();
            txtKho.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).SoLuongTrongKho.ToString();
            cbbKhuTrungBay.Text = BLL_KhuTrungBay.Instance.getKhuTrungBay(hh.MaKhuTrungBay).TenKhuTrungBay.ToString();
            cbbNCU.Text = BLL_NCU.Instance.getNhaCungUng(hh.MaNhaCungUng).TenNhaCungUng.ToString();
            txtGiaNhap.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).GiaNhap.ToString();
            txtGiaBan.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).GiaBan.ToString();
            txtTacGia.Text = hh.TacGia;
            txtLanTaiBan.Text = hh.LanTaiBan.ToString();

            cbbTheLoaiSach.DisplayMember = "TenTheLoaisach";
            cbbTheLoaiSach.DataSource = BLL_TheLoaiSach.Instance.getListTheLoaiSach();
            cbbKhuTrungBay.DisplayMember = "TenKhuTrungBay";
            cbbKhuTrungBay.DataSource = BLL_KhuTrungBay.Instance.getListKhuTrungBay();
            BLL_NCU.Instance.getListNCU(cbbNCU);
        }
        public bool Check_Sach()
        {
            if (txtSach.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Nhập tên sách không hợp lệ");
                return false;
            }
            int a;
            if (Int32.TryParse(txtNamSX.Text, out a) == false || txtNamSX.Text.ToString().Length != 4)
            {
                MessageBox.Show("Năm sản xuất không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtSoLuongTrenKhu.Text, out a) == false)
            {
                MessageBox.Show("Nhập số lượng trong khu trưng bày không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtKho.Text, out a) == false)
            {
                MessageBox.Show("Số lượng trong kho không hợp lệ");
                return false;
            }
            if (txtNXS.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Nhà sản xuất không hợp lệ");
                return false;
            }
            if (cbbNCU.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Nhập nhà cung ứng không hợp lệ");
                return false;
            }
            if (cbbKhuTrungBay.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Nhập khu trưng bày không hợp lệ không hợp lệ");
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
            if (Int32.TryParse(txtLanTaiBan.Text, out a) == false)
            {
                MessageBox.Show("Số lần tái bản này không hợp lệ");
                return false;
            }
            if (txtTacGia.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Tên tác giả không hợp lệ");
                return false;
            }
            if (BLL_TheLoaiSach.Instance.getTheLoaiSach_byTen(cbbTheLoaiSach.Text.ToString().Trim()) == null)
            {
                MessageBox.Show("Không tồn tại tên thể loại sách này");
                return false;
            }
            return true;
        }
        public bool Check_NhanVien()
        {
            if (BLL_NV.Instance.GetNVByMaNV(MaNhanVien).MaChucVu == "CV002")
                return false;
            txtSach.Enabled = false;
            txtNamSX.Enabled = false;
            cbbTheLoaiSach.Enabled = false;
            txtNXS.Enabled = false;
            txtTacGia.Enabled = false;
            txtLanTaiBan.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuongTrenKhu.Enabled = false;
            txtKho.Enabled = false;
            cbbKhuTrungBay.Enabled = false;
            cbbNCU.Enabled = false;
            txtGiaNhap.Enabled = false;
            btThemTLS.Enabled = false;
            btCCapNhat.Enabled = false;
            return true;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btThemTLS_Click(object sender, EventArgs e)
        {
            TaoTheLoaiSach tTLS = new TaoTheLoaiSach();
            tTLS.ShowDialog();

            cbbTheLoaiSach.DataSource = null;
            cbbTheLoaiSach.DisplayMember = "TenTheLoaisach";
            cbbTheLoaiSach.DataSource = BLL_TheLoaiSach.Instance.getListTheLoaiSach();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (Check_Sach() == false)
                return;
            //Them hang hoa
            DTO.HangHoa hanghoa = new DTO.HangHoa();
            hanghoa.MaHangHoa = this.MaSach;
            hanghoa.TenHangHoa = txtSach.Text.ToString().Trim();
            hanghoa.NamSanXuat = txtNamSX.ToString().Trim();
            hanghoa.NhaSanXuat = txtNXS.Text.ToString().ToString().Trim();
            hanghoa.SoLuongTrenKhuTrungBay = Convert.ToInt16(txtSoLuongTrenKhu.Text.Trim());
            hanghoa.SoLuongTrongKho = Convert.ToInt16(txtKho.Text.Trim());
            hanghoa.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text.Trim());
            hanghoa.GiaBan = Convert.ToDecimal(txtGiaBan.Text.Trim());
            hanghoa.TrangThai = "Đang chờ xét duyệt cập nhật thông tin ";

            DTO.DeXuat DeXuat = new DTO.DeXuat("", MaNhanVien, "Đang chờ phê duyệt", "Đề xuất cập nhật thông tin hàng hóa", DateTime.Now);

            hanghoa.MaKho = "K000";
            string MaTheLoaiSach = BLL_TheLoaiSach.Instance.getTheLoaiSach_byTen(cbbTheLoaiSach.Text.ToString().Trim()).MaTheLoaiSach;
            DTO.Sach Sach = new Sach(hanghoa, txtTacGia.Text.ToString().Trim(), Convert.ToByte(txtLanTaiBan.Text.ToString().Trim()), MaTheLoaiSach);
            DialogResult results = MessageBox.Show("Bạn có muốn đề xuất cập nhật thông tin hàng hóa này không ?", "Xác nhận cập nhật thông tin sách", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                BLL_HangHoa.Instance.DeXuatThemHangHoa(DeXuat, hanghoa, "Sách", cbbKhuTrungBay.Text.ToString().Trim(), cbbNCU.Text.ToString().Trim());
                BLL_Sach.Instance.DeXuatTheSach(Sach);
            }
            this.Dispose();

        }
    }
}