using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cinema.Controls
{
    public class RoundedSearchBox : Panel
    {
        public TextBox InnerTextBox { get; } = new TextBox();
        public int BorderRadius { get; set; } = 18;
        public Color BorderColor { get; set; } = Color.LightGray;

        private string _placeholder = "🔍 Tìm kiếm phim, rạp...";
        private bool _isPlaceholderActive = true;

        public string Placeholder
        {
            get => _placeholder;
            set
            {
                _placeholder = value;
                if (_isPlaceholderActive)
                {
                    InnerTextBox.Text = _placeholder;
                }
            }
        }

        // Thuộc tính lấy nội dung tìm kiếm thực sự (trả về chuỗi rỗng nếu đang hiện chữ gợi ý)
        public string SearchText => _isPlaceholderActive ? string.Empty : InnerTextBox.Text.Trim();

        public RoundedSearchBox()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            Padding = new Padding(14, 11, 14, 8);

            InnerTextBox.BorderStyle = BorderStyle.None;
            InnerTextBox.BackColor = Color.White;
            InnerTextBox.Font = new Font("Segoe UI", 10.5f);
            InnerTextBox.Dock = DockStyle.Fill;

            // Hiển thị chữ gợi ý màu xám ngay từ đầu
            SetPlaceholderState();

            // Khi người dùng bấm chuột vào để gõ -> xóa chữ gợi ý, đổi sang chữ đen
            InnerTextBox.Enter += (s, e) =>
            {
                if (_isPlaceholderActive)
                {
                    _isPlaceholderActive = false;
                    InnerTextBox.Text = "";
                    InnerTextBox.ForeColor = Color.FromArgb(30, 35, 50);
                }
            };

            // Khi người dùng rời chuột ra mà chưa gõ gì -> hiện lại chữ gợi ý màu xám
            InnerTextBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(InnerTextBox.Text))
                {
                    SetPlaceholderState();
                }
            };

            Controls.Add(InnerTextBox);

            // Bấm vào vùng viền trắng xung quanh vẫn focus vào TextBox
            Click += (s, e) => InnerTextBox.Focus();
        }

        private void SetPlaceholderState()
        {
            _isPlaceholderActive = true;
            InnerTextBox.Text = _placeholder;
            InnerTextBox.ForeColor = Color.Gray;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Width > 0 && Height > 0)
            {
                using var regionPath = GetRoundPath(new Rectangle(0, 0, Width, Height), BorderRadius);
                Region = new Region(regionPath);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using var path = GetRoundPath(rect, BorderRadius);

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