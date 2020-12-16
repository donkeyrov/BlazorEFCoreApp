using BlazorEFCoreApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEFCoreApp.Server.IRepository
{
    public interface IUserRepository
    {
        void addUser(User user);
        List<User> GetUsers();
        User GetUser(int Id);
    }
}
