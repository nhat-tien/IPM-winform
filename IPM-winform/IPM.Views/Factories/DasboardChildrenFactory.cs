using IPM_winform.IPM.Views;
using IPM_winform.IPM.Views.ChucVu;
using IPM_winform.IPM.Views.Container;
using IPM_winform.IPM.Views.DonViTrucThuoc;
using IPM_winform.IPM.Views.DuAn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.IPM.Views.Factories
{
    public class DasboardChildrenFactory
    {
        public static Form GetInstance(string formName)
        {
            switch (formName)
            {
                case "home":
                     return new Home();
                case "admin":
                    return new AdminContainer();
                case "myproject":
                    return new ProjectForm();
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}
