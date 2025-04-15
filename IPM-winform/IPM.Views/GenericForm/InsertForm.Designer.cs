namespace IPM_winform.IPM.Views.GenericForm
{
    partial class InsertForm
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
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(57, 109);
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
            btnAdd.Location = new Point(179, 109);
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
            label1.Location = new Point(41, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "Tên Bộ Môn";
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 44);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(116, 23);
            txtName.TabIndex = 8;
            // 
            // InsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 306);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InsertForm";
            Text = "InsertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnAdd;
        private Label label1;
        private TextBox txtName;
    }
}