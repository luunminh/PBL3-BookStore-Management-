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

namespace PBL3_Book_Store_Manager.GUI_Form
{
    public partial class ChiTietHoaDonNhapKho : Form
    {
        public string MaHD { get; set; }
        public ChiTietHoaDonNhapKho(string maHD)
        {
            InitializeComponent();
            MaHD = maHD;
            SetGUI(MaHD);
            TinhTongTien();
        }

        List<HangHoa> l = new List<HangHoa> ();
        public void SetGUI(string maHD)
        {
            HoaDon s = new HoaDon();
            s = BLL_HDBH.Instance.GetHoaDon_ByMaHD (maHD);
            txtTenNV.Text = BLL_NV.Instance.GetNVByMaNV(s.MaNhanVien).TenNhanVien;
            dtpTGTao.Value = s.ThoiGian;
            dgvSPDaChon.DataSource = BLL_HangHoa.Instance.GetListTTHHByMaHD (maHD);
            dgvSPDaChon.Columns[0].HeaderText = "Mã hàng hóa";
            dgvSPDaChon.Columns[1].HeaderText = "Tên hàng hóa";
            dgvSPDaChon.Columns[2].HeaderText = "Số lượng";
            dgvSPDaChon.Columns[3].HeaderText = "Giá bán";
            dgvSPDaChon.Columns[4].HeaderText = "Giá nhập";
           // dgvSPDaChon.Columns["Giá nhập"].Visible = false;
            dgvSPDaChon.Columns[5].HeaderText = "Mức giảm giá";
            dgvSPDaChon.Columns[6].HeaderText = "Thành tiền";
            dgvSPDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void TinhTongTien()
        {
            //double sum = 0;
            List<TTHangHoa> data = BLL_HangHoa.Instance.GetListTTHHByMaHD(MaHD);
            txtTongTien.Text = String.Format("{0:0,0}", BLL_HDBH.Instance.GetHoaDon_ByMaHD(MaHD).TongTien) + " VNĐ";
            //txtTongTien.Text = BLL_HDBH.Instance.GetHoaDon_ByMaHD(MaHD).TongTien.ToString()  + "  VNĐ";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
