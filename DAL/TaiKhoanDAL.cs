using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyRapChieuPhim.DTO;

namespace QuanLyRapChieuPhim.DAL
{
    public class TaiKhoanDAL
    {
        private static TaiKhoanDAL instance;
        public static TaiKhoanDAL Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAL(); return instance; }
            private set { instance = value; }
        }
       
        private TaiKhoanDAL() { }

        // Kiểu trả về TaiKhoanDTO? cho phép trả về null khi không tìm thấy tài khoản
        public TaiKhoanDTO DangNhap(string tenDangNhap, string matKhauHash)
        {
            string query = @"SELECT TenDangNhap, MatKhauHash, Quyen, TrangThai
                 FROM TaiKhoan 
                 WHERE TenDangNhap = @TenDangNhap AND MatKhauHash = @MatKhauHash";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", SqlDbType.VarChar, 50) { Value = tenDangNhap },
                new SqlParameter("@MatKhauHash", SqlDbType.VarChar, 256) { Value = matKhauHash }
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
            string query = "SELECT MaKH FROM KhachHang WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", SqlDbType.VarChar, 50) { Value = tenDangNhap }
            };

            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return null;
        }
         // Kiểm tra xem tên đăng nhập đã tồn tại trong cơ sở dữ liệu hay chưa
        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", SqlDbType.VarChar, 50) { Value = tenDangNhap }
            };
            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int count = Convert.ToInt32(result);
                return count > 0; // Nếu count > 0, tên đăng nhập đã tồn tại
            }
            return false; // Nếu không tìm thấy, trả về false
        }
        public bool KiemTraSoDienThoaiTonTai(string soDienThoai)
        {
            string query = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
            SqlParameter[] parameters =
            {
        new SqlParameter("@SoDienThoai", SqlDbType.VarChar, 15) { Value = soDienThoai }
           };
            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value && Convert.ToInt32(result) > 0;
        }

        public bool DangKyTaiKhoan(string tenDangNhap, string matKhauHash,
                               string hoTen, string soDienThoai, string email)
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.GetConnectionString()))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // INSERT vào TaiKhoan
                        string query1 = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhauHash, Quyen, TrangThai)
                                 VALUES (@TenDangNhap, @MatKhauHash, N'KhachHang', 1)";
                        using (SqlCommand cmd1 = new SqlCommand(query1, connection, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                            cmd1.Parameters.AddWithValue("@MatKhauHash", matKhauHash);
                            cmd1.ExecuteNonQuery();
                        }

                        // INSERT vào KhachHang
                        string query2 = @"INSERT INTO KhachHang (HoTen, SoDienThoai, Email, TenDangNhap)
                                 VALUES (@HoTen, @SoDienThoai, @Email, @TenDangNhap)";
                        using (SqlCommand cmd2 = new SqlCommand(query2, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@HoTen", hoTen);
                            cmd2.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                            cmd2.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? DBNull.Value : (object)email);
                            cmd2.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                            cmd2.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"DangKyTaiKhoan Error: {ex.Message}", ex);
                    }
                
               }
              }
           }
        // Kiểm tra Tên đăng nhập có khớp với SĐT hoặc Email trong bảng KhachHang không
        public bool KiemTraThongTinKhoiPhuc(string tenDangNhap, string sdtHoacEmail)
        {
            string query = @"
        SELECT COUNT(*) 
        FROM TaiKhoan tk
        INNER JOIN KhachHang kh ON tk.TenDangNhap = kh.TenDangNhap
        WHERE tk.TenDangNhap = @TenDangNhap 
          AND (kh.SoDienThoai = @ThongTin OR kh.Email = @ThongTin)
          AND tk.TrangThai = 1";

            SqlParameter[] parameters = {
        new SqlParameter("@TenDangNhap", tenDangNhap),
        new SqlParameter("@ThongTin", sdtHoacEmail)
    };

            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }

        // Cập nhật mật khẩu mới đã băm SHA-256
        public bool CapNhatMatKhauMoi(string tenDangNhap, string matKhauMoiHash)
        {
            string query = "UPDATE TaiKhoan SET MatKhauHash = @MatKhauHash WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters = {
        new SqlParameter("@MatKhauHash", matKhauMoiHash),
        new SqlParameter("@TenDangNhap", tenDangNhap)
    };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }
    }


    }
