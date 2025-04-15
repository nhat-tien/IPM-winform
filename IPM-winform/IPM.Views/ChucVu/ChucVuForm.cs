using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Dtos;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.IPM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPM_winform.IPM.Views.GenericForm;
using Microsoft.EntityFrameworkCore;

namespace IPM_winform.IPM.Views.ChucVu
{
    public class ChucVuForm: FormContainer
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
                Visible = false,
            },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên Chức Vụ",
                    Name = "PositionName",
                }
        ]; set => base.Columns = value;
        }

        public override string Label => "Chức Vụ";

        public ChucVuForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.Positions.Add(new Position()
            {
                PositionName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.Positions.Select(r => new TableDto()
            {
                Id = r.PositionId.ToString(),
                Name = r.PositionName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(string id)
        {
            int idNum = Int32.Parse(id);
            db.AffiliatedUnits.Where(r => r.AffiliatedUnitId == idNum).ExecuteDelete();
            Reload();
        }

        public override void OnUpdate(string id, object name)
        {
            string updateName = (string)name;
            int idNum = Int32.Parse(id);
            db.AffiliatedUnits.Where(r => r.AffiliatedUnitId == idNum)
                .ExecuteUpdate(r => r.SetProperty(e => e.AffiliatedUnitName, updateName));
        }
    }
}
