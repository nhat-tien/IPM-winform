using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.DuAn
{
    public partial class ProjectViewForm : Form
    {

        private readonly ProjectForm _parentView;
        private readonly int _id;
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public ProjectViewForm(ProjectForm parentView, int id)
        {
            InitializeComponent();
            _parentView = parentView;
            _id = id;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.GoToIndex();
        }

        private void ProjectViewForm_Load(object sender, EventArgs e)
        {
            var project = db.Projects
                .Include(e => e.ApprovingAgency)
                .Include(e => e.AffiliatedUnit)
                .Include(e => e.Category)
                .Include(e => e.Counterparty)
                .Include(e => e.Files)
                .Include(e => e.Participations)
                .ThenInclude(e => e.User)
                .Where(e => e.ProjectId == _id)
                .FirstOrDefault();

            if (project is null)
            {
                return;
            }

            label10.Text = project.ProjectNameVietnamese;
            label11.Text = project.ProjectNameEnglish;
            label12.Text = project.StartDate.ToString("dd/MM/yyyy");
            richTextBox1.Text = project.ProjectPurpose;
            richTextBox2.Text = project.Content;
            label13.Text = project.AffiliatedUnit?.AffiliatedUnitName;
            label14.Text = project.Category?.CategoryName;
            label15.Text = project.ApprovingAgency?.ApprovingAgencyName;
            label16.Text = project.Counterparty?.CounterpartyName;

            
            foreach (var part in project.Participations)
            {
                var user = part.User;
                dataGridView3.Rows.Add(
                    user.LastName,
                    user.FirstName,
                    user.Email
                 );
            };

            foreach (var file in project.Files)
            {
                dataGridView1.Rows.Add(
                    file.FileId,
                    file.FileName,
                    file.ObjectName
                    
                 );
            };

        }
    }

}
