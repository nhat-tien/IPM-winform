//using QLGV.Presenters;
using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IPM_winform.IPM.Views
{
    public partial class Home : Form
    {
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        
        public Home()
        {
            InitializeComponent();
            SetUpCountProject();
            SetUpCountMyProject();
            SetUpCountUser();
            SetupStat();
        }

        private void SetUpCountProject()
        {
            int count = db.Projects.Count();
            label3.Text = count.ToString();

        }
        private void SetUpCountMyProject()
        {
            var user = Session.getSession();
            var count = db.Participations
                .Where(e => e.UserId == user.UserId)
                .Count();
            label5.Text = count.ToString();
        }

        private void SetUpCountUser()
        {
            var count = db.Users.Count();
            label4.Text = count.ToString();
        }

        private void SetupStat()
        {
            chart1.Titles.Add("Cơ cấu dự án theo đơn vị");

            var dvtts = db.AffiliatedUnits.ToList();
            Dictionary<string, string> map = new Dictionary<string, string>();

            foreach (var dvtt in dvtts)
            {
                int count = db.Projects.Where(e => e.AffiliatedUnitId == dvtt.AffiliatedUnitId).Count();
                map.Add(dvtt.AffiliatedUnitName ?? "", count.ToString());
            }


            foreach (var item in map)
            {
                if (item.Value == "0")
                {
                    continue;
                }
                chart1.Series["s1"].Points.AddXY(item.Key, item.Value);
            }

            foreach (DataPoint point in chart1.Series["s1"].Points)
            {
                point.Label = $"{point.AxisLabel}: {point.YValues[0]}";
            }
        }
    }
}
