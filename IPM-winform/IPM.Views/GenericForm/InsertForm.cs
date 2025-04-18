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
    public partial class ProjectAddForm : Form
    {

        private readonly FormContainer _parentView;
        public ProjectAddForm(FormContainer parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            label1.Text = _parentView.InsertLabel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parentView.OnCreate(txtName.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.GoToIndex();
        }
    }
}
