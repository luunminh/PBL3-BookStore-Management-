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

namespace PBL3_Book_Store_Manager.GUI_Form
{
    public partial class ThemNV : Form
    {

        public delegate void MyDel();
        public MyDel d { get; set; }
        List<DTO.CaLam> listCaLam;
        public ThemNV()
        {
            InitializeComponent();
            rdbNam.Checked = true;
            cbbChucVu.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
            listCaLam = new List<CaLam>();
            cbbCaLam.DisplayMember = "TenCaLam";
            cbbCaLam.DataSource = BLL_CaLam.Instance.GetListCaLam_BLL();
            dgvViewCaLam.DataSource = null;
        }
        public void show()
        {
            dgvViewCaLam.Columns["TrangThai"].Visible = false;
            dgvViewCaLam.Columns[0].HeaderText = "Mã ca làm";
            dgvViewCaLam.Columns[1].HeaderText = "Tên ca làm";
            dgvViewCaLam.Columns[2].HeaderText = "Giờ bắt đầu";
            dgvViewCaLam.Columns[3].HeaderText = "Giờ kết thúc";
            dgvViewCaLam.Columns[3].HeaderText = "Phụ cấp ca làm";
        }
        public bool Check()
        {
            if (txtDiaChi.Text.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return false;
            }
            if (CheckCCCD(txtCCCD.Text) == false)
            {
                return false;
            }
            if (CheckSDT(txtSDT.Text) == false)
            {
                return false;
            }
            if (txtTenNV.Text.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                return false;
            }
            if (txtTenTk.Text.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return false;
            }
            else if (BLL_DN.Instance.CheckTenTK(txtTenTk.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng nhập tên tài khoản khác");
                return false;
            }
            if (txtMk.Text.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return false;
            }
            if (listCaLam.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ca làm");
                return false;
            }
            if (rdbNam.Checked == true || rdbNu.Checked == true)
            {
                return true;
            }
            else return false;
            return true;
        }
        public bool CheckSDT(string sdt)
        {
            if (sdt.Trim() == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại cho nhà cung ứng. Vui lòng nhập số điện thoại cho nhà cung ứng!");
                return false;
            }
            if (sdt.Trim().Length != 10)
            {
                MessageBox.Show("Vui lòng chỉ nhập số điện thoại có 10 chữ số!");
                return false;
            }
            if (sdt.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng không được bỏ trống số điện thoại!");
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
        public bool CheckCCCD(string cccd)
        {
            if (cccd.Trim() == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập Căn cước công dân cho nhà cung ứng. Vui lòng nhập Căn cước công dân!");
                return false;
            }
            if (cccd.Trim().Length != 12)
            {
                MessageBox.Show("Vui lòng chỉ nhập số Căn cước công dân có 12 chữ số!");
                return false;
            }
            if (cccd.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng không được bỏ trống Căn cước công dân!");
                return false;
            }
            else
            {
                long sdtcheck;
                if (Int64.TryParse(cccd, out sdtcheck) == false)
                {
                    MessageBox.Show("Căn cước công dân không đúng định dạng");
                    return false;
                }
            }
            return true;

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            foreach (DTO.CaLam item in listCaLam)
            {
                if (item.TenCaLam == cbbCaLam.Text.ToString())
                {
                    MessageBox.Show("Ca làm đã tồn tại");
                    return;
                }
            }
            listCaLam.Add(BLL_CaLam.Instance.GetListCaLamByTenCaLam(cbbCaLam.Text.ToString())[0]);
            dgvViewCaLam.DataSource = null;
            dgvViewCaLam.DataSource = listCaLam;
            show();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvViewCaLam.SelectedRows.Count == 1)
            {
                listCaLam.RemoveAt(dgvViewCaLam.SelectedRows[0].Index);
                dgvViewCaLam.DataSource = null;
                dgvViewCaLam.DataSource = listCaLam;
                show();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 ca làm");
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo nhân viên mới không ?", "Xác nhận tạo", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {

                if (Check())
                {
                    string tt;
                    string maCV;
                    if (cbbTinhTrang.SelectedIndex == 0)
                    {
                        tt = "Hoạt động";
                    }
                    else tt = "Tạm ngưng";
                    if (cbbChucVu.SelectedIndex == 0)
                    {
                        maCV = "CV000";
                    }
                    else if (cbbChucVu.SelectedIndex == 1)
                    {
                        maCV = "CV001";
                    }
                    else maCV = "CV002";
                    NhanVien s = new NhanVien
                    {
                        MaNhanVien = "",
                        TenNhanVien = txtTenNV.Text,
                        DiaChi = txtDiaChi.Text,
                        GioiTinh = Convert.ToBoolean(rdbNam.Checked),
                        NgaySinh = dtp_NS.Value,
                        SoCanCuocCongDan = txtCCCD.Text,
                        SoDienThoai = txtSDT.Text,
                        TinhTrang = tt,
                        MaChucVu = maCV,
                    };
                    BLL_NV.Instance.AddNV(s);
                    TaiKhoan tk = new TaiKhoan
                    {
                        TenTaiKhoan = txtTenTk.Text,
                        MatKhau = txtMk.Text,
                        MaNhanVien = BLL_NV.Instance.GetLastestNV().MaNhanVien,
                    };
                    BLL_DN.Instance.AddTaiKhoan(tk);
                    foreach (CaLam i in listCaLam)
                    {
                        CTCaLam ctcl = new CTCaLam
                        {
                            MaCaLam = i.MaCaLam,
                            MaNhanVien = tk.MaNhanVien,
                            TrangThai = "Đang làm việc"
                        };
                        DAL_CaLam.Instance.ThemChiTietCaLam(ctcl);
                    }
                    MessageBox.Show("Thêm nhân viên thành công");
                    d();
                    this.Dispose();
                }
            }
        }
    }
}