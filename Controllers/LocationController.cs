using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class LocationController : Controller
    {
            public readonly ILocationService _locationService;
        public readonly ICarService _carService;
            public LocationController(ILocationService locationService,ICarService carService)
            {
                _locationService = locationService;
                _carService = carService;
            }
            public IActionResult Index()
            {
            var location = _locationService.GetAllLocation();
                return View(location);
            }
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }
        public IActionResult SelectLocation()
        {

            ViewBag.Locations = _locationService.GetAllLocation();
            var model = new CreateLocationViewModel();
            return View(model);
        }
       

            [HttpPost]
            public IActionResult Create(CreateLocationViewModel model)
            {
                _locationService.AddLocation(model);
                return RedirectToAction("Index");
            }
            public IActionResult Find()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Find(int id)
            {
               _locationService.SearchLocationById(id);
                return RedirectToAction("Index");
            }
            public IActionResult Update()
            {
                return View();
            }
        [HttpPost]
        public IActionResult Update(UpdateLocationViewModel model)
        {
            _locationService.UpdateLocation(model);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var location = _locationService.SearchLocationById(id);
            if (location == null)
            {
                return NotFound();
            }
            return View(location);
        }
        public IActionResult Delete(int id)
            { 
            
                 _locationService.DeleteLocation(id);
                return RedirectToAction("Index");
            }
        }
}
