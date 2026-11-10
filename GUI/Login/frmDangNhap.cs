using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using QuanLyRapChieuPhim.BUS;
using QuanLyRapChieuPhim.DTO;

namespace QuanLyRapChieuPhim.GUI
{
    public partial class frmDangNhap : Form
    {

        private Bitmap? blurredBackground;

        // Cho phép rê chuột kéo Form khi FormBorderStyle = None
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmDangNhap()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            // 1. Cắt PictureBox thành hình tròn xoe
            BoTronControl(picGif);

            // 2. Tự động vẽ thêm một vòng viền tròn trang trí bên ngoài
            picGif.Paint += PicGif_Paint;
            // Cho phép di chuyển form bằng chuột khi click vào nền form
            this.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, 0xA1, 0x2, 0);
                }
            };

            // Đăng ký các sự kiện tạo hiệu ứng kính mờ cho Panel
            this.Load += FrmDangNhap_Load;
            pblDangNhap.Paint += PblDangNhap_Paint;
            pblDangNhap.Resize += (s, e) => BoGocPanel(pblDangNhap, 25);
        }
   

        // Hàm cắt bất kỳ Control vuông nào thành hình tròn
        private void BoTronControl(Control c)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, c.Width, c.Height);
                c.Region = new Region(path);
            }
        }

        // Vẽ viền tròn mỏng đỏ cam rực rỡ xung quanh khung GIF
        private void PicGif_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(220, 53, 69), 2f)) // Viền đỏ cùng tông nền
            {
                e.Graphics.DrawEllipse(pen, 1, 1, picGif.Width - 2, picGif.Height - 2);
            }
        }
        private void FrmDangNhap_Load(object? sender, EventArgs e)
        {
            TaoHieuUngKinhMo();
            BoGocPanel(pblDangNhap, 25);
        }

        // Tạo ảnh nền bị làm mờ đúng vị trí của pblDangNhap
        private void TaoHieuUngKinhMo()
        {
            if (this.BackgroundImage == null) return;

            // 1. Dựng ảnh nền thực tế theo kích thước form hiện tại
            using (Bitmap fullBg = new Bitmap(this.Width, this.Height))
            {
                using (Graphics gFull = Graphics.FromImage(fullBg))
                {
                    gFull.DrawImage(this.BackgroundImage, 0, 0, this.Width, this.Height);
                }

                // 2. Cắt đúng vùng nằm ngay phía sau Panel
                Rectangle cropRect = pblDangNhap.Bounds;
                using (Bitmap cropped = fullBg.Clone(cropRect, PixelFormat.Format32bppArgb))
                {
                    // 3. Làm mờ ảnh cắt bằng thuật toán Fast Blur (bán kính làm mờ = 15)
                    blurredBackground?.Dispose();
                    blurredBackground = ApplyBlur(cropped, 15);
                }
            }
        }

        // Sự kiện vẽ lên Panel: Ảnh mờ + Lớp phủ tối (Tint) + Viền sáng phản quang
        private void PblDangNhap_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pblDangNhap.Width - 1, pblDangNhap.Height - 1);

            using (GraphicsPath path = GetRoundPath(rect, 24))
            {
                // Đổi sang màu sáng (Trắng ngà / Kem sáng bán trong suốt nhẹ)
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect,
                    Color.FromArgb(245, 255, 255, 255), // Đỉnh thẻ: Trắng tinh
                    Color.FromArgb(240, 240, 242, 245), // Đáy thẻ: Trắng xám nhẹ
                    LinearGradientMode.Vertical))
                {
                    g.FillPath(brush, path);
                }

                // Đường viền xám bạc mỏng giúp nổi khối trên nền đỏ
                using (Pen borderPen = new Pen(Color.FromArgb(200, 200, 200), 1.5f))
                {
                    g.DrawPath(borderPen, path);
                }
            }
        }

        // Hàm bo góc Panel
        private void BoGocPanel(Panel pnl, int radius)
        {
            using (GraphicsPath path = GetRoundPath(pnl.ClientRectangle, radius))
            {
                pnl.Region = new Region(path);
            }
        }

        // Đường dẫn cong để bo góc
        private GraphicsPath GetRoundPath(Rectangle rect, int radius)
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

        // Thuật toán làm mờ ảnh (Fast Box Blur)
        private Bitmap ApplyBlur(Bitmap source, int radius)
        {
            Bitmap scaled = new Bitmap(source.Width / 4, source.Height / 4);
            using (Graphics g = Graphics.FromImage(scaled))
            {
                g.InterpolationMode = InterpolationMode.Bilinear;
                g.DrawImage(source, 0, 0, scaled.Width, scaled.Height);
            }

            Bitmap blurred = new Bitmap(source.Width, source.Height);
            using (Graphics g = Graphics.FromImage(blurred))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(scaled, 0, 0, blurred.Width, blurred.Height);
            }
            scaled.Dispose();
            return blurred;
        }

      

        // Sự kiện click nút Đăng nhập
    }
}