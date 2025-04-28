namespace IPM_winform.IPM.Views
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            header = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            btnMenu = new PictureBox();
            menu = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            home = new Button();
            myproject = new Button();
            admin = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            rightPanel = new Panel();
            mainPanel = new Panel();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.SteelBlue;
            header.Controls.Add(label2);
            header.Controls.Add(pictureBox1);
            header.Controls.Add(btnMenu);
            header.Dock = DockStyle.Top;
            header.ForeColor = SystemColors.ControlDarkDark;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(4, 3, 4, 3);
            header.Name = "header";
            header.Size = new Size(695, 46);
            header.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(515, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 3;
            label2.Text = "Welcome...";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(642, 7);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(130, 70);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(129, 22);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(129, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(129, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.Location = new Point(8, 10);
            btnMenu.Margin = new Padding(12, 12, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(37, 29);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(15, 16, 46);
            menu.Controls.Add(panel1);
            menu.Controls.Add(home);
            menu.Controls.Add(myproject);
            menu.Controls.Add(admin);
            menu.Dock = DockStyle.Left;
            menu.FlowDirection = FlowDirection.TopDown;
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(4, 3, 4, 3);
            menu.Name = "menu";
            menu.Size = new Size(209, 554);
            menu.TabIndex = 1;
            menu.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(56, 140, 247);
            label1.Location = new Point(64, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "IPM";
            // 
            // home
            // 
            home.BackColor = Color.Transparent;
            home.Cursor = Cursors.Hand;
            home.FlatAppearance.BorderSize = 0;
            home.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 140, 247);
            home.FlatStyle = FlatStyle.Flat;
            home.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            home.ForeColor = Color.White;
            home.Image = Properties.Resources.home;
            home.ImageAlign = ContentAlignment.MiddleLeft;
            home.Location = new Point(0, 58);
            home.Margin = new Padding(0, 6, 0, 6);
            home.Name = "home";
            home.Padding = new Padding(12, 2, 12, 2);
            home.Size = new Size(209, 43);
            home.TabIndex = 4;
            home.Text = "  HOME";
            home.TextAlign = ContentAlignment.MiddleRight;
            home.TextImageRelation = TextImageRelation.ImageBeforeText;
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // myproject
            // 
            myproject.BackColor = Color.Transparent;
            myproject.Cursor = Cursors.Hand;
            myproject.FlatAppearance.BorderSize = 0;
            myproject.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 140, 247);
            myproject.FlatStyle = FlatStyle.Flat;
            myproject.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myproject.ForeColor = Color.White;
            myproject.Image = (Image)resources.GetObject("myproject.Image");
            myproject.ImageAlign = ContentAlignment.MiddleLeft;
            myproject.Location = new Point(0, 113);
            myproject.Margin = new Padding(0, 6, 0, 6);
            myproject.Name = "myproject";
            myproject.Padding = new Padding(12, 2, 12, 2);
            myproject.Size = new Size(209, 43);
            myproject.TabIndex = 5;
            myproject.Text = "  DỰ ÁN CỦA TÔI";
            myproject.TextAlign = ContentAlignment.MiddleLeft;
            myproject.TextImageRelation = TextImageRelation.ImageBeforeText;
            myproject.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            admin.BackColor = Color.Transparent;
            admin.Cursor = Cursors.Hand;
            admin.FlatAppearance.BorderSize = 0;
            admin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 140, 247);
            admin.FlatStyle = FlatStyle.Flat;
            admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin.ForeColor = Color.White;
            admin.Image = (Image)resources.GetObject("admin.Image");
            admin.ImageAlign = ContentAlignment.MiddleLeft;
            admin.Location = new Point(0, 168);
            admin.Margin = new Padding(0, 6, 0, 6);
            admin.Name = "admin";
            admin.Padding = new Padding(12, 2, 12, 2);
            admin.Size = new Size(209, 43);
            admin.TabIndex = 0;
            admin.Text = "  ADMIN";
            admin.TextAlign = ContentAlignment.MiddleLeft;
            admin.TextImageRelation = TextImageRelation.ImageBeforeText;
            admin.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(mainPanel);
            rightPanel.Controls.Add(header);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(209, 0);
            rightPanel.Margin = new Padding(4, 3, 4, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(695, 554);
            rightPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 46);
            mainPanel.Margin = new Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(695, 508);
            mainPanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(904, 554);
            Controls.Add(rightPanel);
            Controls.Add(menu);
            ForeColor = SystemColors.ControlText;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            Text = "IPM";
            Load += Dashboard_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            menu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private Button myproject;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
    }
}

