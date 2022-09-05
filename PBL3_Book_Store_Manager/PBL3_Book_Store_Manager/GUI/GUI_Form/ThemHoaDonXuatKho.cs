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
    public partial class ThemHoaDonXuatKho : Form
    {
        string MaNV;
        decimal totalHD = 0;
        public delegate void MyDel();
        public MyDel d { get; set; }
        List<DTO.HangHoa> listHangHoa;
        List<DTO.TTHangHoa> listTTHH;
        List<short> listSoLuong;
        public ThemHoaDonXuatKho(string maNhanVien)
        {
            InitializeComponent();
            MaNV = maNhanVien;
            cbbHH.SelectedIndex = 0;
            listHangHoa = new List<DTO.HangHoa>();
            listSoLuong = new List<short>();
            listTTHH = new List<TTHangHoa>();
            txtMaNV.Text = BLL_NV.Instance.GetNVByMaNV(MaNV).TenNhanVien.ToString();

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
        public void setGUISPDaChon()
        {
            dgvSPDaChon.DataSource = null;
            dgvSPDaChon.DataSource = listTTHH;
            dgvSPDaChon.Columns["Discount"].Visible = false;
            dgvSPDaChon.Columns["GiaNhap"].Visible = false;
            dgvSPDaChon.Columns[0].HeaderText = "Mã hàng hóa";
            dgvSPDaChon.Columns[1].HeaderText = "Tên hàng hóa";
            dgvSPDaChon.Columns[2].HeaderText = "Số lượng";
            dgvSPDaChon.Columns[3].HeaderText = "Giá bán";
            dgvSPDaChon.Columns[4].HeaderText = "Giá nhập";
            dgvSPDaChon.Columns[6].HeaderText = "Thành tiền";
            dgvSPDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btThemHH_Click(object sender, EventArgs e)
        {
            bool i = false;
            if (dgvHHSearch.SelectedRows.Count == 0 || dgvHHSearch.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn 1 đối tượng hàng hóa");
                return;
            }
            DTO.HangHoa HangHoa = DAL_HH.Instance.TimKiemHangHoa("MaHangHoa", dgvHHSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString())[0];
            DTO.TTHangHoa TTHH = new DTO.TTHangHoa
            {
                MaHangHoa = dgvHHSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(),
                TenHangHoa = dgvHHSearch.SelectedRows[0].Cells["TenHangHoa"].Value.ToString(),
                GiaBan = HangHoa.GiaBan,
            };
            if (Convert.ToInt16(numSoLuongHH.Value.ToString().Trim()) <= 0)
            {
                MessageBox.Show("Số lượng nhập kho của hàng hóa này không phù hợp");
                return;
            }    
            if (HangHoa.SoLuongTrongKho > numSoLuongHH.Value)
            {
                for (int j = 0; j < listHangHoa.Count; j++)
                    if (HangHoa.MaHangHoa == listHangHoa[j].MaHangHoa)
                    {
                        i = true;
                        if (HangHoa.SoLuongTrongKho < (listSoLuong[j] + numSoLuongHH.Value))
                        {
                            MessageBox.Show("Số lượng không trong kho không đủ");
                            break;
                        }
                        if (BLL_KhuTrungBay.Instance.TrangThaiHienTai(HangHoa.MaKhuTrungBay, Convert.ToInt16(listSoLuong[j] + Convert.ToInt16(numSoLuongHH.Value.ToString().Trim()))) == true)
                        {
                            MessageBox.Show("Khu trưng bày của hàng hóa này đã đầy");
                            return;
                        }
                        else
                        {
                            listSoLuong[j] += Convert.ToInt16(numSoLuongHH.Value.ToString().Trim());
                            listTTHH[j].SoLuong = listSoLuong[j];
                            break;
                        }
                    }
                if (!i)
                {
                    listHangHoa.Add(HangHoa);
                    if (BLL_KhuTrungBay.Instance.TrangThaiHienTai(HangHoa.MaKhuTrungBay, Convert.ToInt16(numSoLuongHH.Value)) == false)
                        listSoLuong.Add(Convert.ToInt16(numSoLuongHH.Value.ToString().Trim()));
                    TTHH.SoLuong = Convert.ToInt16(numSoLuongHH.Value.ToString().Trim());
                    listTTHH.Add(TTHH);
                }
                TTHH.ThanhTien = TTHH.SoLuong * TTHH.GiaBan;
                totalHD += HangHoa.GiaNhap * numSoLuongHH.Value;
                numSoLuongHH.Value = 0;
            }
            else
                MessageBox.Show("Số lượng trong kho không đáp ứng đủ");

            dgvSPDaChon.DataSource = null;
            dgvSPDaChon.DataSource = listTTHH;
            setGUISPDaChon();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            BLL_HangHoa.Instance.TimKiemHangHoa(cbbHH.Text.ToString().Trim(), txtSearch.Text.ToString().Trim(), dgvHHSearch);
            setGUI(dgvHHSearch);
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if (listHangHoa.Count == 0)
            {
                MessageBox.Show("Không có hàng hóa nào trong danh sách sản phẩm đã chọn");
                return;
            }
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo hóa đơn xuất kho mới không ?", "Xác nhận tạo", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                DTO.DeXuat DeXuat = new DTO.DeXuat("", MaNV, "Đang chờ phê duyệt", "Đề xuất xuất hàng hóa lên kệ", DateTime.Now);
                BLL_DeXuat.Instance.AddDeXuat_BLL(DeXuat);
                for (int i = 0; i < listHangHoa.Count; i++)
                {
                    DTO.ChiTietDeXuatHD CTDXHoaDon = new DTO.ChiTietDeXuatHD(BLL_DeXuat.Instance.GetLasTestDeXuat().MaDeXuat, listHangHoa[i].MaHangHoa, listSoLuong[i]);
                    BLL_DeXuat.Instance.AddChiTietDeXuatHD_BLL(CTDXHoaDon);
                }
                this.Close();
            }
        }
        private void btHuy_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}