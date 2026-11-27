using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            DoubleBuffered = true;
            BatDoubleBuffer(pnlTop);
            BatDoubleBuffer(pnlDanhSach);
            BatDoubleBuffer(pnlChiTiet);
            cboTrangThai.SelectedIndex = 0;
            GanSuKien();
        }

        private void GanSuKien()
        {
            Paint += frmKhachHang_Paint;
            Load += frmKhachHang_Load;
            pnlTop.Paint += pnlTop_Paint;
            pnlDanhSach.Paint += pnlCard_Paint;
            pnlChiTiet.Paint += pnlCard_Paint;
            txtTimKiemSDT.TextChanged += txtTimKiemSDT_TextChanged;
            cboTrangThai.SelectedIndexChanged += cboTrangThai_SelectedIndexChanged;
            btnLamMoi.Click += btnLamMoi_Click;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            btnCapNhatDiem.Click += btnCapNhatDiem_Click;
            btnKhoaMoTK.Click += btnKhoaMoTK_Click;
        }

        private void BatDoubleBuffer(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void frmKhachHang_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(45, 22, 68),
                Color.FromArgb(18, 30, 70),
                45F))
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Rectangle rect = panel.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = TaoDuongBoGoc(rect, 12))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(118, 62, 160),
                Color.FromArgb(52, 86, 175),
                45F))
            {
                CapNhatVungBoGoc(panel, path);
                e.Graphics.FillPath(brush, path);
            }
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Rectangle rect = panel.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = TaoDuongBoGoc(rect, 14))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                CapNhatVungBoGoc(panel, path);
                e.Graphics.FillPath(brush, path);
            }
        }

        private GraphicsPath TaoDuongBoGoc(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void CapNhatVungBoGoc(Panel panel, GraphicsPath path)
        {
            Region oldRegion = panel.Region;
            panel.Region = new Region(path);
            oldRegion?.Dispose();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
        }

        private void txtTimKiemSDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
        }

        private void btnKhoaMoTK_Click(object sender, EventArgs e)
        {
        }
    }
}
