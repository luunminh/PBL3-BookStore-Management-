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
    public partial class ChiTietHopDong_NCU : Form
    {
        string MaHopDong { get; set; }
        public ChiTietHopDong_NCU(string maHopDong)
        {
            InitializeComponent();
            MaHopDong = maHopDong;
            SetGUI();
        }
        public void SetGUI()
        {
            txtTenNCU.Text = BLL_HopDongNCU.Instance.GetHopDongNCUViewByMaHD(MaHopDong).MaNhaCungUng;
            dtp_BatDau.Value = BLL_HopDongNCU.Instance.GetHopDongNCUViewByMaHD(MaHopDong).NgayBatDau;
            dtp_KetThuc.Value = BLL_HopDongNCU.Instance.GetHopDongNCUViewByMaHD(MaHopDong).NgayKetThuc;
            pictureBox1.Image = BLL_HopDongNCU.Instance.ByteArrayToImage((BLL_HopDongNCU.Instance.GetHopDongNCUViewByMaHD(MaHopDong).HinhAnh));
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
