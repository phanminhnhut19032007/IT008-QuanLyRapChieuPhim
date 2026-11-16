using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyRapChieuPhim.DTO
{
    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhauHash { get; set; }
        public string Quyen { get; set; }      // "Admin" hoặc "KhachHang"
        public bool TrangThai { get; set; }    // true (1): Hoạt động, false (0): Khóa

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string tenDangNhap, string matKhauHash, string quyen, bool trangThai)
        {
            TenDangNhap = tenDangNhap;
            MatKhauHash = matKhauHash;
            Quyen = quyen;
            TrangThai = trangThai;
        }
    }
}
