using QuanLyRapChieuPhim.BUS;
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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
            KhoiTaoGiaoDienDangKy();
        }
        public void KhoiTaoGiaoDienDangKy()
        {
            //  Bo góc panel đăng ký chính
            if (pnlDangKy != null)
            {
                pnlDangKy.Resize += (s, e) => effuiux.BoGocControl(pnlDangKy, 24);
                effuiux.BoGocControl(pnlDangKy, 24);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form đăng ký và trở về form đăng nhập
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var (thanhCong, thongBao) = TaiKhoanBUS.Instance.XuLyDangKy(
                tbHoTen.Text, tbSoDienThoai.Text, tbEmail.Text,
                tbTenTaiKhoan.Text, tbMatKhau.Text, tbNhapLaiMatKhau.Text);

            if (thanhCong)
            {
                MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
