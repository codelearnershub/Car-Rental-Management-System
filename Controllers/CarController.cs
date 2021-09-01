using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class CarController : Controller
    {


        private readonly ICarService _carService;
        private readonly ICategoryService _categoryService;
        private readonly ILocationService _locationService;
        private readonly RentalsDbContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CarController(ICarService carService, ILocationService locationService,RentalsDbContext dbContext, IWebHostEnvironment webHostEnvironment, ICategoryService categoryService)
        {
           
            _carService = carService;
            _dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;
            _categoryService = categoryService;
             _locationService = locationService;
    }
        public IActionResult Index()
        {
            var car = _carService.GetAll();
            return View(car);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateCarViewModel carVM = new CreateCarViewModel
            {
                CategoryList = _categoryService.GetAllCategory().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                }),
                LocationList = _locationService.GetAllLocation().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                })
            };

            //List<CategoryViewModel> categories = _categoryService.GetAllCategory();
            //List<SelectListItem> listAItems = new List<SelectListItem>();
            //foreach (CategoryViewModel category in categories)
            //{
            //    SelectListItem item = new SelectListItem(category.Name, category.Id.ToString());
            //    listAItems.Add(item);
            //}

            //ViewBag.Categories = listAItems;
                                 
            //List<LocationViewModel> locations = _locationService.GetAllLocation();
            //List<SelectListItem> listALocations = new List<SelectListItem>();
            //foreach (LocationViewModel location in locations)
            //{
            //    SelectListItem item = new SelectListItem(location.Name, location.Id.ToString());
            //    listALocations.Add(item);
            //}

           
            return View(carVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car,IFormFile file,CreateCarViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string imageDirectory = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    Directory.CreateDirectory(imageDirectory);
                    string contentType = file.ContentType.Split('/')[1];
                    string fileName = $"{Guid.NewGuid()}.{contentType}";
                    string fullPath = Path.Combine(imageDirectory, fileName);
                    using (var fileStream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    car.CarPictureUrl = fileName;
                }
                _carService.Create(car);
                return RedirectToAction(nameof(Index));
            }
           // return View(model);
            return RedirectToAction("Index");
        }
      

        public IActionResult Find()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Find(string searchText)
        {
            _carService.Search(searchText);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateCarViewModel car)
        {
            _carService.UpdateCar(car);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string searchText)
        {
            _carService.Search(searchText);
            return RedirectToAction("Index");
        }

    }
}   

