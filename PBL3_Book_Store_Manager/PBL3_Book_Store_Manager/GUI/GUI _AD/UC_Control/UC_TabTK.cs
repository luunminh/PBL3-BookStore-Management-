using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
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
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.GUI.GUI_Form;

namespace PBL3_Book_Store_Manager.GUI__AD.UC_Control
{
    public partial class UC_TabTK : UserControl
    {
        public UC_TabTK()
        {
            InitializeComponent();
            SetGUI();
            cbbSortChi.SelectedIndex = 0;
            ShowThongKeChi(cbbSortChi.Text, txtSearchChi.Text, dtpBatDauChi.Value, dtpKetThucChi.Value);
            long TongTien = 0;

            for (int i = 0; i < dgvChi.Rows.Count; i++)
            {
                string MaDeXuat = dgvChi.Rows[i].Cells["MaDeXuat"].Value.ToString();


                List<DTO.ChiTietDeXuatHD> listCTDXHoaDon = BLL_DeXuat.Instance.getlistChiTietDeXuatHDByMaDX(MaDeXuat);

                foreach (DTO.ChiTietDeXuatHD item in listCTDXHoaDon)
                {
                    DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHHByMaHH(item.MaHangHoa);
                    TongTien += (Convert.ToInt64(HangHoa.GiaNhap) * item.SoLuong);

                }
                lbToTalChi.Text = String.Format("{0:0,0}", TongTien) + " VNĐ"; 
            }
        }
        public void show()
        {
            dgvThu.DataSource = BLL_ThongKe.Instance.GetListHDViewByTG(dtpBatDauThu.Value, dtpKetThucThu.Value);
            dgvThu.Columns[0].HeaderText = "Mã hóa đơn";
            // dgvHDBH.Columns[0].Width = 500;
            dgvThu.Columns[1].HeaderText = "Thời gian tạo";
            // dgvHDBH.Columns[1].Width = 500;
            dgvThu.Columns[2].HeaderText = "Tên nhân viên";
            //dgvHDBH.Columns[2].Width = 500;
            dgvThu.Columns[3].HeaderText = "Tổng tiền";
            dgvThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSortThu.SelectedIndex = 0;
            SetDoanhThuThu(dtpBatDauThu.Value, dtpKetThucThu.Value);
            // MessageBox.Show(dtpKetThucThu.Value.ToString());
        }

        public void SetGUI()
        {
            dtpBatDauThu.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpKetThucThu.Value = dtpBatDauThu.Value.AddYears(1).AddDays(-1);
            dtpBatDauChi.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpKetThucChi.Value = dtpBatDauThu.Value.AddYears(1).AddDays(-1);
            show();

        }


        public void SetDoanhThuThu(DateTime dateFrom, DateTime dateTo)
        {
            lbToTalThu.Text =   String.Format("{0:0,0}", Convert.ToInt32(BLL_ThongKe.Instance.TinhDoanhThuByTG(dateFrom, dateTo))) + " VNĐ";
            lbSoHoaDon.Text = dgvThu.Rows.Count.ToString();
            lbSoLuongBan.Text = DAL_ThongKe.Instance.GetSoLuongHhBanByTG_DAL(dateFrom, dateTo).ToString();
        }

        public void SetDoanhThuThuBySearch(DateTime dateFrom, DateTime dateTo, string Search, string ThongTin)
        {
            lbToTalThu.Text = String.Format("{0:0,0}", Convert.ToInt32(BLL_ThongKe.Instance.TinhDoanhThuByTGSearch(dateFrom, dateTo, Search, ThongTin))) + " VNĐ"; 
            lbSoHoaDon.Text = dgvThu.Rows.Count.ToString();
            lbSoLuongBan.Text = DAL_ThongKe.Instance.GetSoLuongHhBanByTG_DAL(dateFrom, dateTo).ToString();
        }

        private void btSearchThu_Click(object sender, EventArgs e)
        {

            if (cbbSortThu.SelectedIndex == 0)
            {
                if (txtSearchThu.Text == null)
                {
                    dgvThu.DataSource = BLL_ThongKe.Instance.GetListHDViewByTG(dtpBatDauThu.Value, dtpKetThucThu.Value);
                    lbSoLuongBan.Text = DAL_ThongKe.Instance.GetSoLuongHhBanByTG_DAL(dtpBatDauThu.Value, dtpKetThucThu.Value).ToString();
                }
                else
                {
                    dgvThu.DataSource = BLL_ThongKe.Instance.SearchListHDBHViewByMaHd(txtSearchThu.Text, dtpBatDauThu.Value, dtpKetThucThu.Value);
                    SetDoanhThuThuBySearch(dtpBatDauThu.Value, dtpKetThucThu.Value, "MaHoaDon", txtSearchThu.Text);
                    lbSoLuongBan.Text = BLL_ThongKe.Instance.GetSoLuongBan().ToString();
                }

            }
            else if (cbbSortThu.SelectedIndex == 1)
            {
                if (txtSearchThu.Text == null)
                {
                    dgvThu.DataSource = BLL_ThongKe.Instance.GetListHDViewByTG(dtpBatDauThu.Value, dtpKetThucThu.Value);
                    lbSoLuongBan.Text = DAL_ThongKe.Instance.GetSoLuongHhBanByTG_DAL(dtpBatDauThu.Value, dtpKetThucThu.Value).ToString();
                }
                else
                {
                    dgvThu.DataSource = BLL_ThongKe.Instance.SearchListHDBHViewByTenNV(txtSearchThu.Text, dtpBatDauThu.Value, dtpKetThucThu.Value);
                    SetDoanhThuThuBySearch(dtpBatDauThu.Value, dtpKetThucThu.Value, "TenNV", txtSearchThu.Text);
                    lbSoLuongBan.Text = BLL_ThongKe.Instance.GetSoLuongBan().ToString();
                }
            }
        }
        private void btOkThu_Click(object sender, EventArgs e)
        {
            show();
        }
        private void btDetailHH_Click(object sender, EventArgs e)
        {
            if (dgvThu.SelectedRows.Count == 0) MessageBox.Show("Vui lòng chọn đối tượng hóa đơn");
            else if (dgvThu.SelectedRows.Count == 1)
            {
                ChiTietHoaDonNhapKho hd = new ChiTietHoaDonNhapKho(dgvThu.SelectedRows[0].Cells["MaHoaDon"].Value.ToString());
                hd.ShowDialog();

            }
        }


        // thống kê chi 
        public List<DeXuatNhapKhoView> GetListHoaDonNhapHangHoaVaoKho(string ThuocTinh, string TenTimKiem, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            List<DeXuatNhapKhoView> result = new List<DeXuatNhapKhoView>();
            if (ThuocTinh == "All")
            {
                //foreach (DeXuatNhapKhoView i in BLL_DeXuat.Instance.GetAllListDeXuatNhapKhoViewDaChapNhan_BLL())
                //{
                //    result.Add(i);
                //}
            }else 
            
            if (ThuocTinh == "Mã đề xuất" && TenTimKiem != null)
            {
                foreach (DeXuatNhapKhoView i in BLL_DeXuat.Instance.GetListDeXuatNhapKhoViewTheoThuocTinhVaThoiGian_BLL("MaDeXuat", TenTimKiem, NgayBatDau, NgayKetThuc))
                {
                    result.Add(i);
                }
            }
            else if (ThuocTinh == "Tên nhân viên" && TenTimKiem != null)
            {
                foreach (DeXuatNhapKhoView i in BLL_DeXuat.Instance.GetListDeXuatNhapKhoViewTheoThuocTinhVaThoiGian_BLL("TenNhanVien", TenTimKiem, NgayBatDau, NgayKetThuc))
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

        private void btSearchChi_Click(object sender, EventArgs e)
        {
            if (cbbSortChi.Text == "All")
            {
                ShowThongKeChi(cbbSortChi.Text, txtSearchChi.Text, dtpBatDauChi.Value, dtpKetThucChi.Value);
            }

            if (cbbSortChi.Text != null && txtSearchChi.Text != null && dtpBatDauChi.Value != null && dtpKetThucChi.Value != null)
            {
                ShowThongKeChi(cbbSortChi.Text, txtSearchChi.Text, dtpBatDauChi.Value, dtpKetThucChi.Value);
            }
            long TongTien = 0;

            for (int i = 0; i < dgvChi.Rows.Count; i++)
            {
                string MaDeXuat = dgvChi.Rows[i].Cells["MaDeXuat"].Value.ToString();


                List<DTO.ChiTietDeXuatHD> listCTDXHoaDon = BLL_DeXuat.Instance.getlistChiTietDeXuatHDByMaDX(MaDeXuat);

                foreach (DTO.ChiTietDeXuatHD item in listCTDXHoaDon)
                {
                    DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHHByMaHH(item.MaHangHoa);
                    TongTien += (Convert.ToInt64(HangHoa.GiaNhap) * item.SoLuong);

                }
                
            }
            lbToTalChi.Text = String.Format("{0:0,0}", TongTien) + " VNĐ";

        }
        public void ShowThongKeChi(string Sort, string Search, DateTime TGBD, DateTime TGKT)

        {
            dgvChi.DataSource = null;
            dgvChi.DataSource = GetListHoaDonNhapHangHoaVaoKho(cbbSortChi.Text, txtSearchChi.Text, dtpBatDauChi.Value, dtpKetThucChi.Value);

            dgvChi.Columns["LoaiDeXuat"].Visible = false;

            dgvChi.Columns["TinhTrang"].Visible = false;

            dgvChi.Columns["MaNhanVien"].Visible = false;

            dgvChi.Columns[0].HeaderText = "Mã đề xuất";

            dgvChi.Columns[3].HeaderText = "Tên nhân viên";

            dgvChi.Columns[4].HeaderText = "Thời gian";

            dgvChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //cbbSortChi.SelectedIndex = 1;
        }



        private void btOKChi_Click(object sender, EventArgs e)
        {


            ShowThongKeChi(cbbSortChi.Text, txtSearchChi.Text, dtpBatDauChi.Value, dtpKetThucChi.Value);
            long TongTien = 0;

            for (int i = 0; i < dgvChi.Rows.Count; i++)
            {
                string MaDeXuat = dgvChi.Rows[i].Cells["MaDeXuat"].Value.ToString();


                List<DTO.ChiTietDeXuatHD> listCTDXHoaDon = BLL_DeXuat.Instance.getlistChiTietDeXuatHDByMaDX(MaDeXuat);

                foreach (DTO.ChiTietDeXuatHD item in listCTDXHoaDon)
                {
                    DTO.HangHoa HangHoa = BLL_HangHoa.Instance.GetHHByMaHH(item.MaHangHoa);
                    TongTien += (Convert.ToInt64(HangHoa.GiaNhap) * item.SoLuong);

                }
                lbToTalChi.Text = String.Format("{0:0,0}", TongTien) + " VNĐ"; 
            }

        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietDeXuatHoaDonNhapKho_AD chitiet = new ChiTietDeXuatHoaDonNhapKho_AD(dgvChi.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
            chitiet.ShowDialog();
        }
    }
}