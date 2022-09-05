using PBL3_Book_Store_Manager.BLL;
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
    public partial class TaoNCU : Form
    {
        public string MaNV { get; set; }
        public TaoNCU(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool Check()
        {
            if(txtTenNCU.Text.Replace(" ","") == "")
            {
                MessageBox.Show("Bạn chưa nhập tên cho nhà cung ứng. Vui lòng nhập têm cho nhà cung ứng!");
                txtTenNCU.Clear();
                txtTenNCU.Focus();
                return false;
            }
            if (txtDaiDienKD.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Bạn chưa nhập tên người đại diện kinh doanh cho nhà cung ứng.Vui lòng nhập tên người đại diện kinh doanh nhà cung ứng!");
                txtDaiDienKD.Clear();
                txtDaiDienKD.Focus();
                return false;
            }
            if (txtDaiDienPhapLy.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Bạn chưa nhập tên người đại diện pháp lý cho nhà cung ứng.Vui lòng nhập tên người đại diện pháp lý nhà cung ứng!");
                txtDaiDienPhapLy.Clear();
                txtDaiDienPhapLy.Focus();
                return false;
            }
            if (txtDiaChi.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ cho nhà cung ứng. Vui lòng nhập địa chỉ nhà cung ứng!");
                txtDiaChi.Clear();
                txtDiaChi.Focus();
                return false;
            }
            if(CheckSDT(txtSDT.Text) == false)
            {
                return false;
            }    

            return true;
        }
       
        public bool CheckSDT(string sdt)
        {
            if(sdt.Trim() == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại cho nhà cung ứng. Vui lòng nhập số điện thoại cho nhà cung ứng!");
                return false;
            }
            if(sdt.Trim().Length != 10)
            {
                MessageBox.Show("Vui lòng chỉ nhập số điện thoại có 10 chữ số!");
                return false;
            }
            if(sdt.Replace(" ","").Trim() == "")
            {
                MessageBox.Show("Vui lòng không được bỏ trống số điện thoại!");
                return false;
            }
            else
            {
                long sdtcheck;
                if(Int64.TryParse(sdt, out sdtcheck) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    return false;
                }    
            }
            return true;
                
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận thêm mới nhà cung ứng không ?", "Xác nhận thêm", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (Check())
                {
                    NhaCungUng ncu = new NhaCungUng
                    {
                        MaNhaCungUng = "",
                        TenNhaCungUng = txtTenNCU.Text,
                        TenNguoiDaiDienKinhDoanh = txtDaiDienKD.Text,
                        TenNguoiDaiDienPhapLy = txtDaiDienPhapLy.Text,
                        SoDienThoai = txtSDT.Text,
                        DiaChi = txtDiaChi.Text,
                        TrangThai = "Không hoạt động"
                    };
                    BLL_NCU.Instance.AddNCU(ncu);
                    DeXuat dx = new DeXuat
                    {
                        MaDeXuat = "",
                        MaNhanVien = MaNV,
                        TinhTrang = "Đang chờ phê duyệt",
                        ThoiGian = DateTime.Now,
                        LoaiDeXuat = "Đề xuất thêm nhà cung ứng"
                    };
                    BLL_DeXuat.Instance.AddDeXuat_BLL(dx);
                    ChiTietDeXuatNCU chiTietdxNCU = new ChiTietDeXuatNCU
                    {
                        MaDeXuat = BLL_DeXuat.Instance.GetLasTestDeXuat().MaDeXuat,
                        MaNhaCungUng = BLL_NCU.Instance.GetLasTestNCU().MaNhaCungUng,
                        MaThamChieu = "",
                    };
                    BLL_DeXuat.Instance.AddChiTietDeXuat_BLL(chiTietdxNCU);
                    //them de xuat nua
                    MessageBox.Show("Đã tạo đề xuất thêm nhà cung ứng thành công");
                    this.Dispose();
                }
            }
           
        }
    }
}
