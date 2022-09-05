using PBL3_Book_Store_Manager.GUI.GUI_Form;
using PBL3_Book_Store_Manager.GUI_Form;
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

namespace PBL3_Book_Store_Manager.GUI_KHO.UC_Control
{
    public partial class UC_TabKhoHH : UserControl
    {
        public void setGUI(DataGridView dgv)
        {
            dgv.Columns["MaTheLoaiHangHoa"].Visible = false;
            dgv.Columns["NhaSanXuat"].Visible = false;
            dgv.Columns["NamSanXuat"].Visible = false;
            dgv.Columns["MaKhuTrungBay"].Visible = false;
            dgv.Columns["MaKho"].Visible = false;
            dgv.Columns["MaNhaCungUng"].Visible = false;
            dgv.Columns[0].HeaderText = "Mã Hàng Hóa";
            dgv.Columns[1].HeaderText = "Tên Hàng Hóa";
            dgv.Columns[7].HeaderText = "Số Lượng Trên Khu Trưng Bày";
            dgv.Columns[9].HeaderText = "Số Lượng Trong Kho";
            dgv.Columns[10].HeaderText = "Giá Nhập";
            dgv.Columns[11].HeaderText = "Giá Bán";
            dgv.Columns[12].HeaderText = "Trạng Thái";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        string MaNhanVien;
        public UC_TabKhoHH(string MaNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = MaNhanVien;
            cbbKe.DisplayMember = "TenKhuTrungBay";
            cbbKe.DataSource = BLL_KhuTrungBay.Instance.getListKhuTrungBay();
            dgvHHTrongKho.DataSource = BLL_HangHoa.Instance.getListAllHangHoa();
            setGUI(dgvHHTrongKho);
            {
                dataGridView1.DataSource = BLL_HangHoa.Instance.getListAllHangHoa();
                setGUI(dataGridView1);
            }
            TinhSoLuongHienTai("");
        }
        public void TinhSoLuongHienTai(string TenKhuTrungBay)
        {
            long SoLuong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SoLuong += Convert.ToInt64(dataGridView1.Rows[i].Cells["SoLuongTrenKhuTrungBay"].Value.ToString());
            }
            if (TenKhuTrungBay != "")
            {
                DTO.KhuTrungBay KhuTrungBay = BLL_KhuTrungBay.Instance.getKhuTrungBay_Ten(TenKhuTrungBay);
                btSoLuong.Text = SoLuong.ToString() + "/" + KhuTrungBay.SoLuongToiDa;
            }
            else
            {
                long Tong = 0;
                List<DTO.KhuTrungBay> listKhuTrungBay = BLL_KhuTrungBay.Instance.getListKhuTrungBay();
                foreach (DTO.KhuTrungBay item in listKhuTrungBay)
                {
                    Tong += Convert.ToInt64(item.SoLuongToiDa.ToString());
                }
                btSoLuong.Text = SoLuong.ToString() + "/" + Tong;
            }
        }
        private void btTaoHdXuatKho_Click(object sender, EventArgs e)
        {
            ThemHoaDonXuatKho hdxk = new ThemHoaDonXuatKho(MaNhanVien);
            hdxk.Show();
        }

        private void btThemKe_Click(object sender, EventArgs e)
        {
            TaoKe taoKe = new TaoKe();
            taoKe.ShowDialog();
            cbbKe.DisplayMember = "TenKhuTrungBay";
            cbbKe.DataSource = BLL_KhuTrungBay.Instance.getListKhuTrungBay();
        }

        private void btTaoSach_Click(object sender, EventArgs e)
        {
            TaoHangHoa taoSach = new TaoHangHoa(MaNhanVien);
            taoSach.Show();
        }

        private void btTaoHH_Click(object sender, EventArgs e)
        {
            TaoHangHoa taoHH = new TaoHangHoa(MaNhanVien);
            taoHH.ShowDialog();
            dgvHHTrongKho.DataSource = BLL_HangHoa.Instance.getListAllHangHoa();
            setGUI(dgvHHTrongKho);
        }

        private void btTaoHDNhap_Click(object sender, EventArgs e)
        {
            ThemHoaDonNhapKho taoHD = new ThemHoaDonNhapKho("CV002", MaNhanVien);
            taoHD.ShowDialog();

        }

        private void btSearchTrongKho_Click(object sender, EventArgs e)
        {
            if (txtSearchTrongKho.Text != "")
            {
                BLL_HangHoa.Instance.TimKiemHangHoa(cbbSortTrongKho.Text.ToString(), txtSearchTrongKho.Text.ToString(), dgvHHTrongKho);
                setGUI(dgvHHTrongKho);
            }
            else
                dgvHHTrongKho.DataSource = BLL_HangHoa.Instance.getListAllHangHoa();
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHHTrongKho.SelectedRows.Count == 0)
                MessageBox.Show("Vui lòng chọn đối tượng hàng hóa");
            else
                if (dgvHHTrongKho.SelectedRows.Count == 1)
            {
                if (BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa(dgvHHTrongKho.SelectedRows[0].Cells["MaTheLoaiHangHoa"].Value.ToString()).TenTheLoaiHangHoa.Trim() == "Sách")
                {
                    using (ChiTietSach cts = new ChiTietSach(dgvHHTrongKho.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), MaNhanVien))
                        cts.ShowDialog();
                }
                else
                    using (ChiTietHangHoa cthh = new ChiTietHangHoa(dgvHHTrongKho.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), MaNhanVien))
                        cthh.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hàng hóa");
            BLL_HangHoa.Instance.getListHangHoa();
            setGUI(dgvHHTrongKho);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvHHTrongKho.SelectedRows.Count == 1)
            {
                DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHangHoa_ByMaHangHoa(dgvHHTrongKho.SelectedRows[0].Cells["MaHangHoa"].Value.ToString());

                DTO.DeXuat DeXuat = new DTO.DeXuat("", MaNhanVien, "Đang chờ phê duyệt", "Đề xuất tạm ngừng kinh doanh hàng hóa", DateTime.Now);
                DialogResult results = MessageBox.Show("Bạn có muốn tạm ngưng kinh doanh hàng hóa này không ?", "Xác nhận tạm ngưng", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    BLL_DeXuat.Instance.AddDeXuat_BLL(DeXuat);
                    DTO.ChiTietDeXuatHH CTDXHangHoa = new DTO.ChiTietDeXuatHH(BLL_DeXuat.Instance.GetLasTestDeXuat().MaDeXuat, HangHoa.MaHangHoa, "");
                    BLL_DeXuat.Instance.AddChiTietDeXuatHH_BLL(CTDXHangHoa);
                    MessageBox.Show("Đề xuất của bạn đã được gửi tới quản lý");
                }
            }
        }

        private void btChiTietHHKe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Vui lòng chọn đối tượng hàng hóa");
            else
                 if (dataGridView1.SelectedRows.Count == 1)
            {
                if (BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa(dataGridView1.SelectedRows[0].Cells["MaTheLoaiHangHoa"].Value.ToString()).TenTheLoaiHangHoa.Trim() == "Sách")
                {
                    using (ChiTietSach cts = new ChiTietSach(dataGridView1.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), MaNhanVien))
                        cts.ShowDialog();
                }
                else
                    using (ChiTietHangHoa cthh = new ChiTietHangHoa(dataGridView1.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), MaNhanVien))
                        cthh.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hàng hóa");
            BLL_HangHoa.Instance.getListHangHoa();
            setGUI(dataGridView1);
        }

        private void btChiTietKe_Click(object sender, EventArgs e)
        {
            ChiTietKe CTke = new ChiTietKe(BLL_KhuTrungBay.Instance.getKhuTrungBay_Ten(cbbKe.Text).MaKhuTrungBay.ToString());
            CTke.ShowDialog();
            cbbKe.DisplayMember = "TenKhuTrungBay";
            cbbKe.DataSource = BLL_KhuTrungBay.Instance.getListKhuTrungBay();
        }

        private void btSearchTrenKe_Click(object sender, EventArgs e)
        {
            BLL_HangHoa.Instance.TimKiemHangHoa("TenKhuTrungBay", cbbKe.Text.ToString(), cbbSortTrenKe.Text.ToString(), txtSearchTrenKe.Text.ToString(), dataGridView1);
            setGUI(dataGridView1);
            TinhSoLuongHienTai(cbbKe.Text.ToString());
        }

        private void UC_TabKhoHH_Load(object sender, EventArgs e)
        {
        }
    }
}