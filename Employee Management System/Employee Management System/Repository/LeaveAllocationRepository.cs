using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        // readonly indicates that assignment to the field can only
        // occur as part of the declaration or in a constructor in the same class.
        private readonly ApplicationDbContext _db;

        // Keyshort ctor generates the constructor:
        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        /* The above code is called dependency injection. */

        public bool Create(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
