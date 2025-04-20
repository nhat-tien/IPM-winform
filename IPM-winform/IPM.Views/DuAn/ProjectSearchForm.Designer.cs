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
            button1 = new Button();
            dateDen = new DateTimePicker();
            label4 = new Label();
            dateTu = new DateTimePicker();
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
            checkedListBox1 = new CheckedListBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            btnCancel = new Button();
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
            flowLayoutPanel1.Size = new Size(669, 548);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(669, 548);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnEdit);
            flowLayoutPanel2.Controls.Add(btnDelete);
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 222);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel2.Size = new Size(663, 48);
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
            btnEdit.Location = new Point(624, 3);
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
            btnDelete.Location = new Point(581, 3);
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
            btnAdd.Location = new Point(537, 3);
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
            dataGridView1.Location = new Point(3, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(663, 269);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateDen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTu);
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
            panel1.Controls.Add(checkedListBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 213);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(537, 139);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 45;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateDen
            // 
            dateDen.Format = DateTimePickerFormat.Custom;
            dateDen.Location = new Point(344, 168);
            dateDen.Name = "dateDen";
            dateDen.Size = new Size(166, 23);
            dateDen.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 43;
            label4.Text = "Đến";
            // 
            // dateTu
            // 
            dateTu.Format = DateTimePickerFormat.Custom;
            dateTu.Location = new Point(163, 168);
            dateTu.Name = "dateTu";
            dateTu.Size = new Size(166, 23);
            dateTu.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 150);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 41;
            label5.Text = "Ngày bắt đầu từ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 106);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 40;
            label9.Text = "Đối tác";
            // 
            // cbbDoiTac
            // 
            cbbDoiTac.FormattingEnabled = true;
            cbbDoiTac.Location = new Point(341, 124);
            cbbDoiTac.Name = "cbbDoiTac";
            cbbDoiTac.Size = new Size(166, 23);
            cbbDoiTac.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(160, 106);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 38;
            label8.Text = "Cơ quan phê duyệt";
            // 
            // cbbCoQuanPheDuyet
            // 
            cbbCoQuanPheDuyet.FormattingEnabled = true;
            cbbCoQuanPheDuyet.Location = new Point(160, 124);
            cbbCoQuanPheDuyet.Name = "cbbCoQuanPheDuyet";
            cbbCoQuanPheDuyet.Size = new Size(166, 23);
            cbbCoQuanPheDuyet.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 62);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 36;
            label6.Text = "Danh mục";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(341, 80);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(166, 23);
            cbbDanhMuc.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 62);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 34;
            label7.Text = "Đơn vị trực thuộc";
            // 
            // cbbDonViTrucThuoc
            // 
            cbbDonViTrucThuoc.FormattingEnabled = true;
            cbbDonViTrucThuoc.Location = new Point(160, 80);
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
            txtEng.Location = new Point(341, 36);
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(166, 23);
            txtEng.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 18);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Tên Tiếng Anh";
            // 
            // txtVn
            // 
            txtVn.Location = new Point(160, 36);
            txtVn.Name = "txtVn";
            txtVn.Size = new Size(166, 23);
            txtVn.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 18);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên Tiếng Việt";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Tên Tiếng Việt", "Tên Tiếng Anh", "Đơn vị trực thuộc", "Danh mục", "Cơ quan phê duyệt", "Đối tác", "Ngày bắt đầu" });
            checkedListBox1.Location = new Point(9, 18);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(144, 184);
            checkedListBox1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(537, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 23);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProjectSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 548);
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
        private CheckedListBox checkedListBox1;
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
        private DateTimePicker dateDen;
        private Label label4;
        private DateTimePicker dateTu;
        private Label label5;
        private Button button1;
        private Button btnCancel;
    }
}