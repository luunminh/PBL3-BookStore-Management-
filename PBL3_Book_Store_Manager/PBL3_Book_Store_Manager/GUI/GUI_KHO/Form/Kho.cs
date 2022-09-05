using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.GUI.GUI__AD.UC_Control;
using PBL3_Book_Store_Manager.GUI.GUI_Form;
using PBL3_Book_Store_Manager.GUI_BH.UC_Control;
using PBL3_Book_Store_Manager.GUI_Form;
using PBL3_Book_Store_Manager.GUI_KHO.UC_Control;
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
    public partial class Kho : Form
    {
        string Kho_TenTaiKhoan = "", Kho_MatKhau = "", Kho_MaNhanVien = "", Kho_MaChucVu = "";
        public Kho(string TenTaiKhoan, string MatKhau, string MaNhanVien, string MaChucVu)
        {
            InitializeComponent();
            this.Kho_TenTaiKhoan = TenTaiKhoan;
            this.Kho_MatKhau = MatKhau;
            this.Kho_MaNhanVien = MaNhanVien;
            this.Kho_MaChucVu = MaChucVu;
            lbTenNV.Text = BLL_NV.Instance.GetNVByMaNV(Kho_MaNhanVien).TenNhanVien.ToString();
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

        private void btDeXuat_Click(object sender, EventArgs e)
        {
            moveSidePanel(btDeXuat);
            UC_DeXuat ph = new UC_DeXuat(Kho_MaChucVu);
            AddControlsToPanel(ph);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            moveSidePanel(btHoaDon);
            UC_TabKhoHoaDon hd = new UC_TabKhoHoaDon();
            AddControlsToPanel(hd);
        }

        private void btKho_NCU_Click(object sender, EventArgs e)
        {
            moveSidePanel(btKho_NCU);
            UC_KhoNCU ncu = new UC_KhoNCU(Kho_MaChucVu, Kho_MaNhanVien);
            AddControlsToPanel(ncu);
        }

        private void btKho_HH_Click(object sender, EventArgs e)
        {
            moveSidePanel(btKho_HH);
            UC_TabKhoHH ke = new UC_TabKhoHH(Kho_MaNhanVien);
            AddControlsToPanel(ke);
        }

        private void btChiTietNV_Click(object sender, EventArgs e)
        {
            ChiTIetNV chiTietNV = new ChiTIetNV(Kho_MaNhanVien,Kho_MaChucVu);
            chiTietNV.d += new ChiTIetNV.MyDel(setLabelName);
            chiTietNV.ShowDialog();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void setLabelName()
        {
            lbTenNV.Text = BLL_NV.Instance.GetNVByMaNV(Kho_MaNhanVien).TenNhanVien.ToString();
        }
    }
}
