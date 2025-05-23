﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPM_winform.IPM.Views.Factories;
using IPM_winform.IPM.Views.TaiKhoan;
using IPM_winform.Services;

namespace IPM_winform.IPM.Views
{
    public partial class Dashboard : Form
    {

        Form childrenView;
        bool menuExpand = true;
        private Infrastructure.Entities.User? _user = Session.getSession();

        public Dashboard()
        {
            InitializeComponent();
            SetUserName(_user?.FirstName);
            SetUserAvatar(_user?.AvatarUrl);
            //new DashBoardPresenter(this);
            AddActionListener();
            SetChildren(new Home());
        }

        public void SetChildren(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            if (childrenView != null)
            {
                childrenView.Close();
            }
            childrenView = form;
            mainPanel.Controls.Add(childrenView);
            childrenView.Show();
        }


        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menu.Width -= 10;
                if (menu.Width <= 50)
                {
                    menuExpand = false;
                    menuTransition.Stop();

                    home.Width = menu.Width;
                    foreach (Button button in getMenuControls())
                    {
                        button.Width = menu.Width;
                    }
                }
            }
            else
            {
                menu.Width += 10;
                if (menu.Width >= 209)
                {
                    menuExpand = true;
                    menuTransition.Stop();

                    home.Text = "  HOME";
                    admin.Text = "  ADMIN";
                    myproject.Text = "  DỰ ÁN CỦA TÔI";
                    label1.Text = "IPM";
                    home.Width = menu.Width;
                    foreach (Button button in getMenuControls())
                    {
                        button.Width = menu.Width;
                    }

                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            home.Text = "";
            admin.Text = "";
            myproject.Text = "";
            label1.Text = "";
            menuTransition.Start();
        }

        public void AddActionListener()
        {
            foreach (Button button in getMenuControls())
            {
                button.Click += (object o, EventArgs e) =>
                {
                    SetChildren(DasboardChildrenFactory.GetInstance(button.Name));
                };
            }
        }

        public IEnumerable<Button> getMenuControls()
        {

            return menu.Controls.OfType<Button>();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.deleteSession();
            Application.Restart();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetUserName(string name)
        {
            label2.Text = $"Welcome {name}";
        }

        private void SetUserAvatar(string url)
        {
            pictureBox1.Image = String.IsNullOrEmpty(url) ? Properties.Resources.user : Image.FromFile(url);
        }
        private void home_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetChildren(new TaiKhoanForm(this));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (!Author.IsAdmin())
            {
                admin.Hide();
            }
        }
    }
}
