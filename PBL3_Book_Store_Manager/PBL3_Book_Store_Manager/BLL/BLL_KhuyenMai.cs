using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.DAL;
using _3Layers.DTO;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_KhuyenMai
    {
        private static BLL_KhuyenMai _Instance;
        public static BLL_KhuyenMai Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_KhuyenMai();
                }
                return _Instance;
            }
            private set { }
        }
        public List<KhuyenMai> GetAllListKhuyenMaiView_BLL()
        {
            List<KhuyenMai> result = new List<KhuyenMai>();
            foreach (KhuyenMai i in DAL_KhuyenMai.Instance.GetAllListKhuyenMai())
            {
                KhuyenMai s = i;
                s.MaHangHoa = BLL_HangHoa.Instance.GetHHByMaHH(i.MaHangHoa).TenHangHoa;
                result.Add(s);
            }
            return result;
        }
        public KhuyenMai SearchKhuyenMaiByMaKhuyenMai(string MaKhuyenMai)
        {
            List<KhuyenMai> data = GetAllListKhuyenMaiView_BLL();
            KhuyenMai result = new KhuyenMai();

            foreach (KhuyenMai i in data)
            {
                if (i.MaKhuyenMai.Contains(MaKhuyenMai))
                {
                    result = i;
                }
            }
            return result;
        }
        public List<KhuyenMai> SearchListKhuyenMaiByMaKM(string MaKhuyenMai)
        {
            List<KhuyenMai> data = GetAllListKhuyenMaiView_BLL();
            List<KhuyenMai> result = new List<KhuyenMai>();
            if (MaKhuyenMai == null) result = data;
            else
            {
                foreach (KhuyenMai i in data)
                {
                    if (i.MaKhuyenMai.ToString().Contains(MaKhuyenMai))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public List<KhuyenMai> SearchListKhuyenMaiByTenChuongTrinhKhuyenMai(string TenChuongTrinhKhuyenMai)
        {
            List<KhuyenMai> data = GetAllListKhuyenMaiView_BLL();
            List<KhuyenMai> result = new List<KhuyenMai>();
            if (TenChuongTrinhKhuyenMai == null) result = data;
            else
            {
                foreach (KhuyenMai i in DAL_KhuyenMai.Instance.SearchListKhuyenMaiByTenChuongTrinhKhuyenMai_DAL(TenChuongTrinhKhuyenMai))
                {
                    KhuyenMai s = i;
                    s.MaHangHoa = BLL_HangHoa.Instance.GetHHByMaHH(i.MaHangHoa).TenHangHoa;
                    result.Add(s);
                }
            }
            return result;
        }
        public List<KhuyenMai> SearchListKhuyenMaiByNgayBatDau(string NgayBatDau)
        {
            List<KhuyenMai> data = GetAllListKhuyenMaiView_BLL();
            List<KhuyenMai> result = new List<KhuyenMai>();
            if (NgayBatDau == null) result = data;
            else
            {
                foreach (KhuyenMai i in data)
                {
                    if (i.NgayBatDau.ToString().Contains(NgayBatDau))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public List<KhuyenMai> SearchListKhuyenMaiByNgayKetThuc(string NgayKetThuc)
        {
            List<KhuyenMai> data = GetAllListKhuyenMaiView_BLL();
            List<KhuyenMai> result = new List<KhuyenMai>();
            if (NgayKetThuc == null) result = data;
            else
            {
                foreach (KhuyenMai i in data)
                {
                    if (i.NgayKetThuc.ToString().Contains(NgayKetThuc))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public KhuyenMai GetKhuyenMaiByMaHangHoaVaThoiGian(string maHH,DateTime thoigian)
        {
            KhuyenMai result = new KhuyenMai();
            foreach(KhuyenMai i in DAL_KhuyenMai.Instance.GetListKMSortByPhanTramKM())
            {
                if(i.MaHangHoa == maHH && (i.NgayBatDau <= thoigian && i.NgayKetThuc >= thoigian))
                {
                    result = i;
                    return result;
                }
            }
            return null;
        }
        public void AddKhuyenMai(KhuyenMai s)
        {
            DAL_KhuyenMai.Instance.AddKhuyenMai(s);
        }
    }
}