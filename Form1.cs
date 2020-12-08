using System;
using System.Windows.Forms;

namespace simpleHexMap
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            cbSize.SelectedIndex = 1;
            cbWidth.SelectedIndex = 1;
            tsStatus.Text = "";
        }

        private void fMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void fMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var fileName = files[0];
            this.Text = fileName;
            Helper.LoadField(fileName);
            this.updateImage();
        }

        private void updateImage()
        {
            int divider = 1;
            if (chk16.Checked == true) divider = 2;
            int width = int.Parse(cbWidth.Text);
            int pointSize = int.Parse(cbSize.Text);

            Img.DrawHexField(width, pointSize, divider);
        }

        private void chk16_Click(object sender, EventArgs e)
        {
            updateImage();
        }

        private void cbSize_TextChanged(object sender, EventArgs e)
        {
            if (cbSize.Text != "" && cbWidth.Text != "") updateImage();
        }

        private void cbWidth_TextChanged(object sender, EventArgs e)
        {
            if (cbSize.Text != "" && cbWidth.Text != "") updateImage();
        }

        private void Img_MouseMove(object sender, MouseEventArgs e)
        {
            tsStatus.Text = Helper.GetValue(e.X, e.Y);
        }
    }
}
