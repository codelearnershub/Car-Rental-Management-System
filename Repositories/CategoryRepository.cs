using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        public readonly RentalsDbContext _dbContext;
        public CategoryRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Category AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }
        public Category SearchCategoryById(int id)
        {
            return _dbContext.Categories.Find(id);
        }
        public Category UpdateCategory(Category category)
        {
            _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
            return category;
        }
        public void DeleteCategory(int id)
        {

            var category = SearchCategoryById(id);

            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                _dbContext.SaveChanges();
            }
        }

        public List<Category> GetAllCategory()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
