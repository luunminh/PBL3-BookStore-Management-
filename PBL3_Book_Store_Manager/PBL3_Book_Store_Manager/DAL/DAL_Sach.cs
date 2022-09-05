using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Book_Store_Manager.DTO;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_Sach
    {
        private static DAL_Sach _Instance;
        public static DAL_Sach Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Sach();
                return _Instance;
            }
            private set { }
        }
        public List<DTO.Sach> getListSach(string ThuocTinh, string TimKiem)
        {
            List<DTO.Sach> listSach = new List<DTO.Sach>();
            string MaCuaSach = DAL_TheLoaiHangHoa.Instance.getListTheLoaiHangHoa("TenTheLoaiHangHoa", "Sách")[0].MaTheLoaiHangHoa.ToString();
            if (MaCuaSach != null)
            {
                string query1 = "SELECT * FROM HANGHOA WHERE MaTheLoaiHangHoa = N'" + @MaCuaSach + "' AND " + @ThuocTinh + " LIKE N'%" + @TimKiem + "%'";
                foreach (DataRow item in DBHelper.Instance.GetRecords(query1).Rows)
                {
                    DTO.Sach newSach = new Sach(item["MaHangHoa"].ToString(), item["TenHangHoa"].ToString(), item["MaTheLoaiHangHoa"].ToString(), item["NhaSanXuat"].ToString(), item["MaNhaCungUng"].ToString(), item["NamSanXuat"].ToString(), item["MaKhuTrungBay"].ToString(), (short)item["SoLuongTrenKhuTrungBay"], item["MaKho"].ToString(), (short)item["SoLuongTrongKho"], (decimal)item["GiaNhap"], (decimal)item["GiaBan"], item["TrangThai"].ToString());
                    listSach.Add(newSach);
                }
                if (listSach == null)
                    return listSach;
                int i = 0;
                string query2 = "SELECT * FROM SACH;";
                foreach (DataRow item in DBHelper.Instance.GetRecords(query2).Rows)
                {
                    if (i < listSach.Count && listSach[i].MaHangHoa.ToString() == item["MaHangHoa"].ToString())
                    {
                        listSach[i].MaSach = item["MaSach"].ToString();
                        listSach[i].TacGia = item["TacGia"].ToString();
                        listSach[i].LanTaiBan = Convert.ToByte(item["LanTaiBan"].ToString());
                        listSach[i].MaTheLoaiSach = item["MaTheLoaiSach"].ToString();
                        i++;
                    }
                }
            }
            return listSach;
        }
        public void DeXuatThemSach(DTO.Sach Sach)
        {
            string query = "INSERT INTO SACH (TacGia, LanTaiBan, MaHangHoa, MaTheLoaiSach) VALUES (N'" + @Sach.TacGia + "'," + @Sach.LanTaiBan + ",'" + @Sach.MaHangHoa + "','" + @Sach.MaTheLoaiSach + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}