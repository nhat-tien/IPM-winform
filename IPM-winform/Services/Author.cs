using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.Services
{
     public class Author
    {
        public static bool isDevelopment = false;
        public static bool IsAdmin()
        {
            return IsRole("Admin");
        }
        public static bool IsManager()
        {
            return IsRole("Manager");
        }

        public static bool IsUser()
        {
            return IsRole("User");
        }
        public static bool IsNonUser() 
        {
            return IsRole("Admin") || IsRole("Manager");
        }

        public static bool IsRole(string role) 
        {
            if (isDevelopment)
            {
                return true;
            }

            var user = Session.getSession();
            if (user is null)
            {
                return false;
            }

            if (user.Role == role)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
