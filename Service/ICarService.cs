using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public interface ICarService
    {
        public Car AddCar(Car car);
        public void Search(string searchText);
        public Car UpdateCar(UpdateCarViewModel model);
        public void DeleteCar(int id);
        public List<CarViewModel> GetAllCar();
    }
}
