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
    public class BLL_TheLoaiHangHoa
    {
        private static BLL_TheLoaiHangHoa _Instance;
        public static BLL_TheLoaiHangHoa Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_TheLoaiHangHoa();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.TheLoaiHangHoa> getListTheLoaiHangHoa()
        {
            return DAL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa();
        }
        public DTO.TheLoaiHangHoa getTheLoaiHangHoa(string MaTheLoaiHangHoa)
        {
            List<DTO.TheLoaiHangHoa> TLHH = DAL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa("MaTheLoaiHangHoa", MaTheLoaiHangHoa);
            return TLHH[0];
        }
        public DTO.TheLoaiHangHoa getTheLoaiHangHoa(string ThuocTinh, string TenTimKiem)
        {
            List<DTO.TheLoaiHangHoa> TLHH = DAL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa(ThuocTinh, TenTimKiem);
            if (TLHH.Count > 0)
                return TLHH[0];
            return null;
        }
        public bool ThemTheLoaiHangHoa(string TenTheLoaiHangHoa)
        {
            foreach (DTO.TheLoaiHangHoa TLHH in DAL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa())
            {
                if (TLHH.TenTheLoaiHangHoa == TenTheLoaiHangHoa)
                    return true;
            }
            DTO.TheLoaiHangHoa TheLoaiHangHoa = new TheLoaiHangHoa(TenTheLoaiHangHoa.ToString().Trim());
            DAL_TheLoaiHangHoa.Instance.ThemTheLoaiHangHoa(TheLoaiHangHoa);
            return false;
        }
    }
}