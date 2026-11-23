using QuanLyRapChieuPhim.DAL;
using QuanLyRapChieuPhim.DTO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyRapChieuPhim.BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
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
        public (bool thanhCong, string thongBao) XuLyDangKy(string hoTen, string soDienThoai,
    string email, string tenDangNhap, string matKhau, string nhapLaiMatKhau)
        {
            hoTen = hoTen?.Trim() ?? "";
            soDienThoai = soDienThoai?.Trim() ?? "";
            email = email?.Trim() ?? "";
            tenDangNhap = tenDangNhap?.Trim() ?? "";

            if (hoTen == "" || soDienThoai == "" || tenDangNhap == "" || string.IsNullOrEmpty(matKhau))
                return (false, "Vui lòng nhập đầy đủ các thông tin bắt buộc!");

            if (!Regex.IsMatch(soDienThoai, @"^0\d{9,10}$"))
                return (false, "Số điện thoại phải gồm 10-11 chữ số và bắt đầu bằng 0!");

            if (email != "" && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return (false, "Email không hợp lệ!");

            if (!Regex.IsMatch(tenDangNhap, @"^[a-zA-Z0-9_]{4,50}$"))
                return (false, "Tên đăng nhập 4-50 ký tự, chỉ gồm chữ, số và dấu gạch dưới!");

            if (matKhau.Length < 6)
                return (false, "Mật khẩu phải có ít nhất 6 ký tự!");

            if (matKhau != nhapLaiMatKhau)
                return (false, "Mật khẩu nhập lại không khớp!");

            try
            {
                if (TaiKhoanDAL.Instance.KiemTraTenDangNhapTonTai(tenDangNhap))
                    return (false, "Tên đăng nhập đã tồn tại!");

                if (TaiKhoanDAL.Instance.KiemTraSoDienThoaiTonTai(soDienThoai))
                    return (false, "Số điện thoại đã được đăng ký!");

                bool ok = TaiKhoanDAL.Instance.DangKyTaiKhoan(
                    tenDangNhap, BamMatKhau(matKhau), hoTen, soDienThoai, email);

                return ok ? (true, "Đăng ký thành công!") : (false, "Đăng ký thất bại, vui lòng thử lại!");
            }
            catch (Exception ex)
            {
                return (false, "Lỗi hệ thống: " + ex.Message);
            }
        }
    }
}