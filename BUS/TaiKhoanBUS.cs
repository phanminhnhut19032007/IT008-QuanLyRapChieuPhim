using System.Security.Cryptography;
using System.Text;
using QuanLyRapChieuPhim.DAL;
using QuanLyRapChieuPhim.DTO;

namespace QuanLyRapChieuPhim.BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS ? instance;
        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) instance = new TaiKhoanBUS(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanBUS() { }

        // Hàm băm SHA-256 biến chuỗi mật khẩu thô thành chuỗi băm 64 ký tự
        public string BamMatKhau(string matKhauGoc)
        {
            if (string.IsNullOrEmpty(matKhauGoc)) return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(matKhauGoc));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Xử lý logic đăng nhập
        public (bool thanhCong, string thongBao, TaiKhoanDTO taiKhoan) XuLyDangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                return (false, "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", null);
            }

            string hash = BamMatKhau(matKhau);
            TaiKhoanDTO tk = TaiKhoanDAL.Instance.DangNhap(tenDangNhap.Trim(), hash);

            if (tk == null)
            {
                return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null);
            }

            if (!tk.TrangThai)
            {
                return (false, "Tài khoản này hiện đang bị khóa!", null);
            }

            // Lưu phiên làm việc
            Session.TenDangNhap = tk.TenDangNhap;
            Session.Quyen = tk.Quyen;
            if (tk.Quyen == "KhachHang")
            {
                Session.MaKH = TaiKhoanDAL.Instance.LayMaKHTheoTenDangNhap(tk.TenDangNhap);
            }

            return (true, "Đăng nhập thành công!", tk);
        }
    }
}