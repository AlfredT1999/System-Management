using AutoMapper;
using Employee_Management_System.Contracts;
using Employee_Management_System.Data;
using Employee_Management_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Controllers
{
    [Authorize]
    public class LeaveHistoryController : Controller
    {
        private readonly ILeaveHistoryRepository _leaveHistoryRepo;
        private readonly ILeaveTypeRepository _leaveTypeRepo;
        private readonly ILeaveAllocationRepository _leaveAllocRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;

        public LeaveHistoryController(ILeaveHistoryRepository leaveHistoryRepo, ILeaveTypeRepository leaveTypeRepo, ILeaveAllocationRepository leaveAllocRepo, IMapper mapper, UserManager<Employee> userManager)
        {
            _leaveHistoryRepo = leaveHistoryRepo;
            _leaveTypeRepo = leaveTypeRepo;
            _leaveAllocRepo = leaveAllocRepo;
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize(Roles = "Administrator")]
        // GET: LeaveHistoryController
        public async Task<ActionResult> Index()
        {
            var leaveHistories = _leaveHistoryRepo.FindAll();
            var leaveHistoriesModel = _mapper.Map<List<LeaveHistoryVM>>(leaveHistories);
            var model = new AdminLeaveHistoryViewVM
            {
                TotalRequests = leaveHistoriesModel.Count,
                ApprovedRequests = leaveHistoriesModel.Count(q => q.Approved == true),
                PendingRequests = leaveHistoriesModel.Count(q => q.Approved == null),
                RejectedRequests = leaveHistoriesModel.Count(q => q.Approved == false),
                LeaveHistories = leaveHistoriesModel
            };

            return View(model);
        }

        // GET: LeaveHistoryController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var leaveRequest = await _leaveHistoryRepo.FindById(id);
            var model = _mapper.Map<LeaveHistoryVM>(leaveRequest);

            return View(model);
        }

        public async Task<ActionResult> ApproveRequest(int id)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                var leaveRequest = await _leaveHistoryRepo.FindById(id);
                var employeeId = leaveRequest.RequestingEmployeeId;
                var leaveTypeId = leaveRequest.LeaveTypeId;
                var allocation = await _leaveAllocRepo.GetLeaveAllocationByEmployeeAndType(employeeId, leaveTypeId);
                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;

                allocation.NumberOfDays -= daysRequested;

                leaveRequest.Approved = true;
                leaveRequest.ApprovedById = user.Id;
                leaveRequest.DateActioned = DateTime.Now;

                await _leaveHistoryRepo.Update(leaveRequest);
                await _leaveAllocRepo.Update(allocation);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<ActionResult> RejectRequest(int id)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                var leaveRequest = await _leaveHistoryRepo.FindById(id);

                leaveRequest.Approved = false;
                leaveRequest.ApprovedById = user.Id;
                leaveRequest.DateActioned = DateTime.Now;

                await _leaveHistoryRepo.Update(leaveRequest);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }

        }

        public async Task<ActionResult> MyLeave()
        {
            var employee = await _userManager.GetUserAsync(User);
            var employeeId = employee.Id;
            var employeeAllocations = await _leaveAllocRepo.GetLeaveAllocationByEmployee(employeeId);
            var employeeRequests = await _leaveHistoryRepo.GetLeaveHistoriesByEmployee(employeeId);
            var employeeAllocationModel = _mapper.Map<List<LeaveAllocationVM>>(employeeAllocations);
            var employeeRequestsModel = _mapper.Map<List<LeaveHistoryVM>>(employeeRequests);

            var model = new EmployeeLeaveHistoryViewVM
            {
                LeaveAllocations = employeeAllocationModel,
                LeaveHistories = employeeRequestsModel
            };

            return View(model);
        }

        // GET: LeaveHistoryController/Create
        public async Task<ActionResult> Create()
        {
            var leaveTypes = await _leaveTypeRepo.FindAll();
            var leaveTypeItems = leaveTypes.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.Id.ToString()
            });
            var model = new CreateLeaveHistoryVM
            {
                LeaveTypes = leaveTypeItems
            };

            return View(model);
        }

        // POST: LeaveHistoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateLeaveHistoryVM model)
        {
            try
            {
                var startDate = Convert.ToDateTime(model.StartDate);
                var endDate = Convert.ToDateTime(model.EndDate);
                var leaveTypes = await _leaveTypeRepo.FindAll();
                var leaveTypeItems = leaveTypes.Select(q => new SelectListItem
                {
                    Text = q.Name,
                    Value = q.Id.ToString()
                });

                model.LeaveTypes = leaveTypeItems;

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (DateTime.Compare(startDate, endDate) > 1)
                {
                    ModelState.AddModelError("", "Start date cannot be further in the future than the end date.");
                    return View(model);
                }

                var employee = await _userManager.GetUserAsync(User);
                var allocation = await _leaveAllocRepo.GetLeaveAllocationByEmployeeAndType(employee.Id, model.LeaveTypeId);
                int daysRequested = (int)(endDate - startDate).TotalDays;

                if (daysRequested > allocation.NumberOfDays)
                {
                    ModelState.AddModelError("", "You do not have sufficient days for this request");
                    return View(model);
                }

                var leaveHistory = new LeaveHistoryVM
                {
                    RequestingEmployeeId = employee.Id,
                    StartDate = startDate,
                    EndDate = endDate,
                    Approved = null,
                    DateRequested = DateTime.Now,
                    DateActioned = DateTime.Now,
                    LeaveTypeId = model.LeaveTypeId
                };

                var leaveRequest = _mapper.Map<LeaveHistory>(leaveHistory);
                var isSuccess = await _leaveHistoryRepo.Create(leaveRequest);

                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something went wrong with submitting your record");
                    return View(model);
                }

                return RedirectToAction("MyLeave");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
        }

        public async Task<ActionResult> CancelRequest(int id)
        {
            var leaveRequest = await _leaveHistoryRepo.FindById(id);
            leaveRequest.Cancelled = true;
            await _leaveHistoryRepo.Update(leaveRequest);
            await _leaveHistoryRepo.Save();

            // send email to user 
            return RedirectToAction("MyLeave");
        }

        // GET: LeaveHistoryController/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: LeaveHistoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: LeaveHistoryController/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: LeaveHistoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, LeaveHistoryVM model)
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
