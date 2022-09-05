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
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.GUI.GUI_Form;

namespace PBL3_Book_Store_Manager.GUI_KHO.UC_Control
{
    public partial class UC_TabKhoHoaDon : UserControl
    {
        public UC_TabKhoHoaDon()
        {
            InitializeComponent();
            show();
            cbbHDNhapKho.SelectedIndex = 0;
            ShowHoaDonChi();
        }
        public void setGUI(DataGridView dgv)
        {

            dgv.Columns["TinhTrang"].Visible = false;
            dgv.Columns["LoaiDeXuat"].Visible = false;
            dgv.Columns[0].HeaderText = "Mã Đề Xuất";
            dgv.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv.Columns[4].HeaderText = "Thời gian";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void show()
        {
            List<DTO.DeXuat> listDeXuatXuatKho = new List<DTO.DeXuat>();
            foreach (DTO.DeXuat item in BLL_DeXuat.Instance.SearchListDeXuatByLoaiDX("Đề xuất xuất hàng hóa lên kệ"))
                if (item.TinhTrang == "Chấp nhận")
                    listDeXuatXuatKho.Add(item);
            dgvHDXuatKho.DataSource = null;
            dgvHDXuatKho.DataSource = listDeXuatXuatKho;
            setGUI(dgvHDXuatKho);
        }

        private void btChiTietHDXuatKho_Click(object sender, EventArgs e)
        {
            ChiTietDeXuatHoaDonXuatKho_NV cddxhdxk = new ChiTietDeXuatHoaDonXuatKho_NV(dgvHDXuatKho.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
            cddxhdxk.ShowDialog();
        }

        private void btSearchHDXuatKho_Click(object sender, EventArgs e)
        {
            List<DTO.DeXuat> listDeXuatXuatKho = new List<DTO.DeXuat>();
            foreach (DTO.DeXuat item in BLL_DeXuat.Instance.SearchListDeXuatByLoaiDX("Đề xuất xuất hàng hóa lên kệ"))
                if (item.TinhTrang == "Chấp nhận" && item.MaNhanVien == txtSearchHDXuatKho.Text.ToString().Trim())
                    listDeXuatXuatKho.Add(item);
            dgvHDXuatKho.DataSource = null;
            dgvHDXuatKho.DataSource = listDeXuatXuatKho;
            setGUI(dgvHDXuatKho);
        }

        private void btChiTietHdNhapKho_Click(object sender, EventArgs e)
        {
            ChiTietDeXuatHoaDonNhapKho_AD chitiet = new ChiTietDeXuatHoaDonNhapKho_AD(dgvHDNhapKho.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
            chitiet.ShowDialog();
        }
        private void btSearchHdNhapKho_Click(object sender, EventArgs e)
        {
            ShowHoaDonChi();
        }

        // show trên tab kho hóa đơn
        public List<DeXuatNhapKhoView> GetListHoaDonNhapHangHoaVaoKhoKhongTheoThoiGian(string ThuocTinh, string TenTimKiem)
        {
            List<DeXuatNhapKhoView> result = new List<DeXuatNhapKhoView>();
            if (ThuocTinh == "All")
            {
                foreach (DeXuatNhapKhoView i in BLL_DeXuat.Instance.GetAllListDeXuatNhapKhoViewDaChapNhan_BLL())
                {
                    result.Add(i);
                }
            }else
            if (ThuocTinh == "Mã đề xuất" && TenTimKiem != null)
            {
                foreach (DeXuatNhapKhoView i in BLL_DeXuat.Instance.GetListDeXuatNhapKhoViewTheoThuocTinh_BLL("MaDeXuat", TenTimKiem))
                {
                    result.Add(i);
                }
            }
            else if (ThuocTinh == "Tên nhân viên" && TenTimKiem != null)
            {
                foreach (DeXuatNhapKhoView i in BLL_DeXuat.Instance.GetListDeXuatNhapKhoViewTheoThuocTinh_BLL("TenNhanVien", TenTimKiem))
                {
                    result.Add(i);
                }
            }
            else
            {
                foreach (DeXuatNhapKhoView i in BLL_DeXuat.Instance.GetAllListDeXuatNhapKhoViewDaChapNhan_BLL())
                {
                    result.Add(i);
                }
            }
            return result;
        }

        //show

        public void ShowHoaDonChi()

        {
            dgvHDNhapKho.DataSource = null;

            dgvHDNhapKho.DataSource = GetListHoaDonNhapHangHoaVaoKhoKhongTheoThoiGian(cbbHDNhapKho.Text, txtSearchHdNhapKho.Text);

            dgvHDNhapKho.Columns["LoaiDeXuat"].Visible = false;

            dgvHDNhapKho.Columns["TinhTrang"].Visible = false;

            dgvHDNhapKho.Columns["MaNhanVien"].Visible = false;

            dgvHDNhapKho.Columns[0].HeaderText = "Mã đề xuất hóa đơn";

            dgvHDNhapKho.Columns[1].HeaderText = "Loại đề xuất";

            dgvHDNhapKho.Columns[2].HeaderText = "Mã nhân viên";

            dgvHDNhapKho.Columns[3].HeaderText = "Tên nhân viên";

            dgvHDNhapKho.Columns[4].HeaderText = "Thời gian";

            dgvHDNhapKho.Columns[5].HeaderText = "Tình trạng";


            dgvHDNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //cbbSortChi.SelectedIndex = 1;
        }

    }
}
