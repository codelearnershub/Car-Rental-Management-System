using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public interface ICategoryRepository
    {
        public Category AddCategory(Category category);
        public Category SearchCategoryById(int id);
        public Category UpdateCategory(Category category);
        public void DeleteCategory(int id);
        public List<Category> GetAllCategory();
    }
}
