using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace QuanLyRapChieuPhim.DAL
{
    public sealed class AuthRepository
    {
        private const string ValidateUserSql = """
            SELECT COUNT(1)
            FROM TaiKhoan
            WHERE TenDangNhap = @TenDangNhap
              AND MatKhauHash = @MatKhauHash
              AND TrangThai = 1;
            """;

        public bool ValidateCredentials(string tenDangNhap, string matKhau)
        {
            string passwordHash = ComputeSha256Hash(matKhau);

            using SqlConnection connection = DatabaseConnection.Create();
            using SqlCommand command = new(ValidateUserSql, connection);
            command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
            command.Parameters.AddWithValue("@MatKhauHash", passwordHash);
            connection.Open();

            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }

        private static string ComputeSha256Hash(string value)
        {
            byte[] hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(value));
            return Convert.ToHexString(hashBytes).ToLowerInvariant();
        }
    }
}
