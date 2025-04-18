using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.DuAn
{
    public partial class ProjectAddForm : Form
    {

        private readonly ProjectForm _parentView;
        private List<Infrastructure.Entities.User> _users = [];
        private List<Infrastructure.Entities.User> _participate = [];
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public ProjectAddForm(ProjectForm parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            SetDataSourceCoQuanPheDuyet();
            SetDataSourceDanhMuc();
            SetDataSourceDoiTac();
            SetDataSourceDonViTrucThuoc();
            SetDataSourceUser();
            LoadDataUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parentView.OnCreate(txtName.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.GoToIndex();
        }

        public void SetDataSourceDonViTrucThuoc()
        {
            var entities = db.AffiliatedUnits.ToList();
            cbbDonViTrucThuoc.ValueMember = null;
            cbbDonViTrucThuoc.DisplayMember = "AffiliatedUnitName";
            cbbDonViTrucThuoc.DataSource = entities;
        }
        public void SetDataSourceDanhMuc()
        {
            var entities = db.Categories.ToList();
            cbbDanhMuc.ValueMember = null;
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.DataSource = entities;
        }
        public void SetDataSourceCoQuanPheDuyet()
        {
            var entities = db.ApprovingAgencies.ToList();
            cbbCoQuanPheDuyet.ValueMember = null;
            cbbCoQuanPheDuyet.DisplayMember = "ApprovingAgencyName";
            cbbCoQuanPheDuyet.DataSource = entities;
        }
        public void SetDataSourceDoiTac()
        {
            var entities = db.Counterparties.ToList();
            cbbDoiTac.ValueMember = null;
            cbbDoiTac.DisplayMember = "CounterpartyName";
            cbbDoiTac.DataSource = entities;
        }

        public void SetDataSourceUser()
        {
            _users = db.Users.ToList();
        }

        public void LoadDataUser()
        {
            dataGridView2.Rows.Clear();
            foreach (var row in _users)
            {
                dataGridView2.Rows.Add(
                   row.UserId,
                   row.LastName,
                   row.FirstName,
                   row.Email
                );
            }
            dataGridView3.Rows.Clear();
            foreach (var row in _participate)
            {
                dataGridView3.Rows.Add(
                   row.UserId,
                   row.LastName,
                   row.FirstName,
                   row.Email
                );
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int numOfRowSelected = dataGridView2.SelectedRows.Count;

            if (numOfRowSelected == 1)
            {
                btnMoveIn.Enabled = true;
            }
            else
            {
                btnMoveIn.Enabled = false;
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            int numOfRowSelected = dataGridView3.SelectedRows.Count;

            if (numOfRowSelected == 1)
            {
                btnMoveOut.Enabled = true;
            }
            else
            {
                btnMoveOut.Enabled = false;
            }
        }

        public string GetSelectedRowId2()
        {
            var row = dataGridView2.SelectedRows;
            return row[0].Cells[0].Value.ToString() ?? "";
        }

        public string GetSelectedRowId3()
        {
            var row = dataGridView3.SelectedRows;
            return row[0].Cells[0].Value.ToString() ?? "";
        }


        private void btnMoveIn_Click(object sender, EventArgs e)
        {
            var user = _users.Find(e => e.UserId == Int32.Parse(GetSelectedRowId2()));
            _users = _users.Where(e => e.UserId != user.UserId).ToList();
            _participate.Add(user);
            LoadDataUser();
        }
    }
}
