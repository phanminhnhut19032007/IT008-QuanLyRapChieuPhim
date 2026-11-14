using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyRapChieuPhim.GUI
{
    public partial class frmLichSuVe : Form
    {
        public frmLichSuVe()
        {
            InitializeComponent();
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int d = (int)(this.ClientSize.Width * 0.075);

            // Tô nền trắng hình tròn
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(brush, 0, 0, d, d);
            }

            // Vẽ viền mảnh màu xám nhạt
            using (Pen pen = new Pen(Color.FromArgb(200, 200, 200), 1.5f))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, d, d);
            }
        }

        private void frmLichSuVe_Load(object sender, EventArgs e)
        {

        }

        private void frmLichSuVe_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}
