using IPM.Infrastructure.EntityFrameworkDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.IPM.Infrastructure
{
    public class AppDbContextSingleton
    {
        private static AppDBContext _context = null;

        public static AppDBContext GetInstance()
        {
            if(_context == null )
            {
                _context = new AppDBContext();
                return _context;
            } else
            {
                return _context;
            }
        }

    }
}
