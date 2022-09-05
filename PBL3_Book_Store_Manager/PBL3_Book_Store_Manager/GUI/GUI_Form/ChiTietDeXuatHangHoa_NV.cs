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
    public partial class ChiTietDeXuatHangHoa_NV : Form
    {
        string MaDeXuat { get; set; }
       
        public ChiTietDeXuatHangHoa_NV(string maDX)
        {
            InitializeComponent();
            MaDeXuat = maDX;
            setGUI();
        }
        public bool CheckPH()
        {
            if (BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(MaDeXuat) != null)  //co
            {
                txtPhanHoi.Enabled = false;
                return true;
            }
            else                          //chua co phan hoi
            {
                txtPhanHoi.Enabled = true;
                return false;
            }
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
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
