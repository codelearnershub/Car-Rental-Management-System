using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public interface ICarRepository
    {
        public Car Create(Car car);
        public Car AddCar(Car car);
        public IList<Car> Search(string searchText);
        public Car Update(Car car);
        public void Delete(int id);
        public List<Car> GetAll();
        //public IEnumerable<Car> GetAll();
    }
}
