namespace Cinema.GUI.Controls
{
    partial class ucAdminRooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblRoomsHeading = new Label();
            btnReloadRooms = new Button();
            btnEditRoom = new Button();
            btnAddRoom = new Button();
            lblRoomsDataState = new Label();
            dgvRooms = new DataGridView();
            colRoomCode = new DataGridViewTextBoxColumn();
            colRoomName = new DataGridViewTextBoxColumn();
            colSeatCount = new DataGridViewTextBoxColumn();
            colRoomStatus = new DataGridViewTextBoxColumn();
            flpRoomActions = new FlowLayoutPanel();
            btnRoomSeats = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            flpRoomActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblRoomsHeading
            // 
            lblRoomsHeading.Dock = DockStyle.Top;
            lblRoomsHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomsHeading.ForeColor = Color.FromArgb(241, 245, 249);
            lblRoomsHeading.Location = new Point(0, 0);
            lblRoomsHeading.Name = "lblRoomsHeading";
            lblRoomsHeading.Size = new Size(1200, 80);
            lblRoomsHeading.TabIndex = 0;
            lblRoomsHeading.Text = "Danh sách phòng chiếu";
            lblRoomsHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReloadRooms
            // 
            btnReloadRooms.BackColor = Color.FromArgb(48, 59, 78);
            btnReloadRooms.Cursor = Cursors.Hand;
            btnReloadRooms.FlatAppearance.BorderSize = 0;
            btnReloadRooms.FlatStyle = FlatStyle.Flat;
            btnReloadRooms.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReloadRooms.ForeColor = Color.FromArgb(241, 245, 249);
            btnReloadRooms.Location = new Point(828, 8);
            btnReloadRooms.Margin = new Padding(0, 0, 16, 8);
            btnReloadRooms.Name = "btnReloadRooms";
            btnReloadRooms.Size = new Size(260, 72);
            btnReloadRooms.TabIndex = 2;
            btnReloadRooms.Text = "Tải lại";
            btnReloadRooms.UseVisualStyleBackColor = false;
            btnReloadRooms.Click += btnReloadRooms_Click;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.FromArgb(48, 59, 78);
            btnEditRoom.Cursor = Cursors.Hand;
            btnEditRoom.Enabled = false;
            btnEditRoom.FlatAppearance.BorderSize = 0;
            btnEditRoom.FlatStyle = FlatStyle.Flat;
            btnEditRoom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditRoom.ForeColor = Color.FromArgb(241, 245, 249);
            btnEditRoom.Location = new Point(276, 8);
            btnEditRoom.Margin = new Padding(0, 0, 16, 8);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(260, 72);
            btnEditRoom.TabIndex = 1;
            btnEditRoom.Text = "Sửa phòng";
            btnEditRoom.UseVisualStyleBackColor = false;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(255, 190, 85);
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.Enabled = false;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddRoom.ForeColor = Color.FromArgb(21, 27, 40);
            btnAddRoom.Location = new Point(0, 8);
            btnAddRoom.Margin = new Padding(0, 0, 16, 8);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(260, 72);
            btnAddRoom.TabIndex = 0;
            btnAddRoom.Text = "Thêm phòng";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // lblRoomsDataState
            // 
            lblRoomsDataState.Dock = DockStyle.Bottom;
            lblRoomsDataState.Font = new Font("Segoe UI", 9F);
            lblRoomsDataState.ForeColor = Color.FromArgb(148, 163, 184);
            lblRoomsDataState.Location = new Point(0, 752);
            lblRoomsDataState.Name = "lblRoomsDataState";
            lblRoomsDataState.Size = new Size(1200, 48);
            lblRoomsDataState.TabIndex = 2;
            lblRoomsDataState.Text = "Chưa kết nối dữ liệu phòng chiếu.";
            lblRoomsDataState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AllowUserToResizeRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.FromArgb(28, 35, 50);
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 44, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 44, 61);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colRoomCode, colRoomName, colSeatCount, colRoomStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(28, 35, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(48, 59, 78);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(35, 41, 61);
            dgvRooms.Location = new Point(0, 176);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 82;
            dgvRooms.RowTemplate.Height = 56;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(1200, 576);
            dgvRooms.TabIndex = 3;
            dgvRooms.CellFormatting += dgvRooms_CellFormatting;
            dgvRooms.SelectionChanged += dgvRooms_SelectionChanged;
            // 
            // colRoomCode
            // 
            colRoomCode.DataPropertyName = "RoomCode";
            colRoomCode.FillWeight = 20F;
            colRoomCode.HeaderText = "Mã phòng";
            colRoomCode.MinimumWidth = 10;
            colRoomCode.Name = "colRoomCode";
            colRoomCode.ReadOnly = true;
            // 
            // colRoomName
            // 
            colRoomName.DataPropertyName = "RoomName";
            colRoomName.FillWeight = 40F;
            colRoomName.HeaderText = "Tên phòng";
            colRoomName.MinimumWidth = 10;
            colRoomName.Name = "colRoomName";
            colRoomName.ReadOnly = true;
            // 
            // colSeatCount
            // 
            colSeatCount.DataPropertyName = "SeatCount";
            dataGridViewCellStyle2.NullValue = "--";
            colSeatCount.DefaultCellStyle = dataGridViewCellStyle2;
            colSeatCount.FillWeight = 15F;
            colSeatCount.HeaderText = "Số ghế";
            colSeatCount.MinimumWidth = 10;
            colSeatCount.Name = "colSeatCount";
            colSeatCount.ReadOnly = true;
            // 
            // colRoomStatus
            // 
            colRoomStatus.DataPropertyName = "IsActive";
            colRoomStatus.FillWeight = 25F;
            colRoomStatus.HeaderText = "Trạng thái";
            colRoomStatus.MinimumWidth = 10;
            colRoomStatus.Name = "colRoomStatus";
            colRoomStatus.ReadOnly = true;
            // 
            // flpRoomActions
            // 
            flpRoomActions.AutoSize = true;
            flpRoomActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpRoomActions.Controls.Add(btnAddRoom);
            flpRoomActions.Controls.Add(btnEditRoom);
            flpRoomActions.Controls.Add(btnRoomSeats);
            flpRoomActions.Controls.Add(btnReloadRooms);
            flpRoomActions.Dock = DockStyle.Top;
            flpRoomActions.Location = new Point(0, 80);
            flpRoomActions.Margin = new Padding(0);
            flpRoomActions.Name = "flpRoomActions";
            flpRoomActions.Padding = new Padding(0, 8, 0, 8);
            flpRoomActions.Size = new Size(1200, 96);
            flpRoomActions.TabIndex = 3;
            // 
            // btnRoomSeats
            // 
            btnRoomSeats.BackColor = Color.FromArgb(48, 59, 78);
            btnRoomSeats.Cursor = Cursors.Hand;
            btnRoomSeats.Enabled = false;
            btnRoomSeats.FlatAppearance.BorderSize = 0;
            btnRoomSeats.FlatStyle = FlatStyle.Flat;
            btnRoomSeats.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRoomSeats.ForeColor = Color.FromArgb(241, 245, 249);
            btnRoomSeats.Location = new Point(552, 8);
            btnRoomSeats.Margin = new Padding(0, 0, 16, 8);
            btnRoomSeats.Name = "btnRoomSeats";
            btnRoomSeats.Size = new Size(260, 72);
            btnRoomSeats.TabIndex = 3;
            btnRoomSeats.Text = "Sơ đồ ghế";
            btnRoomSeats.UseVisualStyleBackColor = false;
            btnRoomSeats.Click += btnRoomSeats_Click;
            // 
            // ucAdminRooms
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(15, 20, 30);
            Controls.Add(dgvRooms);
            Controls.Add(lblRoomsDataState);
            Controls.Add(flpRoomActions);
            Controls.Add(lblRoomsHeading);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(226, 232, 240);
            Name = "ucAdminRooms";
            Size = new Size(1200, 800);
            Load += ucAdminRooms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            flpRoomActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomsHeading;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Label lblRoomsDataState;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colRoomCode;
        private DataGridViewTextBoxColumn colRoomName;
        private DataGridViewTextBoxColumn colSeatCount;
        private DataGridViewTextBoxColumn colRoomStatus;
        private Button btnReloadRooms;
        private FlowLayoutPanel flpRoomActions;
        private Button btnRoomSeats;
    }
}
