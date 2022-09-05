using _3Layers.DTO;
using PBL3_Book_Store_Manager.BLL;
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

namespace PBL3_Book_Store_Manager.GUI.GUI_Form
{
    public partial class ThemHopDongNCU : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        public ThemHopDongNCU()
        {
            InitializeComponent();
            cbbTenNCU.Items.Clear();
            cbbTenNCU.Items.AddRange(BLL_NCU.Instance.GetCBB().ToArray());
        }

        private void btThemAnh_Click(object sender, EventArgs e)
        {
            ofdOpenFile.Title = "Chọn ảnh";
            ofdOpenFile.Filter = "Image files (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)";
            if(ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofdOpenFile.FileName;
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool Check()
        {
            if (cbbTenNCU.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung ứng");
                return false;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh");
                return false;
            }
            if(dtp_BatDau.Value == dtp_KetThuc.Value)
            {
                MessageBox.Show("Vui lòng ngày bắt đầu không được trùng với ngày kết thúc");
                return false;
            }
            return true;



        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận tạo mới hợp đồng không ?","Xác nhận thêm", MessageBoxButtons.YesNo);
            if(results == DialogResult.Yes)
            {
                if (Check())
                {
                    HopDongNCU s = new HopDongNCU
                    {
                        MaHopDongNCU = "",
                        MaNhaCungUng = ((CBBItems)(cbbTenNCU.SelectedItem)).Value,
                        NgayBatDau = dtp_BatDau.Value,
                        NgayKetThuc = dtp_KetThuc.Value,
                        HinhAnh = ChuyenAnhThanhMangByte(pictureBox1)
                    };
                    //richTextBox1.Text = Convert.ToBase64String(ChuyenAnhThanhMangByte(pictureBox1));
                    //MessageBox.Show(Convert.ToBase64String(ChuyenAnhThanhMangByte(pictureBox1)));
                    BLL_HopDongNCU.Instance.AddHopDongNCU(s);
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
