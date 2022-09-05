using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using PBL3_Book_Store_Manager.DTO;
using PBL3_Book_Store_Manager.DAL;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_HopDongNCU
    {
        private static BLL_HopDongNCU _Instance;
        public static BLL_HopDongNCU Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HopDongNCU();
                }
                return _Instance;
            }
            private set { }
        }
        public List<HopDongNCU> GetAllListHopDongNCU_BLL()
        {
            return DAL_HopDongNCU.Instance.GetAllListHopDongNCU();
        }
        public List<HopDongNCU> GetAllListHopDongNCUView_BLL()
        {
            List<HopDongNCU> result = new List<HopDongNCU>();
            foreach (HopDongNCU i in GetAllListHopDongNCU_BLL())
            {
                HopDongNCU newhd = i;
                newhd.MaNhaCungUng = BLL_NCU.Instance.SearchNCUByMaNCU(i.MaNhaCungUng).TenNhaCungUng;
                result.Add(newhd);
            }
            return result;
        }
        public HopDongNCU GetHopDongNCUViewByMaHD(string maHD)
        {
            foreach (HopDongNCU h in GetAllListHopDongNCUView_BLL())
            {
                if (h.MaHopDongNCU == maHD)
                { return h; }
            }
            return null;
        }
        public List<HopDongNCU> SearchHopDongNCUByMaHD(string maHd)
        {
            List<HopDongNCU> result = new List<HopDongNCU>();
            foreach (HopDongNCU i in GetAllListHopDongNCUView_BLL())
            {
                if (i.MaHopDongNCU.Contains(maHd))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public List<HopDongNCU> SearchHopDongNCUByTenNCU(string TenNCU)
        {
            List<HopDongNCU> result = new List<HopDongNCU>();
            foreach (HopDongNCU i in GetAllListHopDongNCUView_BLL())
            {
                if (i.MaNhaCungUng.Contains(TenNCU))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public void AddHopDongNCU(HopDongNCU s)
        {
            DAL_HopDongNCU.Instance.AddHopDongNCU(s);
        }
        public Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            Image img = Image.FromStream(m);
            return img;
        }
    }
}
