using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class CategoryService:ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category AddCategory(CreateCategoryViewModel model)
        {
            var category = new Category
            {Id = model.Id,
                Name= model.Name,
                CreatedAt = DateTime.Now
            };

            return _categoryRepository.AddCategory(category);
        }
        public Category SearchCategoryById(int id)
        {
            return _categoryRepository.SearchCategoryById(id);
        }
        public Category UpdateCategory(UpdateCategoryViewModel model)
        {
            var category = new Category
            {
                Id = model.Id,
                Name = model.Name
            };
            return _categoryRepository.UpdateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }
        public List<CategoryViewModel> GetAllCategory()
        {
            var category = _categoryRepository.GetAllCategory().Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name= c.Name,
                CreatedAt = DateTime.Now

            }).ToList();
            return category;
        }
    }
}
