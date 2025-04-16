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
            donvitiente = new ToolStripMenuItem();
            donvitructhuoc = new ToolStripMenuItem();
            loaivientro = new ToolStripMenuItem();
            nhataitro = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { thongtinchung });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(634, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thongtinchung
            // 
            thongtinchung.DropDownItems.AddRange(new ToolStripItem[] { chucvu, coquanpheduyet, danhmuc, doitac, donvitiente, donvitructhuoc, loaivientro, nhataitro });
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
            // donvitiente
            // 
            donvitiente.Name = "donvitiente";
            donvitiente.Size = new Size(180, 22);
            donvitiente.Text = "Đơn Vị Tiền Tệ";
            // 
            // donvitructhuoc
            // 
            donvitructhuoc.Name = "donvitructhuoc";
            donvitructhuoc.Size = new Size(180, 22);
            donvitructhuoc.Text = "Đơn Vị Trực Thuộc ";
            // 
            // loaivientro
            // 
            loaivientro.Name = "loaivientro";
            loaivientro.Size = new Size(180, 22);
            loaivientro.Text = "Loại Viện Trợ";
            // 
            // nhataitro
            // 
            nhataitro.Name = "nhataitro";
            nhataitro.Size = new Size(180, 22);
            nhataitro.Text = "Nhà Tài Trợ";
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
        private ToolStripMenuItem donvitiente;
        private ToolStripMenuItem donvitructhuoc;
        private ToolStripMenuItem loaivientro;
        private ToolStripMenuItem nhataitro;
        private Panel mainPanel;
    }
}