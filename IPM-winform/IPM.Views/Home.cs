//using QLGV.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views
{
    public partial class Home : Form
    {
        public string TongSoGiaoVien { get => label3.Text; set => label3.Text = value; }
        public string TongSoBoMon { get => label4.Text; set => label4.Text = value; }
        public Home()
        {
            InitializeComponent();
            //new HomePresenter(this);
        }

    }
}
