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
    public partial class ChiTietHangHoa : Form
    {
        string MaHangHoa;
        string MaNhanVien;
        public ChiTietHangHoa(string mahanghoa, string manhanvien)
        {
            InitializeComponent();
            MaHangHoa = mahanghoa;
            this.MaNhanVien = manhanvien;
            Check_NhanVien();
            Show(MaHangHoa);
            
        }
        List<DTO.HangHoa> hanghoa = new List<DTO.HangHoa>();
        public void Show(string MaHangHoa)
        {
            DTO.HangHoa hh = new DTO.HangHoa();
            hh = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa);
            txtTenHH.Text = hh.TenHangHoa.ToString();
            txtNamSX.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).NamSanXuat;
            txtNXS.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).NhaSanXuat;
            txtSoLuongOKhu.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).SoLuongTrenKhuTrungBay.ToString();
            txtSoLuongOKho.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).SoLuongTrongKho.ToString();
            txtGiaNhap.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).GiaNhap.ToString();
            txtGiaBan.Text = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(MaHangHoa).GiaBan.ToString();

            cbbKhuTrungBay.DisplayMember = "TenKhuTrungBay";
            cbbKhuTrungBay.DataSource = BLL_KhuTrungBay.Instance.getListKhuTrungBay();
            cbbTheLoaiHangHoa.DisplayMember = "TenTheLoaiHangHoa";
            cbbTheLoaiHangHoa.DataSource = BLL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa();
            BLL_NCU.Instance.getListNCU(cbbNCU);

            cbbTheLoaiHangHoa.Text = BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa(hh.MaTheLoaiHangHoa).TenTheLoaiHangHoa.ToString();
            cbbKhuTrungBay.Text = BLL_KhuTrungBay.Instance.getKhuTrungBay(hh.MaKhuTrungBay).TenKhuTrungBay.ToString();
            cbbNCU.Text = BLL_NCU.Instance.getNhaCungUng(hh.MaNhaCungUng).TenNhaCungUng.ToString();

        }
        /*public bool Check_Sach()
        {
            if (BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa("TenTheLoaiHangHoa", cbbTheLoaiHangHoa.Text.ToString().Trim()) == null)
            {
                MessageBox.Show("Không tồn tại thể loại hàng hóa này");
                return false;
            }
            if (BLL_KhuTrungBay.Instance.getKhuTrungBay_Ten(cbbKhuTrungBay.Text.ToString().Trim()) == null)
            {
                MessageBox.Show("Không tồn tại khu trung bay này");
                return false;
            }
            if (BLL_NCU.Instance.SearchListNCUByTenNCU(cbbNCU.Text.ToString().Trim()) == null)
            {
                MessageBox.Show("Không tồn tại nhà cung ứng này");
                return false;
            }
            if (txtTenHH.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Tên hàng hóa không hợp lệ");
                return false;
            }
            if (txtNamSX.Text.ToString().Trim() == "" || txtNamSX.Text.ToString().Length < 4)
            {
                MessageBox.Show("Năm sản xuất không hợp lệ");
                return false;
            }
            if (txtSoLuongOKhu.Text.ToString().Trim() == "" || Convert.ToInt16(txtSoLuongOKhu.Text.Trim()) < 0)
            {
                MessageBox.Show("Số lượng trong khu trưng bày không hợp lệ");
                return false;
            }
            if (txtSoLuongOKho.Text.ToString().Trim() == "" || Convert.ToInt16(txtSoLuongOKho.Text.Trim()) < 0)
            {
                MessageBox.Show("Số lượng trong kho không hợp lệ");
                return false;
            }
            if (txtNXS.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nhà sản xuất không hợp lệ");
                return false;
            }
            if (txtGiaBan.Text.ToString().Trim() == "" || Convert.ToDecimal(txtGiaBan.Text.ToString().Trim()) < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }
            if (txtGiaNhap.Text.ToString().Trim() == "" || Convert.ToDecimal(txtGiaNhap.Text.ToString().Trim()) < 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ");
                return false;
            }
            return true;
        }*/
        public bool Check_NhanVien()
        {
            if (BLL_NV.Instance.GetNVByMaNV(MaNhanVien).MaChucVu == "CV002")
                return false;
            txtTenHH.Enabled = false;
            cbbTheLoaiHangHoa.Enabled = false;
            txtNamSX.Enabled = false;
            txtNXS.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuongOKhu.Enabled = false;
            txtSoLuongOKho.Enabled = false;
            cbbKhuTrungBay.Enabled = false;
            cbbNCU.Enabled = false;
            txtGiaNhap.Enabled = false;
            btThemTLHH.Enabled = false;
            btCapNhat.Enabled = false;
            return true;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool Check_HangHoa()
        {
            if (txtTenHH.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Tên hàng hóa không hợp lệ");
                return false;
            }
            int a;
            if (Int32.TryParse(txtNamSX.Text, out a) == false || txtNamSX.Text.ToString().Length != 4)
            {
                MessageBox.Show("Năm sản xuất không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtSoLuongOKhu.Text, out a) == false)
            {
                MessageBox.Show("Số lượng trong khu trưng bày không hợp lệ");
                return false;
            }
            if (Int32.TryParse(txtSoLuongOKho.Text, out a) == false)
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
            if (cbbTheLoaiHangHoa.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Nhập thể loại hàng hóa không hợp lệ");
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
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (Check_HangHoa() == false)
                return;
            DTO.HangHoa hanghoa = new DTO.HangHoa();
            hanghoa.MaHangHoa = MaHangHoa;
            hanghoa.TenHangHoa = txtTenHH.Text.ToString().Trim();
            hanghoa.NamSanXuat = txtNamSX.ToString().Trim();
            hanghoa.NhaSanXuat = txtNXS.Text.ToString().ToString().Trim();
            hanghoa.SoLuongTrenKhuTrungBay = Convert.ToInt16(txtSoLuongOKhu.Text.Trim());
            hanghoa.SoLuongTrongKho = Convert.ToInt16(txtSoLuongOKho.Text.Trim());
            hanghoa.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text.Trim());
            hanghoa.GiaBan = Convert.ToDecimal(txtGiaBan.Text.Trim());
            hanghoa.TrangThai = "Đang chờ xét duyệt cập nhật thông tin";

            DTO.DeXuat DeXuat = new DTO.DeXuat(MaNhanVien, "Đang chờ phê duyệt", "Đề xuất cập nhật thông tin hàng hóa", DateTime.Now);

            hanghoa.MaKho = "K000";
            if (cbbTheLoaiHangHoa.Text.ToString().Trim() == "Sách")
                
                using (TaoSach taoSach = new TaoSach(DeXuat, hanghoa, cbbTheLoaiHangHoa.Text.ToString().Trim(), cbbKhuTrungBay.Text.ToString().Trim(), cbbNCU.Text.ToString().Trim()))
                    taoSach.ShowDialog();
            else
            {
                MessageBox.Show("Bạn sẽ đề xuất cập nhật sách này");
                BLL_HangHoa.Instance.DeXuatThemHangHoa(DeXuat, hanghoa, cbbTheLoaiHangHoa.Text.ToString().Trim(), cbbKhuTrungBay.Text.ToString().Trim(), cbbNCU.Text.ToString().Trim());
                MessageBox.Show("Đề xuất của bạn đã được gửi tới quản lý");
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