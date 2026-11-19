using System;
using System.Collections.Generic;

namespace Cinema.Model
{
    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string nation { get; set; }
        public int duration { get; set; }
        public string age { get; set; } 
        public string trailer { get; set; }
        public DateTime? releasedate { get; set; }
        public string? pathposterfile { get; set; }

        public Movie() { }

        public Movie(string id, string title, string genre, string nation, int duration,
                     string age, string trailer, string pathposterfile, DateTime? releaseDate = null)
        {
            this.id = id;
            this.title = title;
            this.genre = genre;
            this.nation = nation;
            this.duration = duration;
            this.age = age;
            this.trailer = trailer;
            this.pathposterfile = pathposterfile;
            this.releasedate = releaseDate;
        }
    }

    public static class SampleData
    {
        public static List<Movie> ShowingMovie = new List<Movie>()
        {
            new Movie("M01", "Mưa Đỏ", "Chiến tranh, Lịch sử", "Việt Nam", 125, "T16", "https://youtube.com", "M01.jpeg"),
            new Movie("M02", "Nobita Thám Hiểm Vùng Đất Mới", "Hoạt hình, Phiêu lưu", "Nhật Bản", 109, "P", "https://youtube.com", "M02.jpeg"),
            new Movie("M03", "Địa Đạo", "Chiến tranh, Hành động", "Việt Nam", 128, "T16", "https://youtube.com", "M03.jpeg"),
            new Movie("M04", "Bố Già", "Tâm lý, Gia đình", "Việt Nam", 128, "T13", "https://youtube.com", "M04.jpeg"),
            new Movie("M05", "Đào, Phở và Piano", "Lịch sử, Lãng mạn", "Việt Nam", 100, "T13", "https://youtube.com", "M05.jpeg"),
            new Movie("M06", "Bò Sữa Bay", "Hoạt hình, Gia đình", "Đức", 95, "P", "https://youtube.com", "M06.jpeg"),
            new Movie("M07", "Mắt Biếc", "Tình cảm, Lãng mạn", "Việt Nam", 117, "T13", "https://youtube.com", "M07.jpeg"),
            new Movie("M08", "Hôn Lễ Của Em", "Tình cảm, Tâm lý", "Trung Quốc", 115, "T13", "https://youtube.com", "M08.jpeg")
        };

        public static List<Movie> UpcomingMovie = new List<Movie>()
        {
            new Movie("U01", "Lật Mặt 8: Vòng Tay Nắng", "Hành động, Gia đình", "Việt Nam", 122, "T13", "https://youtube.com", "U01.jpg", new DateTime(2026, 12, 5)),
            new Movie("U02", "Avatar: Lửa Và Tro Tàn", "Khoa học viễn tưởng, Hành động", "Mỹ", 165, "T13", "https://youtube.com", "U02.jpeg", new DateTime(2026, 12, 18)),
            new Movie("U03", "Zootopia 2", "Hoạt hình, Phiêu lưu, Hài", "Mỹ", 105, "P", "https://youtube.com", "U03.jpg", new DateTime(2026, 12, 24)),
            new Movie("U04", "Thám Tử Lừng Danh Conan: Dư Ảnh Của Độc Nhãn", "Hoạt hình, Trinh thám", "Nhật Bản", 110, "K", "https://youtube.com", "U04.jpeg", new DateTime(2027, 1, 1)),
            new Movie("U05", "Đất Rừng Phương Nam 2", "Phiêu lưu, Tâm lý", "Việt Nam", 118, "K", "https://youtube.com", "U05.jpeg", new DateTime(2027, 1, 15)),
            new Movie("U06", "Avengers: Doomsday", "Hành động, Siêu anh hùng", "Mỹ", 155, "T13", "https://youtube.com", "U06.jpeg", new DateTime(2027, 2, 1))
        };
        public static readonly string[] Slots = { "09:30", "11:45", "14:00", "16:15", "19:30", "21:45" };
    }
}