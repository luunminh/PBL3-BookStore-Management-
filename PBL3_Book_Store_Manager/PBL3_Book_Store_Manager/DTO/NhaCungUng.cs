using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class NhaCungUng
    {
        public string MaNhaCungUng { get; set; }
        public string TenNhaCungUng { get; set; }
        public string TenNguoiDaiDienPhapLy { get; set; }
        public string TenNguoiDaiDienKinhDoanh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string TrangThai { get; set; }

        public NhaCungUng(string MaNhaCungUng, string TenNhaCungUng, string TenNguoiDaiDienPhapLy, string TenNguoiDaiDienKinhDoanh, string DiaChi, string SoDienThoai, string TrangThai)
        {
            this.MaNhaCungUng = MaNhaCungUng;
            this.TenNhaCungUng = TenNhaCungUng;
            this.TenNguoiDaiDienPhapLy = TenNguoiDaiDienPhapLy;
            this.TenNguoiDaiDienKinhDoanh = TenNguoiDaiDienKinhDoanh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.TrangThai = TrangThai;
        }
        public NhaCungUng()
        {

        }
    }
}
