using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class ChiTietDeXuatHH
    {
        public string MaDeXuat { get; set; }
        public string MaHangHoa { get; set; }
        public string MaThamChieu { get; set; }
        public ChiTietDeXuatHH()
        {

        }
        public ChiTietDeXuatHH(string MaDeXuat, string MaHangHoa, string MaThamChieu)
        {
            this.MaDeXuat = MaDeXuat;
            this.MaHangHoa = MaHangHoa;
            this.MaThamChieu = MaThamChieu;
        }
    }
}