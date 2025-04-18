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

namespace IPM_winform.IPM.Views.GenericForm
{
    public partial class UserInsertForm : Form
    {
        private readonly UserManager userManager = new UserManager();
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();

        private readonly FormContainer _parentView;
        public UserInsertForm(FormContainer parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            //label.Text = _parentView.InsertLabel;
            cbbRole.SelectedItem = "User";
            SetDataSourceChucVu();
            SetDataSourceDonViTrucThuoc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userManager.CreateUser(new Infrastructure.Entities.User()
            {
                FirstName = txtTen.Text,
                LastName = txtHoLot.Text,
                Email = txtEmail.Text,
                Password = txtMatKhau.Text,
                Sex = rdNam.Checked ? Sex.MALE : Sex.FEMALE,
                Address = txtDiaChi.Text,
                PhoneNumber = txtSoDienThoai.Text,
                Role = (string) cbbRole.SelectedItem,
                Position = (Position) cbbChucVu.SelectedItem,
                AffiliatedUnit = (AffiliatedUnit) cbbDonViTrucThuoc.SelectedItem,
            });
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.GoToIndex();
        }

        public void SetDataSourceChucVu()
        {
            var chucVu = db.Positions.ToList();
            cbbChucVu.ValueMember = null;
            cbbChucVu.DisplayMember = "PositionName";
            cbbChucVu.DataSource = chucVu;
        }
        public void SetDataSourceDonViTrucThuoc()
        {
            var dvtt = db.AffiliatedUnits.ToList();
            cbbDonViTrucThuoc.ValueMember = null;
            cbbDonViTrucThuoc.DisplayMember = "AffiliatedUnitName";
            cbbDonViTrucThuoc.DataSource = dvtt;
        }
    }
}
