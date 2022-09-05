using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.BLL;
using System.Data;
namespace PBL3_Book_Store_Manager.DAL
{
    internal class DAL_DN
    {
        private static DAL_DN _Instance;
        public static DAL_DN Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_DN();
                }
                return _Instance;
            }
            private set { }
        }
        public TaiKhoan GetTaiKhoan(DataRow i)
        {
            return new TaiKhoan
            {
                TenTaiKhoan = i["TenTaiKhoan"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                MaNhanVien = i["MaNhanVien"].ToString()
            };
        }
        public TaiKhoan GetTaiKhoanKhiDangNhap(string TenTaiKhoan, string MatKhau)
        {
            bool check = false;
            TaiKhoan result = new TaiKhoan();
            string query = "select * from TAIKHOAN where TenTaiKhoan = '" + TenTaiKhoan + "' and MatKhau = '" + MatKhau + "'";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                result = GetTaiKhoan(i);
                check = true;
            }
            if(check == true)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public List<TaiKhoan> GetListTK()
        {
            string query = "select * from TAIKHOAN";
            List<TaiKhoan> data = new List<TaiKhoan>();
            foreach(DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetTaiKhoan(i));
            }    
            return data;
        }
        public TaiKhoan GetTKByMaNV(string MaNV)
        {
            foreach(TaiKhoan i in GetListTK())
            {
                if(i.MaNhanVien == MaNV)
                {
                    TaiKhoan s = i;
                    return s;
                }    
            }
            return null;
        }
        public void AddTK(TaiKhoan s)
        {
            string query = @"INSERT INTO TAIKHOAN VALUES ('" + s.TenTaiKhoan + "','" + s.MatKhau + "','" + s.MaNhanVien + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateTK(TaiKhoan s)
        {
            string query = $"UPDATE TAIKHOAN set MatKhau = '{s.MatKhau}' WHERE TenTaiKhoan = '{s.TenTaiKhoan}'";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}