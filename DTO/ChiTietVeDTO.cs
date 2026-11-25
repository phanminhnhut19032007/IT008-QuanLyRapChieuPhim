using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyRapChieuPhim.DTO
{
    public class ChiTietVeDTO
    {
        public string MaVe { get; set; }
        public string SoGhe { get; set; }
        public string TenPhim { get; set; }
        public DateTime NgayMuaVe { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public decimal GiaVe { get; set; }
        public string TrangThai { get; set; }

        public ChiTietVeDTO() { }

        public ChiTietVeDTO(string maVe, string soGhe, string tenPhim, DateTime ngayMuaVe, DateTime thoiGianChieu, decimal giaVe, string trangThai)
        {
            this.MaVe = maVe;
            this.SoGhe = soGhe;
            this.TenPhim = tenPhim;
            this.NgayMuaVe = ngayMuaVe;
            this.ThoiGianChieu = thoiGianChieu;
            this.GiaVe = giaVe;
            this.TrangThai = trangThai;
        }
    }
}
