using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class KhuTrungBay
    {
        public string MaKhuTrungBay { get; set; }
        public string TenKhuTrungBay { get; set; }
        public short SoLuongToiDa { get; set; }
        //public virtual List<HangHoa> HangHoa { get; set; }
        public KhuTrungBay()
        {

        }
        public KhuTrungBay(string makhutrungbay, string tenkhutrungbay, short soluongtoida)
        {
            this.MaKhuTrungBay = makhutrungbay;
            this.TenKhuTrungBay = tenkhutrungbay;
            this.SoLuongToiDa = soluongtoida;
        }
    }
}