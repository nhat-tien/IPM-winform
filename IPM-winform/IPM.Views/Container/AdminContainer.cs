using IPM_winform.IPM.Views.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IPM_winform.IPM.Views.Container
{
    public partial class AdminContainer : Form
    {
        Form childrenView;
        public AdminContainer()
        {
            InitializeComponent();
            AddActionListener();
        }
        public void AddActionListener()
        {
            foreach (ToolStripMenuItem item in thongtinchung.DropDownItems)
            {
                Debug.WriteLine(item.Name);
                item.Click += (object o, EventArgs e) =>
                {
                    Debug.WriteLine(item.Name);
                    SetChildren(AdminContainerChildFactory.GetInstance(item.Name ?? ""));
                };
            }

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

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetChildren(AdminContainerChildFactory.GetInstance("user"));
        }

        private void quảnLíDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetChildren(AdminContainerChildFactory.GetInstance("project"));
        }

        private void báoCáoDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetChildren(AdminContainerChildFactory.GetInstance("danhsachduanReport"));
        }
    }
}
