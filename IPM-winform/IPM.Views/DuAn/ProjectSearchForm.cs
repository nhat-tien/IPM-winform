using DocumentFormat.OpenXml.Presentation;
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

namespace IPM_winform.IPM.Views.DuAn
{
    public partial class ProjectSearchForm : Form
    {
        private readonly ProjectForm _parentView;

        private readonly DataGridViewTextBoxColumn[] _columns;
        private readonly IEnumerable<Project> _initialProjects;
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public ProjectSearchForm(ProjectForm parentView, IEnumerable<Project> rows)
        {
            InitializeComponent();
            _parentView = parentView;
            _columns = _parentView.Columns;
            _initialProjects = rows;
            setUpDataGridViewColumn();
            LoadData(rows);
            SetDataSourceCoQuanPheDuyet();
            SetDataSourceDanhMuc();
            SetDataSourceDoiTac();
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
            _parentView.OnDelete(Int32.Parse(GetSelectedRowId()));
        }

        public void LoadData(IEnumerable<Project> rows)
        {
            dataGridView1.Rows.Clear();
            foreach (var row in rows)
            {
                dataGridView1.Rows.Add(
                   row.ProjectId,
                   row.ProjectNameVietnamese,
                   row.ProjectNameEnglish,
                   row.StartDate.ToString("dd/MM/yyyy"),
                   row.AffiliatedUnit?.AffiliatedUnitName,
                   row.Category?.CategoryName,
                   row.ApprovingAgency?.ApprovingAgencyName,
                   row.Counterparty?.CounterpartyName
                );
            }
        }

        public void SetDataSourceDonViTrucThuoc()
        {
            var entities = db.AffiliatedUnits.ToList();
            cbbDonViTrucThuoc.ValueMember = null;
            cbbDonViTrucThuoc.DisplayMember = "AffiliatedUnitName";
            cbbDonViTrucThuoc.DataSource = entities;
            cbbDonViTrucThuoc.Text = "";
        }
        public void SetDataSourceDanhMuc()
        {
            var entities = db.Categories.ToList();
            cbbDanhMuc.ValueMember = null;
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.DataSource = entities;
            cbbDanhMuc.Text = "";
        }
        public void SetDataSourceCoQuanPheDuyet()
        {
            var entities = db.ApprovingAgencies.ToList();
            cbbCoQuanPheDuyet.ValueMember = null;
            cbbCoQuanPheDuyet.DisplayMember = "ApprovingAgencyName";
            cbbCoQuanPheDuyet.DataSource = entities;
            cbbCoQuanPheDuyet.Text = "";
        }
        public void SetDataSourceDoiTac()
        {
            var entities = db.Counterparties.ToList();
            cbbDoiTac.ValueMember = null;
            cbbDoiTac.DisplayMember = "CounterpartyName";
            cbbDoiTac.DataSource = entities;
            cbbDoiTac.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var projects = _initialProjects;

            if (cbbStatus.SelectedIndex == 0)
            {
                projects = projects.Where(e => e.IsEnd == false);               
            }
            else if (cbbStatus.SelectedIndex == 1)
            {
                projects = projects.Where(e => e.IsEnd == true);
            }

            if (chVietName.Checked)
            {
                projects = projects.Where(e => e.ProjectNameVietnamese.Contains(txtVn.Text));
            }
            if (chEngName.Checked)
            {
                projects = projects.Where(e => e.ProjectNameEnglish.Contains(txtEng.Text));
            }
            if (chDvtt.Checked)
            {
                var condition = (AffiliatedUnit)cbbDonViTrucThuoc.SelectedItem;
                projects = projects.Where(e => e.AffiliatedUnitId == condition.AffiliatedUnitId);
            }
            if (chDm.Checked)
            {
                var condition = (Category)cbbDanhMuc.SelectedItem;
                projects = projects.Where(e => e.CategoryId == condition.CategoryId);
            }
            if (chCqpd.Checked)
            {
                var condition = (ApprovingAgency)cbbCoQuanPheDuyet.SelectedItem;
                projects = projects.Where(e => e.ApprovingAgencyId == condition.ApprovingAgencyId);
            }
            if (chDt.Checked)
            {
                var condition = (Counterparty)cbbDoiTac.SelectedItem;
                projects = projects.Where(e => e.CounterpartyId == condition.CounterpartyId);
            }
            if (chStartDate.Checked)
            {
                DateTime tuNgay = dateBdTu.Value.Date;
                DateTime denNgay = dateBdDen.Value.Date;
                projects = projects.Where(e =>
                {
                    return DateTime.Compare(e.StartDate, tuNgay) >= 0
                    && DateTime.Compare(e.StartDate, denNgay) <= 0;
                });
            }

            if (chEndDate.Checked)
            {
                DateTime tuNgay = dateKtTu.Value.Date;
                DateTime denNgay = dateKtDen.Value.Date;
                projects = projects.Where(e =>
                {
                    return DateTime.Compare(e.EndDate, tuNgay) >= 0
                    && DateTime.Compare(e.EndDate, denNgay) <= 0;
                });
            }

            LoadData(projects);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData(_initialProjects);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
