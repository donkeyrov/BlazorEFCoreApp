using BlazorEFCoreApp.Server.Infrastructure;
using BlazorEFCoreApp.Server.IRepository;
using BlazorEFCoreApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEFCoreApp.Server.Repository
{
    public class UserRepository : IUserRepository
    {
        public void addUser(User user)
        {
            BlazorDBContext dBContext = new BlazorDBContext();
            dBContext.Add(user);
            dBContext.SaveChanges();
        }

        public List<User> GetUsers()
        {
            BlazorDBContext dBContext = new BlazorDBContext();
            return dBContext.Users.ToList();
        }

        public User GetUser(int Id)
        {
            BlazorDBContext dBContext = new BlazorDBContext();
            User user = (User)dBContext.Users.Where(c => c.userId == Id);
            return user ?? null;
        }
    }
}
