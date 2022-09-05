using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class TheLoaiHangHoa
    {
        public string MaTheLoaiHangHoa { get; set; }
        public string TenTheLoaiHangHoa { get; set; }
        //public virtual List<HangHoa> HangHoa { get; set; }

        public TheLoaiHangHoa()
        {

        }
        public TheLoaiHangHoa(string TenTheLoaiHangHoa)
        {
            this.TenTheLoaiHangHoa = TenTheLoaiHangHoa;
        }
        public TheLoaiHangHoa(string MaTheLoaiHangHoa, string TenTheLoaiHangHoa)
        {
            this.MaTheLoaiHangHoa = MaTheLoaiHangHoa;
            this.TenTheLoaiHangHoa = TenTheLoaiHangHoa;
        }
    }

}