using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Repository
{
    // This class inherits from his correspond interface which in this case is ILeaveTypeRepository that at the same
    // time inherits from his base interface. So the current methods are coming from the IRepositoryBase:
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        // readonly indicates that assignment to the field can only
        // occur as part of the declaration or in a constructor in the same class.
        private readonly ApplicationDbContext _db;
        
        // Keyshort ctor generates the constructor:
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        /* The above code is called dependency injection. */

        public bool Create(LeaveType entity)// LeaveType entity, it's the info that comes from the user.
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveType entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveType> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveType FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveType entity)
        {
            throw new NotImplementedException();
        }
    }
}
