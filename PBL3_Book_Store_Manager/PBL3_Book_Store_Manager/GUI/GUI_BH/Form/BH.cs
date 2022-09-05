using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.GUI.GUI__AD.UC_Control;
using PBL3_Book_Store_Manager.GUI__AD.UC_Control;
using PBL3_Book_Store_Manager.GUI_BH.UC_Control;
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
    public partial class BH : Form
    {
        string BH_TenTaiKhoan = "", BH_MatKhau = "", BH_MaNhanVien = "", BH_MaChucVu = "";
        public BH(string TenTaiKhoan, string MatKhau, string MaNhanVien, string MaChucVu)
        {

            InitializeComponent();
            this.BH_TenTaiKhoan = TenTaiKhoan;
            this.BH_MatKhau = MatKhau;
            this.BH_MaNhanVien = MaNhanVien;
            this.BH_MaChucVu = MaChucVu;
            lbTenNV.Text = BLL_NV.Instance.GetNVByMaNV(BH_MaNhanVien).TenNhanVien.ToString();

        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btHome_HH_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHome_HH);
            UC_TabHH uchh = new UC_TabHH(BH_MaNhanVien);
            AddControlsToPanel(uchh);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btHome_HoaDon_Click(object sender, EventArgs e)
        {
            moveSidePanel((btHome_HoaDon));
            UC_HoaDonBH hd = new UC_HoaDonBH(BH_MaNhanVien);
            AddControlsToPanel(hd);
        }

        private void btHome_KM_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHome_KM);
            UC_BHKhuyenMai km = new UC_BHKhuyenMai();
            AddControlsToPanel(km);
        }

        private void btHome_DeXuat_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHome_DeXuat);
            UC_DeXuat ph = new UC_DeXuat(BH_MaChucVu);
            AddControlsToPanel(ph);
        }

        private void btChiTietNV_Click(object sender, EventArgs e)
        {
            GUI.GUI_Form.ChiTIetNV chiTietNV = new GUI.GUI_Form.ChiTIetNV(BH_MaNhanVien,BH_MaChucVu);
            chiTietNV.d += new GUI.GUI_Form.ChiTIetNV.MyDel(setLabelName);
            chiTietNV.ShowDialog();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void setLabelName()
        {
            lbTenNV.Text = BLL_NV.Instance.GetNVByMaNV(BH_MaNhanVien).TenNhanVien.ToString();
        }
    }
}
