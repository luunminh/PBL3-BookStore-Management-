using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Book_Store_Manager.DTO
{
    public class Sach : HangHoa
    {
        public string MaSach { get; set; }
        public string TacGia { get; set; }
        public byte LanTaiBan { get; set; }
        //string MaTHangHoa { get; set; }
        public string MaTheLoaiSach { get; set; }
        public Sach()
        {
        }
        public Sach(string MaSach, string TacGia, byte LanTaiBan, string MaTheLoaiSach)
        {
            this.MaSach = MaSach;
            this.TacGia = TacGia;
            this.LanTaiBan = LanTaiBan;
            this.MaTheLoaiSach = MaTheLoaiSach;
        }
        public Sach(DTO.HangHoa HangHoa, string TacGia, byte LanTaiBan, string MaTheLoaiSach)
        {
            this.MaHangHoa = HangHoa.MaHangHoa;
            this.TenHangHoa = HangHoa.TenHangHoa;
            this.MaTheLoaiHangHoa = HangHoa.MaTheLoaiHangHoa;
            this.NhaSanXuat = HangHoa.NhaSanXuat;
            this.MaNhaCungUng = HangHoa.MaNhaCungUng;
            this.NamSanXuat = HangHoa.NamSanXuat;
            this.MaKhuTrungBay = HangHoa.MaKhuTrungBay;
            this.SoLuongTrenKhuTrungBay = HangHoa.SoLuongTrenKhuTrungBay;
            this.MaKho = HangHoa.MaKho;
            this.SoLuongTrongKho = HangHoa.SoLuongTrongKho;
            this.GiaNhap = HangHoa.GiaNhap;
            this.GiaBan = HangHoa.GiaBan;
            this.TrangThai = HangHoa.TrangThai;
            this.MaSach = MaSach;
            this.TacGia = TacGia;
            this.LanTaiBan = LanTaiBan;
            this.MaTheLoaiSach = MaTheLoaiSach;
        }
        public Sach(string mahanghoa, string tenhanghoa, string matheloaihanghoa, string nhasanxuat, string manhacungung, string namsanxuat, string makhutrungbay, short soluongtrenkhutrungbay, string makho, short soluongtrongkho, decimal gianhap, decimal giaban, string trangthai)
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
    }
}