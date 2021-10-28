using Employee_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Contracts
{
    // This interface inherits from the base interface and pass as a parameter the class or table that corresponds
    // with the current interface;
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        // This is a specific interface for the class LeaveType, so here we can implement more operations apart from
        // the IRepositoryBase:
        Task<ICollection<LeaveType>> GetEmployeesByLeaveType(int id);
    }
}
