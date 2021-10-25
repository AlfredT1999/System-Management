﻿using Employee_Management_System.Contracts;
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

        public bool CheckAllocation(int leaveTypeId, string employeeId)
        {
            var period = DateTime.Now.Year;

            // The Any function means: There's anything here.
            return FindAll().Where(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period).Any();
        }

        /* The above code is called dependency injection. */

        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);

            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);

            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            // Include(q => q.LeaveType) Means that we need to include the info of the table LeaveType
            return (_db.LeaveAllocations.Include(q => q.LeaveType).Include(q => q.Employee).ToList());
        }

        public LeaveAllocation FindById(int id)
        {
            return (_db.LeaveAllocations.Include(q => q.LeaveType).Include(q => q.Employee).FirstOrDefault(q => q.Id == id));
        }

        public ICollection<LeaveAllocation> GetLeaveAllocationByEmployee(string id)
        {
            var period = DateTime.Now.Year;

            return FindAll().Where(q => q.EmployeeId == id && q.Period == period).ToList();
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveAllocations.Any(q => q.Id == id);// The q => is a lambda expression.
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);

            return Save();
        }
    }
}