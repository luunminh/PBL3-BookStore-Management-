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
using PBL3_Book_Store_Manager.DAL;

namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    public partial class ChiTietDeXuatHoaDonNhapKho_AD : Form
    {
        string MaDeXuat;
        List<DTO.ChiTietDeXuatHD> listCTDXHoaDon;
        List<DTO.HangHoa> listHangHoa;

        public ChiTietDeXuatHoaDonNhapKho_AD(string maDeXuat)
        {
            InitializeComponent();
            MaDeXuat = maDeXuat;
            listCTDXHoaDon = new List<DTO.ChiTietDeXuatHD>();
            listHangHoa = new List<DTO.HangHoa>();
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
            tb_TongTien_ChiTietDeXuatHoaDonNhapKho_AD.Text =  String.Format("{0:0,0}", TongTien) + " VNĐ";
            if (DeXuat.TinhTrang != "Đang chờ phê duyệt")
            {
                DTO.PhanHoi PhanHoi = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(DeXuat.MaDeXuat);
                bt_XetDuyet_ChiTietDeXuatHoaDonNhapKho_AD.Enabled = false;
                bt_TuChoiDeXuat_ChiTietDeXuatHoaDonNhapKho_AD.Enabled = false;
                tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Enabled = false;
                if (PhanHoi != null)
                    tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Text = PhanHoi.NoiDung.ToString();
            }
        }
        private void bt_QuayLai_ChiTietDeXuatHoaDonNhapKho_AD_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool CheckPH()
        {
            if (BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(MaDeXuat) != null)
            {
                tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Enabled = false;
                return true;
            }
            else
            {
                tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Enabled = true;
                return false;
            }
        }
        private void bt_TuChoiDeXuat_ChiTietDeXuatHoaDonNhapKho_AD_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận từ chối đề xuất không ?", "Xác nhận ", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (!CheckPH())
                {
                    if (tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Text.Replace(" ", "").Trim() == "")
                    {
                        MessageBox.Show("Vui lòng phản hồi lại cho đề xuất này");
                    }
                    else
                    {
                        DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);

                        DeXuat.TinhTrang = "Không chấp nhận";
                        BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL(DeXuat.TinhTrang, DeXuat.MaDeXuat);
                        DTO.PhanHoi PhanHoi = new PhanHoi(DeXuat.MaNhanVien, DeXuat.MaDeXuat, DateTime.Now, tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Text.ToString().Trim());
                        BLL_DeXuat.Instance.AddPhanHoi(PhanHoi);
                        MessageBox.Show("Đề xuất đã bị từ chối");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã cập nhật tình trạng cho đề xuất này");
                    this.Close();
                }
            }
        }
        private void bt_XetDuyet_ChiTietDeXuatHoaDonNhapKho_AD_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận chấp nhận đề xuất không ?", "Xác nhận ", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                DTO.DeXuat DeXuat = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat);

                for (int i = 0; i < listCTDXHoaDon.Count; i++)
                {
                    listHangHoa[i].SoLuongTrongKho += listCTDXHoaDon[i].SoLuong;
                    BLL_HangHoa.Instance.CapNhatHangHoa(listHangHoa[i]);
                }
                DeXuat.TinhTrang = "Chấp nhận";
                BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL(DeXuat.TinhTrang, DeXuat.MaDeXuat);
                if (tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Text.ToString().Trim() != "")
                {
                    DTO.PhanHoi PhanHoi = new PhanHoi(DeXuat.MaNhanVien, DeXuat.MaDeXuat, DateTime.Now, tb_PhanHoi_ChiTietDeXuatHoaDonNhapKho_AD.Text.ToString().Trim());
                    BLL_DeXuat.Instance.AddPhanHoi(PhanHoi);
                }
                MessageBox.Show("Đề xuất đã được chấp nhận");
                this.Close();
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}