using AutoMapper;
using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using Employee_Management_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class LeaveAllocationController : Controller
    {
        private readonly ILeaveTypeRepository _leaveTypeRepo;
        private readonly ILeaveAllocationRepository _leaveAllocationRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;

        public LeaveAllocationController(ILeaveTypeRepository leaveTypeRepo, ILeaveAllocationRepository leaveAllocationRepo, IMapper mapper, UserManager<Employee> userManager)
        {
            _leaveTypeRepo = leaveTypeRepo;
            _leaveAllocationRepo = leaveAllocationRepo;
            _mapper = mapper;
            _userManager = userManager;
        }

        // GET: LeaveAllocationController
        public async Task<ActionResult> Index()
        {
            var leavetypes = await _leaveTypeRepo.FindAll();// FindAll is definded inside IRepositoryBase.
            var leavetypes2 = leavetypes.ToList();
            var mappedLeaveTypes = _mapper.Map<List<LeaveType>, List<LeaveTypeVM>>(leavetypes2);// Returns a List.
            var model = new CreateLeaveAllocationVM
            {
                NumberUpdated = 0,
                LeaveTypes = mappedLeaveTypes
            };

            return View(model);
        }

        // GET: LeaveAllocationController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var employee = await _userManager.FindByIdAsync(id);
            var mappedEmployees = _mapper.Map<EmployeeVM>(employee);
            var allocations = await _leaveAllocationRepo.GetLeaveAllocationByEmployee(id);
            var mappedAllocations = _mapper.Map<List<LeaveAllocationVM>>(allocations);
            var model = new ViewAllocationVM
            {
                Employee = mappedEmployees,
                LeaveAllocations = mappedAllocations
            };

            return View(model);
        }

        // GET: LeaveAllocationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveAllocationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> SetLeave(int id)
        {
            var leaveTypes = await _leaveTypeRepo.FindById(id);
            var employees = await _userManager.GetUsersInRoleAsync("Employee");

            foreach (var item in employees)
            {
                // if there's something with the same id's or periods' continue. The definition of
                // CheckAllocation is in the repo of leave allocation.
                if(await _leaveAllocationRepo.CheckAllocation(id, item.Id))
                {
                    continue;
                }

                var allocation = new LeaveAllocationVM
                {
                    NumberOfDays = leaveTypes.DefaultDays,
                    DateCreated = DateTime.Now,
                    EmployeeId = item.Id,
                    LeaveTypeId = id,
                    Period = DateTime.Now.Year
                };
                var leaveAllocation = _mapper.Map<LeaveAllocation>(allocation);

                await _leaveAllocationRepo.Create(leaveAllocation);
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> ListEmployees()
        {
            var employees = await _userManager.GetUsersInRoleAsync("Employee");
            var model = _mapper.Map<List<EmployeeVM>>(employees);

            return View(model);
        }

        // GET: LeaveAllocationController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var leaveAllocation = await _leaveAllocationRepo.FindById(id);
            var model = _mapper.Map<EditLeaveAllocationVM>(leaveAllocation);

            return View(model);
        }

        // POST: LeaveAllocationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditLeaveAllocationVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var leaveAllocation = await _leaveAllocationRepo.FindById(model.Id);
                leaveAllocation.NumberOfDays = model.NumberOfDays;
                var isSuccess = await _leaveAllocationRepo.Update(leaveAllocation);

                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }

                // The method Details accept a parameter string id which is the Id of the current employee.
                // new { id = model.EmployeeId } This line makes the reference to that id.
                // In the Edit layout we keep the info of the EmployeeId hidden.
                return RedirectToAction(nameof(Details), new { id = model.EmployeeId });
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveAllocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeaveAllocationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
