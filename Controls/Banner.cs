using Cinema.FuntionHelper;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Cinema.Controls
{
    public class CinemaBanner : UserControl
    {
        public CinemaBanner(string title, string imageFileName)
        {
            Size = new Size(1080,200 );
            Margin = Padding.Empty;
            DoubleBuffered = true;

            var picBanner = new PictureBox
            {
                Bounds = new Rectangle(0, 0, 1100, 180),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.FromArgb(20, 24, 40)
            };
            string imgPath = ImageHelper.ResPath(imageFileName);
            if (File.Exists(imgPath))
            {
                picBanner.Image = Image.FromFile(imgPath);
            }

            // 2. Tiêu đề tên rạp chữ in đậm, cao, màu trắng
            var lblTitle = new Label
            {
                Text = title.ToUpper(),
                Location = new Point(450, 42),
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Black,
                Font = new Font("Impact", 28f, FontStyle.Regular), // Font Impact hoặc Bahnschrift Condensed rất giống mẫu
                TextAlign = ContentAlignment.MiddleLeft
            };

            // 3. Dòng địa chỉ kèm icon ghim vị trí bên dưới
            Controls.Add(lblTitle);
            Controls.Add(picBanner);
            
        }

        
    }
}