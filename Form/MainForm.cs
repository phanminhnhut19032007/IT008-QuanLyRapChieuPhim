using Cinema.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cinema
{
    public  class MainForm : BaseForm
    {
        FlowLayoutPanel flowpage = new FlowLayoutPanel
        {
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            BackColor = Color.Transparent,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Margin = Padding.Empty,
            Padding = Padding.Empty

        };
        readonly Panel pnlScroll = new() { Dock = DockStyle.Fill, AutoScroll = true, BackColor = Theme.Bg };
        CinemaBanner Banner = new CinemaBanner("Cinema","banner.jpeg");
        Header header = new Header();

        public MainForm()
        {
            Text = "Hệ thống quản lý rạp chiếu phim";
            SuspendLayout();
            Padding = new Padding(100, 0, 100, 0); 
            
            pnlScroll.BackColor = Color.Transparent;
            pnlScroll.Controls.Add(flowpage);
            flowpage.Controls.Add(Banner);
            Controls.Add(pnlScroll);
            Controls.Add(header);
            
            ResumeLayout(true);
            
        }
    }
}
