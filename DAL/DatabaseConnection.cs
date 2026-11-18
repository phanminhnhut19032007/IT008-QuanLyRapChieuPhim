using Microsoft.Data.SqlClient;

namespace QuanLyRapChieuPhim.DAL
{
    public static class DatabaseConnection
    {
        private const string ConnectionString =
            "Data Source=localhost\\SQL2025DEV;Initial Catalog=CinemaDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=QuanLyRapChieuPhim;Connect Timeout=10";

        public static SqlConnection Create()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
