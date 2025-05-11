namespace IPM_winform.IPM.Views.DuAn
{
    partial class ProjectSearchForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            chEndDate = new CheckBox();
            dateKtDen = new DateTimePicker();
            label11 = new Label();
            dateKtTu = new DateTimePicker();
            label12 = new Label();
            label10 = new Label();
            cbbStatus = new ComboBox();
            chStartDate = new CheckBox();
            chEngName = new CheckBox();
            chVietName = new CheckBox();
            chDt = new CheckBox();
            chDm = new CheckBox();
            chCqpd = new CheckBox();
            chDvtt = new CheckBox();
            btnCancel = new Button();
            button1 = new Button();
            dateBdDen = new DateTimePicker();
            label4 = new Label();
            dateBdTu = new DateTimePicker();
            label5 = new Label();
            label9 = new Label();
            cbbDoiTac = new ComboBox();
            label8 = new Label();
            cbbCoQuanPheDuyet = new ComboBox();
            label6 = new Label();
            cbbDanhMuc = new ComboBox();
            label7 = new Label();
            cbbDonViTrucThuoc = new ComboBox();
            label3 = new Label();
            txtEng = new TextBox();
            label2 = new Label();
            txtVn = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(737, 668);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.2694626F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.832335F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8982048F));
            tableLayoutPanel1.Size = new Size(737, 668);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnEdit);
            flowLayoutPanel2.Controls.Add(btnDelete);
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 272);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel2.Size = new Size(731, 53);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(247, 155, 56);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.Location = new Point(692, 3);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(35, 35);
            btnEdit.TabIndex = 14;
            toolTip3.SetToolTip(btnEdit, "Chỉnh sửa");
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(247, 56, 56);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.Location = new Point(649, 3);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(35, 35);
            btnDelete.TabIndex = 13;
            toolTip2.SetToolTip(btnDelete, "Xóa");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(56, 140, 247);
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.Location = new Point(605, 3);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(36, 35);
            btnAdd.TabIndex = 12;
            toolTip1.SetToolTip(btnAdd, "Thêm");
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 331);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(731, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(chEndDate);
            panel1.Controls.Add(dateKtDen);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dateKtTu);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbbStatus);
            panel1.Controls.Add(chStartDate);
            panel1.Controls.Add(chEngName);
            panel1.Controls.Add(chVietName);
            panel1.Controls.Add(chDt);
            panel1.Controls.Add(chDm);
            panel1.Controls.Add(chCqpd);
            panel1.Controls.Add(chDvtt);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateBdDen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateBdTu);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cbbDoiTac);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbbCoQuanPheDuyet);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbbDanhMuc);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbbDonViTrucThuoc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEng);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtVn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 263);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // chEndDate
            // 
            chEndDate.AutoSize = true;
            chEndDate.Location = new Point(42, 203);
            chEndDate.Name = "chEndDate";
            chEndDate.Size = new Size(15, 14);
            chEndDate.TabIndex = 86;
            chEndDate.UseVisualStyleBackColor = true;
            // 
            // dateKtDen
            // 
            dateKtDen.Format = DateTimePickerFormat.Custom;
            dateKtDen.Location = new Point(265, 198);
            dateKtDen.Name = "dateKtDen";
            dateKtDen.Size = new Size(166, 23);
            dateKtDen.TabIndex = 85;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(262, 180);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 84;
            label11.Text = "Đến";
            // 
            // dateKtTu
            // 
            dateKtTu.Format = DateTimePickerFormat.Custom;
            dateKtTu.Location = new Point(66, 198);
            dateKtTu.Name = "dateKtTu";
            dateKtTu.Size = new Size(166, 23);
            dateKtTu.TabIndex = 83;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(63, 180);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(95, 15);
            label12.TabIndex = 82;
            label12.Text = "Ngày kết thúc từ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(65, 1);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 81;
            label10.Text = "Trạng thái";
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "Đang tiến hành", "Đã kết thúc", "Tất cả" });
            cbbStatus.Location = new Point(65, 19);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(164, 23);
            cbbStatus.TabIndex = 80;
            // 
            // chStartDate
            // 
            chStartDate.AutoSize = true;
            chStartDate.Location = new Point(42, 159);
            chStartDate.Name = "chStartDate";
            chStartDate.Size = new Size(15, 14);
            chStartDate.TabIndex = 79;
            chStartDate.UseVisualStyleBackColor = true;
            // 
            // chEngName
            // 
            chEngName.AutoSize = true;
            chEngName.Location = new Point(243, 72);
            chEngName.Name = "chEngName";
            chEngName.Size = new Size(15, 14);
            chEngName.TabIndex = 78;
            chEngName.UseVisualStyleBackColor = true;
            // 
            // chVietName
            // 
            chVietName.AutoSize = true;
            chVietName.Location = new Point(44, 72);
            chVietName.Name = "chVietName";
            chVietName.Size = new Size(15, 14);
            chVietName.TabIndex = 77;
            chVietName.UseVisualStyleBackColor = true;
            // 
            // chDt
            // 
            chDt.AutoSize = true;
            chDt.Location = new Point(445, 116);
            chDt.Name = "chDt";
            chDt.Size = new Size(15, 14);
            chDt.TabIndex = 76;
            chDt.UseVisualStyleBackColor = true;
            // 
            // chDm
            // 
            chDm.AutoSize = true;
            chDm.Location = new Point(243, 116);
            chDm.Name = "chDm";
            chDm.Size = new Size(15, 14);
            chDm.TabIndex = 75;
            chDm.UseVisualStyleBackColor = true;
            // 
            // chCqpd
            // 
            chCqpd.AutoSize = true;
            chCqpd.Location = new Point(44, 116);
            chCqpd.Name = "chCqpd";
            chCqpd.Size = new Size(15, 14);
            chCqpd.TabIndex = 74;
            chCqpd.UseVisualStyleBackColor = true;
            // 
            // chDvtt
            // 
            chDvtt.AutoSize = true;
            chDvtt.Location = new Point(445, 72);
            chDvtt.Name = "chDvtt";
            chDvtt.Size = new Size(15, 14);
            chDvtt.TabIndex = 73;
            chDvtt.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(577, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 23);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(464, 194);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 45;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateBdDen
            // 
            dateBdDen.Format = DateTimePickerFormat.Custom;
            dateBdDen.Location = new Point(265, 154);
            dateBdDen.Name = "dateBdDen";
            dateBdDen.Size = new Size(166, 23);
            dateBdDen.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 136);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 43;
            label4.Text = "Đến";
            label4.Click += label4_Click;
            // 
            // dateBdTu
            // 
            dateBdTu.Format = DateTimePickerFormat.Custom;
            dateBdTu.Location = new Point(66, 154);
            dateBdTu.Name = "dateBdTu";
            dateBdTu.Size = new Size(166, 23);
            dateBdTu.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 136);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 41;
            label5.Text = "Ngày bắt đầu từ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(466, 94);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 40;
            label9.Text = "Đối tác";
            // 
            // cbbDoiTac
            // 
            cbbDoiTac.FormattingEnabled = true;
            cbbDoiTac.Location = new Point(466, 112);
            cbbDoiTac.Name = "cbbDoiTac";
            cbbDoiTac.Size = new Size(166, 23);
            cbbDoiTac.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 94);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 38;
            label8.Text = "Cơ quan phê duyệt";
            // 
            // cbbCoQuanPheDuyet
            // 
            cbbCoQuanPheDuyet.FormattingEnabled = true;
            cbbCoQuanPheDuyet.Location = new Point(65, 112);
            cbbCoQuanPheDuyet.Name = "cbbCoQuanPheDuyet";
            cbbCoQuanPheDuyet.Size = new Size(166, 23);
            cbbCoQuanPheDuyet.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 94);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 36;
            label6.Text = "Danh mục";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(264, 112);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(166, 23);
            cbbDanhMuc.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 34;
            label7.Text = "Đơn vị trực thuộc";
            // 
            // cbbDonViTrucThuoc
            // 
            cbbDonViTrucThuoc.FormattingEnabled = true;
            cbbDonViTrucThuoc.Location = new Point(466, 68);
            cbbDonViTrucThuoc.Name = "cbbDonViTrucThuoc";
            cbbDonViTrucThuoc.Size = new Size(166, 23);
            cbbDonViTrucThuoc.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, -94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 32;
            label3.Text = "Tên Dự Án (Tiếng Việt)";
            // 
            // txtEng
            // 
            txtEng.Location = new Point(264, 68);
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(166, 23);
            txtEng.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 50);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Tên Tiếng Anh";
            // 
            // txtVn
            // 
            txtVn.Location = new Point(65, 68);
            txtVn.Name = "txtVn";
            txtVn.Size = new Size(166, 23);
            txtVn.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 50);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên Tiếng Việt";
            // 
            // ProjectSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(737, 668);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectSearchForm";
            Text = "FormIndex";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private Panel panel1;
        private TextBox txtVn;
        private Label label1;
        private TextBox txtEng;
        private Label label2;
        private Label label9;
        private ComboBox cbbDoiTac;
        private Label label8;
        private ComboBox cbbCoQuanPheDuyet;
        private Label label6;
        private ComboBox cbbDanhMuc;
        private Label label7;
        private ComboBox cbbDonViTrucThuoc;
        private Label label3;
        private DateTimePicker dateBdDen;
        private Label label4;
        private DateTimePicker dateBdTu;
        private Label label5;
        private Button button1;
        private Button btnCancel;
        private CheckBox chDt;
        private CheckBox chDm;
        private CheckBox chCqpd;
        private CheckBox chDvtt;
        private CheckBox chStartDate;
        private CheckBox chEngName;
        private CheckBox chVietName;
        private CheckBox chEndDate;
        private DateTimePicker dateKtDen;
        private Label label11;
        private DateTimePicker dateKtTu;
        private Label label12;
        private Label label10;
        private ComboBox cbbStatus;
    }
}