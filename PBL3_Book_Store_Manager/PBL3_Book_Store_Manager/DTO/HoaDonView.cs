using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class HoaDonView
    {
        public string MaHoaDon { get; set; }
        public DateTime ThoiGian { get; set; }
        public string TenNhanVien { get; set; }

        public Decimal TongTien { get; set; }

        //public HoaDonView(string maHD, DateTime tg,string nameNV)
        //{
        //    MaHoaDon = maHD;
        //    ThoiGian = tg;
        //    TenNhanVien = nameNV;
        //}
    }
}
