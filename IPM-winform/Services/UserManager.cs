using BCrypt.Net;
using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.Services
{
    public class UserManager
    {
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public UserManager() 
        {

        }

        public User CreateUser(User user)
        { 
            user.Password = HashPassword(user.Password);
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        public User? Login(string email, string password)
        {
    
            User? user = db.Users
                .Include(e => e.AffiliatedUnit)
                .Include(e => e.Position)
                .FirstOrDefault(e => e.Email == email);
            if(user is null || !VerifyPassword(password, user.Password))
            {
                return null;
            }
            return user;
        }

        private bool VerifyPassword(string pass, string hashPass)
        {
            return BCrypt.Net.BCrypt.Verify(pass, hashPass);
        }

        private string HashPassword(string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(pass);
        }

    }
}
