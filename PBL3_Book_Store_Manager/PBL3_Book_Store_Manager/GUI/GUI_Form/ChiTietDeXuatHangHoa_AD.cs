using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    public partial class ChiTietDeXuatHH_Ad : Form
    {
        string MaDeXuat { get; set; }

        public ChiTietDeXuatHH_Ad(string maDX)
        {
            InitializeComponent();
            MaDeXuat = maDX;
            setGUI();
        }
        public void setGUI()
        {
            DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);
            DTO.ChiTietDeXuatHH CTDXHangHoa = BLL_DeXuat.Instance.GetAllListCTDeXuatHH_byMaDeXuat(DeXuat.MaDeXuat);
            DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(CTDXHangHoa.MaHangHoa);
            DTO.NhanVien NhanVien = BLL_NV.Instance.GetNVByMaNV(DeXuat.MaNhanVien);
            DTO.KhuTrungBay KhuTrungBay = BLL_KhuTrungBay.Instance.getKhuTrungBay(HangHoa.MaKhuTrungBay);

            txtMaNhanVien.Text = DeXuat.MaNhanVien.ToString();
            txtTenNV.Text = NhanVien.TenNhanVien.ToString();
            txtThoiGian.Text = DeXuat.ThoiGian.ToString();
            txtLoaiDX.Text = DeXuat.LoaiDeXuat;

            txtTenHH.Text = HangHoa.TenHangHoa.ToString();
            txtSoLuongKhu.Text = HangHoa.SoLuongTrenKhuTrungBay.ToString();
            txtNamSX.Text = HangHoa.NamSanXuat.ToString();
            txtSoLuongKho.Text = HangHoa.SoLuongTrongKho.ToString();
            txtNhaSX.Text = HangHoa.NhaSanXuat.ToString();
            txtKhu.Text = KhuTrungBay.TenKhuTrungBay.ToString();
            txtGiaBan.Text = HangHoa.GiaBan.ToString();
            txtGiaNhap.Text = HangHoa.GiaNhap.ToString();
            txtTrangThai.Text = DeXuat.TinhTrang.ToString();

            txtTheLoaiHH.Text = BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa(HangHoa.MaTheLoaiHangHoa).TenTheLoaiHangHoa.ToString();

            if (txtTheLoaiHH.Text.ToString() == "Sách")
            {
                DTO.Sach Sach = BLL_Sach.Instance.getSach(HangHoa.MaHangHoa);
                txtTacGia.Text = Sach.TacGia.ToString();
                txtLanTaiBan.Text = Sach.LanTaiBan.ToString();
                txtTheLoaiSach.Text = BLL_TheLoaiSach.Instance.getTheLoaiSach(Sach.MaTheLoaiSach).TenTheLoaiSach.ToString();
            }
            if (DeXuat.TinhTrang != "Đang chờ phê duyệt")
            {
                DTO.PhanHoi PhanHoi = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(DeXuat.MaDeXuat);
                btXetDuyet.Enabled = false;
                btTuChoi.Enabled = false;
                txtPhanHoi.Enabled = false;
                if (PhanHoi != null)
                    txtPhanHoi.Text = PhanHoi.NoiDung.ToString();
            }
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btTuChoi_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận từ chối đề xuất không ?", "Xác nhận ", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (txtPhanHoi.Text.Replace(" ", "").Trim() == "")
                {
                    MessageBox.Show("Vui lòng phản hồi lại cho đề xuất này");
                }
                else
                {
                    DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);
                    DTO.ChiTietDeXuatHH CTDXHangHoa = BLL_DeXuat.Instance.GetAllListCTDeXuatHH_byMaDeXuat(DeXuat.MaDeXuat);
                    DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(CTDXHangHoa.MaHangHoa);

                    if (DeXuat.LoaiDeXuat == "Đề xuất thêm hàng hóa" || DeXuat.LoaiDeXuat == "Đề xuất cập nhật thông tin hàng hóa")
                    {
                        HangHoa.TrangThai = "Lịch sử cập nhật";
                        BLL_HangHoa.Instance.CapNhatHangHoa(HangHoa);
                    }
                    DeXuat.TinhTrang = "Không chấp nhận";
                    BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL(DeXuat.TinhTrang, DeXuat.MaDeXuat);
                    DTO.PhanHoi PhanHoi = new PhanHoi(DeXuat.MaNhanVien, DeXuat.MaDeXuat, DateTime.Now, txtPhanHoi.Text.ToString().Trim());
                    BLL_DeXuat.Instance.AddPhanHoi(PhanHoi);
                    MessageBox.Show("Đề xuất đã bị từ chối");
                    this.Close();
                }
            }
        }

        private void btXetDuyet_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận xét duyệt đề xuất không ?", "Xác nhận ", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);
                DTO.ChiTietDeXuatHH CTDXHangHoa = BLL_DeXuat.Instance.GetAllListCTDeXuatHH_byMaDeXuat(DeXuat.MaDeXuat);
                DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(CTDXHangHoa.MaHangHoa);

                if (DeXuat.LoaiDeXuat == "Đề xuất thêm hàng hóa")
                {
                    HangHoa.TrangThai = "Đang kinh doanh";
                    BLL_HangHoa.Instance.CapNhatHangHoa(HangHoa);
                }

                if (DeXuat.LoaiDeXuat == "Đề xuất cập nhật thông tin hàng hóa")
                {
                    //lấy thằng đang bán ra x, lấy cái thằng đang đề xuất ra,
                    //Tráo đổi 2 nội dung 2 thằng đó nhưng giữ cố định cái mã (là không đổi cái mã)(thông qua biến phụ)
                    //chỉnh lại 2 cái trạng thái (đang kinh doanh, lịch sử cập nhật) (vì đổi cái nội dung nên 2 cái trạng thái cũng đổi theo)
                    //Sau cập nhật 2 cái hàng hóa đó, vs cập nhật lại cái trạng thái của đề xuất

                    //cái lịch sử cập nhật sẽ lưu thông tin của hàng hóa trước khi thay đổi để làm lịch sử.
                    DTO.HangHoa temp = new DTO.HangHoa(HangHoa);
                    temp.MaHangHoa = CTDXHangHoa.MaThamChieu;
                    DTO.HangHoa HHCapNhat = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(CTDXHangHoa.MaThamChieu);
                    HangHoa = HHCapNhat;
                    HangHoa.MaHangHoa = CTDXHangHoa.MaHangHoa;
                    HHCapNhat = temp;

                    HangHoa.TrangThai = "Lịch sử cập nhật";
                    HHCapNhat.TrangThai = "Đang kinh doanh";
                    //Hoan thanh tráo đổi và cập nhật trạng thái

                    BLL_HangHoa.Instance.CapNhatHangHoa(HHCapNhat);
                    BLL_HangHoa.Instance.CapNhatHangHoa(HangHoa);
                }
                if (DeXuat.LoaiDeXuat == "Đề xuất tạm ngừng kinh doanh hàng hóa")
                {
                    BLL_HangHoa.Instance.NgungKinhDoanh(HangHoa);
                }
                DeXuat.TinhTrang = "Chấp nhận";
                BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL(DeXuat.TinhTrang, DeXuat.MaDeXuat);

                if (txtPhanHoi.Text.ToString().Trim() != "")
                {
                    DTO.PhanHoi PhanHoi = new PhanHoi(DeXuat.MaNhanVien, DeXuat.MaDeXuat, DateTime.Now, txtPhanHoi.Text.ToString().Trim());
                    BLL_DeXuat.Instance.AddPhanHoi(PhanHoi);
                }
                MessageBox.Show("Đề xuất đã được chấp nhận");
            }
            this.Close();
        }
    }
}