using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_NCU
    {
        private static DAL_NCU _Instance;
        public static DAL_NCU Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_NCU();
                }
                return _Instance;
            }
            private set { }
        }
        public List<NhaCungUng> GetAllListNCU()
        {
            string query = "select * from NHACUNGUNG";
            List<NhaCungUng> list = new List<NhaCungUng>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetNCU(i));
            }
            return list;
        }
        public NhaCungUng GetNCU(DataRow i)
        {
            return new NhaCungUng
            {
                MaNhaCungUng = i["MaNhaCungUng"].ToString(),
                TenNhaCungUng = i["TenNhaCungUng"].ToString(),
                TenNguoiDaiDienPhapLy = i["TenNguoiDaiDienPhapLy"].ToString(),
                TenNguoiDaiDienKinhDoanh = i["TenNguoiDaiDienKinhDoanh"].ToString(),
                DiaChi = i["DiaChi"].ToString(),
                SoDienThoai = i["SoDienThoai"].ToString(),
                TrangThai = i["TrangThai"].ToString()
            };
        }
        public void AddNCU(NhaCungUng s)
        {
            string query = @"INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES(N'" + s.TenNhaCungUng + "',N'" + s.TenNguoiDaiDienPhapLy + "',N'" + s.TenNguoiDaiDienKinhDoanh + "',N'" + s.DiaChi + "',N'" + s.SoDienThoai + "',N'" + s.TrangThai + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateNCU(NhaCungUng s, string MaNCUCu)
        {
            string query = $"UPDATE NHACUNGUNG SET TenNhaCungUng =  N'{s.TenNhaCungUng}', TenNguoiDaiDienPhapLy = '{s.TenNguoiDaiDienPhapLy}', TenNguoiDaiDienKinhDoanh = '{s.TenNguoiDaiDienKinhDoanh}', DiaChi = '{s.DiaChi}' WHERE MaNhaCungUng ='{MaNCUCu}';";
            DBHelper.Instance.ExecuteDB(query);
        }
        public List<DTO.NhaCungUng> getListNhaCungUng(string ThuocTinh, string TimKiem)
        {
            int i = 0;
            List<DTO.NhaCungUng> listNhaCungUng = new List<DTO.NhaCungUng>();
            string query = "Select * from NhaCungUng WHERE " + @ThuocTinh + " = N'" + @TimKiem + "';";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaNhaCungUng = item["MaNhaCungUng"].ToString();
                string TenNhaCungUng = item["TenNhaCungUng"].ToString();
                string TenNguoiDaiDienPhapLy = item["TenNguoiDaiDienPhapLy"].ToString();
                string TenNguoiDaiDienKinhDoanh = item["TenNguoiDaiDienKinhDoanh"].ToString();
                string DiaChi = item["DiaChi"].ToString();
                string SoDienThoai = item["SoDienThoai"].ToString();
                string TrangThai = item["TrangThai"].ToString();

                DTO.NhaCungUng NhaCungUng = new DTO.NhaCungUng(MaNhaCungUng, TenNhaCungUng, TenNguoiDaiDienPhapLy, TenNguoiDaiDienKinhDoanh, DiaChi, SoDienThoai, TrangThai);
                listNhaCungUng.Add(NhaCungUng);
                i++;
            }
            return listNhaCungUng;
        }
        public void UpdateTrangThaiNCU(string MaNhaCU)
        {
            string query = $"UPDATE NHACUNGUNG SET TrangThai = N'Đang hoạt động' WHERE MaNhaCungUng = '{MaNhaCU}';";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}