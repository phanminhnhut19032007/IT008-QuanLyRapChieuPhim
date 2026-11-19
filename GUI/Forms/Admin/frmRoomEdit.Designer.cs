namespace Cinema.GUI.Forms.Admin
{
    partial class frmRoomEdit
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
            tlpRoomFields = new TableLayoutPanel();
            lblRoomCode = new Label();
            lblRoomName = new Label();
            lblRoomStatus = new Label();
            txtRoomCode = new TextBox();
            txtRoomName = new TextBox();
            chkIsActive = new CheckBox();
            flpRoomActions = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tlpRoomFields.SuspendLayout();
            flpRoomActions.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoomFields
            // 
            tlpRoomFields.ColumnCount = 2;
            tlpRoomFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tlpRoomFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoomFields.Controls.Add(lblRoomCode, 0, 0);
            tlpRoomFields.Controls.Add(lblRoomName, 0, 1);
            tlpRoomFields.Controls.Add(lblRoomStatus, 0, 2);
            tlpRoomFields.Controls.Add(txtRoomCode, 1, 0);
            tlpRoomFields.Controls.Add(txtRoomName, 1, 1);
            tlpRoomFields.Controls.Add(chkIsActive, 1, 2);
            tlpRoomFields.Dock = DockStyle.Fill;
            tlpRoomFields.Location = new Point(0, 0);
            tlpRoomFields.Name = "tlpRoomFields";
            tlpRoomFields.Padding = new Padding(24);
            tlpRoomFields.RowCount = 3;
            tlpRoomFields.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpRoomFields.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpRoomFields.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpRoomFields.Size = new Size(974, 269);
            tlpRoomFields.TabIndex = 0;
            // 
            // lblRoomCode
            // 
            lblRoomCode.Dock = DockStyle.Fill;
            lblRoomCode.Font = new Font("Segoe UI", 11F);
            lblRoomCode.Location = new Point(27, 24);
            lblRoomCode.Name = "lblRoomCode";
            lblRoomCode.Size = new Size(234, 73);
            lblRoomCode.TabIndex = 0;
            lblRoomCode.Text = "Mã phòng";
            lblRoomCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoomName
            // 
            lblRoomName.Dock = DockStyle.Fill;
            lblRoomName.Font = new Font("Segoe UI", 11F);
            lblRoomName.Location = new Point(27, 97);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(234, 73);
            lblRoomName.TabIndex = 1;
            lblRoomName.Text = "Tên phòng";
            lblRoomName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.Dock = DockStyle.Fill;
            lblRoomStatus.Font = new Font("Segoe UI", 11F);
            lblRoomStatus.Location = new Point(27, 170);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(234, 75);
            lblRoomStatus.TabIndex = 2;
            lblRoomStatus.Text = "Trạng thái";
            lblRoomStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRoomCode
            // 
            txtRoomCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRoomCode.BackColor = Color.FromArgb(28, 35, 50);
            txtRoomCode.BorderStyle = BorderStyle.FixedSingle;
            txtRoomCode.Font = new Font("Segoe UI", 11F);
            txtRoomCode.ForeColor = Color.FromArgb(226, 232, 240);
            txtRoomCode.Location = new Point(267, 37);
            txtRoomCode.MaxLength = 20;
            txtRoomCode.Name = "txtRoomCode";
            txtRoomCode.PlaceholderText = "Ví dụ: P001";
            txtRoomCode.Size = new Size(680, 47);
            txtRoomCode.TabIndex = 0;
            // 
            // txtRoomName
            // 
            txtRoomName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRoomName.BackColor = Color.FromArgb(28, 35, 50);
            txtRoomName.BorderStyle = BorderStyle.FixedSingle;
            txtRoomName.Font = new Font("Segoe UI", 11F);
            txtRoomName.ForeColor = Color.FromArgb(226, 232, 240);
            txtRoomName.Location = new Point(267, 110);
            txtRoomName.MaxLength = 100;
            txtRoomName.Name = "txtRoomName";
            txtRoomName.PlaceholderText = "Ví dụ: Phòng 01";
            txtRoomName.Size = new Size(680, 47);
            txtRoomName.TabIndex = 1;
            // 
            // chkIsActive
            // 
            chkIsActive.Anchor = AnchorStyles.Left;
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 11F);
            chkIsActive.Location = new Point(267, 185);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(298, 45);
            chkIsActive.TabIndex = 2;
            chkIsActive.Text = "Cho phép sử dụng";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // flpRoomActions
            // 
            flpRoomActions.BackColor = Color.FromArgb(28, 35, 50);
            flpRoomActions.Controls.Add(btnCancel);
            flpRoomActions.Controls.Add(btnSave);
            flpRoomActions.Dock = DockStyle.Bottom;
            flpRoomActions.FlowDirection = FlowDirection.RightToLeft;
            flpRoomActions.Location = new Point(0, 269);
            flpRoomActions.Name = "flpRoomActions";
            flpRoomActions.Padding = new Padding(24, 16, 24, 16);
            flpRoomActions.Size = new Size(974, 140);
            flpRoomActions.TabIndex = 1;
            flpRoomActions.WrapContents = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(48, 59, 78);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.ForeColor = Color.FromArgb(241, 245, 249);
            btnCancel.Location = new Point(746, 16);
            btnCancel.Margin = new Padding(16, 0, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 64);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 190, 85);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.ForeColor = Color.FromArgb(21, 27, 40);
            btnSave.Location = new Point(470, 16);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(260, 64);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu phòng";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmRoomEdit
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(15, 20, 30);
            CancelButton = btnCancel;
            ClientSize = new Size(974, 409);
            Controls.Add(tlpRoomFields);
            Controls.Add(flpRoomActions);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(226, 232, 240);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRoomEdit";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm phòng";
            tlpRoomFields.ResumeLayout(false);
            tlpRoomFields.PerformLayout();
            flpRoomActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoomFields;
        private Label lblRoomCode;
        private Label lblRoomName;
        private Label lblRoomStatus;
        private TextBox txtRoomCode;
        private TextBox txtRoomName;
        private CheckBox chkIsActive;
        private FlowLayoutPanel flpRoomActions;
        private Button btnCancel;
        private Button btnSave;
    }
}