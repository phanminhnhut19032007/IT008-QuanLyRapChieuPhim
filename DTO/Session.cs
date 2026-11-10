namespace QuanLyRapChieuPhim.DTO
{
    public static class Session
    {
        public static string? TenDangNhap { get; set; }
        public static string? Quyen { get; set; }
        public static int? MaKH { get; set; }

        public static void Clear()
        {
            TenDangNhap = null;
            Quyen = null;
            MaKH = null;
        }
    }
}