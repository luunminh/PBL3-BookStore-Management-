using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class TheLoaiSach
    {
        public string MaTheLoaiSach { get; set; }
        public string TenTheLoaiSach { get; set; }
        public TheLoaiSach()
        {
        }
        public TheLoaiSach(string TenTheLoaiSach)
        {
            this.TenTheLoaiSach = TenTheLoaiSach;
        }
        public TheLoaiSach(string MaTheLoaiSach, string TenTheLoaiSach)
        {
            this.MaTheLoaiSach = MaTheLoaiSach;
            this.TenTheLoaiSach = TenTheLoaiSach;
        }
    }
}
