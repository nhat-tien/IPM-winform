using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
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
using IPM_winform.Services;
using System.Diagnostics;
using IPM_winform.Controls;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace IPM_winform.IPM.Views.DuAn
{
    public partial class ProjectIndexFriendlyUI : Form
    {
        private readonly MyProjectForm _parentView;
        private IEnumerable<Participation> _rows;
        public ProjectIndexFriendlyUI(MyProjectForm parentView, IEnumerable<Participation> rows)
        {
            InitializeComponent();
            _parentView = parentView;
            _rows = rows;
        }

        public void Reload()
        {
            _rows = _parentView.RowsParticipation();
            flowLayoutPanel1.Controls.Clear();
            foreach (var part in _rows)
            {
                var row = part.Project;
                if (row.IsEnd)
                {
                    continue;
                }
                flowLayoutPanel1.Controls.Add(new ProjectBlock()
                {
                    ProjectName = row.ProjectNameVietnamese,
                    Description = row.Description,
                    AffiliatedUnit = row.AffiliatedUnit?.AffiliatedUnitName,
                    Memeber = row.Participations.Count().ToString(),
                    File = row.Files.Count().ToString(),
                    OnView = () =>
                    {
                        _parentView.GoToUpdate(row.ProjectId);
                    },
                    OnDelete = () =>
                    {
                        _parentView.OnDelete(row.ProjectId);
                        Reload();
                    },
                    OnEnd = () =>
                    {
                        _parentView.OnEndProject(row.ProjectId);
                        Reload();
                    },
                    Owner = part.Owner,
                    IsEnd = row.IsEnd,
                });
            }
        }

        private void ProjectIndexFriendlyUI_Load(object sender, EventArgs e)
        {
            Reload();

            if (Services.Author.IsUser())
            {
                btnAdd.Visible = false;
                groupBox1.Visible = false;
            }
        }

        private void OnChange(object sender, EventArgs e)
        {
            bool sortEnd = rdEnd.Checked;
            _rows = _parentView.RowsParticipation();
            flowLayoutPanel1.Controls.Clear();
            foreach (var part in _rows)
            {

                var row = part.Project;

                if (sortEnd)
                {
                    if (!row.IsEnd)
                    {
                        continue;
                    };
                }
                else
                {
                    if (row.IsEnd)
                    {
                        continue;
                    };
                }


                flowLayoutPanel1.Controls.Add(new ProjectBlock()
                {
                    ProjectName = row.ProjectNameVietnamese,
                    Description = row.Description,
                    AffiliatedUnit = row.AffiliatedUnit?.AffiliatedUnitName,
                    Memeber = row.Participations.Count().ToString(),
                    File = row.Files.Count().ToString(),
                    OnView = () =>
                       {
                           _parentView.GoToUpdate(row.ProjectId);
                       },
                    OnDelete = () =>
                    {
                        _parentView.OnDelete(row.ProjectId);
                        Reload();
                    },
                    Owner = part.Owner,
                    IsEnd = row.IsEnd,
                });


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parentView.GoToInsert();
        }
    }
}
