using dispatch_system.Core;
using dispatch_system.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dispatch_system.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DispatchSystemDbContext _context;
        public UserRepository(DispatchSystemDbContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
        }

        public User GetUser(int id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id);
        }

    }
}
