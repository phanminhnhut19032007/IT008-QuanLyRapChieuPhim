using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.FuntionHelper
{
    public class ImageHelper
    {
        // lay duong dan cua anh
        // cac tham so dau la thu muc, tham so cuoi cung la anh;
        public static string ResPath(params string[] paths)
        {
            string link = Path.Combine(AppContext.BaseDirectory); // lay duong dan thu muc goc cua file dang chay
            link = Path.Combine(link, "recourse");
            foreach (string path in paths)
            {
                link = Path.Combine(link, path);
            }
            return link;
        }
        public static void SetImage(PictureBox pic, string path, string fallbackText, float FontSize = 12f)
        {
            // xoa chu ra khoi picturebox;
            for (int i = pic.Controls.Count; i >= 0; i--)
            {
                Control control = pic.Controls[i];
                if (control.GetType() == typeof(Label))
                {
                    if (control.Tag != null && control.Tag.ToString() == "fallback")
                    {
                        pic.Controls.RemoveAt(i); //  xoa khoi picture 
                        control.Dispose(); // giai phong tai nguyen, giong delete con tro ben c++;

                    }
                }
            }
            // xoa anh ra khoi picture box;
            Image oldpic = pic.Image;
            pic.Image = null;
            oldpic?.Dispose();
            // them anh tu path 
            if (File.Exists(path))
            {
                pic.Image = Image.FromFile(path);
                return;
            }
            // khong co anh -> nen xam + chu
            Label lbl = new Label
            {
                Tag = "fallback",
                Text = "fallbacktext",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", FontSize)
            };
            pic.Controls.Add(lbl);
            lbl.SendToBack();
        }
    } 

    
}
