using DocumentFormat.OpenXml.Bibliography;
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

namespace IPM_winform.Controls
{
    public partial class ProjectBlock : UserControl
    {
        public Action OnView { get; set; }
        public Action OnDelete { get; set; }
        public Action OnEnd { get; set; }

        public bool Owner { get; set; } = false;
        public bool IsEnd { get; set; } = false;
        public ProjectBlock()
        {
            InitializeComponent();
        }

        public string ProjectName
        {
            get => lbProjectName.Text;
            set
            {
                lbProjectName.Text = value;
            }
        }

        public string Description
        {
            get => lbDesc.Text;
            set
            {
                lbDesc.Text = value;
            }
        }

        public string AffiliatedUnit
        {
            get => lbdvtt.Text;
            set
            {
                lbdvtt.Text = value;
            }
        }

        public string Memeber
        {
            get => lbMember.Text;
            set
            {
                lbMember.Text = value;
            }
        }

        public string File
        {
            get => lbFile.Text;
            set
            {
                lbFile.Text = value;
            }
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnView != null)
            {
                OnView();
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnDelete != null)
            {
                OnDelete();
            }
        }

        private void ProjectBlock_Load(object sender, EventArgs e)
        {
            if (!Owner)
            {
                xóaToolStripMenuItem.Visible = false;
            }

            if(IsEnd)
            {
                kếtThúcDựÁnToolStripMenuItem.Visible = false;
            }
        }

        private void kếtThúcDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnDelete != null)
            {
                OnDelete();
            }
        }
    }
}
