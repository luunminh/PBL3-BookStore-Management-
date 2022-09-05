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

namespace PBL3_Book_Store_Manager.GUI_Form
{
    public partial class TaoVaChiTietKM : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        List<TTHangHoa> listHH = new List<TTHangHoa>();
        public TaoVaChiTietKM()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
        private bool KtraSave()
        {
            if (listHH != null && listHH.Count == 0)
            {
                MessageBox.Show("Vui Lòng chọn sản phẩm hàng hóa cần thêm vào hóa đơn");
                return false;
            }
            if(txtTenCTKM.Text.Replace(" ","").Trim()== "")
            {
                MessageBox.Show("Vui Lòng nhập tên chương trình khuyến mãi");
                return false;
            }    
            return true;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận thêm mới không ?", "Xác nhận thêm", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (KtraSave())
                {

                    foreach (TTHangHoa i in listHH)
                    {
                        KhuyenMai km = new KhuyenMai
                        {
                            MaKhuyenMai = "",
                            TenChuongTrinhKhuyenMai = txtTenCTKM.Text,
                            MaHangHoa = i.MaHangHoa,
                            PhanTramKhuyenMai = Convert.ToInt16((numPTKM.Value)),
                            NgayBatDau = Convert.ToDateTime((dtpBD.Value)),
                            NgayKetThuc = Convert.ToDateTime((dtpKT.Value)),


                        };
                        BLL_KhuyenMai.Instance.AddKhuyenMai(km);
                    }
                    MessageBox.Show("Tạo khuyến mãi thành công");
                    d();
                    this.Dispose();

                }
            }

        }

        // kiểm tra hàng hóa đã tồn tại trong chương trình khuyến mãi


        private bool CheckIdHangHoaSeDuocChon()
        {
            foreach (TTHangHoa i in listHH)
            {
                if (i.MaHangHoa.Contains(dgvHHKMSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString().Trim()))
                {
                    MessageBox.Show("Sản phẩm này đã có trong chương trình khuyến mãi");
                    return false;
                }
            }
            return true;
        }

        private void btThemKM_Click(object sender, EventArgs e)
        {
            TTHangHoa data = new TTHangHoa();
            bool Check = false;
            if (KtraAddListSPDaChon() && CheckIdHangHoaSeDuocChon())
            {
                data = BLL_HangHoa.Instance.GetTTHHByMaHH(dgvHHKMSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString());
                decimal total = data.GiaBan;
                data.GiaBan -= Convert.ToDecimal(Convert.ToDouble((data.GiaBan)) * (Convert.ToDouble(numPTKM.Value) / 100));
                data.Discount = Convert.ToInt16(numPTKM.Value);
                // data.ThanhTien = Convert.ToDecimal(data.SoLuong * data.GiaBan - data.GiaBan * (data.Discount / 100));
                Check = true;
            }

            if (Check) listHH.Add(data);
            dgvSPDC.DataSource = null;
            dgvSPDC.DataSource = listHH;
            dgvSPDC.Columns["ThanhTien"].Visible = false;
            dgvSPDC.Columns["SoLuong"].Visible = false;
            dgvSPDC.Columns[0].HeaderText = "Mã hàng hóa";
            dgvSPDC.Columns[1].HeaderText = "Tên hàng hóa";
            dgvSPDC.Columns[2].HeaderText = "Số lượng";
            dgvSPDC.Columns[3].HeaderText = "Giá bán";
            dgvSPDC.Columns[4].HeaderText = "Giá nhập";
            // dgvSPDaChon.Columns["Giá nhập"].Visible = false;
            dgvSPDC.Columns[5].HeaderText = "Mức giảm giá";
            //dgvSPDC.Columns[6].HeaderText = "Thành tiền";
        }

        //
        private bool KtraAddListSPDaChon()
        {
            if (dgvHHKMSearch.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn một đối tượng hàng hóa");
                return false;
            }
            else if (dgvHHKMSearch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đối tượng hàng hóa");
                return false;
            }
            return true;
        }

        private void btSearchKM_Click(object sender, EventArgs e)
        {
            if (cbbKM.SelectedIndex == 0)
            {
                dgvHHKMSearch.DataSource = BLL_HangHoa.Instance.GetListSachByTenSachVaTrangThai(txtSearchKM.Text, "Đang kinh doanh");
                dgvHHKMSearch.Columns["MaNhaCungUng"].Visible = false;
                dgvHHKMSearch.Columns["MaTheLoaiHangHoa"].Visible = false;
                dgvHHKMSearch.Columns["MaSach"].Visible = false;
                dgvHHKMSearch.Columns["MaKhuTrungBay"].Visible = false;
                dgvHHKMSearch.Columns["MaKho"].Visible = false;
                dgvHHKMSearch.Columns["MaSach"].Visible = false;
                dgvHHKMSearch.Columns["MaTheLoaiSach"].Visible = false;
                //dgvHHSearch.Columns[0].HeaderText = "Mã sách";
                dgvHHKMSearch.Columns[1].HeaderText = "Tác giả";
                dgvHHKMSearch.Columns[2].HeaderText = "Lần tái bản";
                dgvHHKMSearch.Columns[3].HeaderText = "Mã thể loại sách";
                dgvHHKMSearch.Columns[4].HeaderText = "Mã hàng hóa";
                dgvHHKMSearch.Columns[5].HeaderText = "Tên hàng hóa";
                // dgvHHSearch.Columns[6].HeaderText = "Mã thể loại hàng hóa";
                dgvHHKMSearch.Columns[7].HeaderText = "Nhà sản xuất";
                dgvHHKMSearch.Columns[8].HeaderText = "Năm sản xuất";
                // dgvHHSearch.Columns[9].HeaderText = "Mã nhà cung ứng";
                //dgvHHSearch.Columns[10].HeaderText = "Mã khu trưng bày";
                dgvHHKMSearch.Columns[11].HeaderText = "Số lượng trên kệ";
                //dgvHHSearch.Columns[12].HeaderText = "Mã kho";
                dgvHHKMSearch.Columns[13].HeaderText = "Số lượng trong kho";
                dgvHHKMSearch.Columns[14].HeaderText = "Giá nhập";
                dgvHHKMSearch.Columns[15].HeaderText = "Giá bán";
                dgvHHKMSearch.Columns[16].HeaderText = "Trạng thái";
                //dgvHHSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbbKM.SelectedIndex == 1)
            {
                dgvHHKMSearch.DataSource = BLL_HangHoa.Instance.GetListHHByTenHHvaTrangThai(txtSearchKM.Text, "Đang kinh doanh");
                dgvHHKMSearch.Columns["MaNhaCungUng"].Visible = false;
                dgvHHKMSearch.Columns["MaKhuTrungBay"].Visible = false;
                dgvHHKMSearch.Columns["MaKho"].Visible = false;
                dgvHHKMSearch.Columns[0].HeaderText = "Mã hàng hóa";
                dgvHHKMSearch.Columns[1].HeaderText = "Tên hàng hóa";
                dgvHHKMSearch.Columns[2].HeaderText = "Mã thể loại hàng hóa";
                dgvHHKMSearch.Columns[3].HeaderText = "Nhà sản xuất";
                // dgvHHSearch.Columns[4].HeaderText = "Mã nhà cung ứng";
                dgvHHKMSearch.Columns[4].HeaderText = "Năm sản xuất";
                // dgvHHSearch.Columns[6].HeaderText = "Mã khu trưng bày";
                dgvHHKMSearch.Columns[7].HeaderText = "Số lượng trên khu trưng bày";
                // dgvHHSearch.Columns[8].HeaderText = "Mã kho";
                dgvHHKMSearch.Columns[9].HeaderText = "Số lượng trong kho";
                dgvHHKMSearch.Columns[10].HeaderText = "Giá nhập";
                dgvHHKMSearch.Columns[11].HeaderText = "Giá bán";
                dgvHHKMSearch.Columns[12].HeaderText = "Trạng thái";
                //dgvHHSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


        }
    }

    }