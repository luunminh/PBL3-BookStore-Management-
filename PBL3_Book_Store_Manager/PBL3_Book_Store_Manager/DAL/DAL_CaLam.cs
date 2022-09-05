using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_CaLam
    {
        private static DAL_CaLam _Instance;
        public static DAL_CaLam Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_CaLam();
                }
                return _Instance;
            }
            private set { }
        }
        public List<CaLam> GetListCaLam_DAL()
        {
            string query = "Select * from CALAM";
            List<CaLam> list = new List<CaLam>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetCaLam(i));
            }
            return list;
        }
        public CaLam GetCaLam(DataRow i)
        {
            return new CaLam
            {
                MaCaLam = i["MaCaLam"].ToString(),
                TenCaLam = i["TenCaLam"].ToString(),
                GioBatDau = (TimeSpan)i["GioBatDau"],
                GioKetThuc = (TimeSpan)i["GioKetThuc"],
                PhuCapCaLam = Convert.ToInt32(i["PhuCapCaLam"].ToString()),
                TrangThai = i["TrangThai"].ToString()
            };
        }
        public List<CTCaLam> GetListCTCaLam_DAL()
        {
            string query = "SELECT * FROM CHITIETCALAM";
            List<CTCaLam> data = new List<CTCaLam>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetChiTietCaLam(i));
            }
            return data;
        }
        public CTCaLam GetChiTietCaLam(DataRow i)
        {
            return new CTCaLam
            {
                MaCaLam = i["MaCaLam"].ToString(),
                MaNhanVien = i["MaNhanVien"].ToString(),
                TrangThai = i["TrangThai"].ToString()
            };
        }
        public List<CTCaLam> GetListCTCaLam_DAL(string ThuocTinh, string TenTimKiem)
        {
            string query = "SELECT * FROM CHITIETCALAM WHERE " + @ThuocTinh + " = N'" + @TenTimKiem + "';";
            List<CTCaLam> data = new List<CTCaLam>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetChiTietCaLam(i));
            }
            return data;
        }
        public List<CaLam> GetListCaLamSortByPhuCap()
        {
            string query = "Select * from CALAM ORDER BY PhuCapCaLam";
            List<CaLam> list = new List<CaLam>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetCaLam(i));
            }
            return list;
        }
        public void TamNgungCaLam(string maCaLam)
        {
            string query = "Update CALAM SET TrangThai = N'Tạm ngưng' WHERE MaCaLam = '" + maCaLam + "'";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateCaLam(CaLam s)
        {
            string query = $"UPDATE CALAM SET TenCaLam =  N'{s.TenCaLam}', PhuCapCaLam = '{s.PhuCapCaLam}', GioBatDau = '{s.GioBatDau}', GioKetThuc = '{s.GioKetThuc}' WHERE MaCaLam ='{s.MaCaLam}';";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void DeleteCTCa(CTCaLam s)
        {
            string query = $"DELETE FROM CHITIETCALAM WHERE MaNhanVien ='{s.MaNhanVien}' and MaCaLam ='{s.MaCaLam}'";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void TamNgungCTCaLam(string MaNhanVien)
        {
            string query = $"DELETE FROM CHITIETCALAM WHERE MaNhanVien = '{MaNhanVien}';";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void ThemChiTietCaLam(CTCaLam s)
        {
            string query = $"INSERT INTO CHITIETCALAM VALUES ('{s.MaCaLam}', '{s.MaNhanVien}', N'{s.TrangThai}');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void ThemCaLam(CaLam s)
        {
            string query = $"INSERT INTO CALAM (TenCaLam,GioBatDau,GioKetThuc,PhuCapCaLam,TrangThai) VALUES (N'{s.TenCaLam}','{s.GioBatDau}','{s.GioKetThuc}',{s.PhuCapCaLam},N'Hoạt động');";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}