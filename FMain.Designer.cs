namespace simpleHexMap
{
    partial class fMain
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCellSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk16 = new System.Windows.Forms.CheckBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.Img = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnReload);
            this.pnlTop.Controls.Add(this.cbWidth);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.cbCellSize);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.chk16);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(2);
            this.pnlTop.Size = new System.Drawing.Size(656, 26);
            this.pnlTop.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReload.Location = new System.Drawing.Point(521, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 22);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload file";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbWidth
            // 
            this.cbWidth.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWidth.FormattingEnabled = true;
            this.cbWidth.ItemHeight = 20;
            this.cbWidth.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.cbWidth.Location = new System.Drawing.Point(307, 2);
            this.cbWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(87, 28);
            this.cbWidth.TabIndex = 5;
            this.cbWidth.TextChanged += new System.EventHandler(this.cbWidth_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(222, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cells in row";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCellSize
            // 
            this.cbCellSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCellSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCellSize.FormattingEnabled = true;
            this.cbCellSize.ItemHeight = 20;
            this.cbCellSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCellSize.Location = new System.Drawing.Point(137, 2);
            this.cbCellSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbCellSize.Name = "cbCellSize";
            this.cbCellSize.Size = new System.Drawing.Size(85, 28);
            this.cbCellSize.TabIndex = 1;
            this.cbCellSize.TextChanged += new System.EventHandler(this.cbSize_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(76, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cell size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chk16
            // 
            this.chk16.AutoSize = true;
            this.chk16.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk16.Location = new System.Drawing.Point(2, 2);
            this.chk16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk16.Name = "chk16";
            this.chk16.Size = new System.Drawing.Size(74, 22);
            this.chk16.TabIndex = 3;
            this.chk16.Text = "16 bit";
            this.chk16.UseVisualStyleBackColor = true;
            this.chk16.Click += new System.EventHandler(this.chk16_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.BackColor = System.Drawing.Color.Gray;
            this.pnlImage.Controls.Add(this.Img);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 26);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(656, 710);
            this.pnlImage.TabIndex = 1;
            // 
            // Img
            // 
            this.Img.Location = new System.Drawing.Point(0, 0);
            this.Img.Margin = new System.Windows.Forms.Padding(0);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(576, 640);
            this.Img.TabIndex = 0;
            this.Img.TabStop = false;
            this.Img.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Img_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusSize,
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 736);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(656, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusSize
            // 
            this.tsStatusSize.Name = "tsStatusSize";
            this.tsStatusSize.Size = new System.Drawing.Size(83, 25);
            this.tsStatusSize.Text = "0 Bytes | ";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(169, 25);
            this.tsStatus.Text = "toolStripStatusLabel";
            // 
            // fMain
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(656, 768);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(560, 298);
            this.Name = "fMain";
            this.Text = "Drag&Drop .hex|.bin file to form";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.fMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.fMain_DragEnter);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.CheckBox chk16;
        private System.Windows.Forms.ComboBox cbCellSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusSize;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.Button btnReload;
    }
}

