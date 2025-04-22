using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.TaiKhoan
{
    public partial class CapNhatTaiKhoanForm : Form
    {
        private readonly UserManager userManager = new UserManager();
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        private readonly int _id;

        public CapNhatTaiKhoanForm(int id)
        {
            InitializeComponent();
            //label.Text = _parentView.InsertLabel;
            _id = id;
            //SetDataSourceChucVu();
            //SetDataSourceDonViTrucThuoc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userManager.UpdateUser(new Infrastructure.Entities.User()
            {
                UserId = _id,
                FirstName = txtTen.Text,
                LastName = txtHoLot.Text,
                Email = txtEmail.Text,
                Password = txtMatKhau.Text,
                Sex = rdNam.Checked ? Sex.MALE : Sex.FEMALE,
                Address = txtDiaChi.Text,
                PhoneNumber = txtSoDienThoai.Text,
                Role = (string)cbbRole.SelectedItem,
                Position = (Position)cbbChucVu.SelectedItem,
                AffiliatedUnit = (AffiliatedUnit)cbbDonViTrucThuoc.SelectedItem,
            });
        }


        public void SetDataSourceChucVu(IEnumerable<Position> chucVu)
        {
            cbbChucVu.ValueMember = null;
            cbbChucVu.DisplayMember = "PositionName";
            cbbChucVu.DataSource = chucVu;
        }
        public void SetDataSourceDonViTrucThuoc(IEnumerable<AffiliatedUnit> dvtt)
        {
            cbbDonViTrucThuoc.ValueMember = null;
            cbbDonViTrucThuoc.DisplayMember = "AffiliatedUnitName";
            cbbDonViTrucThuoc.DataSource = dvtt;
        }

        private void UserUpdateForm_Load(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault(e => e.UserId == _id);
            if (user is null)
            {
                return;
            }

            txtHoLot.Text = user.LastName;
            txtTen.Text = user.FirstName;
            txtEmail.Text = user.Email;
            txtSoDienThoai.Text = user.PhoneNumber;
            txtDiaChi.Text = user.Address;
            if (user.Sex == Sex.MALE)
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            var chucVu = db.Positions.ToList();
            SetDataSourceChucVu(chucVu);
            cbbChucVu.SelectedItem = chucVu.FirstOrDefault(e => e.PositionId == user.PositionId);

            var dvtt = db.AffiliatedUnits.ToList();
            SetDataSourceDonViTrucThuoc(dvtt);
            cbbDonViTrucThuoc.SelectedItem = dvtt.FirstOrDefault(e => e.AffiliatedUnitId == user.AffiliatedUnitId);

            cbbRole.SelectedItem = user.Role;
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
