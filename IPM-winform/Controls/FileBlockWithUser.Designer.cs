namespace IPM_winform.Controls
{
    partial class FileBlockWithUser
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
            tảiXuốngToolStripMenuItem = new ToolStripMenuItem();
            lbFileName = new Label();
            lbUserName = new Label();
            lbStatus = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            xácNhậnToolStripMenuItem = new ToolStripMenuItem();
            từChốiToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            pictureBox1.Size = new Size(39, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaToolStripMenuItem, tảiXuốngToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 48);
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Image = Properties.Resources.icons8_trash_20;
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(126, 22);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // tảiXuốngToolStripMenuItem
            // 
            tảiXuốngToolStripMenuItem.Image = Properties.Resources.icons8_download_48;
            tảiXuốngToolStripMenuItem.Name = "tảiXuốngToolStripMenuItem";
            tảiXuốngToolStripMenuItem.Size = new Size(126, 22);
            tảiXuốngToolStripMenuItem.Text = "Tải xuống";
            tảiXuốngToolStripMenuItem.Click += tảiXuốngToolStripMenuItem_Click;
            // 
            // lbFileName
            // 
            lbFileName.AutoEllipsis = true;
            lbFileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbFileName.Location = new Point(58, 7);
            lbFileName.Name = "lbFileName";
            lbFileName.Size = new Size(258, 16);
            lbFileName.TabIndex = 1;
            lbFileName.Text = "label1";
            // 
            // lbUserName
            // 
            lbUserName.AutoEllipsis = true;
            lbUserName.Location = new Point(58, 25);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(258, 16);
            lbUserName.TabIndex = 2;
            lbUserName.Text = "label1";
            // 
            // lbStatus
            // 
            lbStatus.ContextMenuStrip = contextMenuStrip2;
            lbStatus.Location = new Point(328, 18);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(100, 18);
            lbStatus.TabIndex = 3;
            lbStatus.Text = "Chờ xác nhận";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { xácNhậnToolStripMenuItem, từChốiToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(181, 70);
            // 
            // xácNhậnToolStripMenuItem
            // 
            xácNhậnToolStripMenuItem.Image = Properties.Resources.icons8_check_48;
            xácNhậnToolStripMenuItem.Name = "xácNhậnToolStripMenuItem";
            xácNhậnToolStripMenuItem.Size = new Size(180, 22);
            xácNhậnToolStripMenuItem.Text = "Xác nhận";
            xácNhậnToolStripMenuItem.Click += xácNhậnToolStripMenuItem_Click;
            // 
            // từChốiToolStripMenuItem
            // 
            từChốiToolStripMenuItem.Image = Properties.Resources.icons8_x_64;
            từChốiToolStripMenuItem.Name = "từChốiToolStripMenuItem";
            từChốiToolStripMenuItem.Size = new Size(180, 22);
            từChốiToolStripMenuItem.Text = "Từ chối";
            từChốiToolStripMenuItem.Click += từChốiToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_historical_48;
            pictureBox2.Location = new Point(308, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FileBlockWithUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox2);
            Controls.Add(lbStatus);
            Controls.Add(lbUserName);
            Controls.Add(lbFileName);
            Controls.Add(pictureBox1);
            Name = "FileBlockWithUser";
            Size = new Size(414, 50);
            Load += FileBlock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ElipseControl elipseControl1;
        private Label lbStatus;
        private PictureBox pictureBox1;
        private Label lbFileName;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private Label lbUserName;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem xácNhậnToolStripMenuItem;
        private ToolStripMenuItem tảiXuốngToolStripMenuItem;
        private ToolStripMenuItem từChốiToolStripMenuItem;
    }
}
