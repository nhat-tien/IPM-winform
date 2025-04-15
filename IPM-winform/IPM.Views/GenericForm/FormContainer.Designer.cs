namespace IPM_winform.IPM.Views.GenericForm
{
    partial class FormContainer
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            centerPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 3, 0, 0);
            flowLayoutPanel1.Size = new Size(634, 37);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 5);
            label1.Margin = new Padding(4, 2, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 6;
            label1.Text = "Bộ Môn";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(13, 20);
            label2.TabIndex = 7;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 6);
            label3.Margin = new Padding(2, 3, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // centerPanel
            // 
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 37);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(634, 389);
            centerPanel.TabIndex = 2;
            // 
            // FormContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 426);
            Controls.Add(centerPanel);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormContainer";
            Text = "FormContainer";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel centerPanel;
    }
}