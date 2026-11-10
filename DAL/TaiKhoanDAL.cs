using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyRapChieuPhim.DTO;

namespace QuanLyRapChieuPhim.DAL
{
    public class TaiKhoanDAL
    {
        private static TaiKhoanDAL? instance;
        public static TaiKhoanDAL Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAL(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAL() { }

        // Kiểu trả về TaiKhoanDTO? cho phép trả về null khi không tìm thấy tài khoản
        public TaiKhoanDTO? DangNhap(string tenDangNhap, string matKhauHash)
        {
            string query = @"SELECT TenDangNhap, MatKhauHash, Quyen, TrangThai 
                             FROM TaiKhoan 
                             WHERE TenDangNhap = @tenDangNhap AND MatKhauHash = @matKhauHash";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenDangNhap", SqlDbType.VarChar, 50) { Value = tenDangNhap },
                new SqlParameter("@matKhauHash", SqlDbType.VarChar, 256) { Value = matKhauHash }
            };

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TaiKhoanDTO
                {
                    TenDangNhap = row["TenDangNhap"]?.ToString() ?? string.Empty,
                    MatKhauHash = row["MatKhauHash"]?.ToString() ?? string.Empty,
                    Quyen = row["Quyen"]?.ToString() ?? string.Empty,
                    TrangThai = row["TrangThai"] != DBNull.Value && Convert.ToBoolean(row["TrangThai"])
                };
            }

            return null;
        }

        // Lấy MaKH nếu tài khoản là Khách hàng
        public int? LayMaKHTheoTenDangNhap(string tenDangNhap)
        {
            string query = "SELECT MaKH FROM KhachHang WHERE TenDangNhap = @tenDangNhap";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenDangNhap", SqlDbType.VarChar, 50) { Value = tenDangNhap }
            };

            object? result = DataProvider.Instance.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return null;
        }
    }
}