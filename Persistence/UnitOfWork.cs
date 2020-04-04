using dispatch_system.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dispatch_system.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DispatchSystemDbContext _context;
        public IUserRepository Users { get; private set; }

        public UnitOfWork(DispatchSystemDbContext context, IUserRepository users)
        {
            _context = context;
            Users = users;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
