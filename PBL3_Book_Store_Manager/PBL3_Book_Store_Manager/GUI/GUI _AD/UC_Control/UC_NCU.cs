using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.GUI.GUI_Form;
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
    public partial class UC_NCU : UserControl
    {
        string MaChuVu { get; set; }
        public UC_NCU(string maChucVu)
        {
            InitializeComponent();
            MaChuVu = maChucVu;
            SetGUI();
        }
        public void SetGUI()
        {
            dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
            dgvNCU.Columns["TenNguoiDaiDienPhapLy"].Visible = false;
            dgvNCU.Columns["TenNguoiDaiDienKinhDoanh"].Visible = false;
            dgvNCU.Columns["TrangThai"].Visible = false;
            //dgvNCU.Columns["DiaChi"].Visible = false;
            dgvNCU.Columns[0].HeaderText = "Mã nhà cung ứng";
            dgvNCU.Columns[1].HeaderText = "Tên nhà cung ứng";
            dgvNCU.Columns[4].HeaderText = "Địa chỉ";
            dgvNCU.Columns[5].HeaderText = "Số điện thoại";
            dgvNCU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSortNCU.SelectedIndex = 0;


        }

        private void lbHH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btChiTietNCU_Click(object sender, EventArgs e)
        {
            if(dgvNCU.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng nhà cung ứng cần xem chi tiết");
            }    else if(dgvNCU.SelectedRows.Count == 1)
            {
                ChiTietNCU detailncu = new ChiTietNCU(dgvNCU.SelectedRows[0].Cells["MaNhaCungUng"].Value.ToString(), MaChuVu);
                detailncu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ được chọn 1 đối tượng nhà cung ứng để xem chi tiết");
            } 
                
        }

        private void btSearchNCU_Click(object sender, EventArgs e)
        {
            if (cbbSortNCU.SelectedIndex == 0)
            {
                if (txtSearchNCU.Text == null)
                {
                    dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
                }
                else dgvNCU.DataSource = BLL_NCU.Instance.SearchListNCUByTenNCU(txtSearchNCU.Text);
            }
            else if (cbbSortNCU.SelectedIndex == 1)
            {
                if (txtSearchNCU.Text == null)
                {
                    dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
                }
                else dgvNCU.DataSource = BLL_NCU.Instance.SearchListNCUByDiaChi(txtSearchNCU.Text);
            }else if (cbbSortNCU.SelectedIndex == 2)
            {
                if (txtSearchNCU.Text == null)
                {
                    dgvNCU.DataSource = BLL_NCU.Instance.GetAllListNCU_BLL();
                }
                else dgvNCU.DataSource = BLL_NCU.Instance.SearchListNCUBySDT(txtSearchNCU.Text);
            }    
        }
    }
}
