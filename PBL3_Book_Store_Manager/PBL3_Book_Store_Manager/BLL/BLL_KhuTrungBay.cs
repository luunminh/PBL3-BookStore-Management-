using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_KhuTrungBay
    {
        private static BLL_KhuTrungBay _Instance;
        public static BLL_KhuTrungBay Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_KhuTrungBay();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.KhuTrungBay> getListKhuTrungBay()
        {
            return DAL_KhuTrungBay.Instance.getListKhuTrungBay();
        }
        public DTO.KhuTrungBay getKhuTrungBay(string MaKhuTrungBay)
        {
            List<DTO.KhuTrungBay> KTB = DAL_KhuTrungBay.Instance.getListKhuTrungBay("MaKhuTrungBay", MaKhuTrungBay);
            return KTB[0];
        }
        public DTO.KhuTrungBay getKhuTrungBay_Ten(string TenKhuTrungBay)
        {
            List<DTO.KhuTrungBay> KTB = DAL_KhuTrungBay.Instance.getListKhuTrungBay("TenKhuTrungBay", TenKhuTrungBay);
            if (KTB.Count > 0)
                return KTB[0];
            else
                return null;
        }
        public void ThemKhuTrungBay(DTO.KhuTrungBay KhuTrungBay)
        {
            DAL_KhuTrungBay.Instance.ThemKhuTrungBay(KhuTrungBay);
        }
        public void CapNhatKhuTrungBay(DTO.KhuTrungBay KhuTrungBay)
        {
            DAL_KhuTrungBay.Instance.CapNhatKhuTrungBay(KhuTrungBay);
        }
        public bool TrangThaiHienTai(string MaKhuTrungBay, short SoLuongThemVao)
        {
            short x = 0;
            DTO.KhuTrungBay KhuTrungBay = DAL_KhuTrungBay.Instance.getListKhuTrungBay("MaKhuTrungBay", MaKhuTrungBay)[0];
            foreach (DTO.HangHoa item in DAL_HH.Instance.getListHangHoa())
            {
                if (item.MaKhuTrungBay == MaKhuTrungBay)
                    x += item.SoLuongTrenKhuTrungBay;
            }
            x += SoLuongThemVao;
            if (x > KhuTrungBay.SoLuongToiDa)
                return true;
            return false;
        }
    }
}