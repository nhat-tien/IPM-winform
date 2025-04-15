namespace IPM_winform.IPM.Views
{
    partial class LoginForm
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
            panel1 = new Panel();
            lbMessage = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(lbMessage);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(56, 36);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 473);
            panel1.TabIndex = 0;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.ForeColor = Color.Red;
            lbMessage.Location = new Point(48, 299);
            lbMessage.Margin = new Padding(4, 0, 4, 0);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(0, 15);
            lbMessage.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(43, 331);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(304, 32);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 265);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(305, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 247);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(43, 212);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(305, 23);
            txtUserName.TabIndex = 2;
            txtUserName.Enter += txtUserName_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 194);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 33);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(495, 542);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "Đăng Nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
    }
}