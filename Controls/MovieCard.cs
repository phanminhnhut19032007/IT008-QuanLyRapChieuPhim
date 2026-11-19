using Cinema.FuntionHelper;
using Cinema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Cinema.Controls
{
    public class MovieCard : Panel
    {
        public Movie movie { get; }
        public MovieCard(Movie m, bool isUpcoming = false)
        {
            movie = m;
            Size = new Size(528, 350);
            BackColor = Color.Transparent;
            DoubleBuffered = true;
            PictureBox picPoster = new PictureBox
            {
                Bounds = new Rectangle(0, 0, 240, 350),
                SizeMode = PictureBoxSizeMode.StretchImage, // khong vo ti le
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent

            };
            string imgPath = ImageHelper.ResPath(movie.pathposterfile);
            if (!string.IsNullOrEmpty(movie.pathposterfile) && File.Exists(imgPath))
            {
                try
                {
                    byte[] imgBytes = File.ReadAllBytes(imgPath);
                    using var ms = new MemoryStream(imgBytes);
                    using var rawImg = Image.FromStream(ms);
                    picPoster.Image = new Bitmap(rawImg, new Size(240, 350));
                }
                catch
                {
                    // Thông báo chính xác tên file ảnh đang sai định dạng lõi
                    MessageBox.Show($"File ảnh bị lỗi định dạng (WebP/AVIF): {movie.pathposterfile}");
                }
            }
            if (File.Exists(imgPath))
            {
                picPoster.Image = Image.FromFile(imgPath);
            }
            int X = 252;
            int Width = 276;
            Label lblTitle = new Label
            {
                Text = movie.title,
                Bounds = new Rectangle(X, 0, Width, 34),
                ForeColor = Color.White,
                Font = new Font("Time New Roman", 15f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };
            Label lblGenre = new Label
            {
                Text = $"🏷️  {movie.genre}",
                Bounds = new Rectangle(X, 38, Width - 30, 24),
                Font = new Font("Time New Roman", 10f),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true,
                Cursor = Cursors.Hand

            };
            var lblMeta = new Label
            {
                Text = $"🕒  {movie.duration}'   🌐  {movie.nation}   💬  Phụ Đề",
                Bounds = new Rectangle(X, 64, Width, 24),
                ForeColor = Color.White,
                Font = new Font("Time New Roman", 10f, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };
            Label lblAgeDesc = new Label
            {
                Text = $"👤  {GetAgeDescriptioṇ(movie.age)}",
                Bounds = new Rectangle(X, 90, Width, 38),
                ForeColor = Color.White,
                Font = new Font("Time New Roman", 9f, FontStyle.Regular),
                TextAlign = ContentAlignment.TopLeft
            };
            Controls.Add(picPoster);
            Controls.Add(lblTitle);
            Controls.Add(lblGenre);
            Controls.Add(lblMeta);
            Controls.Add(lblAgeDesc);
            if (!isUpcoming)
            {
                // Khung viền suất chiếu giống mẫu Cinestar
                var pnlSchedule = new Panel
                {
                    Bounds = new Rectangle(X, 140, Width, 125),
                    BackColor = Color.FromArgb(22, 28, 52)
                };
                pnlSchedule.Paint += (s, e) =>
                {
                    using var pen = new Pen(Color.FromArgb(75, 85, 120), 1);
                    e.Graphics.DrawRectangle(pen, 0, 0, pnlSchedule.Width - 1, pnlSchedule.Height - 1);
                };

                var lblDate = new Label
                {
                    Text = $"Thứ Ba, {DateTime.Now:dd/MM/yyyy}",
                    Bounds = new Rectangle(12, 10, Width - 24, 22),
                    ForeColor = Color.FromArgb(243, 234, 40),
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold)
                };

                var lblFormat = new Label
                {
                    Text = "STANDARD",
                    Bounds = new Rectangle(12, 36, Width - 24, 20),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 8.5f, FontStyle.Bold)
                };
                pnlSchedule.Controls.Add(lblDate);
                pnlSchedule.Controls.Add(lblFormat);
              

                string[] times = { "10:40", "13:20", " 16:00", "20:30 " };
                Color yellowColor = Color.FromArgb(243, 234, 40);
                Color grayBorder = Color.FromArgb(120, 130, 160);
                int startX = 12;
                int buttonWidth = 60;
                int buttonHeight = 30;
                int gap = 6;
                for (int i = 0; i < times.Length; i++)
                {
                    int posX = startX + i * (gap + buttonWidth);
                    string time_ = times[i];
                    Button btnTime = new Button()
                    {
                        Text = time_,
                        Size = new Size(buttonWidth, buttonHeight),
                        Location = new Point(posX, 64),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                        Font = new Font("Time New Roman", 7f, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                    };
                    btnTime.FlatAppearance.BorderSize = 1;
                    if (i == 0)
                    {
                        btnTime.ForeColor = yellowColor;
                        btnTime.FlatAppearance.BorderColor = yellowColor;
                    }
                    else
                    {
                        btnTime.ForeColor = Color.White;
                        btnTime.FlatAppearance.BorderColor = grayBorder;
                    }
                    pnlSchedule.Controls.Add(btnTime);
                    Controls.Add(pnlSchedule);
                }

            }
            else
            {
                string release = "";
                if (movie.releasedate.HasValue == true)
                {
                    release = $"Dự kiến khởi chiếu {movie.releasedate.Value:dd//MM/yyyy}";
                }
                else
                {
                    release = "Sắp khởi chiếu tại rạp";
                }
                var lblRelease = new Label
                {
                    Text = $"📅  {release}",
                    Bounds = new Rectangle(X, 145, Width, 28),
                    ForeColor = Color.FromArgb(243, 234, 40),
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold)
                };
                Controls.Add(lblRelease); 



            }
          
            
        }
        public static string GetAgeDescriptioṇ(string age)
        {
            string description;
            if (age == "P") description = "P: Phim dành cho mọi lứa tuổi";
            if (age == "K") description = "K: Phim dành cho khán giả dưới 13 tuổi có người bảo hộ";
            if (age == "T13") description = "T13 : Phim dành cho khán giả trên 13 tuổi";
            if (age == "T16") description = "T16 : Phim dành cho khán giả trên 16 tuổi";
            if (age == "T18") description = "T18 : Phim dành cho khán giả trên 18 tuổi";
            else
            {
                description = "Chưa phân loại";
            }
            return description;



        }


    }

}
