using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
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
    public partial class ThemHoaDonNhapKho : Form
    {
        string MaChuVu { get; set; }
        string MaNhanVienKho { get; set; }
        public delegate void MyDel();
        public MyDel d { get; set; }
        List<TTHangHoa> listHH = new List<TTHangHoa>();
        public ThemHoaDonNhapKho(string maChucVu, string maNv)
        {
            InitializeComponent();
            MaChuVu = maChucVu;
            MaNhanVienKho = maNv;
            listHH = new List<TTHangHoa>();
            txtMaNV.Text = BLL_NV.Instance.GetNVByMaNV(MaNhanVienKho).TenNhanVien.ToString();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btThemHH_Click(object sender, EventArgs e)
        {
            TTHangHoa data = new TTHangHoa();
            bool Check = false;
            if (KtraAddListSPDaChon())
            {
                data = BLL_HangHoa.Instance.GetTTHHByMaHH(dgvHHNhapKhoSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString());
                data.SoLuong = Convert.ToInt16(numSoLuongHH.Value);
                data.ThanhTien = Convert.ToDecimal(data.SoLuong * data.GiaNhap);
                Check = true;
            }
            int count = 0;
            foreach (TTHangHoa i in listHH)
            {
                if (i.MaHangHoa == data.MaHangHoa)
                {
                    i.SoLuong += data.SoLuong;
                    i.ThanhTien += data.ThanhTien;
                    count = 1; break;
                }
            }
            if (count == 0 && Check) listHH.Add(data);
            dgvSPDaChon.DataSource = null;
            dgvSPDaChon.DataSource = listHH;
            dgvSPDaChon.Columns["GiaBan"].Visible = false;
            dgvSPDaChon.Columns["Discount"].Visible = false;
            dgvSPDaChon.Columns[0].HeaderText = "Mã hàng hóa";
            dgvSPDaChon.Columns[1].HeaderText = "Tên hàng hóa";
            dgvSPDaChon.Columns[2].HeaderText = "Số lượng nhập";
            dgvSPDaChon.Columns[3].HeaderText = "Số lượng nhập";
            dgvSPDaChon.Columns[4].HeaderText = "Giá nhập";
            dgvSPDaChon.Columns[6].HeaderText = "Thành tiền";
            decimal Tongtien = listHH.Sum(x => x.ThanhTien);
            txtTongTien.Text = String.Format("{0:0,0}", Tongtien) + " VNĐ";
            numSoLuongHH.Value = 0;
        }
        private bool KtraAddListSPDaChon()
        {
            if (dgvHHNhapKhoSearch.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn một đối tượng hàng hóa");
                return false;
            }
            else if (dgvHHNhapKhoSearch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đối tượng hàng hóa");
                return false;
            }
            else if (dgvHHNhapKhoSearch.SelectedRows.Count == 1)
            {
                if ((Convert.ToInt32(numSoLuongHH.Value.ToString()) == 0))
                {
                    MessageBox.Show("Vui lòng nhập số lượng cho hàng hóa");
                    return false;
                }
            }
            return true;
        }
        private void btSearch_Click(object sender, EventArgs e)
        {

            dgvHHNhapKhoSearch.DataSource = BLL_HangHoa.Instance.GetListHHByTenHHvaTrangThai(txtSearch.Text, "Đang kinh doanh");

            dgvHHNhapKhoSearch.Columns["MaKhuTrungBay"].Visible = false;
            dgvHHNhapKhoSearch.Columns["SoLuongTrenKhuTrungBay"].Visible = false;
            dgvHHNhapKhoSearch.Columns["MaKho"].Visible = false;
            dgvHHNhapKhoSearch.Columns["GiaBan"].Visible = false;
            dgvHHNhapKhoSearch.Columns[0].HeaderText = "Mã hàng hóa";
            dgvHHNhapKhoSearch.Columns[1].HeaderText = "Tên hàng hóa";
            dgvHHNhapKhoSearch.Columns[2].HeaderText = "Mã thể loại hàng hóa";
            dgvHHNhapKhoSearch.Columns[3].HeaderText = "Nhà sản xuất";
            dgvHHNhapKhoSearch.Columns[4].HeaderText = "Năm sản xuất";
            dgvHHNhapKhoSearch.Columns[5].HeaderText = "Mã nhà cung ứng";
            dgvHHNhapKhoSearch.Columns[6].HeaderText = "Số lượng trong kho";
            dgvHHNhapKhoSearch.Columns[7].HeaderText = "Giá nhập";
            dgvHHNhapKhoSearch.Columns[8].HeaderText = "Trạng thái";
        }
        private bool KtraSave()
        {
            if (listHH != null && listHH.Count == 0)
            {
                MessageBox.Show("Vui Lòng chọn sản phẩm hàng hóa cần thêm vào hóa đơn");
                return false;
            }
            return true;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo hóa đơn mới không ?", "Xác nhận tạo", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (KtraSave())
                {
                    DeXuat dx = new DeXuat
                    {
                        MaDeXuat = "",
                        MaNhanVien = MaNhanVienKho,
                        TinhTrang = "Đang chờ phê duyệt",
                        LoaiDeXuat = "Đề xuất nhập hàng hóa vào kho",
                        ThoiGian = DateTime.Now,
                    };
                    BLL_DeXuat.Instance.AddDeXuat_BLL(dx);

                    foreach (TTHangHoa i in listHH)
                    {
                        ChiTietDeXuatHD hdnk = new ChiTietDeXuatHD
                        {
                            MaHangHoa = i.MaHangHoa,
                            MaDeXuat = BLL_DeXuat.Instance.GetLasTestDeXuat().MaDeXuat,
                            SoLuong = i.SoLuong,
                        };
                        BLL_HDNK.Instance.AddCTHDNK_BLL(hdnk);

                    }
                    MessageBox.Show("Tạo hóa đơn thành công");
                    this.Dispose();

                }
            }

        }

        private void ThemHoaDonNhapKho_Load(object sender, EventArgs e)
        {

        }
    }
}