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
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk16 = new System.Windows.Forms.CheckBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.Img = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cbWidth);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.chk16);
            this.pnlTop.Controls.Add(this.cbSize);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1067, 39);
            this.pnlTop.TabIndex = 0;
            // 
            // cbWidth
            // 
            this.cbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWidth.FormattingEnabled = true;
            this.cbWidth.Items.AddRange(new object[] {
            "128",
            "256",
            "512"});
            this.cbWidth.Location = new System.Drawing.Point(401, 6);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(56, 24);
            this.cbWidth.TabIndex = 5;
            this.cbWidth.TextChanged += new System.EventHandler(this.cbWidth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ячеек в строке";
            // 
            // chk16
            // 
            this.chk16.AutoSize = true;
            this.chk16.Location = new System.Drawing.Point(3, 8);
            this.chk16.Name = "chk16";
            this.chk16.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.chk16.Size = new System.Drawing.Size(88, 21);
            this.chk16.TabIndex = 3;
            this.chk16.Text = "16 бит";
            this.chk16.UseVisualStyleBackColor = true;
            this.chk16.Click += new System.EventHandler(this.chk16_Click);
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSize.Location = new System.Drawing.Point(221, 6);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(47, 24);
            this.cbSize.TabIndex = 1;
            this.cbSize.TextChanged += new System.EventHandler(this.cbSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер ячейки";
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.BackColor = System.Drawing.Color.Gray;
            this.pnlImage.Controls.Add(this.Img);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 39);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(1067, 549);
            this.pnlImage.TabIndex = 1;
            // 
            // Img
            // 
            this.Img.Location = new System.Drawing.Point(0, 0);
            this.Img.Margin = new System.Windows.Forms.Padding(0);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(512, 512);
            this.Img.TabIndex = 0;
            this.Img.TabStop = false;
            this.Img.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Img_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(143, 20);
            this.tsStatus.Text = "toolStripStatusLabel";
            // 
            // fMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 614);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "fMain";
            this.Text = "Drag&Drop hex file to form";
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
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
    }
}

