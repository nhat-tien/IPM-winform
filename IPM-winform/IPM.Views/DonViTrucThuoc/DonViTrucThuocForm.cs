using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Dtos;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.IPM.Views.GenericForm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.IPM.Views.DonViTrucThuoc
{
    public class DonViTrucThuocForm : FormContainer
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
                    HeaderText = "Tên Đơn Vị Trực Thuộc",
                    Name = "AffiliatedName",
                }
        ]; set => base.Columns = value;
        }

        public override string InsertLabel { get => "Đơn vị trực thuộc"; }
        public override string UpdateLabel { get => "Đơn vị trực thuộc"; }

        public override string Label => "Đơn vị trực thuộc";

        public DonViTrucThuocForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.AffiliatedUnits.Add(new AffiliatedUnit()
            {
                AffiliatedUnitName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.AffiliatedUnits.Select(r => new TableDto()
            {
                Id = r.AffiliatedUnitId.ToString(),
                Name = r.AffiliatedUnitName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(int id)
        {
            db.AffiliatedUnits.Where(r => r.AffiliatedUnitId == id).ExecuteDelete();
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
