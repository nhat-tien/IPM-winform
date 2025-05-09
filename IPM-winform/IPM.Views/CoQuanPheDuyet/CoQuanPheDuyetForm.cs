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

namespace IPM_winform.IPM.Views.CoQuanPheDuyet
{
    internal class CoQuanPheDuyetForm: FormContainer
    {
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public override DataGridViewTextBoxColumn[] Columns
        {
            get => [
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Id",
                Name = "Id",
                ReadOnly = true,
                //Visible = false,
            },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên Cơ Quan Phê Duyệt",
                    Name = "ApprovingAgencyName",
                }
        ]; set => base.Columns = value;
        }

        public override string InsertLabel { get => "Cơ quan phê duyệt"; }
        public override string UpdateLabel { get => "Cơ quan phê duyệt"; }

        public override string Label => "Cơ Quan Phê Duyệt";

        public CoQuanPheDuyetForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.ApprovingAgencies.Add(new ApprovingAgency()
            {
                ApprovingAgencyName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.ApprovingAgencies.Select(r => new TableDto()
            {
                Id = r.ApprovingAgencyId.ToString(),
                Name = r.ApprovingAgencyName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(int id)
        {
            DBExceptionHandler.Handle(() =>
            {
                db.ApprovingAgencies.Where(r => r.ApprovingAgencyId == id).ExecuteDelete();
                Reload();
            });
        }

        public override void OnUpdate(string id, object name)
        {
            string updateName = (string)name;
            int idNum = Int32.Parse(id);
            db.ApprovingAgencies.Where(r => r.ApprovingAgencyId == idNum)
                .ExecuteUpdate(r => r.SetProperty(e => e.ApprovingAgencyName, updateName));
        }
    }
}
