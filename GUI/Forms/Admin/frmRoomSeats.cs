using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema.GUI.Forms.Admin
{
    public partial class frmRoomSeats : Form
    {
        private bool _hasSeatPreview;
        private bool _isArrangingSeatMap;

        public frmRoomSeats()
        {
            InitializeComponent();
        }

        // Vẽ màn hình cong
        private void pnlScreen_Paint(object sender, PaintEventArgs e)
        {
            float width = pnlScreen.ClientSize.Width;

            float drawingHeight =
                pnlScreen.ClientSize.Height - lblScreen.Height;

            if (width <= 0 || drawingHeight <= 0)
                return;

            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float screenInset = 8f * pnlScreen.DeviceDpi / 96f;

            float left = screenInset;
            float right = width - screenInset;

            float endY = drawingHeight * 0.82f;
            float controlY = drawingHeight * 0.08f;

            float scale = pnlScreen.DeviceDpi / 96f;

            using var pen = new Pen(
                Color.FromArgb(255, 190, 85),
                2.5f * scale);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawBezier(
                pen,
                new PointF(left, endY),
                new PointF(width * 0.35f, controlY),
                new PointF(width * 0.65f, controlY),
                new PointF(right, endY));
        }

        // Vẽ lại màn hình khi thay đổi kích thước
        private void pnlScreen_Resize(object sender, EventArgs e)
        {
            pnlScreen.Invalidate();
        }

        // Nút xem trước sơ đồ ghế
        private void btnPreviewSeats_Click(object sender, EventArgs e)
        {
            int rows = (int)nudSeatRows.Value;
            int seatsPerRow = (int)nudSeatsPerRow.Value;

            BuildSeatPreview(rows, seatsPerRow);
        }

        // Dựng sơ đồ ghế
        private void BuildSeatPreview(int rows, int seatsPerRow)
        {
            if (rows < 1 || rows > 26 ||
                seatsPerRow < 2 || seatsPerRow > 20)
            {
                MessageBox.Show(
                    this,
                    "Số hàng phải từ 1 đến 26.\n" +
                    "Số ghế mỗi hàng phải từ 2 đến 20.",
                    "Kiểm tra cấu hình",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            _hasSeatPreview = false;

            float scale = pnlSeatViewport.DeviceDpi / 96f;

            int cellWidth = (int)Math.Round(44 * scale);
            int cellHeight = (int)Math.Round(36 * scale);
            int aisleWidth = (int)Math.Round(28 * scale);
            int seatMargin = (int)Math.Round(3 * scale);

            int leftSeatCount = (seatsPerRow + 1) / 2;

            pnlSeatViewport.SuspendLayout();
            tlpSeats.SuspendLayout();

            try
            {
                pnlSeatViewport.AutoScrollPosition = Point.Empty;

                while (tlpSeats.Controls.Count > 0)
                {
                    Control oldSeat = tlpSeats.Controls[0];

                    tlpSeats.Controls.Remove(oldSeat);
                    oldSeat.Dispose();
                }

                tlpSeats.ColumnStyles.Clear();
                tlpSeats.RowStyles.Clear();

                tlpSeats.RowCount = rows;
                tlpSeats.ColumnCount = seatsPerRow + 1;

                for (int column = 0;
                     column < tlpSeats.ColumnCount;
                     column++)
                {
                    int width = column == leftSeatCount
                        ? aisleWidth
                        : cellWidth;

                    tlpSeats.ColumnStyles.Add(
                        new ColumnStyle(SizeType.Absolute, width));
                }

                for (int row = 0; row < rows; row++)
                {
                    tlpSeats.RowStyles.Add(
                        new RowStyle(SizeType.Absolute, cellHeight));

                    char rowLetter = (char)('A' + row);

                    for (int seatNumber = 1;
                         seatNumber <= seatsPerRow;
                         seatNumber++)
                    {
                        string seatCode = $"{rowLetter}{seatNumber:00}";

                        var seatButton = new Button
                        {
                            Text = seatCode,
                            AccessibleName = $"Ghế {seatCode}",
                            AccessibleDescription = "Xem trước bố trí, chưa lưu.",
                            UseMnemonic = false,
                            Cursor = Cursors.Default,
                            TabIndex = row * seatsPerRow + seatNumber - 1,
                            AutoSize = false,
                            Dock = DockStyle.Fill,
                            Margin = new Padding(seatMargin),
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.FromArgb(226, 232, 240),
                            ForeColor = Color.FromArgb(21, 27, 40),
                            UseVisualStyleBackColor = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            DialogResult = DialogResult.None,
                            TabStop = false
                        };

                        seatButton.FlatAppearance.BorderSize = 0;

                        seatButton.FlatAppearance.MouseOverBackColor =
                            Color.FromArgb(203, 213, 225);

                        int columnIndex = seatNumber - 1;

                        if (seatNumber > leftSeatCount)
                            columnIndex++;

                        tlpSeats.Controls.Add(
                            seatButton, columnIndex, row);
                    }
                }

                lblSeatEmpty.Visible = false;
                tlpSeats.Visible = true;

                lblSeatSummary.Text =
                    $"{rows * seatsPerRow} ghế • Xem trước, chưa lưu";
            }
            finally
            {
                tlpSeats.ResumeLayout(true);
                pnlSeatViewport.ResumeLayout(true);
            }

            _hasSeatPreview = true;

            ArrangeSeatMap();

            pnlSeatCanvas.Visible = true;
            pnlSeatCanvas.BringToFront();

            ArrangeSeatMap();
        }

        // Căn giữa sơ đồ ghế
        private void ArrangeSeatMap()
        {
            if (!_hasSeatPreview || _isArrangingSeatMap)
                return;

            _isArrangingSeatMap = true;

            try
            {
                float scale = pnlSeatViewport.DeviceDpi / 96f;

                int outerMargin = (int)Math.Round(12 * scale);
                int sidePadding = (int)Math.Round(12 * scale);
                int screenGap = (int)Math.Round(12 * scale);

                int minimumWidth = (int)Math.Round(320 * scale);

                int canvasWidth =
                    Math.Max(tlpSeats.Width, minimumWidth)
                    + sidePadding * 2;

                int canvasHeight =
                    pnlScreen.Height
                    + screenGap
                    + tlpSeats.Height
                    + sidePadding;

                Point scroll = pnlSeatViewport.AutoScrollPosition;

                pnlSeatCanvas.Location = new Point(scroll.X, scroll.Y);

                pnlSeatCanvas.Size = new Size(
                    canvasWidth, canvasHeight);

                tlpSeats.Location = new Point(
                    (canvasWidth - tlpSeats.Width) / 2,
                    pnlScreen.Height + screenGap);

                pnlSeatViewport.AutoScrollMinSize = new Size(
                    canvasWidth + outerMargin * 2,
                    canvasHeight + outerMargin * 2);

                int availableWidth = pnlSeatViewport.ClientSize.Width;

                int left = Math.Max(
                    outerMargin,
                    (availableWidth - canvasWidth) / 2);

                scroll = pnlSeatViewport.AutoScrollPosition;

                pnlSeatCanvas.Location = new Point(
                    left + scroll.X,
                    outerMargin + scroll.Y);

                pnlScreen.Invalidate();
            }
            finally
            {
                _isArrangingSeatMap = false;
            }
        }

        // Căn chỉnh lại sơ đồ khi thay đổi kích thước vùng hiển thị
        private void pnlSeatViewport_Resize(object sender, EventArgs e)
        {
            ArrangeSeatMap();
        }
    }
}
