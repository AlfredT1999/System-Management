using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        // readonly indicates that assignment to the field can only
        // occur as part of the declaration or in a constructor in the same class.
        private readonly ApplicationDbContext _db;

        // Keyshort ctor generates the constructor:
        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        /* The above code is called dependency injection. */

        public bool Create(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveHistory FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
