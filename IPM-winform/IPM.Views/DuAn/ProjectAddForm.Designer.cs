namespace IPM_winform.IPM.Views.DuAn
{
    partial class ProjectAddForm
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
            btnBack = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            cbbDoiTac = new ComboBox();
            label8 = new Label();
            cbbCoQuanPheDuyet = new ComboBox();
            label6 = new Label();
            cbbDanhMuc = new ComboBox();
            label7 = new Label();
            cbbDonViTrucThuoc = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            label11 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            textBox2 = new TextBox();
            btnMoveOut = new Button();
            btnMoveIn = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            FileId = new DataGridViewTextBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            label10 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            UserId = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(109, 22);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // txtName
            // 
            txtName.Location = new Point(10, 49);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbbDoiTac);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbbCoQuanPheDuyet);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbbDanhMuc);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbbDonViTrucThuoc);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 318);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(368, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 23);
            dateTimePicker1.TabIndex = 19;
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
            // richTextBox2
            // 
            richTextBox2.Location = new Point(191, 105);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(166, 66);
            richTextBox2.TabIndex = 16;
            richTextBox2.Text = "";
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(10, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(166, 66);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
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
            // textBox1
            // 
            textBox1.Location = new Point(188, 49);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 10;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(3, 858);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(555, 78);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(dataGridView3);
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(btnMoveOut);
            groupBox4.Controls.Add(btnMoveIn);
            groupBox4.Location = new Point(3, 327);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(604, 252);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thành viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(324, 61);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 8;
            label11.Text = "Thành viên dự án";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4 });
            dataGridView3.Location = new Point(342, 90);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(243, 150);
            dataGridView3.TabIndex = 7;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { UserId, LastName, FirstName, Email });
            dataGridView2.Location = new Point(10, 90);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(243, 150);
            dataGridView2.TabIndex = 6;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // button3
            // 
            button3.Location = new Point(160, 52);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Tìm";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 4;
            // 
            // btnMoveOut
            // 
            btnMoveOut.Location = new Point(261, 119);
            btnMoveOut.Name = "btnMoveOut";
            btnMoveOut.Size = new Size(75, 23);
            btnMoveOut.TabIndex = 3;
            btnMoveOut.Text = "<<";
            btnMoveOut.UseVisualStyleBackColor = true;
            // 
            // btnMoveIn
            // 
            btnMoveIn.Location = new Point(261, 90);
            btnMoveIn.Name = "btnMoveIn";
            btnMoveIn.Size = new Size(75, 23);
            btnMoveIn.TabIndex = 2;
            btnMoveIn.Text = ">>";
            btnMoveIn.UseVisualStyleBackColor = true;
            btnMoveIn.Click += btnMoveIn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(3, 585);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(555, 267);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "File";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FileId, FileName });
            dataGridView1.Location = new Point(36, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(479, 150);
            dataGridView1.TabIndex = 14;
            // 
            // FileId
            // 
            FileId.HeaderText = "File Id";
            FileId.Name = "FileId";
            FileId.ReadOnly = true;
            // 
            // FileName
            // 
            FileName.HeaderText = "File Name";
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            // 
            // button5
            // 
            button5.Location = new Point(69, 75);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(88, 27);
            button5.TabIndex = 13;
            button5.Text = "Thêm file";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(427, 43);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(88, 27);
            button4.TabIndex = 12;
            button4.Text = "Browse";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 46);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 23);
            textBox3.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 49);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 11;
            label10.Text = "File";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(644, 784);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // UserId
            // 
            UserId.HeaderText = "UserId";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // LastName
            // 
            LastName.HeaderText = "Họ";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Tên";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "UserId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Họ";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ProjectAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(644, 784);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectAddForm";
            Text = "doc";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnAdd;
        private Label label1;
        private TextBox txtName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label7;
        private ComboBox cbbDonViTrucThuoc;
        private Label label6;
        private ComboBox cbbDanhMuc;
        private Label label8;
        private ComboBox cbbCoQuanPheDuyet;
        private Label label9;
        private ComboBox cbbDoiTac;
        private Button btnMoveIn;
        private Button btnMoveOut;
        private Button button3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private TextBox textBox3;
        private Label label10;
        private DataGridViewTextBoxColumn FileId;
        private DataGridViewTextBoxColumn FileName;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Email;
    }
}