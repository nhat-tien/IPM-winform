namespace IPM_winform.Controls
{
    partial class FileBlock
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
            components = new System.ComponentModel.Container();
            elipseControl1 = new ElipseControl();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xóaToolStripMenuItem = new ToolStripMenuItem();
            lbFileName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Image = Properties.Resources.icons8_pdf_64;
            pictureBox1.Location = new Point(13, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Image = Properties.Resources.icons8_trash_20;
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(94, 22);
            xóaToolStripMenuItem.Text = "Xóa";
            // 
            // lbFileName
            // 
            lbFileName.AutoEllipsis = true;
            lbFileName.Location = new Point(46, 13);
            lbFileName.Name = "lbFileName";
            lbFileName.Size = new Size(258, 16);
            lbFileName.TabIndex = 1;
            lbFileName.Text = "label1";
            // 
            // FileBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lbFileName);
            Controls.Add(pictureBox1);
            Name = "FileBlock";
            Size = new Size(340, 41);
            Load += this.FileBlock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ElipseControl elipseControl1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbFileName;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaToolStripMenuItem;
    }
}
