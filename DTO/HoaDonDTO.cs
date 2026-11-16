using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyRapChieuPhim.DTO
{
    public class HoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public int? MaKH { get; set; }               // Null nếu khách vãng lai
        public decimal TienVe { get; set; }
        public decimal TienDichVu { get; set; }
        public decimal GiamGia { get; set; }
        public decimal TongTien { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public string TrangThaiThanhToan { get; set; } // "Đã thanh toán", "Chờ thanh toán", "Đã hủy"

        // Thuộc tính mở rộng (JOIN từ KhachHang) dùng cho báo cáo thống kê
        public string TenKhachHang { get; set; }

        public HoaDonDTO() { }
    }
}
