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
        IPMDataSet.FileDataTable FileDataTable = new IPMDataSet.FileDataTable();
        IPMDataSet.ThanhVienDataTable ThanhVienDataTable = new IPMDataSet.ThanhVienDataTable();
        string reportsFolder = Application.StartupPath.Replace("\\bin\\Debug\\net8.0-windows", "\\Reports");
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        private int _id;
        public ChiTietDuAnForm(int id)
        {
            InitializeComponent();
            _id = id;
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "ChiTietDuAn.rdlc");
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
            var duAn = db.Projects
                .Include(e => e.AffiliatedUnit)
                .Include(e => e.ApprovingAgency)
                .Include(e => e.Category)
                .Include(e => e.Counterparty)
                .Include(e => e.Files)
                .Include(e => e.Participations)
                .ThenInclude(e => e.User)
                .Where(e => e.ProjectId == _id)
                .FirstOrDefault();
            if (duAn is null)
            {
                return;
            }
            LoadDataToReport(duAn);
        }

        private void LoadDataToReport(Project duAn)
        {


            IList<ReportParameter> param = new List<ReportParameter>
                {
                new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}",
                DateTime.Now.Day,
                DateTime.Now.Month,
                DateTime.Now.Year)),
                new ReportParameter("TenDuAnViet", duAn.ProjectNameVietnamese),
                new ReportParameter("TenDuAnEng", duAn.ProjectNameEnglish),
                new ReportParameter("DonViTrucThuoc", duAn.AffiliatedUnit?.AffiliatedUnitName),
                new ReportParameter("DanhMuc", duAn.Category?.CategoryName),
                new ReportParameter("CoQuanPheDuyet", duAn.ApprovingAgency?.ApprovingAgencyName),
                new ReportParameter("DoiTac", duAn.Counterparty?.CounterpartyName),
                new ReportParameter("MoTa", duAn.Description),
                new ReportParameter("MucTieu", duAn.ProjectPurpose),
                new ReportParameter("NoiDung", duAn.Content),
                };

            reportViewer1.LocalReport.SetParameters(param);

            foreach(var thanhVien in duAn.Participations)
            {
                ThanhVienDataTable.AddThanhVienRow(
                    thanhVien.User?.LastName,
                    thanhVien.User?.FirstName,
                    thanhVien.User?.Email,
                    thanhVien.Owner
                );
            }
           
            ReportDataSource reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "ThanhVien";
            reportDataSource1.Value = ThanhVienDataTable;

            foreach (var file in duAn.Files)
            {
                FileDataTable.AddFileRow(
                    file.FileName
                );
            }

            ReportDataSource reportDataSource2 = new ReportDataSource();
            reportDataSource2.Name = "File";
            reportDataSource2.Value = FileDataTable;


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            reportViewer1.RefreshReport();
        }


    }
}
