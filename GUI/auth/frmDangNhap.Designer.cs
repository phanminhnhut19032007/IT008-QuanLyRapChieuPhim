namespace QuanLyRapChieuPhim.GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pblDangNhap = new Panel();
            btnDangNhap = new Button();
            btnHuy = new Button();
            picGif = new PictureBox();
            llbQuenMatKhau = new LinkLabel();
            llbTaoTaiKhoan = new LinkLabel();
            tb2 = new TextBox();
            tb1 = new TextBox();
            rdbtn2 = new RadioButton();
            rdbtn1 = new RadioButton();
            lb3 = new Label();
            lb2 = new Label();
            lb1 = new Label();
            pblDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGif).BeginInit();
            SuspendLayout();
            // 
            // pblDangNhap
            // 
            pblDangNhap.BackColor = Color.Transparent;
            pblDangNhap.BackgroundImage = (Image)resources.GetObject("pblDangNhap.BackgroundImage");
            pblDangNhap.BackgroundImageLayout = ImageLayout.Stretch;
            pblDangNhap.Controls.Add(btnDangNhap);
            pblDangNhap.Controls.Add(btnHuy);
            pblDangNhap.Controls.Add(picGif);
            pblDangNhap.Controls.Add(llbQuenMatKhau);
            pblDangNhap.Controls.Add(llbTaoTaiKhoan);
            pblDangNhap.Controls.Add(tb2);
            pblDangNhap.Controls.Add(tb1);
            pblDangNhap.Controls.Add(rdbtn2);
            pblDangNhap.Controls.Add(rdbtn1);
            pblDangNhap.Controls.Add(lb3);
            pblDangNhap.Controls.Add(lb2);
            pblDangNhap.Controls.Add(lb1);
            pblDangNhap.Dock = DockStyle.Left;
            pblDangNhap.ForeColor = SystemColors.ActiveCaption;
            pblDangNhap.Location = new Point(0, 0);
            pblDangNhap.Name = "pblDangNhap";
            pblDangNhap.Size = new Size(478, 533);
            pblDangNhap.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            btnDangNhap.Location = new Point(292, 432);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(150, 28);
            btnDangNhap.TabIndex = 11;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuy
            // 
            btnHuy.ForeColor = SystemColors.ActiveCaptionText;
            btnHuy.Location = new Point(142, 433);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(144, 28);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // picGif
            // 
            picGif.BackColor = Color.Black;
            picGif.BackgroundImageLayout = ImageLayout.Stretch;
            picGif.Image = (Image)resources.GetObject("picGif.Image");
            picGif.Location = new Point(102, 23);
            picGif.Name = "picGif";
            picGif.Size = new Size(250, 250);
            picGif.SizeMode = PictureBoxSizeMode.StretchImage;
            picGif.TabIndex = 9;
            picGif.TabStop = false;
            // 
            // llbQuenMatKhau
            // 
            llbQuenMatKhau.ActiveLinkColor = Color.SkyBlue;
            llbQuenMatKhau.AutoSize = true;
            llbQuenMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbQuenMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            llbQuenMatKhau.Location = new Point(147, 473);
            llbQuenMatKhau.Name = "llbQuenMatKhau";
            llbQuenMatKhau.Size = new Size(145, 28);
            llbQuenMatKhau.TabIndex = 8;
            llbQuenMatKhau.TabStop = true;
            llbQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // llbTaoTaiKhoan
            // 
            llbTaoTaiKhoan.ActiveLinkColor = Color.SkyBlue;
            llbTaoTaiKhoan.AutoSize = true;
            llbTaoTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbTaoTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            llbTaoTaiKhoan.Location = new Point(307, 473);
            llbTaoTaiKhoan.Name = "llbTaoTaiKhoan";
            llbTaoTaiKhoan.Size = new Size(135, 28);
            llbTaoTaiKhoan.TabIndex = 7;
            llbTaoTaiKhoan.TabStop = true;
            llbTaoTaiKhoan.Text = "Tạo tài khoản ";
            llbTaoTaiKhoan.LinkClicked += llbTaoTaiKhoan_LinkClicked;
            // 
            // tb2
            // 
            tb2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb2.Location = new Point(142, 349);
            tb2.Name = "tb2";
            tb2.Size = new Size(302, 31);
            tb2.TabIndex = 6;
            // 
            // tb1
            // 
            tb1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb1.Location = new Point(144, 301);
            tb1.Name = "tb1";
            tb1.Size = new Size(300, 31);
            tb1.TabIndex = 5;
            // 
            // rdbtn2
            // 
            rdbtn2.AutoSize = true;
            rdbtn2.BackColor = Color.Transparent;
            rdbtn2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbtn2.ForeColor = SystemColors.ActiveCaptionText;
            rdbtn2.Location = new Point(278, 397);
            rdbtn2.Name = "rdbtn2";
            rdbtn2.Size = new Size(97, 29);
            rdbtn2.TabIndex = 4;
            rdbtn2.TabStop = true;
            rdbtn2.Text = "Quản lý";
            rdbtn2.UseVisualStyleBackColor = false;
            // 
            // rdbtn1
            // 
            rdbtn1.AutoSize = true;
            rdbtn1.BackColor = Color.Transparent;
            rdbtn1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbtn1.ForeColor = SystemColors.ActiveCaptionText;
            rdbtn1.Location = new Point(142, 395);
            rdbtn1.Name = "rdbtn1";
            rdbtn1.Size = new Size(132, 29);
            rdbtn1.TabIndex = 3;
            rdbtn1.TabStop = true;
            rdbtn1.Text = "Khách hàng ";
            rdbtn1.UseVisualStyleBackColor = false;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.BackColor = Color.Transparent;
            lb3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb3.ForeColor = SystemColors.ActiveCaptionText;
            lb3.Location = new Point(55, 396);
            lb3.Name = "lb3";
            lb3.Size = new Size(74, 28);
            lb3.TabIndex = 2;
            lb3.Text = "Vai trò";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.BackColor = Color.Transparent;
            lb2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb2.ForeColor = SystemColors.ActiveCaptionText;
            lb2.Location = new Point(38, 349);
            lb2.Name = "lb2";
            lb2.Size = new Size(108, 28);
            lb2.TabIndex = 1;
            lb2.Text = "Mật khẩu ";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = Color.Transparent;
            lb1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.ForeColor = SystemColors.ActiveCaptionText;
            lb1.Location = new Point(0, 301);
            lb1.Name = "lb1";
            lb1.Size = new Size(146, 28);
            lb1.TabIndex = 0;
            lb1.Text = "Tên tài khoản ";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(999, 533);
            Controls.Add(pblDangNhap);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CINEMA STAR";
            pblDangNhap.ResumeLayout(false);
            pblDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pblDangNhap;
        private Label lb1;
        private Label lb3;
        private Label lb2;
        private RadioButton rdbtn2;
        private RadioButton rdbtn1;
        private TextBox tb1;
        private TextBox tb2;
        private LinkLabel llbQuenMatKhau;
        private LinkLabel llbTaoTaiKhoan;
        private PictureBox picGif;
        private Button btnDangNhap;
        private Button btnHuy;
    }
}