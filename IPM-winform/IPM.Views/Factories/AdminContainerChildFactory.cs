using IPM_winform.IPM.Views.ChucVu;
using IPM_winform.IPM.Views.Container;
using IPM_winform.IPM.Views.CoQuanPheDuyet;
using IPM_winform.IPM.Views.DanhMuc;
using IPM_winform.IPM.Views.DoiTac;
using IPM_winform.IPM.Views.DonViTienTe;
using IPM_winform.IPM.Views.DonViTrucThuoc;
using IPM_winform.IPM.Views.LoaiVienTro;
using IPM_winform.IPM.Views.NhaTaiTro;
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
                case "donvitiente":
                    return new DonViTienTeForm();
                case "donvitructhuoc":
                    return new DonViTrucThuocForm();
                case "loaivientro":
                    return new LoaiVienTroForm();
                case "nhataitro":
                    return new NhaTaiTroForm();
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}
