using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Controls;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.Services;
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
    public partial class ProjectAddForm : Form
    {

        private readonly ProjectForm _parentView;
        private List<Infrastructure.Entities.User> _users = [];
        private List<Infrastructure.Entities.User> _participate = [];
        private List<Infrastructure.Entities.File> _file = [];
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public ProjectAddForm(ProjectForm parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            SetDataSourceCoQuanPheDuyet();
            SetDataSourceDanhMuc();
            SetDataSourceDoiTac();
            SetDataSourceDonViTrucThuoc();
            SetDataSourceUser();
            LoadDataUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var currentUser = Session.getSession();
            var participates = _participate.Select(e =>
            {
                if (e.UserId == currentUser.UserId)
                {
                    return new Participation()
                    {
                        UserId = e.UserId,
                        Owner = true
                    };
                }
                else
                {
                    return new Participation()
                    {
                        UserId = e.UserId,
                        Owner = false
                    };
                }
            }
             );

            var project = new Infrastructure.Entities.Project()
            {
                ProjectNameVietnamese = txtProjectNameVn.Text,
                ProjectNameEnglish = txtProjectNameEng.Text,
                ProjectPurpose = txtMucTieu.Text,
                Content = txtContent.Text,
                AffiliatedUnit = (AffiliatedUnit)cbbDonViTrucThuoc.SelectedItem,
                Category = (Category)cbbDanhMuc.SelectedItem,
                ApprovingAgency = (ApprovingAgency)cbbCoQuanPheDuyet.SelectedItem,
                Counterparty = (Counterparty)cbbDoiTac.SelectedItem,
                Participations = participates.ToList(),
                Files = UploadFile(),
                Description = txtDesc.Text,
                StartDate = startedDate.Value.Date
            };
            db.Projects.Add(project);
            db.SaveChanges();
            Reset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.GoToIndex();
        }

        public void SetDataSourceDonViTrucThuoc()
        {
            var entities = db.AffiliatedUnits.ToList();
            cbbDonViTrucThuoc.ValueMember = null;
            cbbDonViTrucThuoc.DisplayMember = "AffiliatedUnitName";
            cbbDonViTrucThuoc.DataSource = entities;
        }
        public void SetDataSourceDanhMuc()
        {
            var entities = db.Categories.ToList();
            cbbDanhMuc.ValueMember = null;
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.DataSource = entities;
        }
        public void SetDataSourceCoQuanPheDuyet()
        {
            var entities = db.ApprovingAgencies.ToList();
            cbbCoQuanPheDuyet.ValueMember = null;
            cbbCoQuanPheDuyet.DisplayMember = "ApprovingAgencyName";
            cbbCoQuanPheDuyet.DataSource = entities;
        }
        public void SetDataSourceDoiTac()
        {
            var entities = db.Counterparties.ToList();
            cbbDoiTac.ValueMember = null;
            cbbDoiTac.DisplayMember = "CounterpartyName";
            cbbDoiTac.DataSource = entities;
        }

        public void SetDataSourceUser()
        {
            var currentUser = Session.getSession();
            _users = db.Users.Where(e => e.UserId != currentUser.UserId).ToList();
            _participate.Add(currentUser);
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
                       AvatarUrl = row.AvatarUrl
                   }

                );
            }

        }

        private void Reset()
        {
            txtProjectNameVn.Text = "";
            txtProjectNameEng.Text = "";
            txtMucTieu.Text = "";
            txtContent.Text = "";
            cbbDonViTrucThuoc.SelectedIndex = 0;
            cbbDanhMuc.SelectedIndex = 0;
            cbbCoQuanPheDuyet.SelectedIndex = 0;
            cbbDoiTac.SelectedIndex = 0;
            _participate = [];
            _file = [];
            txtDesc.Text = "";
            startedDate.Value = DateTime.Now;
            SetDataSourceUser();
            LoadDataUser();
            ReloadFile();
        }

        //private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        //{
        //    int numOfRowSelected = dataGridView2.SelectedRows.Count;

        //    if (numOfRowSelected == 1)
        //    {
        //        btnMoveIn.Enabled = true;
        //    }
        //    else
        //    {
        //        btnMoveIn.Enabled = false;
        //    }
        //}

        //private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        //{
        //    int numOfRowSelected = dataGridView3.SelectedRows.Count;

        //    if (numOfRowSelected == 1)
        //    {
        //        btnMoveOut.Enabled = true;
        //    }
        //    else
        //    {
        //        btnMoveOut.Enabled = false;
        //    }
        //}

        //public string GetSelectedRowId2()
        //{
        //    var row = dataGridView2.SelectedRows;
        //    return row[0].Cells[0].Value.ToString() ?? "";
        //}

        //public string GetSelectedRowId3()
        //{
        //    var row = dataGridView3.SelectedRows;
        //    return row[0].Cells[0].Value.ToString() ?? "";
        //}


        private void btnMoveIn_Click(object sender, EventArgs e)
        {
            //    var user = _users.Find(e => e.UserId == Int32.Parse(GetSelectedRowId2()));
            //    _users = _users.Where(e => e.UserId != user.UserId).ToList();
            //    _participate.Add(user);
            //    LoadDataUser();
        }

        private void btnMoveOut_Click(object sender, EventArgs e)
        {
            //    var currentUser = Session.getSession();
            //    var selectUserId = Int32.Parse(GetSelectedRowId3());
            //    if (selectUserId == currentUser.UserId)
            //    {
            //        MessageBox.Show("Không thể loại bỏ chủ dự án", "Thao tác không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    var user = _participate.Find(e => e.UserId == selectUserId);
            //    _participate = _participate.Where(e => e.UserId != user.UserId).ToList();
            //    _users.Add(user);
            //    LoadDataUser();
        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = ofd.FileName;
                    _file.Add(new Infrastructure.Entities.File()
                    {
                        FileName = Path.GetFileName(sourceFile),
                        ObjectName = sourceFile,
                    });
                    ReloadFile();
                }
            }
        }

        private void ReloadFile()
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (var row in _file)
            {
                flowLayoutPanel2.Controls.Add(
                  new FileBlock()
                  {
                      FileName = row.FileName
                  }
               );
            }
        }

        
        private List<Infrastructure.Entities.File> UploadFile()
        {
            var currentUser = Session.getSession();
            string destinationDir = @"C:\IPM-winform\Data\files\";
            List<Infrastructure.Entities.File> returnFile = new List<Infrastructure.Entities.File>();

            foreach (var file in _file)
            {
                string sourceFile = file.ObjectName;
                string fileName = Path.GetFileNameWithoutExtension(sourceFile) + DateTime.Now.ToString("ddMMyyyyHHmmss") + Path.GetExtension(sourceFile);
                string destinationPath = Path.Combine(destinationDir, fileName);
                try
                {
                    if (!Directory.Exists(destinationDir))
                    {
                        Directory.CreateDirectory(destinationDir);
                    }
                    System.IO.File.Copy(sourceFile, destinationPath, true);

                    returnFile.Add(new Infrastructure.Entities.File()
                    {
                        FileName = fileName,
                        ObjectName = destinationPath,
                        User = currentUser,
                        Status = "done"
                    });


                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            return returnFile;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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
                _participate.Add(user);
                LoadDataUser();

            }
        }

        private void flowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(UserBlock)))
            {

                UserBlock control = (UserBlock)e.Data.GetData(typeof(UserBlock));

                var currentUser = Session.getSession();
                var selectUserId = control.Id;
                if (selectUserId == currentUser.UserId)
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

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    _file.Add(new Infrastructure.Entities.File()
                    {
                        FileName = Path.GetFileName(file),
                        ObjectName = file,
                    });
                }
                ReloadFile();
            }
        }
    }
}
