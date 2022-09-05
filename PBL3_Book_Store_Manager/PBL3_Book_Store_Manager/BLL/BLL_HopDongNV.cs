using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_HopDongNV
    {
        private static BLL_HopDongNV _Instance;
        public static BLL_HopDongNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HopDongNV();
                }
                return _Instance;
            }
            private set { }
        }
        public List<HopDongNV> GetAllListHopDongNV_BLL()
        {
            return DAL_HopDongNV.Instance.GetAllListHopDongNV();
        }
        public List<HopDongNV> GetAllListHopDongNVView_BLL()
        {
            List<HopDongNV> result = new List<HopDongNV>();
            foreach (HopDongNV i in GetAllListHopDongNV_BLL())
            {
                HopDongNV newhd = i;
                newhd.MaNhanVien = BLL_NV.Instance.GetNVByMaNV(newhd.MaNhanVien).TenNhanVien;
                result.Add(newhd);
            }
            return result;
        }
        public HopDongNV GetHopDongNVViewByMaHD(string maHD)
        {
            foreach (HopDongNV h in GetAllListHopDongNVView_BLL())
            {
                if (h.MaHopDongNV == maHD)
                { return h; }
            }
            return null;
        }
        public HopDongNV GetHopDongNVByMaHD(string maHD)
        {
            foreach (HopDongNV h in GetAllListHopDongNV_BLL())
            {
                if (h.MaHopDongNV == maHD)
                { return h; }
            }
            return null;
        }
        public List<HopDongNV> SearchHopDongNVByMaHD(string maHd)
        {
            List<HopDongNV> result = new List<HopDongNV>();
            foreach (HopDongNV i in GetAllListHopDongNVView_BLL())
            {
                if (i.MaHopDongNV.Contains(maHd))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public List<HopDongNV> SearchHopDongNVByTenNCU(string TenNCU)
        {
            List<HopDongNV> result = new List<HopDongNV>();
            foreach (HopDongNV i in GetAllListHopDongNVView_BLL())
            {
                if (i.MaNhanVien.Contains(TenNCU))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public void AddHopDongNV(HopDongNV s)
        {
            DAL_HopDongNV.Instance.AddHopDongNV(s);
        }
        public Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            Image img = Image.FromStream(m);
            return img;
        }
    }
}