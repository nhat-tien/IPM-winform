using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.Reports
{
    public partial class ChiTietDuAnForm : Form
    {
        IPMDataSet.DanhSachDuAnDataTable danhSachDuAnDataTable = new IPMDataSet.DanhSachDuAnDataTable();
        string reportsFolder = Application.StartupPath.Replace("\\bin\\Debug\\net8.0-windows", "\\Reports");
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        private int _id;
        public ChiTietDuAnForm(int id)
        {
            InitializeComponent();
            _id = id;
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDuAn.rdlc");
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.SetPageSettings(new System.Drawing.Printing.PageSettings()
            {
                Landscape = false,
                Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10),
                PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169)
            });
        }

        private void DanhSachDuAnForm_Load(object sender, EventArgs e)
        {
            SetDataSourceCoQuanPheDuyet();
            SetDataSourceDanhMuc();
            SetDataSourceDoiTac();
            SetDataSourceDonViTrucThuoc();
            var danhSachDuAn = db.Projects
                .Include(e => e.AffiliatedUnit)
                .Include(e => e.ApprovingAgency)
                .Include(e => e.Category)
                .Include(e => e.Counterparty)
                .ToList();
            LoadDataToReport(danhSachDuAn);
           
        }

        private void LoadDataToReport(List<Project> danhSachDuAn, string desc = "Tất cả dự án")
        {
            danhSachDuAnDataTable.Clear();
            foreach (var row in danhSachDuAn)
            {
                danhSachDuAnDataTable.AddDanhSachDuAnRow(
                row.ProjectId,
                row.ProjectNameVietnamese,
                row.ProjectNameEnglish,
                row.ProjectPurpose,
                row.Description,
                row.Content,
                row.StartDate.ToString("dd/MM/yyyy"),
                row.EndDate.ToString("dd/MM/yyyy"),
                row.AffiliatedUnit?.AffiliatedUnitName,
                row.Category?.CategoryName,
                row.ApprovingAgency?.ApprovingAgencyName,
                row.Counterparty?.CounterpartyName
                );
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachDuAn";
            reportDataSource.Value = danhSachDuAnDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", desc);
            reportViewer1.LocalReport.SetParameters(reportParameter);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            IEnumerable<Project> projects = db.Projects
               .Include(e => e.AffiliatedUnit)
               .Include(e => e.ApprovingAgency)
               .Include(e => e.Category)
               .Include(e => e.Counterparty)
               .ToList();
            string condition = "";
            if (cbbStatus.SelectedIndex == 0)
            {
                projects = projects.Where(e => e.IsEnd == false);
                condition += "- Dự án đang tiến hành\n";
            }
            else if (cbbStatus.SelectedIndex == 1)
            {
                projects = projects.Where(e => e.IsEnd == true);
                condition += "- Dự án đã kết thúc\n";
            }


            if (chNgayBatDau.Checked)
            {
                DateTime tuNgay = datebdTu.Value.Date;
                DateTime denNgay = datebdDen.Value.Date;
                projects = projects.Where(e =>
                {
                    return DateTime.Compare(e.StartDate, tuNgay) >= 0
                    && DateTime.Compare(e.StartDate, denNgay) <= 0;
                });
                condition += $"- Ngày bắt đầu từ {tuNgay.ToString("dd/MM/yyyy")} đến {denNgay.ToString("dd/MM/yyyy")}\n";
            }

            if (chNgayKetThuc.Checked)
            {
                DateTime tuNgay = datektTu.Value.Date;
                DateTime denNgay = datektDen.Value.Date;
                projects = projects.Where(e =>
                {
                    return DateTime.Compare(e.EndDate, tuNgay) >= 0
                    && DateTime.Compare(e.EndDate, denNgay) <= 0;
                });
                condition += $"- Ngày kết thúc từ {tuNgay.ToString("dd/MM/yyyy")} đến {denNgay.ToString("dd/MM/yyyy")}\n";
            }

            if(chDvtt.Checked)
            {
                var selectedItem = (AffiliatedUnit)cbbDonViTrucThuoc.SelectedItem;
                projects = projects.Where(e => e.AffiliatedUnitId == selectedItem?.AffiliatedUnitId);
                condition += $"- Đơn vị trực thuộc: {selectedItem?.AffiliatedUnitName}\n";
            }
            if (chDm.Checked)
            {
                var selectedItem = (Category)cbbDanhMuc.SelectedItem;
                projects = projects.Where(e => e.CategoryId == selectedItem?.CategoryId);
                condition += $"- Danh mục: {selectedItem?.CategoryName}\n";
            }
            if (chDt.Checked)
            {
                var selectedItem = (Counterparty)cbbDoiTac.SelectedItem;
                projects = projects.Where(e => e.CounterpartyId == selectedItem?.CounterpartyId);
                condition += $"- Đối tác: {selectedItem?.CounterpartyName}\n";
            }
            if (chCqpd.Checked)
            {
                var selectedItem = (ApprovingAgency)cbbCoQuanPheDuyet.SelectedItem;
                projects = projects.Where(e => e.ApprovingAgencyId == selectedItem?.ApprovingAgencyId);
                condition += $"- Cơ quan phê duyệt: {selectedItem?.ApprovingAgencyId}\n";
            }

            LoadDataToReport(projects.ToList(),condition);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var projects = db.Projects
              .Include(e => e.AffiliatedUnit)
              .Include(e => e.ApprovingAgency)
              .Include(e => e.Category)
              .Include(e => e.Counterparty)
              .ToList();
            LoadDataToReport(projects, "(Tất cả sản phẩm)");
        }
    }
}
