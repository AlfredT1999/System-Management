﻿using Employee_Management_System.Contracts;
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
            return (_db.LeaveAllocations.ToList());
        }

        public LeaveAllocation FindById(int id)
        {
            return (_db.LeaveAllocations.Find(id));
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