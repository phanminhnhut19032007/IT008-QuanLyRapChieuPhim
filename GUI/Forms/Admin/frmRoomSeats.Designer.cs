namespace Cinema.GUI.Forms.Admin
{
    partial class frmRoomSeats
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
            components = new System.ComponentModel.Container();
            lblRoomInfo = new Label();
            pnlSeatArea = new Panel();
            pnlSeatViewport = new Panel();
            pnlSeatCanvas = new Panel();
            tlpSeats = new TableLayoutPanel();
            pnlScreen = new Panel();
            lblScreen = new Label();
            lblSeatEmpty = new Label();
            pnlSeatFooter = new Panel();
            lblSeatSummary = new Label();
            btnClose = new Button();
            flpSeatSettings = new FlowLayoutPanel();
            lblSeatRows = new Label();
            nudSeatRows = new NumericUpDown();
            lblSeatsPerRow = new Label();
            nudSeatsPerRow = new NumericUpDown();
            btnPreviewSeats = new Button();
            btnReloadSeats = new Button();
            btnSaveSeatLayout = new Button();
            tipSeats = new ToolTip(components);
            pnlSeatArea.SuspendLayout();
            pnlSeatViewport.SuspendLayout();
            pnlSeatCanvas.SuspendLayout();
            pnlScreen.SuspendLayout();
            pnlSeatFooter.SuspendLayout();
            flpSeatSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSeatRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSeatsPerRow).BeginInit();
            SuspendLayout();
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoEllipsis = true;
            lblRoomInfo.Dock = DockStyle.Top;
            lblRoomInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRoomInfo.ForeColor = Color.FromArgb(241, 245, 249);
            lblRoomInfo.Location = new Point(0, 0);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Padding = new Padding(24, 0, 24, 0);
            lblRoomInfo.Size = new Size(1374, 112);
            lblRoomInfo.TabIndex = 0;
            lblRoomInfo.Text = "Thông tin phòng";
            lblRoomInfo.TextAlign = ContentAlignment.MiddleLeft;
            lblRoomInfo.UseMnemonic = false;
            // 
            // pnlSeatArea
            // 
            pnlSeatArea.Controls.Add(pnlSeatViewport);
            pnlSeatArea.Dock = DockStyle.Fill;
            pnlSeatArea.Location = new Point(0, 192);
            pnlSeatArea.Name = "pnlSeatArea";
            pnlSeatArea.Padding = new Padding(24, 16, 24, 16);
            pnlSeatArea.Size = new Size(1374, 649);
            pnlSeatArea.TabIndex = 2;
            // 
            // pnlSeatViewport
            // 
            pnlSeatViewport.AutoScroll = true;
            pnlSeatViewport.Controls.Add(pnlSeatCanvas);
            pnlSeatViewport.Controls.Add(lblSeatEmpty);
            pnlSeatViewport.Dock = DockStyle.Fill;
            pnlSeatViewport.Location = new Point(24, 16);
            pnlSeatViewport.Name = "pnlSeatViewport";
            pnlSeatViewport.Size = new Size(1326, 617);
            pnlSeatViewport.TabIndex = 1;
            pnlSeatViewport.Resize += pnlSeatViewport_Resize;
            // 
            // pnlSeatCanvas
            // 
            pnlSeatCanvas.Controls.Add(tlpSeats);
            pnlSeatCanvas.Controls.Add(pnlScreen);
            pnlSeatCanvas.Location = new Point(0, 0);
            pnlSeatCanvas.Margin = new Padding(0);
            pnlSeatCanvas.Name = "pnlSeatCanvas";
            pnlSeatCanvas.Size = new Size(400, 200);
            pnlSeatCanvas.TabIndex = 5;
            pnlSeatCanvas.Visible = false;
            // 
            // tlpSeats
            // 
            tlpSeats.AutoSize = true;
            tlpSeats.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpSeats.ColumnCount = 2;
            tlpSeats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSeats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSeats.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlpSeats.Location = new Point(16, 24);
            tlpSeats.Margin = new Padding(0);
            tlpSeats.Name = "tlpSeats";
            tlpSeats.RowCount = 2;
            tlpSeats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSeats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSeats.Size = new Size(0, 0);
            tlpSeats.TabIndex = 4;
            tlpSeats.Visible = false;
            // 
            // pnlScreen
            // 
            pnlScreen.Controls.Add(lblScreen);
            pnlScreen.Dock = DockStyle.Top;
            pnlScreen.Location = new Point(0, 0);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(400, 160);
            pnlScreen.TabIndex = 3;
            pnlScreen.Paint += pnlScreen_Paint;
            pnlScreen.Resize += pnlScreen_Resize;
            // 
            // lblScreen
            // 
            lblScreen.BackColor = Color.Transparent;
            lblScreen.Dock = DockStyle.Bottom;
            lblScreen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblScreen.ForeColor = Color.FromArgb(255, 190, 85);
            lblScreen.Location = new Point(0, 112);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new Size(400, 48);
            lblScreen.TabIndex = 0;
            lblScreen.Text = "MÀN HÌNH";
            lblScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatEmpty
            // 
            lblSeatEmpty.Dock = DockStyle.Fill;
            lblSeatEmpty.Font = new Font("Segoe UI", 11F);
            lblSeatEmpty.ForeColor = Color.FromArgb(148, 163, 184);
            lblSeatEmpty.Location = new Point(0, 0);
            lblSeatEmpty.Name = "lblSeatEmpty";
            lblSeatEmpty.Size = new Size(1326, 617);
            lblSeatEmpty.TabIndex = 0;
            lblSeatEmpty.Text = "Nhập số hàng, số ghế mỗi hàng rồi bấm Xem trước.";
            lblSeatEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblSeatEmpty.UseMnemonic = false;
            // 
            // pnlSeatFooter
            // 
            pnlSeatFooter.BackColor = Color.FromArgb(28, 35, 50);
            pnlSeatFooter.Controls.Add(lblSeatSummary);
            pnlSeatFooter.Controls.Add(btnClose);
            pnlSeatFooter.Dock = DockStyle.Bottom;
            pnlSeatFooter.Location = new Point(0, 841);
            pnlSeatFooter.Name = "pnlSeatFooter";
            pnlSeatFooter.Padding = new Padding(24, 16, 24, 16);
            pnlSeatFooter.Size = new Size(1374, 88);
            pnlSeatFooter.TabIndex = 3;
            // 
            // lblSeatSummary
            // 
            lblSeatSummary.AutoEllipsis = true;
            lblSeatSummary.Dock = DockStyle.Fill;
            lblSeatSummary.Font = new Font("Segoe UI", 9F);
            lblSeatSummary.ForeColor = Color.FromArgb(148, 163, 184);
            lblSeatSummary.Location = new Point(24, 16);
            lblSeatSummary.Name = "lblSeatSummary";
            lblSeatSummary.Size = new Size(1146, 56);
            lblSeatSummary.TabIndex = 1;
            lblSeatSummary.Text = "Số ghế: —";
            lblSeatSummary.TextAlign = ContentAlignment.MiddleLeft;
            lblSeatSummary.UseMnemonic = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(48, 59, 78);
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(241, 245, 249);
            btnClose.Location = new Point(1170, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 56);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // flpSeatSettings
            // 
            flpSeatSettings.AutoSize = true;
            flpSeatSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpSeatSettings.Controls.Add(lblSeatRows);
            flpSeatSettings.Controls.Add(nudSeatRows);
            flpSeatSettings.Controls.Add(lblSeatsPerRow);
            flpSeatSettings.Controls.Add(nudSeatsPerRow);
            flpSeatSettings.Controls.Add(btnPreviewSeats);
            flpSeatSettings.Controls.Add(btnReloadSeats);
            flpSeatSettings.Controls.Add(btnSaveSeatLayout);
            flpSeatSettings.Dock = DockStyle.Top;
            flpSeatSettings.Location = new Point(0, 112);
            flpSeatSettings.Name = "flpSeatSettings";
            flpSeatSettings.Padding = new Padding(24, 8, 24, 8);
            flpSeatSettings.Size = new Size(1374, 80);
            flpSeatSettings.TabIndex = 1;
            // 
            // lblSeatRows
            // 
            lblSeatRows.AutoSize = true;
            lblSeatRows.Location = new Point(24, 22);
            lblSeatRows.Margin = new Padding(0, 14, 12, 0);
            lblSeatRows.Name = "lblSeatRows";
            lblSeatRows.Size = new Size(114, 37);
            lblSeatRows.TabIndex = 0;
            lblSeatRows.Text = "Số hàng";
            // 
            // nudSeatRows
            // 
            nudSeatRows.AccessibleName = "Số hàng ghế";
            nudSeatRows.BackColor = Color.FromArgb(28, 35, 50);
            nudSeatRows.ForeColor = Color.FromArgb(241, 245, 249);
            nudSeatRows.Location = new Point(150, 16);
            nudSeatRows.Margin = new Padding(0, 8, 24, 8);
            nudSeatRows.Maximum = new decimal(new int[] { 26, 0, 0, 0 });
            nudSeatRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSeatRows.Name = "nudSeatRows";
            nudSeatRows.Size = new Size(120, 43);
            nudSeatRows.TabIndex = 1;
            nudSeatRows.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lblSeatsPerRow
            // 
            lblSeatsPerRow.AutoSize = true;
            lblSeatsPerRow.Location = new Point(294, 22);
            lblSeatsPerRow.Margin = new Padding(0, 14, 12, 0);
            lblSeatsPerRow.Name = "lblSeatsPerRow";
            lblSeatsPerRow.Size = new Size(185, 37);
            lblSeatsPerRow.TabIndex = 2;
            lblSeatsPerRow.Text = "Ghế mỗi hàng";
            // 
            // nudSeatsPerRow
            // 
            nudSeatsPerRow.AccessibleName = "Số ghế mỗi hàng";
            nudSeatsPerRow.BackColor = Color.FromArgb(28, 35, 50);
            nudSeatsPerRow.ForeColor = Color.FromArgb(241, 245, 249);
            nudSeatsPerRow.Location = new Point(491, 16);
            nudSeatsPerRow.Margin = new Padding(0, 8, 24, 8);
            nudSeatsPerRow.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudSeatsPerRow.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudSeatsPerRow.Name = "nudSeatsPerRow";
            nudSeatsPerRow.Size = new Size(120, 43);
            nudSeatsPerRow.TabIndex = 3;
            nudSeatsPerRow.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // btnPreviewSeats
            // 
            btnPreviewSeats.BackColor = Color.FromArgb(255, 190, 85);
            btnPreviewSeats.Cursor = Cursors.Hand;
            btnPreviewSeats.FlatAppearance.BorderSize = 0;
            btnPreviewSeats.FlatStyle = FlatStyle.Flat;
            btnPreviewSeats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPreviewSeats.ForeColor = Color.FromArgb(21, 27, 40);
            btnPreviewSeats.Location = new Point(635, 8);
            btnPreviewSeats.Margin = new Padding(0, 0, 16, 8);
            btnPreviewSeats.Name = "btnPreviewSeats";
            btnPreviewSeats.Size = new Size(220, 56);
            btnPreviewSeats.TabIndex = 4;
            btnPreviewSeats.Text = "Xem trước";
            btnPreviewSeats.UseVisualStyleBackColor = false;
            btnPreviewSeats.Click += btnPreviewSeats_Click;
            // 
            // btnReloadSeats
            // 
            btnReloadSeats.BackColor = Color.FromArgb(48, 59, 78);
            btnReloadSeats.Cursor = Cursors.Hand;
            btnReloadSeats.FlatAppearance.BorderSize = 0;
            btnReloadSeats.FlatStyle = FlatStyle.Flat;
            btnReloadSeats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReloadSeats.ForeColor = Color.FromArgb(241, 245, 249);
            btnReloadSeats.Location = new Point(871, 8);
            btnReloadSeats.Margin = new Padding(0, 0, 16, 8);
            btnReloadSeats.Name = "btnReloadSeats";
            btnReloadSeats.Size = new Size(180, 56);
            btnReloadSeats.TabIndex = 5;
            btnReloadSeats.Text = "Tải lại";
            btnReloadSeats.UseVisualStyleBackColor = false;
            // 
            // btnSaveSeatLayout
            // 
            btnSaveSeatLayout.BackColor = Color.FromArgb(255, 190, 85);
            btnSaveSeatLayout.Cursor = Cursors.Hand;
            btnSaveSeatLayout.Enabled = false;
            btnSaveSeatLayout.FlatAppearance.BorderSize = 0;
            btnSaveSeatLayout.FlatStyle = FlatStyle.Flat;
            btnSaveSeatLayout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveSeatLayout.ForeColor = Color.FromArgb(21, 27, 40);
            btnSaveSeatLayout.Location = new Point(1067, 8);
            btnSaveSeatLayout.Margin = new Padding(0, 0, 16, 8);
            btnSaveSeatLayout.Name = "btnSaveSeatLayout";
            btnSaveSeatLayout.Size = new Size(260, 56);
            btnSaveSeatLayout.TabIndex = 6;
            btnSaveSeatLayout.Text = "Lưu sơ đồ";
            btnSaveSeatLayout.UseVisualStyleBackColor = false;
            // 
            // tipSeats
            // 
            tipSeats.AutoPopDelay = 8000;
            tipSeats.InitialDelay = 300;
            tipSeats.ReshowDelay = 100;
            tipSeats.ShowAlways = true;
            // 
            // frmRoomSeats
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(15, 20, 30);
            CancelButton = btnClose;
            ClientSize = new Size(1374, 929);
            Controls.Add(pnlSeatArea);
            Controls.Add(pnlSeatFooter);
            Controls.Add(flpSeatSettings);
            Controls.Add(lblRoomInfo);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(226, 232, 240);
            MinimizeBox = false;
            MinimumSize = new Size(1000, 760);
            Name = "frmRoomSeats";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sơ đồ ghế";
            pnlSeatArea.ResumeLayout(false);
            pnlSeatViewport.ResumeLayout(false);
            pnlSeatCanvas.ResumeLayout(false);
            pnlSeatCanvas.PerformLayout();
            pnlScreen.ResumeLayout(false);
            pnlSeatFooter.ResumeLayout(false);
            flpSeatSettings.ResumeLayout(false);
            flpSeatSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSeatRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSeatsPerRow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomInfo;
        private Panel pnlSeatArea;
        private Panel pnlSeatViewport;
        private Label lblScreen;
        private Label lblSeatEmpty;
        private Panel pnlSeatFooter;
        private Button btnClose;
        private Label lblSeatSummary;
        private Panel pnlScreen;
        private FlowLayoutPanel flpSeatSettings;
        private Label lblSeatRows;
        private Label lblSeatsPerRow;
        private NumericUpDown nudSeatRows;
        private NumericUpDown nudSeatsPerRow;
        private Button btnPreviewSeats;
        private TableLayoutPanel tlpSeats;
        private Panel pnlSeatCanvas;
        private Button btnReloadSeats;
        private Button btnSaveSeatLayout;
        private ToolTip tipSeats;
    }
}