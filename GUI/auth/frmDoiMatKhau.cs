using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.GUI.auth
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            KhoiTaoGiaoDienDoiMatKhau();
        }
        public void KhoiTaoGiaoDienDoiMatKhau()
        {
            if (pnlDoiMatKhau != null)
            {
                pnlDoiMatKhau.Resize += (s, e) => effuiux.BoGocControl(pnlDoiMatKhau, 24);
                effuiux.BoGocControl(pnlDoiMatKhau, 24);
            }
            if (btnXacNhan != null)
            {
                btnXacNhan.Resize += (s, e) => effuiux.BoGocControl(btnXacNhan, 18);
                effuiux.BoGocControl(btnXacNhan, 18);
            }
            if (btnQuayLai != null)
            {
                btnQuayLai.Resize += (s, e) => effuiux.BoGocControl(btnQuayLai, 18);
                effuiux.BoGocControl(btnQuayLai, 18);
            }
            if (tbSoDienThoai != null)
            {
                tbSoDienThoai.Resize += (s, e) => effuiux.BoGocControl(tbSoDienThoai, 8);
                effuiux.BoGocControl(tbSoDienThoai, 8);
            }
            if (tbMatKhauCu != null)
            {
                tbMatKhauCu.Resize += (s, e) => effuiux.BoGocControl(tbMatKhauCu, 8);
                effuiux.BoGocControl(tbMatKhauCu, 8);
            }
            if (tbMatKhauMoi != null)
            {
                tbMatKhauMoi.Resize += (s, e) => effuiux.BoGocControl(tbMatKhauMoi, 8);
                effuiux.BoGocControl(tbMatKhauMoi, 8);
            }
            if (tbXacNhanMatKhauMoi != null)
            {
                tbXacNhanMatKhauMoi.Resize += (s, e) => effuiux.BoGocControl(tbXacNhanMatKhauMoi, 8);
                effuiux.BoGocControl(tbXacNhanMatKhauMoi, 8);
            }

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form đổi mật khẩu và trở về form đăng nhập
        }
    }
}
