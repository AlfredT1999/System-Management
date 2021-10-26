using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models
{
    public class LeaveHistoryVM
    {
        public int Id { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }

        [Display(Name = "Request Employee")]
        public string RequestingEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }

    public class AdminLeaveHistoryViewVM
    {
        [Display(Name = "Total number of request")]
        public  int TotalRequests { get; set; }
        
        [Display(Name = "Approved Request")]
        public  int ApprovedRequests { get; set; }
        
        [Display(Name = "Pending Request")]
        public  int PendingRequests { get; set; }
        
        [Display(Name = "Rejected Request")]
        public  int RejectedRequests { get; set; }

        public  List<LeaveHistoryVM> LeaveHistories { get; set; }
    }

    public class CreateLeaveHistoryVM
    {
        public int Id { get; set; }

        [Display(Name = "Start Date")]
        [Required]
        public string StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public string EndDate { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
    }

    public class EmployeeLeaveHistoryViewVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveHistoryVM> LeaveHistories { get; set; }
    }
}
