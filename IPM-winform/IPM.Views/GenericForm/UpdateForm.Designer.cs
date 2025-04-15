namespace IPM_winform.IPM.Views.GenericForm
{
    partial class UpdateForm
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
            btnUpdate = new Button();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(54, 103);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 27);
            btnBack.TabIndex = 7;
            btnBack.Text = "Trở về";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(176, 103);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Tên Bộ Môn";
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 38);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(116, 23);
            txtName.TabIndex = 4;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 381);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateForm";
            Text = "UpsertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnUpdate;
        private Label label1;
        private TextBox txtName;
    }
}