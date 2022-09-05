using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DTO;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_ChucVu
    {
        private static DAL_ChucVu _Instance;
        public static DAL_ChucVu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ChucVu();
                }
                return _Instance;
            }
            private set { }
        }
        public List<ChucVu> getListChucVu()
        {
            string query = "SELECT * FROM CHUCVU;";
            List<ChucVu> listChucVu = new List<ChucVu>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                ChucVu newChucVu = new ChucVu
                {
                    MaChucVu = i["MaChucVu"].ToString(),
                    TenChucVu = i["TenChucVu"].ToString()
                };
                listChucVu.Add(newChucVu);
            }
            return listChucVu;
        }
    }
}