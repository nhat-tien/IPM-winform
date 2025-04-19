namespace IPM_winform.IPM.Views.Container
{
    partial class AdminContainer
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
            menuStrip1 = new MenuStrip();
            thongtinchung = new ToolStripMenuItem();
            chucvu = new ToolStripMenuItem();
            coquanpheduyet = new ToolStripMenuItem();
            danhmuc = new ToolStripMenuItem();
            doitac = new ToolStripMenuItem();
            donvitructhuoc = new ToolStripMenuItem();
            quảnLíNgườiDùngToolStripMenuItem = new ToolStripMenuItem();
            quảnLíDựÁnToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { thongtinchung, quảnLíNgườiDùngToolStripMenuItem, quảnLíDựÁnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(634, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thongtinchung
            // 
            thongtinchung.DropDownItems.AddRange(new ToolStripItem[] { chucvu, coquanpheduyet, danhmuc, doitac, donvitructhuoc });
            thongtinchung.Name = "thongtinchung";
            thongtinchung.Size = new Size(107, 20);
            thongtinchung.Text = "Thông tin chung";
            // 
            // chucvu
            // 
            chucvu.Name = "chucvu";
            chucvu.Size = new Size(180, 22);
            chucvu.Text = "Chức Vụ";
            // 
            // coquanpheduyet
            // 
            coquanpheduyet.Name = "coquanpheduyet";
            coquanpheduyet.Size = new Size(180, 22);
            coquanpheduyet.Text = "Cơ Quan Phê Duyệt";
            // 
            // danhmuc
            // 
            danhmuc.Name = "danhmuc";
            danhmuc.Size = new Size(180, 22);
            danhmuc.Text = "Danh Mục";
            // 
            // doitac
            // 
            doitac.Name = "doitac";
            doitac.Size = new Size(180, 22);
            doitac.Text = "Đối tác";
            // 
            // donvitructhuoc
            // 
            donvitructhuoc.Name = "donvitructhuoc";
            donvitructhuoc.Size = new Size(180, 22);
            donvitructhuoc.Text = "Đơn Vị Trực Thuộc ";
            // 
            // quảnLíNgườiDùngToolStripMenuItem
            // 
            quảnLíNgườiDùngToolStripMenuItem.Name = "quảnLíNgườiDùngToolStripMenuItem";
            quảnLíNgườiDùngToolStripMenuItem.Size = new Size(122, 20);
            quảnLíNgườiDùngToolStripMenuItem.Text = "Quản lí người dùng";
            quảnLíNgườiDùngToolStripMenuItem.Click += quảnLíNgườiDùngToolStripMenuItem_Click;
            // 
            // quảnLíDựÁnToolStripMenuItem
            // 
            quảnLíDựÁnToolStripMenuItem.Name = "quảnLíDựÁnToolStripMenuItem";
            quảnLíDựÁnToolStripMenuItem.Size = new Size(90, 20);
            quảnLíDựÁnToolStripMenuItem.Text = "Quản lí dự án";
            quảnLíDựÁnToolStripMenuItem.Click += quảnLíDựÁnToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 24);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(634, 364);
            mainPanel.TabIndex = 1;
            // 
            // AdminContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 388);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "AdminContainer";
            Text = "AdminContainer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem thongtinchung;
        private ToolStripMenuItem chucvu;
        private ToolStripMenuItem coquanpheduyet;
        private ToolStripMenuItem danhmuc;
        private ToolStripMenuItem doitac;
        private ToolStripMenuItem donvitructhuoc;
        private Panel mainPanel;
        private ToolStripMenuItem quảnLíNgườiDùngToolStripMenuItem;
        private ToolStripMenuItem quảnLíDựÁnToolStripMenuItem;
    }
}