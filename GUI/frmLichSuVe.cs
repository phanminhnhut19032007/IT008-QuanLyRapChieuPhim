using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyRapChieuPhim.DTO;

namespace QuanLyRapChieuPhim.GUI
{
    public partial class frmLichSuVe : Form
    {
        private readonly string tenDangNhap = string.Empty;
        private readonly List<DailyTicketSummary> dailyTicketSummaries = new()
        {
            new(new DateTime(2025, 12, 10), new List<Ve>
            {
                new() { MaVe = 1, TenPhim = "Avatar: The Way of Water", MaGhe = 12, ThoiGianBatDau = new DateTime(2025, 12, 10, 19, 30, 0), GiaVe = 120000 },
                new() { MaVe = 2, TenPhim = "Dune: Part Two", MaGhe = 15, ThoiGianBatDau = new DateTime(2025, 12, 10, 21, 0, 0), GiaVe = 95000 }
            }),
            new(new DateTime(2025, 12, 11), new List<Ve>
            {
                new() { MaVe = 3, TenPhim = "How to Train Your Dragon", MaGhe = 8, ThoiGianBatDau = new DateTime(2025, 12, 11, 18, 15, 0), GiaVe = 110000 },
                new() { MaVe = 4, TenPhim = "Avatar: The Way of Water", MaGhe = 20, ThoiGianBatDau = new DateTime(2025, 12, 11, 20, 0, 0), GiaVe = 120000 }
            }),
            new(new DateTime(2025, 12, 12), new List<Ve>
            {
                new() { MaVe = 5, TenPhim = "Dune: Part Two", MaGhe = 4, ThoiGianBatDau = new DateTime(2025, 12, 12, 17, 0, 0), GiaVe = 95000 }
            })
        };

        public frmLichSuVe()
        {
            InitializeComponent();
        }

        public frmLichSuVe(string tenDangNhap) : this()
        {
            this.tenDangNhap = tenDangNhap;
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox avatar = (PictureBox)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            const int borderWidth = 2;
            int diameter = Math.Min(avatar.ClientSize.Width, avatar.ClientSize.Height) - borderWidth * 2;
            if (diameter <= 0)
            {
                return;
            }

            int x = (avatar.ClientSize.Width - diameter) / 2;
            int y = (avatar.ClientSize.Height - diameter) / 2;
            Rectangle bounds = new Rectangle(x, y, diameter, diameter);

            using GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(bounds);
            avatar.Region = new Region(circlePath);

            using Pen pen = new Pen(Color.FromArgb(200, 200, 200), borderWidth);
            e.Graphics.DrawEllipse(pen, bounds);
        }

        private void frmLichSuVe_Load(object sender, EventArgs e)
        {
            ConfigureTicketDetailsGrid();
            LoadCustomerProfile();
            ConfigureTicketChart();
        }

        private void LoadCustomerProfile()
        {
            txtHoTen.Text = "Chưa cập nhật";
            txtNgaySinh.Text = "Chưa cập nhật";
            txtEmail.Text = "Chưa cập nhật";
            txtSoDienThoai.Text = "Chưa cập nhật";
            label11.Text = "0";
            label13.Text = "Chưa cập nhật";
            label1.Text = "Chưa cập nhật";

        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (txtHoTen.ReadOnly)
            {
                txtHoTen.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtSoDienThoai.ReadOnly = false;
                button1.Text = "Lưu thông tin";
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Họ tên và số điện thoại không được để trống.", "Thông tin cá nhân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            label1.Text = txtHoTen.Text.Trim();
            txtHoTen.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
            button1.Text = "Chỉnh sửa";
            MessageBox.Show("Thông tin đã được cập nhật trong phiên hiện tại.", "Thông tin cá nhân", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLichSuVe_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void tableLayoutPanel2_Click(object? sender, EventArgs e)
        {
            using frmDoiMauNen dialog = new frmDoiMauNen(tableLayoutPanel2.BackColor);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                tableLayoutPanel2.BackColor = dialog.SelectedColor;
            }
        }

        private void ConfigureTicketChart()
        {
            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.Name = "Số vé";
            series.IsValueShownAsLabel = true;
            series["PointWidth"] = "0.2";
            series.XValueType = ChartValueType.Date;
            series.YValueType = ChartValueType.Int32;
            series.Points.Clear();

            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy";
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chartArea.AxisX.IsMarginVisible = true;
            chartArea.AxisY.Minimum = 0;

            foreach (DailyTicketSummary summary in dailyTicketSummaries)
            {
                int pointIndex = series.Points.AddXY(summary.Date, summary.TotalTickets);
                DataPoint point = series.Points[pointIndex];
                point.ToolTip = $"{summary.Date:dd/MM/yyyy}: {summary.TotalTickets} vé";
            }
        }

        private void ConfigureTicketDetailsGrid()
        {
            dgvChiTietVe.AutoGenerateColumns = false;
            dgvChiTietVe.AllowUserToAddRows = false;
            dgvChiTietVe.AllowUserToDeleteRows = false;
            dgvChiTietVe.ReadOnly = true;
            dgvChiTietVe.RowHeadersVisible = false;
            dgvChiTietVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietVe.Columns.Clear();
            dgvChiTietVe.Columns.Add("MaVe", "Mã vé");
            dgvChiTietVe.Columns.Add("TenPhim", "Tên phim");
            dgvChiTietVe.Columns.Add("MaGhe", "Mã ghế");
            dgvChiTietVe.Columns.Add("ThoiGianBatDau", "Thời gian bắt đầu");
            dgvChiTietVe.Columns.Add("GiaVe", "Giá vé");
        }

        private void ShowTicketDetails(DailyTicketSummary summary)
        {
            dgvChiTietVe.Rows.Clear();

            foreach (Ve ticket in summary.Tickets)
            {
                dgvChiTietVe.Rows.Add(
                    ticket.MaVe,
                    ticket.TenPhim,
                    ticket.MaGhe,
                    ticket.ThoiGianBatDau.ToString("dd/MM/yyyy HH:mm"),
                    ticket.GiaVe.ToString("N0"));
            }

            dgvChiTietVe.Visible = true;
            tableLayoutPanel8.SetColumnSpan(chart1, 1);
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = chart1.HitTest(e.X, e.Y);
            if (hit.ChartElementType != ChartElementType.DataPoint ||
                hit.PointIndex < 0 || hit.PointIndex >= dailyTicketSummaries.Count)
            {
                return;
            }

            DailyTicketSummary summary = dailyTicketSummaries[hit.PointIndex];
            ShowTicketDetails(summary);
        }



        private sealed record DailyTicketSummary(DateTime Date, List<Ve> Tickets)
        {
            public int TotalTickets => Tickets.Count;
        }
    }
}
