﻿using System;
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
    public partial class ChiTietDeXuatHoaDonXuatKho_AD : Form
    {
        string MaDeXuat;
        List<DTO.ChiTietDeXuatHD> listCTDXHoaDon;
        List<DTO.HangHoa> listHangHoa;
        List<DTO.TTHangHoa> listTTHH;
        public ChiTietDeXuatHoaDonXuatKho_AD(string maDX)
        {
            InitializeComponent();
            MaDeXuat = maDX;
            listHangHoa = new List<DTO.HangHoa>();
            listTTHH = new List<TTHangHoa>();
            listCTDXHoaDon = new List<ChiTietDeXuatHD>();
            show();
        }
        public void setGUI(DataGridView dvg)
        {
            dvg.Columns["MaTheLoaiHangHoa"].Visible = false;
            dvg.Columns["NhaSanXuat"].Visible = false;
            dvg.Columns["NamSanXuat"].Visible = false;
            dvg.Columns["MaKhuTrungBay"].Visible = false;
            dvg.Columns["MaKho"].Visible = false;
            dvg.Columns["MaNhaCungUng"].Visible = false;
            dvg.Columns[0].HeaderText = "Mã Hàng Hóa";
            dvg.Columns[1].HeaderText = "Tên Hàng Hóa";
            dvg.Columns[4].HeaderText = "Mã Nhà Cung Ứng";
            dvg.Columns["SoLuongTrenKhuTrungBay"].HeaderText = "Số lượng trên khu trưng bày";
            dvg.Columns[9].HeaderText = "Số Lượng Trong Kho";
            dvg.Columns[10].HeaderText = "Giá Nhập";
            dvg.Columns[11].HeaderText = "Giá Bán";
            dvg.Columns[12].HeaderText = "Trạng Thái";
            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void setGUIdgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD()
        {
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.DataSource = null;
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.DataSource = listTTHH;
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns["Discount"].Visible = false;
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns["GiaNhap"].Visible = false;
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns[0].HeaderText = "Mã hàng hóa";
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns[1].HeaderText = "Tên hàng hóa";
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns[2].HeaderText = "Số lượng";
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns[3].HeaderText = "Giá bán";
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns[4].HeaderText = "Giá nhập";
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.Columns[6].HeaderText = "Thành tiền";
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void show()
        {
            DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);
            tb_MaNhanVien_ChiTietDeXuatHoaDonXuatKho_AD.Text = DeXuat.MaNhanVien;
            tb_TenNhanVien_ChiTietDeXuatHoaDonXuatKho_AD.Text = BLL_NV.Instance.GetNVByMaNV(DeXuat.MaNhanVien).TenNhanVien;
            txtThoiGian.Text = DeXuat.ThoiGian.ToString();
            txt_LoaiDeXuat_ChiTietDeXuatHoaDonXuatKho_AD.Text = DeXuat.LoaiDeXuat;
            txtTrangThai.Text = DeXuat.TinhTrang;

            listCTDXHoaDon = BLL_DeXuat.Instance.getlistChiTietDeXuatHDByMaDX(MaDeXuat);
            foreach (DTO.ChiTietDeXuatHD item in listCTDXHoaDon)
            {
                DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(item.MaHangHoa);
                listHangHoa.Add(HangHoa);
                DTO.TTHangHoa TTHH = new DTO.TTHangHoa
                {
                    MaHangHoa = HangHoa.MaHangHoa,
                    TenHangHoa = HangHoa.TenHangHoa,
                    GiaBan = HangHoa.GiaBan,
                    SoLuong = item.SoLuong,
                    ThanhTien = item.SoLuong * HangHoa.GiaBan
                };
                listTTHH.Add(TTHH);
            }
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.DataSource = null;
            dgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD.DataSource = listTTHH;
            setGUIdgv_SanPhamDaChon_ChiTietDeXuatHoaDonXuatKho_AD();

            if (DeXuat.TinhTrang != "Đang chờ phê duyệt")
            {
                DTO.PhanHoi PhanHoi = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(DeXuat.MaDeXuat);
                bt_XetDuyet_ChiTietDeXuatHoaDonXuatKho_AD.Enabled = false;
                bt_TuChoiDeXuat_ChiTietDeXuatHoaDonXuatKho_AD.Enabled = false;
                txtPhanHoi.Enabled = false;
                if (PhanHoi != null)
                    txtPhanHoi.Text = PhanHoi.NoiDung.ToString();
            }
        }
        private void ChiTietDeXuatHoaDonXuatKho_AD_Load(object sender, EventArgs e)
        {
        }
        private void bt_QuayLai_ChiTietDeXuatHoaDonXuatKho_AD_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void bt_TuChoiDeXuat_ChiTietDeXuatHoaDonXuatKho_AD_Click(object sender, EventArgs e)
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

                    DeXuat.TinhTrang = "Không chấp nhận";
                    BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL(DeXuat.TinhTrang, DeXuat.MaDeXuat);
                    DTO.PhanHoi PhanHoi = new PhanHoi(DeXuat.MaNhanVien, DeXuat.MaDeXuat, DateTime.Now, txtPhanHoi.Text.ToString().Trim());
                    BLL_DeXuat.Instance.AddPhanHoi(PhanHoi);
                    MessageBox.Show("Đề xuất đã bị từ chối");
                    this.Close();
                }
            }
        }
        private void bt_XetDuyet_ChiTietDeXuatHoaDonXuatKho_AD_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận chấp nhận đề xuất không ?", "Xác nhận ", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);

                for (int i = 0; i < listCTDXHoaDon.Count; i++)
                {
                    listHangHoa[i].SoLuongTrenKhuTrungBay += listCTDXHoaDon[i].SoLuong;
                    listHangHoa[i].SoLuongTrongKho -= listCTDXHoaDon[i].SoLuong;
                    BLL_HangHoa.Instance.CapNhatHangHoa(listHangHoa[i]);
                }
                DeXuat.TinhTrang = "Chấp nhận";
                BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL(DeXuat.TinhTrang, DeXuat.MaDeXuat);
                if (txtPhanHoi.Text.ToString().Trim() != "")
                {
                    DTO.PhanHoi PhanHoi = new PhanHoi(DeXuat.MaNhanVien, DeXuat.MaDeXuat, DateTime.Now, txtPhanHoi.Text.ToString().Trim());
                    BLL_DeXuat.Instance.AddPhanHoi(PhanHoi);
                }
                MessageBox.Show("Đề xuất đã được chấp nhận");
                this.Close();
            }
        }
    }
}
