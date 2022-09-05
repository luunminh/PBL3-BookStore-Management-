using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DTO;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_KhuTrungBay
    {
        private static DAL_KhuTrungBay _Instance;
        public static DAL_KhuTrungBay Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_KhuTrungBay();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.KhuTrungBay> getListKhuTrungBay()
        {
            List<DTO.KhuTrungBay> KhuTrungBay = new List<DTO.KhuTrungBay>();
            string query = "Select * from KHUTRUNGBAY;";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaKhuTrungBay = item["MaKhuTrungBay"].ToString();
                string TenKhuTrungBay = item["TenKhuTrungBay"].ToString();
                short SoLuongToiDa = (short)item["SoLuongToiDa"];

                DTO.KhuTrungBay newKhuTrungBay = new DTO.KhuTrungBay(MaKhuTrungBay, TenKhuTrungBay, SoLuongToiDa);
                KhuTrungBay.Add(newKhuTrungBay);
            }
            return KhuTrungBay;
        }
        public List<DTO.KhuTrungBay> getListKhuTrungBay(string ThuocTinh, string TimKiem)
        {
            List<DTO.KhuTrungBay> KhuTrungBay = new List<DTO.KhuTrungBay>();
            string query = "Select * from KHUTRUNGBAY WHERE " + @ThuocTinh + " = N'" + @TimKiem + "';";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaKhuTrungBay = item["MaKhuTrungBay"].ToString();
                string TenKhuTrungBay = item["TenKhuTrungBay"].ToString();
                short SoLuongToiDa = (short)item["SoLuongToiDa"];

                DTO.KhuTrungBay newKhuTrungBay = new DTO.KhuTrungBay(MaKhuTrungBay, TenKhuTrungBay, SoLuongToiDa);
                KhuTrungBay.Add(newKhuTrungBay);
            }
            return KhuTrungBay;
        }
        public void ThemKhuTrungBay(DTO.KhuTrungBay KhuTrungBay)
        {
            string query = "INSERT INTO KHUTRUNGBAY (TenKhuTrungBay, SoLuongToiDa) VALUES(N'" + @KhuTrungBay.TenKhuTrungBay + "', " + @KhuTrungBay.SoLuongToiDa + ");";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void CapNhatKhuTrungBay(DTO.KhuTrungBay KhuTrungBay)
        {
            string query = "UPDATE KHUTRUNGBAY SET TenKhuTrungBay = N'" + @KhuTrungBay.TenKhuTrungBay + "', SoLuongToiDa = " + @KhuTrungBay.SoLuongToiDa + " WHERE MaKhuTrungBay = N'" + @KhuTrungBay.MaKhuTrungBay + "';";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}