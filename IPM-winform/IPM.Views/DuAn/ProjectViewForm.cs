using DocumentFormat.OpenXml.Bibliography;
using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Controls;
using IPM_winform.Services;
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
using Author = IPM_winform.Services.Author;

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
            LoadData();
        }

        private void LoadData()
        {
            var project = db.Projects
                .AsNoTracking()
               .Include(e => e.ApprovingAgency)
               .Include(e => e.AffiliatedUnit)
               .Include(e => e.Category)
               .Include(e => e.Counterparty)
               .Include(e => e.Files)
               .ThenInclude(e => e.User)
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

            flowLayoutPanel2.Controls.Clear();
            foreach (var part in project.Participations)
            {
                var user = part.User;
                flowLayoutPanel2.Controls.Add(
                    new UserBlock()
                    {
                        Name = user.LastName + " " + user.LastName,
                        Email = user.Email,
                        AvatarUrl = user.AvatarUrl,
                    }
                 );
            };

            flowLayoutPanel3.Controls.Clear();
            foreach (var file in project.Files)
            {
                flowLayoutPanel3.Controls.Add(new FileBlockWithUser()
                {
                    Id = file.FileId,
                    FileName = file.FileName,
                    UserName = file.User.LastName + " " + file.User.FirstName,
                    Status = file.Status,
                    OnCheck = ConfirmFile,
                    OnDelete = DeleteFile,
                    OnReject = RejectFile
                }
                 );
            };

            if (project.IsEnd)
            {
                btnUpdate.Visible = false;
                button1.Visible = false;
                if(Services.Author.IsAdmin())
                {
                    btnKhoiPhuc.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Projects.Where(e => e.ProjectId == _id).ExecuteUpdate(r =>
            r
            .SetProperty(e => e.EndDate, DateTime.Now.Date)
            .SetProperty(e => e.IsEnd, true));
        }

        private void DeleteFile(int id)
        {
            db.Files.Where(e => e.FileId == id).ExecuteDelete();
            LoadData();
        }

        private void ConfirmFile(int id)
        {
            db.Files.Where(e => e.FileId == id).ExecuteUpdate(e => e.SetProperty(r => r.Status, "done"));
            LoadData();
        }

        private void RejectFile(int id)
        {
            db.Files.Where(e => e.FileId == id).ExecuteUpdate(e => e.SetProperty(r => r.Status, "reject"));
            LoadData();
        }

        private void DownloadFile(int id)
        {

        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //Confirm
        //    if (e.ColumnIndex == 5)
        //    {
        //        ConfirmFile(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
        //    }
        //    //Download
        //    else if (e.ColumnIndex == 6)
        //    {
        //        DownloadFile(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
        //    }
        //    //Delete
        //    else if (e.ColumnIndex == 7)
        //    {
        //        DeleteFile(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
        //    };
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _parentView.GoToUpdateManager(_id);
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            db.Projects.Where(e => e.ProjectId == _id).ExecuteUpdate(r =>
            r
            .SetProperty(e => e.IsEnd, false));
        }
    }

}
