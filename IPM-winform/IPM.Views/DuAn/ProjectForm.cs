using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Dtos;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Views.GenericForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IPM_winform.IPM.Views.DuAn
{
    public class ProjectForm : FormContainer
    {
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public override DataGridViewTextBoxColumn[] Columns
        {
            get => [
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Mã Dự Án",
                Name = "ProjectId",
                ReadOnly = true,
                Visible = false,
            },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên Dự Án (Tiếng Việt)",
                    Name = "ProjectNameVietnamese",
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên Dự Án (Tiếng Anh)",
                    Name = "ProjectNameEnglish",
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Ngày bắt đầu",
                    Name = "StartDate",
                }

        ]; set => base.Columns = value;
        }
        public override string Label => "Dự án";

        public ProjectForm() : base()
        {

        }

        public IEnumerable<Project> RowsProject()
        {
            return db.Projects.ToList();
        }

        public override void GoToIndex()
        {
            SetChildren(new ProjectIndexForm(this, RowsProject()));
            ChangeLabel("index");
        }
        public override void GoToInsert()
        {
            SetChildren(new ProjectAddForm(this));
            ChangeLabel("insert"); ;
        }

        public void GoToAdvanceSearch()
        {
            SetChildren(new ProjectSearchForm(this, RowsProject()));
            ChangeLabel("search");
        }
    }
}
