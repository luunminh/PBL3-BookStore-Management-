using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_NV
    {
        private static DAL_NV _Instance;
        public static DAL_NV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_NV();
                }
                return _Instance;
            }
            private set { }
        }
        public List<NhanVien> getListNV()
        {
            string query = "Select * from NHANVIEN";
            List<NhanVien> data = new List<NhanVien>();

            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetNV(i));
            }
            return data;
        }
        public List<NhanVien> getListNV(string ThuocTinh, string TenTimKiem)
        {
            string query = "Select * from NHANVIEN WHERE " + ThuocTinh + " LIKE N'%" + TenTimKiem + "%';";
            List<NhanVien> data = new List<NhanVien>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetNV(i));
            }
            return data;
        }
        public NhanVien GetNV(DataRow i)
        {
            return new NhanVien
            {
                MaNhanVien = i["MaNhanVien"].ToString(),
                TenNhanVien = i["TenNhanVien"].ToString(),
                GioiTinh = Convert.ToBoolean(i["GioiTinh"].ToString()),
                NgaySinh = Convert.ToDateTime(i["NgaySinh"].ToString()),
                SoCanCuocCongDan = i["SoCanCuocCongDan"].ToString(),
                SoDienThoai = i["SoDienThoai"].ToString(),
                DiaChi = i["DiaChi"].ToString(),
                MaChucVu = i["MaChucVu"].ToString(),
                TinhTrang = i["TinhTrang"].ToString()
            };
        }
        public ChucVu GetChucVu(DataRow i)
        {
            return new ChucVu
            {
                MaChucVu = i["MaChucVu"].ToString(),
                TenChucVu = i["TenChucVu"].ToString(),
            };
        }
        public void AddNV(NhanVien s)
        {
            byte Gender = 0;
            if (s.GioiTinh) Gender = 1;
            string query = @"INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'" + s.TenNhanVien + "'," + Gender + ",'" + s.NgaySinh + "','" + s.SoCanCuocCongDan + "','" + s.SoDienThoai + "',N'" + s.DiaChi + "','" + s.MaChucVu + "',N'" + s.TinhTrang + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateNV(NhanVien s)
        {
            byte Gender = 0;
            if (s.GioiTinh) Gender = 1;
            string query = @"UPDATE NHANVIEN set TenNhanVien = N'" + s.TenNhanVien + "',GioiTinh = " + Gender + ",NgaySinh = '" + s.NgaySinh + "',SoCanCuocCongDan = '" + s.SoCanCuocCongDan + "',SoDienThoai ='" + s.SoDienThoai + "',DiaChi = N'" + s.DiaChi + "',MaChucVu = '" + s.MaChucVu + "',TinhTrang =N'" + s.TinhTrang + "' WHERE MaNhanVien = '" + s.MaNhanVien + "';";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateTrangThaiNV(string maNV)
        {
            string query = "UPDATE NHANVIEN Set TinhTrang = N'Tạm ngưng' WHERE MaNhanVien = '" + maNV + "'";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}