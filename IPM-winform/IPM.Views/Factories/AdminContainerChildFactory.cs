using IPM_winform.IPM.Views.ChucVu;
using IPM_winform.IPM.Views.Container;
using IPM_winform.IPM.Views.CoQuanPheDuyet;
using IPM_winform.IPM.Views.DanhMuc;
using IPM_winform.IPM.Views.DoiTac;
using IPM_winform.IPM.Views.DonViTrucThuoc;
using IPM_winform.IPM.Views.DuAn;
using IPM_winform.IPM.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.IPM.Views.Factories
{
    public class AdminContainerChildFactory
    {
        public static Form GetInstance(string formName)
        {
            switch (formName)
            {
                case "thongtinchung":
                    return new ChucVuForm();
                case "chucvu":
                    return new ChucVuForm();
                case "coquanpheduyet":
                    return new CoQuanPheDuyetForm();
                case "danhmuc":
                    return new DanhMucForm();
                case "doitac":
                    return new DoiTacForm();
                case "donvitructhuoc":
                    return new DonViTrucThuocForm();
                case "user":
                    return new UserForm();
                case "project":
                    return new ProjectForm();
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}
