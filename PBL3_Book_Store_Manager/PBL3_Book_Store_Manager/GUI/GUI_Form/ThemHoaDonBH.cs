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

namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    public partial class ThemHoaDonBH : Form
    {
        public string MaNV;
        public decimal totalHD { get; set; }
        public delegate void MyDel();
        public MyDel d { get;set;}
        List<TTHangHoa> listHH = new List<TTHangHoa>();
        public ThemHoaDonBH(string maNhanVien)
        {
            InitializeComponent();
            MaNV = maNhanVien;
            cbbHH.SelectedIndex = 0;
            listHH = new List<TTHangHoa>();
            txtMaNV.Text = BLL_NV.Instance.GetNVByMaNV(MaNV).TenNhanVien.ToString();
           
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btThemHH_Click(object sender, EventArgs e)
        {
              
            TTHangHoa data = new TTHangHoa();
            bool Check = false;
            if (KtraAddListSPDaChon())
            {
                data = BLL_HangHoa.Instance.GetTTHHByMaHH(dgvHHSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString());
                data.SoLuong = Convert.ToInt16(numSoLuongHH.Value);
                if(BLL_KhuyenMai.Instance.GetKhuyenMaiByMaHangHoaVaThoiGian(dgvHHSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), DateTime.Now) == null)
                {
                    data.Discount = 0;
                }
                else
                {
                    data.Discount = Convert.ToInt16(BLL_KhuyenMai.Instance.GetKhuyenMaiByMaHangHoaVaThoiGian(dgvHHSearch.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), DateTime.Now).PhanTramKhuyenMai);

                }
                 data.ThanhTien = Convert.ToDecimal(data.SoLuong * (data.GiaBan - data.GiaBan * (data.Discount / 100)));
                data.ThanhTien = Math.Round(data.ThanhTien,0);
                Check = true;
            }
            int count = 0;
            foreach(TTHangHoa i in listHH)
            {
                if (i.MaHangHoa == data.MaHangHoa)
                {
                    i.SoLuong += data.SoLuong;
                    i.ThanhTien += data.ThanhTien;
                    count = 1; break;
                }
            }
            if(count == 0 && Check) listHH.Add(data);
            dgvSPDaChon.DataSource = null;
            dgvSPDaChon.DataSource = listHH;
            dgvSPDaChon.Columns[0].HeaderText = "Mã hàng hóa";
            dgvSPDaChon.Columns[1].HeaderText = "Tên hàng hóa";
            dgvSPDaChon.Columns[2].HeaderText = "Số lượng";
            dgvSPDaChon.Columns[3].HeaderText = "Giá bán";
            dgvSPDaChon.Columns[4].HeaderText = "Giá nhập";
            // dgvSPDaChon.Columns["Giá nhập"].Visible = false;
            dgvSPDaChon.Columns[5].HeaderText = "Mức giảm giá";
            dgvSPDaChon.Columns[6].HeaderText = "Thành tiền";
            decimal Tongtien = listHH.Sum(x => x.ThanhTien);
            totalHD = Tongtien;
            //string x = String.Format("{0:0,0}", Tongtien);
            txtTongTien.Text = String.Format("{0:0,0}", Tongtien) + " VNĐ";
            numSoLuongHH.Value = 0;

        }

        private bool KtraAddListSPDaChon()
        {
            if(dgvHHSearch.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn một đối tượng hàng hóa");
                return false;
            }else if(dgvHHSearch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đối tượng hàng hóa");
                return false;
            }else if (dgvHHSearch.SelectedRows.Count == 1)
            {
                if((Convert.ToInt32(numSoLuongHH.Value.ToString()) == 0) )
                {
                    MessageBox.Show("Vui lòng nhập số lượng cho hàng hóa");
                    return false;
                }else if((Convert.ToInt32(numSoLuongHH.Value.ToString()) >= 1 && (Convert.ToInt32(numSoLuongHH.Value.ToString()) > Convert.ToInt32(dgvHHSearch.SelectedRows[0].Cells["SoLuongTrenKhuTrungBay"].Value.ToString()))))
                {
                    MessageBox.Show("Số lượng nhập hiện tại nhiều hơn số lượng hàng hóa đang có");
                    return false;
                }
            }    
            
            return true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if(cbbHH.SelectedIndex == 0)
            {
                dgvHHSearch.DataSource = BLL_HangHoa.Instance.GetListSachByTenSachVaTrangThai(txtSearch.Text, "Đang kinh doanh");
                dgvHHSearch.Columns["MaNhaCungUng"].Visible = false;
                dgvHHSearch.Columns["MaTheLoaiHangHoa"].Visible = false;
                dgvHHSearch.Columns["MaSach"].Visible = false;
                dgvHHSearch.Columns["MaKhuTrungBay"].Visible = false;
                dgvHHSearch.Columns["MaKho"].Visible = false;
                dgvHHSearch.Columns["MaSach"].Visible = false;
                dgvHHSearch.Columns["MaTheLoaiSach"].Visible = false;
                //dgvHHSearch.Columns[0].HeaderText = "Mã sách";
                dgvHHSearch.Columns[1].HeaderText = "Tác giả";
                dgvHHSearch.Columns[2].HeaderText = "Lần tái bản";
                dgvHHSearch.Columns[3].HeaderText = "Mã thể loại sách";
                dgvHHSearch.Columns[4].HeaderText = "Mã hàng hóa";
                dgvHHSearch.Columns[5].HeaderText = "Tên hàng hóa";
                // dgvHHSearch.Columns[6].HeaderText = "Mã thể loại hàng hóa";
                dgvHHSearch.Columns[7].HeaderText = "Nhà sản xuất";
                dgvHHSearch.Columns[8].HeaderText = "Năm sản xuất";
               // dgvHHSearch.Columns[9].HeaderText = "Mã nhà cung ứng";
                //dgvHHSearch.Columns[10].HeaderText = "Mã khu trưng bày";
                dgvHHSearch.Columns[11].HeaderText = "Số lượng trên kệ";
                //dgvHHSearch.Columns[12].HeaderText = "Mã kho";
                dgvHHSearch.Columns[13].HeaderText = "Số lượng trong kho";
                dgvHHSearch.Columns[14].HeaderText = "Giá nhập";
                dgvHHSearch.Columns[15].HeaderText = "Giá bán";
                dgvHHSearch.Columns[16].HeaderText = "Trạng thái";
                //dgvHHSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if(cbbHH.SelectedIndex == 1)
            {
                dgvHHSearch.DataSource = BLL_HangHoa.Instance.GetListHHByTenHHvaTrangThai(txtSearch.Text, "Đang kinh doanh");
                dgvHHSearch.Columns["MaNhaCungUng"].Visible = false;
                dgvHHSearch.Columns["MaKhuTrungBay"].Visible = false;
                dgvHHSearch.Columns["MaKho"].Visible = false;
                dgvHHSearch.Columns[0].HeaderText = "Mã hàng hóa";
                dgvHHSearch.Columns[1].HeaderText = "Tên hàng hóa";
                dgvHHSearch.Columns[2].HeaderText = "Mã thể loại hàng hóa";
                dgvHHSearch.Columns[3].HeaderText = "Nhà sản xuất";
                // dgvHHSearch.Columns[4].HeaderText = "Mã nhà cung ứng";
                dgvHHSearch.Columns[4].HeaderText = "Năm sản xuất";
                // dgvHHSearch.Columns[6].HeaderText = "Mã khu trưng bày";
                dgvHHSearch.Columns[7].HeaderText = "Số lượng trên khu trưng bày";
                // dgvHHSearch.Columns[8].HeaderText = "Mã kho";
                dgvHHSearch.Columns[9].HeaderText = "Số lượng trong kho";
                dgvHHSearch.Columns[10].HeaderText = "Giá nhập";
                dgvHHSearch.Columns[11].HeaderText = "Giá bán";
                dgvHHSearch.Columns[12].HeaderText = "Trạng thái";
                //dgvHHSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private bool KtraSave()
        {
            if(listHH != null && listHH.Count == 0)
            {
                MessageBox.Show("Vui Lòng chọn sản phẩm hàng hóa cần thêm vào hóa đơn");
                return false;
            }
            return true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo hóa đơn mới không ?", "Xác nhận tạo", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (KtraSave())
                {
                    HoaDon hd = new HoaDon
                    {
                        MaHoaDon = "",            //HD đã được set tự động ở cở sở dữ liệu
                        ThoiGian = DateTime.Now,
                        MaNhanVien = MaNV,    
                        TongTien = totalHD
                                                //Ma
                    };
                    BLL_HDBH.Instance.AddHD_BLL(hd);
                    HoaDon hdThoiGian = new HoaDon();
                    hdThoiGian = BLL_HDBH.Instance.GetHoaDonByThoiGian(hd);
                    //MessageBox.Show("Thanh cong" +hdThoiGian.MaHoaDon);
                    foreach (TTHangHoa i in listHH)
                    {
                        ChiTietHD ct = new ChiTietHD
                        {
                            MaHoaDon = hdThoiGian.MaHoaDon,
                            MaHangHoa = i.MaHangHoa,
                            SoLuong = i.SoLuong,
                        };
                        BLL_HDBH.Instance.AddCTHD_BLL(ct);
                        HangHoa h = new HangHoa
                        {
                            MaHangHoa = i.MaHangHoa,
                            SoLuongTrenKhuTrungBay = Convert.ToInt16(Convert.ToInt32(BLL_HangHoa.Instance.GetHHByMaHH(i.MaHangHoa).SoLuongTrenKhuTrungBay) - Convert.ToInt32(i.SoLuong)),
                        };
                        BLL_HangHoa.Instance.UpdateSoLuongHH(h);

                    }
                    MessageBox.Show("Tạo hóa đơn thành công");
                    d();
                    this.Dispose();

                }
            }
             
        }
    }
}
