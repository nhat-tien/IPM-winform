namespace IPM_winform.IPM.Views.DuAn
{
    partial class ProjectUpdateManagerForm
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
            label1 = new Label();
            txtProjectNameVn = new TextBox();
            groupBox1 = new GroupBox();
            txtDesc = new RichTextBox();
            label12 = new Label();
            label9 = new Label();
            cbbDoiTac = new ComboBox();
            label8 = new Label();
            cbbCoQuanPheDuyet = new ComboBox();
            label6 = new Label();
            cbbDanhMuc = new ComboBox();
            label7 = new Label();
            cbbDonViTrucThuoc = new ComboBox();
            startedDate = new DateTimePicker();
            label5 = new Label();
            txtContent = new RichTextBox();
            label4 = new Label();
            txtMucTieu = new RichTextBox();
            label3 = new Label();
            txtProjectNameEng = new TextBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label11 = new Label();
            button3 = new Button();
            txtSearch = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            btnBack = new Button();
            btnUpdate = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 9;
            label1.Text = "Tên Dự Án (Tiếng Việt)";
            // 
            // txtProjectNameVn
            // 
            txtProjectNameVn.Location = new Point(10, 49);
            txtProjectNameVn.Margin = new Padding(4, 3, 4, 3);
            txtProjectNameVn.Name = "txtProjectNameVn";
            txtProjectNameVn.Size = new Size(166, 23);
            txtProjectNameVn.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbbDoiTac);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbbCoQuanPheDuyet);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbbDanhMuc);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbbDonViTrucThuoc);
            groupBox1.Controls.Add(startedDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtContent);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMucTieu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProjectNameEng);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtProjectNameVn);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 318);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(367, 105);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(166, 66);
            txtDesc.TabIndex = 35;
            txtDesc.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(364, 87);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 34;
            label12.Text = "Mô tả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(191, 247);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 31;
            label9.Text = "Đối tác";
            // 
            // cbbDoiTac
            // 
            cbbDoiTac.FormattingEnabled = true;
            cbbDoiTac.Location = new Point(191, 265);
            cbbDoiTac.Name = "cbbDoiTac";
            cbbDoiTac.Size = new Size(166, 23);
            cbbDoiTac.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 247);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 29;
            label8.Text = "Cơ quan phê duyệt";
            // 
            // cbbCoQuanPheDuyet
            // 
            cbbCoQuanPheDuyet.FormattingEnabled = true;
            cbbCoQuanPheDuyet.Location = new Point(10, 265);
            cbbCoQuanPheDuyet.Name = "cbbCoQuanPheDuyet";
            cbbCoQuanPheDuyet.Size = new Size(166, 23);
            cbbCoQuanPheDuyet.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 187);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 27;
            label6.Text = "Danh mục";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(191, 205);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(166, 23);
            cbbDanhMuc.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 187);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 25;
            label7.Text = "Đơn vị trực thuộc";
            // 
            // cbbDonViTrucThuoc
            // 
            cbbDonViTrucThuoc.FormattingEnabled = true;
            cbbDonViTrucThuoc.Location = new Point(10, 205);
            cbbDonViTrucThuoc.Name = "cbbDonViTrucThuoc";
            cbbDonViTrucThuoc.Size = new Size(166, 23);
            cbbDonViTrucThuoc.TabIndex = 24;
            // 
            // startedDate
            // 
            startedDate.Format = DateTimePickerFormat.Custom;
            startedDate.Location = new Point(368, 49);
            startedDate.Name = "startedDate";
            startedDate.Size = new Size(166, 23);
            startedDate.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 31);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 18;
            label5.Text = "Ngày bắt đầu";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(191, 105);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(166, 66);
            txtContent.TabIndex = 16;
            txtContent.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 87);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 15;
            label4.Text = "Nội dung";
            // 
            // txtMucTieu
            // 
            txtMucTieu.Location = new Point(10, 105);
            txtMucTieu.Name = "txtMucTieu";
            txtMucTieu.Size = new Size(166, 66);
            txtMucTieu.TabIndex = 14;
            txtMucTieu.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 13;
            label3.Text = "Mục tiêu";
            // 
            // txtProjectNameEng
            // 
            txtProjectNameEng.Location = new Point(188, 49);
            txtProjectNameEng.Margin = new Padding(4, 3, 4, 3);
            txtProjectNameEng.Name = "txtProjectNameEng";
            txtProjectNameEng.Size = new Size(164, 23);
            txtProjectNameEng.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 11;
            label2.Text = "Tên Dự Án (Tiếng Anh)";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel4);
            groupBox4.Controls.Add(flowLayoutPanel3);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Location = new Point(3, 327);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(755, 252);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thành viên";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AllowDrop = true;
            flowLayoutPanel4.AutoScroll = true;
            flowLayoutPanel4.Location = new Point(338, 82);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(299, 150);
            flowLayoutPanel4.TabIndex = 12;
            flowLayoutPanel4.DragDrop += flowLayoutPanel4_DragDrop;
            flowLayoutPanel4.DragEnter += flowLayoutPanel4_DragEnter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AllowDrop = true;
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.Location = new Point(15, 82);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(299, 150);
            flowLayoutPanel3.TabIndex = 11;
            flowLayoutPanel3.DragDrop += flowLayoutPanel3_DragDrop;
            flowLayoutPanel3.DragEnter += flowLayoutPanel3_DragEnter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(338, 36);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 8;
            label11.Text = "Thành viên dự án";
            // 
            // button3
            // 
            button3.Location = new Point(160, 36);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Tìm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(141, 23);
            txtSearch.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(789, 788);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Location = new Point(3, 585);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(755, 78);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 22);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 27);
            btnBack.TabIndex = 11;
            btnBack.Text = "Trở về";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(109, 22);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ProjectUpdateManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(789, 788);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectUpdateManagerForm";
            Text = "doc";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtProjectNameVn;
        private GroupBox groupBox1;
        private TextBox txtProjectNameEng;
        private Label label2;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private RichTextBox txtMucTieu;
        private RichTextBox txtContent;
        private Label label4;
        private DateTimePicker startedDate;
        private Label label5;
        private Label label7;
        private ComboBox cbbDonViTrucThuoc;
        private Label label6;
        private ComboBox cbbDanhMuc;
        private Label label8;
        private ComboBox cbbCoQuanPheDuyet;
        private Label label9;
        private ComboBox cbbDoiTac;
        private Button button3;
        private TextBox txtSearch;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private RichTextBox txtDesc;
        private Label label12;
        private GroupBox groupBox2;
        private Button btnBack;
        private Button btnUpdate;
    }
}