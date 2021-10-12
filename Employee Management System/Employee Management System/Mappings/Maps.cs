using AutoMapper;
using Employee_Management_System.Data;
using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Mappings
{
    // With this class I make a mapper between my view models and my data:
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
