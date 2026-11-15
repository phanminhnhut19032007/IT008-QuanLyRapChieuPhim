using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Cinema.Controls
{
    public class RoundedSearchBox : Panel
    {
        public TextBox InnerTextBox { get; } = new TextBox();
        public int BorderRadius { get; set; } = 18;
        public Color BorderColor { get; set; } = Color.LightGray;

        public RoundedSearchBox()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            Padding = new Padding(14, 8, 14, 8); // Tạo khoảng trống 2 đầu để chữ không chạm góc bo

            InnerTextBox.BorderStyle = BorderStyle.None;
            InnerTextBox.BackColor = Color.White;
            InnerTextBox.Font = new Font("Segoe UI", 10.5f);
            InnerTextBox.Dock = DockStyle.Fill;
            InnerTextBox.PlaceholderText = "🔍 Tìm kiếm phim, rạp..."; // Hỗ trợ sẵn trong .NET 6/8+

            Controls.Add(InnerTextBox);

            // Click vào vùng viền xung quanh vẫn tự động focus vào ô nhập chữ
            Click += (s, e) => InnerTextBox.Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using var path = GetRoundPath(rect, BorderRadius);
            Region = new Region(GetRoundPath(new Rectangle(0, 0, Width, Height), BorderRadius));

            using var brush = new SolidBrush(BackColor);
            e.Graphics.FillPath(brush, path);

            using var pen = new Pen(BorderColor, 1.5f);
            e.Graphics.DrawPath(pen, path);
        }

        private static GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}