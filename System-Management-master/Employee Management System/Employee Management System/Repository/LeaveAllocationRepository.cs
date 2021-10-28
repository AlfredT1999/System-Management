using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> CheckAllocation(int leaveTypeId, string employeeId)
        {
            var period = DateTime.Now.Year;
            var query = await FindAll();

            // The Any function means: There's anything here.
            return query.Where(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period).Any();
        }

        /* The above code is called dependency injection. */

        public async Task<bool> Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);

            return await Save();
        }

        public async Task<bool> Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);

            return await Save();
        }

        public async Task<ICollection<LeaveAllocation>> FindAll()
        {
            // Include(q => q.LeaveType) Means that we need to include the info of the table LeaveType
            var result = await _db.LeaveAllocations.Include(q => q.LeaveType).Include(q => q.Employee).ToListAsync();

            return result;
        }

        public async Task<LeaveAllocation> FindById(int id)
        {
            return await (_db.LeaveAllocations.Include(q => q.LeaveType).Include(q => q.Employee).FirstOrDefaultAsync(q => q.Id == id));
        }

        public async Task<ICollection<LeaveAllocation>> GetLeaveAllocationByEmployee(string employeeId)
        {
            var period = DateTime.Now.Year;
            var query = await FindAll();

            return query.Where(q => q.EmployeeId == employeeId && q.Period == period).ToList();
        }

        public async Task<LeaveAllocation> GetLeaveAllocationByEmployeeAndType(string employeeId, int leaveTypeId)
        {
            var period = DateTime.Now.Year;
            var query = await FindAll();
            var result = query.Where(q => q.EmployeeId == employeeId && q.Period == period && q.LeaveTypeId == leaveTypeId).FirstOrDefault();

            return result;
        }

        public async Task<bool> isExists(int id)
        {
            var exists = await _db.LeaveAllocations.AnyAsync(q => q.Id == id);// The q => is a lambda expression.
            return exists;
        }

        public async Task<bool> Save()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);

            return await Save();
        }
    }
}
