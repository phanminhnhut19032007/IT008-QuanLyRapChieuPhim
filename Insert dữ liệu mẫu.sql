USE CinemaDB;
GO

-- 1. Thêm 1 tài khoản Admin & 5 tài khoản Khách hàng (Mật khẩu: 123456)
INSERT INTO TaiKhoan (TenDangNhap, MatKhauHash, Quyen, TrangThai)
SELECT v.TenDangNhap, v.MatKhauHash, v.Quyen, v.TrangThai
FROM (VALUES
    ('admin2',      '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Admin',     1),
    ('nhannguyen',  '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'KhachHang', 1),
    ('baokha',      '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'KhachHang', 1),
    ('dailoi',      '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'KhachHang', 1),
    ('minhanh',     '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'KhachHang', 1),
    ('khachkhoa',   '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'KhachHang', 0) -- Tài khoản bị khóa
) AS v(TenDangNhap, MatKhauHash, Quyen, TrangThai)
WHERE NOT EXISTS (SELECT 1 FROM TaiKhoan t WHERE t.TenDangNhap = v.TenDangNhap);
GO

-- 2. Thêm 5 Khách hàng tương ứng kèm điểm tích lũy
INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiemTichLuy, TenDangNhap)
SELECT v.HoTen, v.SoDienThoai, v.Email, v.DiemTichLuy, v.TenDangNhap
FROM (VALUES
    (N'Nguyễn Trọng Nhân', '0911223344', 'nhan.nt@gm.uit.edu.vn', 250, 'nhannguyen'),
    (N'Hoàng Bảo Kha',     '0922334455', 'kha.hb@gm.uit.edu.vn',  120, 'baokha'),
    (N'Lê Đại Lợi',        '0933445566', 'loi.ld@gm.uit.edu.vn',  300, 'dailoi'),
    (N'Trần Minh Anh',     '0944556677', 'minhanh@gmail.com',      50, 'minhanh'),
    (N'Phạm Văn Khóa',     '0955667788', 'khoa.pv@gmail.com',       0, 'khachkhoa')
) AS v(HoTen, SoDienThoai, Email, DiemTichLuy, TenDangNhap)
WHERE NOT EXISTS (SELECT 1 FROM KhachHang k WHERE k.TenDangNhap = v.TenDangNhap);
GO

-- 3. Thêm 5 Hóa đơn mẫu (đủ trạng thái & khách vãng lai để test Thống kê)
DECLARE @KH1 INT = (SELECT MaKH FROM KhachHang WHERE TenDangNhap = 'nhannguyen');
DECLARE @KH2 INT = (SELECT MaKH FROM KhachHang WHERE TenDangNhap = 'baokha');
DECLARE @KH3 INT = (SELECT MaKH FROM KhachHang WHERE TenDangNhap = 'dailoi');
DECLARE @KH4 INT = (SELECT MaKH FROM KhachHang WHERE TenDangNhap = 'minhanh');

INSERT INTO HoaDon (NgayLap, MaKH, TienVe, TienDichVu, GiamGia, TongTien, PhuongThucThanhToan, TrangThaiThanhToan)
VALUES
    ('2026-10-25 19:00:00', @KH1, 180000, 75000, 15000, 240000, N'Chuyển khoản QR', N'Đã thanh toán'),
    ('2026-10-27 20:30:00', @KH2, 270000, 110000, 20000, 360000, N'Ví MoMo', N'Đã thanh toán'),
    ('2026-10-29 14:15:00', @KH3, 160000, 45000, 0, 205000, N'Tiền mặt', N'Đã thanh toán'),
    ('2026-10-30 18:00:00', @KH4, 90000, 0, 0, 90000, N'Chuyển khoản QR', N'Chờ thanh toán'),
    ('2026-10-31 10:00:00', NULL, 170000, 60000, 0, 230000, N'Tiền mặt', N'Đã thanh toán');
GO