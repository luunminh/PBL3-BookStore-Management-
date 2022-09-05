using _3Layers.DTO;
using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.GUI_Form
{
    public partial class ThemHopDongNV : Form
    {
        public delegate void MyDell();
        public MyDell d { get; set; }
        public ThemHopDongNV()
        {
            InitializeComponent();
            cbbNV.Items.Clear();
            cbbNV.Items.AddRange(BLL_NV.Instance.GetCBB().ToArray());
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btThemAnh_Click(object sender, EventArgs e)
        {
            ofdOpenFile.Title = "Chọn ảnh";
            ofdOpenFile.Filter = "Image files (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)";
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofdOpenFile.FileName;
            }
        }

        public bool Check()
        {
            if (cbbNV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                return false;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh");
                return false;
            }
            return true;



        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo mới hợp đồng không ?", "Xác nhận thêm", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (Check())
                {
                    HopDongNV s = new HopDongNV
                    {
                        MaHopDongNV = "",
                        MaNhanVien = ((CBBItems)(cbbNV.SelectedItem)).Value,
                        NgayKy = dtp_NgayKyKet.Value,
                        HinhAnh = ChuyenAnhThanhMangByte(pictureBox1)
                    };
                    //richTextBox1.Text = Convert.ToBase64String(ChuyenAnhThanhMangByte(pictureBox1));
                    //MessageBox.Show(Convert.ToBase64String(ChuyenAnhThanhMangByte(pictureBox1)));
                    BLL_HopDongNV.Instance.AddHopDongNV(s);
                    d();
                    MessageBox.Show("Thêm hợp đồng thành công");
                    this.Dispose();
                }
            }
        }

        public byte[] ChuyenAnhThanhMangByte(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
    }
}
