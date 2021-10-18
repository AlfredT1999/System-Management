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
            _db.LeaveTypes.Add(entity);

            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);

            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return (_db.LeaveTypes.ToList());
        }

        public LeaveType FindById(int id)
        {
            return (_db.LeaveTypes.Find(id));
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveTypes.Any(q => q.Id == id);// The q => is a lambda expression.
            return exists;
        }

        public bool Save()
        {
            // If something is created, deleted or updated, the value of _db.SaveChanges() will be major than 0.
            // If not return false.
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);

            return Save();
        }
    }
}
