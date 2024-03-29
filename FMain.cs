﻿using System;
using System.Windows.Forms;

namespace simpleHexMap
{
    public partial class fMain : Form
    {
        private static string fileName = "";
        public fMain()
        {
            InitializeComponent();

            cbCellSize.SelectedIndex = 1;
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
            fileName = files[0];
            this.Text = fileName;
            var size = Helper.LoadField(fileName);
            tsStatusSize.Text = size.ToString() + " Bytes | ";

            this.updateImage();
        }

        private void updateImage()
        {
            int divider = 1;
            if (chk16.Checked == true) divider = 2;
            int width = int.Parse(cbWidth.Text);
            int pointSize = int.Parse(cbCellSize.Text);

            Img.DrawHexField(width, pointSize, divider);
        }

        private void chk16_Click(object sender, EventArgs e)
        {
            updateImage();
        }

        private void cbSize_TextChanged(object sender, EventArgs e)
        {
            if (cbCellSize.Text != "" && cbWidth.Text != "") updateImage();
        }

        private void cbWidth_TextChanged(object sender, EventArgs e)
        {
            if (cbCellSize.Text != "" && cbWidth.Text != "") updateImage();
        }

        private void Img_MouseMove(object sender, MouseEventArgs e)
        {
            tsStatus.Text = Helper.GetValue(e.X, e.Y);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            var size = Helper.LoadField(fileName);
            tsStatusSize.Text = size.ToString() + " Bytes | ";

            this.updateImage();

            Cursor.Current = Cursors.Default;
        }
    }
}
