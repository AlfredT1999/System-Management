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
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;

        public LeaveHistoryController(ILeaveHistoryRepository leaveHistoryRepo, ILeaveTypeRepository leaveTypeRepo, IMapper mapper, UserManager<Employee> userManager)
        {
            _leaveHistoryRepo = leaveHistoryRepo;
            _leaveTypeRepo = leaveTypeRepo;
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize(Roles = "Administrator")]
        // GET: LeaveHistoryController
        public ActionResult Index()
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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeaveHistoryController/Create
        public ActionResult Create()
        {
            var leaveTypes = _leaveTypeRepo.FindAll();
            var leaveTypeItems = leaveTypes.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.Id.ToString()
            });
            var model = new CreateLeaveHistoryVM
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                LeaveTypes = leaveTypeItems
            };

            return View(model);
        }

        // POST: LeaveHistoryController/Create
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

        // GET: LeaveHistoryController/Edit/5
        public ActionResult Edit(int id)
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeaveHistoryController/Delete/5
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
