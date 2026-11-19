using System.Windows.Forms;

namespace Cinema.Controls
{
    /// <summary>
    /// Panel cuộn (AutoScroll) có vẽ qua bộ đệm: hết mảng trắng và giật khi lướt.
    /// WS_EX_COMPOSITED chỉ cần đặt ở panel NGOÀI CÙNG chứa nội dung cuộn;
    /// các control con bên trong tự được vẽ qua bộ đệm.
    /// </summary>
    public class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
    }

    /// <summary>FlowLayoutPanel có DoubleBuffered (dùng cho flow nằm bên trong BufferedPanel).</summary>
    public class DoubleBufferedFlowPanel : FlowLayoutPanel
    {
        public DoubleBufferedFlowPanel()
        {
            DoubleBuffered = true;
        }
    }
}
