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

namespace PBL3_Book_Store_Manager.GUI_BH.UC_Control
{
    public partial class UC_HoaDonBH : UserControl
    {
        string MaNV;
        public UC_HoaDonBH(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            show();
        }

        public void show()
        {
            dgvHDBH.DataSource = BLL_HDBH.Instance.GetListHDView();
            dgvHDBH.Columns[0].HeaderText = "Mã hóa đơn";
           // dgvHDBH.Columns[0].Width = 500;
            dgvHDBH.Columns[1].HeaderText = "Thời gian tạo";
           // dgvHDBH.Columns[1].Width = 500;
            dgvHDBH.Columns[2].HeaderText = "Tên nhân viên";
            dgvHDBH.Columns[3].HeaderText = "Tổng tiền";
            //dgvHDBH.Columns[2].Width = 500;
            dgvHDBH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSortHDBH.SelectedIndex = 0;
        }

        private void btThemHDBH_Click(object sender, EventArgs e)
        {
            ThemHoaDonBH themHDBH = new ThemHoaDonBH(MaNV);
            themHDBH.d += new ThemHoaDonBH.MyDel(Show);
            themHDBH.ShowDialog();
            
        }

        private void btDetailHH_Click(object sender, EventArgs e)
        {
            if (dgvHDBH.SelectedRows.Count == 0) MessageBox.Show("Vui lòng chọn đối tượng hóa đơn");
            else if(dgvHDBH.SelectedRows.Count == 1)
            {
                ChiTietHoaDonNhapKho hd = new ChiTietHoaDonNhapKho(dgvHDBH.SelectedRows[0].Cells["MaHoaDon"].Value.ToString());
                 hd.ShowDialog();
                
            }
        }

        private void btSearchHDBH_Click(object sender, EventArgs e)
        {
            if(cbbSortHDBH.SelectedIndex == 0 )
            {
                if(txtSearchHDBH.Text == null)
                {
                    dgvHDBH.DataSource = BLL_HDBH.Instance.GetListHDView();
                }
                else dgvHDBH.DataSource = BLL_HDBH.Instance.SearchListHDBHViewByMaHd(txtSearchHDBH.Text);
            }else if(cbbSortHDBH.SelectedIndex == 1)
            {
                if (txtSearchHDBH.Text == null)
                {
                    dgvHDBH.DataSource = BLL_HDBH.Instance.GetListHDView();
                }
                else dgvHDBH.DataSource = BLL_HDBH.Instance.SearchListHDBHViewByTenNV(txtSearchHDBH.Text);
            }
        }
    }
}
