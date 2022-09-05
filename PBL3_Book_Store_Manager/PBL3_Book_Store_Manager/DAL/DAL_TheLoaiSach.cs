using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Book_Store_Manager.DTO;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_TheLoaiSach
    {
        private static DAL_TheLoaiSach _Instance;
        public static DAL_TheLoaiSach Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_TheLoaiSach();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.TheLoaiSach> getListTheLoaiSach()
        {
            List<DTO.TheLoaiSach> listTheLoaiSach = new List<DTO.TheLoaiSach>();
            string query = "SELECT * FROM THELOAISACH;";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                DTO.TheLoaiSach newTheLoaiSach = new TheLoaiSach(item["MaTheLoaiSach"].ToString(), item["TenTheLoaiSach"].ToString());
                listTheLoaiSach.Add(newTheLoaiSach);
            }
            return listTheLoaiSach;
        }
        public List<DTO.TheLoaiSach> getListTheLoaiSach(string ThuocTinh, string TimKiem)
        {
            List<DTO.TheLoaiSach> listTheLoaiSach = new List<DTO.TheLoaiSach>();
            string query = "SELECT * FROM THELOAISACH WHERE " + @ThuocTinh + " LIKE N'%" + @TimKiem + "%';";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                DTO.TheLoaiSach newTheLoaiSach = new TheLoaiSach(item["MaTheLoaiSach"].ToString(), item["TenTheLoaiSach"].ToString());
                listTheLoaiSach.Add(newTheLoaiSach);
            }
            return listTheLoaiSach;
        }
        public void ThemTheLoaiSach(DTO.TheLoaiSach TheLoaiSach)
        {
            string query = "INSERT INTO THELOAISACH(TenTheLoaiSach) VALUES (N'" + @TheLoaiSach.TenTheLoaiSach.ToString() + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}