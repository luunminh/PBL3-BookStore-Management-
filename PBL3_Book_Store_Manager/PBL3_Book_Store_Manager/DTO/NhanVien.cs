using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCanCuocCongDan { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaChucVu { get; set; }
        public string TinhTrang { get; set; }

    }
}
