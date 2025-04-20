using IPM_winform.IPM.Views;
using IPM_winform.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views
{
    public partial class LoginForm : Form
    {
        public bool AuthenticatedSuccess { get; set; }
        public string UserName { get => txtUserName.Text; }
        public string Password { get => txtPassword.Text; }
        public string Message { get => lbMessage.Text; set => lbMessage.Text = value; }
        
        public event EventHandler OnLogin;
        
        private readonly UserManager userManager = new UserManager();
        public LoginForm()
        {
            InitializeComponent();
            AuthenticatedSuccess = false;
            //new LoginPresenter(this);
            InitEvents();
        }

        private void InitEvents()
        {
            txtUserName.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassword.Focus();
                }
            };
            txtPassword.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    OnLogin?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = userManager.Login(txtUserName.Text, txtPassword.Text);
            if (user != null)
            {
                AuthenticatedSuccess = true;
                Session.setSession(user);
                Close();
            }
            else
            {
                Message = "Email hoặc mật khẩu chưa chính xác";
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            Message = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Message = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
      



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
