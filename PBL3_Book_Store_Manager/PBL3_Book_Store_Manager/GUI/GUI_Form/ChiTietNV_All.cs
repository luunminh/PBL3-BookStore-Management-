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
    public partial class ChiTietNV_All : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        string MaNhanVien { get; set; }
        Boolean CheckMaNV { get; set; }
        
        string MaChucVu { get; set; }
        List<DTO.CaLam> listCaLam;
        public ChiTietNV_All(string manhanvien, string maCV,Boolean check)
        {
            InitializeComponent();
            this.MaNhanVien = manhanvien;
            MaChucVu = maCV;
            CheckMaNV = check;
            listCaLam = new List<DTO.CaLam>();
            foreach (DTO.CTCaLam item in BLL_CaLam.Instance.GetListChiTietCaLam_BLLByTrangThai())
                if (item.MaNhanVien == MaNhanVien)
                    listCaLam.Add(BLL_CaLam.Instance.GetCaLamByMaCaLam(item.MaCaLam));
            show();
            if(CheckMaNV )
            {
                LockCbb();
            }    
            CheckChucVu();
        }
        public void LockCbb()
        {
            cbbChucVu.Enabled = false;
            cbbTinhTrang.Enabled = false;
        }

        public void show()
        {
            DTO.NhanVien NhanVien = BLL_NV.Instance.GetNVByMaNV(this.MaNhanVien);
            txtTenNV.Text = NhanVien.TenNhanVien.ToString();
            txtSDT.Text = NhanVien.SoDienThoai.ToString();
            txtDiaChi.Text = NhanVien.DiaChi.ToString();
            txtCCCD.Text = NhanVien.SoCanCuocCongDan.ToString();
            //cbbCaLam.Text = BLL_CaLam.Instance.GetCaLamByMaCaLam(NhanVien.MaNhanVien.ToString()).TenCaLam.ToString();
            dtp_NS.Value = NhanVien.NgaySinh;
            cbbChucVu.Text = BLL_ChucVu.Instance.getChucVu_byMaChucVu(NhanVien.MaChucVu).TenChucVu.ToString();
            //  txtLuong.Text =

            if (NhanVien.GioiTinh == true)
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;

            dgvViewCaLam.DataSource = null;
            dgvViewCaLam.DataSource = listCaLam;
            dgvViewCaLam.Columns["TrangThai"].Visible = false;
            dgvViewCaLam.Columns[0].HeaderText = "Mã ca làm";
            dgvViewCaLam.Columns[1].HeaderText = "Tên ca làm";
            dgvViewCaLam.Columns[2].HeaderText = "Giờ bắt đầu";
            dgvViewCaLam.Columns[3].HeaderText = "Giờ kết thúc";
            dgvViewCaLam.Columns[4].HeaderText = "Phụ cấp ca làm";
            //cbbChucVu.DisplayMember = "TenChucVu";
            // cbbChucVu.DataSource = BLL_ChucVu.Instance.getListChucVu();
            if (BLL_NV.Instance.GetNVByMaNV(MaNhanVien).MaChucVu == "CV000")
            {
                cbbChucVu.SelectedIndex = 0;

            }
            else if (BLL_NV.Instance.GetNVByMaNV(MaNhanVien).MaChucVu == "CV001")
            {
                cbbChucVu.SelectedIndex = 1;
            }
            else if (BLL_NV.Instance.GetNVByMaNV(MaNhanVien).MaChucVu == "CV002")
            {
                cbbChucVu.SelectedIndex = 2;
            }
            if (BLL_NV.Instance.GetNVByMaNV(MaNhanVien).TinhTrang == "Hoạt động")
            {
                cbbTinhTrang.SelectedIndex = 0;
            }
            else cbbTinhTrang.SelectedIndex = 1;

            txtTenTk.Text = DAL_DN.Instance.GetTKByMaNV(MaNhanVien).TenTaiKhoan;
            txtMk.Text = DAL_DN.Instance.GetTKByMaNV(MaNhanVien).MatKhau;



        }


        public bool CheckChucVu()
        {
            if (MaChucVu != "CV000")
            {
                cbbChucVu.Enabled = false;
                txtLuong.Enabled = false;
                cbbTinhTrang.Enabled = false;
                return false;
            }
            else
            {
                return true;
            }

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



            if (txtMk.Text.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return false;
            }
            
            
            //if (listCaLam.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn ca làm");
            //    return false;

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

    

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (CheckChucVu())
            {
                if (dgvViewCaLam.SelectedRows.Count == 1)
                {
                    listCaLam.RemoveAt(dgvViewCaLam.SelectedRows[0].Index);
                    dgvViewCaLam.DataSource = null;
                    dgvViewCaLam.DataSource = listCaLam;
                }
                else
                    MessageBox.Show("Vui lòng chọn 1 ca làm");
            }
        }

        public Boolean CheckChange()
        {
            if(txtTenNV.Text.Trim() != BLL_NV.Instance.GetNVByMaNV(MaNhanVien).TenNhanVien)
            {
                return false;
            }    
            if(txtDiaChi.Text.Trim() != BLL_NV.Instance.GetNVByMaNV(MaNhanVien).DiaChi)
            {
                return false;
            }
            if (txtSDT.Text.Trim() != BLL_NV.Instance.GetNVByMaNV(MaNhanVien).SoDienThoai)
            {
                return false;
            }
            if (txtCCCD.Text.Trim() != BLL_NV.Instance.GetNVByMaNV(MaNhanVien).SoCanCuocCongDan)
            {
                return false;
            }
            if (dtp_NS.Value != BLL_NV.Instance.GetNVByMaNV(MaNhanVien).NgaySinh)
            {
                return false;
            }
            if(txtMk.Text.Trim() != DAL_DN.Instance.GetTKByMaNV(MaNhanVien).MatKhau)
            {
                return false;
            }
            
            if (cbbTinhTrang.SelectedItem.ToString() != BLL_NV.Instance.GetNVByMaNV(MaNhanVien).TinhTrang.Trim())
            {
                return false;
            }
            if (cbbChucVu.SelectedItem.ToString() != BLL_ChucVu.Instance.getChucVu_byMaChucVu(BLL_NV.Instance.GetNVByMaNV(MaNhanVien).MaChucVu).TenChucVu.Trim())
            {
                return false;
            }
            
            if(Convert.ToBoolean(rdbNam.Checked) != BLL_NV.Instance.GetNVByMaNV(MaNhanVien).GioiTinh)
            {
                return false;
            }    
            return true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận cập nhật thông tin nhân viên không ?", "Xác nhận tạo", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if(!CheckChange())
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
                            MaNhanVien = MaNhanVien,
                            TenNhanVien = txtTenNV.Text,
                            DiaChi = txtDiaChi.Text,
                            GioiTinh = Convert.ToBoolean(rdbNam.Checked),
                            NgaySinh = dtp_NS.Value,
                            SoCanCuocCongDan = txtCCCD.Text,
                            SoDienThoai = txtSDT.Text,
                            TinhTrang = tt,
                            MaChucVu = maCV,
                        };
                        TaiKhoan tk = new TaiKhoan
                        {
                            TenTaiKhoan = txtTenTk.Text,
                            MatKhau = txtMk.Text,
                            MaNhanVien = MaNhanVien,
                        };

                        BLL_NV.Instance.UpdateNV(s);
                        BLL_DN.Instance.Update(tk);
                        MessageBox.Show("Cập nhật thành công");
                        //if (CheckMaNV)
                        //{
                        //    MessageBox.Show("Bạn cần đăng nhập lại để hệ thống cập nhật thay đổi");
                        //    Application.Exit();
                        //}
                        this.Close();



                    }
                }    

               



            }
        }

        //private void rdbNu_CheckedChanged(object sender, EventArgs e)
        //{
        //    CheckRdb = true;
        //}
    }
}
