using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_ThongKe
    {
        public int SoLuongBan = 0;
        private static BLL_ThongKe _Instance;
        public static BLL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ThongKe();
                }
                return _Instance;
            }
            private set { }
        }
        public Decimal TinhTongDoanhThu(List<HoaDonView> s)
        {
            Decimal result = 0;
            foreach (HoaDonView i in s)
            {
                result += i.TongTien;
            }
            return result;
        }
        public List<ChiTietHD> GetListCTHDTheoTG_BLL(DateTime dateFrom, DateTime dateTo)
        {
            List<ChiTietHD> data = DAL_ThongKe.Instance.GetListCTHDByTG_DAL(dateFrom, dateTo);
            return data;
        }
        public List<ChiTietHD> GetListCTHDBySearch(List<HoaDonView> hdv, List<ChiTietHD> cthd)   //dùng cho hàm tính doanh thu theo search
        {

            List<ChiTietHD> result = new List<ChiTietHD>();

            foreach (HoaDonView i in hdv)
            {
                foreach (ChiTietHD j in cthd)
                {
                    if (j.MaHoaDon == i.MaHoaDon)
                    {
                        result.Add(j);
                    }
                }
            }
            return result;
        }
        public List<HoaDonView> GetListHDViewByTG(DateTime dateFrom, DateTime dateTo)
        {
            List<HoaDon> data = DAL_ThongKe.Instance.GetListHoaDonByTG_DAL(dateFrom, dateTo);
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
        public List<HoaDonView> SearchListHDBHViewByMaHd(string MaHD, DateTime dateFrom, DateTime dateTo)
        {
            List<HoaDonView> data = GetListHDViewByTG(dateFrom, dateTo);
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
        public List<HoaDonView> SearchListHDBHViewByTenNV(string TenNV, DateTime dateFrom, DateTime dateTo)
        {
            List<HoaDonView> data = GetListHDViewByTG(dateFrom, dateTo);
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
        public decimal TinhDoanhThuByTG(DateTime dateFrom, DateTime dateTo)
        {
            decimal result = TinhTongDoanhThu(GetListHDViewByTG(dateFrom, dateTo));
            return result;
        }
        public decimal TinhDoanhThuByTGSearch(DateTime dateFrom, DateTime dateTo, string search, string ThongTin)
        {
            decimal result = 0;
            SoLuongBan = 0;
            if (search == "MaHoaDon")
            {
                foreach (ChiTietHD i in GetListCTHDBySearch(SearchListHDBHViewByMaHd(ThongTin, dateFrom, dateTo), GetListCTHDTheoTG_BLL(dateFrom, dateTo)))
                {
                    SoLuongBan += 1 * i.SoLuong;
                }
                result = TinhTongDoanhThu(SearchListHDBHViewByMaHd(ThongTin, dateFrom, dateTo));
            }
            else
            {
                foreach (ChiTietHD i in GetListCTHDBySearch(SearchListHDBHViewByTenNV(ThongTin, dateFrom, dateTo), GetListCTHDTheoTG_BLL(dateFrom, dateTo)))
                {
                    SoLuongBan += 1 * i.SoLuong;
                }
                result = TinhTongDoanhThu(SearchListHDBHViewByTenNV(ThongTin, dateFrom, dateTo));
            }
            return result;
        }
        public int GetSoLuongBan()
        {
            return SoLuongBan;
        }
    }
}