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
    public partial class ChiTietNCU : Form
    {
        string MaNCU { get; set; }
        string MaChucVu { get; set; }
        string MaNV { get; set; }
        public ChiTietNCU(string maNCU,string maChucVu,string maNv ="")
        {
            InitializeComponent();
            MaChucVu = maChucVu;
            MaNCU = maNCU;
            MaNV = maNv;
            setGUI();
            //MessageBox.Show(MaChucVu);
        }
       
        public void setGUI()
        {
            txtTenNCU.Text = BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).TenNhaCungUng;
            txtDaiDienKD.Text = BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).TenNguoiDaiDienKinhDoanh.ToString();
            txtDaiDienPhapLy.Text = BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).TenNguoiDaiDienPhapLy.ToString();
            txtDiaChi.Text = BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).DiaChi.ToString();
            txtSDT.Text = BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).SoDienThoai.ToString();
            LockTextBox();
        }
        public void LockTextBox()
        {
            if (MaChucVu == "CV000")
            {
                txtTenNCU.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtDaiDienPhapLy.Enabled = false;
                txtDaiDienKD.Enabled = false;

            }

        }
        public bool CheckThayDoi()
        {
            if(txtTenNCU.Text.Trim() != BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).TenNhaCungUng.Trim())
            {
                return false;
            }
            if (txtDaiDienKD.Text.Trim() != BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).TenNguoiDaiDienKinhDoanh.Trim())
            {
                return false;
            }
            if (txtDaiDienPhapLy.Text.Trim() != BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).TenNguoiDaiDienPhapLy.Trim())
            {
                return false;
            }
            if (txtSDT.Text.Trim() != BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).SoDienThoai.Trim())
            {
                return false;
            }
            if (txtDiaChi.Text.Trim() != BLL_NCU.Instance.SearchNCUByMaNCU(MaNCU).DiaChi.Trim())
            {
                return false;
            }

            return true;
        }
        public bool Check()
        {
            if (txtTenNCU.Text.Replace(" ", "") == "")
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
            if (CheckSDT(txtSDT.Text) == false)
            {
                return false;
            }

            return true;
        }

        public bool CheckSDT(string sdt)
        {
            if (sdt.Trim() == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại cho nhà cung ứng. Vui lòng nhập số điện thoại cho nhà cung ứng!");
            }
            if (sdt.Trim().Length != 10)
            {
                MessageBox.Show("Vui lòng chỉ nhập số điện thoại có 10 chữ số!");
                return false;
            }
            else
            {
                long sdtcheck;
                if (Int64.TryParse(sdt, out sdtcheck) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    return false;
                }
            }
            return true;

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if((MaChucVu == "CV000"))
            {
                this.Dispose();
            }
            else
            {
                DialogResult results = MessageBox.Show("Bạn có muốn xác nhận cập nhật thông tin nhà cung ứng không ?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    if (CheckThayDoi() == false)
                    {
                        if (Check())
                        {
                            DeXuat dx = new DeXuat
                            {
                                MaDeXuat = "",
                                MaNhanVien = MaNV,
                                LoaiDeXuat = "Đề xuất cập nhật thông tin nhà cung ứng",
                                ThoiGian = DateTime.Now,
                                TinhTrang = "Đang chờ phê duyệt"
                            };
                            BLL_DeXuat.Instance.AddDeXuat_BLL(dx);

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
                            ChiTietDeXuatNCU ctdxNCU = new ChiTietDeXuatNCU
                            {
                                MaDeXuat = BLL_DeXuat.Instance.GetLasTestDeXuat().MaDeXuat,
                                MaNhaCungUng = MaNCU,
                                MaThamChieu = BLL_NCU.Instance.GetLasTestNCU().MaNhaCungUng
                            };
                            BLL_DeXuat.Instance.AddChiTietDeXuat_BLL(ctdxNCU);
                            MessageBox.Show("Đã gửi đề xuất cập nhật thông tin nhà cung ứng");
                            this.Dispose();
                        }
                    }
                }
                
            } 
                
        }
    }
}
