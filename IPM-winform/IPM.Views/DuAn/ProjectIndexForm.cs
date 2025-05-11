using ClosedXML.Excel;
using IPM_winform.Dtos;
using IPM_winform.IPM.Infrastructure.Entities;
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

namespace IPM_winform.IPM.Views.DuAn
{
    public partial class ProjectIndexForm : Form
    {
        private readonly ProjectForm _parentView;

        private readonly DataGridViewTextBoxColumn[] _columns;
        public ProjectIndexForm(ProjectForm parentView, IEnumerable<Project> rows)
        {
            InitializeComponent();
            _parentView = parentView;
            _columns = _parentView.Columns;
            setUpDataGridViewColumn();
            LoadData(rows);
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

        

        private void DisableViewBtn()
        {
            btnView.Enabled = false;
            btnView.BackColor = Color.FromArgb(40, 247, 155, 56);
        }
        private void EnableViewBtn()
        {
            btnView.Enabled = true;
            btnView.BackColor = Color.FromArgb(27, 161, 22);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int numOfRowSelected = dataGridView1.SelectedRows.Count;
            if (numOfRowSelected > 1)
            {
                EnableDeleteBtn();                
                DisableViewBtn();
            }
            else if (numOfRowSelected == 1)
            {
                EnableDeleteBtn();         
                EnableViewBtn();
            }
            else
            {
                DisableDeleteBtn();
                DisableViewBtn();
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

        private void button1_Click(object sender, EventArgs e)
        {
            _parentView.GoToAdvanceSearch();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = _parentView.Label + "_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("Id", typeof(int)),
                        new DataColumn("Tên Tiếng Việt", typeof(string)),
                        new DataColumn("Tên Tiếng Anh", typeof(string)),
                        new DataColumn("Mục tiêu", typeof(string)),
                        new DataColumn("Nội dung", typeof(string)),
                        new DataColumn("Đơn vị trực thuộc", typeof(string)),
                        new DataColumn("Danh mục", typeof(string)),
                        new DataColumn("Cơ quan phê duyệt", typeof(string)),
                        new DataColumn("Đối tác", typeof(string)),
                        new DataColumn("Ngày bắt đầu", typeof(string)),
                        new DataColumn("Ngày kết thúc", typeof(string)),
                    });
                    var loaiSanPham = _parentView.RowsProject();
                    if (loaiSanPham != null)
                    {
                        foreach (var p in loaiSanPham)
                            table.Rows.Add(
                                p.ProjectId,
                                p.ProjectNameVietnamese,
                                p.ProjectNameEnglish,
                                p.ProjectPurpose,
                                p.Content,
                                p.AffiliatedUnit?.AffiliatedUnitName,
                                p.Category?.CategoryName,
                                p.ApprovingAgency?.ApprovingAgencyName,
                                p.Counterparty?.CounterpartyName,
                                p.StartDate.ToString("dd/MM/yyyy"),
                                p.EndDate.ToString("dd/MM/yyyy")
                            );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, _parentView.Label);
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new ProjectViewForm(_parentView, Int32.Parse(GetSelectedRowId())));
        }
    }
}
