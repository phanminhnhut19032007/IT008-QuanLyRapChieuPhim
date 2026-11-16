using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyRapChieuPhim.DTO
{
    public class LichSuVeDTO
    {
        public int MaVe { get; set; }
        public int MaHoaDon { get; set; }
        public string TenPhim { get; set; }
        public string TenPhong { get; set; }
        public string TenGhe { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime NgayMua { get; set; }
        public decimal GiaVe { get; set; }
        public string TrangThaiThanhToan { get; set; }

        public LichSuVeDTO() { }
    }
}
