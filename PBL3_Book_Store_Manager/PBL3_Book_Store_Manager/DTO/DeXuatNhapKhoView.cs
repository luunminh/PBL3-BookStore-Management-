using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class DeXuatNhapKhoView
    {
        public string MaDeXuat { get; set; }
        public string LoaiDeXuat { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime ThoiGian { get; set; }
        public string TinhTrang { get; set; }
    }
}