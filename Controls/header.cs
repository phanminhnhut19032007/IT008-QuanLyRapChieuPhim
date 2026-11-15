using Cinema.FuntionHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design; 

namespace Cinema.Controls
{
    public class Header : UserControl
    {
        public RoundedSearchBox txtSearch = new RoundedSearchBox()
        {
            Bounds = new Rectangle(560,25, 280 , 45),
            BorderRadius = 18
        };
        Panel line = new Panel
        {
            Bounds = new Rectangle(0,100, 1080, 1),
            BackColor = Color.FromArgb(220, 224, 230) // Xám vừa đủ rõ trên nền trắng
        };
        LinkLabel lnkDangNhap = new LinkLabel()
        {
            Text = "Đăng Nhập",
            Location = new Point(890, 38),
            Font = new Font("Time New Roman", 13f),
            BackColor = Color.Transparent,
            AutoSize = true,
            LinkBehavior = LinkBehavior.HoverUnderline, // gach chan
            LinkColor = Color.White,
            ActiveLinkColor = Color.Gold // doi mau vang khi bam
        };
        PictureBox logoDangNhap = new PictureBox()
        {
            Bounds = new Rectangle(850, 35, 35, 32), // Kích thước 28x28, Y = 35 ngang hàng với chữ
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.Transparent
       
        };
        public Header()
        {
            Size = new Size(1280, 150);
            Dock = DockStyle.Top;
            BackColor = Theme.Navy;
            var pnlTop = new Panel { Bounds = new Rectangle(0, 0, 1080, 99), BackColor = Theme.RedPrimary };
            Control  logo;
            string logoPath = ImageHelper.ResPath("logo.jpg");
            if (File.Exists(logoPath)){
                logo = new PictureBox
                {
                    Bounds = new Rectangle(0, 8, 110, 90),
                    SizeMode = PictureBoxSizeMode.Zoom, // picture tu dong co gian ben trong khung 
                    Image = Image.FromFile(logoPath)    
                };
            }
            else
            {
                logo = new Label
                {
                    Text = "Cinema",
                    Bounds = new Rectangle(20, 8, 150, 48),
                    ForeColor = Theme.Orange,
                    Font = new Font("Segoe UI", 18f, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft
                };
            }
            string bgPath = ImageHelper.ResPath("header_bg.png"); // Đổi tên đúng với file ảnh của bạn
            if (File.Exists(bgPath))
            {
                pnlTop.BackgroundImage = Image.FromFile(bgPath);
               
            }
            string DangNhapPath = ImageHelper.ResPath("login2.png");
            if (File.Exists(DangNhapPath))
            {
                logoDangNhap.Image = Image.FromFile(DangNhapPath);
            }
            logo.Cursor = Cursors.Hand;
            var btnBook = Theme.Make_Button("🎫Đặt vé ngay", Theme.Orange, Color.White, new Rectangle(200, 25, 140, 45));
            var btnPopCorn = Theme.Make_Button("🍿Đặt Bắp Nước", Color.DarkViolet, Color.White, new Rectangle(350, 25, 160, 45));
           

            pnlTop.Controls.Add(logo);
            pnlTop.Controls.Add(btnBook);
            pnlTop.Controls.Add(btnPopCorn);
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(logoDangNhap);
            pnlTop.Controls.Add(lnkDangNhap);
            this.Controls.Add(pnlTop);
            this.Controls.Add(line);
        }   

    }
}
