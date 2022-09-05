using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class TTHangHoa
    {
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set;}
        public short SoLuong { get; set; }
        public decimal GiaBan {get; set;}
        public decimal GiaNhap { get; set;}
        public decimal Discount { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
