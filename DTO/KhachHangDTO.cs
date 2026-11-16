using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyRapChieuPhim.DTO
{
    public class KhachHangDTO
    {
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public int DiemTichLuy { get; set; }
        public string TenDangNhap { get; set; }

        // Thuộc tính mở rộng (JOIN từ bảng TaiKhoan) dùng cho frmKhachHang
        public bool TrangThaiTaiKhoan { get; set; }

        public KhachHangDTO() { }

        public KhachHangDTO(int maKH, string hoTen, string soDienThoai, string email, int diemTichLuy, string tenDangNhap, bool trangThaiTaiKhoan = true)
        {
            MaKH = maKH;
            HoTen = hoTen;
            SoDienThoai = soDienThoai;
            Email = email;
            DiemTichLuy = diemTichLuy;
            TenDangNhap = tenDangNhap;
            TrangThaiTaiKhoan = trangThaiTaiKhoan;
        }
    }
}
