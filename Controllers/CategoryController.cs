using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var category = _categoryService.GetAllCategory();
            return View(category);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryViewModel category)
        {
            _categoryService.AddCategory(category);
            return RedirectToAction("Index");
        }
        public IActionResult Find()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Find(int id)
        {
            _categoryService.SearchCategoryById(id);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateCategoryViewModel category)
        {
            _categoryService.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
         {
            var category = _categoryService.SearchCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

public IActionResult Delete(int id)
        {
            _categoryService.DeleteCategory
                (id);
            return RedirectToAction("Index");
        }
    }
}
