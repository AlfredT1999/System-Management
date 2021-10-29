using Employee_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<LeaveType> LeaveTypes { get;  }
        IGenericRepository<LeaveHistory> LeaveRequests { get;  }
        IGenericRepository<LeaveAllocation> LeaveAllocations { get; }
        Task Save(); 
    }
}
