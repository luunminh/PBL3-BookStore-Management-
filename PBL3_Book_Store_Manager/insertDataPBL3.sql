USE PBL3
GO

--kho 
INSERT INTO KHO VALUES ('K000',N'Kho Cẩm Lệ',N'Đang hoạt động');
INSERT INTO KHO VALUES ('K001',N'Kho Hải Châu',N'Đầy');
INSERT INTO KHO VALUES ('K002',N'Kho Liên Chiểu',N'Tạm ngưng');
INSERT INTO KHO VALUES ('K003',N'Kho Ngũ Hành Sơn',N'Đang hoạt động');
INSERT INTO KHO VALUES ('K004',N'Kho Sơn Trà',N'Đang hoạt động');
INSERT INTO KHO VALUES ('K005',N'Kho Thanh Khê',N'Đầy');
INSERT INTO KHO VALUES ('K006',N'Kho Hòa Vang',N'Đang hoạt động');
INSERT INTO KHO VALUES ('K007',N'Kho Hoàng Sa',N'Tạm ngưng');

--khu trưng bày
INSERT INTO KHUTRUNGBAY VALUES ('KTB000',N'Quầy 1',1000);
INSERT INTO KHUTRUNGBAY VALUES ('KTB001',N'Quầy 2',1001);
INSERT INTO KHUTRUNGBAY VALUES ('KTB002',N'Quầy 3',1003);
INSERT INTO KHUTRUNGBAY VALUES ('KTB003',N'Quầy 4',1004);
INSERT INTO KHUTRUNGBAY VALUES ('KTB004',N'Quầy 5',1005);
INSERT INTO KHUTRUNGBAY VALUES ('KTB005',N'Quầy 6',1006);
INSERT INTO KHUTRUNGBAY VALUES ('KTB006',N'Quầy 7',1007);

--thể loại hàng hóa
INSERT INTO THELOAIHANGHOA VALUES ('TLHH000',N'Sách');
INSERT INTO THELOAIHANGHOA VALUES ('TLHH001',N'Kim loại thường và hợp kim');
INSERT INTO THELOAIHANGHOA VALUES ('TLHH002',N'Thiết bị và dụng cụ khoa học');
INSERT INTO THELOAIHANGHOA VALUES ('TLHH003',N'Thiết bị để chiếu sáng');
INSERT INTO THELOAIHANGHOA VALUES ('TLHH004',N'Dụng cụ âm nhạc');
INSERT INTO THELOAIHANGHOA VALUES ('TLHH005',N'Sách giáo khoa');
INSERT INTO THELOAIHANGHOA VALUES ('TLHH006',N'Vở tập');

--thể loại sách
INSERT INTO THELOAISACH VALUES ('TLS000',N'Chính trị – pháp luật');
INSERT INTO THELOAISACH VALUES ('TLS001',N'Khoa học công nghệ – Kinh tế');
INSERT INTO THELOAISACH VALUES ('TLS002',N'Văn học nghệ thuật');
INSERT INTO THELOAISACH VALUES ('TLS003',N'Văn hóa xã hội – Lịch sử');
INSERT INTO THELOAISACH VALUES ('TLS004',N'Giáo trình');
INSERT INTO THELOAISACH VALUES ('TLS005',N'Truyện, tiểu thuyết');
INSERT INTO THELOAISACH VALUES ('TLS006',N'Tâm lý, tâm linh, tôn giáo');
INSERT INTO THELOAISACH VALUES ('TLS007',N'Sách thiếu nhi');
INSERT INTO THELOAISACH VALUES ('TLS008',N'Sách');

--nhà cung ứng
INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES (N'Công ty cổ phần Văn hóa và Truyền thông Nhã Nam',N'Nhã Nam',N'Lê Thị Nhài',N'59 Đỗ Quang, KĐT Trung Hòa Nhân Chính, Cầu Giấy, Hà Nội','0903244248',N'Đang hoạt động');
INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES (N'Công ty Cổ phần Sách Thái Hà (Thai Ha Books)',N'Thái Hòa',N'Huỳnh Thị Cúc',N'Lô B2 – khu Đấu giá 3ha, Tổ dân phố số 1, P.Phúc Diễn, Q.Bắc Từ Liêm, Hà Nội','0243793048',N'Đang hoạt động');
INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES (N'Công ty TNHH Một Thành Viên Sách Phương Nam',N'Văn Toàn',N'Nguyễn Thị Nga',N'Lầu 1, số 940 Đường 3/2, P.15, Q.11, TP. Hồ Chí Minh','1900665612',N'Đang hoạt động');
INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES (N'Công ty văn hóa Đông A',N'Anh Nguyên',N'Thùy Linh',N'113 Đông Các, Ô Chợ Dừa, Đống Đa, Hà Nội','0243856938',N'Đang hoạt động');
INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES (N'Công ty cổ phần Sách Alpha',N'Alex Nguyen',N'Adam Sivit',N'Tầng 3, Dream Home Center, 11a ngõ 282 Nguyễn Huy Tưởng, Thanh Xuân, Hà Nội','0932329959',N'Đang hoạt động');
INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES (N'Công ty Văn hóa Sáng tạo Trí Việt',N'Lê Tấn Phát',N'Vũ Hà Minh',N'11H Nguyễn Thị Minh Khai, Quận 1, Tp. HCM','0283823385',N'Đang hoạt động');
INSERT INTO NHACUNGUNG (TenNhaCungUng,TenNguoiDaiDienPhapLy,TenNguoiDaiDienKinhDoanh,DiaChi,SoDienThoai,TrangThai) VALUES (N'Công ty TNHH Văn hóa Đông Tây',N'Đoàn Hữu Khôi',N'Hứa Nhuận Phát',N'Thư viện Cafe Đông Tây, Nhà N11a, Trần Quý Kiên, Cầu Giấy, HN','0246329741',N'Đang hoạt động');

--hợp đồng
/*INSERT INTO HOPDONG VALUES ('HD000',N'Hợp đồng nhân viên');
INSERT INTO HOPDONG VALUES ('HD001',N'Hợp đồng nhà cung ứng');
INSERT INTO HOPDONG VALUES ('HD002',N'Hợp đồng nhân viên');
INSERT INTO HOPDONG VALUES ('HD003',N'Hợp đồng nhà cung ứng');
INSERT INTO HOPDONG VALUES ('HD004',N'Hợp đồng nhân viên');
INSERT INTO HOPDONG VALUES ('HD005',N'Hợp đồng nhà cung ứng');
INSERT INTO HOPDONG VALUES ('HD006',N'Hợp đồng nhân viên');*/

--hợp đồng nhà cung ứng 
/*INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES ('NCU0000001','20101001','20191201',NULL);
INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES ('NCU0000002','20111101','20201115',NULL);
INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES ('NCU0000003','20121201','20250119',NULL);
INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES ('NCU0000004','20130901','20211230',NULL);
INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES ('NCU0000005','20140101','20240410',NULL);
INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES ('NCU0000006','20150201','20230624',NULL);
--INSERT INTO HOPDONGNHACUNGUNG (MaNhaCungUng,NgayBatDau,NgayKetThuc,HinhAnh) VALUES ('NCU0000007','20160601','20160701',NULL);*/

--hàng hóa
INSERT INTO HANGHOA VALUES ('HH000',N'giáo trình','TLHH000',N'Nhã Nam','NCU0000001','2000','KTB000',1000,'K000',3000,20.500,23.000,N'Đang kinh doanh');
INSERT INTO HANGHOA VALUES ('HH001',N'sách học ngữ','TLHH002',N'Sào Nam','NCU0000003','1999','KTB005',500,'K004',1200,12.300,15.000,N'Đang chờ xét duyệt thêm');
INSERT INTO HANGHOA VALUES ('HH002',N'từ điển','TLHH001',N'Anh Nguyên','NCU0000002','2005','KTB001',2000,'K000',1900,233.500,250.000,N'Đang chờ xét duyệt tạm ngừng kinh doanh');
INSERT INTO HANGHOA VALUES ('HH003',N'truyện đọc','TLHH003',N'Alex Nguyen','NCU0000001','2005','KTB004',1500,'K000',3300,19.500,22.000,N'Đang chờ xét duyệt cập nhật thông tin');
INSERT INTO HANGHOA VALUES ('HH004',N'họa cụ','TLHH006',N'Kim Đồng','NCU0000001','1993','KTB002',1700,'K000',1400,16.500,19.000,N'Đang kinh doanh');
INSERT INTO HANGHOA VALUES ('HH005',N'giáo trình','TLHH004',N'Nhã Nam','NCU0000002','2010','KTB006',700,'K000',1930,199.500,210.000,N'Đang chờ xét duyệt thêm');
INSERT INTO HANGHOA VALUES ('HH006',N'thước kẽ','TLHH005',N'Kim Nguyễn','NCU0000001','2018','KTB003',100,'K000',120,36.500,40.000,N'Đang kinh doanh');

--sách
INSERT INTO SACH VALUES ('S000',N'Kim Khánh',5,'HH000','TLS000');
INSERT INTO SACH VALUES ('S001',N'Kim Đồng',10,'HH002','TLS001');
INSERT INTO SACH VALUES ('S003',N'Hoa Nhài',11,'HH003','TLS003');
INSERT INTO SACH VALUES ('S002',N'Sao Nam',2,'HH006','TLS006');
INSERT INTO SACH VALUES ('S004',N'Nhã Nam',1,'HH003','TLS002');
INSERT INTO SACH VALUES ('S006',N'Sơn Tây',3,'HH002','TLS005');
INSERT INTO SACH VALUES ('S005',N'Hòa Bình',9,'HH001','TLS000');

--khuyến mãi
INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES (N'Mùa hè xanh','HH000',20,'20220601','20220910');
INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES (N'Xuân đoàn tụ','HH001',10,'20220601','20220910');
INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES (N'Ngày giải phóng','HH003',15,'20220430','20220501');
INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES (N'Quốc tế thiếu nhi','HH004',5,'20220601','20220603');
INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES (N'Truy ân người lái đò','HH002',30,'20221120','20221123');
INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES (N'Giáng sinh hạnh phúc','HH006',12,'20221225','20230101');
INSERT INTO KHUYENMAI (TenChuongTrinhKhuyenMai,MaHangHoa,PhanTramKhuyenMai,NgayBatDau,NgayKetThuc) VALUES (N'Valentine','HH005',9,'20220214','20220219');

--chức vụ
INSERT INTO CHUCVU VALUES ('CV000',N'Quản lý',1000000);
INSERT INTO CHUCVU VALUES ('CV001',N'Nhân viên bán hàng',700000);
INSERT INTO CHUCVU VALUES ('CV002',N'Nhân viên thủ kho',700000);

--ca làm
INSERT INTO CALAM (TenCaLam,GioBatDau,GioKetThuc,PhuCapCaLam,TrangThai) VALUES (N'Ca sáng','07:00:00','11:00:00',200000,N'Hoạt động');
INSERT INTO CALAM (TenCaLam,GioBatDau,GioKetThuc,PhuCapCaLam,TrangThai) VALUES (N'Ca chiều','13:00:00','17:00:00',250000,N'Hoạt động');
INSERT INTO CALAM (TenCaLam,GioBatDau,GioKetThuc,PhuCapCaLam,TrangThai) VALUES (N'Ca tối','18:00:00','20:00:00',300000,N'Hoạt động');

--nhân viên
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Nguyễn Văn Anh',1,'19990101','206300121221','0932400256',N'95 Phan Đăng Lưu, Phường Hòa Cường Bắc, Quận Hải Châu, Đà Nẵng','CV000',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Nguyễn Thị Nhài',0,'19971011','206100211221','0978890765',N'tại 69 Nước Mặn 5, Phường Khuê Mỹ, Quận Ngũ Hành Sơn, Đà Nẵng','CV001',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Đoàn Ngọc Phước',1,'20010319','206301121232','0120512345',N'318 Dũng Sĩ Thanh Khê, Phường Thanh Khê Tây, Quận Thanh Khê, Đà Nẵng','CV002',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Huỳnh Bá Phúc',1,'19901201','206300132134','0932400246',N'318 Dũng Sĩ Thanh Khê, Phường Thanh Khê Tây, Quận Thanh Khê, Đà Nẵng','CV000',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Ngô Gia Định',1,'19910702','206300991235','0777001765',N'120 Nguyễn Đình Chiểu, Phường Khuê Mỹ, Quận Ngũ Hành Sơn, Đà Nẵng','CV002',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Lê Thị Hà',0,'20030505','206400182565','0867123321',N'Yên Khê 2, Phường Thanh Khê Tây, Quận Thanh Khê, Đà Nẵng','CV001',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Hồ Linh Anh',0,'20021111','206201164589','0879234765',N'K05/02 Lê Trọng Tấn, Phường An Khê, Quận Thanh Khê, Đà Nẵng','CV001',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Lê Gia Bảo',1,'19951201','206302002648','0911256985',N'37 Phan Đăng Lưu, Phường Hòa Cường Bắc, Quận Hải Châu, Đà Nẵng','CV001',N'Hoạt động');
INSERT INTO NHANVIEN (TenNhanVien,GioiTinh,NgaySinh,SoCanCuocCongDan,SoDienThoai,DiaChi,MaChucVu,TinhTrang) VALUES (N'Trà Thị Huyền',0,'20000218','206301091234','0124986401',N'102 Dũng Sĩ Thanh Khê, Phường Thanh Khê Tây, Quận Thanh Khê, Đà Nẵng','CV002',N'Tạm ngưng');

--hợp đồng nhân viên 
/*INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES  ('NV000','20190101',NULL);
INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES ('NV001','20190101',NULL);
INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES ('NV002','20190101',NULL);
INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES ('NV003','20190101',NULL);
INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES ('NV004','20190101',NULL);
INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES ('NV006','20190101',NULL);
INSERT INTO HOPDONGNHANVIEN (MaNhanVien,NgayKy,HinhAnh) VALUES ('NV008','20190101',NULL);*/

--chi tiết ca làm
INSERT INTO CHITIETCALAM VALUES ('CL00000001','NV00000001',N'Đang làm việc');
INSERT INTO CHITIETCALAM VALUES ('CL00000001','NV00000002',N'Đang làm việc');
INSERT INTO CHITIETCALAM VALUES ('CL00000002','NV00000003',N'Đang làm việc');
INSERT INTO CHITIETCALAM VALUES ('CL00000003','NV00000004',N'Tạm ngưng');
INSERT INTO CHITIETCALAM VALUES ('CL00000002','NV00000005',N'Đang làm việc');
INSERT INTO CHITIETCALAM VALUES ('CL00000003','NV00000006',N'Tạm ngưng');

--tài khoản
INSERT INTO TAIKHOAN VALUES ('NguyenVanAnh','NguyenVanAnh@0101','NV00000001');
INSERT INTO TAIKHOAN VALUES ('NguyenThiNhai','NguyenThiNhai123','NV00000002');
INSERT INTO TAIKHOAN VALUES ('DoanNgocPhuoc','DoanNgocPhuoc321','NV00000003');
INSERT INTO TAIKHOAN VALUES ('HuynhBaPhuc','HuynhBaPhuc@123','NV00000004');
INSERT INTO TAIKHOAN VALUES ('NgoGiaDinh','NgoGiaDinh12345','NV00000005');
INSERT INTO TAIKHOAN VALUES ('LeThiHa','LeThiHa2003','NV00000006');
INSERT INTO TAIKHOAN VALUES ('HoLinhAnh','HoLinhAnh2002@','NV00000007');
INSERT INTO TAIKHOAN VALUES ('LeGiaBao','LeGiaBao19#95','NV00000008');
INSERT INTO TAIKHOAN VALUES ('TraThiHuyen','TraThiHuyen$$$','NV00000009');






--hóa đơn
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220101 12:00:00','NV00000001',100);
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220410 13:30:00','NV00000002',100);
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220319 20:15:00','NV00000001',100);
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220101 12:00:00','NV00000002',100);
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220319 19:15:00','NV00000003',100);
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220502 18:00:00','NV00000004',100);
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220117 17:45:00','NV00000001',100);
INSERT INTO HOADON (ThoiGian, MaNhanVien,TongTien) VALUES ('20220101 12:10:00','NV00000001',100);

--chi tiết hóa đơn
INSERT INTO CHITIETHOADON VALUES ('HDN0000001','HH000',10);
INSERT INTO CHITIETHOADON VALUES ('HDN0000001','HH006',2);
INSERT INTO CHITIETHOADON VALUES ('HDN0000002','HH006',3);
INSERT INTO CHITIETHOADON VALUES ('HDN0000002','HH001',2);
INSERT INTO CHITIETHOADON VALUES ('HDN0000003','HH003',4);
INSERT INTO CHITIETHOADON VALUES ('HDN0000004','HH004',9);
INSERT INTO CHITIETHOADON VALUES ('HDN0000005','HH002',6);
INSERT INTO CHITIETHOADON VALUES ('HDN0000006','HH002',7);
INSERT INTO CHITIETHOADON VALUES ('HDN0000007','HH001',4);

--đề xuất
INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES ('NV00000001',N'Đang chờ phê duyệt',N'Đề xuất thêm nhà cung ứng','20220101 12:00:00');
INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES ('NV00000001',N'Chấp nhận',N'Đề xuất thêm hàng hóa','20220101 12:10:00');
INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES ('NV00000002',N'Không chấp nhận',N'Đề xuất xuất hàng hóa lên kệ','20220117 17:45:00');
INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES ('NV00000002',N'Chấp nhận',N'Đề xuất tạm ngừng kinh doanh hàng hóa','20220502 18:00:00');
INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES ('NV00000003',N'Đang chờ phê duyệt',N'Đề xuất thêm nhà cung ứng','20220319 19:15:00');
INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES ('NV00000003',N'Chấp nhận', N'Đề xuất cập nhật thông tin nhà cung ứng','20220101 12:00:00');
INSERT INTO DEXUAT (MaNhanVien,TinhTrang,LoaiDeXuat,ThoiGian) VALUES ('NV00000004',N'Đang chờ phê duyệt',N'Đề xuất tạm ngừng kinh doanh hàng hóa','20220101 12:00:00');

--phản hồi
INSERT INTO PHANHOI (MaNhanVien,MaDeXuat,ThoiGian,NoiDung) VALUES ('NV00000004','DX00000001','20220101 12:00:00',N'Mua thêm sách');
INSERT INTO PHANHOI (MaNhanVien,MaDeXuat,ThoiGian,NoiDung) VALUES ('NV00000001','DX00000002','20220410 13:30:00',N'Hết sách trong kho');
INSERT INTO PHANHOI (MaNhanVien,MaDeXuat,ThoiGian,NoiDung) VALUES ('NV00000004','DX00000003','20220211 07:00:00',N'Nhập hàng đủ');
INSERT INTO PHANHOI (MaNhanVien,MaDeXuat,ThoiGian,NoiDung) VALUES ('NV00000002','DX00000004','20220319 20:15:00',N'Khu trưng bày đầy sách');
INSERT INTO PHANHOI (MaNhanVien,MaDeXuat,ThoiGian,NoiDung) VALUES ('NV00000003','DX00000005','20220302 12:30:00',N'Nhập sách thiếu');

--chi tiết đề xuất hàng hóa
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000001','HH006','TC006');
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000002','HH005','TC000');
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000004','HH004','TC001');
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000001','HH003','TC002');
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000002','HH002','TC003');
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000001','HH001','TC004');
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000002','HH000','TC005');
INSERT INTO CHITIETDEXUATHANGHOA VALUES ('DX00000006','HH000','');

--chi tiết đề xuất nhà cung ứng
INSERT INTO CHITIETDEXUATNHACUNGUNG VALUES ('DX00000004','NCU0000006','TC004');
INSERT INTO CHITIETDEXUATNHACUNGUNG VALUES ('DX00000004','NCU0000005','TC003');
INSERT INTO CHITIETDEXUATNHACUNGUNG VALUES ('DX00000004','NCU0000004','TC002');
INSERT INTO CHITIETDEXUATNHACUNGUNG VALUES ('DX00000004','NCU0000003','TC001');
INSERT INTO CHITIETDEXUATNHACUNGUNG VALUES ('DX00000005','NCU0000002','TC000');
INSERT INTO CHITIETDEXUATNHACUNGUNG VALUES ('DX00000005','NCU0000001','TC005');
INSERT INTO CHITIETDEXUATNHACUNGUNG VALUES ('DX00000005','NCU0000007','TC006');

--chi tiết đề xuất hóa đơn
--INSERT INTO CHITIETDEXUATHOADON VALUES ('DX000','HH006',10);
--INSERT INTO CHITIETDEXUATHOADON VALUES ('DX001','HH005',9);
--INSERT INTO CHITIETDEXUATHOADON VALUES ('DX002','HH004',8);
--INSERT INTO CHITIETDEXUATHOADON VALUES ('DX003','HH003',7);
--INSERT INTO CHITIETDEXUATHOADON VALUES ('DX004','HH002',6);
--INSERT INTO CHITIETDEXUATHOADON VALUES ('DX005','HH001',5);
--INSERT INTO CHITIETDEXUATHOADON VALUES ('DX006','HH000',4);