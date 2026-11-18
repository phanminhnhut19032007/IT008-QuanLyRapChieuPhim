using Microsoft.Data.SqlClient;
using QuanLyRapChieuPhim.DTO;

namespace QuanLyRapChieuPhim.DAL
{
    public sealed class VeRepository
    {
        private const string SelectTicketsSql = """
            SELECT
                v.MaVe,
                v.MaLichChieu,
                v.MaGhe,
                v.MaHoaDon,
                v.GiaVe,
                p.TenPhim,
                pc.TenPhong,
                g.TenGhe,
                g.LoaiGhe,
                lc.ThoiGianBatDau,
                hd.NgayLap,
                COALESCE(kh.DiemTichLuy, 0) AS DiemTichLuy,
                kh.HoTen AS TenKhachHang,
                hd.TrangThaiThanhToan
            FROM Ve AS v
            INNER JOIN LichChieu AS lc ON lc.MaLichChieu = v.MaLichChieu
            INNER JOIN Phim AS p ON p.MaPhim = lc.MaPhim
            INNER JOIN PhongChieu AS pc ON pc.MaPhong = lc.MaPhong
            INNER JOIN Ghe AS g ON g.MaGhe = v.MaGhe
            INNER JOIN HoaDon AS hd ON hd.MaHoaDon = v.MaHoaDon
            LEFT JOIN KhachHang AS kh ON kh.MaKH = hd.MaKH
            WHERE hd.TrangThaiThanhToan = N'Đã thanh toán'
              AND kh.TenDangNhap = @TenDangNhap
            ORDER BY hd.NgayLap, v.MaVe;
            """;

        public List<Ve> GetPaidTickets(string tenDangNhap)
        {
            List<Ve> tickets = new();

            using SqlConnection connection = DatabaseConnection.Create();
            using SqlCommand command = new(SelectTicketsSql, connection);
            command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tickets.Add(new Ve
                {
                    MaVe = reader.GetInt32(reader.GetOrdinal("MaVe")),
                    MaLichChieu = reader.GetInt32(reader.GetOrdinal("MaLichChieu")),
                    MaGhe = reader.GetInt32(reader.GetOrdinal("MaGhe")),
                    MaHoaDon = reader.GetInt32(reader.GetOrdinal("MaHoaDon")),
                    GiaVe = reader.GetDecimal(reader.GetOrdinal("GiaVe")),
                    TenPhim = reader.GetString(reader.GetOrdinal("TenPhim")),
                    TenPhong = reader.GetString(reader.GetOrdinal("TenPhong")),
                    TenGhe = reader.GetString(reader.GetOrdinal("TenGhe")),
                    LoaiGhe = reader.GetString(reader.GetOrdinal("LoaiGhe")),
                    ThoiGianBatDau = reader.GetDateTime(reader.GetOrdinal("ThoiGianBatDau")),
                    NgayLapHoaDon = reader.GetDateTime(reader.GetOrdinal("NgayLap")),
                    DiemTichLuy = reader.GetInt32(reader.GetOrdinal("DiemTichLuy")),
                    TenKhachHang = reader.IsDBNull(reader.GetOrdinal("TenKhachHang"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("TenKhachHang")),
                    TrangThaiThanhToan = reader.GetString(reader.GetOrdinal("TrangThaiThanhToan"))
                });
            }

            return tickets;
        }

        public (int MaKH, string HoTen, string SoDienThoai, string Email, int DiemTichLuy)? GetCustomerProfile(string tenDangNhap)
        {
            const string sql = """
                SELECT MaKH, HoTen, SoDienThoai, COALESCE(Email, '') AS Email, DiemTichLuy
                FROM KhachHang
                WHERE TenDangNhap = @TenDangNhap;
                """;

            using SqlConnection connection = DatabaseConnection.Create();
            using SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                return null;
            }

            return (
                reader.GetInt32(reader.GetOrdinal("MaKH")),
                reader.GetString(reader.GetOrdinal("HoTen")),
                reader.GetString(reader.GetOrdinal("SoDienThoai")),
                reader.GetString(reader.GetOrdinal("Email")),
                reader.GetInt32(reader.GetOrdinal("DiemTichLuy")));
        }

        public void UpdateCustomerProfile(string tenDangNhap, string hoTen, string soDienThoai, string email)
        {
            const string sql = """
                UPDATE KhachHang
                SET HoTen = @HoTen,
                    SoDienThoai = @SoDienThoai,
                    Email = @Email
                WHERE TenDangNhap = @TenDangNhap;
                """;

            using SqlConnection connection = DatabaseConnection.Create();
            using SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@HoTen", hoTen);
            command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? DBNull.Value : email);
            command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
            connection.Open();

            if (command.ExecuteNonQuery() == 0)
            {
                throw new InvalidOperationException("Không tìm thấy khách hàng cần cập nhật.");
            }
        }
    }
}
