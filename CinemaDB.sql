
CREATE DATABASE CinemaDB;
GO
USE CinemaDB;
GO

-- 1. Bảng Tài khoản đăng nhập
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhauHash VARCHAR(256) NOT NULL,
    Quyen NVARCHAR(20) NOT NULL CHECK (Quyen IN (N'Admin', N'KhachHang')),
    TrangThai BIT NOT NULL DEFAULT 1 -- 1: Hoạt động, 0: Khóa
);


-- 2. Bảng Khách hàng 
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) NOT NULL UNIQUE,
    Email VARCHAR(100),
    DiemTichLuy INT NOT NULL DEFAULT 0 CHECK (DiemTichLuy >= 0),
    TenDangNhap VARCHAR(50) UNIQUE FOREIGN KEY REFERENCES TaiKhoan(TenDangNhap) ON DELETE CASCADE
);

-- 3. Bảng Thể loại phim
CREATE TABLE TheLoai (
    MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL UNIQUE
);

-- 4. Bảng Phim 
CREATE TABLE Phim (
    MaPhim INT IDENTITY(1,1) PRIMARY KEY,
    TenPhim NVARCHAR(200) NOT NULL,
    ThoiLuong INT NOT NULL CHECK (ThoiLuong > 0),
    NgayKhoiChieu DATE NOT NULL,
    Poster NVARCHAR(500),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đang chiếu' -- Đang chiếu / Ngừng chiếu
);

-- 5. Bảng trung gian Phim_TheLoai (Quan hệ N-N)
CREATE TABLE Phim_TheLoai (
    MaPhim INT NOT NULL FOREIGN KEY REFERENCES Phim(MaPhim) ON DELETE CASCADE,
    MaTheLoai INT NOT NULL FOREIGN KEY REFERENCES TheLoai(MaTheLoai) ON DELETE CASCADE,
    PRIMARY KEY (MaPhim, MaTheLoai)
);

-- 6. Bảng Phòng chiếu (Bỏ TongSoGhe để tránh dư thừa dữ liệu)
CREATE TABLE PhongChieu (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(50) NOT NULL UNIQUE,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Hoạt động' -- Hoạt động / Bảo trì
);

-- 7. Bảng Ghế từng phòng
CREATE TABLE Ghe (
    MaGhe INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL FOREIGN KEY REFERENCES PhongChieu(MaPhong) ON DELETE CASCADE,
    TenGhe VARCHAR(10) NOT NULL,
    LoaiGhe NVARCHAR(20) NOT NULL DEFAULT N'Thường' CHECK (LoaiGhe IN (N'Thường', N'VIP')),
    PhuThu DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (PhuThu >= 0),
    CONSTRAINT UQ_Phong_TenGhe UNIQUE (MaPhong, TenGhe)
);

-- 8. Bảng Lịch chiếu (Suất chiếu)
CREATE TABLE LichChieu (
    MaLichChieu INT IDENTITY(1,1) PRIMARY KEY,
    MaPhim INT NOT NULL FOREIGN KEY REFERENCES Phim(MaPhim),
    MaPhong INT NOT NULL FOREIGN KEY REFERENCES PhongChieu(MaPhong),
    ThoiGianBatDau DATETIME NOT NULL,
    ThoiGianKetThuc DATETIME NOT NULL,
    GiaVeCoBan DECIMAL(18,2) NOT NULL CHECK (GiaVeCoBan > 0),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Sắp chiếu',
    CONSTRAINT CHK_ThoiGianChieu CHECK (ThoiGianKetThuc > ThoiGianBatDau)
);

-- 9. Bảng Dịch vụ (Bắp & Nước)
CREATE TABLE DichVu (
    MaDichVu INT IDENTITY(1,1) PRIMARY KEY,
    TenDichVu NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    HinhAnh NVARCHAR(500),
    TrangThai BIT NOT NULL DEFAULT 1 -- 1: Đang bán, 0: Ngừng bán
);

-- 10. Bảng Hóa đơn đặt vé & dịch vụ
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    MaKH INT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
    TienVe DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienVe >= 0),
    TienDichVu DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TienDichVu >= 0),
    GiamGia DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (GiamGia >= 0),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (TongTien >= 0),
    PhuongThucThanhToan NVARCHAR(50) DEFAULT N'Tiền mặt / QR',
    TrangThaiThanhToan NVARCHAR(50) NOT NULL DEFAULT N'Đã thanh toán'
);

-- 11. Bảng Vé xem phim đã đặt
CREATE TABLE Ve (
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaLichChieu INT NOT NULL FOREIGN KEY REFERENCES LichChieu(MaLichChieu),
    MaGhe INT NOT NULL FOREIGN KEY REFERENCES Ghe(MaGhe),
    MaHoaDon INT NOT NULL FOREIGN KEY REFERENCES HoaDon(MaHoaDon) ON DELETE CASCADE,
    GiaVe DECIMAL(18,2) NOT NULL CHECK (GiaVe >= 0),
    CONSTRAINT UQ_SuatChieu_Ghe UNIQUE (MaLichChieu, MaGhe) -- Chống đặt trùng ghế trong 1 suất
);

-- 12. Bảng Chi tiết dịch vụ (Bắp nước mua kèm hóa đơn)
CREATE TABLE ChiTietDichVu (
    MaHoaDon INT NOT NULL FOREIGN KEY REFERENCES HoaDon(MaHoaDon) ON DELETE CASCADE,
    MaDichVu INT NOT NULL FOREIGN KEY REFERENCES DichVu(MaDichVu),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGiaBan DECIMAL(18,2) NOT NULL CHECK (DonGiaBan >= 0),
    ThanhTien AS (SoLuong * DonGiaBan) PERSISTED,
    PRIMARY KEY (MaHoaDon, MaDichVu)
);
GO

-- Thêm sẵn 1 tài khoản Admin và 1 tài khoản Khách hàng mẫu để test Đăng nhập ở Tuần 3
-- Mật khẩu mặc định '123456' (băm SHA-256: 8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92)
INSERT INTO TaiKhoan (TenDangNhap, MatKhauHash, Quyen, TrangThai) VALUES
('admin', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Admin', 1),
('khachhang1', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'KhachHang', 1);

INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiemTichLuy, TenDangNhap) VALUES
(N'Nguyễn Văn Khách', '0901234567', 'khach1@gmail.com', 100, 'khachhang1');
GO