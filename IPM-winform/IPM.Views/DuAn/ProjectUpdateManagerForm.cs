using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Controls;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.DuAn
{
    public partial class ProjectUpdateManagerForm : Form
    {

        private readonly ProjectForm _parentView;
        private readonly int _id;
        private List<Infrastructure.Entities.User> _users = [];
        private List<Infrastructure.Entities.User> _participate = [];
        private List<Infrastructure.Entities.User> _addParticipate = [];
        private List<Infrastructure.Entities.User> _deleteParticipate = [];
        private int _ownerId;
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public ProjectUpdateManagerForm(ProjectForm parentView, int id)
        {
            InitializeComponent();
            _parentView = parentView;
            _id = id;
            SetData();
            LoadDataUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addParticipates = _addParticipate.Select(e =>
            {
                {
                    return new Participation()
                    {
                        ProjectId = _id,
                        UserId = e.UserId,
                        Owner = false
                    };
                }
            });

            var deleteParticipates = _deleteParticipate.Select(e =>
            {
                {
                    return new Participation()
                    {
                        UserId = e.UserId,
                        Owner = false
                    };
                }
            });

            var project = db.Projects.Single(e => e.ProjectId == _id);
            if (project is null)
            {
                return;
            };

            project.ProjectNameVietnamese = txtProjectNameVn.Text;
            project.ProjectNameEnglish = txtProjectNameEng.Text;
            project.ProjectPurpose = txtMucTieu.Text;
            project.Content = txtContent.Text;
            project.Description = txtDesc.Text;
            project.AffiliatedUnit = (AffiliatedUnit)cbbDonViTrucThuoc.SelectedItem;
            project.Category = (Category)cbbDanhMuc.SelectedItem;
            project.ApprovingAgency = (ApprovingAgency)cbbCoQuanPheDuyet.SelectedItem;
            project.Counterparty = (Counterparty)cbbDoiTac.SelectedItem;
            project.StartDate = startedDate.Value.Date;

            db.Projects.Update(project);

            db.Participations.AddRange(addParticipates);

            foreach (var participation in deleteParticipates)
            {
                db.Participations
                    .Where(e => e.UserId == participation.UserId)
                    .Where(e => e.ProjectId == _id)
                    .ExecuteDelete();
            }

            db.SaveChanges();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.GoToIndex();
        }



        public void SetData()
        {
            var dvtt = db.AffiliatedUnits.ToList();
            cbbDonViTrucThuoc.ValueMember = null;
            cbbDonViTrucThuoc.DisplayMember = "AffiliatedUnitName";
            cbbDonViTrucThuoc.DataSource = dvtt;

            var dm = db.Categories.ToList();
            cbbDanhMuc.ValueMember = null;
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.DataSource = dm;

            var cqpd = db.ApprovingAgencies.ToList();
            cbbCoQuanPheDuyet.ValueMember = null;
            cbbCoQuanPheDuyet.DisplayMember = "ApprovingAgencyName";
            cbbCoQuanPheDuyet.DataSource = cqpd;


            var dt = db.Counterparties.ToList();
            cbbDoiTac.ValueMember = null;
            cbbDoiTac.DisplayMember = "CounterpartyName";
            cbbDoiTac.DataSource = dt;

            var project = db.Projects
               .AsNoTracking()
              .Include(e => e.ApprovingAgency)
              .Include(e => e.AffiliatedUnit)
              .Include(e => e.Category)
              .Include(e => e.Counterparty)
              .Include(e => e.Files)
              .ThenInclude(e => e.User)
              .Include(e => e.Participations)
              .ThenInclude(e => e.User)
              .Where(e => e.ProjectId == _id)
              .FirstOrDefault();

            if (project is null)
            {
                return;
            }

            txtProjectNameVn.Text = project.ProjectNameVietnamese;
            txtProjectNameEng.Text = project.ProjectNameEnglish;
            startedDate.Value = project.StartDate;
            txtMucTieu.Text = project.ProjectPurpose;
            txtContent.Text = project.Content;
            txtDesc.Text = project.Description;
            cbbDonViTrucThuoc.SelectedItem = dvtt.FirstOrDefault(e => e.AffiliatedUnitId == project.AffiliatedUnitId);
            cbbDanhMuc.SelectedItem = dm.FirstOrDefault(e => e.CategoryId == project.CategoryId);
            cbbCoQuanPheDuyet.SelectedItem = cqpd.FirstOrDefault(e => e.ApprovingAgencyId == project.ApprovingAgencyId); ;
            cbbDoiTac.SelectedItem = dt.FirstOrDefault(e => e.CounterpartyId == project.CounterpartyId);

            var owner = project.Participations.FirstOrDefault(e => e.Owner);
            if(owner is not null)
            {
                _ownerId = owner.UserId;
            }
            var user = project.Participations.Select(e => e.User).ToList();
            var userIds = user.Select(e => e.UserId).ToList();
            _users = db.Users.Where(e => !userIds.Contains(e.UserId)).ToList();
            _participate = user;
        }

        public void LoadDataUser()
        {
            flowLayoutPanel3.Controls.Clear();
            foreach (var row in _users)
            {
                flowLayoutPanel3.Controls.Add(
                   new UserBlock()
                   {
                       Id = row.UserId,
                       Name = row.LastName + " " + row.FirstName,
                       Email = row.Email,
                       AvatarUrl = row.AvatarUrl
                   }

                );
            }

            flowLayoutPanel4.Controls.Clear();
            foreach (var row in _participate)
            {
                flowLayoutPanel4.Controls.Add(
                   new UserBlock()
                   {
                       Id = row.UserId,
                       Name = row.LastName + " " + row.FirstName,
                       Email = row.Email,
                       AvatarUrl = row.AvatarUrl,
                       Owner = _ownerId == row.UserId
                   }

                );
            }
        }




        //private void btnMoveIn_Click(object sender, EventArgs e)
        //{
        //    var user = _users.Find(e => e.UserId == Int32.Parse(GetSelectedRowId2()));
        //    _users = _users.Where(e => e.UserId != user.UserId).ToList();
        //    _addParticipate.Add(user);
        //    _participate.Add(user);
        //    LoadDataUser();
        //}

        //private void btnMoveOut_Click(object sender, EventArgs e)
        //{
        //    var currentUser = Session.getSession();
        //    var selectUserId = Int32.Parse(GetSelectedRowId3());
        //    if (selectUserId == currentUser.UserId)
        //    {
        //        MessageBox.Show("Không thể loại bỏ chủ dự án", "Thao tác không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    var user = _participate.Find(e => e.UserId == selectUserId);
        //    _participate = _participate.Where(e => e.UserId != user.UserId).ToList();

        //    if(_addParticipate.Any(e => e.UserId == user.UserId))
        //    {
        //        _addParticipate = _addParticipate.Where(e => e.UserId != user.UserId).ToList();
        //    } else
        //    {
        //        _deleteParticipate.Add(user);
        //    };

        //    _users.Add(user);
        //    LoadDataUser();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length <= 0)
            {
                LoadDataUser();
                return;
            }
            var searchText = txtSearch.Text.Trim();

            var filterUser = _users.Where(e =>
            {
                return e.FirstName.Contains(searchText) || e.LastName.Contains(searchText) || e.Email.Contains(searchText);
            });
            flowLayoutPanel3.Controls.Clear();
            foreach (var row in filterUser)
            {
                flowLayoutPanel3.Controls.Add(
                   new UserBlock()
                   {
                       Id = row.UserId,
                       Name = row.LastName + " " + row.FirstName,
                       Email = row.Email,
                       AvatarUrl = row.AvatarUrl
                   }

                );
            }
        }
        private void flowLayoutPanel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(UserBlock)))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void flowLayoutPanel4_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(UserBlock)))
            {

                UserBlock control = (UserBlock)e.Data.GetData(typeof(UserBlock));

                var user = _users.Find(e => e.UserId == control.Id);

                if (user == null)
                {
                    return;
                }

                _users = _users.Where(e => e.UserId != user.UserId).ToList();
                _addParticipate.Add(user);
                _participate.Add(user);
                LoadDataUser();

            }
        }

        private void flowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(UserBlock)))
            {

                UserBlock control = (UserBlock)e.Data.GetData(typeof(UserBlock));

                var selectUserId = control.Id;

                if (control.Owner)
                {
                    MessageBox.Show("Không thể loại bỏ chủ dự án", "Thao tác không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = _participate.Find(e => e.UserId == selectUserId);

                if (user == null)
                {
                    return;
                }

                _participate = _participate.Where(e => e.UserId != user.UserId).ToList();

                if (_addParticipate.Any(e => e.UserId == user.UserId))
                {
                    _addParticipate = _addParticipate.Where(e => e.UserId != user.UserId).ToList();
                }
                else
                {
                    _deleteParticipate.Add(user);
                };

                _users.Add(user);
                LoadDataUser();
            }
        }

        private void flowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(UserBlock)))
            {
                e.Effect = DragDropEffects.Copy;
            }





        }
    }

}
