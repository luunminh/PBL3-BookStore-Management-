using PBL3_Book_Store_Manager.BLL;
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
    public partial class ChiTietDeXuatNCU_NV : Form
    {
        string MaDeXuat { get; set; }
        public ChiTietDeXuatNCU_NV(string maDX)
        {
            InitializeComponent();
            MaDeXuat = maDX;
            CheckLoaiDeXuat();
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
                //txtPhanHoi.Enabled = true;
                return false;
            }
        }

        public bool CheckLoaiDeXuat()
        {
            if (BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).LoaiDeXuat.Trim() == "Đề xuất thêm nhà cung ứng")   //them
            {
                setGUIThem();
                return true;

            }
            else     //cap nhat
            {
                setGUISua();
                return false;
            }

        }

        public void setGUIThem()
        {
            txtMaNhanVien.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).MaNhanVien;
            txtTenNV.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).MaNhanVien;
            txtThoiGian.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).ThoiGian.ToString();
            txtLoaiDeXuat.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).LoaiDeXuat.ToString();
            if (CheckPH())
            {
                txtPhanHoi.Text = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(MaDeXuat).NoiDung;
            }
            txtTrangThai.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).TinhTrang;
            txtTenNCU.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).TenNhaCungUng;
            txtSDT.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).SoDienThoai;
            txtDiaChi.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).DiaChi;
            txtDaiDienKD.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).TenNguoiDaiDienKinhDoanh;
            txtDaiDienPhapLy.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).TenNguoiDaiDienPhapLy;
        }

        public void setGUISua()
        {
            txtMaNhanVien.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).MaNhanVien;
            txtTenNV.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).MaNhanVien;
            txtThoiGian.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).ThoiGian.ToString();
            txtLoaiDeXuat.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).LoaiDeXuat.ToString();
            if (CheckPH())
            {
                txtPhanHoi.Text = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(MaDeXuat).NoiDung;
            }
            txtTrangThai.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).TinhTrang;
            txtTenNCU.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).TenNhaCungUng;
            txtSDT.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).SoDienThoai;
            txtDiaChi.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).DiaChi;
            txtDaiDienKD.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).TenNguoiDaiDienKinhDoanh;
            txtDaiDienPhapLy.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).TenNguoiDaiDienPhapLy;
        }


        private void bt_QuayLai_ChiTietDeXuatHoaDonNhapKho_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
