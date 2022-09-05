using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DBHelper
    {
        private static DBHelper _Instance;
        public static DBHelper Instance { 
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=LAPTOP-S9M2GDGE\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
                    _Instance = new DBHelper(s);
                }    
                return _Instance;
            }
            private set { } 
        }
        private SqlConnection cnn;
        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void CommandNCU(HopDongNCU s,string query)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@MaNhaCungUng", s.MaNhaCungUng);
            cmd.Parameters.Add("@NgayBatDau", s.NgayBatDau);
            cmd.Parameters.Add("@NgayKetThuc", s.NgayKetThuc);
            cmd.Parameters.Add("@HinhAnh", s.HinhAnh);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void CommandNV(HopDongNV s, string query)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@MaNhanVien", s.MaNhanVien);
            cmd.Parameters.Add("@NgayKy", s.NgayKy);
            cmd.Parameters.Add("@HinhAnh", s.HinhAnh);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}