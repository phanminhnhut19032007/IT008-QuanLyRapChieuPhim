namespace QuanLyRapChieuPhim.GUI
{
    partial class frmDoiMauNen
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblHuongDan;
        private Panel pnlPreview;
        private Button btnChonMau;
        private Button btnApDung;
        private Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlPreview = new Panel();
            lblHuongDan = new Label();
            btnChonMau = new Button();
            btnApDung = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblHuongDan
            // 
            lblHuongDan.AutoSize = true;
            lblHuongDan.Location = new Point(20, 18);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(175, 20);
            lblHuongDan.TabIndex = 0;
            lblHuongDan.Text = "Chọn màu nền cho panel:";
            // 
            // pnlPreview
            // 
            pnlPreview.BorderStyle = BorderStyle.FixedSingle;
            pnlPreview.Location = new Point(20, 48);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(320, 35);
            pnlPreview.TabIndex = 1;
            // 
            // btnChonMau
            // 
            btnChonMau.AutoSize = true;
            btnChonMau.Location = new Point(20, 100);
            btnChonMau.Name = "btnChonMau";
            btnChonMau.Size = new Size(88, 30);
            btnChonMau.TabIndex = 2;
            btnChonMau.Text = "Chọn màu";
            btnChonMau.UseVisualStyleBackColor = true;
            btnChonMau.Click += ChonMau_Click;
            // 
            // btnApDung
            // 
            btnApDung.AutoSize = true;
            btnApDung.DialogResult = DialogResult.OK;
            btnApDung.Location = new Point(190, 100);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(72, 30);
            btnApDung.TabIndex = 3;
            btnApDung.Text = "Áp dụng";
            btnApDung.UseVisualStyleBackColor = true;
            btnApDung.Click += ApDung_Click;
            // 
            // btnHuy
            // 
            btnHuy.AutoSize = true;
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.Location = new Point(270, 100);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(50, 30);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmDoiMauNen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 170);
            Controls.Add(btnHuy);
            Controls.Add(btnApDung);
            Controls.Add(btnChonMau);
            Controls.Add(pnlPreview);
            Controls.Add(lblHuongDan);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDoiMauNen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi màu nền";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
