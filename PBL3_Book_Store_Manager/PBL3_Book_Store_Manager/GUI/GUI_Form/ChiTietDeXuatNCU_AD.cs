using PBL3_Book_Store_Manager.BLL;
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
    public partial class ChiTietDeXuatNCU_AD : Form
    {
        public string MaNV;
        public delegate void MyDel();
        public MyDel d { get; set; }
        string MaDeXuat { get; set; }
        public ChiTietDeXuatNCU_AD(string maDX)
        {
            InitializeComponent();
            MaDeXuat = maDX;
            CheckLoaiDeXuat();
        }

        public bool CheckPH()
        {
            if (BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(MaDeXuat) != null)  //co
            {
                txtPhanHoi.Enabled = false;
                return true;
            }
            else                          //chua co phan hoi
            {
                txtPhanHoi.Enabled = true;
                return false;
            }
        }

        public bool CheckLoaiDeXuat()
        {
            if(BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).LoaiDeXuat.Trim() == "Đề xuất thêm nhà cung ứng")   //them
            {
                setGUIThem();
                return true;
                
            } 
            else     //cap nhat
            {
                setGUISua();
                return false;
            } 
                
        }

        public void setGUIThem()
        {
            txtMaNhanVien.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).MaNhanVien;
            txtTenNV.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).MaNhanVien;
            txtThoiGian.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).ThoiGian.ToString();
            txtLoaiDeXuat.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).LoaiDeXuat.ToString();
            if (CheckPH())
            {
                txtPhanHoi.Text = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(MaDeXuat).NoiDung;
            }
            txtTrangThai.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).TinhTrang;
            txtTenNCU.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).TenNhaCungUng;
            txtSDT.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).SoDienThoai;
            txtDiaChi.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).DiaChi;
            txtDaiDienKD.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).TenNguoiDaiDienKinhDoanh;
            txtDaiDienPhapLy.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng).TenNguoiDaiDienPhapLy;
        }

        public void setGUISua()
        {
            txtMaNhanVien.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).MaNhanVien;
            txtTenNV.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).MaNhanVien;
            txtThoiGian.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).ThoiGian.ToString();
            txtLoaiDeXuat.Text = BLL_DeXuat.Instance.GetDeXuatViewByMaDeXuat(MaDeXuat).LoaiDeXuat.ToString();
            if (CheckPH())
            {
                txtPhanHoi.Text = BLL_DeXuat.Instance.GetListPhanHoiByMaDeXuat(MaDeXuat).NoiDung;
            }
            txtTrangThai.Text = BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(MaDeXuat).TinhTrang;
            txtTenNCU.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).TenNhaCungUng;
            txtSDT.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).SoDienThoai;
            txtDiaChi.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).DiaChi;
            txtDaiDienKD.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).TenNguoiDaiDienKinhDoanh;
            txtDaiDienPhapLy.Text = BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu).TenNguoiDaiDienPhapLy;
        }

        private void bt_QuayLai_ChiTietDeXuatHoaDonNhapKho_AD_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btXetDuyet_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận xét duyệt đề xuất không ?", "Xác nhận ", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if(CheckLoaiDeXuat() == true)             //de xuat them 
                {
                    if (!CheckPH())
                    {
                        if (txtPhanHoi.Text.Replace(" ", "").Trim() == "")
                        {
                            MessageBox.Show("Vui lòng phản hồi lại cho đề xuất này");
                        }
                        else
                        {
                            PhanHoi news = new PhanHoi()
                            {
                                MaDeXuat = MaDeXuat,
                                MaNhanVien = txtMaNhanVien.Text,
                                MaPhanHoi = "",
                                NoiDung = txtPhanHoi.Text,
                                ThoiGian = DateTime.Now
                            };
                            BLL_DeXuat.Instance.AddPhanHoi(news);
                            BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL("Chấp nhận", MaDeXuat);
                            BLL_NCU.Instance.UpdateTrangThaiNCU_BLL(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng);

                            //THAY ĐỔI TÌNH TRẠNG CỦA HÀNG HÓA SAU KHI MERGE HÀNG HÓA VÀO
                            MessageBox.Show("Xét duyệt đề xuất thành công");
                            d();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã cập nhật tình trạng cho đề xuất này");
                    }
                }else                     //de xuat cap nhat
                {
                    if (!CheckPH())
                    {
                        if (txtPhanHoi.Text.Replace(" ", "").Trim() == "")
                        {
                            MessageBox.Show("Vui lòng phản hồi lại cho đề xuất này");
                        }
                        else
                        {
                            PhanHoi news = new PhanHoi()
                            {
                                MaDeXuat = MaDeXuat,
                                MaNhanVien = txtMaNhanVien.Text,
                                MaPhanHoi = "",
                                NoiDung = txtPhanHoi.Text,
                                ThoiGian = DateTime.Now
                            };
                            BLL_DeXuat.Instance.AddPhanHoi(news);
                            BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL("Chấp nhận", MaDeXuat);
                            BLL_NCU.Instance.UpdateNCU(BLL_NCU.Instance.GetNCUByMaNCUKhongTrangThai(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu), BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaNhaCungUng);
                           // BLL_NCU.Instance.DeleteNCU(BLL_DeXuat.Instance.GetChiTietDeXuatNCUByMaDX(MaDeXuat).MaThamChieu);
                            //THAY ĐỔI TÌNH TRẠNG CỦA HÀNG HÓA SAU KHI MERGE HÀNG HÓA VÀO
                            MessageBox.Show("Xét duyệt đề xuất thành công");
                            d();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã cập nhật tình trạng cho đề xuất này");
                    }
                }

            }
        }

        private void btTuChoiDX_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận từ chối đề xuất không ?", "Xác nhận ", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                if (!CheckPH())
                {
                    if (txtPhanHoi.Text.Replace(" ", "").Trim() == "")
                    {
                        MessageBox.Show("Vui lòng phản hồi lại cho đề xuất này");
                    }
                    else
                    {
                        PhanHoi news = new PhanHoi()
                        {
                            MaDeXuat = MaDeXuat,
                            MaNhanVien = txtMaNhanVien.Text,
                            MaPhanHoi = "",
                            NoiDung = txtPhanHoi.Text,
                            ThoiGian = DateTime.Now
                        };
                        BLL_DeXuat.Instance.AddPhanHoi(news);
                        BLL_DeXuat.Instance.UpdateTrangThaiDX_BLL("Không chấp nhận", MaDeXuat);
                        MessageBox.Show("Xét duyệt đề xuất thành công");
                        d();
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Bạn đã cập nhật tình trạng cho đề xuất này");
                }

            }
        }
    }
}
