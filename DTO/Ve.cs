using System;

namespace QuanLyRapChieuPhim.DTO
{
    public class Ve
    {
        // 1. Các thuộc tính gốc
        public int MaVe { get; set; }
        public int MaLichChieu { get; set; }
        public int MaGhe { get; set; }
        public int MaHoaDon { get; set; }
        public decimal GiaVe { get; set; }

        // 2. Các thuộc tính mở rộng dùng khi JOIN bảng để hiển thị
        public string TenPhim { get; set; } = string.Empty;
        public string TenPhong { get; set; } = string.Empty;
        public string TenGhe { get; set; } = string.Empty;
        public string LoaiGhe { get; set; } = string.Empty;
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public int DiemTichLuy { get; set; }
        public string TenKhachHang { get; set; } = string.Empty;
        public string TrangThaiThanhToan { get; set; } = string.Empty;

        // Constructor không tham số
        public Ve()
        {
        }

        // Constructor đầy đủ cho các thuộc tính gốc
        public Ve(int maVe, int maLichChieu, int maGhe, int maHoaDon, decimal giaVe)
        {
            MaVe = maVe;
            MaLichChieu = maLichChieu;
            MaGhe = maGhe;
            MaHoaDon = maHoaDon;
            GiaVe = giaVe;
        }
    }
}
