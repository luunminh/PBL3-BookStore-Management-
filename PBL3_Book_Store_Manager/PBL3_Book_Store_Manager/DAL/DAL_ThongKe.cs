using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_ThongKe
    {
        private static DAL_ThongKe _Instance;
        public static DAL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ThongKe();
                }
                return _Instance;
            }
            private set { }
        }
        public int GetSoLuongHhBanByTG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select sum(SoLuong) " +
               "from CHITIETHOADON, HOADON where HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon and ThoiGian >= '{0}' and ThoiGian <= '{1}' ", dateFrom, dateTo);
            int SoHH = 0;
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                if (i[0].ToString() != "")
                {
                    SoHH = Convert.ToInt32(i[0]);
                }
            }
            return SoHH;
        }
        public List<HoaDon> GetListHoaDonByTG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            List<HoaDon> data = new List<HoaDon>();
            string query = string.Format("select * from HOADON where  ThoiGian >= '{0}' and ThoiGian <= '{1}' ", dateFrom, dateTo);
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(DAL_HD.Instance.GetHDBH(i));
            }
            return data;
        }
        public List<ChiTietHD> GetListCTHDByTG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            List<ChiTietHD> data = new List<ChiTietHD>();
            string query = string.Format("select CHITIETHOADON.MaHoaDon, MaHangHoa, SoLuong " +
               "from CHITIETHOADON, HOADON where HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon and ThoiGian >= '{0}' and ThoiGian <= '{1}' ", dateFrom, dateTo);
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(DAL_HD.Instance.GetChiTietHD(i));
            }
            return data;
        }
    }
}