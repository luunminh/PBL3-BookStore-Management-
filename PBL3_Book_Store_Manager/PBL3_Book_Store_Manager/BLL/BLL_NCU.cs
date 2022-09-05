using _3Layers.DTO;
using PBL3_Book_Store_Manager.DAL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.BLL
{
    public class BLL_NCU
    {
        private static BLL_NCU _Instance;
        public static BLL_NCU Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NCU();
                }
                return _Instance;
            }
            private set { }
        }
        public List<NhaCungUng> GetAllListNCU_BLL()
        {
            List<NhaCungUng> result = new List<NhaCungUng>();
            foreach (NhaCungUng i in DAL_NCU.Instance.GetAllListNCU())
            {
                if (i.TrangThai.Trim() == "Đang hoạt động")
                {
                    NhaCungUng s = i;
                    result.Add(s);
                }
            }
            return result;
        }
        public List<NhaCungUng> GetAllListNCUKhongTrangThai_BLL()
        {
            List<NhaCungUng> data = DAL_NCU.Instance.GetAllListNCU();
            return data;
        }
        public NhaCungUng SearchNCUByMaNCU(string mancu)
        {
            List<NhaCungUng> data = GetAllListNCU_BLL();
            NhaCungUng result = new NhaCungUng();

            foreach (NhaCungUng i in data)
            {
                if (i.MaNhaCungUng == mancu)
                {
                    result = i;
                }
            }
            return result;
        }
        public NhaCungUng GetNCUByMaNCUKhongTrangThai(string mancu)
        {
            List<NhaCungUng> data = GetAllListNCUKhongTrangThai_BLL();
            NhaCungUng result = new NhaCungUng();

            foreach (NhaCungUng i in data)
            {
                if (i.MaNhaCungUng == mancu)
                {
                    result = i;
                }
            }
            return result;
        }
        public List<NhaCungUng> SearchListNCUBySDT(string sdt)
        {
            List<NhaCungUng> data = GetAllListNCU_BLL();
            List<NhaCungUng> result = new List<NhaCungUng>();
            if (sdt == null) result = data;
            else
            {
                foreach (NhaCungUng i in data)
                {
                    if (i.SoDienThoai.Contains(sdt) && i.TrangThai == "Đang hoạt động")
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public List<NhaCungUng> SearchListNCUByTenNCU(string tenncu)
        {
            List<NhaCungUng> data = GetAllListNCU_BLL();
            List<NhaCungUng> result = new List<NhaCungUng>();
            if (tenncu == null) result = data;
            else
            {
                foreach (NhaCungUng i in data)
                {
                    if (i.TenNhaCungUng.Contains(tenncu) && i.TrangThai == "Đang hoạt động")
                    {
                        result.Add(i);
                    }
                }
            }
            if (result.Count > 0)
                return result;
            return null;
        }
        public List<NhaCungUng> SearchListNCUByDiaChi(string dc)
        {
            List<NhaCungUng> data = GetAllListNCU_BLL();
            List<NhaCungUng> result = new List<NhaCungUng>();
            if (dc == null) result = data;
            else
            {
                foreach (NhaCungUng i in data)
                {
                    if (i.DiaChi.Contains(dc) && i.TrangThai == "Đang hoạt động")
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public NhaCungUng GetLasTestNCU()
        {
            List<NhaCungUng> data = GetAllListNCUKhongTrangThai_BLL();
            return data[data.Count - 1];
        }
        public void AddNCU(NhaCungUng s)
        {
            DAL_NCU.Instance.AddNCU(s);
        }
        public void UpdateNCU(NhaCungUng s, string MaNCUCu)
        {
            DAL_NCU.Instance.UpdateNCU(s, MaNCUCu);
        }
        public void UpdateTrangThaiNCU_BLL(string MaNCU)
        {
            DAL_NCU.Instance.UpdateTrangThaiNCU(MaNCU);
        }
        public List<CBBItems> GetCBB()
        {
            List<CBBItems> data = new List<CBBItems>();
            foreach (NhaCungUng i in GetAllListNCU_BLL())
            {
                data.Add(new CBBItems
                {
                    Value = i.MaNhaCungUng,
                    Text = i.TenNhaCungUng
                });
            }
            return data;
        }
        public DTO.NhaCungUng getNhaCungUng(string MaNhaCungUng)
        {
            List<DTO.NhaCungUng> listNhaCungUng = DAL_NCU.Instance.getListNhaCungUng("MaNhaCungUng", MaNhaCungUng);
            return listNhaCungUng[0];
        }
        public void getListNCU(ComboBox cbb)
        {
            List<DTO.NhaCungUng> listNCU = DAL_NCU.Instance.GetAllListNCU();
            cbb.DisplayMember = "TenNhaCungUng";
            cbb.DataSource = listNCU;
        }
    }
}