using dispatch_system.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dispatch_system.Persistence
{
    public class DispatchSystemDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DispatchSystemDbContext(DbContextOptions<DispatchSystemDbContext> options): base(options)
        {

        }
    }
}
