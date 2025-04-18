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

namespace IPM_winform.IPM.Views.NhaTaiTro
{
    public class NhaTaiTroForm: FormContainer
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
                    HeaderText = "Nhà Tài Trợ",
                    Name = "SponsorName",
                }
        ]; set => base.Columns = value;
        }

        public override string InsertLabel { get => "Nhà tài trợ"; }
        public override string UpdateLabel { get => "Nhà tài trợ"; }

        public override string Label => "Nhà Tài Trợ";

        public NhaTaiTroForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.Sponsors.Add(new Sponsor()
            {
                SponsorName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.Sponsors.Select(r => new TableDto()
            {
                Id = r.SponsorId.ToString(),
                Name = r.SponsorName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(string id)
        {
            int idNum = Int32.Parse(id);
            db.Sponsors.Where(r => r.SponsorId == idNum).ExecuteDelete();
            Reload();
        }

        public override void OnUpdate(string id, object name)
        {
            string updateName = (string)name;
            int idNum = Int32.Parse(id);
            db.Sponsors.Where(r => r.SponsorId == idNum)
                .ExecuteUpdate(r => r.SetProperty(e => e.SponsorName, updateName));
        }
    }
}
