using PBL3_Book_Store_Manager.BLL;
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
    public partial class ChiTietHopDongNV : Form
    {
        string MaHopDong { get; set; }
        public ChiTietHopDongNV(string maHD)
        {
            InitializeComponent();
            MaHopDong = maHD;
            SetGUI();
        }
        public void SetGUI()
        {
            txtMaNV.Text = BLL_HopDongNV.Instance.GetHopDongNVByMaHD(MaHopDong).MaNhanVien;
            txtTenNV.Text = BLL_HopDongNV.Instance.GetHopDongNVViewByMaHD(MaHopDong).MaNhanVien;
            dtpNgayKy.Value = BLL_HopDongNV.Instance.GetHopDongNVViewByMaHD(MaHopDong).NgayKy;
           // dtp_KetThuc.Value = BLL_HopDongNCU.Instance.GetHopDongNCUViewByMaHD(MaHopDong).NgayKetThuc;
            pictureBox1.Image = BLL_HopDongNV.Instance.ByteArrayToImage((BLL_HopDongNV.Instance.GetHopDongNVViewByMaHD(MaHopDong).HinhAnh));
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
