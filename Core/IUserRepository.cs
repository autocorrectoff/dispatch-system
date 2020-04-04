using dispatch_system.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dispatch_system.Core
{
    public interface IUserRepository
    {
        public User GetUser(int id);
        public void AddUser(User user);
        public void DeleteUser(User user);
    }
}
