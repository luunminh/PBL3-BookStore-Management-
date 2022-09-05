using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DAL;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_HDBH
    {
        private static BLL_HDBH _Instance;
        public static BLL_HDBH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HDBH();
                }
                return _Instance;
            }
            private set { }
        }
        public List<HoaDon> GetListHoaDonBH_BLL()
        {
            List<HoaDon> data = new List<HoaDon>();
            data = DAL_HD.Instance.getListHDBH("select * from HOADON");
            return data;
        }
        public HoaDon GetHoaDon_ByMaHD(string ma)
        {
            HoaDon s = new HoaDon();
            foreach (HoaDon i in GetListHoaDonBH_BLL())
            {
                if (i.MaHoaDon == ma) s = i;
            }
            return s;
        }
        public HoaDon GetHoaDonByThoiGian(HoaDon s)
        {
            HoaDon hd = new HoaDon();
            foreach (HoaDon i in GetListHoaDonBH_BLL())
            {
                if (i.ThoiGian.ToString() == s.ThoiGian.ToString())
                {
                    hd = i;
                    return hd;
                }
            }
            return null;
        }
        public List<ChiTietHD> GetListChiTietHD_BLL()
        {
            List<ChiTietHD> data = new List<ChiTietHD>();
            data = DAL_HD.Instance.GetListChiTietHD("select * from CHITIETHOADON");
            return data;
        }
        public void AddHD_BLL(HoaDon s)
        {
            DAL_HD.Instance.AddHD_DAL(s);
        }
        public void AddCTHD_BLL(ChiTietHD s)
        {
            DAL_HD.Instance.AddCTHD_DAL(s);
        }
        public List<HoaDonView> SearchListHDBHViewByMaHd(string MaHD)
        {
            List<HoaDonView> data = GetListHDView();
            List<HoaDonView> result = new List<HoaDonView>();
            if (MaHD == null) result = data;
            else
            {
                foreach (HoaDonView i in data)
                {
                    if (i.MaHoaDon.Contains(MaHD))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public List<HoaDonView> SearchListHDBHViewByTenNV(string TenNV)
        {
            List<HoaDonView> data = GetListHDView();
            List<HoaDonView> result = new List<HoaDonView>();
            if (TenNV == null) result = data;
            else
            {
                foreach (HoaDonView i in data)
                {
                    if (i.TenNhanVien.Contains(TenNV))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public List<HoaDonView> GetListHDView()
        {
            List<HoaDon> data = GetListHoaDonBH_BLL();
            List<HoaDonView> result = new List<HoaDonView>();

            foreach (HoaDon hoaDon in data)
            {
                HoaDonView hd = new HoaDonView
                {
                    MaHoaDon = hoaDon.MaHoaDon,
                    ThoiGian = hoaDon.ThoiGian,
                    TenNhanVien = BLL_NV.Instance.GetNVByMaNV(hoaDon.MaNhanVien).TenNhanVien,
                    TongTien = hoaDon.TongTien
                };
                result.Add(hd);
            }
            return result;
        }
    }
}
