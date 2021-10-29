using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        // Injection:
        private readonly ApplicationDbContext _context;
        private IGenericRepository<LeaveType> _LeaveTypes;
        private IGenericRepository<LeaveHistory> _LeaveRequests;
        private IGenericRepository<LeaveAllocation> _LeaveAllocations;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<LeaveType> LeaveTypes
            => _LeaveTypes ??= new GenericRepository<LeaveType>(_context);// It's the same as _LeaveTypes == null ? _LeaveTypes : new GenericRepository<LeaveType>(_context);
       
        public IGenericRepository<LeaveHistory> LeaveRequests
            => _LeaveRequests ??= new GenericRepository<LeaveHistory>(_context);
        
        public IGenericRepository<LeaveAllocation> LeaveAllocations
            => _LeaveAllocations ??= new GenericRepository<LeaveAllocation>(_context);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispose)
        {
            if (dispose)
                _context.Dispose();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
