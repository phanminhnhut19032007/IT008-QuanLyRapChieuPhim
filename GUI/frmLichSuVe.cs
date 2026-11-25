using QuanLyRapChieuPhim.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.GUI
{
    public partial class frmLichSuVe : Form
    {
        // Biến lưu phần trăm tiến độ (từ 0.0f đến 1.0f)
        private float tyLeDiem = 0f;
        public frmLichSuVe()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // Bật DoubleBuffered cho tất cả Panel và TableLayoutPanel để chống nhấp nháy
            BatDoubleBuffer(tableLayoutPanel1);
            BatDoubleBuffer(panel1);
            BatDoubleBuffer(panel2);
            BatDoubleBuffer(panel5);
            BatDoubleBuffer(panel6);
            CapNhatTichDiem(3800); // Ví dụ: cập nhật điểm hiện tại là 
        }

        private void BatDoubleBuffer(Control ctrl)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, ctrl, new object[] { true });
        }

        private void frmLichSuVe_Load(object sender, EventArgs e)
        {
            ChonTabMenu(label5); // Mặc định chọn tab "Thông tin cá nhân"
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.ClientRectangle.Width == 0 || panel2.ClientRectangle.Height == 0) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int r = 14;
            int d = r * 2;
            Rectangle rect = panel2.ClientRectangle;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                // Chỉ cập nhật Region khi kích thước thay đổi để tránh kích hoạt vẽ lại liên tục
                if (panel2.Region == null)
                    panel2.Region = new Region(path);

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect,
                    Color.FromArgb(118, 62, 160),
                    Color.FromArgb(52, 86, 175),
                    45F))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);
            if (rect.Width == 0 || rect.Height == 0) return;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(45, 22, 68),
                Color.FromArgb(18, 30, 70),
                45F))
            {
                // Chỉ tô lại đúng vùng vừa lộ ra khi cuộn (e.ClipRectangle) giúp mượt gấp nhiều lần
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Invalidate();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = panel7.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;

            int r = rect.Height / 2; // Bo tròn 2 đầu dạng viên thuốc (pill shape)

            // 1. Vẽ thanh nền màu xám xanh nhạt (#646E8C)
            using (GraphicsPath bgPath = TaoDuongBoVienThuoc(rect, r))
            using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(100, 110, 140)))
            {
                e.Graphics.FillPath(bgBrush, bgPath);
            }

            // 2. Vẽ phần điểm đã đạt màu vàng sáng (#F3EA28)
            int fillWidth = (int)(rect.Width * tyLeDiem);
            if (fillWidth >= rect.Height) // Chỉ vẽ khi đủ độ rộng bo tròn
            {
                Rectangle fillRect = new Rectangle(0, 0, fillWidth, rect.Height);
                using (GraphicsPath fillPath = TaoDuongBoVienThuoc(fillRect, r))
                using (SolidBrush fillBrush = new SolidBrush(Color.FromArgb(243, 234, 40)))
                {
                    e.Graphics.FillPath(fillBrush, fillPath);
                }
            }
        }
        private GraphicsPath TaoDuongBoVienThuoc(Rectangle rect, int r)
        {
            GraphicsPath path = new GraphicsPath();
            int d = r * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void CapNhatTichDiem(int diemHienTai)
        {
            int mocToiDa = 10000;

            // Rút gọn số lớn hơn 1000 thành dạng "k" (vd: 2500 -> "2.5k", 0 -> "0")
            string chuoiDiem = diemHienTai >= 1000
                ? $"{(diemHienTai / 1000.0):0.#}k"
                : diemHienTai.ToString();

            label3.Text = $"{chuoiDiem}";

            // Cập nhật tỉ lệ cho thanh tiến trình
            tyLeDiem = Math.Min(1.0f, (float)diemHienTai / mocToiDa);
            panel7.Invalidate();
        }
        private void ChonTabMenu(Label lblDangChon)
        {
            Color mauVangSang = Color.FromArgb(243, 234, 40);
            Color mauTrangThuong = Color.White;

            // 1. Đưa cả 3 mục menu về màu trắng bình thường
            label7.ForeColor = mauTrangThuong; // Thông tin cá nhân
            label6.ForeColor = mauTrangThuong; // Thành viên
            label5.ForeColor = mauTrangThuong; // Lịch sử mua hàng

            // 2. Tô vàng sáng cả icon lẫn chữ của mục vừa bấm
            lblDangChon.ForeColor = mauVangSang;

            // 3. Căn giữa theo chiều dọc vạch vàng pnlIndicator với dòng đang chọn
            panel8.Top = lblDangChon.Top + (lblDangChon.Height - panel8.Height) / 2;
            panel8.Visible = true;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            ChonTabMenu(label5);
            label8.Text = "THÔNG TIN KHÁCH HÀNG";
            panel5.Visible = true;
            panel6.Visible = true;
            dataGridView1.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ChonTabMenu(label6);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ChonTabMenu(label7);
            label8.Text = "LỊCH SỬ MUA HÀNG";
            panel5.Visible = false;
            panel6.Visible = false;
            dataGridView1.Visible = true;
 
        }
    }
}