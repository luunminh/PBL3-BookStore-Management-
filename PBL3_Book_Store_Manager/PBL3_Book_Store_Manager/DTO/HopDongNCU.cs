using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class HopDongNCU
    {
        public string MaHopDongNCU { get; set; }

        public string MaNhaCungUng { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public byte[] HinhAnh { get; set; }

    }
}
