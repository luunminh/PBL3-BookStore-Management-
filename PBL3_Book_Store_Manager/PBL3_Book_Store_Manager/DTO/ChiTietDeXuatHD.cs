using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class ChiTietDeXuatHD
    {
        public string MaDeXuat { get; set; }
        public string MaHangHoa { get; set; }
        public short SoLuong { get; set; }
        public ChiTietDeXuatHD()
        {

        }
        public ChiTietDeXuatHD(string MaDeXuat, string MaHangHoa, short SoLuong)
        {
            this.MaDeXuat = MaDeXuat;
            this.MaHangHoa = MaHangHoa;
            this.SoLuong = SoLuong;
        }
    }
}
