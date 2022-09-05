using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
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
    public partial class ChiTietDeXuatHoaDonNhapKho_NV : Form
    {
        string MaDeXuat { get; set; }
        List<DTO.ChiTietDeXuatHD> listCTDXHoaDon;
        List<DTO.HangHoa> listHangHoa;

        public ChiTietDeXuatHoaDonNhapKho_NV(string maDX)
        {
            InitializeComponent();
            MaDeXuat = maDX;
            show();
        }
        public void setGUI(DataGridView dvg)
        {
            dvg.Columns["MaTheLoaiHangHoa"].Visible = false;
            dvg.Columns["NhaSanXuat"].Visible = false;
            dvg.Columns["NamSanXuat"].Visible = false;
            dvg.Columns["MaKhuTrungBay"].Visible = false;
            dvg.Columns["SoLuongTrenKhuTrungBay"].Visible = false;
            dvg.Columns["MaKho"].Visible = false;
            dvg.Columns["MaNhaCungUng"].Visible = false;
            dvg.Columns[0].HeaderText = "Mã Hàng Hóa";
            dvg.Columns[1].HeaderText = "Tên Hàng Hóa";
            dvg.Columns[4].HeaderText = "Mã Nhà Cung Ứng";
            dvg.Columns[9].HeaderText = "Số Lượng Trong Kho";
            dvg.Columns[10].HeaderText = "Giá Nhập";
            dvg.Columns[11].HeaderText = "Giá Bán";
            dvg.Columns[12].HeaderText = "Trạng Thái";
        }
        public void show()
        {
            DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);
            tb_MaNhanVien_ChiTietDeXuatHoaDonNhapKho_AD.Text = DeXuat.MaNhanVien;
            tb_TenNhanVien_ChiTietDeXuatHoaDonNhapKho_AD.Text = BLL_NV.Instance.GetNVByMaNV(DeXuat.MaNhanVien).TenNhanVien;
            dtp_ThoiGian_ChiTietDeXuatHoaDonNhapKho_AD.Value = DeXuat.ThoiGian;
            textBox1.Text = DeXuat.LoaiDeXuat;
            cb_TrangThai_ChiTietDeXuatHoaDonNhapKho_AD.Text = DeXuat.TinhTrang;

            listCTDXHoaDon = BLL_DeXuat.Instance.getlistChiTietDeXuatHDByMaDX(MaDeXuat);
            listHangHoa = new List<DTO.HangHoa>();

            long TongTien = 0;
            foreach (DTO.ChiTietDeXuatHD item in listCTDXHoaDon)
            {
                DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHHByMaHH(item.MaHangHoa);
                listHangHoa.Add(HangHoa);
                TongTien += (Convert.ToInt64(HangHoa.GiaNhap) * item.SoLuong);
            }
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonNhapKho_AD.DataSource = null;
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonNhapKho_AD.DataSource = listHangHoa;
            setGUI(dgv_SanPhamDaChon_ChiTietDeXuatHoaDonNhapKho_AD);
            tb_TongTien_ChiTietDeXuatHoaDonNhapKho_AD.Text = String.Format("{0:0,0}", TongTien) + " VNĐ";
            DTO.PhanHoi PhanHoi = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(DeXuat.MaDeXuat);
            if (PhanHoi != null)
                tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Text = PhanHoi.NoiDung.ToString();
        }
        private void bt_QuayLai_ChiTietDeXuatHoaDonNhapKho_AD_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}