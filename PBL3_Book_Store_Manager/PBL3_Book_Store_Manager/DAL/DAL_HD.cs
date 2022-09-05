using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_HD
    {
        private static DAL_HD _Instance;
        public static DAL_HD Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HD();
                }
                return _Instance;
            }
            private set { }
        }
        public List<HoaDon> getListHDBH(string query)
        {
            List<HoaDon> data = new List<HoaDon>();

            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetHDBH(i));
            }
            return data;
        }
        public HoaDon GetHDBH(DataRow i)
        {
            return new HoaDon
            {
                MaHoaDon = i["MaHoaDon"].ToString(),
                ThoiGian = Convert.ToDateTime(i["ThoiGian"].ToString()),
                MaNhanVien = i["MaNhanVien"].ToString(),
                TongTien = Convert.ToDecimal(i["TongTien"].ToString())
            };
        }
        public List<ChiTietHD> GetListChiTietHD(string query)
        {
            List<ChiTietHD> data = new List<ChiTietHD>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetChiTietHD(i));
            }
            return data;
        }
        public ChiTietHD GetChiTietHD(DataRow i)
        {
            return new ChiTietHD
            {
                MaHoaDon = i["MaHoaDon"].ToString(),
                MaHangHoa = i["MaHangHoa"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),

            };
        }
        public void AddHD_DAL(HoaDon hd)
        {
            string query = "insert into HOADON (ThoiGian, MaNhanVien,TongTien) values ('" + hd.ThoiGian + "','" + hd.MaNhanVien + "', '" + hd.TongTien + "')";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddCTHD_DAL(ChiTietHD dt)
        {
            string query = "insert into CHITIETHOADON values ('" + dt.MaHoaDon + "','" + dt.MaHangHoa + "','" + dt.SoLuong + "')";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}