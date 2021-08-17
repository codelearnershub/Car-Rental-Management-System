using CarRentalsSystem.Models;
using CarRentalsSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            var role = _roleService.GetAllRole();
            return View(role);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRole(CreateRoleViewModel model)
        {
            _roleService.AddRole(model);

            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateRoleViewModel model)
        {
            _roleService.UpdateRole(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Find(string name)
        {
            _roleService.FindRoleByName(name);
            return RedirectToAction("Index");
        }
        public IActionResult Delete (string name)
        {
            _roleService.DeleteRole(name);
            return RedirectToAction("Index");
        }
      
    }
}
