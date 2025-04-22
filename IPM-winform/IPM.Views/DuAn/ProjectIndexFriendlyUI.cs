using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using IPM_winform.Dtos;
using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPM_winform.Services;
using System.Diagnostics;

namespace IPM_winform.IPM.Views.DuAn
{
    public partial class ProjectIndexFriendlyUI : Form
    {
        private readonly ProjectForm _parentView;
        private readonly IEnumerable<Project> _rows;
        public ProjectIndexFriendlyUI(ProjectForm parentView, IEnumerable<Project> rows)
        {
            InitializeComponent();
            _parentView = parentView;
            _rows = rows;
        }

        private void ProjectIndexFriendlyUI_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var row in _rows)
            {
                flowLayoutPanel1.Controls.Add(FolderBuilder(i++, row));
            }

            if(Services.Author.IsUser())
            {
                btnAdd.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private FlowLayoutPanel FolderBuilder(int id, Project project)
        {

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            Label label = new Label();
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = Properties.Resources.icons8_folder_96;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pic" + id;
            pictureBox.Size = new Size(126, 106);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Click += (object sender, EventArgs e) =>
            { 
                _parentView.GoToUpdate(project.ProjectId);
            };

            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10F);
            label.Location = new Point(43, 112);
            label.Name = "lab" + id;
            label.Size = new Size(45, 19);
            label.TabIndex = 0;
            label.Text = project.ProjectNameVietnamese;
            label.TextAlign = ContentAlignment.MiddleCenter;

            flowLayoutPanel.Anchor = AnchorStyles.None;
            flowLayoutPanel.BackColor = Color.Transparent;
            flowLayoutPanel.Controls.Add(pictureBox);
            flowLayoutPanel.Controls.Add(label);
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(3, 3);
            flowLayoutPanel.Name = "pa" + id;
            flowLayoutPanel.Size = new Size(132, 151);
            flowLayoutPanel.TabIndex = 1;
            flowLayoutPanel.Cursor = Cursors.Hand;
            


            return flowLayoutPanel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parentView.GoToInsert();
        }
    }
}
