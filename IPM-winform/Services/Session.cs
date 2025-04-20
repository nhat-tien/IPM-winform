using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.Services
{
    public class Session
    {
        private static IPM.Infrastructure.Entities.User? _userinfo;

        public static IPM.Infrastructure.Entities.User? getSession()
        {
            return _userinfo;
        }

        public static void deleteSession()
        {
            _userinfo = null;
        }
        public static void setSession(IPM.Infrastructure.Entities.User user)
        {
            _userinfo = user;
        }
    }
}
