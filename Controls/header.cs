using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Cinema.Controls
{
    internal class Header : UserControl
    {
       public Header()
        {
            Size = new Size(1280, 100);
            Dock = DockStyle.Top;
            BackColor = Color.White;
            var pnlTop = new Panel { Bounds = new Rectangle(0, 0, 1280, 64), BackColor = Theme.Navy };
            Control  logo;
            string logoPath = Theme.ResPath("logo.png");
            if (File.Exists(logoPath){
                logo = new PictureBox
                {
                    Bounds = new Rectangle(20, 8, 150, 48),
                    SizeMode = PictureBoxSizeMode.Zoom // picture tu dong co gian ben trong khung 
                    Image = ImageHelper.LoadOrPlaceholder(logoPath, 150, 48, "Cinema")
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
            
        }

    }
}
