using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.BLL;
namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_ChiTietDeXuatHoaDonNhapKho
    {
        private static DAL_ChiTietDeXuatHoaDonNhapKho _Instance;
        public static DAL_ChiTietDeXuatHoaDonNhapKho Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ChiTietDeXuatHoaDonNhapKho();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_ChiTietDeXuatHoaDonNhapKho()
        {
        }
        public string MaHangHoa { get; set; }
        public string MaDeXuat { get; set; }
        public int SoLuong { get; set; }
        public ChiTietDeXuatHoaDonNhapKho GetChiTietDeXuatHoaDonNhapKho(DataRow i)
        {
            return new ChiTietDeXuatHoaDonNhapKho
            {
                MaHangHoa = i["MaHangHoa"].ToString(),
                MaDeXuat = i["MaDeXuat"].ToString(),
                SoLuong = Convert.ToInt16(i["SoLuong"].ToString()),

            };
        }
        public List<ChiTietDeXuatHoaDonNhapKho> GetListChiTietDeXuatHoaDonNhapKho_DAL()
        {
            string query = "Select * from CHITIETDEXUATHOADON";
            List<ChiTietDeXuatHoaDonNhapKho> list = new List<ChiTietDeXuatHoaDonNhapKho>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetChiTietDeXuatHoaDonNhapKho(i));
            }
            return list;
        }
    }
}