namespace IPM_winform.Reports
{
    partial class DanhSachDuAnForm
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            chDt = new CheckBox();
            chDm = new CheckBox();
            chCqpd = new CheckBox();
            chDvtt = new CheckBox();
            label9 = new Label();
            cbbDoiTac = new ComboBox();
            label8 = new Label();
            cbbCoQuanPheDuyet = new ComboBox();
            label10 = new Label();
            cbbDanhMuc = new ComboBox();
            label11 = new Label();
            cbbDonViTrucThuoc = new ComboBox();
            btnCancel = new Button();
            btnFilter = new Button();
            chNgayKetThuc = new CheckBox();
            label3 = new Label();
            datektDen = new DateTimePicker();
            label6 = new Label();
            datektTu = new DateTimePicker();
            label7 = new Label();
            chNgayBatDau = new CheckBox();
            label2 = new Label();
            datebdDen = new DateTimePicker();
            label4 = new Label();
            datebdTu = new DateTimePicker();
            label5 = new Label();
            label1 = new Label();
            cbbStatus = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(3, 244);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(711, 351);
            reportViewer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(reportViewer1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.3010025F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.6989975F));
            tableLayoutPanel1.Size = new Size(717, 598);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(chDt);
            panel1.Controls.Add(chDm);
            panel1.Controls.Add(chCqpd);
            panel1.Controls.Add(chDvtt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cbbDoiTac);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbbCoQuanPheDuyet);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbbDanhMuc);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cbbDonViTrucThuoc);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(chNgayKetThuc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(datektDen);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(datektTu);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(chNgayBatDau);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(datebdDen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(datebdTu);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbStatus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 235);
            panel1.TabIndex = 1;
            // 
            // chDt
            // 
            chDt.AutoSize = true;
            chDt.Location = new Point(304, 198);
            chDt.Name = "chDt";
            chDt.Size = new Size(15, 14);
            chDt.TabIndex = 72;
            chDt.UseVisualStyleBackColor = true;
            // 
            // chDm
            // 
            chDm.AutoSize = true;
            chDm.Location = new Point(304, 155);
            chDm.Name = "chDm";
            chDm.Size = new Size(15, 14);
            chDm.TabIndex = 71;
            chDm.UseVisualStyleBackColor = true;
            // 
            // chCqpd
            // 
            chCqpd.AutoSize = true;
            chCqpd.Location = new Point(103, 198);
            chCqpd.Name = "chCqpd";
            chCqpd.Size = new Size(15, 14);
            chCqpd.TabIndex = 70;
            chCqpd.UseVisualStyleBackColor = true;
            // 
            // chDvtt
            // 
            chDvtt.AutoSize = true;
            chDvtt.Location = new Point(103, 155);
            chDvtt.Name = "chDvtt";
            chDvtt.Size = new Size(15, 14);
            chDvtt.TabIndex = 69;
            chDvtt.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(325, 176);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 68;
            label9.Text = "Đối tác";
            // 
            // cbbDoiTac
            // 
            cbbDoiTac.FormattingEnabled = true;
            cbbDoiTac.Location = new Point(325, 194);
            cbbDoiTac.Name = "cbbDoiTac";
            cbbDoiTac.Size = new Size(166, 23);
            cbbDoiTac.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 176);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 66;
            label8.Text = "Cơ quan phê duyệt";
            // 
            // cbbCoQuanPheDuyet
            // 
            cbbCoQuanPheDuyet.FormattingEnabled = true;
            cbbCoQuanPheDuyet.Location = new Point(127, 194);
            cbbCoQuanPheDuyet.Name = "cbbCoQuanPheDuyet";
            cbbCoQuanPheDuyet.Size = new Size(166, 23);
            cbbCoQuanPheDuyet.TabIndex = 65;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(325, 132);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 64;
            label10.Text = "Danh mục";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(325, 150);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(166, 23);
            cbbDanhMuc.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(127, 132);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 62;
            label11.Text = "Đơn vị trực thuộc";
            // 
            // cbbDonViTrucThuoc
            // 
            cbbDonViTrucThuoc.FormattingEnabled = true;
            cbbDonViTrucThuoc.Location = new Point(127, 150);
            cbbDonViTrucThuoc.Name = "cbbDonViTrucThuoc";
            cbbDonViTrucThuoc.Size = new Size(166, 23);
            cbbDonViTrucThuoc.TabIndex = 61;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(595, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 23);
            btnCancel.TabIndex = 60;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(506, 193);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(83, 23);
            btnFilter.TabIndex = 59;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // chNgayKetThuc
            // 
            chNgayKetThuc.AutoSize = true;
            chNgayKetThuc.Location = new Point(29, 107);
            chNgayKetThuc.Name = "chNgayKetThuc";
            chNgayKetThuc.Size = new Size(15, 14);
            chNgayKetThuc.TabIndex = 56;
            chNgayKetThuc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 106);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 55;
            label3.Text = "Ngày kết thúc";
            // 
            // datektDen
            // 
            datektDen.Format = DateTimePickerFormat.Custom;
            datektDen.Location = new Point(325, 100);
            datektDen.Name = "datektDen";
            datektDen.Size = new Size(166, 23);
            datektDen.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 53;
            label6.Text = "Đến";
            // 
            // datektTu
            // 
            datektTu.Format = DateTimePickerFormat.Custom;
            datektTu.Location = new Point(128, 100);
            datektTu.Name = "datektTu";
            datektTu.Size = new Size(165, 23);
            datektTu.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 82);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 51;
            label7.Text = "Từ";
            // 
            // chNgayBatDau
            // 
            chNgayBatDau.AutoSize = true;
            chNgayBatDau.Location = new Point(29, 63);
            chNgayBatDau.Name = "chNgayBatDau";
            chNgayBatDau.Size = new Size(15, 14);
            chNgayBatDau.TabIndex = 50;
            chNgayBatDau.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 62);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 49;
            label2.Text = "Ngày bắt đầu";
            // 
            // datebdDen
            // 
            datebdDen.Format = DateTimePickerFormat.Custom;
            datebdDen.Location = new Point(325, 56);
            datebdDen.Name = "datebdDen";
            datebdDen.Size = new Size(166, 23);
            datebdDen.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 47;
            label4.Text = "Đến";
            // 
            // datebdTu
            // 
            datebdTu.Format = DateTimePickerFormat.Custom;
            datebdTu.Location = new Point(128, 56);
            datebdTu.Name = "datebdTu";
            datebdTu.Size = new Size(165, 23);
            datebdTu.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 38);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 45;
            label5.Text = "Từ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 16);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Trạng thái";
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "Đang tiến hành", "Đã kết thúc", "Tất cả" });
            cbbStatus.Location = new Point(129, 12);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(164, 23);
            cbbStatus.TabIndex = 0;
            // 
            // DanhSachDuAnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 598);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DanhSachDuAnForm";
            Text = "DanhSachDuAnForm";
            Load += DanhSachDuAnForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox cbbStatus;
        private Label label1;
        private DateTimePicker datebdDen;
        private Label label4;
        private DateTimePicker datebdTu;
        private Label label5;
        private CheckBox chNgayBatDau;
        private Label label2;
        private CheckBox chNgayKetThuc;
        private Label label3;
        private DateTimePicker datektDen;
        private Label label6;
        private DateTimePicker datektTu;
        private Label label7;
        private Button btnCancel;
        private Button btnFilter;
        private Label label9;
        private ComboBox cbbDoiTac;
        private Label label8;
        private ComboBox cbbCoQuanPheDuyet;
        private Label label10;
        private ComboBox cbbDanhMuc;
        private Label label11;
        private ComboBox cbbDonViTrucThuoc;
        private CheckBox chDt;
        private CheckBox chDm;
        private CheckBox chCqpd;
        private CheckBox chDvtt;
    }
}