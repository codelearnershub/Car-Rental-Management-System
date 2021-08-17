using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public interface ICarRepository
    {
        public Car AddCar(Car car);
        public IList<Car> Search(string searchText);
        public Car UpdateCar(Car car);
        public void Delete(int id);
        //public List<Car> GetAllCars();
    }
}
