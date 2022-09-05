using PBL3_Book_Store_Manager.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.GUI_BH.UC_Control
{
    public partial class UC_BHKhuyenMai : UserControl
    {
        public UC_BHKhuyenMai()
        {
            InitializeComponent();
            ShowKhuyenMai();
        }
        public void ShowKhuyenMai()
        {
            dgvKM.DataSource = BLL_KhuyenMai.Instance.GetAllListKhuyenMaiView_BLL();
            dgvKM.Columns[0].HeaderText = "Mã khuyến mãi";
            dgvKM.Columns[1].HeaderText = "Tên chương trình khuyến mãi";
            dgvKM.Columns[2].HeaderText = "Tên hàng hóa";
            dgvKM.Columns[3].HeaderText = "Phần trăm khuyến mãi";
            dgvKM.Columns[4].HeaderText = "Ngày bắt đầu";
            dgvKM.Columns[5].HeaderText = "Ngày kết thúc";
            dgvKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSortKM.SelectedIndex = 0;


        }

        private void btSearchKM_Click(object sender, EventArgs e)
        {
            if (cbbSortKM.SelectedIndex == 0)
            {
                if (txtSearchKM.Text == null)
                {
                    dgvKM.DataSource = BLL_KhuyenMai.Instance.GetAllListKhuyenMaiView_BLL();

                }
                else dgvKM.DataSource = BLL_KhuyenMai.Instance.SearchListKhuyenMaiByMaKM(txtSearchKM.Text);
            }
            else if (cbbSortKM.SelectedIndex == 1)
            {
                if (txtSearchKM.Text == null)
                {
                    dgvKM.DataSource = BLL_KhuyenMai.Instance.GetAllListKhuyenMaiView_BLL();
                }
                else dgvKM.DataSource = BLL_KhuyenMai.Instance.SearchListKhuyenMaiByTenChuongTrinhKhuyenMai(txtSearchKM.Text);
            }
            else if (cbbSortKM.SelectedIndex == 2)
            {
                if (txtSearchKM.Text == null)
                {
                    dgvKM.DataSource = BLL_KhuyenMai.Instance.GetAllListKhuyenMaiView_BLL();
                }
                else dgvKM.DataSource = BLL_KhuyenMai.Instance.SearchListKhuyenMaiByNgayBatDau(txtSearchKM.Text);
            }
            else if (cbbSortKM.SelectedIndex == 3)
            {
                if (txtSearchKM.Text == null)
                {
                    dgvKM.DataSource = BLL_KhuyenMai.Instance.GetAllListKhuyenMaiView_BLL();
                }
                else dgvKM.DataSource = BLL_KhuyenMai.Instance.SearchListKhuyenMaiByNgayKetThuc(txtSearchKM.Text);
            }
        }
    }
}