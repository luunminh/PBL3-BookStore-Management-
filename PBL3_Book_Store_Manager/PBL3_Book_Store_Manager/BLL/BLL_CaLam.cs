using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_CaLam
    {
        private static BLL_CaLam _Instance;

        public static BLL_CaLam Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_CaLam();
                return _Instance;
            }
            private set { }
        }
        public List<CaLam> GetListCaLam_BLL()
        {
            List<CaLam> data = new List<CaLam>();
            data = DAL_CaLam.Instance.GetListCaLam_DAL();
            return data;
        }
        public CaLam GetCaLamByMaCaLam(string maCaLam)
        {
            CaLam s = new CaLam();
            foreach (CaLam i in GetListCaLam_BLL())
            {
                if (i.MaCaLam == maCaLam)
                {
                    s = i;
                    return s;
                }
            }
            return null;
        }
        public Boolean CheckUpDateCa(CaLam s)
        {
            CaLam cu = GetCaLamByMaCaLam(s.MaCaLam);
            if (cu.TenCaLam == s.MaCaLam && cu.PhuCapCaLam == s.PhuCapCaLam && cu.GioBatDau == s.GioBatDau && cu.GioKetThuc == s.GioKetThuc)
            {
                return true;
            }
            else
            {
                DAL_CaLam.Instance.UpdateCaLam(s);
                return false;
            }
        }
        public List<CaLam> GetListCaLamByMaCaLam(string maCaLam)
        {
            List<CaLam> data = GetListCaLam_BLL();
            List<CaLam> result = new List<CaLam>();
            foreach (CaLam i in data)
            {
                if (i.MaCaLam.Contains(maCaLam))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public List<CaLam> GetListCaLamByTenCaLam(string tenCaLam)
        {
            List<CaLam> data = GetListCaLam_BLL();
            List<CaLam> result = new List<CaLam>();
            foreach (CaLam i in data)
            {
                if (i.TenCaLam.Contains(tenCaLam))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public List<CaLam> GetListCaLamByPhuCap(string phuCap)
        {
            List<CaLam> data = DAL_CaLam.Instance.GetListCaLamSortByPhuCap();
            List<CaLam> result = new List<CaLam>();
            foreach (CaLam i in data)
            {
                if (i.PhuCapCaLam.ToString().Contains(phuCap))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public void ThemCaLam(CaLam s)
        {
            DAL_CaLam.Instance.ThemCaLam(s);
        }
        public List<CTCaLam> GetListCTCaLam_BLL()
        {
            List<CTCaLam> data = new List<CTCaLam>();
            data = DAL_CaLam.Instance.GetListCTCaLam_DAL();
            return data;
        }
        public List<CaLam> GetListCTCaLam_BLLByTrangThai()
        {
            List<CaLam> data = GetListCaLam_BLL();
            List<CaLam> result = new List<CaLam>();
            foreach (CaLam i in data)
            {
                if (i.TrangThai == "Hoạt động")
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public List<CTCaLam> GetListCTCaLamByMaCaKhongTrangThai(string maCaLam)
        {
            List<CTCaLam> data = GetListCTCaLam_BLL();
            List<CTCaLam> result = new List<CTCaLam>();

            foreach (CTCaLam i in data)
            {
                if (i.MaCaLam == maCaLam)
                {
                    CTCaLam s = new CTCaLam();
                    s = i;
                    result.Add((s));
                }

            }
            return result;
        }
        public List<CTCaLam> GetListChiTietCaLam_BLLByTrangThai()
        {
            List<CTCaLam> result = new List<CTCaLam>();
            foreach (CaLam i in GetListCaLam_BLL())
            {
                if (i.TrangThai == "Hoạt động")
                {
                    foreach (CTCaLam item in DAL_CaLam.Instance.GetListCTCaLam_DAL("MaCaLam", i.MaCaLam))
                        result.Add(item);
                }
            }
            return result;
        }
        public void TamNgungCaLam(string maCaLam)
        {
            DAL_CaLam.Instance.TamNgungCaLam(maCaLam);
        }
        public List<ChiTietCaLamView> GetListCTCaLamView()
        {
            List<ChiTietCaLamView> data = new List<ChiTietCaLamView>();
            foreach (CTCaLam i in GetListCTCaLam_BLL())
            {
                ChiTietCaLamView s = new ChiTietCaLamView
                {
                    MaCaLam = i.MaCaLam,
                    TrangThai = i.TrangThai,
                    TenNhanVien = BLL_NV.Instance.GetNVByMaNV(i.MaNhanVien).TenNhanVien,
                    MaNhanVien = i.MaNhanVien,
                };
                data.Add(s);
            }
            return data;
        }
        public List<ChiTietCaLamView> GetListCTCaLamViewByMaCaLam(string maCaLam)
        {
            List<ChiTietCaLamView> data = GetListCTCaLamView();
            List<ChiTietCaLamView> result = new List<ChiTietCaLamView>();

            foreach (ChiTietCaLamView i in data)
            {
                if (i.MaCaLam == maCaLam && i.TrangThai == "Đang làm việc")
                {
                    ChiTietCaLamView s = new ChiTietCaLamView();
                    s = i;
                    result.Add((s));
                }
            }
            return result;
        }
        public void TamNgungCTCaLam_BLL(string MaNV)
        {
            DAL_CaLam.Instance.TamNgungCTCaLam(MaNV);
        }
        public void CheckCTCL(List<ChiTietCaLamView> ctclView, string maCa)
        {
            foreach (ChiTietCaLamView j in ctclView)
            {
                Boolean check = false;
                foreach (CTCaLam i in BLL_CaLam.Instance.GetListCTCaLamByMaCaKhongTrangThai(maCa))
                {
                    if (j.MaNhanVien == i.MaNhanVien && j.TrangThai == "Tạm ngưng" && j.MaCaLam == i.MaCaLam)
                    {
                        DAL_CaLam.Instance.DeleteCTCa(i);
                        check = true;
                    }
                    else if (j.MaNhanVien == i.MaNhanVien && i.TrangThai == "Đang làm việc")
                    {
                        check = true;
                        continue;
                    }
                }
                if (check == false)
                {
                    CTCaLam newCa = new CTCaLam
                    {
                        MaCaLam = j.MaCaLam,
                        MaNhanVien = j.MaNhanVien,
                        TrangThai = j.TrangThai,
                    };
                    DAL_CaLam.Instance.ThemChiTietCaLam(newCa);
                }
            }
        }
    }
}
