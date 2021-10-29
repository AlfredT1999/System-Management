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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;
        
        public LeaveHistoryController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Employee> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize(Roles = "Administrator")]
        // GET: LeaveHistoryController
        public async Task<ActionResult> Index()
        {
            var leaveHistories = await _unitOfWork.LeaveRequests.FindAll(
                includes: new List<string> { "RequestingEmployee", "LeaveType"});
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
            var leaveRequest = await _unitOfWork.LeaveRequests.Find(q => q.Id == id,
                includes: new List<string> { "ApprovedBy", "RequestingEmployee", "LeaveType" });
            var model = _mapper.Map<LeaveHistoryVM>(leaveRequest);

            return View(model);
        }

        public async Task<ActionResult> ApproveRequest(int id)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                var leaveRequest = await _unitOfWork.LeaveRequests.Find(q => q.Id == id);
                var employeeId = leaveRequest.RequestingEmployeeId;
                var leaveTypeId = leaveRequest.LeaveTypeId;
                var period = DateTime.Now.Year;
                var allocation = await _unitOfWork.LeaveAllocations.Find(
                    q => q.EmployeeId == employeeId && q.Period == period && q.LeaveTypeId == leaveTypeId);

                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;

                allocation.NumberOfDays -= daysRequested;

                leaveRequest.Approved = true;
                leaveRequest.ApprovedById = user.Id;
                leaveRequest.DateActioned = DateTime.Now;

                _unitOfWork.LeaveRequests.Update(leaveRequest);
                _unitOfWork.LeaveAllocations.Update(allocation);
                await _unitOfWork.Save();

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
                var leaveRequest = await _unitOfWork.LeaveRequests.Find(q => q.Id == id);

                leaveRequest.Approved = false;
                leaveRequest.ApprovedById = user.Id;
                leaveRequest.DateActioned = DateTime.Now;

                _unitOfWork.LeaveRequests.Update(leaveRequest);
                await _unitOfWork.Save();

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
            var employeeAllocations = await _unitOfWork.LeaveAllocations.FindAll(q => q.EmployeeId == employeeId,
                includes: new List<string> { "LeaveType"});
            var employeeRequests = await _unitOfWork.LeaveRequests.FindAll(q => q.RequestingEmployeeId == employeeId);
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
            var leaveTypes = await _unitOfWork.LeaveTypes.FindAll();
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
                var leaveTypes = await _unitOfWork.LeaveTypes.FindAll();
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
                var period = DateTime.Now.Year;
                var allocation = await _unitOfWork.LeaveAllocations.Find(
                    q => q.EmployeeId == employee.Id && q.Period == period && q.LeaveTypeId == model.LeaveTypeId);

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
                await _unitOfWork.LeaveRequests.Create(leaveRequest);
                await _unitOfWork.Save();

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
            var leaveRequest = await _unitOfWork.LeaveRequests.Find(q => q.Id == id);
            leaveRequest.Cancelled = true;
            _unitOfWork.LeaveRequests.Update(leaveRequest);
            await _unitOfWork.Save();

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
