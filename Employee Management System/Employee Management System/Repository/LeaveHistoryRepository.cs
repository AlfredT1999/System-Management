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
            _db.LeaveHistories.Add(entity);

            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);

            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            return (_db.LeaveHistories.ToList());
        }

        public LeaveHistory FindById(int id)
        {
            return (_db.LeaveHistories.Find(id));
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveHistories.Any(q => q.Id == id);// The q => is a lambda expression.
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);

            return Save();
        }
    }
}
