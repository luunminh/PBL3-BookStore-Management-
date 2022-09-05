using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.DAL
{
    public class DAL_HH
    {
        private static DAL_HH _Instance;
        public static DAL_HH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HH();
                }
                return _Instance;
            }
            private set { }
        }
        public List<HangHoa> getListHH(string query)
        {
            List<HangHoa> data = new List<HangHoa>();

            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetHH(i));
            }
            return data;
        }
        public HangHoa GetHH(DataRow i)
        {
            return new HangHoa()
            {
                MaHangHoa = i["MaHangHoa"].ToString(),
                TenHangHoa = i["TenHangHoa"].ToString(),
                MaTheLoaiHangHoa = i["MaTheLoaiHangHoa"].ToString(),
                NhaSanXuat = i["NhaSanXuat"].ToString(),
                MaNhaCungUng = i["MaNhaCungUng"].ToString(),
                NamSanXuat = i["NamSanXuat"].ToString(),
                MaKhuTrungBay = i["MaKhuTrungBay"].ToString(),
                SoLuongTrenKhuTrungBay = Convert.ToInt16(i["SoLuongTrenKhuTrungBay"].ToString()),
                MaKho = i["MaKho"].ToString(),
                SoLuongTrongKho = Convert.ToInt16(i["SoLuongTrongKho"].ToString()),
                GiaNhap = Convert.ToDecimal(i["GiaNhap"].ToString()),
                GiaBan = Convert.ToDecimal(i["GiaBan"].ToString()),
                TrangThai = i["TrangThai"].ToString()
            };
        }
        public List<DTO.HangHoa> getListHangHoa()
        {
            List<DTO.HangHoa> HangHoa = new List<DTO.HangHoa>();
            string query = "Select * from HANGHOA WHERE TrangThai = N'Đang kinh doanh';";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaHangHoa = item["MaHangHoa"].ToString();
                string TenHangHoa = item["TenHangHoa"].ToString();
                string MaTheLoaiHangHoa = item["MaTheLoaiHangHoa"].ToString();
                string NhaSanXuat = item["NhaSanXuat"].ToString();
                string MaNhaCungUng = item["MaNhaCungUng"].ToString();
                string NamSanXuat = item["NamSanXuat"].ToString();
                string MaKhuTrungBay = item["MaKhuTrungBay"].ToString();
                short SoLuongTrenKhuTrungBay = (short)item["SoLuongTrenKhuTrungBay"];
                string MaKho = item["MaKho"].ToString();
                short SoLuongTrongKho = (short)item["SoLuongTrongKho"];
                decimal GiaNhap = (decimal)item["GiaNhap"];
                decimal GiaBan = (decimal)item["GiaBan"];
                string TrangThai = item["TrangThai"].ToString();

                DTO.HangHoa newHangHoa = new DTO.HangHoa(MaHangHoa, TenHangHoa, MaTheLoaiHangHoa, NhaSanXuat, MaNhaCungUng, NamSanXuat, MaKhuTrungBay, SoLuongTrenKhuTrungBay, MaKho, SoLuongTrongKho, GiaNhap, GiaBan, TrangThai);
                HangHoa.Add(newHangHoa);
            }
            return HangHoa;
        }
        public List<DTO.HangHoa> getListHangHoa(string query)
        {
            List<DTO.HangHoa> HangHoa = new List<DTO.HangHoa>();
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaHangHoa = item["MaHangHoa"].ToString();
                string TenHangHoa = item["TenHangHoa"].ToString();
                string MaTheLoaiHangHoa = item["MaTheLoaiHangHoa"].ToString();
                string NhaSanXuat = item["NhaSanXuat"].ToString();
                string MaNhaCungUng = item["MaNhaCungUng"].ToString();
                string NamSanXuat = item["NamSanXuat"].ToString();
                string MaKhuTrungBay = item["MaKhuTrungBay"].ToString();
                short SoLuongTrenKhuTrungBay = (short)item["SoLuongTrenKhuTrungBay"];
                string MaKho = item["MaKho"].ToString();
                short SoLuongTrongKho = (short)item["SoLuongTrongKho"];
                decimal GiaNhap = (decimal)item["GiaNhap"];
                decimal GiaBan = (decimal)item["GiaBan"];
                string TrangThai = item["TrangThai"].ToString();

                DTO.HangHoa newHangHoa = new DTO.HangHoa(MaHangHoa, TenHangHoa, MaTheLoaiHangHoa, NhaSanXuat, MaNhaCungUng, NamSanXuat, MaKhuTrungBay, SoLuongTrenKhuTrungBay, MaKho, SoLuongTrongKho, GiaNhap, GiaBan, TrangThai);
                HangHoa.Add(newHangHoa);
            }
            return HangHoa;
        }
        public List<Sach> GetListSach()
        {
            List<Sach> data = new List<Sach>();
            string query = "SELECT HANGHOA.MaHangHoa, HANGHOA.TenHangHoa, HANGHOA.MaTheLoaiHangHoa, HANGHOA.NhaSanXuat, HANGHOA.MaNhaCungUng, HANGHOA.NamSanXuat, HANGHOA.MaKhuTrungBay, HANGHOA.SoLuongTrenKhuTrungBay, HANGHOA.MaKho, HANGHOA.SoLuongTrongKho, HANGHOA.GiaNhap, HANGHOA.GiaBan, HANGHOA.TrangThai, SACH.MaSach, SACH.TacGia, SACH.LanTaiBan, SACH.MaTheLoaiSach FROM HANGHOA FULL OUTER JOIN SACH ON HANGHOA.MaHangHoa = SACH.MaHangHoa where HANGHOA.MaHangHoa = SACH.MaHangHoa;";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetSach(i));
            }
            return data;
        }
        public Sach GetSach(DataRow i)
        {
            return new Sach()
            {
                MaHangHoa = i["MaHangHoa"].ToString(),
                TenHangHoa = i["TenHangHoa"].ToString(),
                MaTheLoaiHangHoa = i["MaTheLoaiHangHoa"].ToString(),
                NhaSanXuat = i["NhaSanXuat"].ToString(),
                MaNhaCungUng = i["MaNhaCungUng"].ToString(),
                NamSanXuat = i["NamSanXuat"].ToString(),
                MaKhuTrungBay = i["MaKhuTrungBay"].ToString(),
                SoLuongTrenKhuTrungBay = Convert.ToInt16(i["SoLuongTrenKhuTrungBay"].ToString()),
                MaKho = i["MaKho"].ToString(),
                SoLuongTrongKho = Convert.ToInt16(i["SoLuongTrongKho"].ToString()),
                GiaNhap = Convert.ToDecimal(i["GiaNhap"].ToString()),
                GiaBan = Convert.ToDecimal(i["GiaBan"].ToString()),
                TrangThai = i["TrangThai"].ToString(),
                MaSach = i["MaSach"].ToString(),
                TacGia = i["TacGia"].ToString(),
                LanTaiBan = Convert.ToByte(i["LanTaiBan"].ToString()),
                MaTheLoaiSach = i["MaTheLoaiSach"].ToString()
            };
        }
        public List<HangHoa> TimKiemHangHoa(string ThuocTinh, string TenTimKiem)
        {
            List<DTO.HangHoa> HangHoa = new List<DTO.HangHoa>();
            string query = "Select * from HANGHOA where " + @ThuocTinh + " LIKE N'%" + @TenTimKiem + "%' AND TrangThai = N'Đang kinh doanh';";
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                string MaHangHoa = item["MaHangHoa"].ToString();
                string TenHangHoa = item["TenHangHoa"].ToString();
                string MaTheLoaiHangHoa = item["MaTheLoaiHangHoa"].ToString();
                string NhaSanXuat = item["NhaSanXuat"].ToString();
                string MaNhaCungUng = item["MaNhaCungUng"].ToString();
                string NamSanXuat = item["NamSanXuat"].ToString();
                string MaKhuTrungBay = item["MaKhuTrungBay"].ToString();
                short SoLuongTrenKhuTrungBay = (short)item["SoLuongTrenKhuTrungBay"];
                string MaKho = item["MaKho"].ToString();
                short SoLuongTrongKho = (short)item["SoLuongTrongKho"];
                decimal GiaNhap = (decimal)item["GiaNhap"];
                decimal GiaBan = (decimal)item["GiaBan"];
                string TrangThai = item["TrangThai"].ToString();

                DTO.HangHoa newHangHoa = new DTO.HangHoa(MaHangHoa, TenHangHoa, MaTheLoaiHangHoa, NhaSanXuat, MaNhaCungUng, NamSanXuat, MaKhuTrungBay, SoLuongTrenKhuTrungBay, MaKho, SoLuongTrongKho, GiaNhap, GiaBan, TrangThai);
                HangHoa.Add(newHangHoa);
            }
            return HangHoa;
        }
        public void UpdateSoLuongHH(HangHoa s)
        {
            string query = "update HANGHOA set SoLuongTrenKhuTrungBay = '" + s.SoLuongTrenKhuTrungBay + "' where MaHangHoa = '" + s.MaHangHoa + "'";
            DBHelper.Instance.ExecuteDB(query);
        }
        public bool NgungKinhDoanh(string MaHangHoa)
        {
            string query = "update HANGHOA set TrangThai = N'Đang chờ xét duyệt tạm ngừng kinh doanh' where MaHangHoa = N'" + @MaHangHoa + "';";
            DataTable data = DBHelper.Instance.GetRecords(query);
            return true;
        }
        public void DeXuatThemHangHoa(DTO.HangHoa HangHoa)
        {
            string query = "INSERT INTO HANGHOA (TenHangHoa, MaTheLoaiHangHoa, NhaSanXuat, MaNhaCungUng, NamSanXuat, MaKhuTrungBay, SoLuongTrenKhuTrungBay, MaKho, SoLuongTrongKho, GiaNhap, GiaBan, TrangThai) VALUES (N'" + @HangHoa.TenHangHoa + "','" + @HangHoa.MaTheLoaiHangHoa + "',N'" + @HangHoa.NhaSanXuat + "','" + @HangHoa.MaNhaCungUng + "','2022','" + @HangHoa.MaKhuTrungBay + "'," + @HangHoa.SoLuongTrenKhuTrungBay + ",'" + @HangHoa.MaKho + "'," + @HangHoa.SoLuongTrongKho + "," + HangHoa.GiaNhap + "," + HangHoa.GiaBan + ",N'" + @HangHoa.TrangThai + "');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void CapNhatHangHoa(DTO.HangHoa HangHoa)
        {
            string query = "UPDATE HANGHOA SET TenHangHoa = N'" + @HangHoa.TenHangHoa + "', MaTheLoaiHangHoa = '" + @HangHoa.MaTheLoaiHangHoa + "', NhaSanXuat = N'" + @HangHoa.NhaSanXuat + "', MaNhaCungUng = '" + @HangHoa.MaNhaCungUng + "', NamSanXuat = '" + @HangHoa.NamSanXuat + "', MaKhuTrungBay = '" + @HangHoa.MaKhuTrungBay + "', SoLuongTrenKhuTrungBay = " + @HangHoa.SoLuongTrenKhuTrungBay + ", MaKho = '" + @HangHoa.MaKho + "', SoLuongTrongKho = " + @HangHoa.SoLuongTrongKho + ", GiaNhap = " + @HangHoa.GiaNhap + ", GiaBan = " + @HangHoa.GiaBan + " , TrangThai = N'" + @HangHoa.TrangThai + "' WHERE MaHangHoa = '" + @HangHoa.MaHangHoa + "'; ";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}