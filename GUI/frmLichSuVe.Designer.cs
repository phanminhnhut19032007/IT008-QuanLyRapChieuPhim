namespace QuanLyRapChieuPhim.GUI
{
    partial class frmLichSuVe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            MaVe = new DataGridViewTextBoxColumn();
            SoGhe = new DataGridViewTextBoxColumn();
            TenPhim = new DataGridViewTextBoxColumn();
            NgayMuaVe = new DataGridViewTextBoxColumn();
            ThoiGianChieu = new DataGridViewTextBoxColumn();
            GiaVe = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            button2 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panel5 = new Panel();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panel8 = new Panel();
            label18 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(1262, 673);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 40);
            panel1.BackColor = Color.FromArgb(30, 26, 69);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 466);
            panel1.TabIndex = 0;
            panel1.Scroll += panel1_Scroll;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 86, 175);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaVe, SoGhe, TenPhim, NgayMuaVe, ThoiGianChieu, GiaVe, TrangThai });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(118, 62, 160);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(243, 234, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(346, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 335);
            dataGridView1.TabIndex = 4;
            dataGridView1.Visible = false;
            // 
            // MaVe
            // 
            MaVe.DataPropertyName = "MaVe";
            MaVe.HeaderText = "Mã Vé";
            MaVe.MinimumWidth = 6;
            MaVe.Name = "MaVe";
            MaVe.ReadOnly = true;
            // 
            // SoGhe
            // 
            SoGhe.DataPropertyName = "SoGhe";
            SoGhe.HeaderText = "Số Ghế";
            SoGhe.MinimumWidth = 6;
            SoGhe.Name = "SoGhe";
            SoGhe.ReadOnly = true;
            // 
            // TenPhim
            // 
            TenPhim.DataPropertyName = "Tên Phim";
            TenPhim.HeaderText = "Tên Phim";
            TenPhim.MinimumWidth = 6;
            TenPhim.Name = "TenPhim";
            TenPhim.ReadOnly = true;
            // 
            // NgayMuaVe
            // 
            NgayMuaVe.DataPropertyName = "NgayMuaVe";
            NgayMuaVe.HeaderText = "Ngày Mua Vé";
            NgayMuaVe.MinimumWidth = 6;
            NgayMuaVe.Name = "NgayMuaVe";
            NgayMuaVe.ReadOnly = true;
            // 
            // ThoiGianChieu
            // 
            ThoiGianChieu.DataPropertyName = "ThoiGianChieu";
            ThoiGianChieu.HeaderText = "Thời Gian Chiếu";
            ThoiGianChieu.MinimumWidth = 6;
            ThoiGianChieu.Name = "ThoiGianChieu";
            ThoiGianChieu.ReadOnly = true;
            // 
            // GiaVe
            // 
            GiaVe.DataPropertyName = "GiaVe";
            GiaVe.HeaderText = "Giá Vé";
            GiaVe.MinimumWidth = 6;
            GiaVe.Name = "GiaVe";
            GiaVe.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(button2);
            panel6.Controls.Add(textBox7);
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(textBox5);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label14);
            panel6.ForeColor = Color.Black;
            panel6.Location = new Point(346, 495);
            panel6.Name = "panel6";
            panel6.Size = new Size(810, 430);
            panel6.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(15, 368);
            button2.Name = "button2";
            button2.Size = new Size(190, 49);
            button2.TabIndex = 10;
            button2.Text = "Đổi mật khẩu";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(18, 314);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(778, 34);
            textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(18, 219);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(778, 34);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(18, 124);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(778, 34);
            textBox5.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 283);
            label17.Name = "label17";
            label17.Size = new Size(173, 28);
            label17.TabIndex = 12;
            label17.Text = "Xác thực mật khẩu";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 188);
            label16.Name = "label16";
            label16.Size = new Size(133, 28);
            label16.TabIndex = 11;
            label16.Text = "Mật khẩu mới";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 93);
            label15.Name = "label15";
            label15.Size = new Size(119, 28);
            label15.TabIndex = 10;
            label15.Text = "Mật khẩu cũ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(15, 15);
            label14.Name = "label14";
            label14.Size = new Size(196, 38);
            label14.TabIndex = 10;
            label14.Text = "Đổi mật khẩu";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button1);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(346, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(810, 335);
            panel5.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(18, 276);
            button1.Name = "button1";
            button1.Size = new Size(190, 49);
            button1.TabIndex = 9;
            button1.Text = "Lưu thông tin";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(416, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(380, 34);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(380, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(416, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 34);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 34);
            textBox1.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(416, 93);
            label13.Name = "label13";
            label13.Size = new Size(99, 28);
            label13.TabIndex = 4;
            label13.Text = "Ngày sinh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(416, 188);
            label12.Name = "label12";
            label12.Size = new Size(59, 28);
            label12.TabIndex = 3;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 188);
            label11.Name = "label11";
            label11.Size = new Size(128, 28);
            label11.TabIndex = 2;
            label11.Text = "Số điện thoại";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 93);
            label10.Name = "label10";
            label10.Size = new Size(96, 28);
            label10.TabIndex = 1;
            label10.Text = "Họ và tên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 15);
            label9.Name = "label9";
            label9.Size = new Size(255, 38);
            label9.TabIndex = 0;
            label9.Text = "Thông tin cá nhân";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(346, 58);
            label8.Name = "label8";
            label8.Size = new Size(448, 46);
            label8.TabIndex = 1;
            label8.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 74, 168);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Cursor = Cursors.Hand;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(80, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 325);
            panel2.TabIndex = 0;
            panel2.Scroll += panel2_Scroll;
            panel2.Paint += panel2_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(243, 234, 40);
            panel8.Location = new Point(11, 162);
            panel8.Name = "panel8";
            panel8.Size = new Size(3, 28);
            panel8.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Location = new Point(57, 127);
            label18.Name = "label18";
            label18.Size = new Size(54, 28);
            label18.TabIndex = 13;
            label18.Text = "/10K";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(85, 74, 168);
            panel7.Location = new Point(20, 115);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 10);
            panel7.TabIndex = 12;
            panel7.Paint += panel7_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 245);
            label7.Name = "label7";
            label7.Size = new Size(193, 27);
            label7.TabIndex = 11;
            label7.Text = "🕒 Lịch sử mua hàng";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 204);
            label6.Name = "label6";
            label6.Size = new Size(138, 27);
            label6.TabIndex = 10;
            label6.Text = "⭐ Thành viên";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 162);
            label5.Name = "label5";
            label5.Size = new Size(200, 27);
            label5.TabIndex = 9;
            label5.Text = "👤 Thông tin cá nhân";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 288);
            label4.Name = "label4";
            label4.Size = new Size(135, 27);
            label4.TabIndex = 8;
            label4.Text = "↪ Đăng xuất";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(20, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(20, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(17, 127);
            label3.Name = "label3";
            label3.Size = new Size(20, 28);
            label3.TabIndex = 4;
            label3.Text = "..";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(20, 84);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 3;
            label2.Text = "Tích điểm";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 9F);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(68, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(152, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Thay đổi ảnh đại diện";
            linkLabel1.VisitedLinkColor = Color.Black;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(68, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.login;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmLichSuVe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmLichSuVe";
            Text = "frmLichSuVe";
            Load += frmLichSuVe_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label8;
        private Panel panel5;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label13;
        private Button button1;
        private Panel panel6;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button2;
        private Panel panel7;
        private Label label18;
        private Panel panel8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaVe;
        private DataGridViewTextBoxColumn SoGhe;
        private DataGridViewTextBoxColumn TenPhim;
        private DataGridViewTextBoxColumn NgayMuaVe;
        private DataGridViewTextBoxColumn ThoiGianChieu;
        private DataGridViewTextBoxColumn GiaVe;
        private DataGridViewTextBoxColumn TrangThai;
    }
}