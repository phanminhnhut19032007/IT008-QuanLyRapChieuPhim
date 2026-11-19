using Cinema.Controls;
using Cinema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cinema
{
    public class MainForm : BaseForm
    {
        // SỬA 1: FlowLayoutPanel -> DoubleBufferedFlowPanel, BackColor Transparent -> màu đặc (Theme.Bg)
        DoubleBufferedFlowPanel flowpage = new DoubleBufferedFlowPanel
        {
            Padding = new Padding(90, 0, 0, 0),
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            BackColor = Theme.Navy,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Margin = Padding.Empty,
        };
        DoubleBufferedFlowPanel flowMovies = new DoubleBufferedFlowPanel
        {
            Width = 1080,
            MinimumSize = new Size(1080, 0),
            MaximumSize = new Size(1080, 0), // 0 ở
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = true,
            BackColor = Color.FromArgb(44, 34, 85),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Padding = Padding.Empty
        };

        // SỬA 2: Panel thường -> BufferedPanel (WS_EX_COMPOSITED), đây là chỗ quan trọng nhất
        readonly BufferedPanel pnlScroll = new() { Dock = DockStyle.Fill, AutoScroll = true, BackColor = Theme.Navy };

        CinemaBanner Banner = new CinemaBanner("Cinema", "banner.jpeg");
        Header header = new Header();
        Panel line = new Panel
        {
            Size = new Size(1080, 1),
            BackColor = Color.FromArgb(220, 224, 230), // Xám vừa đủ rõ trên nền trắng
            Margin = Padding.Empty
        };
        MovieTabBar MovieTabBar_ = new MovieTabBar();
        public MainForm()
        {
            Text = "Hệ thống quản lý rạp chiếu phim";
           
            DoubleBuffered = true;

            // SỬA 3: bỏ dòng pnlScroll.BackColor = Color.Transparent;
            // Nền trong suốt trong vùng cuộn là nguyên nhân chính gây mảng trắng: mỗi lần cuộn
            // Windows phải vẽ lại nền của cha cho từng control con.
       
            pnlScroll.Controls.Add(flowpage);
            flowpage.Controls.Add(header);
            flowpage.Controls.Add(Banner);
            flowpage.Controls.Add(line);
            flowpage.Controls.Add(MovieTabBar_);
            flowpage.Controls.Add(flowMovies);
            Controls.Add(pnlScroll);
            this.ActiveControl = pnlScroll;

            LoadMovie(SampleData.ShowingMovie, isUpcoming: false);

            MovieTabBar_.TabChanged += MovieTabBar_TabChanged;
            
        }

        private void MovieTabBar_TabChanged(int index_)
        {
            if (index_ == 1)
            {
                LoadMovie(SampleData.ShowingMovie, isUpcoming: false);
            }
            else if (index_ == 2)
            {
                LoadMovie(SampleData.UpcomingMovie, isUpcoming: true);
            }
        }

        private void LoadMovie(List<Movie> movies, bool isUpcoming)
        {
            flowMovies.SuspendLayout();

            // SỬA 4: Controls.Clear() chỉ gỡ control ra khỏi panel chứ KHÔNG giải phóng.
            // Mỗi lần đổi tab, các MovieCard cũ (và ảnh poster của chúng) vẫn nằm trong bộ nhớ -> càng dùng càng nặng.
            var oldCards = flowMovies.Controls.Cast<Control>().ToList();
            flowMovies.Controls.Clear();
            foreach (var c in oldCards) c.Dispose();

            for (int i = 0; i < movies.Count; i++)
            {
                var card = new MovieCard(movies[i], isUpcoming);

                int rightMargin = (i % 2 == 1) ? 0 : 24;
                card.Margin = new Padding(0, 0, rightMargin, 28);
                flowMovies.Controls.Add(card);
            }
            flowMovies.ResumeLayout(true);
        }
    }
}
