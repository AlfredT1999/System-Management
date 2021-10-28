using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> Create(LeaveType entity)// LeaveType entity, it's the info that comes from the user.
        {
            await _db.LeaveTypes.AddAsync(entity);

            return await Save();
        }

        public async Task<bool> Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);

            return await Save();
        }

        public async Task<ICollection<LeaveType>> FindAll()
        {
            return await _db.LeaveTypes.ToListAsync();
        }

        public async Task<LeaveType> FindById(int id)
        {
            return await _db.LeaveTypes.FindAsync(id);
        }

        public async Task<ICollection<LeaveType>> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> isExists(int id)
        {
            var exists = await _db.LeaveTypes.AnyAsync(q => q.Id == id);// The q => is a lambda expression.
            return exists;
        }

        public async Task<bool> Save()
        {
            // If something is created, deleted or updated, the value of _db.SaveChanges() will be major than 0.
            // If not return false.
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);

            return await Save();
        }
    }
}
