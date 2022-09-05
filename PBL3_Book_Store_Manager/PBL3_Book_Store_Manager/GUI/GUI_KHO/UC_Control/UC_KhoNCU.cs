using PBL3_Book_Store_Manager.BLL;
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

namespace PBL3_Book_Store_Manager.GUI_KHO.UC_Control
{
    public partial class UC_KhoNCU : UserControl
    {
        string MaChuVu { get; set; }
        string MaNhanVien { get; set; }
        public UC_KhoNCU(string maChucVu,string maNv)
        {
            InitializeComponent();
            MaNhanVien = maNv;
            MaChuVu = maChucVu;
            SetGUI();
        }


        public void SetGUI()
        {
            dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
            dgvNCU.Columns["TenNguoiDaiDienPhapLy"].Visible = false;
            dgvNCU.Columns["TenNguoiDaiDienKinhDoanh"].Visible = false;
            dgvNCU.Columns["TrangThai"].Visible = false;
            dgvNCU.Columns[0].HeaderText = "Mã nhà cung ứng";
            dgvNCU.Columns[1].HeaderText = "Tên nhà cung ứng";
            dgvNCU.Columns[4].HeaderText = "Địa chỉ";
            dgvNCU.Columns[5].HeaderText = "Số điện thoại";
            dgvNCU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSort.SelectedIndex = 0;


        }

        private void btThem_Click(object sender, EventArgs e)
        {
            TaoNCU taoNCU = new TaoNCU(MaNhanVien);
            taoNCU.ShowDialog();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex == 0)
            {
                if (txtSearch.Text.Trim() == null)
                {
                    dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
                }
                else dgvNCU.DataSource = BLL_NCU.Instance.SearchListNCUByTenNCU(txtSearch.Text);
            }
            else if (cbbSort.SelectedIndex == 1)
            {
                if (txtSearch.Text.Trim() == null)
                {
                    dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
                }
                else dgvNCU.DataSource = BLL_NCU.Instance.SearchListNCUByDiaChi(txtSearch.Text);
            }
            else if (cbbSort.SelectedIndex == 2)
            {
                if (txtSearch.Text.Trim() == null)
                {
                    dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
                }
                else dgvNCU.DataSource = BLL_NCU.Instance.SearchListNCUBySDT(txtSearch.Text);
            }
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvNCU.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng nhà cung ứng cần xem chi tiết");
            }
            else if (dgvNCU.SelectedRows.Count == 1)
            {
                ChiTietNCU detailncu = new ChiTietNCU(dgvNCU.SelectedRows[0].Cells["MaNhaCungUng"].Value.ToString(), MaChuVu, MaNhanVien);
                detailncu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ được chọn 1 đối tượng nhà cung ứng để xem chi tiết");
            }
        }
    }
}
