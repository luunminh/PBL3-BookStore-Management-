using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DTO;
using System.Data;
namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_KhuyenMai
    {
        private static DAL_KhuyenMai _Instance;
        public static DAL_KhuyenMai Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_KhuyenMai();
                }
                return _Instance;
            }
            private set { }
        }
        public List<KhuyenMai> GetAllListKhuyenMai()
        {
            string query = "select * from KHUYENMAI";
            List<KhuyenMai> list = new List<KhuyenMai>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetKhuyenMai(i));
            }
            return list;
        }
        public KhuyenMai GetKhuyenMai(DataRow i)
        {
            return new KhuyenMai
            {
                MaKhuyenMai = i["MaKhuyenMai"].ToString(),
                TenChuongTrinhKhuyenMai = i["TenChuongTrinhKhuyenMai"].ToString(),
                MaHangHoa = i["MaHangHoa"].ToString(),
                PhanTramKhuyenMai = Convert.ToInt32(i["PhanTramKhuyenMai"].ToString()),
                NgayBatDau = Convert.ToDateTime(i["NgayBatDau"].ToString()),
                NgayKetThuc = Convert.ToDateTime(i["NgayKetThuc"].ToString()),
            };
        }
        public List<KhuyenMai> SearchListKhuyenMaiByTenChuongTrinhKhuyenMai_DAL(string TenChuongTrinhKhuyenMai)
        {
            List<KhuyenMai> list = new List<KhuyenMai>();
            string query = "select * from KHUYENMAI where TenChuongTrinhKhuyenMai like '%" + TenChuongTrinhKhuyenMai + "%'";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetKhuyenMai(i));
            }
            return list;
        }
        public List<KhuyenMai> GetListKMSortByPhanTramKM()
        {
            List<KhuyenMai> list = new List<KhuyenMai>();
            string query = "select * from KHUYENMAI ORDER BY PhanTramKhuyenMai DESC";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetKhuyenMai(i));
            }
            return list;
        }
        public void AddKhuyenMai(KhuyenMai km)
        {
            string query = @"INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES(N'" + km.TenChuongTrinhKhuyenMai + "',N'" + km.MaHangHoa + "',N'" + km.PhanTramKhuyenMai + "',N'" + km.NgayBatDau + "',N'" + km.NgayKetThuc + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateDungChuongTrinhKhuyenMai(KhuyenMai km)
        {
            string query = $"UPDATE KHUYENMAI SET NgayKetThuc = '{DateTime.Now}' WHERE MaKhuyenMai ='{km.MaKhuyenMai}';";
            DBHelper.Instance.ExecuteDB(query);

        }
    }
}