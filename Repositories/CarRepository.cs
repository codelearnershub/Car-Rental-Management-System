using CarRentalsSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class CarRepository : ICarRepository
    {
        public readonly RentalsDbContext _dbContext;
        public CarRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Car AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
            return car;
        }
       
        public Car UpdateCar(Car car)
        {
            _dbContext.Cars.Update(car);
            _dbContext.SaveChanges();
            return car;
        }
        public void Delete(int id)
        {
            //var customer = FindById(id);
            var car = new Car
            {
                Id = id
            };
            if (car != null)
            {
                _dbContext.Cars.Remove(car);
                _dbContext.SaveChanges();
            }
        }
        public List<Car> GetAll(IEnumerable<int> carId)
        {
            return _dbContext.Cars.Where(item => carId.Contains(item.LocationId)).ToList();

        }

        public List<Car> GetAllCars()
        {
            return _dbContext.Cars.ToList();
        }
        public IList<Car> Search(string searchText)
        {
            return _dbContext.Cars.Where(item => EF.Functions.Like(item.Name, $"%{searchText}%")).ToList();
        } 

    }
}