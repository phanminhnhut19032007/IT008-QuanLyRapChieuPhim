using Microsoft.VisualBasic.ApplicationServices;

namespace Cinema
{
    public partial class BaseForm : Form
    {
        public static Color Navy = Color.FromArgb(26, 26, 78);
        public static Color Orange = Color.FromArgb(255, 120, 0);
        public static Color Bg = Color.FromArgb(245, 245, 245);
        public BaseForm()
        {
            AutoScaleMode = AutoScaleMode.None; // tranh lech man hinh khi scale
            ClientSize = new Size(1280, 720);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Bg;
            Font = new Font("Segoe UI", 10);
            DoubleBuffered = true;
        }
    }
}

