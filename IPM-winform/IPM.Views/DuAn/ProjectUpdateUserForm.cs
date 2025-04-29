using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.Controls;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.Services;
using Microsoft.EntityFrameworkCore;
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
    public partial class ProjectUpdateUserForm : Form
    {

        private readonly ProjectForm _parentView;
        private readonly int _id;
        private List<Infrastructure.Entities.File> _file = [];
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public ProjectUpdateUserForm(ProjectForm parentView, int id)
        {
            InitializeComponent();
            _parentView = parentView;
            _id = id;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.GoToIndex();
        }

        



    

        private void ProjectUpdateUserForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var currentUser = Session.getSession();
            var project = db.Projects
                .AsNoTracking()
                .Include(e => e.ApprovingAgency)
                .Include(e => e.AffiliatedUnit)
                .Include(e => e.Category)
                .Include(e => e.Counterparty)
                .Include(e => e.Files)
                .ThenInclude(e => e.User)
                .Where(e => e.ProjectId == _id)
                .FirstOrDefault();

            if (project is null)
            {
                return;
            }

            label11.Text = project.ProjectNameVietnamese;
            label12.Text = project.ProjectNameEnglish;
            label13.Text = project.StartDate.ToString("dd/MM/yyyy");
            txtMucTieu.Text = project.ProjectPurpose;
            txtContent.Text = project.Content;
            label14.Text = project.AffiliatedUnit?.AffiliatedUnitName;
            label15.Text = project.Category?.CategoryName;
            label16.Text = project.ApprovingAgency?.ApprovingAgencyName;
            label17.Text = project.Counterparty?.CounterpartyName;

            flowLayoutPanel2.Controls.Clear();
            foreach (var file in project.Files)
            {
                if (file.User.UserId == currentUser.UserId)
                {
                    flowLayoutPanel2.Controls.Add(
                        new FileBlockWithUser()
                        {
                            Id = file.FileId,
                            FileName = file.FileName,
                            UserName = file.User.LastName + " " + file.User.FirstName,
                            Status = file.Status,
                            FileUrl = file.ObjectName,
                            OnDelete = DeleteFile
                        }
                        );
                }
            };

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
                    string sourceFile = file;
                    string destinationDir = @"C:\IPM-winform\Data\files\";
                    string fileName = Path.GetFileNameWithoutExtension(sourceFile) + DateTime.Now.ToString("ddMMyyyyHHmmss") + Path.GetExtension(sourceFile);
                    string destinationPath = Path.Combine(destinationDir, fileName);
                    try
                    {
                        if (!Directory.Exists(destinationDir))
                        {
                            Directory.CreateDirectory(destinationDir);
                        }
                        System.IO.File.Copy(sourceFile, destinationPath, true);

                        db.Files.Add(new Infrastructure.Entities.File()
                        {
                            FileName = fileName,
                            ObjectName = destinationPath,
                            ProjectId = _id,
                            UserId = Session.getSession().UserId,
                            Status = "wait"
                        });
                        db.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                    }

                }
                LoadData();
            }
        }

        private void DeleteFile(int id)
        {
            db.Files.Where(e => e.FileId == id).ExecuteDelete();
            LoadData();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = ofd.FileName;
                    string destinationDir = @"C:\IPM-winform\Data\files\";
                    string fileName = Path.GetFileNameWithoutExtension(sourceFile) + DateTime.Now.ToString("ddMMyyyyHHmmss") + Path.GetExtension(sourceFile);
                    string destinationPath = Path.Combine(destinationDir, fileName);
                        try
                        {
                            if (!Directory.Exists(destinationDir))
                            {
                                Directory.CreateDirectory(destinationDir);
                            }
                            System.IO.File.Copy(sourceFile, destinationPath, true);

                            db.Files.Add(new Infrastructure.Entities.File()
                            {
                                FileName = fileName,
                                ObjectName = destinationPath,
                                ProjectId = _id,
                                UserId = Session.getSession().UserId,
                                Status = "wait"
                            });
                            db.SaveChanges();

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.ToString());
                        }
                    }
                    flowLayoutPanel2.Controls.Clear();
                    LoadData();
                }
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //Delete
        //    if (e.ColumnIndex == 3)
        //    {
        //        DeleteFile(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
        //    };
        //}
    
}
