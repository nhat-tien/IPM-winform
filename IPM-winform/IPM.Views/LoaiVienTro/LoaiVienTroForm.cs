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

namespace IPM_winform.IPM.Views.LoaiVienTro
{
    public class LoaiVienTroForm: FormContainer
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
                    HeaderText = "Loại Viện Trợ",
                    Name = "AidTypeName",
                }
        ]; set => base.Columns = value;
        }

        public override string InsertLabel { get => "Loại viện trợ"; }
        public override string UpdateLabel { get => "Loại viện trợ"; }

        public override string Label => "Loại Viện Trợ";

        public LoaiVienTroForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.AidTypes.Add(new AidType()
            {
                AidTypeName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.AidTypes.Select(r => new TableDto()
            {
                Id = r.AidTypeId.ToString(),
                Name = r.AidTypeName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(int id)
        {
            db.AidTypes.Where(r => r.AidTypeId == id).ExecuteDelete();
            Reload();
        }

        public override void OnUpdate(string id, object name)
        {
            string updateName = (string)name;
            int idNum = Int32.Parse(id);
            db.AidTypes.Where(r => r.AidTypeId == idNum)
                .ExecuteUpdate(r => r.SetProperty(e => e.AidTypeName, updateName));
        }
    }
}
