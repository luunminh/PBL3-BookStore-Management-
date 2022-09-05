using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.BLL
{
    internal class BLL_DN
    {
        private static BLL_DN _Instance;
        public static BLL_DN Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DN();
                }
                return _Instance;
            }
            private set { }
        }
        public List<TaiKhoan> GetListTK_BLL()
        {
            return DAL_DN.Instance.GetListTK();
        }
        public bool CheckTenTK(string TenTK)
        {
            foreach (TaiKhoan i in GetListTK_BLL())
            {
                if (TenTK.Trim() == i.TenTaiKhoan.Trim())
                {
                    return true;  //trung
                }
            }
            return false;   //không trung
        }
        public void AddTaiKhoan(TaiKhoan s)
        {
            DAL_DN.Instance.AddTK(s);
        }
        public void Update(TaiKhoan s)
        {
            DAL_DN.Instance.UpdateTK(s);
        }
    }
}
