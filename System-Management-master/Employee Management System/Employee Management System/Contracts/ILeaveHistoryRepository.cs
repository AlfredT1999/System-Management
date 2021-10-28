using Employee_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Contracts
{
    public interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
        Task<ICollection<LeaveHistory>> GetLeaveHistoriesByEmployee(string employeeId);
    }
}
