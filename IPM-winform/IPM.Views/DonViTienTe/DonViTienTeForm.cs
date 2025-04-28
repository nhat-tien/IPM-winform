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

namespace IPM_winform.IPM.Views.DonViTienTe
{
    public class DonViTienTeForm: FormContainer
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
                    HeaderText = "Đơn Vị Tiền Tệ",
                    Name = "CurrencyUnitName",
                }
        ]; set => base.Columns = value;
        }
        public override string InsertLabel { get => "Đơn vị tiền tệ"; }
        public override string UpdateLabel { get => "Đơn vị tiền tệ"; }

        public override string Label => "Đơn Vị Tiền Tệ";

        public DonViTienTeForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.CurrencyUnits.Add(new CurrencyUnit()
            {
                CurrencyUnitName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.CurrencyUnits.Select(r => new TableDto()
            {
                Id = r.CurrencyUnitId.ToString(),
                Name = r.CurrencyUnitName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(int id)
        {
            db.CurrencyUnits.Where(r => r.CurrencyUnitId == id).ExecuteDelete();
            Reload();
        }

        public override void OnUpdate(string id, object name)
        {
            string updateName = (string)name;
            int idNum = Int32.Parse(id);
            db.CurrencyUnits.Where(r => r.CurrencyUnitId == idNum)
                .ExecuteUpdate(r => r.SetProperty(e => e.CurrencyUnitName, updateName));
        }
    }
}
