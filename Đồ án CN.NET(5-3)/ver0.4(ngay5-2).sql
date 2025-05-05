CREATE DATABASE QLTTAN
GO
USE QLTTAN
GO

-- 1. CoSo
CREATE TABLE CoSo (
    MaCoSo VARCHAR(10) PRIMARY KEY,
    TenCoSo NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100)
)
GO

-- 2. ChucVu
CREATE TABLE ChucVu (
    MaChucVu VARCHAR(10) PRIMARY KEY,
    TenChucVu NVARCHAR(100)
)
GO

-- 3. KhoaHoc
CREATE TABLE KhoaHoc (
    MaKhoaHoc VARCHAR(10) PRIMARY KEY,
    TenKhoaHoc NVARCHAR(100),
    MoTa NVARCHAR(250),
    HocPhi FLOAT,
    ThoiGian NVARCHAR(50)
)
GO

-- 4. MaGiamGia
CREATE TABLE MaGiamGia (
    MaGiamGia VARCHAR(10) PRIMARY KEY,
    TenMaGiamGia NVARCHAR(100),
    SoTienDuocGiam FLOAT,
    HanSuDung DATE,
    GhiChu NVARCHAR(250)
)
GO

-- 5. GiaoVien
CREATE TABLE GiaoVien (
    MaGiaoVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    Gioitinh NVARCHAR(15),
    Ngaysinh DATE,
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100),
    MaCoSo VARCHAR(10),
    GhiChu NVARCHAR(250),
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo)
)
GO

-- 6. NhanVien
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    MaChucVu VARCHAR(10),
    GioiTinh NVARCHAR(10),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100),
    GhiChu NVARCHAR(250),
    MaCoSo VARCHAR(10),
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo),
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
)
GO

-- 7. HocVien
CREATE TABLE HocVien (
    MaHocVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    SoDienThoai VARCHAR(10),
    Email VARCHAR(100),
    TrangThai NVARCHAR(250),
    MaCoSo VARCHAR(10),
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo)
)
GO

-- 8. PhongHoc
CREATE TABLE PhongHoc (
    MaPhong VARCHAR(10) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    SucChua INT,
    MaCoSo VARCHAR(10),
    FOREIGN KEY (MaCoSo) REFERENCES CoSo(MaCoSo)
)
GO

-- 9. Luong
CREATE TABLE Luong (
    MaLuong VARCHAR(10) PRIMARY KEY,
    MaGiaoVien VARCHAR(10),
    SoTienLuong FLOAT,
    NgayTra DATE,
    GhiChu NVARCHAR(250),
    SoGioLamViec FLOAT, -- Cột mới được thêm
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien)
)
GO

-- 10. TaiKhoan
CREATE TABLE TaiKhoan (
    TenTK VARCHAR(10) PRIMARY KEY,
    MatKhau VARCHAR(100)
)
GO

-- 11. LopHoc
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
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien),
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong)
)
GO

-- 12. HoaDon
CREATE TABLE HoaDon (
    MaHoaDon VARCHAR(10) PRIMARY KEY,
    MaHocVien VARCHAR(10),
    NgayLapHoaDon DATE,
    TongTien FLOAT,
    MaGiamGia VARCHAR(10),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaGiamGia) REFERENCES MaGiamGia(MaGiamGia)
)
GO

-- 13. HoaDonChiTiet
CREATE TABLE HoaDonChiTiet (
    MaHoaDonChiTiet VARCHAR(10) PRIMARY KEY,
    MaHoaDon VARCHAR(10),
    MaKhoaHoc VARCHAR(10),
    SoTien FLOAT,
    GhiChu NVARCHAR(250),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
)
GO

-- 14. PhieuThu
CREATE TABLE PhieuThu (
    MaPhieuThu VARCHAR(10) PRIMARY KEY,
    MaHocVien VARCHAR(10),
    NgayThu DATE,
    SoTien FLOAT,
    GhiChu NVARCHAR(250),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien)
)
GO

-- 15. DiemThi
CREATE TABLE DiemThi (
    MaDiemThi VARCHAR(10) PRIMARY KEY,
    MaHocVien VARCHAR(10),
    MaKhoaHoc VARCHAR(10),
    Diem FLOAT,
    NgayThi DATE,
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
)
GO

-- 16. DiemDanh
CREATE TABLE DiemDanh (
    MaDiemDanh VARCHAR(10) PRIMARY KEY,             
    MaGiaoVien VARCHAR(10),                          
    TenGiaoVien NVARCHAR(100),                       
    MaHocVien VARCHAR(10),                           
    NgayHoc DATE,                                   
    TrangThai NVARCHAR(50),                         
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien)
)
GO

-- 17. LichHoc
CREATE TABLE LichHoc (
    MaLichHoc VARCHAR(10) PRIMARY KEY,
    MaLopHoc VARCHAR(10),
    NgayHoc DATE,
    CaHoc NVARCHAR(50),
    MaPhong VARCHAR(10),
    MaGiaoVien VARCHAR(10),
    FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc),
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong),
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien)
)
GO

-- 18. ChamCong (Bảng mới được thêm)
CREATE TABLE ChamCong (
    MaChamCong VARCHAR(10) PRIMARY KEY,
    MaGiaoVien VARCHAR(10),
    NgayLamViec DATE,
    SoGioLamViec FLOAT,
    GhiChu NVARCHAR(250),
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien)
)
GO

-- Chèn dữ liệu
--- Cơ sở
INSERT INTO CoSo (MaCoSo, TenCoSo, DiaChi, SoDienThoai, Email) VALUES
('CS01', N'Cơ sở TP.HCM', N'45 Nguyễn Huệ, TP.HCM', '0978123456', 'tphcm@eglagena.com'),
('CS02', N'Cơ sở Hà Nội', N'12 Hàng Bài, Hà Nội', '0918765432', 'hanoi@eglagena.com'),
('CS03', N'Cơ sở Bình Định', N'23 Trần Hưng Đạo, Bình Định', '0901234567', 'binhdinh@eglagena.com'),
('CS04', N'Cơ sở Lâm Đồng', N'67 Hồ Xuân Hương, Lâm Đồng', '0938765432', 'lamdong@eglagena.com')
GO

--- Chức vụ
INSERT INTO ChucVu (MaChucVu, TenChucVu) VALUES
('CV001', N'Quản lý'),
('CV002', N'Nhân Viên')
GO

--- Khoá học
INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc, MoTa, HocPhi, ThoiGian)
VALUES
('KH001', N'Tiếng Anh Giao Tiếp Cơ Bản', N'Khoá học giúp học viên giao tiếp tự tin trong các tình huống thường ngày.', 2500000, N'2 tháng'),
('KH002', N'Tiếng Anh Giao Tiếp Nâng Cao', N'Nâng cao kỹ năng phản xạ và từ vựng trong giao tiếp thực tế.', 3500000, N'2.5 tháng'),
('KH003', N'Tiếng Anh Cho Người Mất Gốc', N'Phù hợp với người bắt đầu học lại từ đầu, củng cố nền tảng ngữ pháp và phát âm', 3000000, N'3 tháng'),
('KH004', N'Luyện Thi IELTS 6.5+', N'Khoá học giúp học viên đạt mục tiêu điểm IELTS 6.5 trở lên.', 4500000, N'4 tháng'),
('KH005', N'Tiếng Anh Trong Công Sở', N'Rèn luyện kỹ năng email, hội thoại và thuyết trình trong môi trường công việc', 3200000, N'2 tháng'),
('KH006', N'Tiếng Anh TOEIC 650+', N'Rèn kĩ năng nghe nói, đọc viết', 4000000, N'8 tháng'),
('KH007', N'IELTS 5.5+', N'Luyện 4 kỹ năng IELTS ở mức trung bình khá', 4000000, N'12 tuần'),
('KH008', N'Tiếng Anh Thiếu Nhi', N'Chương trình học sinh động phù hợp cho trẻ từ 6–10 tuổi', 2000000, N'6 tuần'),
('KH009', N'TOEIC 450+', N'Luyện thi TOEIC cho người mới bắt đầu định hướng', 2800000, N'10 tuần'),
('KH010', N'Tiếng Anh Thiếu Niên', N'Phát triển kỹ năng toàn diện cho học sinh THCS', 2400000, N'8 tuần')
GO

--- Mã giảm giá
INSERT INTO MaGiamGia (MaGiamGia, TenMaGiamGia, SoTienDuocGiam, HanSuDung, GhiChu) VALUES
('GG001', N'Giảm giá mùa hè', 50000.00, '2025-06-30', N'Áp dụng cho đơn hàng trên 200,000 VNĐ'),
('GG002', N'Khuyến mãi tân sinh viên', 100000.00, '2025-09-15', N'Chỉ áp dụng cho khách hàng mới'),
('GG003', N'Giảm giá cuối năm', 75000.00, '2025-12-31', N'Không áp dụng cho sản phẩm giảm giá sẵn'),
('GG004', N'Black Friday', 200000.00, '2025-11-30', N'Giảm tối đa 200,000 VNĐ'),
('GG005', N'Chào mừng thành viên', 30000.00, '2025-12-31', N'Áp dụng cho thành viên đăng ký mới')
GO

--- Phòng học
INSERT INTO PhongHoc (MaPhong, TenPhong, SucChua, MaCoSo) VALUES
('P001', 'Phòng A101', 30, 'CS01'),
('P002', 'Phòng A102', 25, 'CS01'),
('P003', 'Phòng A103', 25, 'CS01'),
('P004', 'Phòng B101', 25, 'CS02'),
('P005', 'Phòng B102', 25, 'CS02'),
('P006', 'Phòng B103', 25, 'CS02'),
('P007', 'Phòng C101', 25, 'CS03'),
('P008', 'Phòng C102', 25, 'CS03'),
('P009', 'Phòng C103', 25, 'CS03'),
('P010', 'Phòng D101', 25, 'CS04'),
('P011', 'Phòng D102', 25, 'CS04'),
('P012', 'Phòng D103', 25, 'CS04')
GO

--- Giáo viên
INSERT INTO GiaoVien (MaGiaoVien, HoTen, Gioitinh, Ngaysinh, SoDienThoai, Email, MaCoSo, GhiChu) VALUES
('GV001', N'Trần Mai Văn Kha', N'Nam', '1985-03-15', '0912345679', 'maivanha@gmail.com', 'CS01', N'Giáo viên Tiếng Anh'),
('GV002', N'Lê Duy Khải', N'Nam', '1990-07-22', '0923456790', 'duykhai@gmail.com', 'CS01', N'Giáo viên Tiếng Anh'),
('GV003', N'Hoàng Lan Nam', N'Nam', '1988-11-30', '0945678902', 'lannam@gmail.com', 'CS01', N'Giáo viên Tiếng Anh'),
('GV004', N'Đặng Thi Giang', N'Nữ', '1995-09-25', '0967890124', 'thigiang@gmail.com', 'CS01', N'Giáo viên Tiếng Anh'),
('GV005', N'Bùi Thảo Uyên', N'Nữ', '1990-07-22', '0989012346', 'thaouyen@gmail.com', 'CS01', N'Giáo viên Tiếng Anh'),
---Cơ sở 2
('GV006', N'Đỗ Quốc Linh', N'Nam', '1988-11-30', '0990123457', 'quoclinh@gmail.com', 'CS02', N'Giáo viên Tiếng Anh'),
('GV007', N'Nguyễn Thị Hồng', N'Nữ', '1990-05-12', '0912345678', 'hongnguyen@gmail.com', 'CS02', N'Giáo viên Tiếng Anh'),
('GV008', N'Trần Văn Minh', N'Nam', '1985-03-22', '0987654321', 'minhtran@gmail.com', 'CS02', N'Giáo viên Tiếng Anh'),
('GV009', N'Phạm Thị Lan', N'Nữ', '1992-09-14', '0978123456', 'lanpham@gmail.com', 'CS02', N'Giáo viên Tiếng Anh'),
('GV010', N'Lê Quang Huy', N'Nam', '1987-07-07', '0901122334', 'huy@gmail.com', 'CS02', N'Giáo viên Tiếng Anh'),
--- Cơ sở 3
('GV011', N'Vũ Thị Thuỳ Linh', N'Nữ', '1991-04-18', '0911223344', 'maivu@gmail.com', 'CS03', N'Giáo viên Tiếng Anh'),
('GV012', N'Ngô Văn Thành Nam', N'Nam', '1986-12-05', '0933445566', 'thanhngo@gmail.com', 'CS03', N'Giáo viên Tiếng Anh'),
('GV013', N'Đặng Thiều Quang Tuấn', N'Nam', '1989-06-21', '0977332211', 'tuandang@gmail.com', 'CS03', N'Giáo viên Tiếng Anh'),
('GV014', N'Lý Thị Mỹ Hạnh', N'Nữ', '1993-08-30', '0909988776', 'hanhly@gmail.com', 'CS03', N'Giáo viên Tiếng Anh'),
('GV015', N'Trịnh Thị Châu', N'Nữ', '1990-02-10', '0966112233', 'chautrinh@gmail.com', 'CS03', N'Giáo viên Tiếng Anh'),
--- Cơ sở 4
('GV016', N'Hoàng Văn Minh Tùng', N'Nam', '1988-01-15', '0912003344', 'phuchoang@gmail.com', 'CS04', N'Giáo viên Tiếng Anh'),
('GV017', N'Nguyễn Thị Kiều My', N'Nữ', '1991-11-22', '0933001122', 'oanhkim@gmail.com', 'CS04', N'Giáo viên Tiếng Anh'),
('GV018', N'Phan Minh Nhật', N'Nam', '1987-04-09', '0977990011', 'nhatphan@gmail.com', 'CS04', N'Giáo viên Tiếng Anh'),
('GV019', N'Tô Thị Bích Hữu', N'Nữ', '1992-06-28', '0909887766', 'ngocto@gmail.com', 'CS04', N'Giáo viên Tiếng Anh'),
('GV020', N'Lê Văn Tùng', N'Nam', '1990-09-03', '0988004455', 'tunle@gmail.com', 'CS04', N'Giáo viên Tiếng Anh')
GO

--- Nhân viên
INSERT INTO NhanVien (MaNhanVien, HoTen, MaChucVu, GioiTinh, SoDienThoai, Email, GhiChu, MaCoSo) VALUES
-- Cơ sở CS01
('NV001', N'Nguyễn Minh Thuận', 'CV001', N'Nam', '0901234560', 'minhthuan@gmail.com', N'đang ổn', 'CS01'),
('NV002', N'Trần Mai Văn Kha', 'CV002', N'Nam', '0912345679', 'maivanha@gmail.com', N'đang ổn', 'CS01'),
('NV003', N'Lê Duy Khải', 'CV002', N'Nam', '0923456790', 'duykhai@gmail.com', N'đang ổn', 'CS01'),
('NV004', N'Bùi Thảo Uyên', 'CV002', N'Nữ', '0989012346', 'thaouyen@gmail.com', N'đang ổn', 'CS01'),
('NV005', N'Vũ Thái Hòa', 'CV002', N'Nữ', '0956789013', 'thaihoa@gmail.com', N'đang ổn', 'CS01'),

-- Cơ sở CS02
('NV006', N'Vũ Thanh Lê', 'CV001', N'Nam', '0958901235', 'thanhle@gmail.com', N'đang ổn', 'CS02'),
('NV007', N'Đặng Nguyễn Lê Nguyên', 'CV002', N'Nam', '0969012346', 'lenguyen@gmail.com', N'đang ổn', 'CS02'),
('NV008', N'Ngô Hồng Thắm', 'CV002', N'Nữ', '0970123457', 'hongtham@gmail.com', N'đang ổn', 'CS02'),
('NV009', N'Vũ Kiều My', 'CV002', N'Nữ', '0959012346', 'kieumy@gmail.com', N'đang ổn', 'CS02'),
('NV010', N'Trần Mạnh Hùng', 'CV002', N'Nam', '0915678902', 'manhhung@gmail.com', N'đang ổn', 'CS02'),

-- Cơ sở CS03
('NV011', N'Nguyễn Thi Giang', 'CV001', N'Nữ', '0906789013', 'thigiang@gmail.com', N'đang ổn', 'CS03'),
('NV012', N'Trần Thị Tuyết', 'CV002', N'Nữ', '0917890124', 'thituyet@gmail.com', N'đang ổn', 'CS03'),
('NV013', N'Lê Mai Chi', 'CV002', N'Nữ', '0928901235', 'maichi@gmail.com', N'đang ổn', 'CS03'),
('NV014', N'Ngô Vũ Phương', 'CV002', N'Nữ', '0973456790', 'vuphuong@gmail.com', N'đang ổn', 'CS03'),
('NV015', N'Đặng Tuyết Nam', 'CV002', N'Nam', '0962345679', 'tuyetnam@gmail.com', N'đang ổn', 'CS03'),

-- Cơ sở CS04
('NV016', N'Vũ Hoàng Long', 'CV001', N'Nam', '0952345679', 'hoanglong@gmail.com', N'đang ổn', 'CS04'),
('NV017', N'Đặng Thanh Trúc', 'CV002', N'Nữ', '0963456790', 'thanhtruc@gmail.com', N'đang ổn', 'CS04'),
('NV018', N'Ngô Duy Nam', 'CV002', N'Nam', '0974567891', 'duynam@gmail.com', N'đang ổn', 'CS04'),
('NV019', N'Đặng Thị Hữu Vy', 'CV002', N'Nữ', '0963456791', 'huuvy@gmail.com', N'đang ổn', 'CS04'),
('NV020', N'Phạm Quốc Thuận', 'CV002', N'Nam', '0939012346', 'quocthuan@gmail.com', N'đang ổn', 'CS04')
GO

--- Học viên
INSERT INTO HocVien (MaHocVien, HoTen, NgaySinh, SoDienThoai, Email, TrangThai, MaCoSo) VALUES
-- Học viên cơ sở 1
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
('HV041', N'Đỗ Thiên', '1997-01-10', '0912345041', 'DThien@gmail.com', N'Đã đóng học phí', 'CS01'),
('HV042', N'Nguyễn Minh Tâm', '1996-11-12', '0912345042', 'MTam@gmail.com', N'Đã đóng học phí', 'CS01'),
('HV043', N'Nguyễn Duy Khang', '1998-03-25', '0912345043', 'duykhang@gmail.com', N'Chưa đóng học phí', 'CS01'),
('HV044', N'Nguyễn Văn Tuấn', '1995-09-20', '0912345044', 'tuannguyen@gmail.com', N'Chưa đóng học phí', 'CS01'),
('HV045', N'Bùi Yến', '1999-06-14', '0912345045', 'yenbui@gmail.com', N'Đã đóng học phí', 'CS01'),
-- Học viên cơ sở 2
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
('HV046', N'Đào Thị Thanh Thảo', '1997-02-03', '0912345046', 'thanhthao@gmail.com', N'Chưa đóng học phí', 'CS02'),
('HV047', N'Trần Phạm Ánh Ngọc Hà', '1996-08-22', '0912345047', 'hatran@gmail.com', N'Chưa đóng học phí', 'CS02'),
('HV048', N'Nguyễn Quang Nguyên', '1998-12-09', '0912345048', 'quangnguyen@gmail.com', N'Đã đóng học phí', 'CS02'),
('HV049', N'Nguyễn Ngọc Anh', '1997-05-18', '0912345049', 'anhngoc@gmail.com', N'Chưa đóng học phí', 'CS02'),
('HV050', N'Phan Duy Anh', '1995-10-30', '0912345050', 'duyanh@gmail.com', N'Đã đóng học phí', 'CS02'),
-- Học viên cơ sở 3
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
('HV051', N'Nguyễn Thị Phương Thảo', '1996-03-19', '0912345051', 'phuongthao@gmail.com', N'Chưa đóng học phí', 'CS03'),
('HV052', N'Lê Nguyễn Thảo Ngân', '1998-07-04', '0912345052', 'thaongan@gmail.com', N'Đã đóng học phí', 'CS03'),
('HV053', N'Lê Kim Dung', '1997-09-15', '0912345053', 'kimdung@gmail.com', N'Chưa đóng học phí', 'CS03'),
('HV054', N'Hoàng Đạt Dũng', '1996-04-21', '0912345054', 'datdung@gmail.com', N'Đã đóng học phí', 'CS03'),
('HV055', N'Lê Thị Vui', '1999-01-11', '0912345055', 'levui@gmail.com', N'Chưa đóng học phí', 'CS03'),
-- Học viên cơ sở 4
('HV031', N'Nguyễn Văn Thế', '2010-02-15', '0901234531', 'vanthe@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV032', N'Trần Thị Minh Huệ', '2011-04-20', '0912345642', 'minhhue@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV033', N'Lê Văn Khoa', '2009-06-25', '0923456753', 'vankhoa@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV034', N'Phạm Thị Thảo Phương', '2010-09-10', '0934567864', 'thaophuong@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV035', N'Hoàng Văn Sơn', '2011-01-05', '0945678975', 'vanson@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV036', N'Vũ Thị Xương', '2009-03-18', '0956789086', 'thixuong@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV037', N'Đặng Văn Xuân', '2010-07-22', '0967890197', 'vanxuan@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV038', N'Trần Nguyễn Minh Chiến', '2011-10-15', '0978901208', 'minhchien@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV039', N'Bùi Văn Ý', '2009-12-30', '0989012319', 'vanyi@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV040', N'Đỗ Thị Ánh Ngọc', '2010-05-08', '0990123420', 'anhngoc@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV056', N'Triệu Bình', '1995-12-17', '0912345056', 'trieubinh@gmail.com', N'Chưa đóng học phí', 'CS04'),
('HV057', N'Triệu Tuyên', '1998-05-27', '0912345057', 'trieutuyen@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV058', N'Triệu Hằng', '1997-06-08', '0912345058', 'trieuhang@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV059', N'Đỗ Thị Tường Vy', '1996-10-13', '0912345059', 'dovy@gmail.com', N'Đã đóng học phí', 'CS04'),
('HV060', N'Nguyễn Văn Được', '1995-08-02', '0912345060', 'vanduoc@gmail.com', N'Chưa đóng học phí', 'CS04')
GO

--- Lớp học
INSERT INTO LopHoc (MaLopHoc, TenLopHoc, MaKhoaHoc, MaCoSo, MaGiaoVien, NgayBatDau, NgayKetThuc, CaHoc, MaPhong) VALUES
('LH01', N'Lớp Giao Tiếp Cơ Bản 01', 'KH001', 'CS01', 'GV002', '2025-04-01', '2025-06-30', N'Tối 19:00-21:00', 'P001'),
('LH02', N'Lớp IELTS 6.0 01', 'KH002', 'CS02', 'GV003', '2025-04-05', '2025-08-05', N'Chiều 14:00-16:00', 'P004'),
('LH03', N'Lớp TOEIC 700 01', 'KH003', 'CS03', 'GV005', '2025-04-10', '2025-07-10', N'Sáng 09:00-11:00', 'P007'),
('LH04', N'Lớp Trẻ Em 01', 'KH004', 'CS04', 'GV002', '2025-04-15', '2025-06-15', N'Chiều 15:00-17:00', 'P010'),
('LH05', N'Lớp Thương Mại 01', 'KH005', 'CS01', 'GV003', '2025-04-20', '2025-07-20', N'Tối 18:30-20:30', 'P002'),
('LH06', N'Lớp Giao Tiếp Nâng Cao 01', 'KH006', 'CS02', 'GV001', '2025-04-25', '2025-07-25', N'Tối 19:00-21:00', 'P005'),
('LH07', N'Lớp Du Lịch 01', 'KH007', 'CS03', 'GV005', '2025-05-01', '2025-07-01', N'Sáng 08:00-10:00', 'P008'),
('LH08', N'Lớp Phát Âm 01', 'KH008', 'CS04', 'GV006', '2025-05-05', '2025-07-05', N'Chiều 14:00-16:00', 'P011'),
('LH09', N'Lớp Văn Phòng 01', 'KH009', 'CS01', 'GV002', '2025-05-10', '2025-08-10', N'Tối 19:00-21:00', 'P003'),
('LH10', N'Lớp IELTS 7.0 01', 'KH010', 'CS02', 'GV003', '2025-05-15', '2025-09-15', N'Sáng 09:00-11:00', 'P006')
GO

--- Tài khoản
	INSERT INTO TaiKhoan (TenTK, MatKhau) VALUES
-- Quản lý (CV001)
('ADThuan', 'Thuan123'), 
('ADLe', 'Le123'),       
('ADGiang', 'Giang123'), 
('ADLong', 'Long123'),   

-- Nhân viên(CV002)
('VKha', 'kha123'),    
('DKhai', 'khai123'),    
('TUyen', 'uyen123'),    
('THoa', 'hoa123'),      

('LNguyen', 'nguyen123'),
('HTham', 'tham123'),
('KMy', 'my123'),
('MHung', 'hung123'),

('TTuyet', 'tuyet123'),
('MChi', 'chi123'),
('VPhuong', 'phuong123'),
('TNam', 'nam123'),

('TTruc', 'truc123'),
('DNam', 'nam123'),
('HVy', 'vy123'),
('QThuan', 'thuan123'),
----Giáo viên
-- Cơ sở CS01
('gvVKha', 'VKha123'),       
('gvDKhai', 'DKhai123'),     
('gvLNam', 'LNam123'),      
('gvTGiang', 'TGiang123'),
('gvTUyen', 'TUyen123'), 

-- Cơ sở CS02
('gvQLinh', 'QLinh123'),
('gvHNguyen', 'HNguyen123'),
('gvMMinh', 'MMinh123'),
('gvLLan', 'LLan123'),
('gvQHuy', 'QHuy123'),

-- Cơ sở CS03
('gvTLinh', 'TLinh123'),
('gvTNam', 'TNam123'), 
('gvQTuan', 'QTuan123'),
('gvMHanh', 'MHanh123'),
('gvCChau', 'CChau123'),

-- Cơ sở CS04
('gvMTung', 'MTung123'),
('gvKMy', 'KMy123'),
('gvPNhat', 'PNhat123'), 
('gvBHuu', 'BHuu123'), 
('gvVTung', 'VTung123')



--- Phiếu thu
INSERT INTO PhieuThu (MaPhieuThu, MaHocVien, NgayThu, SoTien, GhiChu) VALUES
('PT001', 'HV001', '2025-03-02', 1300000, N'Thu học phí tháng 6'),
('PT002', 'HV002', '2025-03-02', 1000000, N'Thu học phí tháng 6'),
('PT003', 'HV003', '2025-03-04', 1500000, N'Thu học phí tháng 4'),
('PT004', 'HV004', '2025-03-06', 1200000, N'Thu học phí tháng 7'),
('PT005', 'HV005', '2025-03-08', 1350000, N'Thu học phí tháng 9'),
('PT006', 'HV006', '2025-03-10', 1100000, N'Thu học phí tháng 3'),
('PT007', 'HV007', '2025-03-12', 1450000, N'Thu học phí tháng 1'),
('PT008', 'HV008', '2025-03-14', 1250000, N'Thu học phí tháng 5'),
('PT009', 'HV009', '2025-03-16', 1150000, N'Thu học phí tháng 8'),
('PT010', 'HV010', '2025-03-18', 1300000, N'Thu học phí tháng 2'),
('PT011', 'HV011', '2025-03-20', 1400000, N'Thu học phí tháng 11'),
('PT012', 'HV012', '2025-03-22', 1000000, N'Thu học phí tháng 6'),
('PT013', 'HV013', '2025-03-24', 1350000, N'Thu học phí tháng 10'),
('PT014', 'HV014', '2025-03-26', 1450000, N'Thu học phí tháng 4'),
('PT015', 'HV015', '2025-03-28', 1150000, N'Thu học phí tháng 12'),
('PT016', 'HV016', '2025-03-30', 1250000, N'Thu học phí tháng 3'),
('PT017', 'HV017', '2025-03-03', 1500000, N'Thu học phí tháng 7'),
('PT018', 'HV018', '2025-03-05', 1100000, N'Thu học phí tháng 1'),
('PT019', 'HV019', '2025-03-07', 1200000, N'Thu học phí tháng 8'),
('PT020', 'HV020', '2025-03-09', 1300000, N'Thu học phí tháng 6'),
('PT021', 'HV021', '2025-03-11', 1400000, N'Thu học phí tháng 5'),
('PT022', 'HV022', '2025-03-13', 1000000, N'Thu học phí tháng 10'),
('PT023', 'HV023', '2025-03-15', 1250000, N'Thu học phí tháng 2'),
('PT024', 'HV024', '2025-03-17', 1350000, N'Thu học phí tháng 11'),
('PT025', 'HV025', '2025-03-19', 1450000, N'Thu học phí tháng 4'),
('PT026', 'HV026', '2025-03-21', 1150000, N'Thu học phí tháng 9'),
('PT027', 'HV027', '2025-03-23', 1300000, N'Thu học phí tháng 12'),
('PT028', 'HV028', '2025-03-25', 1100000, N'Thu học phí tháng 3'),
('PT029', 'HV029', '2025-03-27', 1200000, N'Thu học phí tháng 6'),
('PT030', 'HV030', '2025-03-29', 1500000, N'Thu học phí tháng 5'),
('PT031', 'HV031', '2025-03-31', 1400000, N'Thu học phí tháng 1'),
('PT032', 'HV032', '2025-03-02', 1450000, N'Thu học phí tháng 8'),
('PT033', 'HV033', '2025-03-04', 1250000, N'Thu học phí tháng 9'),
('PT034', 'HV034', '2025-03-06', 1350000, N'Thu học phí tháng 2'),
('PT035', 'HV035', '2025-03-08', 1000000, N'Thu học phí tháng 11'),
('PT036', 'HV036', '2025-03-10', 1150000, N'Thu học phí tháng 7'),
('PT037', 'HV037', '2025-03-12', 1300000, N'Thu học phí tháng 4'),
('PT038', 'HV038', '2025-03-14', 1100000, N'Thu học phí tháng 10'),
('PT039', 'HV039', '2025-03-16', 1400000, N'Thu học phí tháng 3'),
('PT040', 'HV040', '2025-03-18', 1500000, N'Thu học phí tháng 6'),
('PT041', 'HV041', '2025-03-20', 1200000, N'Thu học phí tháng 1'),
('PT042', 'HV042', '2025-03-22', 1450000, N'Thu học phí tháng 8'),
('PT043', 'HV043', '2025-03-24', 1350000, N'Thu học phí tháng 5'),
('PT044', 'HV044', '2025-03-26', 1250000, N'Thu học phí tháng 7'),
('PT045', 'HV045', '2025-03-28', 1150000, N'Thu học phí tháng 12'),
('PT046', 'HV046', '2025-03-30', 1000000, N'Thu học phí tháng 2'),
('PT047', 'HV047', '2025-03-03', 1500000, N'Thu học phí tháng 9'),
('PT048', 'HV048', '2025-03-05', 1100000, N'Thu học phí tháng 4'),
('PT049', 'HV049', '2025-03-07', 1300000, N'Thu học phí tháng 10'),
('PT050', 'HV050', '2025-03-09', 1400000, N'Thu học phí tháng 6'),
('PT051', 'HV051', '2025-03-11', 1200000, N'Thu học phí tháng 11'),
('PT052', 'HV052', '2025-03-13', 1450000, N'Thu học phí tháng 3'),
('PT053', 'HV053', '2025-03-15', 1250000, N'Thu học phí tháng 7'),
('PT054', 'HV054', '2025-03-17', 1350000, N'Thu học phí tháng 2'),
('PT055', 'HV055', '2025-03-19', 1150000, N'Thu học phí tháng 5'),
('PT056', 'HV056', '2025-03-21', 1000000, N'Thu học phí tháng 10'),
('PT057', 'HV057', '2025-03-23', 1500000, N'Thu học phí tháng 1'),
('PT058', 'HV058', '2025-03-25', 1100000, N'Thu học phí tháng 12'),
('PT059', 'HV059', '2025-03-27', 1300000, N'Thu học phí tháng 4'),
('PT060', 'HV060', '2025-03-29', 1400000, N'Thu học phí tháng 9')
GO

--- Điểm thi
INSERT INTO DiemThi (MaDiemThi, MaHocVien, MaKhoaHoc, Diem, NgayThi) VALUES
('DT001', 'HV001', 'KH001', 8.5, '2025-03-15'),
('DT002', 'HV002', 'KH002', 7.0, '2025-03-16')
GO

--- điểm danh
INSERT INTO DiemDanh (MaDiemDanh, MaGiaoVien, TenGiaoVien, MaHocVien, NgayHoc, TrangThai) VALUES
('DD001', 'GV001', N'Trần Mai Văn Kha', 'HV001', '2025-03-10', N'Có mặt'),
('DD002', 'GV001', N'Lê Duy Khải', 'HV002', '2025-03-10', N'Vắng mặt'),
('DD003', 'GV002', N'Hoàng Lan Nam', 'HV003', '2025-03-10', N'Trễ'),
('DD004', 'GV002', N'Đặng Thị Giang', 'HV004', '2025-03-10', N'Có mặt'),
('DD005', 'GV001', N'Bùi Thảo Uyên', 'HV006', '2025-03-11', N'Có mặt'),
('DD006', 'GV001', N'Đỗ Quốc Linh', 'HV007', '2025-03-11', N'Có mặt')

GO

--- Lương
INSERT INTO Luong (MaLuong, MaGiaoVien, SoTienLuong, NgayTra, GhiChu, SoGioLamViec) VALUES
('L001', 'GV001', 5000000, '2025-04-01', N'Lương tháng 4/2025', 80),
('L002', 'GV002', 6000000, '2025-04-01', N'Lương tháng 4/2025 + thưởng', 90),
('L003', 'GV004', 4500000, '2025-04-01', N'Lương tháng 4/2025', 70),
('L004', 'GV006', 5200000, '2025-05-01', N'Lương tháng 5/2025', 85)
GO

--- Hoá đơn
INSERT INTO HoaDon (MaHoaDon, MaHocVien, NgayLapHoaDon, TongTien, MaGiamGia) VALUES
('HD001', 'HV001', '2025-03-01', 4500000.00, 'GG001'),
('HD002', 'HV002', '2025-03-02', 8000000.00, NULL),
('HD003', 'HV003', '2025-03-03', 5250000.00, 'GG003'),
('HD004', 'HV004', '2025-03-04', 4000000.00, NULL),
('HD005', 'HV005', '2025-03-05', 1150000.00, 'GG004'),
('HD006', 'HV006', '2025-03-06', 6000000.00, NULL),
('HD007', 'HV007', '2025-03-07', 5000000.00, 'GG005'),
('HD008', 'HV008', '2025-03-08', 4500000.00, NULL),
('HD009', 'HV009', '2025-03-09', 1050000.00, 'GG002'),
('HD010', 'HV010', '2025-03-10', 9000000.00, NULL)
GO

--- Hoá đơn chi tiết
INSERT INTO HoaDonChiTiet (MaHoaDonChiTiet, MaHoaDon, MaKhoaHoc, SoTien, GhiChu) VALUES
('HDC001', 'HD001', 'KH001', 5000000.00, N'Học lại trả phí'),
('HDC002', 'HD002', 'KH002', 8000000.00, N'Không có ghi chú'),
('HDC003', 'HD003', 'KH003', 6000000.00, N'Đăng kí lần đầu'),
('HDC004', 'HD004', 'KH004', 4000000.00, N'Không hoàn tiền sau đăng kí'),
('HDC005', 'HD005', 'KH005', 7000000.00, N'Học lại trả phí'),
('HDC006', 'HD005', 'KH006', 6000000.00, N'Không có ghi chú'),
('HDC007', 'HD006', 'KH006', 6000000.00, N'Không hoàn tiền sau đăng kí'),
('HDC008', 'HD007', 'KH007', 5500000.00, N'Học lại trả phí'),
('HDC009', 'HD008', 'KH008', 4500000.00, N'Không có ghi chú'),
('HDC010', 'HD009', 'KH009', 6500000.00, N'Khóa học tiếng Anh văn phòng'),
('HDC011', 'HD009', 'KH010', 5000000.00, N'Không hoàn tiền sau đăng kí'),
('HDC012', 'HD010', 'KH010', 9000000.00, N'Học lại trả phí')
GO

--- Chấm công
INSERT INTO ChamCong (MaChamCong, MaGiaoVien, NgayLamViec, SoGioLamViec, GhiChu) VALUES
('CC001', 'GV002', '2025-04-01', 4.0, N'Dạy lớp LH01, ca tối'),
('CC002', 'GV002', '2025-04-02', 4.0, N'Dạy lớp LH09, ca tối'),
('CC003', 'GV003', '2025-04-01', 4.5, N'Dạy lớp LH02, ca chiều'),
('CC004', 'GV003', '2025-04-03', 4.5, N'Dạy lớp LH10, ca sáng'),
('CC005', 'GV005', '2025-04-01', 3.5, N'Dạy lớp LH03, ca sáng'),
('CC006', 'GV005', '2025-04-02', 3.5, N'Dạy lớp LH07, ca sáng'),
('CC007', 'GV006', '2025-04-01', 4.0, N'Dạy lớp LH04, ca chiều'),
('CC008', 'GV006', '2025-04-03', 4.0, N'Dạy lớp LH08, ca chiều'),
('CC009', 'GV002', '2025-04-01', 4.0, N'Dạy lớp LH05, ca tối'),
('CC010', 'GV001', '2025-04-02', 4.0, N'Dạy lớp LH06, ca tối')
GO

--- Lịch học
	INSERT INTO LichHoc (MaLichHoc, MaLopHoc, NgayHoc, CaHoc, MaPhong, MaGiaoVien) VALUES --sua lai MaNhanVien thanh magv, đã sửa
	('LHOC001', 'LH01', '2025-04-03', N'Sáng 08:00-10:00', 'P001', 'GV001'),
	('LHOC002', 'LH02', '2025-04-07', N'Chiều 13:00-15:00', 'P001', 'GV002'),
	('LHOC003', 'LH03', '2025-04-10', N'Trưa 10:00-12:00', 'P001', 'GV003'),
	('LHOC004', 'LH04', '2025-04-14', N'Chiều 15:00-17:00', 'P001', 'GV004'),
	('LHOC005', 'LH05', '2025-04-17', N'Sáng 08:00-10:00', 'P001', 'GV005'),
	('LHOC006', 'LH06', '2025-04-21', N'Trưa 10:00-12:00', 'P001', 'GV006'),
	('LHOC007', 'LH07', '2025-04-24', N'Chiều 13:00-15:00', 'P001', 'GV007'),
	('LHOC008', 'LH08', '2025-04-28', N'Chiều 15:00-17:00', 'P001', 'GV008'),
	('LHOC009', 'LH09', '2025-05-01', N'Trưa 10:00-12:00', 'P001', 'GV009'),
	('LHOC010', 'LH10', '2025-05-05', N'Sáng 08:00-10:00', 'P001', 'GV010'),
	('LHOC011', 'LH02', '2025-04-06', N'Chiều 14:00-16:00', 'P004', 'GV011'),
	('LHOC012', 'LH03', '2025-04-11', N'Sáng 09:00-11:00', 'P007', 'GV012'),
	('LHOC013', 'LH04', '2025-04-16', N'Chiều 15:00-17:00', 'P010', 'GV013'),
	('LHOC014', 'LH05', '2025-04-21', N'Tối 18:30-20:30', 'P002', 'GV014'),
	('LHOC015', 'LH06', '2025-04-26', N'Tối 19:00-21:00', 'P005', 'GV015'),
	('LHOC016', 'LH07', '2025-05-02', N'Sáng 08:00-10:00', 'P008', 'GV016'),
	('LHOC017', 'LH08', '2025-05-06', N'Chiều 14:00-16:00', 'P011', 'GV017'),
	('LHOC018', 'LH09', '2025-05-11', N'Tối 19:00-21:00', 'P003', 'GV018'),
	('LHOC019', 'LH10', '2025-05-16', N'Sáng 09:00-11:00', 'P006', 'GV019')
	GO