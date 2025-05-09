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

namespace IPM_winform.IPM.Views.DoiTac
{
    public class DoiTacForm: FormContainer
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
                    HeaderText = "Tên Đối Tác",
                    Name = "CounterpartyName",
                }
        ]; set => base.Columns = value;
        }

        public override string InsertLabel { get => "Đối tác"; }
        public override string UpdateLabel { get => "Đối tác"; }

        public override string Label => "Đối Tác";

        public DoiTacForm() : base()
        {

        }

        public override void OnCreate(string name)
        {
            db.Counterparties.Add(new Counterparty()
            {
                CounterpartyName = name
            });
            db.SaveChanges();
        }

        public override IEnumerable<TableDto> Rows()
        {
            var affiliated = db.Counterparties.Select(r => new TableDto()
            {
                Id = r.CounterpartyId.ToString(),
                Name = r.CounterpartyName ?? ""
            }).ToList();

            return affiliated;
        }

        public override void OnDelete(int id)
        {
            DBExceptionHandler.Handle(() =>
            {
                db.Counterparties.Where(r => r.CounterpartyId == id).ExecuteDelete();
                Reload();
            });
        }

        public override void OnUpdate(string id, object name)
        {
            string updateName = (string)name;
            int idNum = Int32.Parse(id);
            db.Counterparties.Where(r => r.CounterpartyId == idNum)
                .ExecuteUpdate(r => r.SetProperty(e => e.CounterpartyName, updateName));
        }
    }
}
