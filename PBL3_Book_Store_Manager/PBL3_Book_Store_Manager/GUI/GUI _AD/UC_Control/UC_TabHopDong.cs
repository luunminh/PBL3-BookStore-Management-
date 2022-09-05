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

namespace PBL3_Book_Store_Manager.GUI__AD.UC_Control
{
    public partial class UC_TabHopDong : UserControl
    {
        public UC_TabHopDong()
        {
            InitializeComponent();
          //  dgvNCU.DataSource = new List<string>();
            ShowNV();
            ShowNCU();
        }

        public void ShowNCU()
        {
            dgvNCU.DataSource = BLL_HopDongNCU.Instance.GetAllListHopDongNCUView_BLL();
            dgvNCU.Columns["HinhAnh"].Visible = false;
            dgvNCU.Columns[0].HeaderText = "Mã hợp đồng";
            // dgvHDBH.Columns[0].Width = 500;
            dgvNCU.Columns[1].HeaderText = "Tên nhà cung ứng";
            // dgvHDBH.Columns[1].Width = 500;
            dgvNCU.Columns[2].HeaderText = "Ngày bắt đầu";
            //dgvHDBH.Columns[2].Width = 500;
            dgvNCU.Columns[3].HeaderText = "Ngày kết thúc";
            dgvNCU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSortNCU.SelectedIndex = 0;
        }

        public void ShowNV()
        {
            dgvNV.DataSource = BLL_HopDongNV.Instance.GetAllListHopDongNVView_BLL();
            dgvNV.Columns["HinhAnh"].Visible = false;
            dgvNV.Columns[0].HeaderText = "Mã hợp đồng";
            // dgvHDBH.Columns[0].Width = 500;
            dgvNV.Columns[1].HeaderText = "Tên nhân viên";
            // dgvHDBH.Columns[1].Width = 500;
            dgvNV.Columns[2].HeaderText = "Ngày ký kết";
            //dgvHDBH.Columns[2].Width = 500;
            // dgvNV.Columns[3].HeaderText = "Ngày kết thúc";
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSortNV.SelectedIndex = 0;
        }

        //NV
        private void btThemNV_Click(object sender, EventArgs e)
        {
            ThemHopDongNV themHdHv = new ThemHopDongNV();
            themHdHv.d += new ThemHopDongNV.MyDell(ShowNV);
            themHdHv.ShowDialog();
        }

        private void btChiTietNV_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xem chi tiết");
            }
            else if (dgvNV.SelectedRows.Count == 1)
            {
                ChiTietHopDongNV hopdongnv = new ChiTietHopDongNV(dgvNV.SelectedRows[0].Cells["MaHopDongNV"].Value.ToString());
                    hopdongnv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một hợp đồng cần xem chi tiết");
            }
        }

        private void btSearchNV_Click(object sender, EventArgs e)
        {
            if (cbbSortNV.SelectedIndex == 0)
            {
                if (txtSearchNV.Text.Trim() == "")
                {
                    dgvNV.DataSource = BLL_HopDongNV.Instance.GetAllListHopDongNVView_BLL();

                }
                else
                {
                    dgvNV.DataSource = BLL_HopDongNV.Instance.SearchHopDongNVByMaHD(txtSearchNV.Text);
                }
            }
            else if (cbbSortNV.SelectedIndex == 1)
            {
                if (txtSearchNV.Text.Trim() == "")
                {
                    dgvNV.DataSource = BLL_HopDongNV.Instance.GetAllListHopDongNVView_BLL();

                }
                else
                {
                    dgvNV.DataSource = BLL_HopDongNV.Instance.SearchHopDongNVByTenNCU(txtSearchNV.Text);
                }
            }
        }

        //NCU

        private void btThemNCU_Click(object sender, EventArgs e)
        {
            using (ThemHopDongNCU hdncu = new ThemHopDongNCU())
            {
                hdncu.d += new ThemHopDongNCU.MyDel(ShowNCU);
                hdncu.ShowDialog();
            }
        }

        private void btSearchNCU_Click(object sender, EventArgs e)
        {
            if (cbbSortNCU.SelectedIndex == 0)
            {
                if (txtSearchNCU.Text.Trim() == "")
                {
                    dgvNCU.DataSource = BLL_HopDongNCU.Instance.GetAllListHopDongNCUView_BLL();
                }
                else
                {
                    dgvNCU.DataSource = BLL_HopDongNCU.Instance.SearchHopDongNCUByMaHD(txtSearchNCU.Text);
                }
            }
            else if (cbbSortNCU.SelectedIndex == 1)
            {
                if (txtSearchNCU.Text.Trim() == "")
                {
                    dgvNCU.DataSource = BLL_HopDongNCU.Instance.GetAllListHopDongNCUView_BLL();
                }
                else
                {
                    dgvNCU.DataSource = BLL_HopDongNCU.Instance.SearchHopDongNCUByTenNCU(txtSearchNCU.Text);
                }
            }
        }

        private void btChiTietNCU_Click(object sender, EventArgs e)
        {
            if (dgvNCU.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xem chi tiết");
            }
            else if (dgvNCU.SelectedRows.Count == 1)
            {
                ChiTietHopDong_NCU hopdongncu = new ChiTietHopDong_NCU(dgvNCU.SelectedRows[0].Cells["MaHopDongNCU"].Value.ToString());
                hopdongncu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một hợp đồng cần xem chi tiết");
            }

        }


    }
}
