using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DTO;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_Kho
    {
        private static DAL_Kho _Instance;
        public static DAL_Kho Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Kho();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.Kho> getListKho()
        {
            List<DTO.Kho> kho = new List<DTO.Kho>();
            string query = "Select * from KHO;";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaKho = item["MaKho"].ToString();
                string TenKho = item["TenKho"].ToString();
                string TrangThai = item["TrangThai"].ToString();

                DTO.Kho newKho = new DTO.Kho(MaKho, TenKho, TrangThai);
                kho.Add(newKho);
            }
            return kho;
        }
        public List<DTO.Kho> getListKho(string ThuocTinh, string TimKiem)
        {
            List<DTO.Kho> Kho = new List<DTO.Kho>();
            string query = "Select * from KHO WHERE " + @ThuocTinh + " = N'" + @TimKiem + "';";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaKho = item["MaKho"].ToString();
                string TenKho = item["TenKho"].ToString();
                string TrangThai = item["TrangThai"].ToString();

                DTO.Kho newKho = new DTO.Kho(MaKho, TenKho, TrangThai);
                Kho.Add(newKho);
            }
            return Kho;
        }
    }
}