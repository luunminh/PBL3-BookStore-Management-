using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.DAL;

namespace PBL3_Book_Store_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {

            TaiKhoan tk = new TaiKhoan();
            tk = DAL_DN.Instance.GetTaiKhoanKhiDangNhap(txtTaiKhoan.Text, txtMk.Text);
            if (tk == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng! Xin vui lòng kiểm tra lại");
            }
            else
            {
                string MaNhanVien = tk.MaNhanVien.ToString();
                // lấy ra mã chức vụ của nhân viên khi đăng nhập để khởi tạo form
                string MaChucVu = BLL_NV.Instance.GetNVByMaNV(MaNhanVien).MaChucVu.ToString();
                string TinhTrang = BLL_NV.Instance.GetNVByMaNV(MaNhanVien).TinhTrang.ToString();

                // admin 
                if (MaChucVu == "CV000")
                {
                    // khởi tạo form Admin và cấp quyền
                    if (TinhTrang.Contains("Hoạt động"))
                    {
                        Admin admin = new Admin(tk.TenTaiKhoan, tk.MatKhau, MaNhanVien, MaChucVu);
                        admin.ShowDialog();
                    }
                    else if (TinhTrang.Contains("Tạm ngưng"))
                    {
                        MessageBox.Show("Tài khoản đã tạm ngưng!");
                    }


                }
                // Nhân viên bán hàng

                if (MaChucVu == "CV001")
                {
                    // khởi tạo form BH và cấp quyền
                    if (TinhTrang == "Hoạt động")
                    {
                        BH bH = new BH(tk.TenTaiKhoan, tk.MatKhau, MaNhanVien, MaChucVu);
                        bH.ShowDialog();
                    }
                    else if (TinhTrang.Contains("Tạm ngưng"))
                    {
                        MessageBox.Show("Tài khoản đã tạm ngưng!");
                    }



                }
                // Nhân viên thủ kho 
                if (MaChucVu == "CV002")
                {
                    // khởi tạo form Kho và cấp quyền
                    if (TinhTrang == "Hoạt động")
                    {
                        Kho kho = new Kho(tk.TenTaiKhoan, tk.MatKhau, MaNhanVien, MaChucVu);
                        kho.ShowDialog();
                    }
                    else if (TinhTrang.Contains("Tạm ngưng"))
                    {
                        MessageBox.Show("Tài khoản đã tạm ngưng!");
                    }

                }
            }


        }

        private void btEye_Click(object sender, EventArgs e)
        {
            if(txtMk.UseSystemPasswordChar == true)
            {
                txtMk.UseSystemPasswordChar = false;

            }    else if(txtMk.UseSystemPasswordChar == false)
            {
                txtMk.UseSystemPasswordChar = true;
            }    
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
