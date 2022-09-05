using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class HangHoa
    {
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public string MaTheLoaiHangHoa { get; set; }
        public string NhaSanXuat { get; set; }
        public string MaNhaCungUng { get; set; }
        public string NamSanXuat { get; set; }
        public string MaKhuTrungBay { get; set; }
        public short SoLuongTrenKhuTrungBay { get; set; }
        public string MaKho { get; set; }
        public short SoLuongTrongKho { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string TrangThai { get; set; }
        public HangHoa()
        {

        }
        public HangHoa(string mahanghoa, string tenhanghoa, string matheloaihanghoa, string nhasanxuat, string manhacungung, string namsanxuat, string makhutrungbay, short soluongtrenkhutrungbay, string makho, short soluongtrongkho, decimal gianhap, decimal giaban, string trangthai)
        {
            this.MaHangHoa = mahanghoa;
            this.TenHangHoa = tenhanghoa;
            this.MaTheLoaiHangHoa = matheloaihanghoa;
            this.NhaSanXuat = nhasanxuat;
            this.MaNhaCungUng = manhacungung;
            this.NamSanXuat = namsanxuat;
            this.MaKhuTrungBay = makhutrungbay;
            this.SoLuongTrenKhuTrungBay = soluongtrenkhutrungbay;
            this.MaKho = makho;
            this.SoLuongTrongKho = soluongtrongkho;
            this.GiaNhap = gianhap;
            this.GiaBan = giaban;
            this.TrangThai = trangthai;
        }
        public HangHoa(string mahanghoa, string tenhanghoa, string manhacungung, string makho, short soluongtrongkho, decimal gianhap, decimal giaban, string trangthai)
        {
            this.MaHangHoa = mahanghoa;
            this.TenHangHoa = tenhanghoa;
            this.MaNhaCungUng = manhacungung;
            this.MaKho = makho;
            this.SoLuongTrongKho = soluongtrongkho;
            this.GiaNhap = gianhap;
            this.GiaBan = giaban;
            this.TrangThai = trangthai;
        }
        public HangHoa(DTO.HangHoa HangHoa)
        {
            this.MaHangHoa = HangHoa.MaHangHoa;
            this.TenHangHoa = HangHoa.TenHangHoa;
            this.MaTheLoaiHangHoa = HangHoa.MaTheLoaiHangHoa;
            this.NamSanXuat = HangHoa.NamSanXuat;
            this.NhaSanXuat = HangHoa.NhaSanXuat;
            this.MaNhaCungUng = HangHoa.MaNhaCungUng;
            this.MaKhuTrungBay = HangHoa.MaKhuTrungBay;
            this.SoLuongTrenKhuTrungBay = HangHoa.SoLuongTrenKhuTrungBay;
            this.MaKho = HangHoa.MaKho;
            this.SoLuongTrongKho = HangHoa.SoLuongTrongKho;
            this.GiaNhap = HangHoa.GiaNhap;
            this.GiaBan = HangHoa.GiaBan;
            this.TrangThai = HangHoa.TrangThai;
        }
    }
}