create database QLTTANNP3
use QLTTANNP3
go
--table coso
CREATE TABLE CoSo 
(
    MaCoSo VARCHAR(10) PRIMARY KEY,
    TenCoSo NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(10),
    Email VARCHAR(100)
)
go
---table nhan vien
CREATE TABLE NhanVien 
(
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    ChucVu NVARCHAR(50),
	GioiTinh NVARCHAR(10),
    SoDienThoai VARCHAR(10),
    Email VARCHAR(100),
	GhiChu NVARCHAR(250),
    MaCoSo VARCHAR(10),
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo)
)
go
---table hoc vien
CREATE TABLE HocVien 
(
    MaHocVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    SoDienThoai VARCHAR(10),
    Email VARCHAR(100),
    TrangThai NVARCHAR(250),
    MaCoSo VARCHAR(10),	
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo),
)
go
----table khoa hoc
CREATE TABLE KhoaHoc 
(
    MaKhoaHoc VARCHAR(10) PRIMARY KEY,
    TenKhoaHoc NVARCHAR(100),
    MoTa NVARCHAR(250),
    HocPhi DECIMAL(15,2),
    ThoiGian NVARCHAR(50)
)
go
----- table lophoc
CREATE TABLE LopHoc (
    MaLopHoc VARCHAR(10) PRIMARY KEY,
    TenLopHoc NVARCHAR(100),
    MaKhoaHoc VARCHAR(10),
    MaCoSo VARCHAR(10),
    MaGiaoVien VARCHAR(10),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    CaHoc NVARCHAR(50),
    MaPhong VARCHAR(10),
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc),
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo),
    FOREIGN KEY (MaGiaoVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong)
)
go

---Bảng hóa đơn
CREATE TABLE HoaDon
(
	MaHD varchar(20) primary key,
	MaHV varchar(10),
	TongTien DECIMAL(15,2),
	FOREIGN KEY (MaHV) REFERENCES HocVien(MaHocVien)
)
go
--- Bảng hóa đơn chi tiết
CREATE TABLE HoaDonChiTiet
(
	MaHDCT varchar(20) primary key,
	MaHD varchar(20),
	MaKH varchar(10),
	TongTien DECIMAL(15,2)
	FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaKH) REFERENCES KhoaHoc(MaKhoaHoc)
)
go

-- Bảng Phiếu Thu
CREATE TABLE PhieuThu (
    MaPhieuThu VARCHAR(10) PRIMARY KEY,
    MaHocVien VARCHAR(10),
    NgayThu DATE,
    SoTien DECIMAL(15,2),
    GhiChu NVARCHAR(250),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien)
)
go

-- Bảng Điểm Thi
CREATE TABLE DiemThi (
    MaDiemThi VARCHAR(10) PRIMARY KEY,
    MaHocVien VARCHAR(10),
    MaKhoaHoc VARCHAR(10),
    Diem DECIMAL(4,2),
    NgayThi DATE,
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
)
go
-- Bảng Điểm Danh
CREATE TABLE DiemDanh (
    MaDiemDanh VARCHAR(10) PRIMARY KEY,
    MaHocVien VARCHAR(10),
    NgayHoc DATE,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien)
)
go

-- Bảng Phòng Học	
CREATE TABLE PhongHoc (
    MaPhong VARCHAR(10) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    SucChua INT,
    MaCoSo VARCHAR(10),
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo)
)
go

---Bảng Lịch Học
CREATE TABLE LichHoc (
    MaLichHoc VARCHAR(10) PRIMARY KEY,
    MaLopHoc VARCHAR(10),
    NgayHoc DATE,
    CaHoc NVARCHAR(50),
    MaPhong VARCHAR(10),
    MaNhanVien VARCHAR(10),
    FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc),
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
)
go

---Bảng phân công giảng dạy
CREATE TABLE PhanCongGiangDay (
    MaPhanCong VARCHAR(10) PRIMARY KEY ,
    MaNhanVien VARCHAR(10),
    MaLopHoc VARCHAR(10),
    NgayPhanCong DATE ,
    GhiChu NVARCHAR(250),
     FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
     FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc)    
)
go
CREATE TABLE TaiKhoan
(
	tenTK VARCHAR(10) primary key,
	matKhau VARCHAR(10)
 	FOREIGN KEY (tenTK) REFERENCES NhanVien(MaNhanVien),

)
go
CREATE TABLE MaGiamGia
(
	Magiamgia VARCHAR(10) primary key,
	Tenmagiamgia  NVARCHAR(100),
 	Sotienduocgiam DECIMAL(15,2),
	Hansudung DATE,
	ghichu NVARCHAR(250)
)
go


INSERT INTO CoSo (MaCoSo, TenCoSo, DiaChi, SoDienThoai, Email) VALUES
('CS01', N'Cơ sở TP.HCM', N'45 Nguyễn Huệ, TP.HCM', '0978123456', 'tphcm@eglagena.com'),
('CS02', N'Cơ sở Hà Nội', N'12 Hàng Bài, Hà Nội', '0918765432', 'hanoi@eglagena.com'),
('CS03', N'Cơ sở Bình Định', N'23 Trần Hưng Đạo, Bình Định', '0901234567', 'binhdinh@eglagena.com'),
('CS04', N'Cơ sở Lâm Đồng', N'67 Hồ Xuân Hương, Lâm Đồng', '0938765432', 'lamdong@eglagena.com'),
select * from CoSo
----du lieu bang nhan vien
-- Cơ sở CS01
INSERT INTO NhanVien (MaNhanVien, HoTen, ChucVu, SoDienThoai, Email, GhiChu, MaCoSo) VALUES
('NV001', N'Nguyễn Minh Thuận', N'Quản lý', '0901234560', 'minhthuan@gmail.com', N'đang ổn', 'CS01'),
('NV002', N'Trần Mai Văn Kha', N'Kế toán', '0912345679', 'maivanha@gmail.com', N'đang ổn', 'CS01'),
('NV003', N'Lê Duy Khải', N'Kế toán', '0923456790', 'duykhai@gmail.com', N'đang ổn', 'CS01'),
('NV009', N'Bùi Thảo Uyên', N'Giáo viên', '0989012346', 'thaouyen@gmail.com', N'đang ổn', 'CS01'),
('NV006', N'Vũ Thái Hòa', N'Giáo viên', '0956789013', 'thaihoa@gmail.com', N'đang ổn', 'CS01'),
('NV012', N'Trần Hữu Duy', N'Giáo viên', '0913456790', 'huuduy@gmail.com', N'đang ổn', 'CS01'),
('NV005', N'Hoàng Lan Nam', N'Giáo viên', '0945678902', 'lannam@gmail.com', N'đang ổn', 'CS01'),
('NV010', N'Đỗ Quốc Linh', N'Giáo viên', '0990123457', 'quoclinh@gmail.com', N'đang ổn', 'CS01'),
('NV007', N'Đặng Thi Giang', N'Giáo viên', '0967890124', 'thigiang@gmail.com', N'đang ổn', 'CS01'),
('NV013', N'Lê Tấn Nam', N'Giáo viên', '0924567891', 'tannam@gmail.com', N'đang ổn', 'CS01'),
('NV008', N'Ngô Minh Thuận', N'Giáo viên', '0978901235', 'minhthuan@gmail.com', N'đang ổn', 'CS01'),
('NV004', N'Phạm Minh Đăng', N'Giáo viên', '0934567891', 'minhdang@gmail.com', N'đang ổn', 'CS01'),
('NV011', N'Nguyễn Bảo Long', N'Giáo viên', '0902345679', 'baolong@gmail.com', N'đang ổn', 'CS01'),

-- Cơ sở CS02
('NV026', N'Vũ Thanh Lê', N'Quản lý', '0958901235', 'thanhle@gmail.com', N'đang ổn', 'CS02'),
('NV027', N'Đặng Nguyễn Lê Nguyên', N'Kế toán', '0969012346', 'lenguyen@gmail.com', N'đang ổn', 'CS02'),
('NV028', N'Ngô Hồng Thắm', N'Kế toán', '0970123457', 'hongtham@gmail.com', N'đang ổn', 'CS02'),
('NV036', N'Vũ Kiều My', N'Giáo viên', '0959012346', 'kieumy@gmail.com', N'đang ổn', 'CS02'),
('NV032', N'Trần Mạnh Hùng', N'Giáo viên', '0915678902', 'manhhung@gmail.com', N'đang ổn', 'CS02'),
('NV029', N'Bùi Thị Tuyết Hoa', N'Giáo viên', '0981234568', 'tuyethoa@gmail.com', N'đang ổn', 'CS02'),
('NV035', N'Hoàng Minh Mai', N'Giáo viên', '0948901235', 'minhmai@gmail.com', N'đang ổn', 'CS02'),
('NV034', N'Phạm Hoàng Long', N'Giáo viên', '0937890124', 'hoanglong@gmail.com', N'đang ổn', 'CS02'),
('NV031', N'Nguyễn Hoàng Hạnh', N'Giáo viên', '0904567891', 'hoanghanh@gmail.com', N'đang ổn', 'CS02'),
('NV033', N'Lê Thị Lan Anh', N'Giáo viên', '0926789013', 'lananh@gmail.com', N'đang ổn', 'CS02'),
('NV037', N'Đặng Lan Oanh', N'Giáo viên', '0960123457', 'lanoanh@gmail.com', N'đang ổn', 'CS02'),
('NV038', N'Ngô Tấn Phúc', N'Giáo viên', '0971234568', 'tanphuc@gmail.com', N'đang ổn', 'CS02'),
('NV030', N'Đỗ Hữu Phước', N'Giáo viên', '0992345679', 'huuphuoc@gmail.com', N'đang ổn', 'CS02'),

-- Cơ sở CS03
('NV051', N'Nguyễn Thi Giang', N'Quản lý', '0906789013', 'thigiang@gmail.com', N'đang ổn', 'CS03'),
('NV052', N'Trần Thị Tuyết', N'Kế toán', '0917890124', 'thituyet@gmail.com', N'đang ổn', 'CS03'),
('NV053', N'Lê Mai Chi', N'Kế toán', '0928901235', 'maichi@gmail.com', N'đang ổn', 'CS03'),
('NV058', N'Ngô Vũ Phương', N'Giáo viên', '0973456790', 'vuphuong@gmail.com', N'đang ổn', 'CS03'),
('NV057', N'Đặng Tuyết Nam', N'Giáo viên', '0962345679', 'tuyetnam@gmail.com', N'đang ổn', 'CS03'),
('NV054', N'Phạm Quốc Thuận', N'Giáo viên', '0939012346', 'quocthuan@gmail.com', N'đang ổn', 'CS03'),
('NV060', N'Đỗ Hoàng Quỳnh', N'Giáo viên', '0995678902', 'hoangquynh@gmail.com', N'đang ổn', 'CS03'),
('NV063', N'Lê Hoàng Tùng', N'Giáo viên', '0928901236', 'hoangtung@gmail.com', N'đang ổn', 'CS03'),
('NV056', N'Vũ Quốc Mai', N'Giáo viên', '0951234568', 'quocmai@gmail.com', N'đang ổn', 'CS03'),
('NV059', N'Bùi Minh Quang', N'Giáo viên', '0984567891', 'minhquang@gmail.com', N'đang ổn', 'CS03'),
('NV061', N'Nguyễn Thị Mộng Trinh', N'Giáo viên', '0906789013', 'mongtrinh@gmail.com', N'đang ổn', 'CS03'),
('NV055', N'Hoàng Mai Long', N'Giáo viên', '0940123457', 'mailong@gmail.com', N'đang ổn', 'CS03'),
('NV062', N'Trần Hữu Lâm', N'Giáo viên', '0917890125', 'huulam@gmail.com', N'đang ổn', 'CS03'),

-- Cơ sở CS04
('NV076', N'Vũ Hoàng Long', N'Quản lý', '0952345679', 'hoanglong@gmail.com', N'đang ổn', 'CS04'),
('NV077', N'Đặng Thanh Trúc', N'Kế toán', '0963456790', 'thanhtruc@gmail.com', N'đang ổn', 'CS04'),
('NV078', N'Ngô Duy Nam', N'Kế toán', '0974567891', 'duynam@gmail.com', N'đang ổn', 'CS04'),
('NV087', N'Đặng Thị Hữu Vy', N'Giáo viên', '0963456791', 'huuvy@gmail.com', N'đang ổn', 'CS04');

----du lieu bang hoc vien
INSERT INTO HocVien (MaHocVien, HoTen, NgaySinh, SoDienThoai, Email, TrangThai, MaCoSo) VALUES
--- hoc vien co so 1
('HV001', N'Nguyễn Thị Lan Hương', '2000-05-15', '0901234561', 'lanhuong@gmail.com', N'Đã đóng học phí', 'CS01'),
('HV002', N'Trần Văn Bình', '1999-08-20', '0912345672', 'vanbinh@gmail.com', N'Chưa đóng học phí', 'CS01'),
('HV003', N'Lê Thị Tú', '2001-03-10', '0923456783', 'thitu@gmail.com', N'Đã đóng học phí', 'CS01'),
('HV004', N'Phạm Văn Linh', '2000-12-25', '0934567894', 'vanlinh@gmail.com', N'Chưa đóng học phí', 'CS01'),
('HV005', N'Hoàng Thị Ngọc', '1998-07-30', '0945678905', 'thingoc@gmail.com', N'Đã đóng học phí', 'CS01'),
('HV006', N'Vũ Văn Phong', '2002-01-15', '0956789016', 'vanphong@gmail.com', N'Chưa đóng học phí', 'CS01'),
('HV007', N'Đặng Thị Quỳnh Mai', '1999-11-05', '0967890127', 'quynhmai@gmail.com', N'Đã đóng học phí', 'CS01'),
('HV008', N'Nguyễn Văn Triết', '2001-09-22', '0978901238', 'vantriet@gmail.com', N'Chưa đóng học phí', 'CS01'),
('HV009', N'Bùi Thị Thảo Xuân', '2000-04-18', '0989012349', 'thaoxuan@gmail.com', N'Đã đóng học phí', 'CS01'),
('HV010', N'Đỗ Nguyễn Tâm', '1997-06-12', '0990123450', 'nguyentam@gmail.com', N'Chưa đóng học phí', 'CS01'),
---hoc vien co so 2
('HV011', N'Nguyễn Văn Hòa', '2000-07-12', '0901234511', 'vanhoa@gmail.com', N'Đã đóng học phí', 'CS02'),
('HV012', N'Trần Thị Cúc Trinh', '1999-09-25', '0912345622', 'cuctrinh@gmail.com', N'Chưa đóng học phí', 'CS02'),
('HV013', N'Nguyễn Lê Dũng', '2001-02-18', '0923456733', 'ledung@gmail.com', N'Đã đóng học phí', 'CS02'),
('HV014', N'Phạm Thị Hiền Trang', '2000-11-30', '0934567844', 'hientrang@gmail.com', N'Chưa đóng học phí', 'CS02'),
('HV015', N'Hoàng Đinh Văn Khánh', '1998-04-05', '0945678955', 'vankhanh@gmail.com', N'Đã đóng học phí', 'CS02'),
('HV016', N'Vũ Thị Linh Đan', '2002-06-20', '0956789066', 'linhdan@gmail.com', N'Chưa đóng học phí', 'CS02'),
('HV017', N'Đặng Nguyễn Văn Minh', '1999-12-15', '0967890177', 'vanminh@gmail.com', N'Đã đóng học phí', 'CS02'),
('HV018', N'Ngô Thị Hồng Ngọc', '2001-08-10', '0978901288', 'hongngoc@gmail.com', N'Chưa đóng học phí', 'CS02'),
('HV019', N'Bùi Nguyễn Văn Phát', '2000-03-22', '0989012399', 'vanphat@gmail.com', N'Đã đóng học phí', 'CS02'),
('HV020', N'Đỗ Thị Quỳnh Quyên', '1997-10-08', '0990123400', 'quynhquyen@gmail.com', N'Chưa đóng học phí', 'CS02'),
---hoc vien co so 3
('HV021', N'Nguyễn Thị Bảo Anh', '2000-01-14', '0901234521', 'baoanh@gmail.com', N'Chưa đóng học phí', 'CS03'),
('HV022', N'Trần Lê Phước', '1999-05-28', '0912345632', 'lephuoc@gmail.com', N'Đã đóng học phí', 'CS03'),
('HV023', N'Lê Thị Cẩm Châu', '2001-07-09', '0923456743', 'camchau@gmail.com', N'Chưa đóng học phí', 'CS03'),
('HV024', N'Phạm Nguyễn Văn Duy', '2000-10-16', '0934567854', 'vandu@gmail.com', N'Đã đóng học phí', 'CS03'),
('HV025', N'Hoàng Thị Kiều Giang', '1998-03-23', '0945678965', 'kieugiang@gmail.com', N'Chưa đóng học phí', 'CS03'),
('HV026', N'Vũ Văn Nhật Hào', '2002-09-11', '0956789076', 'nhathao@gmail.com', N'Đã đóng học phí', 'CS03'),
('HV027', N'Đặng Thị Kim Loan', '1999-06-04', '0967890187', 'kimloan@gmail.com', N'Chưa đóng học phí', 'CS03'),
('HV028', N'Ngô Đình Nam', '2001-12-27', '0978901298', 'dinhnam@gmail.com', N'Đã đóng học phí', 'CS03'),
('HV029', N'Bùi Thị Phương Mai', '2000-08-19', '0989012309', 'phuongmai@gmail.com', N'Chưa đóng học phí', 'CS03'),
('HV030', N'Đỗ Văn Thuận', '1997-11-02', '0990123410', 'vanthuan@gmail.com', N'Đã đóng học phí', 'CS03'),
---hoc vien co so 4
('HV031', N'Nguyễn Văn Thế', '2010-02-15', '0901234531', 'vanthe@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV032', N'Trần Thị Minh Huệ', '2011-04-20', '0912345642', 'minhhue@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV033', N'Lê Văn Khoa', '2009-06-25', '0923456753', 'vankhoa@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV034', N'Phạm Thị Thảo Phương', '2010-09-10', '0934567864', 'thaophuong@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV035', N'Hoàng Văn Sơn', '2011-01-05', '0945678975', 'vanson@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV036', N'Vũ Thị Xương', '2009-03-18', '0956789086', 'thixuong@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV037', N'Đặng Văn Xuân', '2010-07-22', '0967890197', 'vanxuan@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV038', N'Trần Nguyễn Minh Chiến', '2011-10-15', '0978901208', 'minhchien@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV039', N'Bùi Văn Ý', '2009-12-30', '0989012319', 'vanyi@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV040', N'Đỗ Thị Ánh Ngọc', '2010-05-08', '0990123420', 'anhngoc@gmail.com', N'Chưa đóng học phí', 'CS04');
go
---du lieu bang khoa hoc
INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc, MoTa, HocPhi, ThoiGian) VALUES
('KH01', N'Tiếng Anh Giao Tiếp Cơ Bản', 'Khóa học giao tiếp cơ bản', 5000000.00, N'3 tháng'),
('KH02', N'Tiếng Anh IELTS 6.0', 'Chuẩn bị cho kỳ thi IELTS', 8000000.00, N'4 tháng'),
('KH03', N'Tiếng Anh TOEIC 700', 'Luyện thi TOEIC', 6000000.00, N'3 tháng'),
('KH04', N'Tiếng Anh Trẻ Em', 'Dành cho học sinh tiểu học', 4000000.00, N'2 tháng'),
('KH05', N'Tiếng Anh Thương Mại', 'Kỹ năng tiếng Anh trong kinh doanh', 7000000.00, N'3 tháng'),
('KH06', N'Tiếng Anh Giao Tiếp Nâng Cao', 'Nâng cao kỹ năng giao tiếp', 6000000.00, N'3 tháng'),
('KH07', N'Tiếng Anh Du Lịch', 'Tiếng Anh cho ngành du lịch', 5500000.00, N'2 tháng'),
('KH08', N'Tiếng Anh Phát Âm', 'Cải thiện phát âm chuẩn', 4500000.00, N'2 tháng'),
('KH09', N'Tiếng Anh Văn Phòng', 'Tiếng Anh cho công việc văn phòng', 6500000.00, N'3 tháng'),
('KH10', N'Tiếng Anh IELTS 7.0', 'Luyện thi IELTS nâng cao', 9000000.00, N'4 tháng');
go
-----du lieu bang lop hoc
INSERT INTO LopHoc (MaLopHoc, TenLopHoc, MaKhoaHoc, MaCoSo, MaGiaoVien, NgayBatDau, NgayKetThuc, CaHoc) VALUES
('LH01', N'Lớp Giao Tiếp Cơ Bản 01', 'KH01', 'CS01', 'NV002', '2025-04-01', '2025-06-30', N'Tối 19:00-21:00'),
('LH02', N'Lớp IELTS 6.0 01', 'KH02', 'CS02', 'NV003', '2025-04-05', '2025-08-05', N'Chiều 14:00-16:00'),
('LH03', N'Lớp TOEIC 700 01', 'KH03', 'CS03', 'NV005', '2025-04-10', '2025-07-10', N'Sáng 09:00-11:00'),
('LH04', N'Lớp Trẻ Em 01', 'KH04', 'CS04', 'NV007', '2025-04-15', '2025-06-15', N'Chiều 15:00-17:00'),
('LH05', N'Lớp Thương Mại 01', 'KH05', 'CS01', 'NV009', '2025-04-20', '2025-07-20', N'Tối 18:30-20:30'),
('LH06', N'Lớp Giao Tiếp Nâng Cao 01', 'KH06', 'CS02', 'NV010', '2025-04-25', '2025-07-25', N'Tối 19:00-21:00'),
('LH07', N'Lớp Du Lịch 01', 'KH07', 'CS03', 'NV005', '2025-05-01', '2025-07-01', N'Sáng 08:00-10:00'),
('LH08', N'Lớp Phát Âm 01', 'KH08', 'CS04', 'NV007', '2025-05-05', '2025-07-05', N'Chiều 14:00-16:00'),
('LH09', N'Lớp Văn Phòng 01', 'KH09', 'CS01', 'NV002', '2025-05-10', '2025-08-10', N'Tối 19:00-21:00'),
('LH10', N'Lớp IELTS 7.0 01', 'KH10', 'CS02', 'NV003', '2025-05-15', '2025-09-15', N'Sáng 09:00-11:00');
go
---du lieu bang 
INSERT INTO DangKyHoc (MaDangKy, MaHocVien, MaLopHoc, NgayDangKy, TrangThai) VALUES
('DK001', 'HV001', 'LH01', '2025-03-15', N'Đã xác nhận'),
('DK002', 'HV002', 'LH01', '2025-03-16', N'Đã xác nhận'),
('DK003', 'HV003', 'LH02', '2025-03-17', N'Chờ duyệt'),
('DK004', 'HV004', 'LH02', '2025-03-18', N'Đã xác nhận'),
('DK005', 'HV005', 'LH03', '2025-03-19', N'Đã xác nhận'),
('DK006', 'HV006', 'LH03', '2025-03-20', N'Chờ duyệt'),
('DK007', 'HV007', 'LH04', '2025-03-21', N'Đã xác nhận'),
('DK008', 'HV008', 'LH04', '2025-03-22', N'Đã xác nhận'),
('DK009', 'HV009', 'LH05', '2025-03-23', N'Đã xác nhận'),
('DK010', 'HV010', 'LH06', '2025-03-24', N'Chờ duyệt');
go

-- thêm dữ liệu bảng phiếu thu
INSERT INTO PhieuThu (MaPhieuThu, MaHocVien, NgayThu, SoTien, GhiChu) VALUES
('PT001', 'HV001', '2025-03-01', 1000000, 'Thu học phí tháng 3'),
('PT002', 'HV002', '2025-03-02', 1500000, 'Thu học phí tháng 3')
go
--thêm dữ liệu bảng điểm thi
INSERT INTO DiemThi (MaDiemThi, MaHocVien, MaKhoaHoc, Diem, NgayThi) VALUES
('DT001', 'HV001', 'KH001', 8.5, '2025-03-15'),
('DT002', 'HV002', 'KH002', 7.0, '2025-03-16')
go
--thêm dữ liệu bảng điểm danh
INSERT INTO DiemDanh (MaDiemDanh, MaHocVien, NgayHoc, TrangThai) VALUES
('DD001', 'HV001', '2025-03-10', 'Có mặt'),
('DD002', 'HV002', '2025-03-10', 'Vắng mặt')
go
--thêm dữ liệu bảng phòng học
INSERT INTO PhongHoc (MaPhong, TenPhong, SucChua, MaCoSo) VALUES
('P001', 'Phòng A101', 30, 'CS001'),
('P002', 'Phòng B102', 25, 'CS002')
go
---them du lieu bang taikhoan
INSERT INTO taiTaiKhoan(tenTK, matKhau) VALUES
('NV001', 'NV001'),
('NV002', 'NV002'),
('NV003', 'NV003'),
('NV004', 'NV004'),
('NV006', 'NV006'),
('NV007', 'NV007')
---them du lieu bang magiamgia
INSERT INTO MaGiamGia (Magiamgia, Tenmagiamgia, Sotienduocgiam, Hansudung, ghichu)
VALUES 
('GG001', N'Giảm giá mùa hè', 50000.00, '2025-06-30', N'Áp dụng cho đơn hàng trên 200,000 VNĐ'),
('GG002', N'Khuyến mãi tân sinh viên', 100000.00, '2025-09-15', N'Chỉ áp dụng cho khách hàng mới'),
('GG003', N'Giảm giá cuối năm', 75000.00, '2025-12-31', N'Không áp dụng cho sản phẩm giảm giá sẵn'),
('GG004', N'Black Friday', 200000.00, '2025-11-30', N'Giảm tối đa 200,000 VNĐ'),
('GG005', N'Chào mừng thành viên', 30000.00, '2025-12-31', N'Áp dụng cho thành viên đăng ký mới');

select * from CoSo
select * from NhanVien
select * from HocVien
select * from KhoaHoc
select * from LopHoc
select * from DangKyHoc
