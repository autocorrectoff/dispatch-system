using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dispatch_system.Core
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
    }
}
