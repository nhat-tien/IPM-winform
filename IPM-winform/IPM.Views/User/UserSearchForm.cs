using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Dtos;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.User
{
    public partial class UserSearchForm : Form
    {
        private readonly UserForm _parentView;

        private readonly DataGridViewTextBoxColumn[] _columns;
        private readonly IEnumerable<Infrastructure.Entities.User> _initialUsers;
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public UserSearchForm(UserForm parentView, IEnumerable<Infrastructure.Entities.User> rows)
        {
            InitializeComponent();
            _parentView = parentView;
            _columns = _parentView.Columns;
            _initialUsers = rows;
            setUpDataGridViewColumn();
            LoadData(rows);
            SetDataSourceChucVu();
            SetDataSourceDonViTrucThuoc();
        }

        public void setUpDataGridViewColumn()
        {
            foreach (var column in _columns)
            {
                dataGridView1.Columns.Add(column);
            }
        }

        public void clearSelection()
        {
            dataGridView1.ClearSelection();
        }

        private void DisableDeleteBtn()
        {
            btnDelete.Enabled = false;
            btnDelete.BackColor = Color.FromArgb(40, 247, 56, 56);
        }
        private void EnableDeleteBtn()
        {
            btnDelete.Enabled = true;
            btnDelete.BackColor = Color.FromArgb(247, 56, 56);
        }

        private void DisableEditBtn()
        {
            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.FromArgb(40, 247, 155, 56);
        }
        private void EnableEditBtn()
        {
            btnEdit.Enabled = true;
            btnEdit.BackColor = Color.FromArgb(247, 155, 56);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int numOfRowSelected = dataGridView1.SelectedRows.Count;
            if (numOfRowSelected > 1)
            {
                EnableDeleteBtn();
                DisableEditBtn();
            }
            else if (numOfRowSelected == 1)
            {
                EnableDeleteBtn();
                EnableEditBtn();
            }
            else
            {
                DisableEditBtn();
                DisableDeleteBtn();
            }
        }
        public string GetSelectedRowId()
        {
            var row = dataGridView1.SelectedRows;
            return row[0].Cells[0].Value.ToString() ?? "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parentView.GoToInsert();
        }
        public DataGridViewSelectedRowCollection GetSelectedRow()
        {
            return dataGridView1.SelectedRows;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows;
            var name = row[0].Cells[1].Value.ToString() ?? "";
            _parentView.GoToUpdate(GetSelectedRowId(), name);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _parentView.OnDelete(GetSelectedRowId());
        }

        public void LoadData(IEnumerable<Infrastructure.Entities.User> rows)
        {
            
            dataGridView1.Rows.Clear();
            foreach (var row in rows)
            {
                dataGridView1.Rows.Add(
                   row.UserId,
                   row.LastName,
                   row.FirstName,
                   row.Email,
                   row.PhoneNumber,
                   row.Role
                );
            }
        }

        public void SetDataSourceDonViTrucThuoc()
        {
            var entities = db.AffiliatedUnits.ToList();
            cbbDonViTrucThuoc.ValueMember = null;
            cbbDonViTrucThuoc.DisplayMember = "AffiliatedUnitName";
            cbbDonViTrucThuoc.DataSource = entities;
        }
        
        
        public void SetDataSourceChucVu()
        {
            var entities = db.Positions.ToList();
            cbbChucVu.ValueMember = null;
            cbbChucVu.DisplayMember = "PositionName";
            cbbChucVu.DataSource = entities;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = _initialUsers;
            var items = checkedListBox1.CheckedItems;

            if (items.Contains("Họ lót"))
            {
                users = users.Where(e => e.LastName.Contains(txtHoLot.Text));
            }
            if (items.Contains("Tên"))
            {
                users = users.Where(e => e.FirstName.Contains(Ten.Text));
            }
            if (items.Contains("Email"))
            {
                users = users.Where(e => e.Email.Contains(txtEmail.Text));
            }
            if (items.Contains("Số điện thoại"))
            {
                users = users.Where(e => e.PhoneNumber.Contains(txtSoDienThoai.Text));
            }
            if (items.Contains("Đơn vị trực thuộc"))
            {
                var condition = (AffiliatedUnit)cbbDonViTrucThuoc.SelectedItem;
                users = users.Where(e => e.AffiliatedUnitId == condition.AffiliatedUnitId);
            }
            if (items.Contains("Chức vụ"))
            {
                var condition = (Position)cbbChucVu.SelectedItem;
                users = users.Where(e => e.PositionId == condition.PositionId);
            }

            if (items.Contains("Vai trò"))
            {
                var condition = (string) cbbRole.SelectedItem;
                users = users.Where(e => e.Role == condition);
            }

            LoadData(users);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData(_initialUsers);
        }
    }
}
