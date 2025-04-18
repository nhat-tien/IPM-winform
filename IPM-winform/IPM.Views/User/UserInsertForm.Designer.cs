namespace IPM_winform.IPM.Views.GenericForm
{
    partial class UserInsertForm
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
            label = new Label();
            txtHoLot = new TextBox();
            s = new GroupBox();
            label9 = new Label();
            cbbRole = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtMatKhau = new TextBox();
            label6 = new Label();
            cbbDonViTrucThuoc = new ComboBox();
            cbbChucVu = new ComboBox();
            label5 = new Label();
            txtDiaChi = new RichTextBox();
            groupBox3 = new GroupBox();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            s.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 33);
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
            btnAdd.Location = new Point(109, 33);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(7, 31);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(40, 15);
            label.TabIndex = 9;
            label.Text = "Họ lót";
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(7, 49);
            txtHoLot.Margin = new Padding(4, 3, 4, 3);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(150, 23);
            txtHoLot.TabIndex = 8;
            // 
            // s
            // 
            s.Controls.Add(label9);
            s.Controls.Add(cbbRole);
            s.Controls.Add(label8);
            s.Controls.Add(label7);
            s.Controls.Add(txtMatKhau);
            s.Controls.Add(label6);
            s.Controls.Add(cbbDonViTrucThuoc);
            s.Controls.Add(cbbChucVu);
            s.Controls.Add(label5);
            s.Controls.Add(txtDiaChi);
            s.Controls.Add(groupBox3);
            s.Controls.Add(txtSoDienThoai);
            s.Controls.Add(label4);
            s.Controls.Add(txtEmail);
            s.Controls.Add(label3);
            s.Controls.Add(txtTen);
            s.Controls.Add(label2);
            s.Controls.Add(txtHoLot);
            s.Controls.Add(label);
            s.Dock = DockStyle.Top;
            s.Location = new Point(0, 0);
            s.Name = "s";
            s.Size = new Size(570, 353);
            s.TabIndex = 12;
            s.TabStop = false;
            s.Text = "Nhập nội dung";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(165, 243);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 26;
            label9.Text = "Role";
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Items.AddRange(new object[] { "Admin", "Manager", "User" });
            cbbRole.Location = new Point(165, 261);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(150, 23);
            cbbRole.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(323, 86);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 24;
            label8.Text = "Đơn vị trực thuộc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 86);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 23;
            label7.Text = "Chức vụ";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(7, 261);
            txtMatKhau.Margin = new Padding(4, 3, 4, 3);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(150, 23);
            txtMatKhau.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 243);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 22;
            label6.Text = "Mật khẩu";
            // 
            // cbbDonViTrucThuoc
            // 
            cbbDonViTrucThuoc.FormattingEnabled = true;
            cbbDonViTrucThuoc.Location = new Point(323, 104);
            cbbDonViTrucThuoc.Name = "cbbDonViTrucThuoc";
            cbbDonViTrucThuoc.Size = new Size(150, 23);
            cbbDonViTrucThuoc.TabIndex = 20;
            // 
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(165, 104);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(150, 23);
            cbbChucVu.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 149);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 18;
            label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(261, 167);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(212, 47);
            txtDiaChi.TabIndex = 17;
            txtDiaChi.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdNu);
            groupBox3.Controls.Add(rdNam);
            groupBox3.Location = new Point(13, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(226, 65);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giới tính";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(96, 25);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(41, 19);
            rdNu.TabIndex = 1;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(27, 25);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(51, 19);
            rdNam.TabIndex = 0;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(7, 104);
            txtSoDienThoai.Margin = new Padding(4, 3, 4, 3);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(150, 23);
            txtSoDienThoai.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 86);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 15;
            label4.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(323, 49);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(165, 49);
            txtTen.Margin = new Padding(4, 3, 4, 3);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(150, 23);
            txtTen.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 11;
            label2.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 361);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(570, 72);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // UserInsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 433);
            Controls.Add(groupBox2);
            Controls.Add(s);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserInsertForm";
            Text = "InsertForm";
            s.ResumeLayout(false);
            s.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnAdd;
        private Label label;
        private TextBox txtHoLot;
        private GroupBox s;
        private GroupBox groupBox2;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtSoDienThoai;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private GroupBox groupBox3;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label label5;
        private RichTextBox txtDiaChi;
        private ComboBox cbbChucVu;
        private ComboBox cbbDonViTrucThuoc;
        private TextBox txtMatKhau;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbbRole;
    }
}