using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public interface ICategoryService
    {
        public Category AddCategory(CreateCategoryViewModel model);
        public Category SearchCategoryById(int id);
        public Category UpdateCategory(UpdateCategoryViewModel model);
        public void DeleteCategory(int id);
        public List<CategoryViewModel> GetAllCategory();
    }
}
