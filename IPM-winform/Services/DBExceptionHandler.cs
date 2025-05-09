using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.Services
{
    public class DBExceptionHandler
    {
        public const int FOREIGN_KEY_VIOLATION = 547;
        public static void Handle(Action action) 
        {
            try
            {
                action();
            } catch (SqlException e) 
            {
                //MessageBox.Show(e.Number.ToString());
                if(e.Number == FOREIGN_KEY_VIOLATION)
                {
                   MessageBox.Show("Xung đột với khóa ngoại ở bảng khác", "Không thể thực hiện hành động", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
