using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Drawing2D;

namespace Cinema
{ 
    public static class Theme
    {
        public static Color Navy = Color.FromArgb(26, 26, 78);
        public static Color Orange = Color.FromArgb(255, 120, 0);
        public static Color Bg = Color.FromArgb(245, 245, 245);
        public static Color RedPrimary = Color.FromArgb(198, 40, 40);
        public static Button Make_Button(string text, Color back, Color fore, Rectangle Bound,float fontsize = 10f)
        {
            Button b = new Button
            {
                Text = text,
                BackColor = back,
                Bounds = Bound,
                ForeColor = fore,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", fontsize, FontStyle.Bold),
                UseVisualStyleBackColor = false,
                Cursor = Cursors.Hand
            };
            return b;
        }
    }
    public class BaseForm : Form
    {
        public BaseForm()
        {
            AutoScaleMode = AutoScaleMode.None; // tranh lech man hinh khi scale
            ClientSize = new Size(1280, 720);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            
            Font = new Font("Segoe UI", 8);
            DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var rightRect = new Rectangle(0, 0, Width , Height);
            using var brush = new LinearGradientBrush(
                rightRect,
                Color.FromArgb(62, 30, 102),  // Tím đậm trầm (#3E1E66)
                Color.FromArgb(35, 75, 160),  // Xanh dương đậm (#234BA0) // Xanh dương bên phải (#2E62C6)
                LinearGradientMode.Horizontal
            );
            e.Graphics.FillRectangle(brush, rightRect);
        }
    }
}

