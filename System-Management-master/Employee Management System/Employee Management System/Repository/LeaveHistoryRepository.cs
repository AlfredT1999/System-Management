using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> Create(LeaveHistory entity)
        {
            await _db.LeaveHistories.AddAsync(entity);

            return await Save();
        }

        public async Task<bool> Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);

            return await Save();
        }

        public async Task<ICollection<LeaveHistory>> FindAll()
        {
            return await _db.LeaveHistories
                .Include(q => q.RequestingEmployee)// Get the data from the EmployeeVM
                .Include(q => q.ApprovedBy)
                .Include(q => q.LeaveType)
                .ToListAsync();
        }

        public async Task<LeaveHistory> FindById(int id)
        {
            return await (_db.LeaveHistories
                .Include(q => q.RequestingEmployee)// Get the data from the EmployeeVM
                .Include(q => q.ApprovedBy)
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id));
        }

        public async Task<ICollection<LeaveHistory>> GetLeaveHistoriesByEmployee(string employeeId)
        {
            var query = await FindAll();

            return query.Where(q => q.RequestingEmployeeId == employeeId).ToList();
        }

        public async Task<bool> isExists(int id)
        {
            var exists = await _db.LeaveHistories.AnyAsync(q => q.Id == id);// The q => is a lambda expression.
            return exists;
        }

        public async Task<bool> Save()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);

            return await Save();
        }
    }
}
