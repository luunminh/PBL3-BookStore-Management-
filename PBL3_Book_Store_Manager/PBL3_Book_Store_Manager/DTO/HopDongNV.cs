using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class HopDongNV
    {
        public string MaHopDongNV { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayKy { get; set; }
        public byte [] HinhAnh { get; set; }
    }
}
