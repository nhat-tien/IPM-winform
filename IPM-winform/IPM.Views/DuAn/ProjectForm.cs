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
using IPM_winform.Services;
using System.Diagnostics;
using DocumentFormat.OpenXml.InkML;

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
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Đơn vị trực thuộc",
                    Name = "AffiliatedUnitName",
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Danh mục",
                    Name = "Category",
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Cơ quan phê duyệt",
                    Name = "ApprovingAgencyName",
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Đối tác",
                    Name = "CounterpartyName",
                }

        ]; set => base.Columns = value;
        }
        public override string Label => "Dự án";

        public ProjectForm() : base()
        {

        }

        public virtual IEnumerable<Project> RowsProject()
        {
            return db.Projects.Include(e => e.AffiliatedUnit)
                .Include(e => e.Category)
                .Include(e => e.ApprovingAgency)
                .Include(e => e.Counterparty)
                .ToList();
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

        public new void GoToUpdate(int id)
        {
            if(Services.Author.IsUser())
            {
                SetChildren(new ProjectUpdateUserForm(this, id));
                ChangeLabel("update");
            } else
            {
                SetChildren(new ProjectViewForm(this, id));
                ChangeLabel("update");
            }
        }

        public void GoToUpdateManager(int id)
        {
            SetChildren(new ProjectUpdateManagerForm(this, id));
            ChangeLabel("update");
        }
        public override void OnDelete(int id)
        {
            var result = MessageBox.Show("Bạn có chắc muốn xóa dự án, điều này không thể khôi phục", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                db.Projects.Where(r => r.ProjectId == id).ExecuteDelete();
                foreach (var entry in db.ChangeTracker.Entries())
                {
                    entry.State = EntityState.Detached;
                }
            }
        }

        public void OnEndProject(int id)
        {
            var result = MessageBox.Show("Bạn có chắc muốn kết thúc dự án, điều này không thể khôi phục", "Xác nhận kết thúc", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                db.Projects.Where(e => e.ProjectId == id).ExecuteUpdate(r => r.SetProperty(e => e.EndDate, DateTime.Now.Date));
                foreach (var entry in db.ChangeTracker.Entries())
                {
                    entry.State = EntityState.Detached;
                }
            }
        }
    }
}
