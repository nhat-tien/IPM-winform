using IPM_winform.Dtos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.User
{
    public partial class UserIndexForm : Form
    {
        private readonly UserForm _parentView;
       
        private readonly DataGridViewTextBoxColumn[] _columns; 
        public UserIndexForm(UserForm parentView, IEnumerable<Infrastructure.Entities.User> rows)
        {
            InitializeComponent();
            _parentView = parentView;
            _columns = _parentView.Columns;
            setUpDataGridViewColumn();
            LoadData(rows);
            DisableDeleteBtn();
            DisableEditBtn();
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
    }
}
