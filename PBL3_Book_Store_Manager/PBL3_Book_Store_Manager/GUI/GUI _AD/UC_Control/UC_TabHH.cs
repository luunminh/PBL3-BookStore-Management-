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
using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.GUI_Form;

namespace PBL3_Book_Store_Manager.GUI__AD.UC_Control
{
    public partial class UC_TabHH : UserControl
    {
        public void setGUI(DataGridView dvg)
        {
            dvg.Columns["MaTheLoaiHangHoa"].Visible = false;
            dvg.Columns["MaNhaCungUng"].Visible = false ;
            dvg.Columns["NhaSanXuat"].Visible = false;
            dvg.Columns["NamSanXuat"].Visible = false;
            dvg.Columns["MaKhuTrungBay"].Visible = false;
            dvg.Columns["MaKho"].Visible = false;
            dvg.Columns[0].HeaderText = "Mã Hàng Hóa";
            dvg.Columns[1].HeaderText = "Tên Hàng Hóa";
            dvg.Columns[7].HeaderText = "Số Lượng Trên Khu Trưng Bày";
            dvg.Columns[8].HeaderText = "Mã Kho";
            dvg.Columns[9].HeaderText = "Số Lượng Trong Kho";
            dvg.Columns[10].HeaderText = "Giá Nhập";
            dvg.Columns[11].HeaderText = "Giá Bán";
            dvg.Columns[12].HeaderText = "Trạng Thái";
            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string MaNhanVien;
        public UC_TabHH(string MaNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = MaNhanVien;
            dgvHH.DataSource = BLL_HangHoa.Instance.getListAllHangHoa();
            setGUI(dgvHH);
        }
        private void btChiTietHH_Click(object sender, EventArgs e)
        {
            if (dgvHH.SelectedRows.Count == 0)
                MessageBox.Show("Vui lòng chọn đối tượng hàng hóa");
            else
                if (dgvHH.SelectedRows.Count == 1)
            {
                if (BLL_TheLoaiHangHoa.Instance.getTheLoaiHangHoa(dgvHH.SelectedRows[0].Cells["MaTheLoaiHangHoa"].Value.ToString()).TenTheLoaiHangHoa.ToString() == "Sách")
                {
                    using (ChiTietSach cts = new ChiTietSach(dgvHH.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), MaNhanVien))
                        cts.ShowDialog();
                }
                else
                    using (ChiTietHangHoa cthh = new ChiTietHangHoa(dgvHH.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), MaNhanVien))
                        cthh.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hàng hóa");
            BLL_HangHoa.Instance.getListHangHoa();
            setGUI(dgvHH);
        }

        private void btSearchHH_Click(object sender, EventArgs e)
        {
            if (txtSearchHH.Text.ToString() != "")
                BLL_HangHoa.Instance.TimKiemHangHoa(cbbSortHH.Text.ToString(), txtSearchHH.Text.ToString(), dgvHH);
            else
                dgvHH.DataSource = BLL_HangHoa.Instance.getListAllHangHoa();
            setGUI(dgvHH);
        }
    }
}