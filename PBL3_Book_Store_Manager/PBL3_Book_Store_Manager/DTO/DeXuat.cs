using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class DeXuat
    {
        public string MaDeXuat { get; set; }
        public string MaNhanVien { get; set; }
        public string TinhTrang { get; set; }
        public string LoaiDeXuat { get; set; }
        public DateTime ThoiGian { get; set; }

        public DeXuat(string MaDeXuat, string MaNhanVien, string TinhTrang, string LoaiDeXuat, DateTime ThoiGian)
        {
            this.MaDeXuat = MaDeXuat;
            this.MaNhanVien = MaNhanVien;
            this.TinhTrang = TinhTrang;
            this.LoaiDeXuat = LoaiDeXuat;
            this.ThoiGian = ThoiGian;
        }
        public DeXuat(string MaNhanVien, string TinhTrang, string LoaiDeXuat, DateTime ThoiGian)
        {
            this.MaNhanVien = MaNhanVien;
            this.TinhTrang = TinhTrang;
            this.LoaiDeXuat = LoaiDeXuat;
            this.ThoiGian = ThoiGian;
        }
        public DeXuat()
        {

        }
    }
}
