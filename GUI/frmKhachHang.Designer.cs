namespace QuanLyRapChieuPhim.GUI
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            lblTieuDe = new Label();
            pnlTop = new Panel();
            lblTimKiem = new Label();
            txtTimKiemSDT = new TextBox();
            lblLocTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnLamMoi = new Button();
            pnlDanhSach = new Panel();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiemTichLuy = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            pnlChiTiet = new Panel();
            lblTieuDeChiTiet = new Label();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDiemTichLuy = new Label();
            txtDiemTichLuy = new TextBox();
            btnCapNhatDiem = new Button();
            pnlPhanCach = new Panel();
            lblTrangThaiTK = new Label();
            btnKhoaMoTK = new Button();
            SuspendLayout();
            pnlTop.SuspendLayout();
            pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            pnlChiTiet.SuspendLayout();

            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(28, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "QUẢN LÝ KHÁCH HÀNG";

            pnlTop.BackColor = Color.FromArgb(118, 62, 160);
            pnlTop.Controls.Add(lblTimKiem);
            pnlTop.Controls.Add(txtTimKiemSDT);
            pnlTop.Controls.Add(lblLocTrangThai);
            pnlTop.Controls.Add(cboTrangThai);
            pnlTop.Controls.Add(btnLamMoi);
            pnlTop.Location = new Point(28, 68);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1144, 70);
            lblTimKiem.AutoSize = true;
            lblTimKiem.BackColor = Color.Transparent;
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimKiem.ForeColor = Color.White;
            lblTimKiem.Location = new Point(22, 24);
            lblTimKiem.Text = "Tìm kiếm SĐT / Tên:";
            txtTimKiemSDT.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiemSDT.Location = new Point(180, 19);
            txtTimKiemSDT.Name = "txtTimKiemSDT";
            txtTimKiemSDT.AutoSize = false;
            txtTimKiemSDT.Size = new Size(300, 32);
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.BackColor = Color.Transparent;
            lblLocTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocTrangThai.ForeColor = Color.White;
            lblLocTrangThai.Location = new Point(522, 24);
            lblLocTrangThai.Text = "Trạng thái:";
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboTrangThai.Items.AddRange(new object[] { "Tất cả", "Hoạt động", "Bị khóa" });
            cboTrangThai.Location = new Point(610, 19);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(220, 25);
            btnLamMoi.BackColor = Color.FromArgb(243, 234, 40);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(956, 16);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(164, 38);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;

            pnlDanhSach.BackColor = Color.White;
            pnlDanhSach.Controls.Add(dgvKhachHang);
            pnlDanhSach.Location = new Point(28, 158);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Padding = new Padding(14);
            pnlDanhSach.Size = new Size(765, 534);
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AllowUserToResizeRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.BorderStyle = BorderStyle.None;
            dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(52, 86, 175);
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(52, 86, 175);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvKhachHang.ColumnHeadersHeight = 40;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, HoTen, SDT, Email, DiemTichLuy, TrangThai });
            rowStyle.BackColor = Color.White;
            rowStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rowStyle.ForeColor = Color.FromArgb(45, 22, 68);
            rowStyle.SelectionBackColor = Color.FromArgb(118, 62, 160);
            rowStyle.SelectionForeColor = Color.FromArgb(243, 234, 40);
            dgvKhachHang.DefaultCellStyle = rowStyle;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.GridColor = Color.FromArgb(230, 230, 238);
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowTemplate.Height = 36;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 246, 250);
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Name = "dgvKhachHang";
            MaKH.HeaderText = "Mã KH";
            MaKH.Name = "MaKH";
            HoTen.HeaderText = "Họ và tên";
            HoTen.Name = "HoTen";
            SDT.HeaderText = "Số điện thoại";
            SDT.Name = "SDT";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            DiemTichLuy.HeaderText = "Điểm";
            DiemTichLuy.Name = "DiemTichLuy";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.Name = "TrangThai";

            pnlChiTiet.BackColor = Color.White;
            pnlChiTiet.Location = new Point(813, 158);
            pnlChiTiet.Name = "pnlChiTiet";
            pnlChiTiet.Size = new Size(359, 534);
            pnlChiTiet.Controls.AddRange(new Control[] { lblTieuDeChiTiet, lblMaKH, txtMaKH, lblHoTen, txtHoTen, lblSDT, txtSDT, lblEmail, txtEmail, lblDiemTichLuy, txtDiemTichLuy, btnCapNhatDiem, pnlPhanCach, lblTrangThaiTK, btnKhoaMoTK });
            lblTieuDeChiTiet.AutoSize = true;
            lblTieuDeChiTiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDeChiTiet.ForeColor = Color.FromArgb(45, 22, 68);
            lblTieuDeChiTiet.Location = new Point(20, 17);
            lblTieuDeChiTiet.Text = "THÔNG TIN & ĐIỀU CHỈNH";

            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaKH.Location = new Point(20, 55);
            lblMaKH.Text = "Mã khách hàng";
            txtMaKH.Location = new Point(20, 73);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(319, 24);
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.Location = new Point(20, 107);
            lblHoTen.Text = "Họ và tên";
            txtHoTen.Location = new Point(20, 125);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(319, 24);
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSDT.Location = new Point(20, 159);
            lblSDT.Text = "Số điện thoại";
            txtSDT.Location = new Point(20, 177);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(319, 24);
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(20, 211);
            lblEmail.Text = "Email";
            txtEmail.Location = new Point(20, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(319, 24);

            lblDiemTichLuy.AutoSize = true;
            lblDiemTichLuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiemTichLuy.Location = new Point(20, 271);
            lblDiemTichLuy.Text = "Điểm tích lũy";
            txtDiemTichLuy.Location = new Point(20, 291);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.Size = new Size(118, 25);
            btnCapNhatDiem.BackColor = Color.FromArgb(243, 234, 40);
            btnCapNhatDiem.FlatAppearance.BorderSize = 0;
            btnCapNhatDiem.FlatStyle = FlatStyle.Flat;
            btnCapNhatDiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhatDiem.ForeColor = Color.Black;
            btnCapNhatDiem.Location = new Point(148, 286);
            btnCapNhatDiem.Name = "btnCapNhatDiem";
            btnCapNhatDiem.Size = new Size(191, 38);
            btnCapNhatDiem.Text = "Cập nhật điểm";
            btnCapNhatDiem.UseVisualStyleBackColor = false;
            pnlPhanCach.BackColor = Color.FromArgb(225, 225, 233);
            pnlPhanCach.Location = new Point(20, 350);
            pnlPhanCach.Name = "pnlPhanCach";
            pnlPhanCach.Size = new Size(319, 1);
            lblTrangThaiTK.AutoSize = true;
            lblTrangThaiTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrangThaiTK.Location = new Point(20, 378);
            lblTrangThaiTK.Name = "lblTrangThaiTK";
            lblTrangThaiTK.Text = "Trạng thái tài khoản";
            btnKhoaMoTK.BackColor = Color.Crimson;
            btnKhoaMoTK.FlatAppearance.BorderSize = 0;
            btnKhoaMoTK.FlatStyle = FlatStyle.Flat;
            btnKhoaMoTK.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoaMoTK.ForeColor = Color.White;
            btnKhoaMoTK.Location = new Point(20, 407);
            btnKhoaMoTK.Name = "btnKhoaMoTK";
            btnKhoaMoTK.Size = new Size(319, 38);
            btnKhoaMoTK.Text = "Khóa tài khoản";
            btnKhoaMoTK.UseVisualStyleBackColor = false;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 22, 68);
            ClientSize = new Size(1200, 720);
            Controls.Add(pnlChiTiet);
            Controls.Add(pnlDanhSach);
            Controls.Add(pnlTop);
            Controls.Add(lblTieuDe);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            pnlChiTiet.ResumeLayout(false);
            pnlChiTiet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTieuDe;
        private Panel pnlTop;
        private Label lblTimKiem;
        private TextBox txtTimKiemSDT;
        private Label lblLocTrangThai;
        private ComboBox cboTrangThai;
        private Button btnLamMoi;
        private Panel pnlDanhSach;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiemTichLuy;
        private DataGridViewTextBoxColumn TrangThai;
        private Panel pnlChiTiet;
        private Label lblTieuDeChiTiet;
        private Label lblMaKH;
        private TextBox txtMaKH;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDiemTichLuy;
        private TextBox txtDiemTichLuy;
        private Button btnCapNhatDiem;
        private Panel pnlPhanCach;
        private Label lblTrangThaiTK;
        private Button btnKhoaMoTK;

        #endregion
    }
}