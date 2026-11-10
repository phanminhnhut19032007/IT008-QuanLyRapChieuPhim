using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyRapChieuPhim.BUS;
using QuanLyRapChieuPhim.DTO;

namespace QuanLyRapChieuPhim.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();

            // Gán phím Enter cho nút Đăng nhập và ESC cho nút Hủy/Thoát
            this.AcceptButton = btnDangNhap;
            this.CancelButton = btnHuy;
        }

        private void KhoiTaoGiaoDien()
        {
            //  Bo góc panel đăng nhập chính
            if (pblDangNhap != null)
            {
                pblDangNhap.Resize += (s, e) => UIFrmDangNhap.BoGocControl(pblDangNhap, 24);
                UIFrmDangNhap.BoGocControl(pblDangNhap, 24);
            }

            // Cắt tròn khung PictureBox chứa GIF và vẽ viền đỏ
            if (picGif != null)
            {
                picGif.SizeMode = PictureBoxSizeMode.StretchImage;
                UIFrmDangNhap.BoTronControl(picGif);
                picGif.Paint += (s, e) =>
                {
                    UIFrmDangNhap.VeVienTron(e.Graphics, picGif.Width, picGif.Height, Color.FromArgb(220, 53, 69), 2f);
                };
            }

      
          
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
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
            var ketQua = TaiKhoanBUS.Instance.XuLyDangNhap(tenDangNhap, matKhau);

            if (!ketQua.thanhCong)
            {
                MessageBox.Show(ketQua.thongBao, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb2.SelectAll();
                tb2.Focus();
                return;
            }

            // Kiểm tra khớp RadioButton
            string vaiTroChon = rdBtn2.Checked ? "Admin" : "KhachHang";
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

            if (Session.Quyen == "Admin")
            {
                MessageBox.Show("Chuyển hướng vào màn hình Quản lý", "Admin Dashboard");
            }
            else
            {
                MessageBox.Show($"Chuyển hướng vào màn hình Đặt vé (Mã khách hàng: {Session.MaKH})", "Khách hàng");
            }

            // Reset phiên khi quay lại
            Session.Clear();
            tb2.Text = "";
            tb1.Focus();
            this.Show();
        }

        //    private void btnHuy_Click(object sender, EventArgs e)
        //    {
        //        DialogResult dr = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Xác nhận",
        //                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (dr == DialogResult.Yes)
        //        {
        //            Application.Exit();
        //        }
        //    }
        //
        //
    }
}