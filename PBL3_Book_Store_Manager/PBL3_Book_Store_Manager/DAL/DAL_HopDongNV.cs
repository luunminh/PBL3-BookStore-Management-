using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_HopDongNV
    {
        private static DAL_HopDongNV _Instance;
        public static DAL_HopDongNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HopDongNV();
                }
                return _Instance;
            }
            private set { }
        }
        public List<HopDongNV> GetAllListHopDongNV()
        {
            List<HopDongNV> data = new List<HopDongNV>();
            string query = "select * from HOPDONGNHANVIEN";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(new HopDongNV
                {
                    MaHopDongNV = i["MaHopDongNV"].ToString(),
                    MaNhanVien = i["MaNhanVien"].ToString(),
                    NgayKy = Convert.ToDateTime(i["NgayKy"]),
                    HinhAnh = (byte[])(i["HinhAnh"])

                });
            }
            return data;
        }
        public void AddHopDongNV(HopDongNV s)
        {
            string query = "INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES (@MaNhanVien,@NgayKy,@HinhAnh)";
            DBHelper.Instance.CommandNV(s, query);
        }
    }
}