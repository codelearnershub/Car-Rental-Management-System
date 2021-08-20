using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class AuthController : Controller

    {
        public readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            _userService.RegisterUser(model);
           
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {



            User user = _userService.LoginUser(vm.Email, vm.Password);

            if (user == null) return View();


            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                   new Claim(ClaimTypes.Role, user.UserRoles.ToString()),
                };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var props = new AuthenticationProperties();

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);

            /* List<UserRole> userRoles = new List<UserRole>();
             foreach (var use in user.UserRoles)
             {
                 Console.WriteLine(use);

             }
             Role role = new Role();
 */
            //var userRole = user.UserRoles.ToString();
           /* if (user.UserRoles.Contains("Admin") == 1)
                {
                    return RedirectToAction("Index", "AdminDashboard");
                } 
                else
                {
                    return RedirectToAction("Index", "CustomerDashboard");
                }*/
                return RedirectToAction("Index");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        //The old model of authorization Creating Customer and Admin model seperately having their repositories,services
        //(all with interface) and also their controller.We have foreign key roleId in the user ,so int the service we have 
        //this to assign role to users in our system. So we ahve this: Role = roleService.FindRole("Customer");


    }
}
