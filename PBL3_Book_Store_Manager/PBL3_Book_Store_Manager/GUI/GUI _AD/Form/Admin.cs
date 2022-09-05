using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.GUI.GUI__AD.UC_Control;
using PBL3_Book_Store_Manager.GUI.GUI_Form;
using PBL3_Book_Store_Manager.GUI__AD.UC_Control;
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

namespace PBL3_Book_Store_Manager
{
    public partial class Admin : Form
    {
        string Admin_TenTaiKhoan = "", Admin_MatKhau = "", Admin_MaNhanVien = "", Admin_MaChucVu = "";
        public Admin(string TenTaiKhoan, string MatKhau, string MaNhanVien, string MaChucVu)
        {
            InitializeComponent();
            this.Admin_TenTaiKhoan = TenTaiKhoan;
            this.Admin_MatKhau = MatKhau;
            this.Admin_MaNhanVien = MaNhanVien;
            this.Admin_MaChucVu = MaChucVu;
            lbTenNV.Text = BLL_NV.Instance.GetNVByMaNV(Admin_MaNhanVien).TenNhanVien.ToString();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btHomeHH_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHomeHH);
            UC_TabHH uchh = new UC_TabHH(Admin_MaNhanVien);
            AddControlsToPanel(uchh);
        }

        private void bttHome_NV_Click(object sender, EventArgs e)
        {
            moveSidePanel(bttHome_NV);
            UC_TabNV ucnv = new UC_TabNV(Admin_MaNhanVien);
            AddControlsToPanel(ucnv);
        }

        private void btHome_ThongKe_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHome_ThongKe);
            UC_TabTK uctt = new UC_TabTK();
            AddControlsToPanel(uctt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btHome_NCU_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHome_NCU);
            UC_NCU ucncu = new UC_NCU(Admin_MaChucVu);
            AddControlsToPanel(ucncu);
        }

        private void btDeXuat_Click(object sender, EventArgs e)
        {
            moveSidePanel(btDeXuat);
            UC_DeXuat ucdx = new UC_DeXuat(Admin_MaChucVu);
            AddControlsToPanel(ucdx);
        }

        private void btHome_KhuyenMai_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHome_KhuyenMai);
            UC_KhuyenMai uckm = new UC_KhuyenMai();
            AddControlsToPanel(uckm);
        }

        private void btHome_HopDong_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHome_HopDong);
            UC_TabHopDong hd = new UC_TabHopDong();
            AddControlsToPanel(hd);
        }

        private void btChiTietNV_Click(object sender, EventArgs e)
        {
            ChiTIetNV chiTietNV = new ChiTIetNV(Admin_MaNhanVien,Admin_MaChucVu);
            chiTietNV.d += new ChiTIetNV.MyDel(setLabelName);
            chiTietNV.ShowDialog();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void setLabelName ()
        {
            lbTenNV.Text = BLL_NV.Instance.GetNVByMaNV(Admin_MaNhanVien).TenNhanVien.ToString();
        }
    }
}
