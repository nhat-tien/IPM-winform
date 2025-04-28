namespace IPM_winform.Controls
{
    partial class UserBlock
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
            lbName = new Label();
            lbEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 10;
            elipseControl1.TargetControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Image = Properties.Resources.user_avatar_male_5;
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += OnMouseDown;
            pictureBox1.MouseMove += OnMouseMove;
            pictureBox1.MouseUp += OnMouseUp;
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
            // lbName
            // 
            lbName.AutoEllipsis = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbName.Location = new Point(47, 7);
            lbName.Name = "lbName";
            lbName.Size = new Size(220, 15);
            lbName.TabIndex = 1;
            lbName.Text = "label1";
            lbName.MouseDown += OnMouseDown;
            lbName.MouseMove += OnMouseMove;
            lbName.MouseUp += OnMouseUp;
            // 
            // lbEmail
            // 
            lbEmail.AutoEllipsis = true;
            lbEmail.Font = new Font("Segoe UI", 9F);
            lbEmail.Location = new Point(47, 22);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(220, 16);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "label1";
            lbEmail.MouseDown += OnMouseDown;
            lbEmail.MouseMove += OnMouseMove;
            lbEmail.MouseUp += OnMouseUp;
            // 
            // UserBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lbEmail);
            Controls.Add(lbName);
            Controls.Add(pictureBox1);
            Name = "UserBlock";
            Size = new Size(270, 46);
            Load += FileBlock_Load;
            MouseDown += OnMouseDown;
            MouseMove += OnMouseMove;
            MouseUp += OnMouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ElipseControl elipseControl1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbName;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private Label lbEmail;
    }
}
