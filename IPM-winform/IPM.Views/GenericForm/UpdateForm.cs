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
    public partial class UpdateForm: Form
    {
        private readonly FormContainer _parentView;
        private readonly string _id;
        public UpdateForm(FormContainer parentView, string idSelected, string name)
        {
            InitializeComponent();
            _parentView = parentView;
            _id = idSelected;
            txtName.Text = name;   
            label1.Text = _parentView.InsertLabel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _parentView.OnUpdate(_id, txtName.Text);
        }
    }
}
