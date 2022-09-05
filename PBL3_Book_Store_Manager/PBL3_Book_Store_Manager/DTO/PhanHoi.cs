using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class PhanHoi
    {
        public string MaPhanHoi { get; set; }
        public string MaNhanVien { get; set; }
        public string MaDeXuat { get; set; }
        public DateTime ThoiGian { get; set; }
        public string NoiDung { get; set; }
        public PhanHoi()
        {
        }
        public PhanHoi(string MaNhanVien, string MaDeXuat, DateTime ThoiGian, string NoiDung)
        {
            this.MaNhanVien = MaNhanVien;
            this.MaDeXuat = MaDeXuat;
            this.ThoiGian = ThoiGian;
            this.NoiDung = NoiDung;
        }
    }
}
