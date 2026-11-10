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
            linklb2 = new LinkLabel();
            linklb1 = new LinkLabel();
            tb2 = new TextBox();
            tb1 = new TextBox();
            rdBtn2 = new RadioButton();
            rdBtn1 = new RadioButton();
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
            pblDangNhap.Controls.Add(linklb2);
            pblDangNhap.Controls.Add(linklb1);
            pblDangNhap.Controls.Add(tb2);
            pblDangNhap.Controls.Add(tb1);
            pblDangNhap.Controls.Add(rdBtn2);
            pblDangNhap.Controls.Add(rdBtn1);
            pblDangNhap.Controls.Add(lb3);
            pblDangNhap.Controls.Add(lb2);
            pblDangNhap.Controls.Add(lb1);
            pblDangNhap.Dock = DockStyle.Left;
            pblDangNhap.ForeColor = SystemColors.ActiveCaption;
            pblDangNhap.Location = new Point(0, 0);
            pblDangNhap.Name = "pblDangNhap";
            pblDangNhap.Size = new Size(453, 533);
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
            btnDangNhap.Click += this.btnDangNhap_Click;
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
            // 
            // picGif
            // 
            picGif.BackColor = Color.Black;
            picGif.BackgroundImageLayout = ImageLayout.Stretch;
            picGif.Image = (Image)resources.GetObject("picGif.Image");
            picGif.Location = new Point(95, 23);
            picGif.Name = "picGif";
            picGif.Size = new Size(269, 266);
            picGif.SizeMode = PictureBoxSizeMode.StretchImage;
            picGif.TabIndex = 9;
            picGif.TabStop = false;
            // 
            // linklb2
            // 
            linklb2.ActiveLinkColor = Color.SkyBlue;
            linklb2.AutoSize = true;
            linklb2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklb2.ImageAlign = ContentAlignment.MiddleLeft;
            linklb2.Location = new Point(147, 473);
            linklb2.Name = "linklb2";
            linklb2.Size = new Size(145, 28);
            linklb2.TabIndex = 8;
            linklb2.TabStop = true;
            linklb2.Text = "Quên mật khẩu";
            // 
            // linklb1
            // 
            linklb1.ActiveLinkColor = Color.SkyBlue;
            linklb1.AutoSize = true;
            linklb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklb1.ImageAlign = ContentAlignment.MiddleLeft;
            linklb1.Location = new Point(307, 473);
            linklb1.Name = "linklb1";
            linklb1.Size = new Size(135, 28);
            linklb1.TabIndex = 7;
            linklb1.TabStop = true;
            linklb1.Text = "Tạo tài khoản ";
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
            // rdBtn2
            // 
            rdBtn2.AutoSize = true;
            rdBtn2.BackColor = Color.Transparent;
            rdBtn2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBtn2.ForeColor = SystemColors.ActiveCaptionText;
            rdBtn2.Location = new Point(278, 397);
            rdBtn2.Name = "rdBtn2";
            rdBtn2.Size = new Size(94, 29);
            rdBtn2.TabIndex = 4;
            rdBtn2.TabStop = true;
            rdBtn2.Text = "Quản lý";
            rdBtn2.UseVisualStyleBackColor = false;
            // 
            // rdBtn1
            // 
            rdBtn1.AutoSize = true;
            rdBtn1.BackColor = Color.Transparent;
            rdBtn1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBtn1.ForeColor = SystemColors.ActiveCaptionText;
            rdBtn1.Location = new Point(142, 395);
            rdBtn1.Name = "rdBtn1";
            rdBtn1.Size = new Size(130, 29);
            rdBtn1.TabIndex = 3;
            rdBtn1.TabStop = true;
            rdBtn1.Text = "Khách hàng ";
            rdBtn1.UseVisualStyleBackColor = false;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.BackColor = Color.Transparent;
            lb3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb3.ForeColor = SystemColors.ActiveCaptionText;
            lb3.Location = new Point(55, 396);
            lb3.Name = "lb3";
            lb3.Size = new Size(69, 28);
            lb3.TabIndex = 2;
            lb3.Text = "Vai trò";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.BackColor = Color.Transparent;
            lb2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2.ForeColor = SystemColors.ActiveCaptionText;
            lb2.Location = new Point(39, 349);
            lb2.Name = "lb2";
            lb2.Size = new Size(99, 28);
            lb2.TabIndex = 1;
            lb2.Text = "Mật khẩu ";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = Color.Transparent;
            lb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.ForeColor = SystemColors.ActiveCaptionText;
            lb1.Location = new Point(12, 301);
            lb1.Name = "lb1";
            lb1.Size = new Size(132, 28);
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
        private RadioButton rdBtn2;
        private RadioButton rdBtn1;
        private TextBox tb1;
        private TextBox tb2;
        private LinkLabel linklb2;
        private LinkLabel linklb1;
        private PictureBox picGif;
        private Button btnDangNhap;
        private Button btnHuy;
    }
}