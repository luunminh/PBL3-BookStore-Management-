using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_ChucVu
    {
        private static BLL_ChucVu _Instance;
        public static BLL_ChucVu Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_ChucVu();
                return _Instance;
            }
            private set { }
        }
        public DTO.ChucVu getChucVu_byMaChucVu(string MaChucVu)
        {
            foreach (DTO.ChucVu item in DAL_ChucVu.Instance.getListChucVu())
            {
                if (item.MaChucVu == MaChucVu)
                    return item;
            }
            return null;
        }
    }
}