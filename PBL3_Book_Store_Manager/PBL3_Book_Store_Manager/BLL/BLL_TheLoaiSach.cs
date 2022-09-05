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
    public class BLL_TheLoaiSach
    {
        private static BLL_TheLoaiSach _Instance;
        public static BLL_TheLoaiSach Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_TheLoaiSach();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.TheLoaiSach> getListTheLoaiSach()
        {
            return DAL_TheLoaiSach.Instance.getListTheLoaiSach();
        }
        public DTO.TheLoaiSach getTheLoaiSach(string MaTheLoaiSach)
        {
            List<DTO.TheLoaiSach> listSach = DAL_TheLoaiSach.Instance.getListTheLoaiSach("MaTheLoaiSach", MaTheLoaiSach);
            return listSach[0];
        }
        public DTO.TheLoaiSach getTheLoaiSach_byTen(string TenTheLoaiSach)
        {
            List<DTO.TheLoaiSach> listSach = DAL_TheLoaiSach.Instance.getListTheLoaiSach("TenTheLoaiSach", TenTheLoaiSach);
            if (listSach.Count > 0)
                return listSach[0];
            return null;
        }
        public bool ThemTheLoaiSach(string TenTheLoaiSach)
        {
            foreach (DTO.TheLoaiSach TLS in DAL_TheLoaiSach.Instance.getListTheLoaiSach())
            {
                if (TLS.TenTheLoaiSach == TenTheLoaiSach)
                    return true;
            }
            DTO.TheLoaiSach TheLoaiSach = new TheLoaiSach(TenTheLoaiSach.ToString().Trim());
            DAL_TheLoaiSach.Instance.ThemTheLoaiSach(TheLoaiSach);
            return false;
        }
    }
}