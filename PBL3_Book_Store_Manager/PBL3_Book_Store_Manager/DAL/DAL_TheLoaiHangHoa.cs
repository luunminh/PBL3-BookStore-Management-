using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_TheLoaiHangHoa
    {
        private static DAL_TheLoaiHangHoa _Instance;
        public static DAL_TheLoaiHangHoa Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_TheLoaiHangHoa();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.TheLoaiHangHoa> getListTheLoaiHangHoa()
        {
            List<DTO.TheLoaiHangHoa> listTheLoaiHangHoa = new List<DTO.TheLoaiHangHoa>();
            string query = "SELECT * FROM THELOAIHANGHOA;";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaTheLoaiHangHoa = item["MaTheLoaiHangHoa"].ToString();
                string TenTheLoaiHangHoa = item["TenTheLoaiHangHoa"].ToString();

                DTO.TheLoaiHangHoa TheLoaiHangHoa = new DTO.TheLoaiHangHoa(MaTheLoaiHangHoa, TenTheLoaiHangHoa);
                listTheLoaiHangHoa.Add(TheLoaiHangHoa);
            }
            return listTheLoaiHangHoa;
        }
        public List<DTO.TheLoaiHangHoa> getListTheLoaiHangHoa(string ThuocTinh, string TimKiem)
        {
            List<DTO.TheLoaiHangHoa> listTheLoaiHangHoa = new List<DTO.TheLoaiHangHoa>();
            string query = "Select * from THELOAIHANGHOA WHERE " + @ThuocTinh + " = N'" + @TimKiem + "';";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaTheLoaiHangHoa = item["MaTheLoaiHangHoa"].ToString();
                string TenTheLoaiHangHoa = item["TenTheLoaiHangHoa"].ToString();

                DTO.TheLoaiHangHoa TheLoaiHangHoa = new DTO.TheLoaiHangHoa(MaTheLoaiHangHoa, TenTheLoaiHangHoa);
                listTheLoaiHangHoa.Add(TheLoaiHangHoa);
            }
            return listTheLoaiHangHoa;
        }
        public void ThemTheLoaiHangHoa(DTO.TheLoaiHangHoa TheLoaiHangHoa)
        {
            string query = "INSERT INTO THELOAIHANGHOA(TenTheLoaiHangHoa) VALUES (N'" + @TheLoaiHangHoa.TenTheLoaiHangHoa.ToString() + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}