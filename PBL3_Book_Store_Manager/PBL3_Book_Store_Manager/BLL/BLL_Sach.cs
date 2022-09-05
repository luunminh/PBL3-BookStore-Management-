using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Book_Store_Manager.DAL;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_Sach
    {
        private static BLL_Sach _Instance;
        public static BLL_Sach Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Sach();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.Sach> getListSach(string ThuocTinh, string TimKiem)
        {
            return DAL_Sach.Instance.getListSach(ThuocTinh, TimKiem);
        }
        public DTO.Sach getSach(string MaHangHoa)
        {
            return DAL_Sach.Instance.getListSach("MaHangHoa", MaHangHoa)[0];
        }
        public void DeXuatTheSach(DTO.Sach Sach)
        {
            DTO.HangHoa HangHoa = new DTO.HangHoa();
            List<DTO .HangHoa> listHangHoa = DAL_HH.Instance.getListHangHoa("SELECT* FROM HANGHOA WHERE TenHangHoa = N'" + @Sach.TenHangHoa + "';");
            Sach.MaHangHoa = listHangHoa[listHangHoa.Count - 1].MaHangHoa;
            DAL_Sach.Instance.DeXuatThemSach(Sach);
        }
    }
}