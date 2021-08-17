using CarRentalsSystem.Models;
using CarRentalsSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class DashBoardController : Controller
    {
        public readonly IUserRepository __userRepository;
        public DashBoardController(IUserRepository userRepository)
        {
            __userRepository = userRepository;
        }
        public IActionResult Index()
        {   int id = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            User user = __userRepository.FindUserById(id);

            DashBoardViewModel vm = new DashBoardViewModel
            {
               User = user
           };

        
            return View();
        }
    }
}
