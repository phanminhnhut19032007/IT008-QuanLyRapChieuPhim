using QuanLyRapChieuPhim.BUS;
using QuanLyRapChieuPhim.DTO;
using QuanLyRapChieuPhim.GUI.auth;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            KhoiTaoGiaoDienDangNhap();

            // Gán phím Enter cho nút Đăng nhập và ESC cho nút Hủy/Thoát
            this.AcceptButton = btnDangNhap;
            this.CancelButton = btnHuy;
        }

        private void KhoiTaoGiaoDienDangNhap()
        {
            //  Bo góc panel đăng nhập chính
            if (pblDangNhap != null)
            {
                pblDangNhap.Resize += (s, e) => effuiux.BoGocControl(pblDangNhap, 24);
                effuiux.BoGocControl(pblDangNhap, 24);
            }

            // Cắt tròn khung PictureBox chứa GIF và vẽ viền đỏ
            if (picGif != null)
            {
                picGif.SizeMode = PictureBoxSizeMode.StretchImage;
                effuiux.BoTronControl(picGif);
                picGif.Paint += (s, e) =>
                {
                    effuiux.VeVienTron(e.Graphics, picGif.Width, picGif.Height, Color.FromArgb(220, 53, 69), 2f);
                };
            }
            if (tb1 != null)
            {
                tb1.Resize += (s, e) => effuiux.BoGocControl(tb1, 4);
                effuiux.BoGocControl(tb1, 4);
            }
            if (tb2 != null)
            {
                tb2.Resize += (s, e) => effuiux.BoGocControl(tb2, 4);
                effuiux.BoGocControl(tb2, 4);
            }
            if(btnDangNhap != null)
            {
                btnDangNhap.Resize += (s, e) => effuiux.BoGocControl(btnDangNhap, 18);
                effuiux.BoGocControl(btnDangNhap, 18);
            }
            if(btnHuy != null)
            {
                btnHuy.Resize += (s, e) => effuiux.BoGocControl(btnHuy, 18);
                effuiux.BoGocControl(btnHuy, 18);
            }


        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = tb1.Text.Trim();
                string matKhau = tb2.Text;

                // Kiểm tra rỗng
                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb1.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb2.Focus();
                    return;
                }

                // Gọi Tầng BUS băm SHA-256 và đối chiếu CSDL
                var (thanhCong, thongBao, tk) = TaiKhoanBUS.Instance.XuLyDangNhap(tenDangNhap, matKhau);

                if (!thanhCong)
                {
                    MessageBox.Show(thongBao, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb2.SelectAll();
                    tb2.Focus();
                    return;
                }

                // Kiểm tra khớp RadioButton
                string vaiTroChon = rdbtn2.Checked ? "Admin" : "KhachHang";
                if (!string.Equals(Session.Quyen, vaiTroChon, StringComparison.OrdinalIgnoreCase))
                {
                    string tenQuyen = Session.Quyen == "Admin" ? "Quản lý" : "Khách hàng";
                    MessageBox.Show($"Tài khoản này có vai trò là '{tenQuyen}'.\nVui lòng tích đúng vai trò trước khi đăng nhập!",
                                    "Sai phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đăng nhập thành công -> Điều hướng
                MessageBox.Show($"Đăng nhập thành công!\nXin chào: {Session.TenDangNhap})",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();



                // Reset phiên khi quay lại
                Session.Clear();
                tb2.Text = "";
                tb1.Focus();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xác nhận thoát ứng dụng
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void llbTaoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Ẩn tạm form Đăng nhập
            using (frmDangKy frm = new frmDangKy())
            {
                frm.ShowDialog(); // Mở form Đăng ký và chờ người dùng thao tác xong
            }
            this.Show(); // Tự động hiện lại form Đăng nhập khi form Đăng ký đóng
        }

      

        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Ẩn tạm form Đăng nhập
            using (frmDoiMatKhau frm = new frmDoiMatKhau())
            {
                frm.ShowDialog(); // Mở form Đổi mật khẩu và chờ người dùng thao tác xong
            }
            this.Show(); // Tự động hiện lại form Đăng nhập khi form Đổi mật khẩu đóng
        }
    }
}