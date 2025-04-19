using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using IPM_winform.Dtos;
using Microsoft.EntityFrameworkCore;
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

namespace IPM_winform.IPM.Views.GenericForm
{
    public partial class IndexForm : Form, IIndexForm
    {
        private readonly FormContainer _parentView;

        private readonly DataGridViewTextBoxColumn[] _columns;
        public IndexForm(FormContainer parentView, IEnumerable<TableDto> rows)
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
            btnDelete.BackColor = System.Drawing.Color.FromArgb(40, 247, 56, 56);
        }
        private void EnableDeleteBtn()
        {
            btnDelete.Enabled = true;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(247, 56, 56);
        }

        private void DisableEditBtn()
        {
            btnEdit.Enabled = false;
            btnEdit.BackColor = System.Drawing.Color.FromArgb(40, 247, 155, 56);
        }
        private void EnableEditBtn()
        {
            btnEdit.Enabled = true;
            btnEdit.BackColor = System.Drawing.Color.FromArgb(247, 155, 56);
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

        public void LoadData(IEnumerable<TableDto> rows)
        {
            dataGridView1.Rows.Clear();
            foreach (var row in rows)
            {
                dataGridView1.Rows.Add(
                   row.Id,
                   row.Name
                );
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                _parentView.OnCreate(r[_parentView.InsertLabel].ToString());
                            }
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _parentView.Reload();
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
                    table.Columns.AddRange(new DataColumn[2] {
                        new DataColumn("Id", typeof(int)),
                        new DataColumn(_parentView.InsertLabel, typeof(string))
                    });
                    var loaiSanPham = _parentView.Rows();
                    if (loaiSanPham != null)
                    {
                        foreach (var p in loaiSanPham)
                            table.Rows.Add(p.Id, p.Name);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim();
            if(searchText is null || searchText.Length <= 0)
            {
                _parentView.Reload();
                return;
            }    
            dataGridView1.Rows.Clear();          
            var rows = _parentView.Rows().Where(e => e.Name.Contains(txtSearch.Text));
            foreach (var row in rows)
            {
                dataGridView1.Rows.Add(
                   row.Id,
                   row.Name
                );
            };
        }
    }
}
