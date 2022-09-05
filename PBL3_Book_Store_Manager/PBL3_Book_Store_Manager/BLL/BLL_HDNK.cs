using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.DAL;
namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_HDNK
    {
        private static BLL_HDNK _Instance;
        public static BLL_HDNK Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HDNK();
                }
                return _Instance;
            }
            private set { }
        }
        public void AddCTHDNK_BLL(ChiTietDeXuatHD s)
        {
            DAL_DeXuat.Instance.AddCTDeXuatHoaHonNhapKho(s);
        }
    }
}