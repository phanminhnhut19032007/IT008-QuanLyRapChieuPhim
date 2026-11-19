using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Controls
{
    public class MovieTabBar : UserControl
    {
        public event    Action<int>? TabChanged;
        private readonly Label lblDangChieu;
        private readonly Label lblSapChieu;
        private readonly Panel indicator; // Thanh gạch chân màu vàng

        // Bảng màu lấy chuẩn theo ảnh mẫu Cinestar
        private readonly Color ActiveBg = Color.FromArgb(44, 34, 85);     // Tím than đậm (#2C2255)
        private readonly Color InactiveBg = Color.FromArgb(17, 23, 42);   // Xanh đen tối (#11172A)
        private readonly Color ActiveText = Color.FromArgb(243, 234, 40); // Vàng tươi (#F3EA28)
        private readonly Color InactiveText = Color.White;
        public MovieTabBar()
        {
           
            Size = new Size(1080, 60   );
            int halfwidth = 1080 / 2;
            DoubleBuffered = true;
            lblDangChieu = new Label()
            {
                Text = "PHIM ĐANG CHIẾU",
                
                Bounds = new Rectangle(0, 0, halfwidth, Height-4),
                Font = new Font("Bahnschrift Condensed", 18f,FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            lblSapChieu = new Label
            {
                Text = "PHIM SẮP CHIẾU",
                Bounds = new Rectangle(halfwidth, 0, halfwidth, Height-4),
                Font = new Font("Bahnschrift Condensed", 18f,FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            indicator = new Panel()
            {
                Size = new Size(halfwidth , 4),
                Location = new Point(0, Height - 4),
                BackColor = ActiveText
            };
            SelectTab(1);
            lblDangChieu.Click += LblDangChieu_Click;
            lblSapChieu.Click += LblSapChieu_Click;
            Controls.Add(lblDangChieu);
            Controls.Add(lblSapChieu);
            Controls.Add(indicator);

        }
        public void SelectTab(int index_)
        {
             if(index_ == 1)
             {
                indicator.Left = 0;
                lblDangChieu.BackColor = ActiveBg;    // Nền tím đậm cho tab đang chọn
                lblDangChieu.ForeColor = ActiveText;
                lblSapChieu.BackColor = InactiveBg;   // Nền tối cho tab còn lại
                lblSapChieu.ForeColor = InactiveText;
            }
             if(index_ == 2)
             {
                indicator.Left = Width / 2;
                lblDangChieu.BackColor = InactiveBg;
                lblDangChieu.ForeColor = InactiveText;
                lblSapChieu.BackColor = ActiveBg;
                lblSapChieu.ForeColor = ActiveText;
            }
            TabChanged?.Invoke(index_);

        } 
        private void LblSapChieu_Click(object? sender, EventArgs e)
        {
            SelectTab(2);
        }

        private void LblDangChieu_Click(object? sender, EventArgs e)
        {
            SelectTab(1);
        }  
    }
}
