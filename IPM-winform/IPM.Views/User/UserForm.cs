using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Views.DuAn;
using IPM_winform.IPM.Views.GenericForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.IPM.Views.User
{
    public class UserForm: FormContainer
    {
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();

        public override DataGridViewTextBoxColumn[] Columns
        {
            get => [
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Mã người dùng",
                Name = "UserId",
                ReadOnly = true,
            },
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Họ lót",
                Name = "LastName",
            },
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tên",
                Name = "FirstName",
            },
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Email",
                Name = "Email",
            },
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Số điện thoại",
                Name = "PhoneNumber",
            },
            new DataGridViewTextBoxColumn()
            {
                HeaderText = "Role",
                Name = "Role",
            },
            ]; set => base.Columns = value;
        }
        public override string Label => "Người dùng";

        public UserForm() : base()
        {

        }

        public IEnumerable<Infrastructure.Entities.User> RowsUser()
        {
            return db.Users.ToList();
        }
        public override void GoToIndex()
        {
            SetChildren(new UserIndexForm(this, RowsUser()));
            ChangeLabel("index");
        }
        public override void GoToInsert()
        {
            SetChildren(new UserInsertForm(this));
            ChangeLabel("insert"); ;
        }
    }
}
