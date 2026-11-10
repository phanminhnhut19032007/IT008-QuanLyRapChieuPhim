using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.GUI
{
    public static class UIFrmDangNhap
    {
        //  Cắt bo tròn góc chữ nhật cho bất kỳ Control nào
        public static void BoGocControl(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;
            using (GraphicsPath path = GetRoundPath(control.ClientRectangle, radius))
            {
                control.Region = new Region(path);
            }
        }

        //  Cắt PictureBox thành hình tròn xoe (chứa ảnh GIF ăn bắp rang)
        public static void BoTronControl(Control control)
        {
            if (control.Width <= 0 || control.Height <= 0) return;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, control.Width, control.Height);
                control.Region = new Region(path);
            }
        }

        // Vẽ viền tròn trang trí cho khung GIF
        public static void VeVienTron(Graphics g, int width, int height, Color color, float thickness = 2f)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(color, thickness))
            {
                g.DrawEllipse(pen, thickness / 2, thickness / 2, width - thickness, height - thickness);
            }
        }

        //  Cài đặt tự động bo góc và vẽ viền cho Panel bọc TextBox hoặc Button
        public static void SetupRoundBox(Control c, int radius, Color borderColor)
        {
            c.Resize += (s, e) => BoGocControl(c, radius);
            c.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, c.Width - 1, c.Height - 1);
                using (GraphicsPath path = GetRoundPath(rect, radius))
                using (Pen pen = new Pen(borderColor, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
            BoGocControl(c, radius);
        }

        //  Đường cong bo góc mượt mà
        public static GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}