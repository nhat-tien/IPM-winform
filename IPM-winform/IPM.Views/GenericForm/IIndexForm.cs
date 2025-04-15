using IPM_winform.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.IPM.Views.GenericForm
{
    public interface IIndexForm
    {
        void LoadData(IEnumerable<TableDto> rows);
    }
}
