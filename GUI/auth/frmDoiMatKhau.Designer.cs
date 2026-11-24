namespace QuanLyRapChieuPhim.GUI.auth
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            lb1 = new Label();
            lb2 = new Label();
            tbSoDienThoai = new TextBox();
            tbMatKhauCu = new TextBox();
            tbMatKhauMoi = new TextBox();
            tbXacNhanMatKhauMoi = new TextBox();
            lb5 = new Label();
            btnXacNhan = new Button();
            btnQuayLai = new Button();
            lb3 = new Label();
            lb4 = new Label();
            pnlDoiMatKhau = new Panel();
            pnlDoiMatKhau.SuspendLayout();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.Location = new Point(180, 43);
            lb1.Name = "lb1";
            lb1.Size = new Size(200, 38);
            lb1.TabIndex = 0;
            lb1.Text = "Đổi Mật Khẩu ";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 12F);
            lb2.Location = new Point(51, 133);
            lb2.Name = "lb2";
            lb2.Size = new Size(133, 28);
            lb2.TabIndex = 1;
            lb2.Text = "Số điện thoại ";
            // 
            // tbSoDienThoai
            // 
            tbSoDienThoai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSoDienThoai.Location = new Point(203, 137);
            tbSoDienThoai.Name = "tbSoDienThoai";
            tbSoDienThoai.Size = new Size(306, 27);
            tbSoDienThoai.TabIndex = 2;
            // 
            // tbMatKhauCu
            // 
            tbMatKhauCu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMatKhauCu.Location = new Point(203, 207);
            tbMatKhauCu.Name = "tbMatKhauCu";
            tbMatKhauCu.Size = new Size(306, 27);
            tbMatKhauCu.TabIndex = 4;
            // 
            // tbMatKhauMoi
            // 
            tbMatKhauMoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMatKhauMoi.Location = new Point(203, 277);
            tbMatKhauMoi.Name = "tbMatKhauMoi";
            tbMatKhauMoi.Size = new Size(306, 27);
            tbMatKhauMoi.TabIndex = 6;
            // 
            // tbXacNhanMatKhauMoi
            // 
            tbXacNhanMatKhauMoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbXacNhanMatKhauMoi.Location = new Point(203, 342);
            tbXacNhanMatKhauMoi.Name = "tbXacNhanMatKhauMoi";
            tbXacNhanMatKhauMoi.Size = new Size(306, 27);
            tbXacNhanMatKhauMoi.TabIndex = 8;
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Font = new Font("Segoe UI", 12F);
            lb5.Location = new Point(7, 338);
            lb5.Name = "lb5";
            lb5.Size = new Size(177, 28);
            lb5.TabIndex = 7;
            lb5.Text = "Xác nhận mật khẩu";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(377, 407);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(132, 33);
            btnXacNhan.TabIndex = 9;
            btnXacNhan.Text = "Xác nhận ";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(222, 409);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(132, 31);
            btnQuayLai.TabIndex = 10;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb3.Location = new Point(65, 203);
            lb3.Name = "lb3";
            lb3.Size = new Size(119, 28);
            lb3.TabIndex = 11;
            lb3.Text = "Mật khẩu cũ";
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb4.Location = new Point(51, 276);
            lb4.Name = "lb4";
            lb4.Size = new Size(133, 28);
            lb4.TabIndex = 12;
            lb4.Text = "Mật khẩu mới";
            // 
            // pnlDoiMatKhau
            // 
            pnlDoiMatKhau.Controls.Add(lb1);
            pnlDoiMatKhau.Controls.Add(lb4);
            pnlDoiMatKhau.Controls.Add(lb2);
            pnlDoiMatKhau.Controls.Add(lb3);
            pnlDoiMatKhau.Controls.Add(tbSoDienThoai);
            pnlDoiMatKhau.Controls.Add(btnQuayLai);
            pnlDoiMatKhau.Controls.Add(tbMatKhauCu);
            pnlDoiMatKhau.Controls.Add(btnXacNhan);
            pnlDoiMatKhau.Controls.Add(tbMatKhauMoi);
            pnlDoiMatKhau.Controls.Add(tbXacNhanMatKhauMoi);
            pnlDoiMatKhau.Controls.Add(lb5);
            pnlDoiMatKhau.Location = new Point(64, 40);
            pnlDoiMatKhau.Name = "pnlDoiMatKhau";
            pnlDoiMatKhau.Size = new Size(552, 505);
            pnlDoiMatKhau.TabIndex = 13;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(704, 615);
            Controls.Add(pnlDoiMatKhau);
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDoiMatKhau";
            pnlDoiMatKhau.ResumeLayout(false);
            pnlDoiMatKhau.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lb1;
        private Label lb2;
        private TextBox tbSoDienThoai;
        private TextBox tbMatKhauCu;
        private Label label1;
        private TextBox tbMatKhauMoi;
        private Label label2;
        private TextBox tbXacNhanMatKhauMoi;
        private Label lb5;
        private Button btnXacNhan;
        private Button btnQuayLai;
        private Label lb3;
        private Label lb4;
        private Panel pnlDoiMatKhau;
    }
}