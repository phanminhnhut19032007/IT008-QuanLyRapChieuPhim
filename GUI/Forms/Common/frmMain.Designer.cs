namespace Cinema.GUI.Forms.Common
{
    partial class frmMain
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
            pnlSidebar = new Panel();
            pnlNavigation = new Panel();
            btnReports = new Button();
            btnTickets = new Button();
            btnShowtimes = new Button();
            btnRooms = new Button();
            btnMovies = new Button();
            btnDashboard = new Button();
            lblBrand = new Label();
            pnlHeader = new Panel();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlNavigation.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pnlNavigation);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(360, 727);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            pnlNavigation.AutoScroll = true;
            pnlNavigation.Controls.Add(btnReports);
            pnlNavigation.Controls.Add(btnTickets);
            pnlNavigation.Controls.Add(btnShowtimes);
            pnlNavigation.Controls.Add(btnRooms);
            pnlNavigation.Controls.Add(btnMovies);
            pnlNavigation.Controls.Add(btnDashboard);
            pnlNavigation.Dock = DockStyle.Fill;
            pnlNavigation.Location = new Point(0, 96);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(360, 631);
            pnlNavigation.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 59, 78);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 44, 61);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F);
            btnReports.ForeColor = Color.FromArgb(226, 232, 240);
            btnReports.Location = new Point(0, 320);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(24, 0, 0, 0);
            btnReports.Size = new Size(360, 64);
            btnReports.TabIndex = 5;
            btnReports.Text = "Thống kê";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnTickets
            // 
            btnTickets.Cursor = Cursors.Hand;
            btnTickets.Dock = DockStyle.Top;
            btnTickets.FlatAppearance.BorderSize = 0;
            btnTickets.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 59, 78);
            btnTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 44, 61);
            btnTickets.FlatStyle = FlatStyle.Flat;
            btnTickets.Font = new Font("Segoe UI", 11F);
            btnTickets.ForeColor = Color.FromArgb(226, 232, 240);
            btnTickets.Location = new Point(0, 256);
            btnTickets.Name = "btnTickets";
            btnTickets.Padding = new Padding(24, 0, 0, 0);
            btnTickets.Size = new Size(360, 64);
            btnTickets.TabIndex = 4;
            btnTickets.Text = "Quản lý đặt vé";
            btnTickets.TextAlign = ContentAlignment.MiddleLeft;
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnShowtimes
            // 
            btnShowtimes.Cursor = Cursors.Hand;
            btnShowtimes.Dock = DockStyle.Top;
            btnShowtimes.FlatAppearance.BorderSize = 0;
            btnShowtimes.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 59, 78);
            btnShowtimes.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 44, 61);
            btnShowtimes.FlatStyle = FlatStyle.Flat;
            btnShowtimes.Font = new Font("Segoe UI", 11F);
            btnShowtimes.ForeColor = Color.FromArgb(226, 232, 240);
            btnShowtimes.Location = new Point(0, 192);
            btnShowtimes.Name = "btnShowtimes";
            btnShowtimes.Padding = new Padding(24, 0, 0, 0);
            btnShowtimes.Size = new Size(360, 64);
            btnShowtimes.TabIndex = 3;
            btnShowtimes.Text = "Suất chiếu";
            btnShowtimes.TextAlign = ContentAlignment.MiddleLeft;
            btnShowtimes.UseVisualStyleBackColor = false;
            btnShowtimes.Click += btnShowtimes_Click;
            // 
            // btnRooms
            // 
            btnRooms.Cursor = Cursors.Hand;
            btnRooms.Dock = DockStyle.Top;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 59, 78);
            btnRooms.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 44, 61);
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 11F);
            btnRooms.ForeColor = Color.FromArgb(226, 232, 240);
            btnRooms.Location = new Point(0, 128);
            btnRooms.Name = "btnRooms";
            btnRooms.Padding = new Padding(24, 0, 0, 0);
            btnRooms.Size = new Size(360, 64);
            btnRooms.TabIndex = 2;
            btnRooms.Text = "Phòng chiếu";
            btnRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnMovies
            // 
            btnMovies.Cursor = Cursors.Hand;
            btnMovies.Dock = DockStyle.Top;
            btnMovies.FlatAppearance.BorderSize = 0;
            btnMovies.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 59, 78);
            btnMovies.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 44, 61);
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Segoe UI", 11F);
            btnMovies.ForeColor = Color.FromArgb(226, 232, 240);
            btnMovies.Location = new Point(0, 64);
            btnMovies.Name = "btnMovies";
            btnMovies.Padding = new Padding(24, 0, 0, 0);
            btnMovies.Size = new Size(360, 64);
            btnMovies.TabIndex = 1;
            btnMovies.Text = "Quản lý phim";
            btnMovies.TextAlign = ContentAlignment.MiddleLeft;
            btnMovies.UseVisualStyleBackColor = false;
            btnMovies.Click += btnMovies_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(21, 27, 40);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 59, 78);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 44, 61);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F);
            btnDashboard.ForeColor = Color.FromArgb(226, 232, 240);
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(24, 0, 0, 0);
            btnDashboard.Size = new Size(360, 64);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Tổng quan";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblBrand
            // 
            lblBrand.Dock = DockStyle.Top;
            lblBrand.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(255, 190, 85);
            lblBrand.Location = new Point(0, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Padding = new Padding(24, 0, 0, 0);
            lblBrand.Size = new Size(360, 96);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "CineFlow";
            lblBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(28, 35, 50);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(360, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 0, 24, 0);
            pnlHeader.Size = new Size(879, 96);
            pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Dock = DockStyle.Fill;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(241, 245, 249);
            lblPageTitle.Location = new Point(24, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(831, 96);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Tổng quan";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(15, 20, 30);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(360, 96);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(24);
            pnlContent.Size = new Size(879, 631);
            pnlContent.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(21, 27, 40);
            ClientSize = new Size(1239, 727);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1265, 798);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineFlow - CinemaManagement";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlNavigation.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblBrand;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Label lblPageTitle;
        private Panel pnlNavigation;
        private Button btnDashboard;
        private Button btnShowtimes;
        private Button btnRooms;
        private Button btnMovies;
        private Button btnReports;
        private Button btnTickets;
    }
}