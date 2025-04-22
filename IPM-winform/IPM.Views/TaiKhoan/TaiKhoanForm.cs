using ClosedXML.Excel;
using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.TaiKhoan
{
    public partial class TaiKhoanForm : Form
    {
        private readonly IPM.Infrastructure.Entities.User? _userinfo;
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        private readonly Dashboard _parentView;
        public TaiKhoanForm(Dashboard parentView)
        {
            InitializeComponent();
            _userinfo = Session.getSession();
            _parentView = parentView;
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_userinfo is null)
            {
                return;
            }
            label2.Text = _userinfo.LastName;
            label3.Text = _userinfo.FirstName;
            label5.Text = _userinfo.Email;
            label7.Text = _userinfo.PhoneNumber;
            label9.Text = _userinfo.Sex == Infrastructure.Entities.Sex.MALE ? "Nam" : "Nữ";
            label11.Text = _userinfo.Role;
            label13.Text = _userinfo.Position?.PositionName;
            label15.Text = _userinfo.AffiliatedUnit?.AffiliatedUnitName;
            if (!String.IsNullOrEmpty(_userinfo.AvatarUrl))
            {
                pictureBox1.Image = Image.FromFile(_userinfo.AvatarUrl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Tải lên avatar";
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog.FileName;
                string destinationDir = @"C:\IPM-winform\Data\avatars\";
                string fileName = Path.GetFileNameWithoutExtension(sourceFile) + DateTime.Now.ToString("ddMMyyyyHHmmss") + Path.GetExtension(sourceFile);
                string destinationPath = Path.Combine(destinationDir, fileName);
                try
                {
                    if (!Directory.Exists(destinationDir))
                    {
                        Directory.CreateDirectory(destinationDir);
                    }
                    System.IO.File.Copy(sourceFile, destinationPath, true);

                    var user = db.Users.Find(_userinfo.UserId);
                    user.AvatarUrl = destinationPath;
                    db.Update(user);
                    db.SaveChanges();
                    LoadData();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new CapNhatTaiKhoanForm(_userinfo.UserId));
        }
    }
}
