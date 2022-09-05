using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
	public class KhuyenMai
	{

		public string MaKhuyenMai { get; set; }
		public string TenChuongTrinhKhuyenMai { get; set; }
		public string MaHangHoa { get; set; }
		public int PhanTramKhuyenMai { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
	}
}