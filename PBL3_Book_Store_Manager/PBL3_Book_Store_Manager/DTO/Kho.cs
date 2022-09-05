using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class Kho
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string TrangThai { get; set; }
        //public virtual List<HangHoa> HangHoa { get; set; }
        public Kho(string makho, string tenkho, string trangthai)
        {
            this.MaKho = makho;
            this.TenKho = tenkho;
            this.TrangThai = trangthai;
        }

        public Kho()
        {
        }
    }
}