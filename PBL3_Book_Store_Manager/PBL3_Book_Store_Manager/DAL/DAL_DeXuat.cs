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
    public class DAL_DeXuat
    {
        private static DAL_DeXuat _Instance;
        public static DAL_DeXuat Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_DeXuat();
                }
                return _Instance;
            }
            private set { }
        }
        public List<DeXuat> GetAllListDeXuat()
        {
            string query = "select * from DEXUAT";
            List<DeXuat> list = new List<DeXuat>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new DeXuat
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    MaNhanVien = i["MaNhanVien"].ToString(),
                    TinhTrang = i["TinhTrang"].ToString(),
                    LoaiDeXuat = i["LoaiDeXuat"].ToString(),
                    ThoiGian = Convert.ToDateTime(i["ThoiGian"])
                });
            }
            return list;
        }
        public void AddDeXuat(DeXuat s)
        {
            string query = $"INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES('{s.MaNhanVien}',N'{s.TinhTrang}',N'{s.LoaiDeXuat}','{s.ThoiGian}');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public List<DeXuatNhapKhoView> GetAllListDeXuatNhapKhoDaChapNhan_DAL()
        {
            string query = $"select MaDeXuat,LoaiDeXuat,NHANVIEN.MaNhanVien,TenNhanVien,ThoiGian,DEXUAT.TinhTrang from NHANVIEN,DEXUAT where NHANVIEN.MaNhanVien = DEXUAT.MaNhanVien and DEXUAT.LoaiDeXuat = N'Đề xuất nhập hàng hóa vào kho' and DEXUAT.TinhTrang = N'Chấp nhận'";
            List<DeXuatNhapKhoView> result = new List<DeXuatNhapKhoView>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                result.Add(new DeXuatNhapKhoView
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    LoaiDeXuat = i["LoaiDeXuat"].ToString(),
                    MaNhanVien = i["MaNhanVien"].ToString(),
                    TenNhanVien = i["TenNhanVien"].ToString(),
                    ThoiGian = Convert.ToDateTime(i["ThoiGian"]),
                    TinhTrang = i["TinhTrang"].ToString()

                });
            }
            return result;
        }
        public List<DeXuatNhapKhoView> GetListDeXuatNhapKhoTheoThuocTinhVaThoiGian_DAL(string ThuocTinh, string TenTimKiem, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc)
        {
            string query = $"select MaDeXuat,LoaiDeXuat,NHANVIEN.MaNhanVien,TenNhanVien,ThoiGian,DEXUAT.TinhTrang from NHANVIEN,DEXUAT where NHANVIEN.MaNhanVien = DEXUAT.MaNhanVien and DEXUAT.LoaiDeXuat = N'Đề xuất nhập hàng hóa vào kho' and DEXUAT.TinhTrang = N'Chấp nhận' and DEXUAT.ThoiGian between '{ThoiGianBatDau}' and '{ThoiGianKetThuc}' and " + @ThuocTinh + " like N'%" + @TenTimKiem + "%'";
            List<DeXuatNhapKhoView> result = new List<DeXuatNhapKhoView>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                result.Add(new DeXuatNhapKhoView
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    LoaiDeXuat = i["LoaiDeXuat"].ToString(),
                    MaNhanVien = i["MaNhanVien"].ToString(),
                    TenNhanVien = i["TenNhanVien"].ToString(),
                    ThoiGian = Convert.ToDateTime(i["ThoiGian"]),
                    TinhTrang = i["TinhTrang"].ToString()
                });
            }
            return result;
        }
        public List<DeXuatNhapKhoView> GetListDeXuatNhapKhoTheoThuocTinh_DAL(string ThuocTinh, string TenTimKiem)
        {
            string query = $"select MaDeXuat,LoaiDeXuat,NHANVIEN.MaNhanVien,TenNhanVien,ThoiGian,DEXUAT.TinhTrang from NHANVIEN,DEXUAT where NHANVIEN.MaNhanVien = DEXUAT.MaNhanVien and DEXUAT.LoaiDeXuat = N'Đề xuất nhập hàng hóa vào kho' and DEXUAT.TinhTrang = N'Chấp nhận' and " + @ThuocTinh + " like N'%" + @TenTimKiem + "%'";
            List<DeXuatNhapKhoView> result = new List<DeXuatNhapKhoView>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                result.Add(new DeXuatNhapKhoView
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    LoaiDeXuat = i["LoaiDeXuat"].ToString(),
                    MaNhanVien = i["MaNhanVien"].ToString(),
                    TenNhanVien = i["TenNhanVien"].ToString(),
                    ThoiGian = Convert.ToDateTime(i["ThoiGian"]),
                    TinhTrang = i["TinhTrang"].ToString()
                });
            }
            return result;
        }
        public List<ChiTietDeXuatNCU> GetAllListCTDeXuatNCU()
        {
            string query = "select * from CHITIETDEXUATNHACUNGUNG";
            List<ChiTietDeXuatNCU> list = new List<ChiTietDeXuatNCU>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new ChiTietDeXuatNCU
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    MaNhaCungUng = i["MaNhaCungUng"].ToString(),
                    MaThamChieu = i["MaThamChieu"].ToString(),
                });
            }
            return list;
        }
        public List<ChiTietDeXuatHD> GetAllListCTDeXuatHD()
        {
            string query = "select * from CHITIETDEXUATHOADON";
            List<ChiTietDeXuatHD> list = new List<ChiTietDeXuatHD>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new ChiTietDeXuatHD
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    MaHangHoa = i["MaHangHoa"].ToString(),
                    SoLuong = Convert.ToInt16(i["SoLuong"].ToString())
                });
            }
            return list;
        }
        public List<ChiTietDeXuatHD> GetlListCTDeXuatHD_byMaDeXuat(string MaDeXuat)
        {
            string query = "select * from CHITIETDEXUATHOADON WHERE MaDeXuat = N'" + @MaDeXuat + "';";
            List<ChiTietDeXuatHD> list = new List<ChiTietDeXuatHD>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new ChiTietDeXuatHD
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    MaHangHoa = i["MaHangHoa"].ToString(),
                    SoLuong = Convert.ToInt16(i["SoLuong"].ToString())
                });
            }
            return list;
        }
        public DTO.ChiTietDeXuatHH GetListCTDeXuatHangHoa(string MaDeXuat)
        {
            string query = "select * from CHITIETDEXUATHANGHOA WHERE MaDeXuat = N'" + MaDeXuat + "';";
            List<DTO.ChiTietDeXuatHH> listCTDXHangHoa = new List<ChiTietDeXuatHH>();
            foreach (DataRow item in DBHelper.Instance.GetRecords(query).Rows)
            {
                DTO.ChiTietDeXuatHH CTDXHangHoa = new ChiTietDeXuatHH(item["MaDeXuat"].ToString(), item["MaHangHoa"].ToString(), item["MaThamChieu"].ToString());
                listCTDXHangHoa.Add(CTDXHangHoa);
            }
            return listCTDXHangHoa[0];
        }
        public List<PhanHoi> GetAllListPhanHoi()
        {
            string query = "select * from PHANHOI";
            List<PhanHoi> list = new List<PhanHoi>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new PhanHoi
                {
                    MaDeXuat = i["MaDeXuat"].ToString(),
                    MaNhanVien = i["MaNhanVien"].ToString(),
                    MaPhanHoi = (i["MaNhanVien"].ToString()),
                    NoiDung = i["NoiDung"].ToString(),
                    ThoiGian = Convert.ToDateTime(i["ThoiGian"].ToString())
                });
            }
            return list;
        }
        public void AddCTDeXuatNCU(ChiTietDeXuatNCU s)
        {
            string query = $"INSERT INTO CHITIETDEXUATNHACUNGUNG (MaDeXuat,MaNhaCungUng,MaThamChieu) VALUES('{s.MaDeXuat}','{s.MaNhaCungUng}','{s.MaThamChieu}');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddCTDeXuatHD(ChiTietDeXuatHD s)
        {
            string query = $"INSERT INTO CHITIETDEXUATHOADON (MaDeXuat,MaHangHoa,SoLuong) VALUES('{s.MaDeXuat}','{s.MaHangHoa}','{s.SoLuong}');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddCTDeXuatHH(ChiTietDeXuatHH s)
        {
            string query = $"INSERT INTO CHITIETDEXUATHANGHOA (MaDeXuat,MaHangHoa,MaThamChieu) VALUES('{s.MaDeXuat}','{s.MaHangHoa}','{s.MaThamChieu}');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddPhanHoi(PhanHoi s)
        {
            string query = $"INSERT INTO PHANHOI (MaNhanVien,MaDeXuat,ThoiGian,NoiDung) VALUES('{s.MaNhanVien}','{s.MaDeXuat}','{s.ThoiGian}',N'{s.NoiDung}');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddCTDeXuatHoaHonNhapKho(ChiTietDeXuatHD s)
        {
            string query = $"INSERT INTO CHITIETDEXUATHOADON (MaDeXuat,MaHangHoa,SoLuong) VALUES('{s.MaDeXuat}','{s.MaHangHoa}','{s.SoLuong}');";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateTrangThaiDX(string TinhTrang, string MaDeXuat)
        {
            string query = $"UPDATE DEXUAT SET TinhTrang = N'{TinhTrang}' WHERE MaDeXuat = '{MaDeXuat}';";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}