namespace IPM_winform.Controls
{
    partial class ProjectBlock
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
            lbProjectName = new Label();
            elipseControl1 = new ElipseControl();
            lbDesc = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbMember = new Label();
            lbdvtt = new Label();
            lbFile = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xemToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcDựÁnToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbProjectName
            // 
            lbProjectName.AutoEllipsis = true;
            lbProjectName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbProjectName.Location = new Point(22, 26);
            lbProjectName.Name = "lbProjectName";
            lbProjectName.Size = new Size(215, 27);
            lbProjectName.TabIndex = 0;
            lbProjectName.Text = "Dự án có cái tên rất dài rất dài để thử xem ksn cknds cdskn csdkncd";
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = this;
            // 
            // lbDesc
            // 
            lbDesc.AutoEllipsis = true;
            lbDesc.BackColor = Color.White;
            lbDesc.ForeColor = Color.Gray;
            lbDesc.Location = new Point(24, 58);
            lbDesc.Name = "lbDesc";
            lbDesc.Size = new Size(213, 29);
            lbDesc.TabIndex = 1;
            lbDesc.Text = "Mô tả dự án gì đó mà nó khá là dài";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_48;
            pictureBox1.Location = new Point(25, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_file_48;
            pictureBox2.Location = new Point(83, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new Point(45, 118);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(38, 15);
            lbMember.TabIndex = 4;
            lbMember.Text = "label1";
            // 
            // lbdvtt
            // 
            lbdvtt.AutoSize = true;
            lbdvtt.BorderStyle = BorderStyle.FixedSingle;
            lbdvtt.Location = new Point(25, 88);
            lbdvtt.Name = "lbdvtt";
            lbdvtt.Size = new Size(40, 17);
            lbdvtt.TabIndex = 6;
            lbdvtt.Text = "label3";
            // 
            // lbFile
            // 
            lbFile.AutoSize = true;
            lbFile.Location = new Point(105, 119);
            lbFile.Name = "lbFile";
            lbFile.Size = new Size(38, 15);
            lbFile.TabIndex = 7;
            lbFile.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xemToolStripMenuItem, kếtThúcDựÁnToolStripMenuItem, xóaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 92);
            // 
            // xemToolStripMenuItem
            // 
            xemToolStripMenuItem.ForeColor = SystemColors.ControlText;
            xemToolStripMenuItem.Image = Properties.Resources.icons8_eye_20;
            xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            xemToolStripMenuItem.Size = new Size(180, 22);
            xemToolStripMenuItem.Text = "Xem";
            xemToolStripMenuItem.Click += xemToolStripMenuItem_Click;
            // 
            // kếtThúcDựÁnToolStripMenuItem
            // 
            kếtThúcDựÁnToolStripMenuItem.Image = Properties.Resources.icons8_check_48;
            kếtThúcDựÁnToolStripMenuItem.Name = "kếtThúcDựÁnToolStripMenuItem";
            kếtThúcDựÁnToolStripMenuItem.Size = new Size(180, 22);
            kếtThúcDựÁnToolStripMenuItem.Text = "Kết thúc dự án";
            kếtThúcDựÁnToolStripMenuItem.Click += kếtThúcDựÁnToolStripMenuItem_Click;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.ForeColor = Color.Red;
            xóaToolStripMenuItem.Image = Properties.Resources.icons8_trash_20;
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(180, 22);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // ProjectBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lbFile);
            Controls.Add(lbdvtt);
            Controls.Add(lbMember);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbDesc);
            Controls.Add(lbProjectName);
            Name = "ProjectBlock";
            Size = new Size(255, 168);
            Load += ProjectBlock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProjectName;
        private ElipseControl elipseControl1;
        private Label lbDesc;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lbMember;
        private PictureBox pictureBox2;
        private Label lbdvtt;
        private Label lbFile;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem xemToolStripMenuItem;
        private ToolStripMenuItem kếtThúcDựÁnToolStripMenuItem;
    }
}
