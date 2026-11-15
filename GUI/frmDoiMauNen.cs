using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.GUI
{
    public sealed partial class frmDoiMauNen : Form
    {
        private readonly ColorDialog colorDialog;

        public Color SelectedColor { get; private set; }

        public frmDoiMauNen(Color currentColor)
        {
            InitializeComponent();
            SelectedColor = currentColor;
            colorDialog = new ColorDialog { Color = currentColor, FullOpen = true };
            pnlPreview.BackColor = currentColor;
            AcceptButton = btnApDung;
            CancelButton = btnHuy;
        }

        private void ChonMau_Click(object? sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                SelectedColor = colorDialog.Color;
                pnlPreview.BackColor = SelectedColor;
            }
        }

        private void ApDung_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
