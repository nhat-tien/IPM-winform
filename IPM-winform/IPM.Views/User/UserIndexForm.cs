using ClosedXML.Excel;
using IPM_winform.Dtos;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
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
        private readonly UserManager userManager = new UserManager();
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
            _parentView.GoToUpdateUser(Int32.Parse(GetSelectedRowId()));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBExceptionHandler.Handle(() =>
            {
                _parentView.OnDelete(Int32.Parse(GetSelectedRowId()));
                Reload();
            });
        }

        public void Reload()
        {
            LoadData(_parentView.RowsUser());
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
                    table.Columns.AddRange(new DataColumn[10] {
                        new DataColumn("Id", typeof(int)),
                        new DataColumn("Họ lót", typeof(string)),
                        new DataColumn("Tên", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("Số điện thoại", typeof(string)),
                        new DataColumn("Chức vụ", typeof(string)),
                        new DataColumn("Đơn vị trực thuộc", typeof(string)),
                        new DataColumn("Vai trò", typeof(string)),
                        new DataColumn("Giới tính", typeof(string)),
                        new DataColumn("Địa chỉ", typeof(string)),
                    });
                    var users = _parentView.RowsUser();
                    if (users != null)
                    {
                        foreach (var p in users)
                            table.Rows.Add(
                                p.UserId,
                                p.LastName,
                                p.FirstName,
                                p.Email,
                                p.PhoneNumber,
                                p.Position?.PositionName,
                                p.AffiliatedUnit?.AffiliatedUnitName,
                                p.Role,
                                p.Sex == Sex.FEMALE ? "Nữ" : "Nam"
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
                                userManager.CreateUser(new Infrastructure.Entities.User() {
                                    LastName = r["Họ lót"].ToString(),
                                    FirstName = r["Tên"].ToString(),
                                    Email = r["Email"].ToString(),
                                    PhoneNumber = r["Số điện thoại"].ToString(),
                                    Role = r["Vai trò"].ToString() ?? "User",
                                    Sex = r["Giới tính"].ToString() == "Nam" ? Sex.MALE : Sex.FEMALE,
                                    Address = r["Địa chỉ"].ToString(),
                                    Password = r["Password"].ToString() ?? "123456"
                                });
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
    }
}
