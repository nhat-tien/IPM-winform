using IPM_winform.Dtos;
using IPM_winform.IPM.Views.DuAn;
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
    public partial class FormContainer: Form
    {
        Form childrenView;
        public virtual DataGridViewTextBoxColumn[] Columns { get; set; }
        public virtual string Label { get => ""; }
        public virtual string InsertLabel { get => ""; }
        public virtual string UpdateLabel { get => ""; }

        public virtual IEnumerable<TableDto> Rows()
        {
            return [];
        }

        public virtual void OnCreate(string name) 
        { 
            Console.Write(name);
        }

        public virtual void OnDelete(string id)
        {
            Console.Write(id);
        }

        public virtual void OnUpdate(string id, object entity)
        {
            Console.Write(id);
        }


        protected virtual Form GetUpdateView(string? idSelected, string name)
        {
            if(idSelected is null)
            {
                throw new Exception("Missing id");
            }
            return new UpdateForm(this, idSelected, name);
        }

        public FormContainer()
        {
            InitializeComponent();
            label1.Text = Label;
            GoToIndex();
        }

        public void SetChildren(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            if (childrenView != null)
            {
                childrenView.Close();
            }
            childrenView = form;
            centerPanel.Controls.Add(childrenView);
            ChangeLabel(childrenView.GetType().Name);
            childrenView.Show();
        }

        public virtual void GoToIndex()
        {
            SetChildren(new IndexForm(this, Rows()));
            ChangeLabel("index");
        }

        public virtual void GoToInsert()
        {
            SetChildren(new ProjectAddForm(this));
            ChangeLabel("insert");
        }

        public virtual void GoToUpdate(string idSelected, string name)
        {
            SetChildren(new UpdateForm(this, idSelected, name));
            ChangeLabel("update");
        }


        public void ChangeLabel(string name)
        {
            string label = "";
            switch (name)
            {
                case "index":
                    label = "Danh sách";
                    break;
                case "insert":
                    label = "Thêm";
                    break;
                case "update":
                    label = "Chỉnh sửa";
                    break;
                case "search":
                    label = "Tìm kiếm";
                    break;
            }
            label3.Text = label;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetChildren(new IndexForm(this, Rows()));
        }

        public void Reload()
        {
            if(childrenView is IIndexForm indexForm)
            {
                indexForm.LoadData(Rows());
            }
        }
    }
}
