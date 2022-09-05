using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using PBL3_Book_Store_Manager.BLL;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_HopDongNCU
    {
        private static DAL_HopDongNCU _Instance;
        public static DAL_HopDongNCU Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HopDongNCU();
                }
                return _Instance;
            }
            private set { }
        }
        public List<HopDongNCU> GetAllListHopDongNCU()
        {
            List<HopDongNCU> data = new List<HopDongNCU>();
            string query = "select * from HOPDONGNHACUNGUNG";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {

                data.Add(new HopDongNCU
                {
                    MaHopDongNCU = i["MaHopDongNCU"].ToString(),
                    MaNhaCungUng = i["MaNhaCungUng"].ToString(),
                    NgayBatDau = Convert.ToDateTime(i["NgayBatDau"]),
                    NgayKetThuc = Convert.ToDateTime(i["NgayKetThuc"]),
                    HinhAnh = (byte[])(i["HinhAnh"])

                });
            }
            return data;
        }
        public void AddHopDongNCU(HopDongNCU s)
        {
            string query = "INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES (@MaNhaCungUng,@NgayBatDau,@NgayKetThuc,@HinhAnh)";
            DBHelper.Instance.CommandNCU(s, query);
        }
    }
}