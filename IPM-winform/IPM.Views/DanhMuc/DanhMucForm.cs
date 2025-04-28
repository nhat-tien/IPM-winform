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

namespace IPM_winform.IPM.Views.DanhMuc
{
    public class DanhMucForm: FormContainer
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
                    HeaderText = "Danh Mục",
                    Name = "CategoryName",
                }
        ]; set => base.Columns = value;
        }

        public override string InsertLabel { get => "Danh mục"; }
        public override string UpdateLabel { get => "Danh mục"; }

        public override string Label => "Danh Mục";

        public DanhMucForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.Categories.Add(new Category()
            {
                CategoryName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.Categories.Select(r => new TableDto()
            {
                Id = r.CategoryId.ToString(),
                Name = r.CategoryName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(int id)
        {
            db.Categories.Where(r => r.CategoryId == id).ExecuteDelete();
            Reload();
        }

        public override void OnUpdate(string id, object name)
        {
            string updateName = (string)name;
            int idNum = Int32.Parse(id);
            db.Categories.Where(r => r.CategoryId == idNum)
                .ExecuteUpdate(r => r.SetProperty(e => e.CategoryName, updateName));
        }
    }
}
